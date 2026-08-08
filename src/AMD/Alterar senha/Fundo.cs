using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMD.Alterar_senha
{
    public partial class Fundo : Form
    {
        public Fundo()
        {
            InitializeComponent();
        }

        private void Fundo_Load(object sender, EventArgs e)
        {
            Alterar_senha.AlterarSenha frm = new Alterar_senha.AlterarSenha();
            frm.ShowDialog();
        }
    }
}
