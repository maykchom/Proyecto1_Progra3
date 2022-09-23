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
        /// <summary>
        /// Método InsertarOrden.
        /// Ejecuta el método InsertarOrden de la clase "ClaseOrdenes" en la capa DAL
        /// Espera como parámetro una clase que contendrá como atributos los valores de los campos a insertar.
        /// Retorna un valor booleano con el fin de informar el éxito que tuvo la transacción.
        /// </summary>
        /// <param name="customerID"></param>
        /// <param name="employeedID"></param>
        /// <param name="orderDate"></param>
        /// <param name="requiereDate"></param>
        /// <param name="shippedDate"></param>
        /// <param name="shipvia"></param>
        /// <param name="freight"></param>
        /// <param name="shipName"></param>
        /// <param name="shipAddress"></param>
        /// <param name="shipCity"></param>
        /// <param name="shipRegion"></param>
        /// <param name="shipPosCod"></param>
        /// <param name="shipCountry"></param>
        /// <returns></returns>
        public static OrdenesRespuesta InsertarOrden(string customerID, int employeedID, DateTime orderDate, DateTime requiereDate, DateTime shippedDate,
        int shipvia, double freight, string shipName, string shipAddress, string shipCity, string shipRegion, string shipPosCod, string shipCountry)
        {
            return ClaseOrdenes.InsertaOrdenES(customerID, employeedID, orderDate, requiereDate, shippedDate, shipvia, freight, shipName, shipAddress, shipCity, shipRegion, shipPosCod, shipCountry);
        }
        /// <summary>
        /// Método InsertarOrdenDetails.
        /// Ejecuta el método InsertarOrdenDetails de la clase "ClaseOrdenes" en la capa DAL
        /// Espera como parámetro una clase que contendrá como atributos los valores de los campos a insertar.
        /// Retorna un valor booleano con el fin de informar el éxito que tuvo la transacción.
        /// </summary>
        /// <param name="OrderID"></param>
        /// <param name="ProductID"></param>
        /// <param name="UnitPrice"></param>
        /// <param name="Quantity"></param>
        /// <param name="Discount"></param>
        /// <returns></returns>
        public static bool InsertarOrdenDetails(int OrderID, int ProductID, decimal UnitPrice, int Quantity, double Discount)
        {
            return ClaseOrdenes.InsertaOrdenDetails(OrderID, ProductID, UnitPrice, Quantity, Discount);
        }
    }
}
