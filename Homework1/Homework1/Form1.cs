using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int numero1;
            //int numero2;

            //numero1 = Convert.ToInt32(this.textBox1.Text);
            //numero2 = Convert.ToInt32(this.textBox2.Text);

            //////////////////////////Ejercicio1 ////////////////////////////////////
            //if (numero1 > numero2)
            //{
            //    MessageBox.Show("El numero " + numero1 + " es mayor al numero " + numero2);
            //}
            //else
            //{
            //    MessageBox.Show("El numero " + numero2 + " es mayor al numero " + numero1);
            //}


            ///////////////////////////Ejercicio2///////////////////7
            //int suma = numero1 + numero2;

            //if (suma <= 256)
            //{
            //    MessageBox.Show("It fits 8 bits");
            //}
            //else if(suma >= 257 && suma <= 1024){
            //    MessageBox.Show("It fits in 10 bits");
            //}
            //else if(suma > 1024){
            //    MessageBox.Show("The number is too big");
            //}


            string text1;
            string text2;

            text1 = this.textBox1.Text;
            text2 = this.textBox2.Text;
           
            MessageBox.Show(text1 + " " + text2);

            MessageBox.Show("La cadena tiene " + (text1 + " " + text2).Length + " caracteres");
        }
    }
}
