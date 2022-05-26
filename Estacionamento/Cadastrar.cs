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
    public partial class Cadastrar : Form
    {
        DAOVI form;
        public Cadastrar()
        {
            form = new DAOVI("Estacionamento");
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            long cpf = Convert.ToInt64(ECPF());
            string nome = ENome();
             string telefone = ETele();
            form.Inserir(cpf, nome, telefone);
            form.PreencherVetor();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public string ENome()
        {
            return textBox1.Text;
        }//Nome

        public string ECPF()
        {
            return textBox2.Text;
        }//CPF

        public string ETele()
        {
            return textBox3.Text;
        }//Telefono

        private void Proximo_Click(object sender, EventArgs e)
        {

        }
    }
}
