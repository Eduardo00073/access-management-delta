using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AMD.Cadastro
{
    public partial class FRMCadastro_computador : Form
    {
        public FRMCadastro_computador()
        {
            InitializeComponent();
        }

        #region BTN Gravar
        private void BTNGravar_Click_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
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
                        cmd.CommandText = "insert into Computador (Nome, Posicao, Laboratorio) values ( @Nome, @Posicao, @Laboratorio)";
                    }
                    else
                    {
                        cmd.CommandText = "update Computador set Nome = @Nome, Posicao = @Posicao, Laboratorio = @Laboratorio where idComputador = @idComputador";
                        cmd.Parameters.Add("@idComputador", SqlDbType.Int).Value = Convert.ToInt32(lblId.Text);
                    }
                    cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = Convert.ToString(TXTNome.Text);
                    cmd.Parameters.Add("@Laboratorio", SqlDbType.VarChar).Value = Convert.ToString(CBLaboratorio.Text);

                    if (radioButton1.Checked)
                        cmd.Parameters.Add("@Posicao", SqlDbType.Int).Value = 1;

                    else if (radioButton2.Checked)
                        cmd.Parameters.Add("@Posicao", SqlDbType.Int).Value = 2;

                    else if (radioButton3.Checked)
                        cmd.Parameters.Add("@Posicao", SqlDbType.Int).Value = 3;

                    else if (radioButton4.Checked)
                        cmd.Parameters.Add("@Posicao", SqlDbType.Int).Value = 4;

                    else if (radioButton5.Checked)
                        cmd.Parameters.Add("@Posicao", SqlDbType.Int).Value = 5;

                    else if (radioButton6.Checked)
                        cmd.Parameters.Add("@Posicao", SqlDbType.Int).Value = 6;

                    else if (radioButton7.Checked)
                        cmd.Parameters.Add("@Posicao", SqlDbType.Int).Value = 7;

                    else if (radioButton8.Checked)
                        cmd.Parameters.Add("@Posicao", SqlDbType.Int).Value = 8;

                    else if (radioButton9.Checked)
                        cmd.Parameters.Add("@Posicao", SqlDbType.Int).Value = 9;

                    else if (radioButton10.Checked)
                        cmd.Parameters.Add("@Posicao", SqlDbType.Int).Value = 10;

                    else if (radioButton11.Checked)
                        cmd.Parameters.Add("@Posicao", SqlDbType.Int).Value = 11;

                    else if (radioButton12.Checked)
                        cmd.Parameters.Add("@Posicao", SqlDbType.Int).Value = 12;

                    else if (radioButton13.Checked)
                        cmd.Parameters.Add("@Posicao", SqlDbType.Int).Value = 13;

                    else if (radioButton14.Checked)
                        cmd.Parameters.Add("@Posicao", SqlDbType.Int).Value = 14;

                    else if (radioButton15.Checked)
                        cmd.Parameters.Add("@Posicao", SqlDbType.Int).Value = 15;

                    else if (radioButton16.Checked)
                        cmd.Parameters.Add("@Posicao", SqlDbType.Int).Value = 16;

                    else if (radioButton17.Checked)
                        cmd.Parameters.Add("@Posicao", SqlDbType.Int).Value = 17;

                    else if (radioButton18.Checked)
                        cmd.Parameters.Add("@Posicao", SqlDbType.Int).Value = 18;

                    else if (radioButton19.Checked)
                        cmd.Parameters.Add("@Posicao", SqlDbType.Int).Value = 19;

                    else if (radioButton20.Checked)
                        cmd.Parameters.Add("@Posicao", SqlDbType.Int).Value = 20;

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
        private void BTNLimpar_Click_1(object sender, EventArgs e)
        {
            Limpar();
        }
        #endregion

        #region BTN Excluir
        private void BTNExcluir_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            SqlConnection conexao = new SqlConnection(Config.clsDados.StringDeConexao);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            conexao.Open();

            try
            {
                if (lblId.Text != "")
                {
                    cmd.CommandText = "delete from Acesso_Computador where idComputador = @idComputador";
                    cmd.Parameters.Add("@idComputador", SqlDbType.Int).Value = Convert.ToInt32(lblId.Text);
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();

                    cmd.CommandText = "delete from Computador where idComputador = @idComputador";
                    cmd.Parameters.Add("@idComputador", SqlDbType.Int).Value = Convert.ToInt32(lblId.Text);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                else
                {
                    MessageBox.Show("Selecione um Computador!");
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

        #region Função Validar
        private bool validar()
        {
            if (TXTNome.Text == "")
            {
                MessageBox.Show("Campo Nome PC deve ser prenchido!");
                TXTNome.Focus();
                return false;
            }
            else if (CBLaboratorio.Text == "")
            {
                MessageBox.Show("Campo Laboratorio deve ser Selecionado!");
                CBLaboratorio.Focus();
                return false;
            } 
            return true;
        }
        #endregion

        #region Função Limpar
        private void Limpar()
        {
            TXTNome.Text = "";
            lblId.Text = "";
            TXTPesquisa.Text = "";
            CBLaboratorio.SelectedIndex  = -1;
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
            radioButton14.Checked = false;
            radioButton15.Checked = false;
            radioButton16.Checked = false;
            radioButton17.Checked = false;
            radioButton18.Checked = false;
            radioButton19.Checked = false;
            radioButton20.Checked = false;
        }
        #endregion

        #region Função Pesquisar
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
                    cmd.CommandText = "select * from Computador";
                }
                else
                {
                    cmd.CommandText = "select * from Computador where Nome like '%" + nome.ToString() + "%'";
                }

                da.Fill(tb);
                cmd.Parameters.Clear();

                DGPesquisa_computador.DataSource = tb;
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

        #region BTN Pesquisar
        private void BTNPesquisa_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            Pesquisa(TXTPesquisa.Text);
        }
        #endregion

        #region DV
        private void DGPesquisa_computador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = DGPesquisa_computador[0, DGPesquisa_computador.CurrentRow.Index].Value.ToString();
            TXTNome.Text = DGPesquisa_computador[3, DGPesquisa_computador.CurrentRow.Index].Value.ToString();
            CBLaboratorio.Text = DGPesquisa_computador[1, DGPesquisa_computador.CurrentRow.Index].Value.ToString();

            int posicao = int.Parse(DGPesquisa_computador[2, DGPesquisa_computador.CurrentRow.Index].Value.ToString());

            if (posicao == 1)
            {
                radioButton1.Checked = true;
            }

            else if (posicao == 2)
            {
                radioButton2.Checked = true;
            }

            else if (posicao == 3)
            {
                radioButton3.Checked = true;
            }

            else if (posicao == 4)
            {
                radioButton4.Checked = true;
            }

            else if (posicao == 5)
            {
                radioButton5.Checked = true;
            }

            else if (posicao == 6)
            {
                radioButton6.Checked = true;
            }

            else if (posicao == 7)
            {
                radioButton7.Checked = true;
            }

            else if (posicao == 8)
            {
                radioButton8.Checked = true;
            }

            else if (posicao == 9)
            {
                radioButton9.Checked = true;
            }
            else if (posicao == 10)
            {
                radioButton10.Checked = true;
            }

            else if (posicao == 11)
            {
                radioButton11.Checked = true;
            }

            else if (posicao == 12)
            {
                radioButton12.Checked = true;
            }

            else if (posicao == 13)
            {
                radioButton13.Checked = true;
            }

            else if (posicao == 14)
            {
                radioButton14.Checked = true;
            }

            else if (posicao == 15)
            {
                radioButton15.Checked = true;
            }

            else if (posicao == 16)
            {
                radioButton16.Checked = true;
            }

            else if (posicao == 17)
            {
                radioButton17.Checked = true;
            }

            else if (posicao == 18)
            {
                radioButton18.Checked = true;
            }

            else if (posicao == 19)
            {
                radioButton19.Checked = true;
            }

            else if (posicao == 20)
            {
                radioButton20.Checked = true;
            }
         }
        #endregion

        #region Cadastro Computador
        private void FRMCadastro_computador_Load(object sender, EventArgs e)
        {
            Pesquisa(TXTPesquisa.Text);
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
