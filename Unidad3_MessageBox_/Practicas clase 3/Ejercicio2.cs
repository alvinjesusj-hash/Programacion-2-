using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad3_MessageBox_.Practicas_clase_3
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Desea salir del programa?",
                                                      "Confirmación de cierre",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);
        }
    }
}
