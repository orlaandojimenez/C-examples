using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string result = "";
            //Declaramos un array de numeros
            int[] numbers = { 0, -5, 2, 67, 1000, 3, 5, 6, 5, 13 };
            result = getStringFromArray(numbers) + "\n";

            Array.Sort(numbers);
            result += getStringFromArray(numbers);

            MessageBox.Show(result);

        }

        private string getStringFromArray(int[] array)
        {
            string text = "";
            foreach (int item in array)
            {
                text += item + ", ";
            }
            //Elimina la ultima coma
            text = text.Substring(0, text.Length - 2);
            return text;
        }
    }
}
