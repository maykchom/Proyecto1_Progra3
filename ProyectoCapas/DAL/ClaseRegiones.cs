using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Entidades;

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

        public static bool EliminaRegion(int RegionID)
        {
            string strSQL = "Delete from region where RegionID="+ RegionID;
            return ExecTransaction(strSQL);
        }


    }
}
