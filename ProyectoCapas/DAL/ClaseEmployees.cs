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
    public class ClaseEmployees
    {
        /// <summary>
        /// Método ListarEmployees
        /// Ejecuta una consulta SQL de tipo "Select" que obtiene la data de la base de datos.
        /// Espera como parámetro un string que definirá la consulta en caso de buscar algo en específico.
        /// Retorna la data en formato de DataTable
        /// </summary>
        /// <param name="strEmpl"></param>
        /// <returns></returns>
        public static DataTable ListarEmployees(string strEmpl)
        {
            string strSQL = "select * from cargaremployees";
            strSQL += " where LastName like '%" + strEmpl + "%'";
            return Configuracion.GetDataTable(strSQL);
        }
        /// <summary>
        /// Método InsetarEmployees
        /// Ejecuta una consulta SQL de tipo "Insert" que inserta un nuevo registro a la tabla de Employees.
        /// Espera como parámetro una clase que contiene los atributos que son equivalentes a los campos de la tabla employees que se desean insertar.
        /// Retorna un valor booleano con el fin de informar el éxito que tuvo la transacción.
        /// </summary>
        /// <param name="employees"></param>
        /// <returns></returns>
        public static bool InsertarEmployees(Employees employees)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "InsertarEmployees";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@LastName", employees.LastName);
            cmd.Parameters["@LastName"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@FirstName", employees.FirstName);
            cmd.Parameters["@FirstName"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Title", employees.Title);
            cmd.Parameters["@Title"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@TitleOfC", employees.TitleOfCourtesy);
            cmd.Parameters["@TitleOfC"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@BirthD", employees.BirthDate);
            cmd.Parameters["@BirthD"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@HireDate", employees.HireDate);
            cmd.Parameters["@HireDate"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Address", employees.Address);
            cmd.Parameters["@Address"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@City", employees.City);
            cmd.Parameters["@City"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Region", employees.Region);
            cmd.Parameters["@Region"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@PostalCod", employees.PostalCode);
            cmd.Parameters["@PostalCod"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Country", employees.Country);
            cmd.Parameters["@Country"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@HPhone", employees.HomePhone);
            cmd.Parameters["@HPhone"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Extens", employees.Extension);
            cmd.Parameters["@Extens"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Photo", employees.Photo);
            cmd.Parameters["@Photo"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Notes", employees.Notes);
            cmd.Parameters["@Notes"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Reports", employees.ReportsTo);
            cmd.Parameters["@Reports"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@PhotoP", employees.PhotoPath);
            cmd.Parameters["@PhotoP"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Salary", employees.Salary);
            cmd.Parameters["@Salary"].Direction = ParameterDirection.Input;
            return Configuracion.ExecTransactionParameters(cmd);
        }
        /// <summary>
        /// Método EditarEmployees
        /// Ejecuta una consulta SQL de tipo "Update" que inserta un nuevo registro a la tabla de Employees.
        /// Espera como parámetro una clase que contiene los atributos que son equivalentes a los campos de la tabla employees que se desean insertar.
        /// Retorna un valor booleano con el fin de informar el éxito que tuvo la transacción.
        /// </summary>
        /// <param name="employees"></param>
        /// <returns></returns>
        public static bool EditarEmployees(Employees employees)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "ActualizaEmployees";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDEmployee", employees.EmployeeID);
            cmd.Parameters["@IDEmployee"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@LastName", employees.LastName);
            cmd.Parameters["@LastName"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@FirstName", employees.FirstName);
            cmd.Parameters["@FirstName"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Title", employees.Title);
            cmd.Parameters["@Title"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@TitleOfC", employees.TitleOfCourtesy);
            cmd.Parameters["@TitleOfC"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@BirthD", employees.BirthDate);
            cmd.Parameters["@BirthD"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@HireDate", employees.HireDate);
            cmd.Parameters["@HireDate"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Address", employees.Address);
            cmd.Parameters["@Address"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@City", employees.City);
            cmd.Parameters["@City"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Region", employees.Region);
            cmd.Parameters["@Region"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@PostalCod", employees.PostalCode);
            cmd.Parameters["@PostalCod"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Country", employees.HomePhone);
            cmd.Parameters["@Country"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@HPhone", employees.HomePhone);
            cmd.Parameters["@HPhone"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Extens", employees.Extension);
            cmd.Parameters["@Extens"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Photo", employees.Photo);
            cmd.Parameters["@Photo"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Notes", employees.Notes);
            cmd.Parameters["@Notes"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Reports", employees.ReportsTo);
            cmd.Parameters["@Reports"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@PhotoP", employees.PhotoPath);
            cmd.Parameters["@PhotoP"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Salary", employees.Salary);
            cmd.Parameters["@Salary"].Direction = ParameterDirection.Input;
            return Configuracion.ExecTransactionParameters(cmd);
        }
        /// <summary>
        /// Método EliminarEmployees
        /// Ejecuta una consulta SQL de tipo "Delete" que inserta un nuevo registro a la tabla de Employees.
        /// Espera como parámetro una clase que contiene los atributos que son equivalentes a los campos de la tabla employees que se desean insertar.
        /// Retorna un valor booleano con el fin de informar el éxito que tuvo la transacción.
        /// </summary>
        /// <param name="employees"></param>
        /// <returns></returns>
        public static bool EliminaEmployees(Employees employees)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "EliminarEmployees";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idEmpl", employees.EmployeeID);
            cmd.Parameters["@idEmpl"].Direction = ParameterDirection.Input;
            return Configuracion.ExecTransactionParameters(cmd);
        }

       
    }
}
