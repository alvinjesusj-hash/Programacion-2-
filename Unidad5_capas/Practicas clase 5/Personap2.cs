using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad5_capas.Practicas_clase_5
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int AñoNacimiento { get; set; }

        public Persona(string nombre, int añoNacimiento)
        {
            Nombre = nombre;
            AñoNacimiento = añoNacimiento;
        }
    }
}
