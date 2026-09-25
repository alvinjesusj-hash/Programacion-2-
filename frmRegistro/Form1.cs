using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmRegistro
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblContrasena_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtNombre.Text + " " + txtApellido.Text, "Bienvenido");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtUsuario.Clear();
            txtContraseña.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close ();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            modificar();

            void modificar()
            {
                
                MessageBox.Show("Modificado con exito");
            }
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }
    }
}
