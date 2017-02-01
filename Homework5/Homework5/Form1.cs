using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework5
{
    public partial class Form1 : Form
    {

        List<string> lista = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msj = this.textBox1.Text;

            lista.Add(msj);

            foreach (var item in lista)
            {
                this.label1.Text += item + "\n";
            }

            this.textBox1.Text = "";
        }
    }
}
