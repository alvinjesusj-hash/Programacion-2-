using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad3_MessageBox_.Ejemplos
{
    public partial class frmMessageBox : Form
    {
        public frmMessageBox()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea continuar?",
                                                      "Mensaje de confirmacion",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Ha seleccionado 'Sí'.");
            }
            else
            { 
                MessageBox.Show("Ha seleccionado 'No'.");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Está seguro de que desea cerrar la aplicación?",
                                                      "Confirmación de cierre",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);
            
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
       
        }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Error de conexion. Desea reintentar?",
                                                     "Error",
                                                     MessageBoxButtons.RetryCancel,
                                                     MessageBoxIcon.Error);
            if (respuesta == DialogResult.Retry)
                MessageBox.Show("Reintentando conexiom...");

                 
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            int opcion = Convert.ToInt32(txtOpcion.Text);

            switch (opcion)
            {
                case 1:
                    MessageBox.Show("Opción 1 seleccionada.", "Opcion1", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    MessageBox.Show("Opción 2 seleccionada.", "Opcion2", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 3:
                    MessageBox.Show("Opción 3 seleccionada.", "Opcion3", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    MessageBox.Show("Opción no válida.", "Opcion Invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }
    }
}
