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
    public class BLLOrdenes
    {

        public static DataTable ConsultaAbierta(string consulta)
        {
            return ClaseOrdenes.ConsultaAbierta(consulta);
        }

        public static OrdenesRespuesta InsertarOrden(string customerID, int employeedID, DateTime orderDate, DateTime requiereDate, DateTime shippedDate,
        int shipvia, double freight, string shipName, string shipAddress, string shipCity, string shipRegion, string shipPosCod, string shipCountry)
        {
            return ClaseOrdenes.InsertaOrdenES(customerID, employeedID, orderDate, requiereDate, shippedDate, shipvia, freight, shipName, shipAddress, shipCity, shipRegion, shipPosCod, shipCountry);
        }

        public static bool InsertarOrdenDetails(int OrderID, int ProductID, decimal UnitPrice, int Quantity, double Discount)
        {
            return ClaseOrdenes.InsertaOrdenDetails(OrderID, ProductID, UnitPrice, Quantity, Discount);
        }
    }
}
