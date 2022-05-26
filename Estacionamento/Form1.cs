using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento
{
    
    public partial class Form1 : Form
    {
        Cadastrar cadas;
        Form2 vouentrar;
        Saida vouSai;
        

        public Form1()
        {
            InitializeComponent();
            vouentrar = new Form2();
            cadas = new Cadastrar();
            vouSai = new Saida();
            
        }//Fim do construtor

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            Visible = true;
            cadas.ShowDialog();
            Visible = false;
        }

        private void Entrada_Click(object sender, EventArgs e)
        {

            Visible = true;
            vouentrar.ShowDialog();
            Visible = false;                   
        }

        private void Saida_Click(object sender, EventArgs e)
        {
            
            Visible = true;
            vouSai.ShowDialog();
            Visible = false;
        }//Fim do botão
    }//Fim da clasee
}//Fim do projeto
