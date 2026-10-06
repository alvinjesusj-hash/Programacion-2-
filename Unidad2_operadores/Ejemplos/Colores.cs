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
    public partial class Colores : Form
    {
        public Colores()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cambiarColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir el cuadro de seleccion de color 
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Si el usuario selecciona un color, aplicarle al fondo del formulario el color seleccionado
                this.BackColor = colorDialog1.Color;
            }
        }
    }
}


        
    

