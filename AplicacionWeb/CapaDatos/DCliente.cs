﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
using System.Data.SqlClient;
using System.Data;
using AplicacionWeb.CapaDatos;

/// <summary>
/// Clase Cliente:
/// </summary>

namespace AplicacionWeb.CapaDatos
{
    public class DCliente
    {
        DConexion conexion = new DConexion();

        string tabla = "Cliente";//nombre de la tabla:
        private int idCliente;
        private string nombre;
        private string direccion;
        private string telefono;


        public DCliente(int idCliente, string nombre, string direccion, string telefono)
        {
            this.IdCliente = idCliente;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Telefono = telefono;
        }
        public DCliente()
        {
            
          
        }


        //Métodos para establecer y recuperar los datos:
        public int IdCliente
        {
            get
            {
                return idCliente;
            }

            set
            {
                idCliente = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

       //Método Agregar registros cliente:
       public void Agregar()
       {
            conexion.Conectar(tabla);
            
            //obtener las filas de tabla:
            DataRow fila;
            fila = conexion.Data.Tables[tabla].NewRow();
            //fila["IdCliente"] = IdCliente;
            fila["Nombre"] = Nombre;
            fila["Direccion"] = Direccion;
            fila["Telefono"] = Telefono;

            conexion.Data.Tables[tabla].Rows.Add(fila);
            conexion.AdaptadorDatos.Update(conexion.Data, tabla);
        } 

        
    }
}