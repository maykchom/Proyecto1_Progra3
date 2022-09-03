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

        public static bool EliminaTerritorio(Territorios Territorios)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "EliminarTerritorios";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TerritoriesID", Territorios.TerritoryID);
            cmd.Parameters["@TerritoriesID"].Direction = ParameterDirection.Input;
            return Configuracion.ExecTransactionParameters(cmd);
        }

        // Editar Territorios
        // Ejecuta una consulta SQL de tipo "Delete" que actualiza un registro en específico de la tabla Territorios.
        public static bool EditarTerritorio(Territorios territorio)
        {
            
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "ActualizarTerritories";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("TerritoryID", territorio.TerritoryID);
            cmd.Parameters["@TerritoryID"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@TerritoryDescription", territorio.TerritoryDescription);
            cmd.Parameters["@TerritoryDescription"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@RegionID", territorio.RegionID);
            cmd.Parameters["@RegionID"].Direction = ParameterDirection.Input;
            return Configuracion.ExecTransactionParameters(cmd);
        }
    }
}
