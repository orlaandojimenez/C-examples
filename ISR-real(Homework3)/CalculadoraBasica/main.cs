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
        //Creamos los arreglos con los datos de la tabla de ISR
        private double[] [] data;

        public main()
        {
            InitializeComponent();
        }

        private void button_Calcular_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != "")
            {
                //Obtenemos el sueldo Neto introducido por el usuario
                double sueldoBruto = Convert.ToDouble(this.textBox1.Text);

                if (sueldoBruto > 0)
                {//Si el sueldo neto es mayor a cero, continuar
                    //Creamos los arreglos de datos
                    createISRTable();
                    int tam = this.data[0].Length;
                    double sueldoNeto, excLimitInf, ISR, limitInf, limitSup, cuotaFix, percent;

                    for (int i = 0; i < tam; i++)
                    {//Iteramos tantas veces como el tamano del arreglo
                        if ((sueldoBruto >= data[0][i]) && (sueldoBruto <= data[1][i]))
                        {
                            limitInf = data[0][i];
                            limitSup = data[1][i];
                            cuotaFix = data[2][i];
                            percent = data[3][i]/100.0;

                            //Aplicamos las operaciones
                            excLimitInf = sueldoBruto - limitInf;
                            ISR = cuotaFix + (excLimitInf * percent);
                            sueldoNeto = sueldoBruto - ISR;

                            //Mandamos mensaje
                            string text = "ISR: " + ISR.ToString() + "\n";
                            text += "Sueldo Neto: " + sueldoNeto.ToString() + "\n";
                            MessageBox.Show(text);

                            break;//Rompemos la iteracion
                        }
                    }
                }
            }
        }

        //Creamos los arreglos de datos y los llenamos
        private void createISRTable()
        {
            //Data from: http://losimpuestos.com.mx/tablas-isr-2015/
            data = new double[4] [];

            //Se declara la longitud de cada fila
            data[0] = new double[11];
            data[1] = new double[11];
            data[2] = new double[11];
            data[3] = new double[11];

            //Datos de limite inferior
            data[0][0] = 0.01;
            data[0][1] = 496.08;
            data[0][2] = 4210.42;
            data[0][3] = 7399.43;
            data[0][4] = 8601.51;
            data[0][5] = 10298.36;
            data[0][6] = 20770.30;
            data[0][7] = 32736.84;
            data[0][8] = 62500.01;
            data[0][9] = 83333.34;
            data[0][10] = 250000.01;

            //Datos de limite superior
            data[1][0] = 496.07;
            data[1][1] = 4210.41;
            data[1][2] = 7399.42;
            data[1][3] = 8601.50;
            data[1][4] = 10298.35;
            data[1][5] = 20770.29;
            data[1][6] = 32736.83;
            data[1][7] = 62500.00;
            data[1][8] = 83333.33;
            data[1][9] = 250000.00;
            data[1][10] = Double.PositiveInfinity;

            //Cuota Fija
            data[2][0] = 0.0;
            data[2][1] = 9.52;
            data[2][2] = 247.24;
            data[2][3] = 594.21;
            data[2][4] = 786.54;
            data[2][5] = 1090.61;
            data[2][6] = 3327.42;
            data[2][7] = 6141.95;
            data[2][8] = 15070.90;
            data[2][9] = 21737.57;
            data[2][10] = 78404.23;

            //Porcentaje sobre el Excedente del Limite Inferior
            data[3][0] = 1.92;
            data[3][1] = 6.4;
            data[3][2] = 10.88;
            data[3][3] = 16.0;
            data[3][4] = 17.92;
            data[3][5] = 21.36;
            data[3][6] = 23.52;
            data[3][7] = 30.0;
            data[3][8] = 32.0;
            data[3][9] = 34.0;
            data[3][10] = 35.0;
        }

    }
}
