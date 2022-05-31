using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Estacionamento
{
    internal class Odao
    {
        MySqlConnection conexao;

        public Odao(string Estacionamento)
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
    }//Fim da classe
}//Fim do projeto
