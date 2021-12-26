// /***************************************************************************
//  *
//  * $Author: Hurricane
//  *
//  ***************************************************************************/

using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using UoFiddler.Plugin.UopPacker.Classes;
using System.Configuration;
using System.Diagnostics;
using Renci.SshNet;
using UoFiddler.Plugin.UoMarsManagementTool.Classes;

namespace UoFiddler.Plugin.UoMarsManagementTool.UserControls
{
    public partial class UoMarsManagerControl : UserControl
    {
        private readonly string[] mulFileForServUoFileFolder = { "map0.mul", "map1.mul", "map2.mul", "map3.mul", "map4.mul", "map5.mul",
                                    "staidx0.mul", "staidx1.mul", "staidx2.mul", "staidx3.mul", "staidx4.mul", "staidx5.mul",
                                    "statics0.mul", "statics1.mul", "statics2.mul", "statics3.mul", "statics4.mul", "statics5.mul"};
        
        private readonly string[] mulFileForUoMarsClientFileFolder = {"staidx0.mul", "staidx1.mul", "staidx2.mul", "staidx3.mul", "staidx4.mul", "staidx5.mul",
                                    "statics0.mul", "statics1.mul", "statics2.mul", "statics3.mul", "statics4.mul", "statics5.mul"};

        private readonly string[] processToKill = { "py", "cedserver", "ServUO", "node", "cmd"};
        private int _total;
        private int _success;

        public UoMarsManagerControl()
        {
            InitializeComponent();

            ReadAllSettings();
        }

        #region UI Button Click Event
        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (eventTextBox != null && eventTextBox.Text != null)
                eventTextBox.Text = String.Empty;

            CloseAllProcess();

            if (CheckAllInputFolder())
                PackMulToUopForUoMarsClientFileFolder();

            MoveFiles();

            OpenAllProcess();
        }
        private void selectCentredFileFolderBtn_Click(object sender, EventArgs e)
        {
            if (CentredFileFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                CentredFileFolderTextBox.Text = CentredFileFolderBrowserDialog.SelectedPath;
            }
        }
        private void selectUoMarsClientFileFolderBtn_Click(object sender, EventArgs e)
        {
            if (UoMarsFileFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                UoMarsClientFileFolderTextBox.Text = UoMarsFileFolderBrowserDialog.SelectedPath;
            }
        }
        private void ServUoFileFolderBtn_Click(object sender, EventArgs e)
        {
            if (ServUoFileFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                ServUoFileFolderTextBox.Text = ServUoFileFolderBrowserDialog.SelectedPath;
            }
        }
        private void CentredServerFeluccaBtn_Click(object sender, EventArgs e)
        {
            if (CentredServerFeluccaExeFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                CentredServerFeluccaTextBox.Text = CentredServerFeluccaExeFolderBrowserDialog.SelectedPath;
            }
        }
        private void CentredServerTrammelBtn_Click(object sender, EventArgs e)
        {
            if (CentredServerTrammelExeFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                CentredServerTrammelTextBox.Text = CentredServerTrammelExeFolderBrowserDialog.SelectedPath;
            }
        }
        private void CentredServerIlshenarBtn_Click(object sender, EventArgs e)
        {
            if (CentredServerIlshenarExeFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                CentredServerIlshenarTextBox.Text = CentredServerIlshenarExeFolderBrowserDialog.SelectedPath;
            }
        }
        private void pyFileHasherBtn_Click(object sender, EventArgs e)
        {
            if (pyFileHasherFileFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                pyFileHasherTextBox.Text = pyFileHasherFileFolderBrowserDialog.SelectedPath;
            }
        }
        private void ServUOExeBtn_Click(object sender, EventArgs e)
        {
            if (ServUoFileFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                ServUOExeTextBox.Text = ServUoFileFolderBrowserDialog.SelectedPath;
            }
        }
        
        private void BackupBtn_Click(object sender, EventArgs e)
        {
            if (BackupFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                BackupTextBox.Text = BackupFolderBrowserDialog.SelectedPath;
            }
        }
        
        private void SelectLocalFolderBtn_Click(object sender, EventArgs e)
        {
            if (DeployLocalFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                DeployLocalFolderTextBox.Text = DeployLocalFolderBrowserDialog.SelectedPath;
            }
        }

