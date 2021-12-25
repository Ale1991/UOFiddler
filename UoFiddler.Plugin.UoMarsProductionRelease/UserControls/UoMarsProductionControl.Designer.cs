namespace UoFiddler.Plugin.UoMarsProductionRelease.UserControls
{
    partial class UoMarsProductionControl
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
            
            #region Initialyze classes
            eventTextBox = new System.Windows.Forms.TextBox();
            ReleaseProductionTitle = new System.Windows.Forms.Label();
            ReleaseProductionIpLabel = new System.Windows.Forms.Label();
            ReleaseProductionIpTextBox = new System.Windows.Forms.TextBox();
            #endregion
            
            #region EventBox
            eventTextBox.Location = new System.Drawing.Point(490, 20);
            eventTextBox.Multiline = true;
            eventTextBox.Name = "eventTextBox";
            eventTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            eventTextBox.Size = new System.Drawing.Size(300, 230);
            eventTextBox.TabIndex = 17;
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
            int currentY = 20;
            
            #region title
            ReleaseProductionTitle.AutoSize = true;
            ReleaseProductionTitle.Location = new System.Drawing.Point(10, currentY);
            ReleaseProductionTitle.Name = "ReleaseProductionTitle";
            ReleaseProductionTitle.Size = new System.Drawing.Size(150, 20);
            ReleaseProductionTitle.TabIndex = 15;
            ReleaseProductionTitle.Text = "Release Production";
            #endregion

            currentY += 30;
            
            #region Server Ip
            ReleaseProductionIpLabel.AutoSize = true;
            ReleaseProductionIpLabel.Location = new System.Drawing.Point(labelX, currentY+labelYModifier);
            ReleaseProductionIpLabel.Name = "ReleaseProductionIpLabel";
            ReleaseProductionIpLabel.Size = new System.Drawing.Size(labelWidth, labelHeight);
            ReleaseProductionIpLabel.TabIndex = 13;
            ReleaseProductionIpLabel.Text = "Server IP";
            
            ReleaseProductionIpTextBox.Location = new System.Drawing.Point(inputX, currentY);
            ReleaseProductionIpTextBox.Name = "ReleaseProductionIpTextBox";
            ReleaseProductionIpTextBox.Size = new System.Drawing.Size(inputWidth, inputHeight);
            ReleaseProductionIpTextBox.TabIndex = 14;
            #endregion
            
            
            // Draw
            Controls.Add(ReleaseProductionTitle);
            Controls.Add(ReleaseProductionIpLabel);
            Controls.Add(ReleaseProductionIpTextBox);
            
            Name = "UoMarsManagerControl";
            Size = new System.Drawing.Size(1040, 395);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        
        private System.Windows.Forms.TextBox eventTextBox;
        
        private System.Windows.Forms.Label ReleaseProductionTitle;
        private System.Windows.Forms.Label ReleaseProductionIpLabel;
        private System.Windows.Forms.TextBox ReleaseProductionIpTextBox;
    }
}
