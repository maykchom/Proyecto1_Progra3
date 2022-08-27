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
    public class ClaseTerritorios : Configuracion
    {
        public static DataTable ListarTerritorios(string strTerritorio)
        {
            string strSQL = "select * from Territories";
            strSQL += " where TerritoryDescription like '%" + strTerritorio + "%'";
            return GetDataTable(strSQL);
        }

        public static bool InsertaTerritorios(Territorios Territorio)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "InsertaTerritorios";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DescriTerritorio", Territorio.TerritoryDescription);
            cmd.Parameters["@DescriTerritorio"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@RegionID", Territorio.RegionID);
            cmd.Parameters["@RegionID"].Direction = ParameterDirection.Input;
            return Configuracion.ExecTransactionParameters(cmd);
        }

        public static bool EliminaTerritorio(int TerritoryID)
        {
            string strSQL = "Delete from Territories where TerritoryID=" + TerritoryID;
            return ExecTransaction(strSQL);
        }

        // Editar Territorios
        // Ejecuta una consulta SQL de tipo "Delete" que actualiza un registro en específico de la tabla Territorios.
        public static bool EditarTerritorio(Territorios territorio)
        {
            string strSQL = "Update Territories  set TerritoryDescription = '" + territorio.TerritoryDescription + "',RegionID='" + territorio.RegionID + "'where TerritoryID = '" + territorio.TerritoryID + "'";
            return ExecTransaction(strSQL);
        }
    }
}
