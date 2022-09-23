using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class ClaseProveedores : Configuracion
    {
        
        // Metodo de listar proveedores.
        // Ejecuta una consulta SQL de tipo "Select" que obtiene la data de la base de datos.
        // Espera como parámetro un string que definirá la consulta en caso de buscar algo en específico.
        public static DataTable ListarProveedores(string strProveedor)
        {
            string strSQL = "select * from Suppliers";
            strSQL += " where CompanyName like '%" + strProveedor + "%'";
            return GetDataTable(strSQL);
        }

        // Insertar Proveedores
        // Ejecuta una consulta SQL de tipo "Insert" que inserta un nuevo registro a la tabla de producto.
        public static bool InsertaProveedores(Proveedores Proveedor)
        {
            string strSQL = "Insert into Suppliers (SupplierID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax,HomePage ) values(";
            strSQL += "'" + Proveedor.SupplierID + "',";
            strSQL += "'" + Proveedor.CompanyName + "',";
            strSQL += "'" + Proveedor.ContactName + "',";
            strSQL += "'" + Proveedor.ContactTitle + "',";
            strSQL += "'" + Proveedor.Address + "',";
            strSQL += "'" + Proveedor.City + "',";
            strSQL += "'" + Proveedor.Region + "',";
            strSQL += "'" + Proveedor.PostalCode + "',";
            strSQL += "'" + Proveedor.Country + "',";
            strSQL += "'" + Proveedor.Phone + "',";
            strSQL += "'" + Proveedor.Fax + "',";
            strSQL += "'" + Proveedor.HomePage + "');";
            return ExecTransaction(strSQL);
        }

        // Eliminar Proveedor
        // Ejecuta una consulta SQL de tipo "Delete" que actualiza un registro en específico de la tabla Products.
        // Espera como parámetro un valor entero que contiene el ID del Producto a eliminar.
        public static bool EliminaProveedor(int SupplierID )
        {
            string strSQL = "Delete from Suppliers where SupplierID="+ SupplierID;
            return ExecTransaction(strSQL);
        }

        // Editar Proveedor
        // Ejecuta una consulta SQL de tipo "Delete" que actualiza un registro en específico de la tabla Products.
        public static bool EditarProveedor(Proveedores Proveedor)
        {
            string strSQL = "Update Suppliers  set CompanyName = '" + Proveedor.CompanyName + "',ContactName='" + Proveedor.ContactName + "',ContactTitle='" + Proveedor.ContactTitle + "',Address='" + Proveedor.Address + "',City='" + Proveedor.City + "',Region='" + Proveedor.Region + "',PostalCode='" + Proveedor.PostalCode + "',Country='" + Proveedor.Country + "',Phone='" + Proveedor.Phone + "',Fax='" + Proveedor.Fax + "',Homepage='" + Proveedor.HomePage + "'where SupplierID = '" + Proveedor.SupplierID + "'";
            return ExecTransaction(strSQL);
        }

        /// <summary>
        /// Método InsertaProveedorSP
        /// Ejecuta una consulta SQL de tipo "Insert" que inserta un nuevo registro a la tabla de proveedores.
        /// Espera como parámetro una clase que contiene los atributos que son equivalentes a los campos de la tabla proveedores que se desean insertar.
        /// Retorna un valor booleano con el fin de informar el éxito que tuvo la transacción.
        /// </summary>
        /// <param name="productos"></param>
        /// <returns></returns>
        public static bool InsertaProveedorSP(Proveedores proveedor)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "InsertaProveedores";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CompanyName", proveedor.CompanyName);
            cmd.Parameters["@CompanyName"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@ContactName", proveedor.ContactName);
            cmd.Parameters["@ContactName"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@ContactTitle", proveedor.ContactTitle);
            cmd.Parameters["@ContactTitle"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Address", proveedor.Address);
            cmd.Parameters["@Address"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@City", proveedor.City);
            cmd.Parameters["@City"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Region", proveedor.Region);
            cmd.Parameters["@Region"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@PostalCode", proveedor.PostalCode);
            cmd.Parameters["@PostalCode"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Country", proveedor.Country);
            cmd.Parameters["@Country"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Phone", proveedor.Phone);
            cmd.Parameters["@Phone"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Fax", proveedor.Fax);
            cmd.Parameters["@Fax"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@HomePage", proveedor.HomePage);
            cmd.Parameters["@HomePage"].Direction = ParameterDirection.Input;
            return Configuracion.ExecTransactionParameters(cmd);
        }

    }
}
