using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///////////////////Ejercicio1///////////////
            //int numero = 1;
            //int resultado = 0;

            //while (numero <= 10)
            //{
            //    resultado = resultado + numero;
            //    MessageBox.Show(resultado.ToString());
            //    numero++;
            //}



            /////////////////////Ejercicio2////////////////////7
            //int numero = 1;
            //int resultado = 1;
            //while (numero <= 10)
            //{
            //    resultado = resultado * numero;
            //    MessageBox.Show(resultado.ToString());
            //    numero++;
            //}

            int i = 1;
            int resultado = 1;
            int n;



            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Introduce un valor");
                return;
            }
            
                n = Convert.ToInt32(this.textBox1.Text);

                while (i <= n)
                {
                    resultado = resultado * i;
                    i++;
                }

                MessageBox.Show(resultado.ToString());
            }
            

////////////////////EJERCICIO5//////////////////////////////////77
         //int i = 1;
         //   int resultado = 0;
         //   int n;
         //   int res = 0;

         //   n = Convert.ToInt32(this.textBox1.Text);

         //   while (i <= n)
         //   {
         //       resultado = resultado + i;
         //       i++;
         //   }
         //   res = (n * (n + 1)) / 2;

         //   MessageBox.Show("Con while " + resultado.ToString());
         //   MessageBox.Show("Con formula " + res.ToString());
            
        //}
    }
}
