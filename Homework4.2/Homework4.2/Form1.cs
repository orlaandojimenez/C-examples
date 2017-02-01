using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Homework4._2
{
    public partial class Form1 : Form
    {

        
        public string nip = "1234";
        Queue cola = new Queue();
        

        public Form1()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cola.Count == 4)
            {
                textBox1.ReadOnly = true;
            }
            else
            {
                cola.Enqueue(2);
                this.textBox1.Text += "*";
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cola.Count == 4)
            {
                textBox1.ReadOnly = true;
            }
            else
            {
                cola.Enqueue(1);
                this.textBox1.Text += "*";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cola.Count == 4)
            {
                textBox1.ReadOnly = true;
            }
            else
            {
                cola.Enqueue(3);
                this.textBox1.Text += "*";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cola.Count == 4)
            {
                textBox1.ReadOnly = true;
            }
            else
            {
                cola.Enqueue(4);
                this.textBox1.Text += "*";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (cola.Count == 4)
            {
                textBox1.ReadOnly = true;
            }
            else
            {
                cola.Enqueue(5);
                this.textBox1.Text += "*";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (cola.Count == 4)
            {
                textBox1.ReadOnly = true;
            }
            else
            {
                cola.Enqueue(6);
                this.textBox1.Text += "*";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (cola.Count == 4)
            {
                textBox1.ReadOnly = true;
            }
            else
            {
                cola.Enqueue(7);
                this.textBox1.Text += "*";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (cola.Count == 4)
            {
                textBox1.ReadOnly = true;
            }
            else
            {
                cola.Enqueue(8);
                this.textBox1.Text += "*";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (cola.Count == 4)
            {
                textBox1.ReadOnly = true;
            }
            else
            {
                cola.Enqueue(9);
                this.textBox1.Text += "*";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (cola.Count == 4)
            {
                textBox1.ReadOnly = true;
            }
            else
            {
                cola.Enqueue(0);
                this.textBox1.Text += "*";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string resultado = cola.Dequeue().ToString() + cola.Dequeue().ToString() + cola.Dequeue().ToString() + cola.Dequeue().ToString();
            

            if (resultado == nip)
            {
                MessageBox.Show("Acceso correcto");
                this.textBox1.Text = "";
                cola.Clear();
            }
            else
            {
                MessageBox.Show("Acceso denegado");
                this.textBox1.Text = "";
                cola.Clear();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            cola.Clear();
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.ReadOnly = true;
        }
    }
}
