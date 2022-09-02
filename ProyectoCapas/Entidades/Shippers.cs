using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Shipper
    {
  
            /// <summary>
            ///  representa a la entidad de Shippers de la base de datos
            ///  Los atributos de la clase representan a los campos de la entidad Shippers
            /// </summary>
            public int ShipperID { get; set; }
            public string CompanyName { get; set; }
            public string Phone { get; set; }
            
        }
    }

