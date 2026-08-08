using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.Web;
using System.Net.Mail;
using System.Net.Mime;
using System.Data.SqlClient;

namespace AMD.Problema
{
    public partial class FRMProblema_pc : Form
    {
        public FRMProblema_pc()
        {
            InitializeComponent();
        }

        #region Variaves

        int VarPublicAcesso = AMD.Config.idAcessoClass.VarPublic;

        string fios;
        string monitornaofuncional;
        string mouse;
        string outrosproblemas;
        string programacomerro;
        string sistemaoperacional;
        string teclado;
        string windows;
        string descrição;

        #endregion

        #region BTN Enviar
        private void BTNEnviar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            //if (validar())
            //{
            //    //Criando um objeto do tipo MailMessage
            //    MailMessage message = new MailMessage();

            //    //Estes 2 campos corresponde a quem está enviando o e-mail
            //    message.Sender = new MailAddress("amdelta073@gmail.com");
            //    message.From = new MailAddress("amdelta073@gmail.com");

            //    //Aqui você coloca para quem você quer enviar o e-mail
            //    //message.To.Add(new MailAddress("eduardo_junior_nene@hotmail.com"));
            //    message.To.Add(new MailAddress("mauro.pires@etec.sp.gov.br"));

            //    //Aqui você coloca o assunto
            //    message.Subject = "Problema na Máquina";

            //    //E aqui você coloca o corpo do e-mail

            //    string Mensagem = "O usuário de matrícula: " + matricula.Text + ", cujo nome é " + text1.Text + " identificou que há problemas.\n" + "Laboratório: " + label4.Text + ", equipamento localizado na posição: " + label2.Text + ".\n" + "Seu nome é especificado como: " + label3.Text + ".\n";

            //    if (CBFios_do_PC_nao_funciona.Checked == true)
            //    {
            //        fios = CBFios_do_PC_nao_funciona.Text;
            //    }
            //    if (CBMonitor_nao_funcional.Checked == true)
            //    {
            //        monitornaofuncional = CBMonitor_nao_funcional.Text;
            //    }
            //    if (CBMouse_nao_funcional.Checked == true)
            //    {
            //        mouse = CBMouse_nao_funcional.Text;
            //    }
            //    if (CBOutros_problemas_nesta_ou_em_outra_maquina.Checked == true)
            //    {
            //        outrosproblemas = CBOutros_problemas_nesta_ou_em_outra_maquina.Text;
            //    }
            //    if (CBPrograma_com_erro.Checked == true)
            //    {
            //        programacomerro = CBPrograma_com_erro.Text;
            //    }
            //    if (CBSistema_operacional_com_erro.Checked == true)
            //    {
            //        sistemaoperacional = CBSistema_operacional_com_erro.Text;
            //    }
            //    if (CBTeclado_nao_funcional.Checked == true)
            //    {
            //        teclado = CBTeclado_nao_funcional.Text;
            //    }
            //    if (CBWindows_com_tela_azul.Checked == true)
            //    {
            //        windows = CBWindows_com_tela_azul.Text;
            //    }
            //    if (TXTDescricao.Text != "")
            //    {
            //        descrição = TXTDescricao.Text;
            //    }
            //    message.Body = Mensagem + "O problema baseia-se em: " + " " + fios + " " + monitornaofuncional + " " + mouse + " " + outrosproblemas + " " + programacomerro + " " + sistemaoperacional + " " + teclado + " " + windows + " Descrição do usuário: " + descrição;

            //    //Se o corpo do e-mail for HTML, coloque o IsBodyHtml = true, caso contrário, = false
            //    message.IsBodyHtml = false;

            //    //Smtp
            //    SmtpClient smtp = new SmtpClient();

            //    //Aqui você coloca seu usuário e senha
            //    smtp.Credentials = new NetworkCredential("amdelta073@gmail.com", "delta4x0002");

            //    //Caso o servidor tenha SSL, habilite utilizando true
            //    smtp.EnableSsl = true;

            //    //Aqui é o endereços do SMTP
            //    smtp.Host = "smtp.gmail.com";

            //    //É a porta utilizada para a conexão
            //    smtp.Port = 587;

            //    //Envia o e-mail :)
            //    smtp.Send(message);

