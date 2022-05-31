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
    public partial class Form2 : Form
    {
        Dao dao;
        Auto car;
        public Form2()
        {
            dao = new Dao("Estacionamento");
            car = new Auto("Estacionamento");
            InitializeComponent();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            string placa = InPlaca();
            DateTime dataE = DateTime.Now;
            DateTime horaE = DateTime.Now;
            car.ConsultarPlaca(placa);
            if (placa = true)
            {
                MessageBox.Show("" + dataE, "" + horaE);
                dao.EntradaBoa(dataE, horaE);
                dao.VouEntrar();
            }
        }//Aqui devemos fazer uma verificação com a tabela do veiculo para confirmar que a placa informada existe.

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        public string InPlaca()
        {
            return maskedTextBox1.Text;
        }
    }//Fim da classe Forms2 ou MarcarSaida/Registrar.....
}//Fim do Projeto
