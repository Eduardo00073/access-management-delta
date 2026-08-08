using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace AMD.Cadastro
{
    public partial class FRMCadastro_usuario : Form
    {

        public FRMCadastro_usuario()
        {
            InitializeComponent();
        }

        #region BNT Gravar
        private void BTNGravar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                SqlConnection conexao = new SqlConnection(Config.clsDados.StringDeConexao);
                SqlCommand cmd = new SqlCommand();
                SqlTransaction ts;
                bool gravou = false;
                cmd.Connection = conexao;
                conexao.Open();
                ts = conexao.BeginTransaction();

                try
                {
                    if (lblId.Text == "")
                    {
                        cmd.CommandText = "insert into Usuario (Nome, Matricula_Acesso, Senha, Permissao) values ( @Nome, @Matricula_Acesso, @Senha, @Permissao)";
                    }
                    else
                    {
                        cmd.CommandText = "update Usuario set Nome = @Nome, Matricula_Acesso = @Matricula_Acesso, Senha = @Senha, Permissao = @Permissao where idUsuario = @idUsuario";
                        cmd.Parameters.Add("@idUsuario", SqlDbType.Int).Value = Convert.ToInt32(lblId.Text);
                    }
                    cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = Convert.ToString(TXTNome.Text);
                    cmd.Parameters.Add("@Matricula_Acesso", SqlDbType.VarChar).Value = Convert.ToString(TXTMatricula_acesso.Text);
                    cmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = Convert.ToString (TXTSenha.Text);

                    if (RBComum.Checked)

                        cmd.Parameters.Add("@Permissao", SqlDbType.Bit).Value = 0;
                    else
                        cmd.Parameters.Add("@Permissao", SqlDbType.Bit).Value = 1;

                    cmd.Transaction = ts;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    gravou = true;

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro: " + ex);
                }

                finally
                {
                    if (ts != null)
                    {
                        if (gravou)
                        {
                            ts.Commit();
                            Limpar();
                            Pesquisa(TXTPesquisa.Text);
                        }
                        else
                            ts.Rollback();
                    }

                    if (conexao.State == ConnectionState.Open)
                        conexao.Close();
                    conexao.Dispose();
                }
            }
        }
        #endregion

        #region BTN Limpar
        private void BTNLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        #endregion

        #region BTN Excluir
        private void BTNExcluir_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(Config.clsDados.StringDeConexao);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            conexao.Open();

            try
            {
                if (lblId.Text != "")
                {
                    cmd.CommandText = "delete from Acesso_Computador where idUsuario = @idUsuario";
                    cmd.Parameters.Add("@idUsuario", SqlDbType.Int).Value = Convert.ToInt32(lblId.Text);
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();

                    cmd.CommandText = "delete from Usuario where idUsuario = @idUsuario";
                    cmd.Parameters.Add("@idUsuario", SqlDbType.Int).Value = Convert.ToInt32(lblId.Text);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                else
                {
                    MessageBox.Show("Selecione um usuário!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();
                conexao.Dispose();
                Limpar();
                Pesquisa("");
            }
        }
        #endregion

        #region BTN Fechar
        private void BTNFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region BTN Pesquisa
        private void BTNPesquisa_Click(object sender, EventArgs e)
        {
            Pesquisa(TXTPesquisa.Text);
        }
        #endregion

        #region PERMITIR APENAS NÚMEROS NO TEXBOX MATRICULA(acesso)
        private void TXTMatricula_acesso_KeyPress(object sender, KeyPressEventArgs e)
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

        #region Função Limpar
        private void Limpar()
        {
            lblId.Text = "";
            TXTMatricula_acesso.Text = "";
            TXTNome.Text = "";
            TXTSenha.Text = "";
            TXTPesquisa.Text = "";
            RBComum.Checked = true;
            RBAdm.Checked = false;
        }
        #endregion

        #region Função Validar
        private bool validar()
        {
            if (TXTNome.Text == "")
            {
                MessageBox.Show("Campo Nome deve ser prenchido!");
                TXTNome.Focus();
                return false;
            }
            else if (TXTMatricula_acesso.Text == "")
            {
                MessageBox.Show("Campo Matricula (Acesso) deve ser preenchido!");
                TXTMatricula_acesso.Focus();
                return false;
            }
            else if (TXTSenha.Text.Length < 5)
            {
                MessageBox.Show("Campo Senha deve ser preenchido com no mínimo 5 caracteres!");
                TXTSenha.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region Função Pesquisa
        private void Pesquisa(string nome)
        {
            Limpar();
            SqlConnection conexao = new SqlConnection(Config.clsDados.StringDeConexao);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;

            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            conexao.Open();

            try
            {
                if (nome == "")
                {
                    cmd.CommandText = "select * from Usuario";
                }
                else
                {
                    cmd.CommandText = "select * from Usuario where Nome like '%" + nome.ToString() + "%'";
                }

                da.Fill(tb);
                cmd.Parameters.Clear();

                DGPesquisa_usuario.DataSource = tb;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();
                conexao.Dispose();
            }
        }

        #endregion

        #region Cadastro de usuário
        private void FRMCadastro_usuario_Load(object sender, EventArgs e)
        {
            Pesquisa(TXTPesquisa.Text);
        }
        #endregion

        #region DG
        private void DGPesquisa_usuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = DGPesquisa_usuario[0, DGPesquisa_usuario.CurrentRow.Index].Value.ToString();
            TXTNome.Text = DGPesquisa_usuario[3, DGPesquisa_usuario.CurrentRow.Index].Value.ToString();
            TXTMatricula_acesso.Text = DGPesquisa_usuario[1, DGPesquisa_usuario.CurrentRow.Index].Value.ToString();
            TXTSenha.Text = DGPesquisa_usuario[2, DGPesquisa_usuario.CurrentRow.Index].Value.ToString();

            bool tipo = bool.Parse(DGPesquisa_usuario[4, DGPesquisa_usuario.CurrentRow.Index].Value.ToString());

            if(tipo)
                RBAdm.Checked = true;
            else
                RBComum.Checked = true;

        }
        #endregion

        private void TXTPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BTNPesquisa_Click(sender, e);
            }
        }


    }
}