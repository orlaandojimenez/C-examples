using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace OOP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//STACK / PILAS
            Stack pila = new Stack();
            string msg = "";
            //Inserta los objetos en la Pila
            pila.Push("Hola");
            pila.Push("FIME");
            pila.Push("!");

            //Uno por uno Retira los elementos de la pila
            msg += pila.Pop().ToString() + "\n";
            msg += pila.Pop().ToString() + "\n";
            msg += pila.Pop().ToString();

            MessageBox.Show(msg);
        }

        private void button2_Click(object sender, EventArgs e)
        {//COLAS / QUEUES
            Queue cola = new Queue();
            string msg = "";
            //Inserta los objetos en la Cola
            cola.Enqueue("Hola");
            cola.Enqueue("FIME");
            cola.Enqueue("!");

            //Uno por uno Retira los elementos de la cola
            msg += cola.Dequeue().ToString() + "\n";
            msg += cola.Dequeue().ToString() + "\n";
            msg += cola.Dequeue().ToString();

            //Retira todos los elementos con un ciclo
            msg += "\n\n\n";
            for (int i = 1; i <= cola.Count; i++)
            {
                msg += cola.Dequeue().ToString() + "\n";
            }

            MessageBox.Show(msg);
        }

        private void button4_Click(object sender, EventArgs e)
        {//STACK / PILAS - Usando un ciclo for para extraer los elementos
            Stack pila = new Stack();
            string msg = "";
            //Inserta los objetos en la Pila
            pila.Push("Hola");
            pila.Push("FIME");
            pila.Push("!");

            //Retira todos los elementos con un ciclo
            while(pila.Count > 0)
            {
                msg += pila.Pop().ToString() + "\n";
            }

            MessageBox.Show(msg);
        }

        private void button3_Click(object sender, EventArgs e)
        {//COLAS / QUEUES - Usando un ciclo for para extraer los elementos
            Queue cola = new Queue();
            string msg = "";
            //Inserta los objetos en la Cola
            cola.Enqueue("Hola");
            cola.Enqueue("FIME");
            cola.Enqueue("!");

            //Retira todos los elementos con un ciclo
            while (cola.Count > 0)
            {
                msg += cola.Dequeue().ToString() + "\n";
            }

            MessageBox.Show(msg);
        }

    }
}
