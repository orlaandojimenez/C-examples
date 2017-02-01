using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework4._3
{
    public partial class Form1 : Form
    {
        string dash;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dash = this.textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] separed = dash.Split('-');

            foreach (var word in separed)
            {
                this.comboBox1.Items.Add(word + "\n");
            }

            
        }
    }
}
