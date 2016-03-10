using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

/// <summary>
///Clase de la conexión del proyecto Clientes: 
/// </summary>

namespace AplicacionWeb.CapaDatos
{
    public class DConexion
    {
        //varables:
        private SqlDataReader reader;
        private SqlDataAdapter adaptadorDatos;
        private DataSet data;
        protected SqlConnection cn = new SqlConnection();
        public static string Error;

        public DataSet Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public SqlDataReader DataReader
        {
            get
            {
                return reader;
            }

            set
            {
                reader = value;
            }
        }

        public SqlDataAdapter AdaptadorDatos
        {
            get
            {
                return adaptadorDatos;
            }

            set
            {
                adaptadorDatos = value;
            }
        }

       

        public DConexion()
        {

        }

        public void Conectar(string tabla)
        {
            try
            {
                string strConexion = ConfigurationManager.ConnectionStrings["ClientesConnectionString"].ConnectionString;
                cn.ConnectionString = strConexion;
                cn.Open();
                
                AdaptadorDatos = new SqlDataAdapter("Select * from " + tabla, cn);
                SqlCommandBuilder ejecutamosComandos = new SqlCommandBuilder(AdaptadorDatos);
                Data = new DataSet();
                AdaptadorDatos.Fill(Data, tabla);

                cn.Close();
            }
            catch (Exception ex)
            {

                Error = "ERROR: " + ex.Message.ToString();
                
            }
        }
    }
}