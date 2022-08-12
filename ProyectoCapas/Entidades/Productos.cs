using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Productos
    {
        /// <summary>
        /// La clase Productos representa a la entidad productos de la base de datos
        /// Los atributos de la clase representan a los campos de la entidad Productos
        /// </summary>
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsonOrder { get; set; }
        public int RecorderLevel { get; set; }
        public int Discontinued { get; set; }
    }
}
