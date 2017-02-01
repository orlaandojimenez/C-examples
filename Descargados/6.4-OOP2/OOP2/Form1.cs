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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string output;
            string originalString, string1, string2,
             string3, string4;

            char[] characterArray = { 'b', 'i', 'r', 't', 'h', ' ', 'd', 'a', 'y' };

            // string initialization
            originalString = "Welcome to C# programming!";
            string1 = originalString;
            string2 = new string(characterArray);
            string3 = new string(characterArray, 6, 3);
            string4 = new string('C', 5);

            output = "string1 = " + "\"" + string1 + "\"\n" +
            "string2 = " + "\"" + string2 + "\"\n" +
            "string3 = " + "\"" + string3 + "\"\n" +
            "string4 = " + "\"" + string4 + "\"\n";

            MessageBox.Show(output, "String Class Constructors",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] strings = { "started", "starting", "ended", "ending" };
            string output = "";

            //test every string to see if it starts with "st"
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].StartsWith("st"))
                {
                    output += strings[i] + " starts with st \n";
                }
            }
            output += "\n";

            // test every string to see if it ends with "ed"
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].EndsWith("ed"))
                {
                    output += strings[i] + " ends with ed \n";
                }
            }
            
            MessageBox.Show(output, "Demonstrating StartsWith and EndsWith methods",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string letters = "abcdefghijklmabcdefghijklm";
            string output = "";

            // invoke Substring method and pass it one parameter
            output += "Substring from index 20 to end is \"" +
            letters.Substring(20) + "\"\n";

            // invoke Substring method and pass it two parameters
            output += "Substring from index 0 to 6 is \"" +
            letters.Substring(0, 6) + "\"";

            MessageBox.Show(output,
            "Demonstrating String method Substring",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string string1 = "cheers!";
            string string2 = "GOOD BYE ";
            string string3 = " spaces ";
            string output;

            output = "string1 = \"" + string1 + "\"\n" +
            "string2 = \"" + string2 + "\"\n" +
            "string3 = \"" + string3 + "\"";

            // call method Replace
            output +=
            "\n\nReplacing \"e\" with \"E\" in string1: \"" +
            string1.Replace('e', 'E') + "\"";

            // call ToLower and ToUpper
            output += "\n\nstring1.ToUpper() = \"" +
            string1.ToUpper() + "\"\nstring2.ToLower() = \"" +
            string2.ToLower() + "\"";
            // call Trim method
            output += "\n\nstring3 after trim = \"" +
            string3.Trim() + "\"";

            // call ToString method
            output += "\n\nstring1 = \"" + string1.ToString() + "\"";

            MessageBox.Show(output,
            "Demonstrating various string methods",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string csvString = "pedro,juan,liz,hazael,fernando";
            string[] csvArray = csvString.Split(',');
            string resultado1 = "";
            string resultado2 = "";

            foreach (string word in csvArray)
            {//USO DEL FOREACH PARA RECORRER EL ARREGLO
                resultado1 += word + "\n";
            }

            for(int i = 0; i < csvArray.Length; i++)
            {
                resultado2 += csvArray[i] + "\n";
            }

            MessageBox.Show(resultado1 + "\n\n" + resultado2);

        }
    }
}
