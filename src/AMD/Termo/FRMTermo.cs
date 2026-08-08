using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Security.Principal;

namespace AMD.Termo
{
    public partial class FRMTermo : Form
    {
        
        public FRMTermo()
        {
            InitializeComponent();

        }

        #region BTN Recusar
        private void Recusar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            Process.Start("TASKKILL", "/f /im * AMD.exe /t");
            Application.Restart();
            this.Dispose();
        }
        #endregion

        #region BTN Aceitar
        private void BTNAceitar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            this.Dispose();
            Desktop_AMD.FRMdesktop_AMD_user_comun frm = new Desktop_AMD.FRMdesktop_AMD_user_comun();
            frm.ShowDialog();
           
        }
        #endregion 

        #region Bloqueio de teclas
        private void FRMTermo_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            base.OnClosing(e);
        }

        #endregion

        #region  Video de Ajuda
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\AMD\AMD\Ajuda\Ajuda.mp4";
        }
        #endregion


    }
}
