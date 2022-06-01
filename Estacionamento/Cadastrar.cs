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
            maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            long cpf = Convert.ToInt64(ConteTexCPF());
            string nome = ConteudoTextBox();
            string telefone = ConteTexTele();
            cadas.Inserir(cpf, nome, telefone);
            cadas.PreencherVetor();
            textBox6.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
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
            return maskedTextBox1.Text;
        }//CPF

        public string ETele()
        {
            return maskedTextBox2.Text;
        }//Telefono

        private void Proximo_Click(object sender, EventArgs e)
        {

        }//Fim do botão para pular de página.

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }//Fim da classe
}//Fim do projeto
