using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_producto
{
    internal class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public decimal ObtenerPrecioConIVA()
        {
            return Precio * 1.13m;
        }
    }
}
