using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace AMD.Alterar_senha
{
    public partial class AlterarSenha : Form
    {
        private Random rand = new Random();
        public AlterarSenha()
        {
            InitializeComponent();
        }

        #region Variáveis
        int id = AMD.Config.idAcessoClass.VarPublic;
        #endregion

        private void CreateImage()
        {
            string code = GetRandomText();

            Bitmap bitmap = new Bitmap(200, 50, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bitmap);
            Pen pen = new Pen(Color.Yellow);
            Rectangle rect = new Rectangle(0, 0, 200, 50);

            SolidBrush b = new SolidBrush(Color.Black);
            SolidBrush White = new SolidBrush(Color.White);

            int counter = 0;

            g.DrawRectangle(pen, rect);
            g.FillRectangle(b, rect);

            for (int i = 0; i < code.Length; i++)
            {
                g.DrawString(code[i].ToString(), new Font("Georgia", 10 + rand.Next(14, 18)), White, new PointF(10 + counter, 10));
                counter += 20;
            }

            DrawRandomLines(g);

            if (File.Exists("C:\\amd\\amd\\tempimage.bmp"))
            {

                try
                {
                    File.Delete("C:\\amd\\amd\\tempimage.bmp");
                    bitmap.Save("C:\\amd\\amd\\tempimage.bmp");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                bitmap.Save("C:\\amd\\amd\\tempimage.bmp");

            }

            g.Dispose();
                bitmap.Dispose();
                pictureBox1.Image = Image.FromFile("C:\\amd\\amd\\tempimage.bmp");

            }
        
        private void DrawRandomLines(Graphics g)
        {
            SolidBrush green = new SolidBrush(Color.Green);
            for (int i = 0; i < 20; i++)
            {
                g.DrawLines(new Pen(green, 2), GetRandomPoints());
            }

        }
        private Point[] GetRandomPoints()
        {
            Point[] points = { new Point(rand.Next(10, 150), rand.Next(10, 150)), new Point(rand.Next(10, 100), rand.Next(10, 100)) };
            return points;
        }

        string code;
        private string GetRandomText()
        {
            StringBuilder randomText = new StringBuilder();

            if (String.IsNullOrEmpty(code))
            {
                string alphabets = "abcdefghijklmnopqrstuvwxyz1234567890";

                Random r = new Random();
                for (int j = 0; j <= 5; j++)
                {

                    randomText.Append(alphabets[r.Next(alphabets.Length)]);
                }

                code = randomText.ToString();
            }

            return code;
        }
        #region BTNConfirmar
        private void BTNConfirmar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            if (textBox1.Text == code.ToString())
            {
                if (validar())
                {
                    if (ls.Text == TXTsenhaAtual.Text && TBXSenha.Text == TBXNovaSenha.Text)
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

                            SqlConnection connection = new SqlConnection(Config.clsDados.StringDeConexao);
                            connection.Open();

                            SqlCommand cls = new SqlCommand("select u.idUsuario from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario where ac.idAcesso = @idAcesso group by u.idUsuario", connection);
                            cls.Parameters.Add("@idAcesso", SqlDbType.Int).Value = id;
                            int idusuario = Convert.ToInt32(cls.ExecuteScalar());
                            cls.Parameters.Clear();

                            if (connection.State == ConnectionState.Open)
                            {
                                connection.Close();
                            }
                            connection.Dispose();

                            cmd.CommandText = "update Usuario set Senha = @senha where idUsuario = @idUsuario";
                            cmd.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idusuario;
                            cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = TBXNovaSenha.Text;
                            cmd.Transaction = ts;
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                            gravou = true;

                            MessageBox.Show("Senha alterada com sucesso");
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
                                }
                                else
                                {
                                    ts.Rollback();
                                }
                            }
                            if (conexao.State == ConnectionState.Open)
                            {
                                conexao.Close();
                            }
                            conexao.Dispose();

                            Process.Start("Shutdown", "/l /f");

                        }
                    }
                    else
                    {
                        MessageBox.Show("As senha não coincidem.\nTente novamente.");
                        Limpar();
                    }
                }
            }
            else
            {
                validar();
                pictureBox1.Image.Dispose();
                code = "";
                textBox1.Text = "";
                CreateImage();
                MessageBox.Show("Texto de verificação incorreto");

            }
        }
        
        #endregion

        #region BTNFechar

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("Shutdown", "/l /f");
            this.Dispose();
        }
        #endregion

        #region BTN Alterar Senha

        private void AlterarSenha_Load(object sender, EventArgs e)
        {
            CreateImage();
            

            SqlConnection conexao = new SqlConnection(Config.clsDados.StringDeConexao);
            conexao.Open();

            SqlCommand cls = new SqlCommand("select u.Senha from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario where ac.idAcesso = @idAcesso group by u.Senha", conexao);
            cls.Parameters.Add("@idAcesso", SqlDbType.Int).Value = id;
            ls.Text = Convert.ToString(cls.ExecuteScalar());
            cls.Parameters.Clear();

            SqlCommand SCO = new SqlCommand("select u.Matricula_Acesso from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario where ac.idAcesso = @idAcesso group by u.Matricula_Acesso", conexao);
            SCO.Parameters.Add("@idAcesso", SqlDbType.Int).Value = id;
            label2.Text = Convert.ToString(SCO.ExecuteScalar());
            SCO.Parameters.Clear();

            SqlCommand cmd = new SqlCommand("select u.Nome from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario where ac.idAcesso = @idAcesso group by u.Nome", conexao);
            cmd.Parameters.Add("@idAcesso", SqlDbType.Int).Value = id;
            label3.Text = Convert.ToString(cmd.ExecuteScalar());
            cmd.Parameters.Clear();

        }
        #endregion

        #region Função Validar
        private bool validar()
        {
            if (TBXSenha.Text.Length < 5 && TBXNovaSenha.Text.Length < 5)
            {
                MessageBox.Show("Os campos de senhas deve ser preenchido com no mínimo 5 caracteres!");
                TXTsenhaAtual.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region Função Limpar
        private void Limpar()
        {
            TXTsenhaAtual.Text = "";
            TBXSenha.Text = "";
            TBXNovaSenha.Text = "";
        }
        #endregion

        #region Key Down

        private void TBXSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                TBXNovaSenha.Focus();
            }
        }

        private void TBXNovaSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox1.Focus();
               
            }
        }
        #endregion

        private void TXTsenhaAtual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TBXSenha.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Dispose();
            code = "";
            textBox1.Text = "";
            CreateImage();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BTNConfirmar_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateImage();
        }
    }

}
