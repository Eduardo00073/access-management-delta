namespace AMD.Termo
{
    partial class FRMTermo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMTermo));
            this.BTNAceitar = new System.Windows.Forms.Button();
            this.Recusar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNAceitar
            // 
            this.BTNAceitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(32)))), ((int)(((byte)(25)))));
            this.BTNAceitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNAceitar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAceitar.Location = new System.Drawing.Point(1226, 703);
            this.BTNAceitar.Name = "BTNAceitar";
            this.BTNAceitar.Size = new System.Drawing.Size(128, 45);
            this.BTNAceitar.TabIndex = 0;
            this.BTNAceitar.Text = "Aceitar";
            this.BTNAceitar.UseVisualStyleBackColor = false;
            this.BTNAceitar.Click += new System.EventHandler(this.BTNAceitar_Click);
            // 
            // Recusar
            // 
            this.Recusar.AutoSize = true;
            this.Recusar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Recusar.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recusar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Recusar.Location = new System.Drawing.Point(14, 729);
            this.Recusar.Name = "Recusar";
            this.Recusar.Size = new System.Drawing.Size(69, 19);
            this.Recusar.TabIndex = 1;
            this.Recusar.Text = "Recusar";
            this.Recusar.Click += new System.EventHandler(this.Recusar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1314, 627);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(18, 226);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(654, 449);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // FRMTermo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Recusar);
            this.Controls.Add(this.BTNAceitar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMTermo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMTermo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMTermo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNAceitar;
        private System.Windows.Forms.Label Recusar;
        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}