using System;
using System.Windows.Forms;

namespace AMD.Desktop_AMD
{
    public partial class FRMdesktop_AMD_user_comun : Form
    {
      
        public FRMdesktop_AMD_user_comun()
        {
            InitializeComponent();
        }

        #region BTN Desligar
        private void BTNDesligar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            Desligar_computador.FRMDesligar_Reiniciar frm = new Desligar_computador.FRMDesligar_Reiniciar();
            frm.ShowDialog();
        }
        #endregion

        #region BTN Problema
        private void BTNProblema_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            Problema.FRMProblema_pc frm = new Problema.FRMProblema_pc();
            frm.ShowDialog();
        }
        #endregion

        #region BTN Alterar Senha
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            string mesagem = "Você deseja mesmo alterar sua senha?\nAtenção ao alterar sua senha sua maquina fara logo off e terá de fazer o acesso novamente!!!";
            string titulo = "Alterar sua senha?";

           

            MessageBoxButtons botao = MessageBoxButtons.YesNo;

            DialogResult resultado = MessageBox.Show(mesagem, titulo, botao);

            if (resultado == DialogResult.Yes)
            {
                Alterar_senha.Fundo frm = new Alterar_senha.Fundo();
                frm.ShowDialog();
            }
            else
            {
                this.Close();
            }
          
            
        }
        #endregion

        #region Desabilitando  Alt + F4
        private void FRMdesktop_AMD_user_comun_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            base.OnClosing(e);
        }
        #endregion

        #region AMD
        private void label1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            Actors.Sobre frm = new Actors.Sobre();
            frm.ShowDialog();
        }
        #endregion

        #region LOAD
        private void FRMdesktop_AMD_user_comun_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\System32\userinit.exe");
        }
        #endregion

        #region TXTProblema
        private void label2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            Problema.FRMProblema_pc frm = new Problema.FRMProblema_pc();
            frm.ShowDialog();
        }
        #endregion

        #region TXTAlterar Senha
        private void label3_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            string mesagem = "Você deseja mesmo alterar sua senha?\nAtenção ao alterar sua senha sua maquina fara logo off e terá de fazer o acesso novamente!!!";
            string titulo = "Alterar sua senha?";



            MessageBoxButtons botao = MessageBoxButtons.YesNo;

            DialogResult resultado = MessageBox.Show(mesagem, titulo, botao);

            if (resultado == DialogResult.Yes)
            {
                Alterar_senha.Fundo frm = new Alterar_senha.Fundo();
                frm.ShowDialog();
            }
            else
            {
                this.Close();
            }

        }
        #endregion

    }
}
