namespace AMD
{
    partial class Acesso
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
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acesso));
            this.BTNDesligar = new System.Windows.Forms.Button();
            this.LBVNomePC = new System.Windows.Forms.Label();
            this.LBpc = new System.Windows.Forms.Label();
            this.BTNAjuda = new System.Windows.Forms.Button();
            this.BTNAcessar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTsenha = new System.Windows.Forms.TextBox();
            this.TXTacesso = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNAcessar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Location = new System.Drawing.Point(25, 145);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(775, 254);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // BTNDesligar
            // 
            this.BTNDesligar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(32)))), ((int)(((byte)(25)))));
            this.BTNDesligar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNDesligar.BackgroundImage")));
            this.BTNDesligar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNDesligar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNDesligar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNDesligar.Location = new System.Drawing.Point(1298, 699);
            this.BTNDesligar.Name = "BTNDesligar";
            this.BTNDesligar.Size = new System.Drawing.Size(56, 57);
            this.BTNDesligar.TabIndex = 4;
            this.BTNDesligar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.BTNDesligar.UseVisualStyleBackColor = false;
            this.BTNDesligar.Click += new System.EventHandler(this.BTNDesligar_Click);
            // 
            // LBVNomePC
            // 
            this.LBVNomePC.AutoSize = true;
            this.LBVNomePC.Location = new System.Drawing.Point(13, 13);
            this.LBVNomePC.Name = "LBVNomePC";
            this.LBVNomePC.Size = new System.Drawing.Size(0, 13);
            this.LBVNomePC.TabIndex = 9;
            this.LBVNomePC.Visible = false;
            // 
            // LBpc
            // 
            this.LBpc.AutoSize = true;
            this.LBpc.Location = new System.Drawing.Point(22, 12);
            this.LBpc.Name = "LBpc";
            this.LBpc.Size = new System.Drawing.Size(0, 13);
            this.LBpc.TabIndex = 11;
            this.LBpc.Visible = false;
            // 
            // BTNAjuda
            // 
            this.BTNAjuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNAjuda.BackgroundImage")));
            this.BTNAjuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNAjuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNAjuda.Location = new System.Drawing.Point(12, 700);
            this.BTNAjuda.Name = "BTNAjuda";
            this.BTNAjuda.Size = new System.Drawing.Size(56, 56);
            this.BTNAjuda.TabIndex = 3;
            this.BTNAjuda.UseVisualStyleBackColor = true;
            this.BTNAjuda.Click += new System.EventHandler(this.BTNAjuda_Click);
            // 
            // BTNAcessar
            // 
            this.BTNAcessar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(32)))), ((int)(((byte)(25)))));
            this.BTNAcessar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNAcessar.BackgroundImage")));
            this.BTNAcessar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNAcessar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BTNAcessar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNAcessar.Location = new System.Drawing.Point(579, 331);
            this.BTNAcessar.Name = "BTNAcessar";
            this.BTNAcessar.Size = new System.Drawing.Size(39, 38);
            this.BTNAcessar.TabIndex = 35;
            this.BTNAcessar.TabStop = false;
            this.BTNAcessar.Click += new System.EventHandler(this.BTNAcessar_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(273, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 32);
            this.label2.TabIndex = 34;
            this.label2.Text = " Senha: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(136, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "Matrícula (Acesso): ";
            // 
            // TXTsenha
            // 
            this.TXTsenha.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTsenha.Location = new System.Drawing.Point(400, 331);
            this.TXTsenha.MaxLength = 16;
            this.TXTsenha.Name = "TXTsenha";
            this.TXTsenha.PasswordChar = '*';
            this.TXTsenha.Size = new System.Drawing.Size(185, 39);
            this.TXTsenha.TabIndex = 2;
            this.TXTsenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTsenha_KeyDown);
            // 
            // TXTacesso
            // 
            this.TXTacesso.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTacesso.Location = new System.Drawing.Point(400, 287);
            this.TXTacesso.MaxLength = 6;
            this.TXTacesso.Name = "TXTacesso";
            this.TXTacesso.Size = new System.Drawing.Size(97, 39);
            this.TXTacesso.TabIndex = 1;
            this.TXTacesso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTacesso_KeyDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(110, 314);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(615, 206);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // Acesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.BTNAcessar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTsenha);
            this.Controls.Add(this.TXTacesso);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.BTNAjuda);
            this.Controls.Add(this.LBpc);
            this.Controls.Add(this.LBVNomePC);
            this.Controls.Add(this.BTNDesligar);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Acesso";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesso";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Acesso_FormClosing);
            this.Load += new System.EventHandler(this.Acesso_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNAcessar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNDesligar;
        private System.Windows.Forms.Label LBVNomePC;
        private System.Windows.Forms.Label LBpc;
        private System.Windows.Forms.Button BTNAjuda;
        private System.Windows.Forms.PictureBox BTNAcessar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTsenha;
        private System.Windows.Forms.TextBox TXTacesso;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

