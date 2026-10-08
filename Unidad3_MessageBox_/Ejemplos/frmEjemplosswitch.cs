using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad3_MessageBox_
{
    public partial class frmEjemploswitch : Form
    {
        public frmEjemploswitch()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDiadesemana_Click(object sender, EventArgs e)
        {
            int dia;
           
            dia = Convert.ToInt32(txtDiadesemana.Text);

            // logica desarrollada con if else 
            //if (dia == 1)
            //{
            //    MessageBox.Show("Lunes");
            //}
            //else if (dia == 2)
            //{
            //    MessageBox.Show("Martes");
            //}
            //else if (dia == 3)
            //{
            //    MessageBox.Show("Miercoles");
            //}
            //else if (dia == 4)
            //{
            //    MessageBox.Show("Jueves");
            //}
            //else if (dia == 5)
            //{
            //    MessageBox.Show("Viernes");
            //}
            //else if (dia == 6)
            //{
            //    MessageBox.Show("Sabado");
            //}
            //else if (dia == 7)
            //{
            //    MessageBox.Show("Domingo");
            //}
            //else
            //{
            //    MessageBox.Show("El numero ingresado no es valido, ingrese un numero del 1 al 7");
            //}

            //Logica desarrollada con switch case
            switch (dia)
            {
                case 1:
                    MessageBox.Show("Lunes");break;       
                case 2:
                    MessageBox.Show("Martes");break;             
                case 3:
                    MessageBox.Show("Miercoles");break;                  
                case 4:
                    MessageBox.Show("Jueves");break;                  
                case 5:
                    MessageBox.Show("Viernes");break;                 
                case 6:
                    MessageBox.Show("Sabado");break;                  
                case 7:
                    MessageBox.Show("Domingo");break;                 
                default:
                    MessageBox.Show("El numero ingresado no es valido, ingrese un numero del 1 al 7");
                    break;
            }
        }

    }
}
