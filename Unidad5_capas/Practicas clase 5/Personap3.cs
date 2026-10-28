using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad5_capas.Practicas_clase_5
{
    public class Personas
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Personas(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
    }
}
