using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad2_operadores.Ejemplos;

namespace Unidad2_operadores
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new EjemploOperadore());
            //Application.Run(new Comparador());
            //Application.Run(new EjemploControles());
            Application.Run(new Colores());
        }
    }
}
