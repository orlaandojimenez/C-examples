using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace MisViajes
{
    public class clsViaje: clsConexion
    {
        string tabla = "viaje"; //nombre de la tabla
        //protected int idviaje;
        protected string destino;
        protected string fecha_salida;
        protected string fecha_regreso;
        protected string hotel;

        public clsViaje(string destino, string fecha_salida, string fecha_regreso, string hotel)
        {
            //this.idviaje = idviaje;
            this.destino = destino;
            this.fecha_salida = fecha_salida;
            this.fecha_regreso = fecha_regreso;
            this.hotel = hotel;
        }
        //metodos para establecer y recuperar datos
        //public int Idviaje
        //{
        //    set { idviaje = value; }
        //    get { return idviaje; }
        //}

        public string Destino
        {
            set { destino = value; }
            get { return destino; }
        }

        public string Fecha_Salida
        {
            set { fecha_salida = value; }
            get { return fecha_salida; }
        }

        public string Fecha_Regreso
        {
            set { fecha_regreso = value; }
            get { return fecha_regreso; }
        }

        public string Hotel
        {
            set { hotel = value; }
            get { return hotel; }
        }

        //metodo agregar registro
        public void Agregar()
        {
            conectar(tabla);
            DataRow fila; //DataRow es una fila
            fila = Data.Tables[tabla].NewRow();
            fila["destino"] = Destino;
            fila["fecha_salida"] = Fecha_Salida;
            fila["fecha_regreso"] = Fecha_Regreso;
            fila["hotel"] = Hotel;

            Data.Tables[tabla].Rows.Add(fila); //se agrega una fila al dataset
            AdaptadorDatos.Update(Data, tabla);
        }

        public bool eliminar(int valor)
        {
            conectar(tabla);
            DataRow fila;
            int x = Data.Tables[tabla].Rows.Count - 1;
            for (int i = 0; i <= x; i++)
            {
                fila = Data.Tables[tabla].Rows[i];

                if (int.Parse(fila["idcliente"].ToString()) == valor)
                {
                    fila = Data.Tables[tabla].Rows[i];
                    fila.Delete();
                    DataTable tablaborrados;
                    tablaborrados = Data.Tables[tabla].GetChanges(DataRowState.Deleted);
                    AdaptadorDatos.Update(tablaborrados);
                    Data.Tables[tabla].AcceptChanges();
                    return true;
                }
            } return false;
        }

        public bool existe(int valor)
        {
            conectar(tabla);
            DataRow fila;
            int x = Data.Tables[tabla].Rows.Count - 1;
            for (int i = 0; i <= x; i++)
            {
                fila = Data.Tables[tabla].Rows[i];
                if (int.Parse(fila["idcliente"].ToString()) == valor)
                {
                    //Idcliente = int.Parse(fila["idcliente"].ToString());
                    //Nombre = fila["nombre"].ToString();
                    //Direccion = fila["direccion"].ToString();
                    //Telefono = fila["telefono"].ToString();
                    return true;
                }
            } return false;
        }
    }
}