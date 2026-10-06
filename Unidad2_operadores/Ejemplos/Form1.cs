using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad2_operadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdad_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtEdad.Text, out int edad))
            {
                if (edad >= 18)
                {
                    MessageBox.Show("Eres mayor de edad.");
                }
                else
                {
                    MessageBox.Show("No eres mayor de edad.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa una edad válida.");
            }
        }
    }
}
