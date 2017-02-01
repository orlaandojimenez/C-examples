using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random randomObject = new Random();

            int[] a = new int[30];
            string impr = "";

            for (int i = 0; i < 30; i++)
            {
                int random = randomObject.Next(100);
                a[i] = random;
                impr += "La casilla " + i + " Tiene el valor " + a[i] + "\n";
                   
            }

            MessageBox.Show(impr);
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n;
            int[] a = new int[10];

            n = Convert.ToInt32(this.textBox1.Text);

            a[0] = 4;
            a[1] = 5;
            a[2] = 54;
            a[3] = 87;
            a[4] = 12;
            a[5] = 32;
            a[6] = 66;
            a[7] = 3;
            a[8] = 99;
            a[9] = 55;

            for (int i = 0; i < 10; i++)
            {
                if (a[i] == n)
                {
                    MessageBox.Show("El numero " + n + " esta en la casilla " + i);
                    break;
                }
                if (i == 9)
                {
                    if (a[i] != n)
                    {
                        MessageBox.Show("El numero no se encuentra en el arreglo");
                    }
                }
                
                   
            }


            
        }
    }
}
