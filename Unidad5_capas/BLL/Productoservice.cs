using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unidad5_capas.DAL;

namespace Unidad5_capas
{
    internal class Productoservice
    {
        // lista simulada de productos
        private List<Producto> productos;


        public Productoservice()
        {
            // inicializar la lista de productos con algunos datos de ejemplo
            productos = new List<Producto>
            {
                new Producto  {Nombre = "Laptop", Precio = 1200 },
                new Producto  {Nombre = "Mouse", Precio = 25 },
                new Producto  {Nombre = "Teclado", Precio = 50 },
                new Producto  {Nombre = "Monitor", Precio = 300 }
            };
        }

        //Metodo para obtener todos los productos
        public List<Producto> ObtenerProductos()
        {
            return productos;
        }

    }
}
