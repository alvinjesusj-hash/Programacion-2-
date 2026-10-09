using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad3_MessageBox_.Practicas_clase_3
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void btnSeleccionar1_Click(object sender, EventArgs e)
        {
            int Opcion
                = Convert.ToInt32(txtOpcion1.Text);

            switch (Opcion)
            { 
                case 1:
                    MessageBox.Show("Opcion 1 seleccionada");
                    break;
                case 2:
                    MessageBox.Show("Opcion 2 seleccionada");
                    break;
                case 3:
                    MessageBox.Show("Opcion 3 seleccionada");
                    break;
                default:
                    MessageBox.Show("Opcion no valida");
                    break;
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
