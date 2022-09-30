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
    public class BLLvistaOrdenes
    {
        /// <summary>
        /// Método ListarOrdenes.
        /// Ejecuta el método ListarOrdenes de la clase "ClaseOrdenes" en la capa DAL
        /// Espera como parámetro un string que contendrá el valor de la consulta a buscar.
        /// La data que devolverá será en formato DataTable
        /// </summary>
        /// <param name="strShipper"></param>
        /// <returns></returns>
        public static DataTable ListarOrdenes(string strShipper)
        {
            return ClaseVistaOrdenes.ListarOrdenes(strShipper);
        }
        /// <summary>
        /// Método ListarOrden.
        /// Ejecuta el método ListarOrden de la clase "ClaseOrdenes" en la capa DAL
        /// Espera como parámetro un string que contendrá el valor de la consulta a buscar.
        /// La data que devolverá será en formato DataTable
        /// </summary>
        /// <param name="NoFactura"></param>
        /// <returns></returns>
        public static DataTable ListarOrden(string NoFactura)
        {
            return ClaseVistaOrdenes.ListarOrden(NoFactura);
        }
        /// <summary>
        /// Método ListarOrdenesDetalles.
        /// Ejecuta el método ListarOrdenesDetalles de la clase "ClaseOrdenes" en la capa DAL
        /// Espera como parámetro un string que contendrá el valor de la consulta a buscar.
        /// La data que devolverá será en formato DataTable
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>

        public static DataTable ListarOrdenesDetalles(int order)
        {
            return ClaseVistaOrdenes.ListarOrdenesDetalles(order);
        }

        public static DataTable obtenerTotal(int order)
        {
            return ClaseVistaOrdenes.obtenerTotal(order);
        }
    }
}
