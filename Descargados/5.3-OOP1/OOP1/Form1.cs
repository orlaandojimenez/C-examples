using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            Usuario user = new Usuario();
            Cliente cliente = new Cliente();
            Empleado empleado = new Empleado();

            string resultado = "";
            resultado += persona.identificarse() + "\n";
            resultado += user.identificarse() + "\n";
            resultado += cliente.identificarse() + "\n";
            resultado += empleado.identificarse() + "\n";
            MessageBox.Show(resultado);
        }
    }
}
