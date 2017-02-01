using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MisViajes
{
    public class clsConexion
    {
        //Se definen variables
        protected SqlDataReader reader;
        protected SqlDataAdapter AdaptadorDatos;
        protected DataSet data;
        protected SqlConnection oconeccion = new SqlConnection();

        public clsConexion()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public void conectar(string tabla)
        {
            //se asigna la conectionstring
            string strConeccion = ConfigurationManager.ConnectionStrings["ViajesConnectionString"].ConnectionString;
            //se asigna el valor a la variable oconeccion
            oconeccion.ConnectionString = strConeccion;
            //se abre la conexion
            oconeccion.Open();
            AdaptadorDatos = new SqlDataAdapter("SELECT * FROM " + tabla, oconeccion);
            SqlCommandBuilder ejecutaComandos = new SqlCommandBuilder(AdaptadorDatos);
            Data = new DataSet();
            AdaptadorDatos.Fill(Data, tabla);
            oconeccion.Close();
        }

        public DataSet Data
        {
            set { data = value; }
            get { return data; }
        }

        public SqlDataReader DataReader
        {
            set { reader = value; }
            get { return reader; }
        }
    }
}