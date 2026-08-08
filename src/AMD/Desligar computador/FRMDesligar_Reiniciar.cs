using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace AMD.Desligar_computador
{
    public partial class FRMDesligar_Reiniciar : Form
    {

        public FRMDesligar_Reiniciar()
        {
            InitializeComponent();
        }

        #region Cancelar
        private void BNTCancelar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            this.Dispose();
        }
        #endregion

        #region Desligar
        private void BTNDesligar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            Process.Start("Shutdown","/s /f /t 00");
        }
        #endregion

        #region Reiniciar
        private void BTNReiniciar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            Process.Start("Shutdown", "/r /f /t 00");
        }
        #endregion

        #region Desabilitando Alt + F4
        private void FRMDesligar_Reiniciar_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            base.OnClosing(e);
        }
        #endregion

        private void label3_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            Process.Start("Shutdown", "/r /f /t 00");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            Process.Start("Shutdown", "/s /f /t 00");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("Shutdown", "/l /f");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Process.Start("Shutdown", "/l /f");
        }
    }

}
