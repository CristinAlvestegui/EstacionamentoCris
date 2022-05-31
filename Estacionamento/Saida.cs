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
    public partial class Saida : Form
    {
        Dao dao;
        public Saida()
        {
            dao = new Dao("Estacionamento");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dataS = data.Now;
            DateTime horaS = hora.Now;
            dao.SaidaBoa(dataS, horaS);
            MessageBox.Show("" + dataS, "" + horaS);
            dao.VouSair();
        }
    }//Fim da classe
}//fim do Formulario