        private void DeployProduction_Click(object sender, EventArgs e)
        {
            SaveDeploySettings();
            if (DeployButtonComputing != null && DeployButtonComputing.Text != null) DeployButtonComputing.Text = String.Empty;
            if (eventTextBox != null && eventTextBox.Text != null) eventTextBox.Text = String.Empty;
            
            #region ValidatingFields
            // validating fields
            string serverIp = DeployIpTextBox?.Text;
            if (String.IsNullOrEmpty(serverIp))
            {
                if (DeployButtonComputing != null) DeployButtonComputing.Text += "Errore!";
                if (eventTextBox != null)
                {
                    eventTextBox.Text += "Errore nella connessione al server remoto:" + Environment.NewLine;
                    eventTextBox.Text += "Aggiungi un Server IP valido";
                }
                
                MessageBox.Show("Aggiungi un Server IP valido");
                return;
            }

            int serverPort = 0;
            try
            {
                serverPort = Int32.Parse(DeployIpPortTextBox.Text);
                if (serverPort <= 0)
                {
                    if (DeployButtonComputing != null) DeployButtonComputing.Text += "Errore!";
                    if (eventTextBox != null)
                    {
                        eventTextBox.Text += "Errore nella connessione al server remoto:" + Environment.NewLine;
                        eventTextBox.Text += "Aggiungi una Server Port valida";
                    }
                    
                    MessageBox.Show("Aggiungi una Server Port valida");
                    return;
                }
            }
            catch
            {
                if (DeployButtonComputing != null) DeployButtonComputing.Text += "Errore!";
                if (eventTextBox != null)
                {
                    eventTextBox.Text += "Errore nella connessione al server remoto:" + Environment.NewLine;
                    eventTextBox.Text += "Server Port: Inserire un valore intero valido";
                }
                
                MessageBox.Show("Server Port: Inserire un valore intero valido");
                return;
            }

            string serverUsername = DeployUsernameTextBox.Text;
            if (String.IsNullOrEmpty(serverUsername))
            {
                if (DeployButtonComputing != null) DeployButtonComputing.Text += "Errore!";
                if (eventTextBox != null)
                {
                    eventTextBox.Text += "Errore nella connessione al server remoto:" + Environment.NewLine;
                    eventTextBox.Text += "Aggiungi un Server Username valido";
                }
                
                MessageBox.Show("Aggiungi un Server Username valido");
                return;
            }

            string serverPassword = DeployPasswordTextBox.Text;
            if (String.IsNullOrEmpty(serverPassword))
            {
                if (DeployButtonComputing != null) DeployButtonComputing.Text += "Errore!";
                if (eventTextBox != null)
                {
                    eventTextBox.Text += "Errore nella connessione al server remoto:" + Environment.NewLine;
                    eventTextBox.Text += "Aggiungi una Server Password valida";
                }
                
                MessageBox.Show("Aggiungi una Server Password valida");
                return;
            }
            
            string localFolder = DeployLocalFolderTextBox.Text;
            if (String.IsNullOrEmpty(localFolder))
            {
                if (DeployButtonComputing != null) DeployButtonComputing.Text += "Errore!";
                if (eventTextBox != null)
                {
                    eventTextBox.Text += "Errore nella connessione al server remoto:" + Environment.NewLine;
                    eventTextBox.Text += "Aggiungi una cartella locale valida";
                }
                
                MessageBox.Show("Aggiungi una cartella locale valida");
                return;
            }
            #endregion

            DeployProduction deployer = new DeployProduction(
                serverIp, 
                serverPort, 
                serverUsername, 
                serverPassword, 
                localFolder, 
                DeployRemoteScriptTextBox.Text,
                pyFileHasherTextBox?.Text
            )
            {
                DeployButtonComputing = DeployButtonComputing,
                EventTextBox = eventTextBox
            };
            
            deployer.Deploy();
        }
        #endregion

        #region Handle Process Methods
        private void CloseAllProcess()
        {
            var runningProcess = Process.GetProcesses();//.Where(pr =>processToKill.Contains(pr.ProcessName)); // without '.exe'
            foreach (var process in runningProcess)
            {
                bool contains = processToKill.Contains(process.ProcessName);
                if (contains)
                {
                    if (eventTextBox != null)
                        eventTextBox.Text += $"{process.ProcessName} found! Killing..." + Environment.NewLine;
                    process.Kill();
                }
            }
        }

