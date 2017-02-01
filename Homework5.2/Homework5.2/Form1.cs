using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            pathDesktop += "\\BaseDeDatos.csv";

            List<string[]> myDB = new List<string[]>();//El tipo de dato es un arreglo de strings
            if (File.Exists(pathDesktop))
            {
                try
                {
                    //READ THE FILE AND LOAD IN RAM ALL DATABASE
                StreamReader reader = new StreamReader(pathDesktop); //Abrimos el archivo

                while (!reader.EndOfStream)
                {//Read the file until the end
                    //Read a line
                    string line = reader.ReadLine();
                    //Parse a line
                    string[] items = line.Split(',');
                    myDB.Add(items);
                }

                reader.Close(); //Cerramos el archivo

                //WORK WITH THE DATABASE

                string dumyText = "";
                double totalPurchase = 0.0;
                double totalCost = 0.0;
                double totalProfit = 0.0;
                
                    double actualPurchase = 0.0;
                    int mayorCustomerIndex = 0;
                double lastMayorPurchase = 0.0;

                    //List all Customers
                foreach (string[] row in myDB)
                {
                    dumyText += row[0] + " - " + row[1] + "\n";
                }

                    //Calculate total purchase and Cost
                    int i = 0;
                foreach (string[] row in myDB)
                {
                    actualPurchase = Convert.ToDouble(row[2]);
                    totalPurchase += actualPurchase;
                    totalCost += Convert.ToDouble(row[3]);

                    if (actualPurchase > lastMayorPurchase)
                    {
                        mayorCustomerIndex = i;
                        lastMayorPurchase = actualPurchase;
                    }

                    i++;
                }
                totalProfit = totalPurchase - totalCost;
                    dumyText += "Total Purchase: " + totalPurchase.ToString() + "\n";
                    dumyText += "Total Profit: " + totalProfit.ToString() + "\n";
                    dumyText += "Mayor Customer: " + myDB[mayorCustomerIndex][1];




                    
                this.label1.Text = dumyText;

                 }
                
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.ToString(), "ERROR leyendo el archivo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
            else
            {//Si el archivo no existe manda un mensaje
                string msg = "El archivo no existe, favor de crearlo. \n";
                MessageBox.Show(msg);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
