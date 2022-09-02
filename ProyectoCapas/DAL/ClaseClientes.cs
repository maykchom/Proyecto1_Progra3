﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Entidades;

namespace DAL
{
    public class ClaseClientes :Configuracion
    {
        /// <summary>
        /// Método ListarShippers
        /// Ejecuta una consulta SQL de tipo "Select" que obtiene la data de la base de datos.
        /// Espera como parámetro un string que definirá la consulta en caso de buscar algo en específico.
        /// Retorna la data en formato de DataTable
        /// </summary>
        /// <param name="strCliente"></param>
        /// <returns></returns>
        public static DataTable ListarClientes(string strClientes)
        {
            string strSQL = "select * from vistaCustomers";
            strSQL += " where CompanyName like '%" + strClientes + "%'";
            return GetDataTable(strSQL);
        }

        // Eliminar Clientes
        // Ejecuta un Procedimiento almacenado SQL de tipo "Delete" que actualiza un registro en específico de la tabla customers.
        // Espera como parámetro un valor entero que contiene el ID del curtomer a eliminar.
       
        // Editar Cliente
        // Ejecuta un procedimiento almacenado SQL de tipo "Delete" que actualiza un registro en específico de la tabla costumers.
        public static bool EditarCliente(Clientes Cliente)
        {
            
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "ActualizarCustomer";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdCustumer", Cliente.CustomerID);
            cmd.Parameters["@IdCustumer"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@CompanyName", Cliente.CompanyName);
            cmd.Parameters["@CompanyName"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@ContactName", Cliente.ContactName);
            cmd.Parameters["@ContactName"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@ContactTitle", Cliente.ContactTitle);
            cmd.Parameters["@ContactTitle"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Address", Cliente.Address);
            cmd.Parameters["@Address"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@City", Cliente.City);
            cmd.Parameters["@City"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Region", Cliente.Region);
            cmd.Parameters["@Region"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@PostalCode", Cliente.PostalCode);
            cmd.Parameters["@PostalCode"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Country", Cliente.Country);
            cmd.Parameters["@Country"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Phone", Cliente.Phone);
            cmd.Parameters["@Phone"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Fax", Cliente.Fax);
            return Configuracion.ExecTransactionParameters(cmd);
        
    }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="clientes"></param>
        /// <returns></returns>
        public static bool InsertarClientes(Clientes Cliente)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "InsertarCustomer";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdCustomer", Cliente.CustomerID);
            cmd.Parameters["@IdCustomer"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@CompanyName", Cliente.CompanyName);
            cmd.Parameters["@CompanyName"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@ContactName", Cliente.ContactName);
            cmd.Parameters["@ContactName"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@ContactTitle", Cliente.ContactTitle);
            cmd.Parameters["@ContactTitle"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Address", Cliente.Address);
            cmd.Parameters["@Address"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@City", Cliente.City);
            cmd.Parameters["@City"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Region", Cliente.Region);
            cmd.Parameters["@Region"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@PostalCode", Cliente.PostalCode);
            cmd.Parameters["@PostalCode"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Country", Cliente.Country);
            cmd.Parameters["@Country"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Phone", Cliente.Phone);
            cmd.Parameters["@Phone"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Fax", Cliente.Fax);
            return Configuracion.ExecTransactionParameters(cmd);
        }
        // Eliminar clientes
        // Ejecuta un Procedimiento almacenado SQL de tipo "Delete" que actualiza un registro en específico de la tabla customers.
       
        public static bool EliminarCustomer(string Cliente)
        {

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "EliminarCustomer";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdCliente", Cliente);
            cmd.Parameters["@IdCliente"].Direction = ParameterDirection.Input;

            return Configuracion.ExecTransactionParameters(cmd);

        }
    }
}
