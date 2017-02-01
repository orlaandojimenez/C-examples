using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Christmas_tree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            string figura = this.comboBox1.Text;
            string impr = "";



            n = Convert.ToInt32(this.textBox1.Text);

            switch (figura)
            {
                case "*":
               for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    impr = impr + figura;
                }
                impr = impr + figura + "\n";
            }
             MessageBox.Show(impr);
                   break;

                case "-":
                   for (int i = 0; i < n; i++)
                   {
                       for (int j = 0; j < i; j++)
                       {
                           impr = impr + figura;
                       }
                       impr = impr + figura + "\n";
                   }
                   MessageBox.Show(impr);
                   break;

                case "%":
                   for (int i = 0; i < n; i++)
                   {
                       for (int j = 0; j < i; j++)
                       {
                           impr = impr + figura;
                       }
                       impr = impr + figura + "\n";
                   }
                   MessageBox.Show(impr);
                   break;

                case "&":
                   for (int i = 0; i < n; i++)
                   {
                       for (int j = 0; j < i; j++)
                       {
                           impr = impr + figura;
                       }
                       impr = impr + figura + "\n";
                   }
                   MessageBox.Show(impr);
                   break;

                   }
            
        }
       
    }

}