        private void OpenAllProcess()
        {
            OpenServUOCompiler();
            OpenPyFileHasher();
            OpenCentredServerFelucca();
            OpenCentredServerTrammel();
            OpenCentredServerIlshenar();
        }

        private void OpenServUOExe()
        {
            if(ServUOExeTextBox.Text != null && Directory.Exists(ServUOExeTextBox.Text))
            {
                string path = Path.Combine(ServUOExeTextBox.Text, "ServUO.exe");
                if (File.Exists(path))
                {
                    var proc = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = Path.Combine(ServUOExeTextBox.Text, "ServUO.exe"),
                            // Arguments = "checkout AndroidManifest.xml",
                            // UseShellExecute = false,
                            // RedirectStandardOutput = true,
                            // CreateNoWindow = false,
                            // WorkingDirectory = @"C:\MyAndroidApp\"
                        }
                    };
                    proc.Start();
                    eventTextBox.Text += $"ServUO.exe started" + Environment.NewLine;
                }
                else
                    eventTextBox.Text += $"ServUO.exe start failed: File not exists" + Environment.NewLine;
            }
            else
                eventTextBox.Text += $"ServUO.exe start failed: Directory not exists" + Environment.NewLine;

        }
        private void OpenServUOCompiler()
        {
            if(ServUOExeTextBox.Text != null && Directory.Exists(ServUOExeTextBox.Text))
            {
                string path = Path.Combine(ServUOExeTextBox.Text, "Compile_Debug.bat");
                if (File.Exists(path))
                {
                    var proc = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = Path.Combine(ServUOExeTextBox.Text, "Compile_Debug.bat"),
                            // Arguments = "checkout AndroidManifest.xml",
                            // UseShellExecute = false,
                            // RedirectStandardOutput = true,
                            // CreateNoWindow = false,
                            // WorkingDirectory = @"C:\MyAndroidApp\"
                        }
                    };
                    proc.Start();
                    eventTextBox.Text += $"Compile_Debug.bat started" + Environment.NewLine;
                }
                else
                    eventTextBox.Text += $"Compile_Debug.bat start failed: File not exists" + Environment.NewLine;
            }
            else
                eventTextBox.Text += $"Compile_Debug.bat start failed: Directory not exists" + Environment.NewLine;

        }
        private void OpenPyFileHasher()
        {
            if (pyFileHasherTextBox.Text != null && Directory.Exists(pyFileHasherTextBox.Text))
            {
                string path = Path.Combine(pyFileHasherTextBox.Text, "pyFileHasher.py");
                if (File.Exists(path))
                {
                    var proc = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = path,
                            // Arguments = "checkout AndroidManifest.xml",
                            UseShellExecute = true,
                            // RedirectStandardOutput = true,
                            // CreateNoWindow = false,
                            WorkingDirectory = pyFileHasherTextBox.Text
                        }
                    };
                    proc.Start();
                    eventTextBox.Text += $"pyFileHasher.py started" + Environment.NewLine;
                }
                else
                    eventTextBox.Text += $"pyFileHasher.py start failed: File not exists" + Environment.NewLine;
            }
            else
                eventTextBox.Text += $"pyFileHasher.py start failed: Directory not exists" + Environment.NewLine;
        }
        private void OpenCentredServerFelucca()
        {
            if (CentredServerFeluccaTextBox.Text != null && Directory.Exists(CentredServerFeluccaTextBox.Text))
            {
                string path = Path.Combine(CentredServerFeluccaTextBox.Text, "cedserver.exe");
                if (File.Exists(path))
                {
                    var proc = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = path,
                            // Arguments = "checkout AndroidManifest.xml",
                            // UseShellExecute = false,
                            // RedirectStandardOutput = true,
                            // CreateNoWindow = false,
                            // WorkingDirectory = @"C:\MyAndroidApp\"
                        }
                    };
                    proc.Start();
                    eventTextBox.Text += $"cedserver.exe Felucca started" + Environment.NewLine;
                }
                else
                    eventTextBox.Text += $"cedserver.exe Felucca start failed: File not exists" + Environment.NewLine;
            }
            else
                eventTextBox.Text += $"cedserver.exe Felucca start failed: Directory not exists" + Environment.NewLine;
        }
        private void OpenCentredServerTrammel()
        {
            if (CentredServerTrammelTextBox.Text != null && Directory.Exists(CentredServerTrammelTextBox.Text))
            {
                string path = Path.Combine(CentredServerTrammelTextBox.Text, "cedserver.exe");
                if (File.Exists(path))
                {
                    var proc = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = path,
                            // Arguments = "checkout AndroidManifest.xml",
                            // UseShellExecute = false,
                            // RedirectStandardOutput = true,
                            // CreateNoWindow = false,
                            // WorkingDirectory = @"C:\MyAndroidApp\"
                        }
                    };
                    proc.Start();
                    eventTextBox.Text += $"cedserver.exe Trammel started" + Environment.NewLine;
                }
                else
                    eventTextBox.Text += $"cedserver.exe Trammel start failed: File not exists" + Environment.NewLine;
            }
            else
                eventTextBox.Text += $"cedserver.exe Trammel start failed: Directory not exists" + Environment.NewLine;
        }
        private void OpenCentredServerIlshenar()
        {
            if (CentredServerIlshenarTextBox.Text != null && Directory.Exists(CentredServerIlshenarTextBox.Text))
            {
                string path = Path.Combine(CentredServerIlshenarTextBox.Text, "cedserver.exe");
                if (File.Exists(path))
                {
                    var proc = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = path,
                            // Arguments = "checkout AndroidManifest.xml",
                            // UseShellExecute = false,
                            // RedirectStandardOutput = true,
                            // CreateNoWindow = false,
                            // WorkingDirectory = @"C:\MyAndroidApp\"
                        }
                    };
                    proc.Start();
                    eventTextBox.Text += $"cedserver.exe Ilshenar started" + Environment.NewLine;
                }
                else
                    eventTextBox.Text += $"cedserver.exe Ilshenar start failed: File not exists" + Environment.NewLine;
            }
            else
                eventTextBox.Text += $"cedserver.exe Ilshenar start failed: Directory not exists" + Environment.NewLine;
        }
        #endregion

        #region File Packing/Moving Method
        private bool areUpdated(string inFile, string outFile)
        {
            if (File.Exists(inFile) && File.Exists(outFile))
            {
                if (File.GetLastWriteTime(inFile) == File.GetLastWriteTime(outFile))
                    return true;
                else
                    return false;
            }
            return false;
        }
        private void MoveFileFromCentredToUoMarsClientFileFolder(string file, string fileName)
        {
            if (UoMarsClientFileFolderTextBox.Text?.Length != 0 && UoMarsClientFileFolderTextBox.Text != null
                && Directory.Exists(UoMarsClientFileFolderTextBox.Text))
            {
                string destFilePath = Path.Combine(UoMarsClientFileFolderTextBox.Text, fileName);

                if (File.Exists(destFilePath))
                {

                    if(areUpdated(file, destFilePath))
                    {
                        if (eventTextBox != null)
                            eventTextBox.Text += $"{fileName} exists and it's already updated in {new DirectoryInfo(UoMarsClientFileFolderTextBox.Text).Name}" + Environment.NewLine;
                    }
                    else
                    {
                        if (eventTextBox != null)
                            eventTextBox.Text += $"{fileName} found {new DirectoryInfo(UoMarsClientFileFolderTextBox.Text).Name}! Deleting..." + Environment.NewLine;

                        File.Delete(destFilePath);
                        File.Copy(file, destFilePath);

                        if (eventTextBox != null)
                            eventTextBox.Text += $"{fileName} Copied in {new DirectoryInfo(UoMarsClientFileFolderTextBox.Text).Name}" + Environment.NewLine;
                    }
                }
                else
                {
                    File.Copy(file, destFilePath);

                    if (eventTextBox != null)
                        eventTextBox.Text += $"{fileName} not exists in {new DirectoryInfo(UoMarsClientFileFolderTextBox.Text).Name}. Copied" + Environment.NewLine;
                }
                
                // moving into backup folder
                MoveFileToBackupFolder(file, Path.GetFileName(file));
            }
        }
        private void MoveFileFromCentredToServUoFileFolder(string file, string fileName)
        {
            if (ServUoFileFolderTextBox.Text?.Length != 0 && ServUoFileFolderTextBox.Text != null
                && Directory.Exists(ServUoFileFolderTextBox.Text))
            {
                string destFilePath = Path.Combine(ServUoFileFolderTextBox.Text, fileName);

                if (File.Exists(destFilePath))
                {
                    if (eventTextBox != null)
                        eventTextBox.Text += $"{fileName} found in {new DirectoryInfo(ServUoFileFolderTextBox.Text).Name}! Deleting..." + Environment.NewLine;

                    File.Delete(destFilePath);
                }

                File.Copy(file, destFilePath);
                
                // moving into backup folder
                MoveFileToBackupFolder(file, Path.GetFileName(file));

                if (eventTextBox != null)
                    eventTextBox.Text += $"{fileName} Copied in {new DirectoryInfo(ServUoFileFolderTextBox.Text).Name}" + Environment.NewLine;
            }
        }

        private void MoveFileToBackupFolder(string file, string fileName)
        {
            if(BackupTextBox?.Text != null && BackupTextBox.Text.Length <= 0 || !Directory.Exists(BackupTextBox.Text)) return;
            if (!File.Exists(file)) return;
            
            string destFilePath = Path.Combine(BackupTextBox.Text, fileName);

            if (File.Exists(destFilePath)) File.Delete(destFilePath);
            File.Copy(file, destFilePath);

            if (eventTextBox != null)
                eventTextBox.Text += $"{fileName} Copied in {new DirectoryInfo(BackupTextBox.Text).Name}" + Environment.NewLine;
            
        }
        
        private void MoveFiles()
        {
            if (CentredFileFolderTextBox.Text?.Length != 0 && CentredFileFolderTextBox.Text != null
                && Directory.Exists(CentredFileFolderTextBox.Text))
            {
                string[] files = Directory.GetFiles(CentredFileFolderTextBox.Text);
                foreach (string file in files)
                {
                    if (mulFileForUoMarsClientFileFolder.Contains(Path.GetFileName(file)))
                        MoveFileFromCentredToUoMarsClientFileFolder(file, Path.GetFileName(file));

                    if (mulFileForServUoFileFolder.Contains(Path.GetFileName(file)))
                        MoveFileFromCentredToServUoFileFolder(file, Path.GetFileName(file));
                }
            }
        }
        private string FixPath(string file)
        {
            return (file == null) ? null : Path.Combine(CentredFileFolderTextBox.Text, file);
        } 
        private void Pack(string inFile, string inIdx, string outFile, FileType type, int typeIndex)
        {
            try
            {
                bool convertFile = true;

                ComputingTextBox.Text = inFile;
                Refresh();
                inFile = FixPath(inFile);

                if (!File.Exists(inFile))
                {
                    return;
                }

                outFile = FixPath(outFile);

                if (File.Exists(outFile))
                {

                    if(areUpdated(inFile, outFile))
                    {
                        if (eventTextBox != null)
                            eventTextBox.Text += $"{Path.GetFileName(outFile)} exists and its uop is already updated" + Environment.NewLine;

                        convertFile = false;
                    }
                    else
                    {
                        if (eventTextBox != null)
                            eventTextBox.Text += $"{Path.GetFileName(outFile)} found in {new DirectoryInfo(Path.GetDirectoryName(outFile)).Name}! Deleting..." + Environment.NewLine;
                        File.Delete(outFile);
                    }

                }
                else
                {
                    if (eventTextBox != null)
                        eventTextBox.Text += $"{Path.GetFileName(outFile)} not found. Creating..." + Environment.NewLine;
                }

                if(convertFile)
                {
                    inIdx = FixPath(inIdx);
                    ++_total;

                    LegacyMulFileConverter.ToUOP(inFile, inIdx, outFile, type, typeIndex);

                    eventTextBox.Text += $"{Path.GetFileName(outFile)} Created in {new DirectoryInfo(Path.GetDirectoryName(outFile)).Name}" + Environment.NewLine;

                    // set same date of generator file
                    File.SetLastWriteTime(outFile, File.GetLastWriteTime(inFile));

                    ++_success;
                }


            }
            catch (Exception e)
            {
                MessageBox.Show($"An error occured while performing the action.\r\n{e.Message}");
            }
        }
        private void PackMulToUopForUoMarsClientFileFolder()
        {
            _success = _total = 0;

            Pack("art.mul", "artidx.mul", Path.Combine(UoMarsClientFileFolderTextBox.Text, "artLegacyMUL.uop"), FileType.ArtLegacyMul, 0);
            MoveFileToBackupFolder(Path.Combine(UoMarsClientFileFolderTextBox.Text, "artLegacyMUL.uop"), "artLegacyMUL.uop");

            Pack("gumpart.mul", "gumpidx.mul", Path.Combine(UoMarsClientFileFolderTextBox.Text, "gumpartLegacyMUL.uop"), FileType.GumpartLegacyMul, 0);
            MoveFileToBackupFolder(Path.Combine(UoMarsClientFileFolderTextBox.Text, "gumpartLegacyMUL.uop"), "gumpartLegacyMUL.uop");

            Pack("sound.mul", "soundidx.mul", Path.Combine(UoMarsClientFileFolderTextBox.Text, "soundLegacyMUL.uop"), FileType.SoundLegacyMul, 0);
            MoveFileToBackupFolder(Path.Combine(UoMarsClientFileFolderTextBox.Text, "soundLegacyMUL.uop"), "soundLegacyMUL.uop");

            for (int i = 0; i <= 5; ++i)
            {
                string map = $"map{i}";
                Pack(map + ".mul", null, Path.Combine(UoMarsClientFileFolderTextBox.Text, map + "LegacyMUL.uop"), FileType.MapLegacyMul, i);
                MoveFileToBackupFolder(Path.Combine(UoMarsClientFileFolderTextBox.Text, map + "LegacyMUL.uop"), map + "LegacyMUL.uop");

                Pack(map + "x.mul", null, Path.Combine(UoMarsClientFileFolderTextBox.Text, map + "xLegacyMUL.uop"), FileType.MapLegacyMul, i);
                MoveFileToBackupFolder(Path.Combine(UoMarsClientFileFolderTextBox.Text, map + "xLegacyMUL.uop"),map + "xLegacyMUL.uop");
            }
            
            ComputingTextBox.Text = $"Done ({_success}/{_total} files packed)";
        }
        #endregion

        #region Setting/Input Methods

        private void SaveDeploySettings()
        {
            AddUpdateAppSettings("DeployIpTextBox.Text", DeployIpTextBox.Text);
            AddUpdateAppSettings("DeployIpPortTextBox.Text", DeployIpPortTextBox.Text);
            AddUpdateAppSettings("DeployUsernameTextBox.Text", DeployUsernameTextBox.Text);
            AddUpdateAppSettings("DeployLocalFolderTextBox.Text", DeployLocalFolderTextBox.Text);
            AddUpdateAppSettings("DeployRemoteScriptTextBox.Text", DeployRemoteScriptTextBox.Text);
        }
        
        private bool CheckAllInputFolder()
        {
            if (CentredFileFolderTextBox.Text?.Length == 0 || CentredFileFolderTextBox.Text == null)
            {
                MessageBox.Show("You must specify the Centred File Folder");
                return false;
            }
            else
            {
                AddUpdateAppSettings("CentredFileFolderTextBox.Text", CentredFileFolderTextBox.Text);
            }

            if (UoMarsClientFileFolderTextBox.Text?.Length == 0 || UoMarsClientFileFolderTextBox.Text == null)
            {
                MessageBox.Show("You must specify the UoMarsClient File Folder");
                return false;
            }
            else
            {
                AddUpdateAppSettings("UoMarsClientFileFolderTextBox.Text", UoMarsClientFileFolderTextBox.Text);
            }

            if (ServUoFileFolderTextBox.Text?.Length == 0 || ServUoFileFolderTextBox.Text == null)
            {
                MessageBox.Show("You must specify the ServUo File Folder");
                return false;
            }
            else
            {
                AddUpdateAppSettings("ServUoFileFolderTextBox.Text", ServUoFileFolderTextBox.Text);
            }

            if (CentredServerFeluccaTextBox.Text?.Length == 0 || CentredServerFeluccaTextBox.Text == null)
            {
                MessageBox.Show("You must specify the CentredServer.exe Folder");
                return false;
            }
            else
            {
                AddUpdateAppSettings("CentredServerFeluccaTextBox.Text", CentredServerFeluccaTextBox.Text);
            }

            if (CentredServerTrammelTextBox.Text?.Length == 0 || CentredServerTrammelTextBox.Text == null)
            {
                MessageBox.Show("You must specify the CentredServerTrammel.exe Folder");
                return false;
            }
            else
            {
                AddUpdateAppSettings("CentredServerTrammelTextBox.Text", CentredServerTrammelTextBox.Text);
            }
            
            if (CentredServerIlshenarTextBox.Text?.Length == 0 || CentredServerIlshenarTextBox.Text == null)
            {
                MessageBox.Show("You must specify the CentredServerIlshenar.exe Folder");
                return false;
            }
            else
            {
                AddUpdateAppSettings("CentredServerIlshenarTextBox.Text", CentredServerIlshenarTextBox.Text);
            }

            if (pyFileHasherTextBox.Text?.Length == 0 || pyFileHasherTextBox.Text == null)
            {
                MessageBox.Show("You must specify the pyFileHasher.py Folder");
                return false;
            }
            else
            {
                AddUpdateAppSettings("pyFileHasherTextBox.Text", pyFileHasherTextBox.Text);
            }

            if (ServUOExeTextBox.Text?.Length == 0 || ServUOExeTextBox.Text == null)
            {
                MessageBox.Show("You must specify the pyFileHasher.py Folder");
                return false;
            }
            else
            {
                AddUpdateAppSettings("ServUOExeTextBox.Text", ServUOExeTextBox.Text);
            }
            
            if (BackupTextBox?.Text?.Length > 0)
            {
                AddUpdateAppSettings("BackupTextBox.Text", BackupTextBox.Text);
            }
            
            return true;
        }
        private void ReadAllSettings()
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;

                if (appSettings.Count == 0)
                {
                    // Console.WriteLine("AppSettings is empty.");
                }
                else
                {
                    foreach (var key in appSettings.AllKeys)
                    {
                        switch (key)
                        {
                            case "CentredFileFolderTextBox.Text":
                                CentredFileFolderTextBox.Text = appSettings[key];
                                break;
                            case "UoMarsClientFileFolderTextBox.Text":
                                UoMarsClientFileFolderTextBox.Text = appSettings[key];
                                break;
                            case "ServUoFileFolderTextBox.Text":
                                ServUoFileFolderTextBox.Text = appSettings[key];
                                break;
                            case "CentredServerFeluccaTextBox.Text":
                                CentredServerFeluccaTextBox.Text = appSettings[key];
                                break;
                            case "CentredServerTrammelTextBox.Text":
                                CentredServerTrammelTextBox.Text = appSettings[key];
                                break;
                            case "CentredServerIlshenarTextBox.Text":
                                CentredServerIlshenarTextBox.Text = appSettings[key];
                                break;
                            case "pyFileHasherTextBox.Text":
                                pyFileHasherTextBox.Text = appSettings[key];
                                break;
                            case "ServUOExeTextBox.Text":
                                ServUOExeTextBox.Text = appSettings[key];
                                break;
                            case "DeployIpTextBox.Text":
                                DeployIpTextBox.Text = appSettings[key];
                                break;
                            case "DeployIpPortTextBox.Text":
                                DeployIpPortTextBox.Text = appSettings[key];
                                break;
                            case "DeployUsernameTextBox.Text":
                                DeployUsernameTextBox.Text = appSettings[key];
                                break;
                            case "DeployLocalFolderTextBox.Text":
                                DeployLocalFolderTextBox.Text = appSettings[key];
                                break;
                            case "DeployRemoteScriptTextBox.Text":
                                DeployRemoteScriptTextBox.Text = appSettings[key];
                                break;
                            case "BackupTextBox.Text":
                                BackupTextBox.Text = appSettings[key];
                                break;
                        }
                    }
                }
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
        }
        private void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }
        #endregion
    }
}
