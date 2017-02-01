using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2
{
    public partial class Form1 : Form
    {
        int numberClicks = 0;

        public Form1()
        {
            InitializeComponent();
        }

        #region EVENTOS MOUSE
        private void buttonClick_Click(object sender, EventArgs e)
        {
            this.labelClick.Text = "Clicks: " + numberClicks;
            numberClicks++;
        }

        private void buttonClick_MouseHover(object sender, EventArgs e)
        {
            this.labelMouse.Text = "Mouse sobre el botón";
        }

        private void buttonClick_MouseLeave(object sender, EventArgs e)
        {
            this.labelMouse.Text = "Bye";
        }

        private void labelMouse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("click!!");
        }

        private void labelClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("cluck!!");
        }

        #endregion

        #region EVENTOS DE FORMULARIO
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido joven padowan!");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Hasta la vista baby...");
        }
        #endregion

        #region EVENTOS DE TECLADO
        private void textBoxKeyPress_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.textBoxKeyPress2.Text += e.KeyChar.ToString();
            this.labelKeyPress.Text = e.KeyChar.ToString();
        }
        #endregion

        private void textBoxKeyPress_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
