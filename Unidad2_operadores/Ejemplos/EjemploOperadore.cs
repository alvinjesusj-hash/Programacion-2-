using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad2_operadores.Ejemplos
{
    public partial class EjemploOperadore : Form
    {
        public EjemploOperadore()
        {
            InitializeComponent();
        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            // Declaracion de variables
            int a = 10;
            int b = 5;


            bool resultado = a + b; // Operacion relacional

            int suma = a + b; // Operador aritmetico 
            int modulo = a % b; // Operador aritmetico

            bool condicion = (a < b) && (b > 0); // Operador logico
            MessageBox.Show("a es mayor que b? " + resultado);
            MessageBox.Show("La suma de a + b es: " + suma);
            MessageBox.Show("El módulo de a % b es: " + modulo);
            MessageBox.Show("(a>b) y (b>0)? " + condicion);
        }
    }
}
