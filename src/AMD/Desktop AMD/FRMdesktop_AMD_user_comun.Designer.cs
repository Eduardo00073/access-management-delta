namespace AMD.Desktop_AMD
{
    partial class FRMdesktop_AMD_user_comun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMdesktop_AMD_user_comun));
            this.BTNDesligar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNProblema = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BTNDesligar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNProblema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNDesligar
            // 
            this.BTNDesligar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNDesligar.BackgroundImage")));
            this.BTNDesligar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNDesligar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNDesligar.Location = new System.Drawing.Point(443, 6);
            this.BTNDesligar.Name = "BTNDesligar";
            this.BTNDesligar.Size = new System.Drawing.Size(62, 63);
            this.BTNDesligar.TabIndex = 7;
            this.BTNDesligar.TabStop = false;
            this.BTNDesligar.Click += new System.EventHandler(this.BTNDesligar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial", 35.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 54);
            this.label1.TabIndex = 8;
            this.label1.Text = "AMD";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BTNProblema
            // 
            this.BTNProblema.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNProblema.BackgroundImage")));
            this.BTNProblema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNProblema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNProblema.Location = new System.Drawing.Point(152, 6);
            this.BTNProblema.Name = "BTNProblema";
            this.BTNProblema.Size = new System.Drawing.Size(117, 43);
            this.BTNProblema.TabIndex = 9;
            this.BTNProblema.TabStop = false;
            this.BTNProblema.Click += new System.EventHandler(this.BTNProblema_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Algum problema ?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(313, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 43);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Alterar senha ?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FRMdesktop_AMD_user_comun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(84)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(517, 81);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTNProblema);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNDesligar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(450, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMdesktop_AMD_user_comun";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FRMdesktop_AMD_user_comun";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMdesktop_AMD_user_comun_FormClosing);
            this.Load += new System.EventHandler(this.FRMdesktop_AMD_user_comun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BTNDesligar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNProblema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BTNDesligar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BTNProblema;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}