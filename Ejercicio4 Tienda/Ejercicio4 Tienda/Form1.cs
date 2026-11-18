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

namespace Ejercicio4_Tienda
{
    public partial class Form1 : Form
    {

        private string cadenaConexion =
           "Server=localhost;Port=3306;Database=Tienda;Uid=root;Pwd=A123456789;";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int codigo, cantidad;
            decimal precio;

            if (!int.TryParse(txtCodigo.Text, out codigo) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                !decimal.TryParse(txtPrecio.Text, out precio) ||
                !int.TryParse(txtCantidad.Text, out cantidad))
            {
                MessageBox.Show("Complete todos los campos con valores válidos.");
                return;
            }

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string sql = "INSERT INTO Producto (codigo, nombre, precio, cantidad, codigo_categoria) " +
                                 "VALUES (@codigo, @nombre, @precio, @cantidad, 1)";

                    using (MySqlCommand comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@codigo", codigo);
                        comando.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                        comando.Parameters.AddWithValue("@precio", precio);
                        comando.Parameters.AddWithValue("@cantidad", cantidad);
                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Producto agregado correctamente.");
                LimpiarCampos();
                MostrarProductos();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                    MessageBox.Show("Ya existe un producto con ese código.");
                else
                    MessageBox.Show("Error de base de datos: " + ex.Message);
            }

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codigo;

            if (!int.TryParse(txtCodigo.Text, out codigo))
            {
                MessageBox.Show("Ingrese el código del producto a eliminar.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea eliminar el producto con código " + codigo + "?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string sql = "DELETE FROM Producto WHERE codigo = @codigo";

                    using (MySqlCommand comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@codigo", codigo);
                        int filas = comando.ExecuteNonQuery();

                        if (filas > 0)
                            MessageBox.Show("Producto eliminado.");
                        else
                            MessageBox.Show("No existe un producto con ese código.");
                    }
                }

                LimpiarCampos();
                MostrarProductos();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de base de datos: " + ex.Message);
            }
        }

        private void MostrarProductos()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string sql = "SELECT codigo AS Codigo, nombre AS Nombre, " +
                                 "precio AS Precio, cantidad AS Cantidad FROM Producto";

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    dgvProductos.DataSource = tabla;
                    dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvProductos.ReadOnly = true;
                    dgvProductos.AllowUserToAddRows = false;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de base de datos: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtCodigo.Focus();
        }
    }
}

