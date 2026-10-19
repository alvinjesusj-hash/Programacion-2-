using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad4_POO.Ejemplos
{
    internal class Persona
    {
        //Atributos a campos 
        private string _nombre;

        public string Nombre
        { 
           get {return _nombre; }
           set { _nombre = value; }
        }
        public int Edad;
        private int _edad
         
        {
            get { return _edad; } 
            set
            {
                if (value >=0 && value <=120)
                
                  _edad = value;
                else
                    MessageBox.Show("Edad invalida");
                
            }

        }

        //Metodo o accion 
        public void MostrarDatos()
        {
            MessageBox.Show("Nombre: " + Nombre + "\nEdad: " + Edad);
        }
    }
}
