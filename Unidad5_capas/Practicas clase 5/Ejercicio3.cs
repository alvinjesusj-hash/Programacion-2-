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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            DialogResult respuesta = MessageBox.Show(
                "¿Desea guardar los cambios?",
                "Confirmar cambios",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                MessageBox.Show("Los cambios se guardaron correctamente.");
            }
            else if (respuesta == DialogResult.No)
            {
                MessageBox.Show("Los cambios no se guardaron.");
            }
            else if (respuesta == DialogResult.Cancel)
            {
                MessageBox.Show("Operación cancelada.");
            }

        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {

            List<Personas> personas = new List<Personas>();

            personas.Add(new Personas ("Carlos", 21));
            personas.Add(new Personas ("María", 19));
            personas.Add(new Personas ("José", 23));

            string informacion = "";

            foreach (Personas persona in personas)
            {
                informacion += "Nombre: " + persona.Nombre +
                               "\nEdad: " + persona.Edad +
                               "\n\n";
            }

            MessageBox.Show(informacion, "Lista de personas");

        }
    }
}
