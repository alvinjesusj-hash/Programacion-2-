using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FrmConexion
{
    public partial class FrmConexion : Form
    {
        string cs = "Server=localhost;Database=Tienda;Uid=root;Pwd=A123456789;";

        public FrmConexion()
        {
            InitializeComponent();
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            try
            {
                using (var cn = new MySqlConnection(cs))
                {
                    cn.Open();
                    MessageBox.Show("Conexión exitosa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
