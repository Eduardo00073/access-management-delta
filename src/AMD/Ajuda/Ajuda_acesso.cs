using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Security.Principal;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace AMD.Ajuda
{
    public partial class Ajuda_acesso : Form
    {
    

        public Ajuda_acesso()
        {
            InitializeComponent();
        }

        #region Fechar
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion

        #region Bloqueio
        private void Ajuda_acesso_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            base.OnClosing(e);
        }
        #endregion

    }
}
