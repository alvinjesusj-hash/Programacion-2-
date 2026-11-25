using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FrmInsertar
{
    public partial class FrmInsertar : Form
    {
        string cs = "Server=localhost;Database=Tienda;Uid=root;Pwd=A123456789;";

        public FrmInsertar()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            try
            {
                using (var cn = new MySqlConnection(cs))
                {
                    cn.Open();
                    var cmd = new MySqlCommand(
                        "INSERT INTO Clientes (Nombre, Correo) VALUES (@n, @c)", cn);
                    cmd.Parameters.AddWithValue("@n", txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@c", txtCorreo.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Cliente insertado");
                txtNombre.Clear();
                txtCorreo.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
