using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Usuario
    {
        string nombre;
        int edad;
        
        //CONSTRUCTOR DE LA CLASE USUARIO
        public Usuario()
        {
            nombre = "Steve";
            edad = 56;
        }

        //PROPIEDADES - ATRIBUTOS - FIELDS
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
    }
}