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
using System.Data.SqlClient;
using Microsoft.Win32;
using System.Security.Principal;


namespace AMD
{

    public partial class Acesso : Form
    {

        #region Variaveis Publicas

        public int idAcessoPublica;

        public bool logado = false;

        public bool permissao = false;

        int idAcesso;

        public string NomeMaquina = System.Net.Dns.GetHostName();

        #endregion

        public Acesso()
        {
            InitializeComponent();
        }

        #region Função Limpar
        private void Limpar()
        {
            TXTacesso.Text = "";
            TXTsenha.Text = "";
        }
        #endregion

        #region  PERMITIR APENAS NÚMEROS NO TEXBOX MATRICULA(acesso)
        private void TXTacesso_KeyPress(object sender, KeyPressEventArgs e)
        {
            //PERMITIR APENAS NÚMEROS
            if (char.IsLetter(e.KeyChar) || //Letras
            char.IsSymbol(e.KeyChar) || //Símbolos
            char.IsWhiteSpace(e.KeyChar) || //Espaço
            char.IsPunctuation(e.KeyChar)) //Pontuação
                e.Handled = true; //Não permitir
            //Com o script acima é possível utilizar Números, 'Del', 'BackSpace'
        }
        #endregion

        #region Função Validar
        private bool validar()
        {
            if (TXTacesso.Text == "" || TXTsenha.Text == "")
            {
                MessageBox.Show("O campo Acesso deve ser preenchido com o numero do seu RM! \nO campo da senha deve ser preenchido com seu RM caso não tenha alterando sua senha ainda.");
                TXTacesso.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region BTN Acessar
        private void BTNAcessar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;

            validar();
            string usuario, senha, VNomePC;

            string AdminAMDAcesso = "admin";
            string AdminAMDSenha = "admin@123";

            string ComumAMDAcesso = "aluno";
            string ComumAMDSenha = "aluno@123";

            {
                usuario = TXTacesso.Text;
                senha = TXTsenha.Text;
                VNomePC = LBpc.Text;
                if (usuario == AdminAMDAcesso && senha == AdminAMDSenha)
                {
                    logado = true;
                    permissao = true;
                    this.Dispose();
                }
                else if (usuario == ComumAMDAcesso && senha == ComumAMDSenha)
                {
                    logado = true;
                    permissao = false;
                    this.Dispose();
                }
                else
                {

                    SqlConnection conexao = new SqlConnection(Config.clsDados.StringDeConexao);

                    try
                    {
                        conexao.Open();
                        string _Sql_idUser = string.Empty;
                        string _Sql = string.Empty;

                        string _Sql_PC = string.Empty;
                        Object nome;
                        string nomePC;
                        string _Sql_idAcesso = string.Empty;



                        _Sql = "SELECT COUNT(idUsuario) FROM Usuario WHERE Matricula_Acesso = @Matricula_Acesso AND Senha = @Senha";

                        SqlCommand cmd = new SqlCommand(_Sql, conexao);

                        cmd.Parameters.Add("@Matricula_Acesso", SqlDbType.VarChar).Value = usuario;
                        cmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = senha;

                        int Usuario_tem_permissao_de_acesso = (int)cmd.ExecuteScalar();

                        if (Usuario_tem_permissao_de_acesso > 0)
                        {
                            _Sql_PC = "SELECT COUNT(idComputador) FROM Computador WHERE Nome = @Nome";
                            new SqlCommand(_Sql_PC);
                            cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = VNomePC;
                            int a = (int)cmd.ExecuteScalar();

                            if (a > 0)
                            {

                                cmd.Parameters.Clear();

                                cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = VNomePC;
                                cmd.CommandText = "SELECT(idComputador) FROM Computador WHERE Nome = @Nome";
                                nome = cmd.ExecuteScalar();

                                if (nome != null)
                                {
                                    nomePC = nome.ToString();


                                    cmd.Parameters.Clear();

                                    cmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = senha;
                                    cmd.Parameters.Add("@Matricula_Acesso", SqlDbType.VarChar).Value = usuario;
                                    cmd.CommandText = "select(idUsuario) from Usuario where Matricula_Acesso = @Matricula_Acesso and Senha = @Senha";
                                    int idUser = Convert.ToInt32(cmd.ExecuteScalar());

                                    cmd.Parameters.Clear();

                                    SqlTransaction ts;
                                    bool gravou_acesso = false;
                                    ts = conexao.BeginTransaction();

                                    try
                                    {
                                        cmd.CommandText = "insert into Acesso_Computador (idComputador, idUsuario, Data) values ( @idComputador, @idUsuario, @Data) set @id = SCOPE_IDENTITY()";
                                        cmd.Parameters.AddWithValue("@idComputador", Convert.ToInt32(nome));
                                        cmd.Parameters.AddWithValue("@idUsuario", idUser);
                                        DateTime HORAINICIAL = DateTime.Now;
                                        cmd.Parameters.AddWithValue("@Data", Convert.ToDateTime(HORAINICIAL));
                                        cmd.Parameters.AddWithValue("@id", 0).Direction = ParameterDirection.Output;

                                        cmd.Transaction = ts;
                                        cmd.ExecuteNonQuery();

                                        idAcessoPublica = Convert.ToInt32(cmd.Parameters["@id"].Value);
                                        AMD.Config.idAcessoClass.VarPublic = idAcessoPublica;

                                        cmd.Parameters.Clear();
                                        gravou_acesso = true;
                                    }
                                    catch (SqlException ex)
                                    {
                                        MessageBox.Show("Erro: " + ex);
                                    }

                                    finally
                                    {
                                        if (ts != null)
                                        {
                                            if (gravou_acesso)
                                            {
                                                ts.Commit();

                                            }
                                            else
                                                ts.Rollback();
                                        }

                                    }

                                    cmd.Parameters.Clear();

                                    cmd.Parameters.Add("@Matricula_Acesso", SqlDbType.VarChar).Value = usuario;
                                    cmd.CommandText = "SELECT(Permissao) FROM Usuario WHERE Matricula_Acesso = @Matricula_Acesso";
                                    permissao = bool.Parse(cmd.ExecuteScalar().ToString());

                                    cmd.Parameters.Clear();

                                    cmd.Parameters.Add("@Matricula_Acesso", SqlDbType.VarChar).Value = usuario;
                                    _Sql_idAcesso = "SELECT(idAcesso) FROM Acesso_Computador WHERE Nome = @Matricula_Acesso";
                                    new SqlCommand(_Sql_idAcesso);
                                    idAcesso = Convert.ToInt32(cmd.ExecuteScalar());

                                    cmd.Parameters.Clear();

                                    conexao.Close();
                                    conexao.Dispose();
                                    logado = true;
                                    this.Dispose();
                                   
                                }
                                else
                                {
                                    MessageBox.Show("O cadastro deste computador não foi efetuado, por favor acesse outra máquina e relate que o mesmo (" + LBpc.Text + ") não esta no cadastro de computadores");
                                    logado = false;
                                    Limpar();
                                }
                            }

                        }

                        else
                        {
                            if (TXTacesso.Text != "" && TXTsenha.Text != "")
                                MessageBox.Show("Número da Matricula ou Senha esta incorreto");
                            logado = false;
                            Limpar();
                        }

                    }

                    catch (SqlException)
                    {
                        MessageBox.Show("Erro sem acesso ao servidor.\nFavor verificar se o cabo de rede está conectado.\nCaso não seja possível fazer a conexão favor reportar o ocorrido por outra maquina.\n");
                        conexao.Close();
                        conexao.Dispose();
                    }
                }
            }
        }
        #endregion

        #region BTN Desligar
        private void BTNDesligar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            Desligar_computador.FRMDesligar_Reiniciar frm = new Desligar_computador.FRMDesligar_Reiniciar();
            frm.ShowDialog();
        }
        #endregion

        #region Nome PC LOAD
        private void Acesso_Load(object sender, EventArgs e)
        {
            LBpc.Text = System.Net.Dns.GetHostName();
            KillCtrlAltDelete();
        }
        #endregion

        #region Desabilitar TaskMgr

        public void KillCtrlAltDelete()
        {
            RegistryKey regkey;
            string keyValueInt = "00000001";
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

        #region KeyDown
        private void TXTacesso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXTsenha.Focus();
            }
        }

        private void TXTsenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BTNAcessar_Click(sender, e);
            }
        }
        #endregion

        #region Bloqueio de teclas
        private void Acesso_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            base.OnClosing(e);
        }
        #endregion

        #region BTN Ajuda
        private void BTNAjuda_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            Ajuda.Ajuda_acesso frm = new Ajuda.Ajuda_acesso();
            frm.ShowDialog();
        }
        #endregion
    }
}
