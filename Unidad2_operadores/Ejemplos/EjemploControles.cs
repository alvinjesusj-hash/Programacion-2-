using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad2_operadores.Ejemplos
{
    public partial class EjemploControles : Form
    {
        public EjemploControles()
        {
            InitializeComponent();
        }

        private void EjemploControles_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("rojo");
            listBox1.Items.Add("verde");
            listBox1.Items.Add("azul");

            listBox1.BackColor = Color.LightBlue;
            this.BackColor = Color.LightGray;
        }

        private void btnRojo_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            listBox1.Items.Add("Se selecciono Rojo");
        }

        private void btnVerde_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            listBox1.Items.Add("Se selecciono Verde");
        }

        private void btnAzul_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            listBox1.Items.Add("Se selecciono Azul");
        }
    }
}
