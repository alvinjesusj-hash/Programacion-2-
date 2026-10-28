using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_de_salario
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            double horas, pagoHora, salario;

            if (nombre.Trim() == "")
            {
                MessageBox.Show("Ingrese el nombre del trabajador.");
                return;
            }

            if (!double.TryParse(txtHoras.Text, out horas) || horas <= 0)
            {
                MessageBox.Show("Ingrese horas mayores que cero.");
                return;
            }

            if (!double.TryParse(txtPagoHora.Text, out pagoHora) || pagoHora <= 0)
            {
                MessageBox.Show("Ingrese un pago por hora mayor que cero.");
                return;
            }

            if (horas <= 40)
            {
                salario = horas * pagoHora;
            }
            else
            {
                salario = (40 * pagoHora) +
                          ((horas - 40) * pagoHora * 1.5);
            }

            lblResultado.Text = "Salario total de " + nombre +
                                ": ₡" + salario.ToString("N2");

            MessageBox.Show("Cálculo realizado correctamente.");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtHoras.Clear();
            txtPagoHora.Clear();

            lblResultado.Text = "Salario total:";

            txtNombre.Focus();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

    }
}
