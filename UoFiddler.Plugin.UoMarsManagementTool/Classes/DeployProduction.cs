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

        public void PullCode()
        {
            try
            {
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
            }
            catch (Exception connectionException)
            {
                Error(connectionException.Message);
            }
                
            EventMessage("Pull code avviato!");
            ComputingMessage("Pull code avviato!");
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
            if (!Directory.Exists(LocalFolder))
            {
                Error($"La cartella locale scelta non esiste");
                return false;
            }
            
            // Getting all files inside the folder
            List<string> directories = Directory.GetDirectories(LocalFolder).ToList();
            
            if (directories.Count <= 0)
            {
                Error($"Non ci sono file da caricare nella cartella locale scelta, skipping");
                return false;
            }

            // Creating folder to compress
            EventMessage("Genero package con i files...");
            
            // zipping server folder
            if(Directory.Exists(Path.Combine(LocalFolder, "server")))
                ZipFile.CreateFromDirectory(Path.Combine(LocalFolder, "server"), Path.Combine(LocalFolder, "server.zip"));
            
            // zipping client folder
            if(Directory.Exists(Path.Combine(LocalFolder, "client")))
                ZipFile.CreateFromDirectory(Path.Combine(LocalFolder, "client"), Path.Combine(LocalFolder, "client.zip"));

            // Creating final folder
            string destinationFolder = Path.Combine(LocalFolder, "deploy_latest");
            Directory.CreateDirectory(destinationFolder);
            
            // Moving zip files inside the final folder
            if(File.Exists(Path.Combine(LocalFolder, "server.zip")))
                File.Move(Path.Combine(LocalFolder, "server.zip"), Path.Combine(destinationFolder, "server.zip"));
            
            if(File.Exists(Path.Combine(LocalFolder, "client.zip")))
                File.Move(Path.Combine(LocalFolder, "client.zip"), Path.Combine(destinationFolder, "client.zip"));
        
            // Compressing folder
            ZipFile.CreateFromDirectory(destinationFolder, destinationFolder + ".zip");

            EventMessage($"Package generato! ({destinationFolder}.zip)");
            
            // Moving file as _latest to the pyFileHasher Folder
            if (PyFileHasherFolder.Length > 0)
            {
                string filename = Path.Combine(PyFileHasherFolder, "deploy_latest.zip");
                if(File.Exists(filename)) File.Delete(filename);
                
                File.Move(Path.Combine(LocalFolder, "deploy_latest.zip"), filename);
            }

            // Cleaning up
            if(Directory.Exists(destinationFolder))
                Directory.Delete(destinationFolder, true);
            if(Directory.Exists(Path.Combine(LocalFolder, "client")))
                Directory.Delete(Path.Combine(LocalFolder, "client"), true);
            if(Directory.Exists(Path.Combine(LocalFolder, "server")))
                Directory.Delete(Path.Combine(LocalFolder, "server"), true);
            
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