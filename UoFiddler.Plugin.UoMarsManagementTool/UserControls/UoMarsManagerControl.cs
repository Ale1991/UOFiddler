// /***************************************************************************
//  *
//  * $Author: Hurricane
//  *
//  ***************************************************************************/

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UoFiddler.Plugin.UopPacker.Classes;
using System.Configuration;
using System.Collections.Specialized;
using System.Diagnostics;

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
        private void CentredServerBtn_Click(object sender, EventArgs e)
        {
            if (CentredServerExeFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                CentredServerTextBox.Text = CentredServerExeFolderBrowserDialog.SelectedPath;
            }
        }
        private void CentredServer2Btn_Click(object sender, EventArgs e)
        {
            if (CentredServer2ExeFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                CentredServer2TextBox.Text = CentredServer2ExeFolderBrowserDialog.SelectedPath;
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
            OpenServUOExe();
            OpenPyFileHasher();
            OpenCentredServer();
            OpenCentredServer2();
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
        private void OpenCentredServer()
        {
            if (CentredServerTextBox.Text != null && Directory.Exists(CentredServerTextBox.Text))
            {
                string path = Path.Combine(CentredServerTextBox.Text, "cedserver.exe");
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
                    eventTextBox.Text += $"cedserver.exe 1 started" + Environment.NewLine;
                }
                else
                    eventTextBox.Text += $"cedserver.exe 1 start failed: File not exists" + Environment.NewLine;
            }
            else
                eventTextBox.Text += $"cedserver.exe 1 start failed: Directory not exists" + Environment.NewLine;
        }
        private void OpenCentredServer2()
        {
            if (CentredServer2TextBox.Text != null && Directory.Exists(CentredServer2TextBox.Text))
            {
                string path = Path.Combine(CentredServer2TextBox.Text, "cedserver.exe");
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
                    eventTextBox.Text += $"cedserver.exe 2 started" + Environment.NewLine;
                }
                else
                    eventTextBox.Text += $"cedserver.exe 2 start failed: File not exists" + Environment.NewLine;
            }
            else
                eventTextBox.Text += $"cedserver.exe 2 start failed: Directory not exists" + Environment.NewLine;
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

                if (eventTextBox != null)
                    eventTextBox.Text += $"{fileName} Copied in {new DirectoryInfo(ServUoFileFolderTextBox.Text).Name}" + Environment.NewLine;
            }
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
            Pack("gumpart.mul", "gumpidx.mul", Path.Combine(UoMarsClientFileFolderTextBox.Text, "gumpartLegacyMUL.uop"), FileType.GumpartLegacyMul, 0);
            Pack("sound.mul", "soundidx.mul", Path.Combine(UoMarsClientFileFolderTextBox.Text, "soundLegacyMUL.uop"), FileType.SoundLegacyMul, 0);

            for (int i = 0; i <= 5; ++i)
            {
                string map = $"map{i}";
                Pack(map + ".mul", null, Path.Combine(UoMarsClientFileFolderTextBox.Text, map + "LegacyMUL.uop"), FileType.MapLegacyMul, i);
                Pack(map + "x.mul", null, Path.Combine(UoMarsClientFileFolderTextBox.Text, map + "xLegacyMUL.uop"), FileType.MapLegacyMul, i);
            }
            ComputingTextBox.Text = $"Done ({_success}/{_total} files packed)";
        }
        #endregion

        #region Setting/Input Methods
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

            if (CentredServerTextBox.Text?.Length == 0 || CentredServerTextBox.Text == null)
            {
                MessageBox.Show("You must specify the CentredServer.exe Folder");
                return false;
            }
            else
            {
                AddUpdateAppSettings("CentredServerTextBox.Text", CentredServerTextBox.Text);
            }

            if (CentredServer2TextBox.Text?.Length == 0 || CentredServer2TextBox.Text == null)
            {
                MessageBox.Show("You must specify the CentredServer2.exe Folder");
                return false;
            }
            else
            {
                AddUpdateAppSettings("CentredServer2TextBox.Text", CentredServer2TextBox.Text);
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
                            case "CentredServerTextBox.Text":
                                CentredServerTextBox.Text = appSettings[key];
                                break;
                            case "CentredServer2TextBox.Text":
                                CentredServer2TextBox.Text = appSettings[key];
                                break;
                            case "pyFileHasherTextBox.Text":
                                pyFileHasherTextBox.Text = appSettings[key];
                                break;
                            case "ServUOExeTextBox.Text":
                                ServUOExeTextBox.Text = appSettings[key];
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
