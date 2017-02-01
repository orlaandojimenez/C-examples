using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Empleado : Persona
    {
        int numeroEmpleado;
        double salario;

        //Constructor de la clase Empleado
        public Empleado()
        {
            this.numeroEmpleado = 789456123;
            this.salario = 23500.3;
        }

        //Sobreescritura del Metodo identificarse()
        public override string identificarse()
        {
            string mensaje = "";
            mensaje += base.identificarse();
            mensaje += " - " + this.numeroEmpleado.ToString();
            mensaje += " - " + this.salario.ToString();
            return mensaje;
        }

        public int NumeroEmpleado
        {
            get { return numeroEmpleado; }
            set { numeroEmpleado = value; }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

    }
}
