using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clasificacion_de_una_nota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string ClasificarNota(double nota)
        {
            if (nota >= 90)
                return "Excelente" ;
            else if (nota >= 80)
                return "Muy bueno";
            else if (nota >= 70)
                return "Bueno";
            else if (nota >= 60)
                return "Regular";
            else
                return "Deficiente";
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNota.Clear();

            lblResultado.Text = "Resultado";
            lblResultado.BackColor = SystemColors.Control;

            lstCategorias.ClearSelected();

            txtNota.Focus();
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            double nota;

            if (!double.TryParse(txtNota.Text, out nota) ||
                nota < 0 || nota > 100)
            {
                MessageBox.Show("Ingrese una nota entre 0 y 100.");
                return;
            }

            string categoria = ClasificarNota(nota);

            lblResultado.Text = "Resultado: " + categoria;

            lstCategorias.SelectedItem = categoria;

            if (nota >= 90)
            {
                lblResultado.BackColor = Color.LightGreen;
            }
            else if (nota < 60)
            {
                lblResultado.BackColor = Color.LightCoral;
            }
            else
            {
                lblResultado.BackColor = SystemColors.Control;
            }
        }
    }
}
