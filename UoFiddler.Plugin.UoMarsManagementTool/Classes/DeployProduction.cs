using System;
using System.Collections.Generic;
using System.IO;
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
        private string RemotePath;
        private List<string> FilesList;

        public TextBox EventTextBox;
        public Label DeployButtonComputing;

        public DeployProduction(string serverIp, int serverPort, string serverUsername, string serverPassword, string remotePath, string localFolder, string remoteScript)
        {
            ServerIp = serverIp;
            ServerPort = serverPort;
            ServerUsername = serverUsername;
            ServerPassword = serverPassword;
            RemotePath = remotePath;
            LocalFolder = localFolder;
            RemoteScript = remoteScript;
        }

        public void Deploy()
        {
            try
            {
                ElaborateFilesList();
                if (FilesList.Count <= 0) return;
                if (!RemotePath.EndsWith("/")) RemotePath += "/";
                
                ComputingMessage("Connessione in corso...");
                var client = new SftpClient(ServerIp, ServerPort, ServerUsername, ServerPassword);
                client.Connect();
                if(client.IsConnected)
                {
                    ComputingMessage("Connesso!");
                    
                    try
                    {
                        client.ChangeDirectory(RemotePath);
                    }
                    catch
                    {
                        Error($"La cartella remota scelta ({RemotePath}) non esiste nel server di destinazione");
                        return;
                    }

                    EventMessage($"{FilesList.Count} files trovati da caricare");
                    foreach (string filePath in FilesList)
                    {
                        FileInfo f = new FileInfo(filePath);
                        var fileStream = new FileStream(f.FullName, FileMode.Open);  
                        if(fileStream != null)
                        {
                            ComputingMessage($"Carico: {f.FullName}");
                            //If you have a folder located at sftp://ftp.example.com/share
                            //then you can add this like:
                            client.UploadFile(fileStream, RemotePath + f.Name, null);
                            
                            fileStream.Close();
                            ComputingMessage($"Caricato: {f.FullName}");
                            EventMessage($"{f.FullName} caricato");
                        }
                    }
                    
                    client.Disconnect();
                    client.Dispose();
                    
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
            }
            catch (Exception connectionException)
            {
                Error(connectionException.Message);
            }   
        }

        private void ElaborateFilesList()
        {
            FilesList = new List<string>();

            if (!Directory.Exists(LocalFolder))
            {
                Error($"La cartella locale scelta non esiste");
                return;
            }
            
            // Getting all files inside the folder
            FilesList = Directory.GetFiles(LocalFolder).ToList();
            
            if (FilesList.Count <= 0)
            {
                Error($"Non ci sono file da caricare nella cartella locale scelta");
            }
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