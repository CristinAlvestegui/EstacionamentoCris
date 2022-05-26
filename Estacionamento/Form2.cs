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
        public Form2()
        {
            dao = new Dao("Estacionamento");
            InitializeComponent();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            DateTime dataE = DateTime.Now;
            DateTime horaE = DateTime.Now;
            MessageBox.Show("" + dataE, "" + horaE);
            dao.EntradaBoa(dataE, horaE);
            dao.VetorDataE();
        }//Aqui devemos fazer uma verificação com a tabela do veiculo para confirmar que a placa informada existe.
    }
}
