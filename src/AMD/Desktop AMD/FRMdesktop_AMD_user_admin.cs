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

namespace AMD.Desktop_AMD
{
    public partial class FRMdesktop_AMD_user_admin : Form
    {

        public FRMdesktop_AMD_user_admin()
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

        #region BTN Cadastro USER
        private void BTNCadastro_USER_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            Cadastro.FRMCadastro_usuario frm = new Cadastro.FRMCadastro_usuario();
            frm.ShowDialog();
        }
        #endregion

        #region BTN Cadastro PC
        private void BTNCadastro_PC_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            Cadastro.FRMCadastro_computador frm = new Cadastro.FRMCadastro_computador();
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

        #region BTN Acesso
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            Consultar_acesso.FRMConsultar_acesso frm = new Consultar_acesso.FRMConsultar_acesso();
            frm.ShowDialog();
        }
        #endregion

        #region Alterar Senha
        private void pictureBox2_Click(object sender, EventArgs e)
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

        #region Habilitando TaskMgr
        public static void EnableCTRLALTDEL()  
        {
            RegistryKey regkey;
            string keyValueInt = "00000000";
            string subKey = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";

            try
            {
                regkey = Registry.CurrentUser.CreateSubKey(subKey);
                regkey.SetValue("DisableTaskMgr", keyValueInt);
                regkey.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region Bloqueio Alt + F4
        private void FRMdesktop_AMD_user_admin_FormClosing(object sender, FormClosingEventArgs e)
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
        private void FRMdesktop_AMD_user_admin_Load(object sender, EventArgs e)
        {
            EnableCTRLALTDEL();
            System.Diagnostics.Process.Start(@"C:\Windows\System32\userinit.exe");
        }
        #endregion

        #region TXTCadastro de Usuário
        private void label2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            Cadastro.FRMCadastro_usuario frm = new Cadastro.FRMCadastro_usuario();
            frm.ShowDialog();
        }
        #endregion

        #region TXTCadastro de Computadores
        private void label3_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            Cadastro.FRMCadastro_computador frm = new Cadastro.FRMCadastro_computador();
            frm.ShowDialog();
        }
        #endregion

        #region TXTAcesso
        private void label5_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            Consultar_acesso.FRMConsultar_acesso frm = new Consultar_acesso.FRMConsultar_acesso();
            frm.ShowDialog();
        }
        #endregion

        #region TXTProblema
        private void label4_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            Problema.FRMProblema_pc frm = new Problema.FRMProblema_pc();
            frm.ShowDialog();
        }
        #endregion

        #region TXTAlterar Senha 
        private void label6_Click(object sender, EventArgs e)
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
