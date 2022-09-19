using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ordenes
    {
        /// <summary>
        /// La clase ordenes representa a la entidad Orders de la base de datos
        /// Los atributos de la clase representan a los campos de la entidad orders
        /// </summary>
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int EmployeedID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequieredDate { get; set; }
        public DateTime Shippeddate { get; set; }
        public int ShipVia { get; set; }
        public decimal Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
    }

    public class OrdenesRespuesta
    {
        public bool respuesta { get; set; }
        public int ID { get; set; }
    }

}
