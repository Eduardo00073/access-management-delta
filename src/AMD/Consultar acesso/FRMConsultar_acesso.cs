using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AMD.Consultar_acesso
{
    public partial class FRMConsultar_acesso : Form
    {
        public FRMConsultar_acesso()
        {
            InitializeComponent();
        }

        #region BTN Consultar
        private void BTNConsultar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            int dia, ano, mes;

            dia = monthCalendar1.SelectionStart.Day;
            mes = monthCalendar1.SelectionStart.Month;
            ano = monthCalendar1.SelectionStart.Year;

            SqlConnection conexao = new SqlConnection(Config.clsDados.StringDeConexao);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;

            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            conexao.Open();

            try
            {
                if (monthCalendar1.SelectionStart.ToShortDateString() == null && CBLab.SelectedIndex < 0)
                {
                    MessageBox.Show("Selecione todos os campos para a consulta");
                }
                else
                {
                    int lab = 0;

                    if (CBLab.SelectedIndex == 0)
                    {
                        lab = 1;
                    }
                    else if (CBLab.SelectedIndex == 1)
                    {
                        lab = 2;
                    }
                    else if (CBLab.SelectedIndex == 2)
                    {
                        lab = 3;
                    }
                    else if (CBLab.SelectedIndex == 3)
                    {
                        lab = 4;
                    }
                    else if (CBLab.SelectedIndex == 4)
                    {
                        lab = 5;
                    }
                    else if (CBLab.SelectedIndex == 5)
                    {
                        lab = 6;
                    }
                    else if (CBLab.SelectedIndex == 6)
                    {
                        lab = 7;
                    }
                    else if (CBLab.SelectedIndex == 7)
                    {
                        lab = 8;
                    }
                    else if (CBLab.SelectedIndex == 8)
                    {
                        lab = 9;
                    }
                    else if (CBLab.SelectedIndex == 9)
                    {
                        lab = 10;
                    }
                    else if (CBLab.SelectedIndex == 10)
                    {
                        lab = 11;
                    }
                    else if (CBLab.SelectedIndex == 11)
                    {
                        lab = 12;
                    }
                    else if (CBLab.SelectedIndex == 12)
                    {
                        lab = 13;
                    }
                    else if (CBLab.SelectedIndex == 13)
                    {
                        lab = 14;
                    }
                    else if (CBLab.SelectedIndex == 14)
                    {
                        lab = 15;
                    }
                    else if (CBLab.SelectedIndex == 15)
                    {
                        lab = 16;
                    }
                    else if (CBLab.SelectedIndex == 16)
                    {
                        lab = 17;
                    }
                    else if (CBLab.SelectedIndex == 17)
                    {
                        lab = 18;
                    }
                    else if (CBLab.SelectedIndex == 18)
                    {
                        lab = 19;
                    }
                    else if (CBLab.SelectedIndex == 19)
                    {
                        lab = 20;
                    }
                    else if (CBLab.SelectedIndex == 20)
                    {
                        lab = 21;
                    }
                    else if (CBLab.SelectedIndex == 21)
                    {
                        lab = 22;
                    }
                    else if (CBLab.SelectedIndex == 22)
                    {
                        lab = 23;
                    }
                    else if (CBLab.SelectedIndex == 23)
                    {
                        lab = 24;
                    }
                    else if (CBLab.SelectedIndex == 24)
                    {
                        lab = 25;
                    }
                    else if (CBLab.SelectedIndex == 25)
                    {
                        lab = 26;
                    }
                    else if (CBLab.SelectedIndex == 26)
                    {
                        lab = 27;
                    }
                    else if (CBLab.SelectedIndex == 27)
                    {
                        lab = 28;
                    }
                    else if (CBLab.SelectedIndex == 28)
                    {
                        lab = 29;
                    }
                    else if (CBLab.SelectedIndex == 29)
                    {
                        lab = 30;
                    }
                    else if (CBLab.SelectedIndex == 30)
                    {
                        lab = 31;
                    }
                    else if (CBLab.SelectedIndex == 31)
                    {
                        lab = 32;
                    }
                    else if (CBLab.SelectedIndex == 32)
                    {
                        lab = 33;
                    }
                    else if (CBLab.SelectedIndex == 33)
                    {
                        lab = 34;
                    }
                    else if (CBLab.SelectedIndex == 34)
                    {
                        lab = 35;
                    }
                    else if (CBLab.SelectedIndex == 35)
                    {
                        lab = 36;
                    }
                    else if (CBLab.SelectedIndex == 36)
                    {
                        lab = 37;
                    }
                    else if (CBLab.SelectedIndex == 37)
                    {
                        lab = 38;
                    }
                    else if (CBLab.SelectedIndex == 38)
                    {
                        lab = 39;
                    }
                    else if (CBLab.SelectedIndex == 39)
                    {
                        lab = 40;
                    }
                    else if (CBLab.SelectedIndex == 40)
                    {
                        lab = 41;
                    }
                    else if (CBLab.SelectedIndex == 41)
                    {
                        lab = 42;
                    }
                    else if (CBLab.SelectedIndex == 42)
                    {
                        lab = 43;
                    }
                    else if (CBLab.SelectedIndex == 43)
                    {
                        lab = 44;
                    }
                    else if (CBLab.SelectedIndex == 44)
                    {
                        lab = 45;
                    }
                    else if (CBLab.SelectedIndex == 45)
                    {
                        lab = 46;
                    }
                    else if (CBLab.SelectedIndex == 46)
                    {
                        lab = 47;
                    }
                    else if (CBLab.SelectedIndex == 47)
                    {
                        lab = 48;
                    }
                    else if (CBLab.SelectedIndex == 48)
                    {
                        lab = 49;
                    }
                    else
                    {
                        lab = 50;
                    }

                    if (mes == 1)
                    {
                        if (dia == 1)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '01/01/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 2)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '02/01/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 3)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '03/01/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 4)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '04/01/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 5)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '05/01/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 6)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '06/01/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 7)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '07/01/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 8)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '08/01/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 9)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '09/01/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '" + dia + "/01/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                    }
                    else if (mes == 2)
                    {
                        if (dia == 1)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '01/02/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 2)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '02/02/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 3)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '03/02/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 4)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '04/02/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 5)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '05/02/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 6)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '06/02/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 7)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '07/02/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 8)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '08/02/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 9)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '09/02/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '" + dia + "/02/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                    }
                    else if (mes == 3)
                    {
                        if (dia == 1)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '01/03/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 2)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '02/03/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 3)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '03/03/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 4)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '04/03/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 5)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '05/03/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 6)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '06/03/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 7)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '07/03/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 8)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '08/03/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 9)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '09/03/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '" + dia + "/03/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                    }
                    else if (mes == 4)
                    {
                        if (dia == 1)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '01/04/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 2)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '02/04/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 3)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '03/04/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 4)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '04/04/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 5)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '05/04/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 6)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '06/04/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 7)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '07/04/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 8)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '08/04/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 8)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '09/04/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '" + dia + "/04/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                    }
                    else if (mes == 5)
                    {
                        if (dia == 1)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '01/05/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 2)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '02/05/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 3)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '03/05/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 4)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '04/05/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 5)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '05/05/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 6)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '06/05/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 7)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '07/05/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 8)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '08/05/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 9)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '09/05/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '" + dia + "/05/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                    }
                    else if (mes == 6)
                    {
                        if (dia == 1)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '01/06/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 2)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '02/06/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 3)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '03/06/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 4)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '04/06/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 5)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '05/06/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 6)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '06/06/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 7)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '07/06/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 8)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '08/06/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 9)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '09/06/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '" + dia + "/06/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                    }
                    else if (mes == 7)
                    {
                        if (dia == 1)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '01/07/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 2)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '02/07/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 3)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '03/07/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 4)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '04/07/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 5)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '05/07/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 6)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '06/07/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 7)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '07/07/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 8)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '08/07/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 9)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '09/07/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '" + dia + "/07/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                    }
                    else if (mes == 8)
                    {
                        if (dia == 1)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '01/08/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 2)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '02/08/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 3)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '03/08/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 4)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '04/08/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 5)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '05/08/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 6)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '06/08/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 7)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '07/08/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 8)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '08/08/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 9)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '09/08/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '" + dia + "/08/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                    }
                    else if (mes == 9)
                    {
                        if (dia == 1)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '01/09/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 2)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '02/09/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 3)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '03/09/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 4)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '04/09/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 5)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '05/09/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 6)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '06/09/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 7)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '07/09/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 8)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '08/09/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 9)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '09/09/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '" + dia + "/09/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                    }
                    else
                    {
                        if (dia == 1)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '01/" + mes + "/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 2)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '02/" + mes + "/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 3)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '03/" + mes + "/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 4)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '04/" + mes + "/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 5)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '05/" + mes + "/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 6)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '06/" + mes + "/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 7)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '07/" + mes + "/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 8)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '08/" + mes + "/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else if (dia == 9)
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '09/" + mes + "/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                        else
                        {
                            cmd.CommandText = "select ac.idAcesso, ac.data, u.Nome as 'Nome do Usuário', u.Matricula_Acesso as 'Matrícula', c.Nome as 'Nome do Computador', c.Laboratorio, c.Posicao from Acesso_Computador ac inner join Usuario u on u.idUsuario = ac.idUsuario inner join Computador c on c.idComputador = ac.idComputador where CONVERT(CHAR, data, 103) = '" + dia + "/" + mes + "/" + ano + "' and c.Laboratorio = '" + lab + "' group by ac.idAcesso, ac.data, u.Nome, u.Matricula_Acesso, c.Nome, c.Laboratorio, c.Posicao";
                        }
                    }

                }

                da.Fill(tb);
                cmd.Parameters.Clear();

                DGConsuta_acesso.DataSource = tb;

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

        #region BTN Fechar
        private void BTNFechar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            this.Close();
        }
        #endregion
    }
}
