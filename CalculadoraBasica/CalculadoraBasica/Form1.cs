using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBasica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int numero1;
            //int numero2;
            //int resultado;

            //numero1 = Convert.ToInt32(this.textBox1.Text);//Convierte a entero y asigna el textbox
            //numero2 = Convert.ToInt32(this.textBox2.Text);//Convierte a entero y asigna el textbox
            //resultado = numero1 + numero2;
            //this.label1.Text = resultado.ToString(); //Asigna el label y muestra el resultado

            //---------------------------------------------------------

            //int numero1;

            //numero1 = Convert.ToInt32(this.textBox1.Text);

            //if (numero1 > 70)
            //{
            //    MessageBox.Show("El numero1 es mayor a 70");
            //}
            //else
            //{
            //    MessageBox.Show("El numero1 es menor o igual a 70");
            //}

            ////////////////////////////////////////////////////////////////

            //int numero1;

            //numero1 = Convert.ToInt32(this.textBox1.Text);

            //if (numero1 >= 90)
            //{

            //    MessageBox.Show("Eres un matado");

            //}

            //else
            //{

            //    if (numero1 >= 70)
            //    {

            //        MessageBox.Show("Panzaste");

            //    }

            //    else
            //    {

            //        MessageBox.Show("Nos vemos en segundas");

            //    }

            //}

            ///////////////////////////////////

            //Usamos la propiedad Text de la instancia comboBox1 de la clase ComboBox

            //para accesar al valor seleccionado (esto no es robusto pero sirve para nuestro ejemplo)

            String operador = this.comboBox1.Text;

            int resultado = 0;

            int valor1 = 0;

            int valor2 = 0;

            //Obtenemos los valores de los TextBox's

           
            if (operador == "+")
            {//SUMA
                valor1 = Convert.ToInt32(this.textBox1.Text);


                valor2 = Convert.ToInt32(this.textBox2.Text);

                resultado = valor1 + valor2;

            }

            else if (operador == "-")
            {//RESTA
                valor1 = Convert.ToInt32(this.textBox1.Text);


                valor2 = Convert.ToInt32(this.textBox2.Text);

                resultado = valor1 - valor2;

            }

            else if (operador == "*")
            {//MULTIPLICACION
                valor1 = Convert.ToInt32(this.textBox1.Text);


                valor2 = Convert.ToInt32(this.textBox2.Text);

                resultado = valor1 * valor2;

            }

            else if (operador == "/")
            {//DIVISION
                valor1 = Convert.ToInt32(this.textBox1.Text);


                valor2 = Convert.ToInt32(this.textBox2.Text);

                resultado = valor1 / valor2;

            }

            else if (operador == "pow")
            {//POTENCIA
                valor1 = Convert.ToInt32(this.textBox1.Text);


                valor2 = Convert.ToInt32(this.textBox2.Text);

                int i = 1;
                resultado = valor1;
                while (i < valor2)
                {
                    resultado = resultado * valor1;
                    i++;
                }
            }

            else if (operador == "!")
            {//FACTORIAL
                valor1 = Convert.ToInt32(this.textBox1.Text);



                textBox2.Hide();
                int i = 1;
                resultado = 1;
                while (i <= valor1)
                {
                    resultado = resultado * i;
                    i++;
                }
                
            }

            else
            {//SIN OPERADOR

                MessageBox.Show("Selecciona un operador");

            }

            //Colocamos el resultado en el Label

            this.label1.Text = resultado.ToString();

            //int i = 0;
            //MessageBox.Show(i.ToString());
            //while (i < 10)
            //{
            //    i++;
            //}
            //MessageBox.Show(i.ToString());

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
