using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad5_capas
{
   
    public partial class Form1 : Form
    {

        private Productoservice productoService;
        public Form1()
        {
            InitializeComponent();
            productoService = new Productoservice();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        } 

        private void btnCargar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = productoService.ObtenerProductos();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {
            lblFecha.Text = "";
            lblFecha.Text = "Fecha y  hora actual: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
