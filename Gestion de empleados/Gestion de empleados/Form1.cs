using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_empleados
{
    public partial class Form1 : Form
    {
        // Lista que almacena los empleados
        private List<Empleado> empleados = new List<Empleado>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvEmpleados.Columns.Add("colIdentificacion", "Identificación");
            dgvEmpleados.Columns.Add("colNombre", "Nombre");
            dgvEmpleados.Columns.Add("colSalario", "Salario");
            dgvEmpleados.Columns.Add("colSalarioAnual", "Salario anual");

            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.ReadOnly = true;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtIdentificacion.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe completar la identificación y el nombre.");
                return;
            }

            decimal salario;
            if (!decimal.TryParse(txtSalario.Text, out salario) || salario < 0)
            {
                MessageBox.Show("Ingrese un salario válido.");
                return;
            }

            // Crear el objeto Empleado y guardarlo en la lista
            Empleado nuevo = new Empleado();
            nuevo.Identificacion = txtIdentificacion.Text.Trim();
            nuevo.Nombre = txtNombre.Text.Trim();
            nuevo.Salario = salario;

            empleados.Add(nuevo);

            txtIdentificacion.Clear();
            txtNombre.Clear();
            txtSalario.Clear();
            txtIdentificacion.Focus();

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            dgvEmpleados.Rows.Clear();

            foreach (Empleado emp in empleados)
            {
                dgvEmpleados.Rows.Add(
                    emp.Identificacion,
                    emp.Nombre,
                    emp.Salario.ToString("N2"),
                    emp.SalarioAnual.ToString("N2")
                );
            }

        }
    }
}
