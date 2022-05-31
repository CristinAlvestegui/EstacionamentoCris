using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Estacionamento
{
    internal class Dao
    {
        MySqlConnection conexao;

        //Declarando Vetores
        public DateTime[] dataE;
        public DateTime[] horaE;
        public DateTime[] dataS;
        public DateTime[] horaS;
        public int i;
        public int contador = 0;
        //data = data.Date;
       //hora = hora.Time;

        //Vetores
        //public DateTime[] data;
        //public DateTimeOffset[] dataS;
        //public DateTime[] hora;
        //public DateTimeOffset[] horaS;


        public Dao(string Estacionamento)
        {
            conexao = new MySqlConnection("server=localhost;DataBase=" + Estacionamento + ";Uid=root;Password=;");
            try
            {
                conexao.Open();
                MessageBox.Show("Seja Bem Vindo ao Estacionamento Senac!!!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Algo deu errado!" + e);
                conexao.Close();
            }

        }//Fim do construtor

        public void SoData(DateTime dat)
        {
            try
            {
                MySqlParameter Data = new MySqlParameter();
                Data.ParameterName = "@Date";
                Data.MySqlDbType = MySqlDbType.Date;
                Data.Value = dat.Year + "-" + dat.Moth + "-" + dat.Day;
                data = Data.Value;
            }
            catch (Exception e)
            {
                MessageBox.Show("raaaaaapaaaz!!!" + e);
            }//Fim do catch
        }//Fim do método SóEntrada

        public void SoHora(DateTime tim)
        {
            try
            {
                MySqlParameter Tempo = new MySqlParameter();
                Tempo.ParameterName = "@Time";
                Tempo.MySqlDbType = MySqlDbType.Time;
                Tempo.Value = tim.Hour + "-" + tim.Minute + "-" + tim.Second;
                hora = Tempo.Value;
            }
            catch (Exception e)
            {
                MessageBox.Show("Jesus amado!" + e);
            }//Fim do catch
        }//Fim do método Só Entrada
        public void EntradaBoa(DateTime tim, DateTime dat)
        {
            SoHora(tim);
            SoData(dat);
            VouEntrar();
            try
            {
                dados = "('','" + data + "','" + hora + "')";
                resultado = "Insert * into ControlHora(dataE, horaE) values" + dadosE;
                MySqlCommand sql = new MySqlCommand(resultado, conexao);
                resultado = "" + sql.ExecuteNonQuery();
                MessageBox.Show(resultado + "Salvo com sucesso!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Algo deu Errado" + e);
            }//Fim do catch           
        }//Fim do método Entrada Boa

        public void SaidaBoa(DateTime dat, DateTime tim)
        {
            SoHora(tim);
            SoData(dat);
            VouSair();
            try
            {
                dados = "('','" + data + "','" + hora + "')";
                resultado = "Insert * into ControlHora(dataS, horaS) values" + dados;
                MySqlCommand sql = new MySqlCommand(resultado, conexao);
                resultado = "" + sql.ExecuteNonQuery();
                MessageBox.Show(resultado + "Salvo com sucesso!");
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
            }//Fim do catch       
        }//Fim do método para Saída Boa
        public void VouSair()
        {
            string query = "select * from ControlHora";

            dataS = new DateTime[100];
            horaS = new DateTime[100];

            for (i = 0; i < 100; i++)
            {
                dataS[i] = new DateTime();
                horaS[i] = new DateTime();
            }

            //Criar o comando para coleta de dados
            MySqlCommand coletar = new MySqlCommand(query, conexao);
            //Usar o comando lendo os dados do banco
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;
            while (leitura.Read())
            {
                dataS[i] = Convert.ToDateTime(leitura["dataS"] + "");
                horaS[i] = Convert.ToDateTime(leitura["horaS"] + "");
                i++;
                contador++;
            }

            leitura.Close();
        }//Fim do método para vetor Entrada

        public void VouEntrar()
        {
            string query = "select * from ControlHora";

            //Instanciando vetores
            
            dataE = new DateTime[100];            
            horaE = new DateTime[100];

            //Valor inicial
            for ( i = 0 ; i < 100 ; i++)
            {               
                dataE[i] = new DateTime();               
                horaE[i] = new DateTime();
            }

            //Criar o comando para coleta de dados
            MySqlCommand coletar = new MySqlCommand(query, conexao);
            //Usar o comando lendo os dados do banco
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;
            while (leitura.Read())
            {
                dataE[i] = Convert.ToDateTime(leitura["dataS"] + "");
                horaE[i] = Convert.ToDateTime(leitura["horaS"] + "");
                i++;
                contador++;
            }//Fim do While

            //Fechar o dat reader
            leitura.Close();

        }//Fim do método para preencher vetor Saida

    }//Fim da classe
}//Fim do Projeto
