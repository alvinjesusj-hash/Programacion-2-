using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad3_MessageBox_.Practicas_clase_3
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar1_Click(object sender, EventArgs e)
        {
            int valores = Convert.ToInt32(txtNumero1.Text); 

            switch (valores)
            {
                case 1:
                    MessageBox.Show("Valor 1 seleccionado.", "Valor1", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    MessageBox.Show("Valor 2 seleccionado.", "Valor2", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 3:
                    MessageBox.Show("Valor 3 seleccionado.", "Valor3", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 4:
                    MessageBox.Show("Valor 4 seleccionado.", "Valor4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    MessageBox.Show("Valor no válido o no es un numero.", "Valor Invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
