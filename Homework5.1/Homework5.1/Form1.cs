using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework5._1
{
    public partial class Form1 : Form
    {

        Queue cola = new Queue();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cola.Dequeue();
            this.listAllElements();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            cola.Enqueue(value);
            this.textBox1.Text = "";
            this.listAllElements();
           
           

            

            
        }

        private void listAllElements()
        {
            string msg = "";

            foreach (var item in cola)
            {
                msg += item.ToString() + "\n";
            }
            this.label1.Text = msg;
        }
    }
}
