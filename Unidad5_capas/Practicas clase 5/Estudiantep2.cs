using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad5_capas.Practicas_clase_5
{
    public class Estudiante : Persona
    {
        public string Carrera { get; set; }

        public int EdadCalculada
        {
            get
            {
                return DateTime.Now.Year - AñoNacimiento;
            }
        }

        public Estudiante(string nombre, int añoNacimiento, string carrera)
            : base(nombre, añoNacimiento)
        {
            Carrera = carrera;
        }
    }
}
