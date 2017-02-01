﻿using System;
using System.Data;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Collections.Generic;

/// <summary>
/// Summary description for SQLManager
/// </summary>
/// 
public static class SQLManager
{
    /// <summary>
    /// Metodo que ejecuta un Stored Procedure en base de datos y que posee un manejador Excepciones
    /// </summary>
    /// <param name="storedProcedure">Nombre del Stored Procedure</param>
    /// <param name="parametros">Parametros el Stored Procedure</param>
    /// <returns></returns>
    public static DataSet EjecutarQueryConSP(string storedProcedure, params SqlParameter[] parametros)
    {
        DataSet dataSet = null;
        SqlCommand command;
        SqlDataAdapter sqlDataAdapter;
        string connectionString = "Data Source=MSI;Initial Catalog=NorthWind;Integrated Security=True";

        //obtenemos la string de conexion para el tipo de servidor especificado
        //connectionString = WebConfigurationManager.ConnectionStrings["FIME-Flow-System"].ConnectionString;

        SqlConnection cnn = new SqlConnection(connectionString);//creamos una conexion a la base de datos

        //intentamos abrir la conexion y obtener los datos de la consulta
        try
        {
            cnn.Open();
            command = new SqlCommand(storedProcedure, cnn);
            command.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < parametros.Length; i++)
                command.Parameters.Add(parametros[i]);

            sqlDataAdapter = new SqlDataAdapter(command);
            dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            cnn.Close();
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            Debug.WriteLine(ex.StackTrace);
            dataSet = null;
        }

        return dataSet;
    }

}
