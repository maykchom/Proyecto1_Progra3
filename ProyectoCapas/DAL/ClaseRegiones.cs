using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Entidades;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class ClaseRegiones : Configuracion
    {
        public static DataTable ListarRegiones(string strRegion)
        {
            string strSQL = "select * from region";
            strSQL += " where RegionDescription like '%" + strRegion + "%'";
            return GetDataTable(strSQL);
        }

        public static bool InsertaRegion(Regiones Region)
        {
            string strSQL = "Insert into region (RegionID,RegionDescription) values(";
            strSQL += "'" + Region.RegionID + "',";
            strSQL += "'" + Region.RegionDescripcion + "');";
            return ExecTransaction(strSQL);
        }

        public static bool InsertaRegionSP(Regiones Region)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "InsertarRegion";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Region", Region.RegionID);
            cmd.Parameters["@Region"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@RegionDescripcion", Region.RegionDescripcion);
            cmd.Parameters["@RegionDescripcion"].Direction = ParameterDirection.Input;
            return ExecTransactionParameters(cmd);
        }

        public static bool EditarRegion(Regiones Region)
        {
            string strSQL = "Update region set regiondescription = '" + Region.RegionDescripcion + "' where regionid = " + Region.RegionID;
            return ExecTransaction(strSQL);
        }

        public static bool EliminaRegion(int RegionID)
        {
            string strSQL = "Delete from region where RegionID="+ RegionID;
            return ExecTransaction(strSQL);
        }


    }
}
