using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using Entidades;

namespace BLL
{
    public class BLLTerritorios
    {
        public static DataTable ListarTerritorios(string strTerritorios)
        {
            return ClaseTerritorios.ListarTerritorios(strTerritorios);
        }

        // METODO INSERTAR TERRITORIOS.
        /// Ejecuta el método InsertarTerritorios de la clase "ClaseTerritorios" en la capa DAL.
        public static bool InsertarTerritorios(Territorios territorio)
        {
            return ClaseTerritorios.InsertaTerritorios(territorio);
        }

        // METODO ELIMINAR TERRITORIOS.
        // Ejecuta el método EliminaTERRITORIOS. de la clase "ClaseTERRITORIOS." en la capa DAL.
        public static bool EliminaTerritorios(int TerritorioID)
        {
            return ClaseTerritorios.EliminaTerritorio(TerritorioID);
        }

        // METODO EDITAR TERRITORIOS
        /// Ejecuta el método EditarTERRITORIOS de la clase "ClaseTERRITORIOS" en la capa DAL.
        public static bool EditarTerritorios(Territorios Territorio)
        {
            return ClaseTerritorios.EditarTerritorio(Territorio);
        }

        public static bool InsertarTerritoriosSP(Territorios Territorios)
        {
            return ClaseTerritorios.InsertaTerritorios(Territorios);
        }
    }
}
