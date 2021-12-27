// /***************************************************************************
//  *
//  * $Author: Hurricane
//  *
//  ***************************************************************************/


using System.Windows.Forms;

namespace UoFiddler.Plugin.UoMarsManagementTool.UserControls
{
    partial class UoMarsManagerControl
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti
        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            SuspendLayout();
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            
            #region EventBox
            eventTextBox = new System.Windows.Forms.TextBox();
            
            this.eventTextBox.Location = new System.Drawing.Point(490, 20);
            this.eventTextBox.Multiline = true;
            this.eventTextBox.Name = "eventTextBox";
            this.eventTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.eventTextBox.Size = new System.Drawing.Size(300, 230);
            this.eventTextBox.TabIndex = 17;
            #endregion
            
            int currentY = DeclarePatcherDesign(20);
            DrawPatcher();

            currentY += 50;
            
            currentY = DeclareDeployDesign(currentY);
            DrawDeploy();

            Name = "UoMarsManagerControl";
            Size = new System.Drawing.Size(1040, 600);
            ResumeLayout(false);
            PerformLayout();
        }

        #region designs
        private int DeclarePatcherDesign(int currentY)
        {
            #region Initialyze classes
            CentredFileFolderLabel = new System.Windows.Forms.Label();
            CentredFileFolderTextBox = new System.Windows.Forms.TextBox();
            UoMarsClientFileFolderTextBox = new System.Windows.Forms.TextBox();
            UoMarsFileFolderLabel = new System.Windows.Forms.Label();
            selectCentredFileFolderBtn = new System.Windows.Forms.Button();
            selectUoMarsClientFileFolderBtn = new System.Windows.Forms.Button();
            CentredServerFeluccaLabel = new System.Windows.Forms.Label();
            pyFileHasherLabel = new System.Windows.Forms.Label();
            CentredServerFeluccaTextBox = new System.Windows.Forms.TextBox();
            pyFileHasherTextBox = new System.Windows.Forms.TextBox();
            CentredServerFeluccaBtn = new System.Windows.Forms.Button();
            pyFileHasherBtn = new System.Windows.Forms.Button();
            StartBtn = new System.Windows.Forms.Button();
            CentredFileFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            UoMarsFileFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            CentredServerFeluccaExeFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            pyFileHasherFileFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ServUoFileFolder = new System.Windows.Forms.Label();
            ServUoFileFolderTextBox = new System.Windows.Forms.TextBox();
            ServUoFileFolderBtn = new System.Windows.Forms.Button();
            ServUoFileFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ComputingTextBox = new System.Windows.Forms.Label();
            ServUOLabel = new System.Windows.Forms.Label();
            ServUOExeTextBox = new System.Windows.Forms.TextBox();
            ServUOExeBtn = new System.Windows.Forms.Button();
            ServUOExeFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            CentredServerTrammelLabel = new System.Windows.Forms.Label();
            CentredServerTrammelTextBox = new System.Windows.Forms.TextBox();
            CentredServerTrammelBtn = new System.Windows.Forms.Button();
            CentredServerIlshenarLabel = new System.Windows.Forms.Label();
            CentredServerIlshenarTextBox = new System.Windows.Forms.TextBox();
            CentredServerIlshenarBtn = new System.Windows.Forms.Button();
            CentredServerTrammelExeFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            CentredServerIlshenarExeFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            BackupLabel = new System.Windows.Forms.Label();
            BackupTextBox = new System.Windows.Forms.TextBox();
            BackupBtn = new System.Windows.Forms.Button();
            BackupFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            #endregion

            // label
            int labelX = 10;
            int labelWidth = 95;
            int labelHeight = 13;
            
            // input
            int inputX = 145;
            int inputWidth = 300;
            int inputHeight = 20;
                
            // select (...)
            int buttonX = 450;
            int buttonWidth = 30;
            int buttonHeight = 20;

            int labelYModifier = 3;
            
            #region Centred File Folder
            // CentredFileFolderLabel
            this.CentredFileFolderLabel.AutoSize = true;
            this.CentredFileFolderLabel.Location = new System.Drawing.Point(labelX, currentY+labelYModifier);
            this.CentredFileFolderLabel.Name = "CentredFileFolderLabel";
            this.CentredFileFolderLabel.Size = new System.Drawing.Size(labelWidth, labelHeight);
            this.CentredFileFolderLabel.TabIndex = 0;
            this.CentredFileFolderLabel.Text = "Centred File Folder";
            
            // CentredFileFolderTextBox
            this.CentredFileFolderTextBox.Location = new System.Drawing.Point(inputX, currentY);
            this.CentredFileFolderTextBox.Name = "CentredFileFolderTextBox";
            this.CentredFileFolderTextBox.Size = new System.Drawing.Size(inputWidth, inputHeight);
            this.CentredFileFolderTextBox.TabIndex = 1;
            
            // selectCentredFileFolderBtn
            this.selectCentredFileFolderBtn.Location = new System.Drawing.Point(buttonX, currentY);
            this.selectCentredFileFolderBtn.Name = "selectCentredFileFolderBtn";
            this.selectCentredFileFolderBtn.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.selectCentredFileFolderBtn.TabIndex = 4;
            this.selectCentredFileFolderBtn.Text = "...";
            this.selectCentredFileFolderBtn.UseVisualStyleBackColor = true;
            this.selectCentredFileFolderBtn.Click += new System.EventHandler(this.selectCentredFileFolderBtn_Click);
            #endregion

            currentY += 30;
            
            #region Servuo File Folder
            // ServUoFileFolder
            this.ServUoFileFolder.AutoSize = true;
            this.ServUoFileFolder.Location = new System.Drawing.Point(labelX, currentY+labelYModifier);
            this.ServUoFileFolder.Name = "ServUoFileFolder";
            this.ServUoFileFolder.Size = new System.Drawing.Size(labelWidth, labelHeight);
            this.ServUoFileFolder.TabIndex = 13;
            this.ServUoFileFolder.Text = "ServUo File Folder";
            
            // ServUoFileFolderTextBox
            this.ServUoFileFolderTextBox.Location = new System.Drawing.Point(inputX, currentY);
            this.ServUoFileFolderTextBox.Name = "ServUoFileFolderTextBox";
            this.ServUoFileFolderTextBox.Size = new System.Drawing.Size(inputWidth, inputHeight);
            this.ServUoFileFolderTextBox.TabIndex = 14;
            
            // ServUoFileFolderBtn
            this.ServUoFileFolderBtn.Location = new System.Drawing.Point(buttonX, currentY);
            this.ServUoFileFolderBtn.Name = "ServUoFileFolderBtn";
            this.ServUoFileFolderBtn.Size = new System.Drawing.Size(31, 20);
            this.ServUoFileFolderBtn.TabIndex = 15;
            this.ServUoFileFolderBtn.Text = "...";
            this.ServUoFileFolderBtn.UseVisualStyleBackColor = true;
            this.ServUoFileFolderBtn.Click += new System.EventHandler(this.ServUoFileFolderBtn_Click);
            #endregion
            
            currentY += 30;
            
            #region UoMars Client File Folder
            // UoMarsFileFolderLabel
            this.UoMarsFileFolderLabel.AutoSize = true;
            this.UoMarsFileFolderLabel.Location = new System.Drawing.Point(labelX, currentY+labelYModifier);
            this.UoMarsFileFolderLabel.Name = "UoMarsFileFolderLabel";
            this.UoMarsFileFolderLabel.Size = new System.Drawing.Size(labelWidth, labelHeight);
            this.UoMarsFileFolderLabel.TabIndex = 3;
            this.UoMarsFileFolderLabel.Text = "UoMars Client File Folder";
            
            // UoMarsClientFileFolderTextBox
            this.UoMarsClientFileFolderTextBox.Location = new System.Drawing.Point(inputX, currentY);
            this.UoMarsClientFileFolderTextBox.Name = "UoMarsClientFileFolderTextBox";
            this.UoMarsClientFileFolderTextBox.Size = new System.Drawing.Size(inputWidth, inputHeight);
            this.UoMarsClientFileFolderTextBox.TabIndex = 2;
            
            // selectUoMarsClientFileFolderBtn
            this.selectUoMarsClientFileFolderBtn.Location = new System.Drawing.Point(buttonX, currentY);
            this.selectUoMarsClientFileFolderBtn.Name = "selectUoMarsClientFileFolderBtn";
            this.selectUoMarsClientFileFolderBtn.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.selectUoMarsClientFileFolderBtn.TabIndex = 5;
            this.selectUoMarsClientFileFolderBtn.Text = "...";
            this.selectUoMarsClientFileFolderBtn.UseVisualStyleBackColor = true;
            this.selectUoMarsClientFileFolderBtn.Click += new System.EventHandler(this.selectUoMarsClientFileFolderBtn_Click);
            #endregion
            
            currentY += 30;
            
            #region Centred Felucca
            // CentredServerFeluccaLabel
            this.CentredServerFeluccaLabel.AutoSize = true;
            this.CentredServerFeluccaLabel.Location = new System.Drawing.Point(labelX, currentY+labelYModifier);
            this.CentredServerFeluccaLabel.Name = "CentredServerFeluccaLabel";
            this.CentredServerFeluccaLabel.Size = new System.Drawing.Size(labelWidth, labelHeight);
            this.CentredServerFeluccaLabel.TabIndex = 6;
            this.CentredServerFeluccaLabel.Text = "Centred Felucca";
            
            // CentredServerFeluccaTextBox
            this.CentredServerFeluccaTextBox.Location = new System.Drawing.Point(inputX, currentY);
            this.CentredServerFeluccaTextBox.Name = "CentredServerFeluccaTextBox";
            this.CentredServerFeluccaTextBox.Size = new System.Drawing.Size(inputWidth, inputHeight);
            this.CentredServerFeluccaTextBox.TabIndex = 8;
            
            // CentredServerFeluccaBtn
            this.CentredServerFeluccaBtn.Location = new System.Drawing.Point(buttonX, currentY);
            this.CentredServerFeluccaBtn.Name = "CentredServerFeluccaBtn";
            this.CentredServerFeluccaBtn.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.CentredServerFeluccaBtn.TabIndex = 10;
            this.CentredServerFeluccaBtn.Text = "...";
            this.CentredServerFeluccaBtn.UseVisualStyleBackColor = true;
            this.CentredServerFeluccaBtn.Click += new System.EventHandler(this.CentredServerFeluccaBtn_Click);
            #endregion
            
            currentY += 30;
            
            #region Centred Trammel
            // CentredServerTrammelLabel
            this.CentredServerTrammelLabel.AutoSize = true;
            this.CentredServerTrammelLabel.Location = new System.Drawing.Point(labelX, currentY+labelYModifier);
            this.CentredServerTrammelLabel.Name = "CentredServerTrammelLabel";
            this.CentredServerTrammelLabel.Size = new System.Drawing.Size(labelWidth, labelHeight);
            this.CentredServerTrammelLabel.TabIndex = 21;
            this.CentredServerTrammelLabel.Text = "Centred Trammel";
            
            // CentredServerTrammelTextBox
            this.CentredServerTrammelTextBox.Location = new System.Drawing.Point(inputX, currentY);
            this.CentredServerTrammelTextBox.Name = "CentredServerTrammelTextBox";
            this.CentredServerTrammelTextBox.Size = new System.Drawing.Size(inputWidth, inputHeight);
            this.CentredServerTrammelTextBox.TabIndex = 22;
            
            // CentredServerTrammelBtn
            this.CentredServerTrammelBtn.Location = new System.Drawing.Point(buttonX, currentY);
            this.CentredServerTrammelBtn.Name = "CentredServerTrammelBtn";
            this.CentredServerTrammelBtn.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.CentredServerTrammelBtn.TabIndex = 23;
            this.CentredServerTrammelBtn.Text = "...";
            this.CentredServerTrammelBtn.UseVisualStyleBackColor = true;
            this.CentredServerTrammelBtn.Click += new System.EventHandler(this.CentredServerTrammelBtn_Click);
            #endregion

            currentY += 30;
            
            #region Centred Ilshenar
            // CentredServerTrammelLabel
            this.CentredServerIlshenarLabel.AutoSize = true;
            this.CentredServerIlshenarLabel.Location = new System.Drawing.Point(labelX, currentY+labelYModifier);
            this.CentredServerIlshenarLabel.Name = "CentredServerTrammelLabel";
            this.CentredServerIlshenarLabel.Size = new System.Drawing.Size(labelWidth, labelHeight);
            this.CentredServerIlshenarLabel.TabIndex = 21;
            this.CentredServerIlshenarLabel.Text = "Centred Ilshenar";
            
            // CentredServerTrammelTextBox
            this.CentredServerIlshenarTextBox.Location = new System.Drawing.Point(inputX, currentY);
            this.CentredServerIlshenarTextBox.Name = "CentredServerIlshenarTextBox";
            this.CentredServerIlshenarTextBox.Size = new System.Drawing.Size(inputWidth, inputHeight);
            this.CentredServerIlshenarTextBox.TabIndex = 22;
            
            // CentredServerTrammelBtn
            this.CentredServerIlshenarBtn.Location = new System.Drawing.Point(buttonX, currentY);
            this.CentredServerIlshenarBtn.Name = "CentredServerTrammelBtn";
            this.CentredServerIlshenarBtn.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.CentredServerIlshenarBtn.TabIndex = 23;
            this.CentredServerIlshenarBtn.Text = "...";
            this.CentredServerIlshenarBtn.UseVisualStyleBackColor = true;
            this.CentredServerIlshenarBtn.Click += new System.EventHandler(this.CentredServerIlshenarBtn_Click);
            #endregion

            currentY += 30;
            
            #region  PyFilesHasher
            // pyFileHasherLabel
            this.pyFileHasherLabel.AutoSize = true;
            this.pyFileHasherLabel.Location = new System.Drawing.Point(labelX, currentY+labelYModifier);
            this.pyFileHasherLabel.Name = "pyFileHasherLabel";
            this.pyFileHasherLabel.Size = new System.Drawing.Size(labelWidth, labelHeight);
            this.pyFileHasherLabel.TabIndex = 7;
            this.pyFileHasherLabel.Text = "pyFileHasher.py";
            
            // pyFileHasherTextBox
            this.pyFileHasherTextBox.Location = new System.Drawing.Point(inputX, currentY);
            this.pyFileHasherTextBox.Name = "pyFileHasherTextBox";
            this.pyFileHasherTextBox.Size = new System.Drawing.Size(inputWidth, inputHeight);
            this.pyFileHasherTextBox.TabIndex = 9;
            
            // pyFileHasherBtn
            this.pyFileHasherBtn.Location = new System.Drawing.Point(buttonX, currentY);
            this.pyFileHasherBtn.Name = "pyFileHasherBtn";
            this.pyFileHasherBtn.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.pyFileHasherBtn.TabIndex = 11;
            this.pyFileHasherBtn.Text = "...";
            this.pyFileHasherBtn.UseVisualStyleBackColor = true;
            this.pyFileHasherBtn.Click += new System.EventHandler(this.pyFileHasherBtn_Click);
            #endregion

            currentY += 30;
            
            #region  Servuo Exe
            // ServUOLabel
            this.ServUOLabel.AutoSize = true;
            this.ServUOLabel.Location = new System.Drawing.Point(labelX, currentY+labelYModifier);
            this.ServUOLabel.Name = "ServUOLabel";
            this.ServUOLabel.Size = new System.Drawing.Size(labelWidth, labelHeight);
            this.ServUOLabel.TabIndex = 18;
            this.ServUOLabel.Text = "ServUO.exe";
            
            // ServUOExeTextBox
            this.ServUOExeTextBox.Location = new System.Drawing.Point(inputX, currentY);
            this.ServUOExeTextBox.Name = "ServUOExeTextBox";
            this.ServUOExeTextBox.Size = new System.Drawing.Size(inputWidth, inputHeight);
            this.ServUOExeTextBox.TabIndex = 19;
            
            // ServUOExeBtn
            this.ServUOExeBtn.Location = new System.Drawing.Point(buttonX, currentY);
            this.ServUOExeBtn.Name = "ServUOExeBtn";
            this.ServUOExeBtn.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.ServUOExeBtn.TabIndex = 20;
            this.ServUOExeBtn.Text = "...";
            this.ServUOExeBtn.UseVisualStyleBackColor = true;
            this.ServUOExeBtn.Click += new System.EventHandler(this.ServUOExeBtn_Click);
            #endregion
            
            currentY += 30;
            
            #region BackupFolder
            BackupLabel.AutoSize = true;
            BackupLabel.Location = new System.Drawing.Point(labelX, currentY+labelYModifier);
            BackupLabel.Name = "BackupLabel";
            BackupLabel.Size = new System.Drawing.Size(labelWidth, labelHeight);
            BackupLabel.TabIndex = 18;
            BackupLabel.Text = "Online server folder";
            
            BackupTextBox.Location = new System.Drawing.Point(inputX, currentY);
            BackupTextBox.Name = "BackupTextBox";
            BackupTextBox.Size = new System.Drawing.Size(inputWidth, inputHeight);
            BackupTextBox.TabIndex = 19;
            
            BackupBtn.Location = new System.Drawing.Point(buttonX, currentY);
            BackupBtn.Name = "BackupBtn";
            BackupBtn.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            BackupBtn.TabIndex = 20;
            BackupBtn.Text = "...";
            BackupBtn.UseVisualStyleBackColor = true;
            BackupBtn.Click += new System.EventHandler(BackupBtn_Click);
            #endregion
            
            currentY += 30;
            
            #region Start Area
            // StartBtn
            this.StartBtn.Location = new System.Drawing.Point(labelX, currentY);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(100, 20);
            this.StartBtn.TabIndex = 12;
            this.StartBtn.Text = "Patch UoMars";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            
            // ComputingTextBox
            this.ComputingTextBox.AutoSize = true;
            this.ComputingTextBox.Location = new System.Drawing.Point(inputX, currentY+labelYModifier);
            this.ComputingTextBox.Name = "ServUOLabel";
            this.ComputingTextBox.Size = new System.Drawing.Size(inputWidth, inputHeight);
            this.ComputingTextBox.TabIndex = 18;
            this.ComputingTextBox.Text = "Waiting to patch";
            #endregion

            return currentY;
        }
        private void DrawPatcher()
        {
            Controls.Add(CentredServerIlshenarBtn);
            Controls.Add(CentredServerIlshenarLabel);
            Controls.Add(CentredServerIlshenarTextBox);
            Controls.Add(CentredServerTrammelBtn);
            Controls.Add(CentredServerTrammelTextBox);
            Controls.Add(CentredServerTrammelLabel);
            Controls.Add(ServUOExeBtn);
            Controls.Add(ServUOExeTextBox);
            Controls.Add(ServUOLabel);
            Controls.Add(eventTextBox);
            Controls.Add(ComputingTextBox);
            Controls.Add(ServUoFileFolderBtn);
            Controls.Add(ServUoFileFolderTextBox);
            Controls.Add(ServUoFileFolder);
            Controls.Add(StartBtn);
            Controls.Add(pyFileHasherBtn);
            Controls.Add(CentredServerFeluccaBtn);
            Controls.Add(pyFileHasherTextBox);
            Controls.Add(CentredServerFeluccaTextBox);
            Controls.Add(pyFileHasherLabel);
            Controls.Add(CentredServerFeluccaLabel);
            Controls.Add(selectUoMarsClientFileFolderBtn);
            Controls.Add(selectCentredFileFolderBtn);
            Controls.Add(UoMarsFileFolderLabel);
            Controls.Add(UoMarsClientFileFolderTextBox);
            Controls.Add(CentredFileFolderTextBox);
            Controls.Add(CentredFileFolderLabel);
            Controls.Add(BackupLabel);
            Controls.Add(BackupTextBox);
            Controls.Add(BackupBtn);
        }
        
        private int DeclareDeployDesign(int currentY)
        {
            #region Initialyze classes
            DeployTitle = new System.Windows.Forms.Label();
            DeployIpLabel = new System.Windows.Forms.Label();
            DeployIpTextBox = new System.Windows.Forms.TextBox();
            DeployIpPortLabel = new System.Windows.Forms.Label();
            DeployIpPortTextBox = new System.Windows.Forms.TextBox();
            DeployUsernameLabel = new System.Windows.Forms.Label();
            DeployUsernameTextBox = new System.Windows.Forms.TextBox();
            DeployPasswordLabel = new System.Windows.Forms.Label();
            DeployPasswordTextBox = new System.Windows.Forms.TextBox();
            DeployPullScriptLabel = new System.Windows.Forms.Label();
            DeployPullScriptTextBox = new System.Windows.Forms.TextBox();
            DeployLocalFolderBrowserDialog = new FolderBrowserDialog();
            DeployFilesScriptLabel = new System.Windows.Forms.Label();
            DeployFilesScriptTextBox = new System.Windows.Forms.TextBox();

            DeployButtonPullCode = new System.Windows.Forms.Button();
            DeployButton = new System.Windows.Forms.Button();
            DeployButtonComputing = new System.Windows.Forms.Label();
            #endregion

            // label
            int labelX = 10;
            int labelWidth = 95;
            int labelHeight = 13;
            
            // input
            int inputX = 145;
            int inputWidth = 200;
            int inputHeight = 20;

            int labelYModifier = 3;
            
            #region DeployTitle
            DeployTitle.AutoSize = true;
            DeployTitle.Location = new System.Drawing.Point(labelX, currentY+labelYModifier);
            DeployTitle.Name = "DeployTitle";
            DeployTitle.Size = new System.Drawing.Size(labelWidth, labelHeight);
            DeployTitle.TabIndex = 0;
            DeployTitle.Text = "Deploy in production";
            #endregion

            currentY += 30;
            
            #region Server IP - Port
            DeployIpLabel.AutoSize = true;
            DeployIpLabel.Location = new System.Drawing.Point(labelX, currentY+labelYModifier);
            DeployIpLabel.Name = "DeployIpLabel";
            DeployIpLabel.Size = new System.Drawing.Size(labelWidth, labelHeight);
            DeployIpLabel.TabIndex = 13;
            DeployIpLabel.Text = "Server IP";
            
            DeployIpTextBox.Location = new System.Drawing.Point(inputX, currentY);
            DeployIpTextBox.Name = "DeployIpTextBox";
            DeployIpTextBox.Size = new System.Drawing.Size(inputWidth-100, inputHeight);
            DeployIpTextBox.TabIndex = 14;
            
            DeployIpPortLabel.AutoSize = true;
            DeployIpPortLabel.Location = new System.Drawing.Point(labelX+240, currentY+labelYModifier);
            DeployIpPortLabel.Name = "DeployIpPortLabel";
            DeployIpPortLabel.Size = new System.Drawing.Size(labelWidth, labelHeight);
            DeployIpPortLabel.TabIndex = 13;
            DeployIpPortLabel.Text = "port:";
            
            DeployIpPortTextBox.Location = new System.Drawing.Point(inputX+135, currentY);
            DeployIpPortTextBox.Name = "DeployIpPortTextBox";
            DeployIpPortTextBox.Size = new System.Drawing.Size(inputWidth-150, inputHeight);
            DeployIpPortTextBox.TabIndex = 14;
            #endregion
            
            currentY += 30;
            
            #region Server Username
            DeployUsernameLabel.AutoSize = true;
            DeployUsernameLabel.Location = new System.Drawing.Point(labelX, currentY+labelYModifier);
            DeployUsernameLabel.Name = "DeployUsernameLabel";
            DeployUsernameLabel.Size = new System.Drawing.Size(labelWidth, labelHeight);
            DeployUsernameLabel.TabIndex = 13;
            DeployUsernameLabel.Text = "Server Username";
            
            DeployUsernameTextBox.Location = new System.Drawing.Point(inputX, currentY);
            DeployUsernameTextBox.Name = "DeployUsernameTextBox";
            DeployUsernameTextBox.Size = new System.Drawing.Size(inputWidth, inputHeight);
            DeployUsernameTextBox.TabIndex = 14;
            #endregion
            
            currentY += 30;
            
            #region Server Password
            DeployPasswordLabel.AutoSize = true;
            DeployPasswordLabel.Location = new System.Drawing.Point(labelX, currentY+labelYModifier);
            DeployPasswordLabel.Name = "DeployPasswordLabel";
            DeployPasswordLabel.Size = new System.Drawing.Size(labelWidth, labelHeight);
            DeployPasswordLabel.TabIndex = 13;
            DeployPasswordLabel.Text = "Server Password";

            DeployPasswordTextBox.Location = new System.Drawing.Point(inputX, currentY);
            DeployPasswordTextBox.Name = "DeployPasswordTextBox";
            DeployPasswordTextBox.Size = new System.Drawing.Size(inputWidth, inputHeight);
            DeployPasswordTextBox.TabIndex = 14;
            DeployPasswordTextBox.UseSystemPasswordChar = true;
            DeployPasswordTextBox.PasswordChar = '-';
            #endregion
            
            currentY += 30;
            
            #region pullcodeProd
            DeployButtonPullCode.Location = new System.Drawing.Point(labelX, currentY);
            DeployButtonPullCode.Name = "DeployButtonPullCode";
            DeployButtonPullCode.Size = new System.Drawing.Size(100, 20);
            DeployButtonPullCode.TabIndex = 12;
            DeployButtonPullCode.Text = "Pull code";
            DeployButtonPullCode.UseVisualStyleBackColor = true;
            DeployButtonPullCode.Click += new System.EventHandler(DeployPullCodeProduction_Click);
            #endregion

            #region deployButton
            DeployButton.Location = new System.Drawing.Point(labelX+110, currentY);
            DeployButton.Name = "DeployButton";
            DeployButton.Size = new System.Drawing.Size(100, 20);
            DeployButton.TabIndex = 12;
            DeployButton.Text = "Deploy files";
            DeployButton.UseVisualStyleBackColor = true;
            DeployButton.Click += new System.EventHandler(DeployFilesProduction_Click);
            
            // ComputingTextBox
            DeployButtonComputing.AutoSize = true;
            DeployButtonComputing.Location = new System.Drawing.Point(inputX+90, currentY+labelYModifier);
            DeployButtonComputing.Name = "DeployButtonComputing";
            DeployButtonComputing.Size = new System.Drawing.Size(inputWidth, inputHeight);
            DeployButtonComputing.TabIndex = 18;
            DeployButtonComputing.Text = "asdasd";
            #endregion

            labelX += 350;
            inputX += 350;
            
            int buttonX = 680;
            int buttonWidth = 30;
            int buttonHeight = 20;
            
            #region Deploy pull code Script
            DeployPullScriptLabel.AutoSize = true;
            DeployPullScriptLabel.Location = new System.Drawing.Point(labelX, currentY+labelYModifier-60);
            DeployPullScriptLabel.Name = "DeployPullScriptLabel";
            DeployPullScriptLabel.Size = new System.Drawing.Size(labelWidth, labelHeight);
            DeployPullScriptLabel.TabIndex = 21;
            DeployPullScriptLabel.Text = "Comando server pull code";
            
            DeployPullScriptTextBox.Location = new System.Drawing.Point(inputX+10, currentY-60);
            DeployPullScriptTextBox.Name = "DeployPullScriptTextBox";
            DeployPullScriptTextBox.Size = new System.Drawing.Size(inputWidth, inputHeight);
            DeployPullScriptTextBox.TabIndex = 22;
            #endregion

            #region Deploy files Script
            DeployFilesScriptLabel.AutoSize = true;
            DeployFilesScriptLabel.Location = new System.Drawing.Point(labelX, currentY+labelYModifier-30);
            DeployFilesScriptLabel.Name = "DeployFilesScriptLabel";
            DeployFilesScriptLabel.Size = new System.Drawing.Size(labelWidth, labelHeight);
            DeployFilesScriptLabel.TabIndex = 21;
            DeployFilesScriptLabel.Text = "Comando server import files";
            
            DeployFilesScriptTextBox.Location = new System.Drawing.Point(inputX+10, currentY-30);
            DeployFilesScriptTextBox.Name = "DeployFilesScriptTextBox";
            DeployFilesScriptTextBox.Size = new System.Drawing.Size(inputWidth, inputHeight);
            DeployFilesScriptTextBox.TabIndex = 22;
            #endregion

            return currentY;
        }
        private void DrawDeploy()
        {
            Controls.Add(DeployTitle);
            Controls.Add(DeployIpLabel);
            Controls.Add(DeployIpTextBox);
            Controls.Add(DeployIpPortLabel);
            Controls.Add(DeployIpPortTextBox);
            Controls.Add(DeployUsernameLabel);
            Controls.Add(DeployUsernameTextBox);
            Controls.Add(DeployPasswordLabel);
            Controls.Add(DeployPasswordTextBox);
            Controls.Add(DeployPullScriptLabel);
            Controls.Add(DeployPullScriptTextBox);
            Controls.Add(DeployFilesScriptLabel);
            Controls.Add(DeployFilesScriptTextBox);
            
            Controls.Add(DeployButtonPullCode);
            Controls.Add(DeployButton);
            Controls.Add(DeployButtonComputing);
        }
        #endregion

        #endregion

        private System.Windows.Forms.Label CentredFileFolderLabel;
        private System.Windows.Forms.TextBox CentredFileFolderTextBox;
        private System.Windows.Forms.TextBox UoMarsClientFileFolderTextBox;
        private System.Windows.Forms.Label UoMarsFileFolderLabel;
        private System.Windows.Forms.Button selectCentredFileFolderBtn;
        private System.Windows.Forms.Button selectUoMarsClientFileFolderBtn;
        private System.Windows.Forms.Label CentredServerFeluccaLabel;
        private System.Windows.Forms.Label pyFileHasherLabel;
        private System.Windows.Forms.TextBox CentredServerFeluccaTextBox;
        private System.Windows.Forms.TextBox pyFileHasherTextBox;
        private System.Windows.Forms.Button CentredServerFeluccaBtn;
        private System.Windows.Forms.Button pyFileHasherBtn;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.FolderBrowserDialog CentredFileFolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog UoMarsFileFolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog CentredServerFeluccaExeFolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog pyFileHasherFileFolderBrowserDialog;
        private System.Windows.Forms.Label ServUoFileFolder;
        private System.Windows.Forms.TextBox ServUoFileFolderTextBox;
        private System.Windows.Forms.Button ServUoFileFolderBtn;
        private System.Windows.Forms.FolderBrowserDialog ServUoFileFolderBrowserDialog;
        private System.Windows.Forms.Label ComputingTextBox;
        private System.Windows.Forms.TextBox eventTextBox;
        private System.Windows.Forms.Label ServUOLabel;
        private System.Windows.Forms.TextBox ServUOExeTextBox;
        private System.Windows.Forms.Button ServUOExeBtn;
        private System.Windows.Forms.Label BackupLabel;
        private System.Windows.Forms.TextBox BackupTextBox;
        private System.Windows.Forms.Button BackupBtn;
        private System.Windows.Forms.FolderBrowserDialog ServUOExeFolderBrowserDialog;
        private System.Windows.Forms.Label CentredServerTrammelLabel;
        private System.Windows.Forms.TextBox CentredServerTrammelTextBox;
        private System.Windows.Forms.Button CentredServerTrammelBtn;
        private System.Windows.Forms.Label CentredServerIlshenarLabel;
        private System.Windows.Forms.TextBox CentredServerIlshenarTextBox;
        private System.Windows.Forms.Button CentredServerIlshenarBtn;
        private System.Windows.Forms.FolderBrowserDialog CentredServerTrammelExeFolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog CentredServerIlshenarExeFolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog BackupFolderBrowserDialog;

        private System.Windows.Forms.Label DeployTitle;
        private System.Windows.Forms.Label DeployIpLabel;
        private System.Windows.Forms.TextBox DeployIpTextBox;
        private System.Windows.Forms.Label DeployIpPortLabel;
        private System.Windows.Forms.TextBox DeployIpPortTextBox;
        private System.Windows.Forms.Label DeployUsernameLabel;
        private System.Windows.Forms.TextBox DeployUsernameTextBox;
        private System.Windows.Forms.Label DeployPasswordLabel;
        private System.Windows.Forms.TextBox DeployPasswordTextBox;
        private System.Windows.Forms.Label DeployPullScriptLabel;
        private System.Windows.Forms.TextBox DeployPullScriptTextBox;
        private System.Windows.Forms.FolderBrowserDialog DeployLocalFolderBrowserDialog;
        private System.Windows.Forms.Label DeployFilesScriptLabel;
        private System.Windows.Forms.TextBox DeployFilesScriptTextBox;
        
        private System.Windows.Forms.Button DeployButtonPullCode;
        private System.Windows.Forms.Button DeployButton;
        private System.Windows.Forms.Label DeployButtonComputing;
    }
}
