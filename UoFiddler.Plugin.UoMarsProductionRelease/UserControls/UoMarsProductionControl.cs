using System;
using System.IO;
using System.Windows.Forms;

namespace UoFiddler.Plugin.UoMarsProductionRelease.UserControls
{
    public partial class UoMarsProductionControl : UserControl
    {
        public UoMarsProductionControl()
        {
            
        }
        
        #region UI Button Click Event
        private void ReleaseProd_Click(object sender, EventArgs e)
        {
            string ftpServerIP = "Target IP";
            int ftpPortNumber = 80;//change to appropriate port number
            string ftpUsername = "FTP USer Name";//
            string ftpPassword = "FTP Password";
            
            if (eventTextBox != null && eventTextBox.Text != null) eventTextBox.Text = String.Empty;

            try
            {
                /*var client = new SftpClient(ftpServerIP, ftpPortNumber, ftpUsername, ftpPassword);
                client.Connect();
                if(client.IsConnected)
                {
                    FileInfo f = new FileInfo("C:\\mdu\\abcd.xml");        
                    var fileStream = new FileStream(f.FullName, FileMode.Open);  
                    if(fileStream != null)
                    {
                        //If you have a folder located at sftp://ftp.example.com/share
                        //then you can add this like:
                        client.UploadFile(fileStream, "/share/" + f.Name,null);
                        client.Disconnect();
                        client.Dispose();
                    }
                }*/
            }
            catch (Exception connectionException)
            {
                if (eventTextBox != null)
                {
                    eventTextBox.Text += "Errore connessione al server remoto:" + Environment.NewLine;
                    eventTextBox.Text += connectionException.Message + Environment.NewLine;
                }
            }
        }
        #endregion
    }
}
