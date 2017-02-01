using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Usuario : Persona
    {
        int numeroUsuario;
        
        //Constructor de la clase Usuario
        public Usuario()
        {
            this.numeroUsuario = 123456789;
        }

        //Sobreescritura del Metodo identificarse()
        public override string identificarse()
        {
            string mensaje = "";
            mensaje += base.identificarse();
            mensaje += " - " + this.numeroUsuario.ToString();
            return mensaje;
        }

        //Propiedades
        public int NumeroUsuario
        {
            get { return numeroUsuario; }
            set { numeroUsuario = value; }
        }
    }
}