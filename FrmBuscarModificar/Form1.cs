using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FrmBuscarModificar
{
    public partial class FrmBuscarModificar : Form
    {
        string cs = "Server=localhost;Database=Tienda;Uid=root;Pwd=A123456789;";

        public FrmBuscarModificar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                MessageBox.Show("Ingrese el nombre a buscar");
                return;
            }

            try
            {
                using (var cn = new MySqlConnection(cs))
                {
                    cn.Open();
                    var cmd = new MySqlCommand(
                        "SELECT Correo FROM Clientes WHERE Nombre=@n", cn);
                    cmd.Parameters.AddWithValue("@n", txtBuscar.Text.Trim());
                    object r = cmd.ExecuteScalar();

                    if (r == null)
                    {
                        txtCorreo.Clear();
                        MessageBox.Show("Cliente no encontrado");
                    }
                    else
                    {
                        txtCorreo.Text = r.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Busque un cliente y escriba el nuevo correo");
                return;
            }

            try
            {
                using (var cn = new MySqlConnection(cs))
                {
                    cn.Open();
                    var cmd = new MySqlCommand(
                        "UPDATE Clientes SET Correo=@c WHERE Nombre=@n", cn);
                    cmd.Parameters.AddWithValue("@c", txtCorreo.Text.Trim());
                    cmd.Parameters.AddWithValue("@n", txtBuscar.Text.Trim());
                    int filas = cmd.ExecuteNonQuery();

                    MessageBox.Show(filas > 0
                        ? "Correo actualizado"
                        : "Cliente no encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmBuscarModificar_Load(object sender, EventArgs e)
        {

        }
    }
}