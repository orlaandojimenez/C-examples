using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace OOP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//Crear archivo de Texto
            //Obtenemos mensaje escrito por el usuario
            string msg = this.textBox1.Text;
            if(msg == "")//Si el usuario no ha escrito algo, pon un default
                msg += "Hola FIME!";
            //Obtenemos path al Escritorio
            string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            pathDesktop += "\\FSD.txt";
            try
            {//Usa un try catch por si ocurren errores
                StreamWriter file = new StreamWriter(pathDesktop);
                file.Write(msg);
                file.Close();
                MessageBox.Show("Archivo Creado!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.ToString(), "Error escribiendo el archivo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
