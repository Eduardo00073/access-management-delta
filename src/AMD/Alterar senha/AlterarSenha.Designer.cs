namespace AMD.Alterar_senha
{
    partial class AlterarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarSenha));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TXTsenhaAtual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBXNovaSenha = new System.Windows.Forms.TextBox();
            this.TBXSenha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNConfirmar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ls = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.TXTsenhaAtual);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TBXNovaSenha);
            this.groupBox2.Controls.Add(this.TBXSenha);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 250);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alterar senha (A senha deve ter no mínimo 5 digitos)";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(327, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 34);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(221, 206);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 32);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Digite o texto de verificação: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Você é um robô ?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(5, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 52);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // TXTsenhaAtual
            // 
            this.TXTsenhaAtual.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTsenhaAtual.Location = new System.Drawing.Point(101, 27);
            this.TXTsenhaAtual.MaxLength = 16;
            this.TXTsenhaAtual.Name = "TXTsenhaAtual";
            this.TXTsenhaAtual.PasswordChar = '*';
            this.TXTsenhaAtual.Size = new System.Drawing.Size(111, 25);
            this.TXTsenhaAtual.TabIndex = 0;
            this.TXTsenhaAtual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTsenhaAtual_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Senha Atual";
            // 
            // TBXNovaSenha
            // 
            this.TBXNovaSenha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXNovaSenha.Location = new System.Drawing.Point(165, 97);
            this.TBXNovaSenha.MaxLength = 16;
            this.TBXNovaSenha.Name = "TBXNovaSenha";
            this.TBXNovaSenha.PasswordChar = '*';
            this.TBXNovaSenha.Size = new System.Drawing.Size(111, 25);
            this.TBXNovaSenha.TabIndex = 2;
            this.TBXNovaSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBXNovaSenha_KeyDown);
            // 
            // TBXSenha
            // 
            this.TBXSenha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXSenha.Location = new System.Drawing.Point(101, 62);
            this.TBXSenha.MaxLength = 16;
            this.TBXSenha.Name = "TBXSenha";
            this.TBXSenha.PasswordChar = '*';
            this.TBXSenha.Size = new System.Drawing.Size(111, 25);
            this.TBXSenha.TabIndex = 1;
            this.TBXSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBXSenha_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Confirme Nova Senha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nova Senha";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 67);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "RM: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "(NOME)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nome: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "(RM)";
            // 
            // BTNConfirmar
            // 
            this.BTNConfirmar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BTNConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNConfirmar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNConfirmar.Location = new System.Drawing.Point(390, 12);
            this.BTNConfirmar.Name = "BTNConfirmar";
            this.BTNConfirmar.Size = new System.Drawing.Size(82, 83);
            this.BTNConfirmar.TabIndex = 1;
            this.BTNConfirmar.Text = "Alterar senha e fazer login";
            this.BTNConfirmar.UseVisualStyleBackColor = false;
            this.BTNConfirmar.Click += new System.EventHandler(this.BTNConfirmar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(390, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 71);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancelar e fazer login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ls
            // 
            this.ls.AutoSize = true;
            this.ls.Location = new System.Drawing.Point(436, 113);
            this.ls.Name = "ls";
            this.ls.Size = new System.Drawing.Size(0, 13);
            this.ls.TabIndex = 3;
            this.ls.Visible = false;
            // 
            // AlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(484, 329);
            this.ControlBox = false;
            this.Controls.Add(this.ls);
            this.Controls.Add(this.BTNConfirmar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlterarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar senha";
            this.Load += new System.EventHandler(this.AlterarSenha_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TBXNovaSenha;
        private System.Windows.Forms.TextBox TBXSenha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNConfirmar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TXTsenhaAtual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ls;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}