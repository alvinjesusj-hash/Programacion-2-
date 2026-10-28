using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_producto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            bool valido = true;
            decimal precio;

            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                errorProvider1.SetError(txtCodigo, "Ingrese el código.");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Ingrese el nombre.");
                valido = false;
            }

            if (!decimal.TryParse(txtPrecio.Text, out precio) || precio <= 0)
            {
                errorProvider1.SetError(txtPrecio, "Ingrese un precio mayor que cero.");
                valido = false;
            }

            if (!valido)
            {
                return;
            }

            Producto producto = new Producto();

            producto.Codigo = txtCodigo.Text.Trim();
            producto.Nombre = txtNombre.Text.Trim();
            producto.Precio = precio;

            MessageBox.Show(
                "Código: " + producto.Codigo +
                "\nNombre: " + producto.Nombre +
                "\nPrecio: ₡" + producto.Precio.ToString("N2") +
                "\nPrecio con IVA: ₡" +
                producto.ObtenerPrecioConIVA().ToString("N2"),
                "Datos del producto"
            );
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



    }
}
