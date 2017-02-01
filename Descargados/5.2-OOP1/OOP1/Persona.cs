using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Persona
    {
        int edad;
        string nombre;

        //Constructor de la clase Persona
        public Persona()
        {
            this.edad = 25;
            this.nombre = "Steve Jobs";
        }

        //Propiedades de la clase Persona
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
