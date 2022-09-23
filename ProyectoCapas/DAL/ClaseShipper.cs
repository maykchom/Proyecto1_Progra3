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
    public class ClaseShipper
    {
        /// <summary>
        /// Método ListarShippers
        /// Ejecuta una consulta SQL de tipo "Select" que obtiene la data de la base de datos.
        /// Espera como parámetro un string que definirá la consulta en caso de buscar algo en específico.
        /// Retorna la data en formato de DataTable
        /// </summary>
        /// <param name="strShippers"></param>
        /// <returns></returns>
        public static DataTable ListarShipper(string strShipper)
        {
            string strSQL = "select * from shippers";
            strSQL += " where CompanyName like '%" + strShipper + "%'";
            return Configuracion.GetDataTable(strSQL);
        }
        // Editar Shipper
        // Ejecuta un procedimiento almacenado SQL de tipo "Delete" que actualiza un registro en específico de la tabla Shippers.
        public static bool EditarShipper(Shipper Shipper)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Actualizarshippers";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("ShipperAID", Shipper.ShipperID);
            cmd.Parameters["@ShipperAID"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@CompanyName", Shipper.CompanyName);
            cmd.Parameters["@CompanyName"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Phone", Shipper.Phone);
            cmd.Parameters["@Phone"].Direction = ParameterDirection.Input;
            return Configuracion.ExecTransactionParameters(cmd);
        }
        // Eliminar Shippers
        // Ejecuta un Procedimiento almacenado SQL de tipo "Delete" que actualiza un registro en específico de la tabla Shippers.
        // Espera como parámetro un valor entero que contiene el ID del Shipper a eliminar.
        public static bool EliminarExpendedores( Shipper Expendedores)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "EliminarExpendedores";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ShippersID", Expendedores.ShipperID);
            cmd.Parameters["@ShippersID"].Direction = ParameterDirection.Input;
            return Configuracion.ExecTransactionParameters(cmd);
        }
        /// <summary>
        /// Método InsetarShipperSP
        /// Ejecuta una consulta SQL de tipo "Insert" que inserta un nuevo registro a la tabla de Shipper.
        /// Espera como parámetro una clase que contiene los atributos que son equivalentes a los campos de la tabla Regiones que se desean insertar.
        /// Retorna un valor booleano con el fin de informar el éxito que tuvo la transacción.
        /// </summary>
        /// <param name="productos"></param>
        /// <returns></returns>
        public static bool InsertaShipperSP(Shipper Shipper)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "InsertarShipper";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CompanyName", Shipper.CompanyName);
            cmd.Parameters["@CompanyName"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Phone", Shipper.Phone);
            cmd.Parameters["@Phone"].Direction = ParameterDirection.Input;
            return Configuracion.ExecTransactionParameters(cmd);
        }



    }

}

