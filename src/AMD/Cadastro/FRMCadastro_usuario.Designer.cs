namespace AMD.Cadastro
{
    partial class FRMCadastro_usuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMCadastro_usuario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBAdm = new System.Windows.Forms.RadioButton();
            this.RBComum = new System.Windows.Forms.RadioButton();
            this.BTNExcluir = new System.Windows.Forms.Button();
            this.BTNLimpar = new System.Windows.Forms.Button();
            this.BTNGravar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TXTSenha = new System.Windows.Forms.TextBox();
            this.TXTMatricula_acesso = new System.Windows.Forms.TextBox();
            this.TXTNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGPesquisa_usuario = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BTNPesquisa = new System.Windows.Forms.Button();
            this.TXTPesquisa = new System.Windows.Forms.TextBox();
            this.BTNFechar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGPesquisa_usuario)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBAdm);
            this.groupBox1.Controls.Add(this.RBComum);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 75);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permissão";
            // 
            // RBAdm
            // 
            this.RBAdm.AutoSize = true;
            this.RBAdm.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBAdm.Location = new System.Drawing.Point(8, 42);
            this.RBAdm.Name = "RBAdm";
            this.RBAdm.Size = new System.Drawing.Size(390, 20);
            this.RBAdm.TabIndex = 1;
            this.RBAdm.Text = "ADMs podem cadastrar usuários, computadores e ver acessos";
            this.RBAdm.UseVisualStyleBackColor = true;
            // 
            // RBComum
            // 
            this.RBComum.AutoSize = true;
            this.RBComum.Checked = true;
            this.RBComum.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBComum.Location = new System.Drawing.Point(8, 19);
            this.RBComum.Name = "RBComum";
            this.RBComum.Size = new System.Drawing.Size(386, 20);
            this.RBComum.TabIndex = 0;
            this.RBComum.TabStop = true;
            this.RBComum.Text = "Usuários comuns que só podem acessar e reportar problemas";
            this.RBComum.UseVisualStyleBackColor = true;
            // 
            // BTNExcluir
            // 
            this.BTNExcluir.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BTNExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNExcluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNExcluir.Location = new System.Drawing.Point(240, 308);
            this.BTNExcluir.Name = "BTNExcluir";
            this.BTNExcluir.Size = new System.Drawing.Size(82, 41);
            this.BTNExcluir.TabIndex = 7;
            this.BTNExcluir.Text = "Excluir";
            this.BTNExcluir.UseVisualStyleBackColor = false;
            this.BTNExcluir.Click += new System.EventHandler(this.BTNExcluir_Click);
            // 
            // BTNLimpar
            // 
            this.BTNLimpar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BTNLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNLimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLimpar.Location = new System.Drawing.Point(128, 308);
            this.BTNLimpar.Name = "BTNLimpar";
            this.BTNLimpar.Size = new System.Drawing.Size(82, 41);
            this.BTNLimpar.TabIndex = 8;
            this.BTNLimpar.Text = "Limpar";
            this.BTNLimpar.UseVisualStyleBackColor = false;
            this.BTNLimpar.Click += new System.EventHandler(this.BTNLimpar_Click);
            // 
            // BTNGravar
            // 
            this.BTNGravar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BTNGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNGravar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGravar.Location = new System.Drawing.Point(12, 308);
            this.BTNGravar.Name = "BTNGravar";
            this.BTNGravar.Size = new System.Drawing.Size(82, 41);
            this.BTNGravar.TabIndex = 9;
            this.BTNGravar.Text = "Gravar";
            this.BTNGravar.UseVisualStyleBackColor = false;
            this.BTNGravar.Click += new System.EventHandler(this.BTNGravar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TXTSenha);
            this.groupBox2.Controls.Add(this.TXTMatricula_acesso);
            this.groupBox2.Controls.Add(this.TXTNome);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 184);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastrar ou alterar";
            // 
            // TXTSenha
            // 
            this.TXTSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTSenha.Location = new System.Drawing.Point(74, 126);
            this.TXTSenha.MaxLength = 16;
            this.TXTSenha.Name = "TXTSenha";
            this.TXTSenha.Size = new System.Drawing.Size(140, 26);
            this.TXTSenha.TabIndex = 16;
            // 
            // TXTMatricula_acesso
            // 
            this.TXTMatricula_acesso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTMatricula_acesso.Location = new System.Drawing.Point(166, 77);
            this.TXTMatricula_acesso.MaxLength = 6;
            this.TXTMatricula_acesso.Name = "TXTMatricula_acesso";
            this.TXTMatricula_acesso.Size = new System.Drawing.Size(82, 26);
            this.TXTMatricula_acesso.TabIndex = 10;
            this.TXTMatricula_acesso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTMatricula_acesso_KeyPress);
            // 
            // TXTNome
            // 
            this.TXTNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTNome.Location = new System.Drawing.Point(74, 21);
            this.TXTNome.MaxLength = 100;
            this.TXTNome.Name = "TXTNome";
            this.TXTNome.Size = new System.Drawing.Size(320, 26);
            this.TXTNome.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Senha: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Matrícula (Acesso): ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome: ";
            // 
            // DGPesquisa_usuario
            // 
            this.DGPesquisa_usuario.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGPesquisa_usuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGPesquisa_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGPesquisa_usuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4});
            this.DGPesquisa_usuario.Location = new System.Drawing.Point(455, 74);
            this.DGPesquisa_usuario.Name = "DGPesquisa_usuario";
            this.DGPesquisa_usuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGPesquisa_usuario.Size = new System.Drawing.Size(533, 281);
            this.DGPesquisa_usuario.TabIndex = 14;
            this.DGPesquisa_usuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGPesquisa_usuario_CellClick);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "idUsuario";
            this.Column5.HeaderText = "Usuário ID";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            this.Column5.Width = 5;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Matricula_Acesso";
            this.Column1.HeaderText = "Matrícula (Acesso)";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Senha";
            this.Column3.HeaderText = "Senha";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Nome";
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 230;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Permissao";
            this.Column4.HeaderText = "Permissão  de ADM";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 60;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BTNPesquisa);
            this.groupBox3.Controls.Add(this.TXTPesquisa);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(455, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(533, 56);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesquisar";
            // 
            // BTNPesquisa
            // 
            this.BTNPesquisa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNPesquisa.BackgroundImage")));
            this.BTNPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNPesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNPesquisa.Location = new System.Drawing.Point(486, 19);
            this.BTNPesquisa.Name = "BTNPesquisa";
            this.BTNPesquisa.Size = new System.Drawing.Size(41, 28);
            this.BTNPesquisa.TabIndex = 13;
            this.BTNPesquisa.UseVisualStyleBackColor = true;
            this.BTNPesquisa.Click += new System.EventHandler(this.BTNPesquisa_Click);
            // 
            // TXTPesquisa
            // 
            this.TXTPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTPesquisa.Location = new System.Drawing.Point(6, 21);
            this.TXTPesquisa.MaxLength = 100;
            this.TXTPesquisa.Name = "TXTPesquisa";
            this.TXTPesquisa.Size = new System.Drawing.Size(474, 26);
            this.TXTPesquisa.TabIndex = 12;
            this.TXTPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTPesquisa_KeyDown);
            // 
            // BTNFechar
            // 
            this.BTNFechar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BTNFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNFechar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNFechar.Location = new System.Drawing.Point(351, 308);
            this.BTNFechar.Name = "BTNFechar";
            this.BTNFechar.Size = new System.Drawing.Size(82, 41);
            this.BTNFechar.TabIndex = 16;
            this.BTNFechar.Text = "Fechar";
            this.BTNFechar.UseVisualStyleBackColor = false;
            this.BTNFechar.Click += new System.EventHandler(this.BTNFechar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(439, 40);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 17;
            this.lblId.Visible = false;
            // 
            // FRMCadastro_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(996, 364);
            this.ControlBox = false;
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.BTNFechar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.DGPesquisa_usuario);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BTNGravar);
            this.Controls.Add(this.BTNLimpar);
            this.Controls.Add(this.BTNExcluir);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMCadastro_usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro  de usuário";
            this.Load += new System.EventHandler(this.FRMCadastro_usuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGPesquisa_usuario)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBAdm;
        private System.Windows.Forms.RadioButton RBComum;
        private System.Windows.Forms.Button BTNExcluir;
        private System.Windows.Forms.Button BTNLimpar;
        private System.Windows.Forms.Button BTNGravar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TXTSenha;
        private System.Windows.Forms.TextBox TXTMatricula_acesso;
        private System.Windows.Forms.TextBox TXTNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGPesquisa_usuario;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BTNPesquisa;
        private System.Windows.Forms.TextBox TXTPesquisa;
        private System.Windows.Forms.Button BTNFechar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;

    }
}