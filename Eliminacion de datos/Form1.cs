using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eliminacion_de_datos
{
    public partial class Form1 : Form
    {
        string cs = "Server=localhost;Database=Tienda;Uid=root;Pwd=A123456789;";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del cliente");
                return;
            }

            DialogResult res = MessageBox.Show(
                "¿Seguro que desea eliminar a " + txtNombre.Text.Trim() + "?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (res != DialogResult.Yes) return;

            try
            {
                using (var cn = new MySqlConnection(cs))
                {
                    cn.Open();
                    var cmd = new MySqlCommand(
                        "DELETE FROM Clientes WHERE Nombre=@n", cn);
                    cmd.Parameters.AddWithValue("@n", txtNombre.Text.Trim());
                    int filas = cmd.ExecuteNonQuery();

                    MessageBox.Show(filas > 0
                        ? "Cliente eliminado"
                        : "Cliente no encontrado");
                }
                txtNombre.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
