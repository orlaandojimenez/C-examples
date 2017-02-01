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
        {//Leer un archivo de texto
            //Obtenemos path al Escritorio
            string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            pathDesktop += "\\FSD.txt";
            if(File.Exists(pathDesktop))
            {//El archivo existe, Leer.
                try
                {
                    StreamReader reader = new StreamReader(pathDesktop);//Abrimos el archivo
                    string contenido = reader.ReadLine();               //Leemos la primera linea
                    reader.Close();                                     //Cerramos el archivo
                    string[] comboItems = contenido.Split(',');         //Parseamos la string
                    foreach (string item in comboItems)                 //Agregamos los items al combo
                        this.comboBox1.Items.Add(item);
                }
                catch(Exception ex)
                {//Lanzamos mensaje de error si algo inesperado ocurre
                    MessageBox.Show(this, ex.ToString(), "ERROR leyendo archivo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {//Si el archivo no existe manda un mensaje
                string msg = "El archivo no existe, favor de crearlo.\n";
                msg += "Path: " + pathDesktop + "\n";
                msg += "Recuerda crear contenido separado por comas.\n";
                msg += "Ejemplo: Pedro,Pablo,Juan";
                MessageBox.Show(msg);
            }
        }

    }
}
