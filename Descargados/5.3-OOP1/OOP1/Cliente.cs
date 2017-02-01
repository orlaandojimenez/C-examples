using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Cliente : Persona
    {
        int numeroCliente;
        string direccionEntrega;

        public Cliente()
        {
            this.numeroCliente = 456123789;
            this.direccionEntrega = "Ciudad Universitaria s/n";
        }

        //Sobreescritura del Metodo identificarse()
        public override string identificarse()
        {
            string mensaje = "";
            mensaje += base.identificarse();
            mensaje += " - " + this.numeroCliente.ToString();
            mensaje += " - " + this.direccionEntrega;
            return mensaje;
        }

        //Propiedades
        public int NumeroCliente
        {
            get { return numeroCliente; }
            set { numeroCliente = value; }
        }

        public string DireccionEntrega
        {
            get { return direccionEntrega; }
            set { direccionEntrega = value; }
        }
    }
}
