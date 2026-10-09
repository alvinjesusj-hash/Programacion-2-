using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad3_MessageBox_.Ejemplos;
using Unidad3_MessageBox_.Practicas_clase_3;

namespace Unidad3_MessageBox_
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
            //Application.Run(new frmEjemploswitch());
            //Application.Run(new frmMessageBox());
            //Application.Run(new Ejercicio1());
            //Application.Run(new Ejercicio2());
            Application.Run(new Ejercicio3());
        }
        
    }
}
