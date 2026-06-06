using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms9
{
    public partial class Form1 : Form
    {
        NumericService service = new NumericService();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresarNumero_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(tbNumero.Text);
            service.RegistrarNumero(numero);
        }

        private void btnVerAcumulado_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El acumulado es: " + service.VerAcumulado());
        }

        private void btnVerCantidad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La cantidad de numeros ingresados es: " + service.VerCantidad());
        }

        private void btnVerPromedio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El promedio de los Números es: " + service.CalcularPromedio());
        }
    }
}
