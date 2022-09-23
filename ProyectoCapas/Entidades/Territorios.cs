using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Territorios
    {
        /// <summary>
        ///  La clase Territorios representa a la entidad de Territorios de la base de datos
        ///  Los atributos de la clase representan a los campos de la entidad Territorios
        /// </summary>
        public int TerritoryID { get; set; }
        public string TerritoryDescription { get; set; }
        public int RegionID { get; set; }
       
    }
}
