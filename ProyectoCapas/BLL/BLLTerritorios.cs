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
        /// <summary>
        /// Método ListarTerritorios.
        /// Ejecuta el método ListarTerritorios de la clase "ClaseTerritorios" en la capa DAL
        /// Espera como parámetro un string que contendrá el valor de la consulta a buscar.
        /// La data que devolverá será en formato DataTable
        /// </summary>
        /// <param name="strTerritorios"></param>
        /// <returns></returns>
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

        public static bool EliminaTerritorios(Territorios Territorio)
        {
            return ClaseTerritorios.EliminaTerritorio(Territorio);
        }

        // METODO EDITAR TERRITORIOS
        /// Ejecuta el método EditarTERRITORIOS de la clase "ClaseTERRITORIOS" en la capa DAL.
        public static bool EditarTerritorios(Territorios Territorio)
        {
            return ClaseTerritorios.EditarTerritorio(Territorio);
        }
        /// <summary>
        /// Método ListarTerritorios.
        /// Ejecuta el método ListarTerritorios de la clase "ClaseTerritorios" en la capa DAL
        /// Espera como parámetro un string que contendrá el valor de la consulta a buscar.
        /// La data que devolverá será en formato DataTable
        /// </summary>
        /// <param name="Territorios"></param>
        /// <returns></returns>
        public static bool InsertarTerritoriosSP(Territorios Territorios)
        {
            return ClaseTerritorios.InsertaTerritorios(Territorios);
        }
    }
}
