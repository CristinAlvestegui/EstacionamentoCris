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
        public string dadosE;
        public string dadosS;
        public string resultadoE;
        public string resultadoS;
        public int i;
        public int contador = 0;
        //data = data.Date;
       //hora = hora.Time;

        //Vetores
        public DateTime[] data;
        //public DateTimeOffset[] dataS;
        public DateTime[] hora;
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

        public void EntradaBoa(DateTime data, DateTime hora )
        {
            try
            {
                dadosE = "('','" + data + "','" + hora + "')";
                resultadoE = "Insert * into ControlHora(dataE, horaE) values" + dadosE;
                MySqlCommand sql = new MySqlCommand(resultadoE, conexao);
                resultadoE = "" + sql.ExecuteNonQuery();
                MessageBox.Show(resultadoE + "Salvo com sucesso!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Algo deu Errado" + e);
            }//Fim do catch           
        }

        public void SaidaBoa(DateTime data, DateTime hora)
        {
            dadosS = "('','" + data + "','" + hora + "')";
            resultadoS = "Insert * into ControlHora(dataS, horaS) values" + dadosS;
            MySqlCommand sql = new MySqlCommand(resultadoS, conexao);
            resultadoS = "" + sql.ExecuteNonQuery();
            MessageBox.Show(resultadoS + "Salvo com sucesso!" );
        }
        public void VetorDataE()
        {
            string query = "select * from ControlHora";

            data = new DateTime[100];
            hora = new DateTime[100];

            for (i = 0; i < 100; i++)
            {
                data[i] = new DateTime();
                hora[i] = new DateTime();
            }

            //Criar o comando para coleta de dados
            MySqlCommand coletar = new MySqlCommand(query, conexao);
            //Usar o comando lendo os dados do banco
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;
            while (leitura.Read())
            {
                data[i] = Convert.ToDateTime(leitura["dataE"] + "");
                hora[i] = Convert.ToDateTime(leitura["horaE"] + "");
                i++;
                contador++;
            }

            leitura.Close();
        }//Fim do método para vetor Entrada

        public void VetorDataS()
        {
            string query = "select * from ControlHora";

            //Instanciando vetores
            
            data = new DateTime[100];            
            hora = new DateTime[100];

            //Valor inicial
            for ( i = 0 ; i < 100 ; i++)
            {
                
                data[i] = new DateTime();               
                hora[i] = new DateTime();
            }

            //Criar o comando para coleta de dados
            MySqlCommand coletar = new MySqlCommand(query, conexao);
            //Usar o comando lendo os dados do banco
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;
            while (leitura.Read())
            {
                data[i] = Convert.ToDateTime(leitura["dataS"] + "");
                hora[i] = Convert.ToDateTime(leitura["horaS"] + "");
                i++;
                contador++;
            }//Fim do While

            //Fechar o dat reader
            leitura.Close();

        }//Fim do método para preencher vetor Saida

    }//Fim da classe
}//Fim do Projeto
