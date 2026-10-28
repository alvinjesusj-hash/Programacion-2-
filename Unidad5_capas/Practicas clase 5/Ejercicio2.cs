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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            int añoNacimiento;

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCarrera.Text) ||
                !int.TryParse(txtNacimiento.Text, out añoNacimiento) ||
                añoNacimiento <= 0 ||
                añoNacimiento > DateTime.Now.Year)
            {
                MessageBox.Show("Ingrese los datos correctamente.");
                return;
            }

            Estudiante estudiante = new Estudiante(
                txtNombre.Text,
                añoNacimiento,
                txtCarrera.Text
            );

            MessageBox.Show(
                "Nombre: " + estudiante.Nombre +
                "\nAño de nacimiento: " + estudiante.AñoNacimiento +
                "\nCarrera: " + estudiante.Carrera +
                "\nEdad calculada: " + estudiante.EdadCalculada
            );

        }
    }
}
