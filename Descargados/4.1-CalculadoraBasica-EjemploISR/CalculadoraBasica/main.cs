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
            double bruto = 0;
            double neto = 0;

            //Obtenemos el sueldo bruto a calcular de la TextBox
            bruto = Convert.ToDouble(this.textBox_Val1.Text);

            //Calculamos el Sueldo Neto usando un Metodo
            neto = sueldoNeto(bruto);

            //Desplegamos el resultado
            this.label_Resultado.Text = neto.ToString();
        }

        private double sueldoNeto(double sueldoBruto)
        {
            double sNeto = 0;
            double descuento = sueldoBruto * 0.15;
            sNeto = sueldoBruto - descuento;
            return sNeto;
        }
    }
}
