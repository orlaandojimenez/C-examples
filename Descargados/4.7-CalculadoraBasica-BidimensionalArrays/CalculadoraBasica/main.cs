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
            string[][] data = new string[3][];
            data[0] = new string[2];
            data[1] = new string[2];
            data[2] = new string[2];

            data[0][0] = "Naranja";
            data[0][1] = "32";
            data[1][0] = "Papaya";
            data[1][1] = "5";
            data[2][0] = "Mandarina";
            data[2][1] = "10";

            string text = data[0][0] + " - " + data[0][1] + "\n";
            text += data[1][0] + " - " + data[1][1] + "\n";
            text += data[2][0] + " - " + data[2][1];

            MessageBox.Show(text);
        }
    }
}
