using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_1_Programacion_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmbServicio.SelectedIndex = -1;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int precio = 0;

            switch (cmbServicio.SelectedIndex)
            {
                case 0:
                    precio = 15000;
                    break;

                case 1:
                    precio = 20000;
                    break;

                case 2:
                    precio = 10000;
                    break;

                default:
                    MessageBox.Show("Seleccione un servicio.");
                    return;
            }

            MessageBox.Show("El precio del servicio es: ₡" + precio);
        }
    }
}
