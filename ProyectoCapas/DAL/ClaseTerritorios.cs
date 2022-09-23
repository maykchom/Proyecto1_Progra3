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
        /// <summary>
        /// Método ListarTerritorios
        /// Ejecuta una consulta SQL de tipo "Select" que obtiene la data de la base de datos.
        /// Espera como parámetro un string que definirá la consulta en caso de buscar algo en específico.
        /// Retorna la data en formato de DataTable
        /// </summary>
        /// <param name="strTerritorio"></param>
        /// <returns></returns>
        public static DataTable ListarTerritorios(string strTerritorio)
        {
            string strSQL = "select * from Territories";
            strSQL += " where TerritoryDescription like '%" + strTerritorio + "%'";
            return GetDataTable(strSQL);
        }
        /// <summary>
        /// Método InsetarTerritorios
        /// Ejecuta una consulta SQL de tipo "Insert" que inserta un nuevo registro a la tabla de territorios.
        /// Espera como parámetro una clase que contiene los atributos que son equivalentes a los campos de la tabla territorios que se desean insertar.
        /// Retorna un valor booleano con el fin de informar el éxito que tuvo la transacción.
        /// </summary>
        /// <param name="Territorio"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Método EliminarTerritorios
        /// Ejecuta una consulta SQL de tipo "Delete" que inserta un nuevo registro a la tabla de territorios.
        /// Espera como parámetro una clase que contiene los atributos que son equivalentes a los campos de la tabla territorios que se desean insertar.
        /// Retorna un valor booleano con el fin de informar el éxito que tuvo la transacción.
        /// </summary>
        /// <param name="Territorios"></param>
        /// <returns></returns>
        public static bool EliminaTerritorio(Territorios Territorios)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "EliminarTerritorios";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TerritoriesID", Territorios.TerritoryID);
            cmd.Parameters["@TerritoriesID"].Direction = ParameterDirection.Input;
            return Configuracion.ExecTransactionParameters(cmd);
        }

        /// <summary>
        /// Método EditarTerritorios
        /// Ejecuta una consulta SQL de tipo "Update" que inserta un nuevo registro a la tabla de territorios.
        /// Espera como parámetro una clase que contiene los atributos que son equivalentes a los campos de la tabla territorios que se desean insertar.
        /// Retorna un valor booleano con el fin de informar el éxito que tuvo la transacción.
        /// </summary>
        /// <param name="territorio"></param>
        /// <returns></returns>
        public static bool EditarTerritorio(Territorios territorio)
        {
            
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "ActualizarTerritories";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IDTerritory", territorio.TerritoryID);
            cmd.Parameters["@IDTerritory"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@TerritoryDes", territorio.TerritoryDescription);
            cmd.Parameters["@TerritoryDes"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@IDRegion", territorio.RegionID);
            cmd.Parameters["@IDRegion"].Direction = ParameterDirection.Input;
            return Configuracion.ExecTransactionParameters(cmd);
        }
    }
}
