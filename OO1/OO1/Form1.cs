using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OO1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            User user = new User();
            MessageBox.Show(user.Nombre);
            MessageBox.Show(user.Edad.ToString());
            user.Nombre = "Luck Skywalker";
            MessageBox.Show(user.Nombre);
        }
    }
}
