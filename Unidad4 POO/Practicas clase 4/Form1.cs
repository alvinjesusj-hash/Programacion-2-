using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad4_POO.Practicas_clase_4;

namespace Unidad4_POO.Practicas_clase_4
{
    public partial class txtNombre : Form
    {
        public txtNombre()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click_1(object sender, EventArgs e)
        {

            Producto producto = new Producto();

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre.");
                return;
            }

            if (decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                producto.Nombre = txtNombre.Text;
                producto.Precio = precio;

                producto.MostrarInfo();
            }
            else
            {
                MessageBox.Show("Ingrese un precio válido.");
            }
             
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
