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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button_Calcular_Click(object sender, EventArgs e)
        {
            String operador = this.comboBox1.Text;
            int resultado = 0;
            int valor1 = 0;
            int valor2 = 0;

            //Obtenemos los valores de los TextBox's
            valor1 = Convert.ToInt32(this.textBox_Val1.Text);
            valor2 = Convert.ToInt32(this.textBox_Val2.Text);

            switch (operador)
            {
                case "+"://SUMA
                    resultado = doSuma(valor1, valor2);
                    break;

                case "-"://RESTA
                    resultado = doResta(valor1, valor2);
                    break;

                case "*"://MULTIPLICACION
                    resultado = doMult(valor1, valor2);
                    break;

                case "/"://DIVISION
                    resultado = doDiv(valor1, valor2);
                    break;

                case "pow"://POTENCIA
                    resultado = doPotencia(valor1, valor2);
                    break;

                case "log"://LOGARITMONATURAL
                    resultado = Convert.ToInt32(Math.Log(valor1));
                    break;

                case "sqrt"://RAIZ CUADRADA
                    resultado = Convert.ToInt32(Math.Sqrt(valor1));
                    break;

                default://SIN OPERADOR
                    MessageBox.Show("Selecciona un operador");
                    break;
            }

            //Colocamos el resultado en el Label
            this.label_Resultado.Text = resultado.ToString();
        }
             private int doSuma(int valor1, int valor2) {
            int resultado = valor1 + valor2;
            return resultado;
            }

        private int doResta(int valor1,int valor2){
            int resultado = valor1 - valor2;
            return resultado;
        }

        private int doMult(int valor1, int valor2){
            int resultado = valor1 * valor2;
            return resultado;
        }

        private int doDiv(int valor1, int valor2){
            int resultado = valor1 / valor2;
            return resultado;
        }

        private int doPotencia(int valor1, int valor2){
            int resultado = valor1;
            for (int i = 1; i < valor2; i++)
			{
			    resultado = resultado * valor1;
			}
            return resultado;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
       
        }
    }

