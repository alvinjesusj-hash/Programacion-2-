using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad4_POO.Practicas_clase_4
{
    public class Producto
    {
        public string Nombre;
        public decimal Precio;

        public void MostrarInfo()
                    {
                      MessageBox.Show($"Nombre: {Nombre}\nPrecio: {Precio:C}");
                     }
    }
}
