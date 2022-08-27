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
        public static DataTable ListarShipper(string strShipper)
        {
            string strSQL = "select * from shippers";
            strSQL += " where CompanyName like '%" + strShipper + "%'";
            return Configuracion.GetDataTable(strSQL);
        }



        public static bool EditarShipper(Shipper Shipper)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "ActualizarShipper";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("ShipperAID", Shipper.ShipperID);
            cmd.Parameters["@ShipperAID"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@CompanyName", Shipper.CompanyName);
            cmd.Parameters["@CompanyName"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Phone", Shipper.Phone);
            cmd.Parameters["@Phone"].Direction = ParameterDirection.Input;
            return Configuracion.ExecTransactionParameters(cmd);
        }

        public static bool EliminaShipper(int ShipperID)
        {
            string strSQL = "Delete from Shipper where ShipperID=" + ShipperID;
            return Configuracion.ExecTransaction(strSQL);
        }

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

