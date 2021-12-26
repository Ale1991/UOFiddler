using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;
using Renci.SshNet;

namespace UoFiddler.Plugin.UoMarsManagementTool.Classes
{
    public class DeployProduction
    {
        private readonly string ServerIp;
        private readonly int ServerPort;
        private readonly string ServerUsername;
        private readonly string ServerPassword;
        private readonly string LocalFolder;
        private readonly string RemoteScript;
        private readonly string PyFileHasherFolder;
        private List<string> FilesList;
        private string GeneratedDeployFolderName;

        public TextBox EventTextBox;
        public Label DeployButtonComputing;

        public DeployProduction(
            string serverIp, 
            int serverPort, 
            string serverUsername, 
            string serverPassword, 
            string localFolder, 
            string remoteScript,
            string pyFileHasherFolder
        )
        {
            ServerIp = serverIp;
            ServerPort = serverPort;
            ServerUsername = serverUsername;
            ServerPassword = serverPassword;
            LocalFolder = localFolder;
            RemoteScript = remoteScript;
            PyFileHasherFolder = pyFileHasherFolder;
        }

        public void Deploy()
        {
            try
            {
                if (!GenerateAndMovePack()) return;
                
                // files uploaded, updating shard (if file exists)
                if (RemoteScript.Length > 0)
                {
                    ComputingMessage("Lancio comando server fine deploy");
                    EventMessage($"Eseguo comando nel server remoto: {RemoteScript}");

                    SshClient sshClient = new SshClient(ServerIp, ServerPort, ServerUsername, ServerPassword);
                    sshClient.Connect();
                    SshCommand command = sshClient.CreateCommand(RemoteScript);
                    command.Execute();
                    
                    string result = command.Result;
                    if (result.Length == 0) result = "OK";
                    EventMessage($"Risultato comando: {result}");
                }
                else
                {
                    EventMessage($"Nessuno script di fine deploy specificato");
                }
                
                EventMessage("Deploy completato!");
                ComputingMessage("Deploy completato!");
            }
            catch (Exception connectionException)
            {
                Error(connectionException.Message);
            }
        }

        private bool GenerateAndMovePack()
        {
            FilesList = new List<string>();

            if (!Directory.Exists(LocalFolder))
            {
                Error($"La cartella locale scelta non esiste");
                return false;
            }
            
            // Getting all files inside the folder
            FilesList = Directory.GetFiles(LocalFolder).ToList();
            
            if (FilesList.Count <= 0)
            {
                Error($"Non ci sono file da caricare nella cartella locale scelta");
                return false;
            }

            if (FilesList.Where(x => x.EndsWith(".zip")).ToList().Count == 1)
            {
                GeneratedDeployFolderName = Path.GetFileName(FilesList.Where(x => x.EndsWith(".zip")).ToList()[0]);
                EventMessage($"Esiste già un package nella directory... Carico quello! ({GeneratedDeployFolderName})");
            }
            else
            {
                // Creating folder to compress
                EventMessage("Genero package con i files...");
                GeneratedDeployFolderName = "deploy_" + DateTimeOffset.Now.ToUnixTimeMilliseconds();
                string destinationFolder = Path.Combine(LocalFolder, GeneratedDeployFolderName);
                
                Directory.CreateDirectory(destinationFolder);
                foreach (string file in FilesList)
                {
                    File.Move(file, Path.Combine(destinationFolder, Path.GetFileName(file)));
                }
            
                // Compressing folder
                ZipFile.CreateFromDirectory(destinationFolder, destinationFolder+".zip");
            
                // Removing original folder
                Directory.Delete(destinationFolder, true);
                EventMessage($"Package generato! ({destinationFolder}.zip)");
                GeneratedDeployFolderName += ".zip";
            }
            
            // Moving file as _latest to the pyFileHasher Folder
            if (PyFileHasherFolder.Length > 0)
            {
                string filename = Path.Combine(PyFileHasherFolder, "deploy_latest.zip");
                if(File.Exists(filename)) File.Delete(filename);
                
                File.Move(Path.Combine(LocalFolder, GeneratedDeployFolderName), filename);
            }

            return true;
        }

        private void Error(string message)
        {
            if (DeployButtonComputing != null && DeployButtonComputing.Text != null) 
                DeployButtonComputing.Text = "Errore!";
            
            if (EventTextBox != null && EventTextBox.Text != null)
            {
                EventTextBox.Text += "Errore in production deployment:" + Environment.NewLine;
                EventTextBox.Text += message + Environment.NewLine;
            }
        }
        
        private void ComputingMessage(string message)
        {
            if (DeployButtonComputing != null && DeployButtonComputing.Text != null) 
                DeployButtonComputing.Text = message;
        }
        
        private void EventMessage(string message)
        {
            if (EventTextBox != null && EventTextBox.Text != null)
            {
                EventTextBox.Text += message + Environment.NewLine;
            }
        }
    }
}