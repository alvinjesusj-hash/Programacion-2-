using System;
using System.Globalization;

namespace RegistroActividades
{
    public class Actividad
    {
        public string Descripcion { get; set; }
        public string Responsable { get; set; }
        public DateTime Fecha { get; set; }

        public Actividad(string descripcion, string responsable)
        {
            Descripcion = descripcion;
            Responsable = responsable;
            Fecha = DateTime.Now;
        }

        // Propiedad calculada: solo tiene get
        public string Informacion
        {
            get
            {
                return Descripcion + " - " + Responsable + " - " +
                       Fecha.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
        }
    }
}
