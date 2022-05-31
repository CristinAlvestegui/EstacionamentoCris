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
    internal class Auto
    {
        MySqlConnection conexao;
        public string resultado;
        public string dados;
        public string[] modelo;
        public string[] cor;
        public string msg;
        public string[] placa;
        public int i;
        public int contador = 0;

        public Auto(string Estacionamento)
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
            }//Fim do  catch
        }//Fim do constutor

        public void inserirVeiculo(string placa, string modelo, string cor)
        {  
            try
            {
                dados = "('" + placa + "','" + modelo + "','" + cor + "')";
                resultado = "insert into veiculo(codigo, placa,modelo,cor) values" + dados;
                // EXECULTAR O COMANDO RESULTADO NO BANCO DE DADOS
                MySqlCommand sql = new MySqlCommand(resultado, conexao); // VAI ESTRAR NO PROGRAMA NO BANCO DE DADOS "CONEXÃO"
                resultado = "" + sql.ExecuteNonQuery();// EXECULTAR E GUARDAR O " RESULTADO ", CONTRA O ENTER DO BANCO DE DADOS.
                Console.WriteLine(resultado);
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Algo deu Errado Aqui!\n\n{erro}", "ops!", MessageBoxButtons.OK);
            }//Fim do try catch
        }//Fim do metoro inserir veiculo

        public void VetorAuto()
        {
            string query = "select * from Veiculo";

            placa = new string[9];
            modelo = new string[50];
            cor = new string[50];

            for (i = 0; i < 100; i++)
            {
                placa[i] = "";
                modelo[i] = "";
                cor[i] = "";
            }
            //Criar o comando para coleta de dados
            MySqlCommand coletar = new MySqlCommand(query, conexao);
            //Usar o comando lendo os dados do banco
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;
            while (leitura.Read())
            {
                placa[i] = leitura["placa"] + "";
                modelo[i] = leitura["modelo"] + "";
                cor[i] = leitura["cor"] + "";

                i++;
                contador++;
            }//fim do while
             //Fechar o dataReader
            leitura.Close();

        }//Fim preencher vetor

        public string ConsultarTudo()
        {
            //Preencher o vetor
            VetorAuto();
            msg = "";
            for (long i = 0; i < contador; i++)
            {
                msg += "\n\nPlaca: " + placa[i]
                + ", Modelo: " + modelo[i]
                + ", Cor: " + cor[i];
            }//fim do for
            return msg;
        }//fim do consultarTudo

        public string ConsultarPlaca(string plac)
        {
            VetorAuto();
            for (int i = 0; i < contador; i++)
            {
                if (plac == placa[i])
                {
                    return placa[i];
                }
            }//fim do for
            return "Placa não Encontrada";
        }//Fim do método para consultar Placa

        public string ConsultarModelo(string plac)
        {
            VetorAuto();
            for (int i = 0; i < contador; i++)
            {
                if (plac == modelo[i])
                {
                    return modelo[i];
                }
            }//fim do for
            return "Modelo não encontrado";
        }//Fim do método para consultar Modelo

        public string ConsultarCor(string plac)
        {
            VetorAuto();
            for (long i = 0; i < contador; i++)
            {
                if (plac == cor[i])
                {
                    return cor[i];
                }
            }//fim do for
            return "Cor não encontrado!";
        }//Fim do método para consultar Cor

    }//Fim da classe
}//Fim do Projeto
