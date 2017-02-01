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
            //Creamos una instancia de la clase Random
            Random randomObject = new Random();

            int random = randomObject.Next();
            int r0y5 = randomObject.Next(5);
            int r20y30 = randomObject.Next(20, 30);

            string text = "Numeros aleatorios: " + random + ", " + r0y5 + ", " + r20y30;
            MessageBox.Show(text);
        }

    }
}
