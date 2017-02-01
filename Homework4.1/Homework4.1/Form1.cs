using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Machine machine = new Machine();
            LightMachine lightMachine = new LightMachine(123);
            HardMachine hardMachine = new HardMachine(456);
            HeavyDutyMachine heavyMachine = new HeavyDutyMachine(789);

            string resultado = "";
            resultado += machine.TurnOn() + "\n";
            resultado += lightMachine.TurnOn() + "\n";
            resultado += hardMachine.TurnOn() + "\n";
            resultado += heavyMachine.TurnOn() + "\n";
            MessageBox.Show(resultado);

            resultado = "";
            resultado += machine.MachineData + "\n";
            resultado += lightMachine.MachineData + "\n";
            resultado += hardMachine.MachineData + "\n";
            resultado += heavyMachine.MachineData + "\n";
            MessageBox.Show(resultado);
        }
    }
}
