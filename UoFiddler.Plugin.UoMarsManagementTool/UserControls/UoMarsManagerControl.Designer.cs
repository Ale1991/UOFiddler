// /***************************************************************************
//  *
//  * $Author: Hurricane
//  *
//  ***************************************************************************/


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
            this.CentredFileFolderLabel = new System.Windows.Forms.Label();
            this.CentredFileFolderTextBox = new System.Windows.Forms.TextBox();
            this.UoMarsClientFileFolderTextBox = new System.Windows.Forms.TextBox();
            this.UoMarsFileFolderLabel = new System.Windows.Forms.Label();
            this.selectCentredFileFolderBtn = new System.Windows.Forms.Button();
            this.selectUoMarsClientFileFolderBtn = new System.Windows.Forms.Button();
            this.CentredServerFeluccaLabel = new System.Windows.Forms.Label();
            this.pyFileHasherLabel = new System.Windows.Forms.Label();
            this.CentredServerFeluccaTextBox = new System.Windows.Forms.TextBox();
            this.pyFileHasherTextBox = new System.Windows.Forms.TextBox();
            this.CentredServerFeluccaBtn = new System.Windows.Forms.Button();
            this.pyFileHasherBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.CentredFileFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.UoMarsFileFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.CentredServerFeluccaExeFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.pyFileHasherFileFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ServUoFileFolder = new System.Windows.Forms.Label();
            this.ServUoFileFolderTextBox = new System.Windows.Forms.TextBox();
            this.ServUoFileFolderBtn = new System.Windows.Forms.Button();
            this.ServUoFileFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ComputingTextBox = new System.Windows.Forms.Label();
            this.eventTextBox = new System.Windows.Forms.TextBox();
            this.ServUOLabel = new System.Windows.Forms.Label();
            this.ServUOExeTextBox = new System.Windows.Forms.TextBox();
            this.ServUOExeBtn = new System.Windows.Forms.Button();
            this.ServUOExeFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.CentredServerTrammelLabel = new System.Windows.Forms.Label();
            this.CentredServerTrammelTextBox = new System.Windows.Forms.TextBox();
            this.CentredServerTrammelBtn = new System.Windows.Forms.Button();
            this.CentredServerIlshenarLabel = new System.Windows.Forms.Label();
            this.CentredServerIlshenarTextBox = new System.Windows.Forms.TextBox();
            this.CentredServerIlshenarBtn = new System.Windows.Forms.Button();
            this.CentredServerTrammelExeFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.CentredServerIlshenarExeFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            
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
            int currentY = 20;
            
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
            
            // this.ComputingTextBox.Location = new System.Drawing.Point(143, 353);
            // this.ComputingTextBox.Name = "cavallo"; // ComputingTextBox
            // this.ComputingTextBox.Size = new System.Drawing.Size(338, 20);
            // this.ComputingTextBox.TabIndex = 16;
            #endregion

            // eventTextBox
            this.eventTextBox.Location = new System.Drawing.Point(490, 20);
            this.eventTextBox.Multiline = true;
            this.eventTextBox.Name = "eventTextBox";
            this.eventTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.eventTextBox.Size = new System.Drawing.Size(300, 230);
            this.eventTextBox.TabIndex = 17;
            
            // UoMarsManagerControl
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CentredServerIlshenarBtn);
            this.Controls.Add(this.CentredServerIlshenarLabel);
            this.Controls.Add(this.CentredServerIlshenarTextBox);
            this.Controls.Add(this.CentredServerTrammelBtn);
            this.Controls.Add(this.CentredServerTrammelTextBox);
            this.Controls.Add(this.CentredServerTrammelLabel);
            this.Controls.Add(this.ServUOExeBtn);
            this.Controls.Add(this.ServUOExeTextBox);
            this.Controls.Add(this.ServUOLabel);
            this.Controls.Add(this.eventTextBox);
            this.Controls.Add(this.ComputingTextBox);
            this.Controls.Add(this.ServUoFileFolderBtn);
            this.Controls.Add(this.ServUoFileFolderTextBox);
            this.Controls.Add(this.ServUoFileFolder);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.pyFileHasherBtn);
            this.Controls.Add(this.CentredServerFeluccaBtn);
            this.Controls.Add(this.pyFileHasherTextBox);
            this.Controls.Add(this.CentredServerFeluccaTextBox);
            this.Controls.Add(this.pyFileHasherLabel);
            this.Controls.Add(this.CentredServerFeluccaLabel);
            this.Controls.Add(this.selectUoMarsClientFileFolderBtn);
            this.Controls.Add(this.selectCentredFileFolderBtn);
            this.Controls.Add(this.UoMarsFileFolderLabel);
            this.Controls.Add(this.UoMarsClientFileFolderTextBox);
            this.Controls.Add(this.CentredFileFolderTextBox);
            this.Controls.Add(this.CentredFileFolderLabel);
            this.Name = "UoMarsManagerControl";
            this.Size = new System.Drawing.Size(1040, 395);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

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
        private System.Windows.Forms.FolderBrowserDialog ServUOExeFolderBrowserDialog;
        private System.Windows.Forms.Label CentredServerTrammelLabel;
        private System.Windows.Forms.TextBox CentredServerTrammelTextBox;
        private System.Windows.Forms.Button CentredServerTrammelBtn;
        private System.Windows.Forms.Label CentredServerIlshenarLabel;
        private System.Windows.Forms.TextBox CentredServerIlshenarTextBox;
        private System.Windows.Forms.Button CentredServerIlshenarBtn;
        private System.Windows.Forms.FolderBrowserDialog CentredServerTrammelExeFolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog CentredServerIlshenarExeFolderBrowserDialog;
    }
}
