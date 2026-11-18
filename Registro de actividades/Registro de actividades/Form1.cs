using RegistroActividades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_de_actividades
{
    public partial class Form1 : Form
    {
        private List<Actividad> actividades = new List<Actividad>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvActividades.Columns.Add("colDescripcion", "Descripción");
            dgvActividades.Columns.Add("colResponsable", "Responsable");
            dgvActividades.Columns.Add("colFecha", "Fecha");
            dgvActividades.Columns.Add("colInformacion", "Información");

            dgvActividades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActividades.AllowUserToAddRows = false;
            dgvActividades.ReadOnly = true;

            dgvActividades.Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                                    AnchorStyles.Left | AnchorStyles.Right;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtResponsable.Text))
            {
                MessageBox.Show("Debe completar la descripción y el responsable.");
                return;
            }

            Actividad nueva = new Actividad(txtDescripcion.Text.Trim(),
                                            txtResponsable.Text.Trim());
            actividades.Add(nueva);

            MostrarActividades();

            txtDescripcion.Clear();
            txtResponsable.Clear();
            txtDescripcion.Focus();
        }

        private void MostrarActividades()
        {
            dgvActividades.Rows.Clear();

            foreach (Actividad a in actividades)
            {
                dgvActividades.Rows.Add(
                    a.Descripcion,
                    a.Responsable,
                    a.Fecha.ToString("dd/MM/yyyy"),
                    a.Informacion
                );
            }
        }
    }
}