            //    //É só pra saber que enviamos
                MessageBox.Show("Seu problema foi reportado com sucesso!!\nTraves de em E-mail para o Técnico de informática da instituição");

                this.Dispose();
           // }
        }
        #endregion

        #region BTN Limpar
        private void BTNLimpar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            Limpar();
        }
        #endregion

        #region BTN Fechar
        private void BTNFechar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            this.Dispose();
        }
        #endregion

        #region Função Validar
        private bool validar()
        {
          if (TXTDescricao.Text == "")
            {
                MessageBox.Show("Prencha a Descriçao Porfavor");
                TXTDescricao.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region Função Limpar
        private void Limpar()
        {
            CBSistema_operacional_com_erro.Checked = false;
            CBWindows_com_tela_azul.Checked = false;
            CBPrograma_com_erro.Checked = false;
            CBMouse_nao_funcional.Checked = false;
            CBTeclado_nao_funcional.Checked = false;
            CBMonitor_nao_funcional.Checked = false;
            CBFios_do_PC_nao_funciona.Checked = false;
            CBOutros_problemas_nesta_ou_em_outra_maquina.Checked = false;
            TXTDescricao.Text = "";
        }



        #endregion

        #region Problema LOAD
        private void FRMProblema_pc_Load(object sender, EventArgs e)
        {
            label3.Text = System.Net.Dns.GetHostName();

            SqlConnection conexao = new SqlConnection(Config.clsDados.StringDeConexao);
            conexao.Open();

            SqlCommand cmd = new SqlCommand("select u.Nome from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario where ac.idAcesso = @idAcesso group by u.Nome", conexao);
            cmd.Parameters.Add("@idAcesso", SqlDbType.Int).Value = VarPublicAcesso;
            text1.Text = Convert.ToString(cmd.ExecuteScalar());

            cmd.Parameters.Clear();

            SqlCommand sql = new SqlCommand("select c.Laboratorio from Acesso_Computador ac inner join Computador c on c.idComputador = ac.idComputador where ac.idAcesso = @idAcesso group by c.Laboratorio", conexao);
            sql.Parameters.Add("@idAcesso", SqlDbType.Int).Value = VarPublicAcesso;
            label4.Text = Convert.ToString(sql.ExecuteScalar());

            sql.Parameters.Clear();

            SqlCommand scd = new SqlCommand("select c.Posicao from Acesso_Computador ac inner join Computador c on c.idComputador = ac.idComputador where ac.idAcesso = @idAcesso group by c.Posicao", conexao);
            scd.Parameters.Add("@idAcesso", SqlDbType.Int).Value = VarPublicAcesso;
            label2.Text = Convert.ToString(scd.ExecuteScalar());

            scd.Parameters.Clear();

            SqlCommand SCO = new SqlCommand("select u.Matricula_Acesso from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario where ac.idAcesso = @idAcesso group by u.Matricula_Acesso", conexao);
            SCO.Parameters.Add("@idAcesso", SqlDbType.Int).Value = VarPublicAcesso;
            matricula.Text = Convert.ToString(SCO.ExecuteScalar());

            SCO.Parameters.Clear();

            conexao.Close();
            conexao.Dispose();

            CBSistema_operacional_com_erro.Focus();
        }
        #endregion

        #region KeyDown
        private void CBSistema_operacional_com_erro_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                CBSistema_operacional_com_erro.Checked = true;
            }
        }

        private void CBWindows_com_tela_azul_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CBWindows_com_tela_azul.Checked = true;
            }
        }

        private void CBPrograma_com_erro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CBPrograma_com_erro.Checked = true;
            }
        }

        private void CBMouse_nao_funcional_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CBMouse_nao_funcional.Checked = true;
            }
        }

        private void CBTeclado_nao_funcional_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CBTeclado_nao_funcional.Checked = true;
            }
        }

        private void CBMonitor_nao_funcional_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                CBMonitor_nao_funcional.Checked = true;
            }
        }

        private void CBFios_do_PC_nao_funciona_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CBFios_do_PC_nao_funciona.Checked = true;
            }
        }

        private void CBOutros_problemas_nesta_ou_em_outra_maquina_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CBOutros_problemas_nesta_ou_em_outra_maquina.Checked = true;
            }
        }

        private void TXTDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BTNEnviar_Click(sender, e);
            }
        }
        #endregion
    }
}
