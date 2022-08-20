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
    public class BLLRegiones
    {
        public static DataTable ListarRegiones(string strRegiones)
        {
            return ClaseRegiones.ListarRegiones(strRegiones);
        }

        public static bool InsertarRegiones(Regiones Region)
        {
            return ClaseRegiones.InsertaRegion(Region);
        }

        public static bool EliminaRegiones(int RegionID)
        {
            return ClaseRegiones.EliminaRegion(RegionID);
        }

        public static bool EditarRegiones(Regiones Region)
        {
            return ClaseRegiones.EditarRegion(Region);
        }

        public static bool InsertarRegionesSP(Regiones Region)
        {
            return ClaseRegiones.InsertaRegionesSP(Region);
        }
    }
}
