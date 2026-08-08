namespace AMD.Consultar_acesso
{
    partial class FRMConsultar_acesso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMConsultar_acesso));
            this.DGConsuta_acesso = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBLab = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNFechar = new System.Windows.Forms.Button();
            this.BTNConsultar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGConsuta_acesso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // DGConsuta_acesso
            // 
            this.DGConsuta_acesso.AllowUserToAddRows = false;
            this.DGConsuta_acesso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGConsuta_acesso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.DGConsuta_acesso.Location = new System.Drawing.Point(15, 235);
            this.DGConsuta_acesso.Name = "DGConsuta_acesso";
            this.DGConsuta_acesso.Size = new System.Drawing.Size(839, 440);
            this.DGConsuta_acesso.TabIndex = 50;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idAcesso";
            this.Column1.HeaderText = "idAcesso";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 5;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "data";
            this.Column2.HeaderText = "Data de Acesso";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Nome do Usuário";
            this.Column3.HeaderText = "Nome";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 250;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Matrícula";
            this.Column4.HeaderText = "Matrícula";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Nome do Computador";
            this.Column5.HeaderText = "Nome do Computador";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 155;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Laboratorio";
            this.Column6.HeaderText = "Laboratório";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 90;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Posicao";
            this.Column7.HeaderText = "Posição";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 80;
            // 
            // CBLab
            // 
            this.CBLab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBLab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBLab.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBLab.FormattingEnabled = true;
            this.CBLab.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.CBLab.Location = new System.Drawing.Point(414, 36);
            this.CBLab.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.CBLab.Name = "CBLab";
            this.CBLab.Size = new System.Drawing.Size(49, 27);
            this.CBLab.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "Laboratório: ";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(13, 43);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 52;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(266, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 124);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CBLab);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.groupBox1.Size = new System.Drawing.Size(482, 216);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione a data e o laboratório";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 42);
            this.label2.TabIndex = 55;
            this.label2.Text = "AMD";
            // 
            // BTNFechar
            // 
            this.BTNFechar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BTNFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNFechar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNFechar.Location = new System.Drawing.Point(727, 176);
            this.BTNFechar.Name = "BTNFechar";
            this.BTNFechar.Size = new System.Drawing.Size(127, 48);
            this.BTNFechar.TabIndex = 51;
            this.BTNFechar.Text = "Fechar";
            this.BTNFechar.UseVisualStyleBackColor = false;
            this.BTNFechar.Click += new System.EventHandler(this.BTNFechar_Click);
            // 
            // BTNConsultar
            // 
            this.BTNConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(32)))), ((int)(((byte)(25)))));
            this.BTNConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNConsultar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNConsultar.ForeColor = System.Drawing.Color.White;
            this.BTNConsultar.Location = new System.Drawing.Point(725, 17);
            this.BTNConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNConsultar.Name = "BTNConsultar";
            this.BTNConsultar.Size = new System.Drawing.Size(127, 55);
            this.BTNConsultar.TabIndex = 52;
            this.BTNConsultar.Text = "Consultar";
            this.BTNConsultar.UseVisualStyleBackColor = false;
            this.BTNConsultar.Click += new System.EventHandler(this.BTNConsultar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(502, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 95);
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(556, 118);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 54;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(621, 174);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.TabIndex = 55;
            this.pictureBox4.TabStop = false;
            // 
            // FRMConsultar_acesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(865, 685);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BTNFechar);
            this.Controls.Add(this.BTNConsultar);
            this.Controls.Add(this.DGConsuta_acesso);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMConsultar_acesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar acesso";
            ((System.ComponentModel.ISupportInitialize)(this.DGConsuta_acesso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGConsuta_acesso;
        private System.Windows.Forms.ComboBox CBLab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTNFechar;
        private System.Windows.Forms.Button BTNConsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}