using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_empleados
{
    public class Empleado : Persona
    {
        public decimal Salario { get; set; }

        // Propiedad calculada: solo get, no se guarda
        public decimal SalarioAnual
        {
            get { return Salario * 12; }
        }
    }
}
