using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Unidad5_capas.Practicas_clase_5
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            productos.Clear();
            productos.Add(new Producto("Pantalla", 8500));
            productos.Add(new Producto("Cable", 4500));
            productos.Add(new Producto("Memoria", 75000));

            dgvProductos.DataSource = productos;

        }

        BindingList<Producto> productos = new BindingList<Producto>();

    }


}
