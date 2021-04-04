// /***************************************************************************
//  *
//  * $Author: Turley
//  * 
//  * "THE BEER-WARE LICENSE"
//  * As long as you retain this notice you can do whatever you want with 
//  * this stuff. If we meet some day, and you think this stuff is worth it,
//  * you can buy me a beer in return.
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
            this.CentredServerLabel = new System.Windows.Forms.Label();
            this.pyFileHasherLabel = new System.Windows.Forms.Label();
            this.CentredServerTextBox = new System.Windows.Forms.TextBox();
            this.pyFileHasherTextBox = new System.Windows.Forms.TextBox();
            this.CentredServerBtn = new System.Windows.Forms.Button();
            this.pyFileHasherBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.CentredFileFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.UoMarsFileFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.CentredServerExeFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.pyFileHasherFileFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ServUoFileFolder = new System.Windows.Forms.Label();
            this.ServUoFileFolderTextBox = new System.Windows.Forms.TextBox();
            this.ServUoFileFolderBtn = new System.Windows.Forms.Button();
            this.ServUoFileFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ComputingTextBox = new System.Windows.Forms.TextBox();
            this.eventTextBox = new System.Windows.Forms.TextBox();
            this.ServUOLabel = new System.Windows.Forms.Label();
            this.ServUOExeTextBox = new System.Windows.Forms.TextBox();
            this.ServUOExeBtn = new System.Windows.Forms.Button();
            this.ServUOExeFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.CentredServer2Label = new System.Windows.Forms.Label();
            this.CentredServer2TextBox = new System.Windows.Forms.TextBox();
            this.CentredServer2Btn = new System.Windows.Forms.Button();
            this.CentredServer2ExeFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // CentredFileFolderLabel
            // 
            this.CentredFileFolderLabel.AutoSize = true;
            this.CentredFileFolderLabel.Location = new System.Drawing.Point(19, 47);
            this.CentredFileFolderLabel.Name = "CentredFileFolderLabel";
            this.CentredFileFolderLabel.Size = new System.Drawing.Size(95, 13);
            this.CentredFileFolderLabel.TabIndex = 0;
            this.CentredFileFolderLabel.Text = "Centred File Folder";
            // 
            // CentredFileFolderTextBox
            // 
            this.CentredFileFolderTextBox.Location = new System.Drawing.Point(143, 44);
            this.CentredFileFolderTextBox.Name = "CentredFileFolderTextBox";
            this.CentredFileFolderTextBox.Size = new System.Drawing.Size(338, 20);
            this.CentredFileFolderTextBox.TabIndex = 1;
            // 
            // UoMarsClientFileFolderTextBox
            // 
            this.UoMarsClientFileFolderTextBox.Location = new System.Drawing.Point(143, 119);
            this.UoMarsClientFileFolderTextBox.Name = "UoMarsClientFileFolderTextBox";
            this.UoMarsClientFileFolderTextBox.Size = new System.Drawing.Size(338, 20);
            this.UoMarsClientFileFolderTextBox.TabIndex = 2;
            // 
            // UoMarsFileFolderLabel
            // 
            this.UoMarsFileFolderLabel.AutoSize = true;
            this.UoMarsFileFolderLabel.Location = new System.Drawing.Point(19, 122);
            this.UoMarsFileFolderLabel.Name = "UoMarsFileFolderLabel";
            this.UoMarsFileFolderLabel.Size = new System.Drawing.Size(124, 13);
            this.UoMarsFileFolderLabel.TabIndex = 3;
            this.UoMarsFileFolderLabel.Text = "UoMars Client File Folder";
            // 
            // selectCentredFileFolderBtn
            // 
            this.selectCentredFileFolderBtn.Location = new System.Drawing.Point(487, 44);
            this.selectCentredFileFolderBtn.Name = "selectCentredFileFolderBtn";
            this.selectCentredFileFolderBtn.Size = new System.Drawing.Size(31, 20);
            this.selectCentredFileFolderBtn.TabIndex = 4;
            this.selectCentredFileFolderBtn.Text = "...";
            this.selectCentredFileFolderBtn.UseVisualStyleBackColor = true;
            this.selectCentredFileFolderBtn.Click += new System.EventHandler(this.selectCentredFileFolderBtn_Click);
            // 
            // selectUoMarsClientFileFolderBtn
            // 
            this.selectUoMarsClientFileFolderBtn.Location = new System.Drawing.Point(487, 119);
            this.selectUoMarsClientFileFolderBtn.Name = "selectUoMarsClientFileFolderBtn";
            this.selectUoMarsClientFileFolderBtn.Size = new System.Drawing.Size(31, 20);
            this.selectUoMarsClientFileFolderBtn.TabIndex = 5;
            this.selectUoMarsClientFileFolderBtn.Text = "...";
            this.selectUoMarsClientFileFolderBtn.UseVisualStyleBackColor = true;
            this.selectUoMarsClientFileFolderBtn.Click += new System.EventHandler(this.selectUoMarsClientFileFolderBtn_Click);
            // 
            // CentredServerLabel
            // 
            this.CentredServerLabel.AutoSize = true;
            this.CentredServerLabel.Location = new System.Drawing.Point(19, 165);
            this.CentredServerLabel.Name = "CentredServerLabel";
            this.CentredServerLabel.Size = new System.Drawing.Size(95, 13);
            this.CentredServerLabel.TabIndex = 6;
            this.CentredServerLabel.Text = "CentredServer.exe";
            // 
            // pyFileHasherLabel
            // 
            this.pyFileHasherLabel.AutoSize = true;
            this.pyFileHasherLabel.Location = new System.Drawing.Point(19, 242);
            this.pyFileHasherLabel.Name = "pyFileHasherLabel";
            this.pyFileHasherLabel.Size = new System.Drawing.Size(82, 13);
            this.pyFileHasherLabel.TabIndex = 7;
            this.pyFileHasherLabel.Text = "pyFileHasher.py";
            // 
            // CentredServerTextBox
            // 
            this.CentredServerTextBox.Location = new System.Drawing.Point(143, 165);
            this.CentredServerTextBox.Name = "CentredServerTextBox";
            this.CentredServerTextBox.Size = new System.Drawing.Size(338, 20);
            this.CentredServerTextBox.TabIndex = 8;
            // 
            // pyFileHasherTextBox
            // 
            this.pyFileHasherTextBox.Location = new System.Drawing.Point(143, 239);
            this.pyFileHasherTextBox.Name = "pyFileHasherTextBox";
            this.pyFileHasherTextBox.Size = new System.Drawing.Size(338, 20);
            this.pyFileHasherTextBox.TabIndex = 9;
            // 
            // CentredServerBtn
            // 
            this.CentredServerBtn.Location = new System.Drawing.Point(487, 165);
            this.CentredServerBtn.Name = "CentredServerBtn";
            this.CentredServerBtn.Size = new System.Drawing.Size(31, 20);
            this.CentredServerBtn.TabIndex = 10;
            this.CentredServerBtn.Text = "...";
            this.CentredServerBtn.UseVisualStyleBackColor = true;
            this.CentredServerBtn.Click += new System.EventHandler(this.CentredServerBtn_Click);
            // 
            // pyFileHasherBtn
            // 
            this.pyFileHasherBtn.Location = new System.Drawing.Point(487, 239);
            this.pyFileHasherBtn.Name = "pyFileHasherBtn";
            this.pyFileHasherBtn.Size = new System.Drawing.Size(31, 20);
            this.pyFileHasherBtn.TabIndex = 11;
            this.pyFileHasherBtn.Text = "...";
            this.pyFileHasherBtn.UseVisualStyleBackColor = true;
            this.pyFileHasherBtn.Click += new System.EventHandler(this.pyFileHasherBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(22, 352);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(64, 20);
            this.StartBtn.TabIndex = 12;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // ServUoFileFolder
            // 
            this.ServUoFileFolder.AutoSize = true;
            this.ServUoFileFolder.Location = new System.Drawing.Point(22, 82);
            this.ServUoFileFolder.Name = "ServUoFileFolder";
            this.ServUoFileFolder.Size = new System.Drawing.Size(94, 13);
            this.ServUoFileFolder.TabIndex = 13;
            this.ServUoFileFolder.Text = "ServUo File Folder";
            // 
            // ServUoFileFolderTextBox
            // 
            this.ServUoFileFolderTextBox.Location = new System.Drawing.Point(143, 82);
            this.ServUoFileFolderTextBox.Name = "ServUoFileFolderTextBox";
            this.ServUoFileFolderTextBox.Size = new System.Drawing.Size(338, 20);
            this.ServUoFileFolderTextBox.TabIndex = 14;
            // 
            // ServUoFileFolderBtn
            // 
            this.ServUoFileFolderBtn.Location = new System.Drawing.Point(487, 82);
            this.ServUoFileFolderBtn.Name = "ServUoFileFolderBtn";
            this.ServUoFileFolderBtn.Size = new System.Drawing.Size(31, 20);
            this.ServUoFileFolderBtn.TabIndex = 15;
            this.ServUoFileFolderBtn.Text = "...";
            this.ServUoFileFolderBtn.UseVisualStyleBackColor = true;
            this.ServUoFileFolderBtn.Click += new System.EventHandler(this.ServUoFileFolderBtn_Click);
            // 
            // ComputingTextBox
            // 
            this.ComputingTextBox.Location = new System.Drawing.Point(143, 353);
            this.ComputingTextBox.Name = "ComputingTextBox";
            this.ComputingTextBox.Size = new System.Drawing.Size(338, 20);
            this.ComputingTextBox.TabIndex = 16;
            // 
            // eventTextBox
            // 
            this.eventTextBox.Location = new System.Drawing.Point(535, 44);
            this.eventTextBox.Multiline = true;
            this.eventTextBox.Name = "eventTextBox";
            this.eventTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.eventTextBox.Size = new System.Drawing.Size(487, 258);
            this.eventTextBox.TabIndex = 17;
            // 
            // ServUOLabel
            // 
            this.ServUOLabel.AutoSize = true;
            this.ServUOLabel.Location = new System.Drawing.Point(19, 282);
            this.ServUOLabel.Name = "ServUOLabel";
            this.ServUOLabel.Size = new System.Drawing.Size(65, 13);
            this.ServUOLabel.TabIndex = 18;
            this.ServUOLabel.Text = "ServUO.exe";
            // 
            // ServUOExeTextBox
            // 
            this.ServUOExeTextBox.Location = new System.Drawing.Point(143, 279);
            this.ServUOExeTextBox.Name = "ServUOExeTextBox";
            this.ServUOExeTextBox.Size = new System.Drawing.Size(338, 20);
            this.ServUOExeTextBox.TabIndex = 19;
            // 
            // ServUOExeBtn
            // 
            this.ServUOExeBtn.Location = new System.Drawing.Point(487, 279);
            this.ServUOExeBtn.Name = "ServUOExeBtn";
            this.ServUOExeBtn.Size = new System.Drawing.Size(31, 20);
            this.ServUOExeBtn.TabIndex = 20;
            this.ServUOExeBtn.Text = "...";
            this.ServUOExeBtn.UseVisualStyleBackColor = true;
            this.ServUOExeBtn.Click += new System.EventHandler(this.ServUOExeBtn_Click);
            // 
            // CentredServer2Label
            // 
            this.CentredServer2Label.AutoSize = true;
            this.CentredServer2Label.Location = new System.Drawing.Point(19, 208);
            this.CentredServer2Label.Name = "CentredServer2Label";
            this.CentredServer2Label.Size = new System.Drawing.Size(101, 13);
            this.CentredServer2Label.TabIndex = 21;
            this.CentredServer2Label.Text = "CentredServer2.exe";
            // 
            // CentredServer2TextBox
            // 
            this.CentredServer2TextBox.Location = new System.Drawing.Point(143, 208);
            this.CentredServer2TextBox.Name = "CentredServer2TextBox";
            this.CentredServer2TextBox.Size = new System.Drawing.Size(338, 20);
            this.CentredServer2TextBox.TabIndex = 22;
            // 
            // CentredServer2Btn
            // 
            this.CentredServer2Btn.Location = new System.Drawing.Point(487, 208);
            this.CentredServer2Btn.Name = "CentredServer2Btn";
            this.CentredServer2Btn.Size = new System.Drawing.Size(31, 20);
            this.CentredServer2Btn.TabIndex = 23;
            this.CentredServer2Btn.Text = "...";
            this.CentredServer2Btn.UseVisualStyleBackColor = true;
            this.CentredServer2Btn.Click += new System.EventHandler(this.CentredServer2Btn_Click);
            // 
            // UoMarsManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CentredServer2Btn);
            this.Controls.Add(this.CentredServer2TextBox);
            this.Controls.Add(this.CentredServer2Label);
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
            this.Controls.Add(this.CentredServerBtn);
            this.Controls.Add(this.pyFileHasherTextBox);
            this.Controls.Add(this.CentredServerTextBox);
            this.Controls.Add(this.pyFileHasherLabel);
            this.Controls.Add(this.CentredServerLabel);
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
        private System.Windows.Forms.Label CentredServerLabel;
        private System.Windows.Forms.Label pyFileHasherLabel;
        private System.Windows.Forms.TextBox CentredServerTextBox;
        private System.Windows.Forms.TextBox pyFileHasherTextBox;
        private System.Windows.Forms.Button CentredServerBtn;
        private System.Windows.Forms.Button pyFileHasherBtn;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.FolderBrowserDialog CentredFileFolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog UoMarsFileFolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog CentredServerExeFolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog pyFileHasherFileFolderBrowserDialog;
        private System.Windows.Forms.Label ServUoFileFolder;
        private System.Windows.Forms.TextBox ServUoFileFolderTextBox;
        private System.Windows.Forms.Button ServUoFileFolderBtn;
        private System.Windows.Forms.FolderBrowserDialog ServUoFileFolderBrowserDialog;
        private System.Windows.Forms.TextBox ComputingTextBox;
        private System.Windows.Forms.TextBox eventTextBox;
        private System.Windows.Forms.Label ServUOLabel;
        private System.Windows.Forms.TextBox ServUOExeTextBox;
        private System.Windows.Forms.Button ServUOExeBtn;
        private System.Windows.Forms.FolderBrowserDialog ServUOExeFolderBrowserDialog;
        private System.Windows.Forms.Label CentredServer2Label;
        private System.Windows.Forms.TextBox CentredServer2TextBox;
        private System.Windows.Forms.Button CentredServer2Btn;
        private System.Windows.Forms.FolderBrowserDialog CentredServer2ExeFolderBrowserDialog;
    }
}
