using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class ClaseVistaOrdenes
    {
        /// <summary>
        /// Método ListarOrdenes
        /// Ejecuta una consulta SQL de tipo "Select" que obtiene la data de la base de datos.
        /// Espera como parámetro un string que definirá la consulta en caso de buscar algo en específico.
        /// Retorna la data en formato de DataTable
        /// </summary>
        /// <param name="strShipper"></param>
        /// <returns></returns>
        public static DataTable ListarOrdenes(string strShipper)
        {
            string strSQL = "select * from vistaOrdenes";
            strSQL += " where NombreCompania like '%" + strShipper + "%' order by OrdenID";
            return Configuracion.GetDataTable(strSQL);
        }
        /// <summary>
        /// Método ListarOrdenes
        /// Ejecuta una consulta SQL de tipo "Select" que obtiene la data de la base de datos.
        /// Espera como parámetro un string que definirá la consulta en caso de buscar algo en específico.
        /// Retorna la data en formato de DataTable
        /// </summary>
        /// <param name="NoFactura"></param>
        /// <returns></returns>
        public static DataTable ListarOrden(string NoFactura)
        {
            string strSQL = "select * from vistaOrdenes";
            strSQL += " where OrdenID = " + NoFactura;
            return Configuracion.GetDataTable(strSQL);
        }
        /// <summary>
        /// Método ListarOrdenesDetalles
        /// Ejecuta una consulta SQL de tipo "Select" que obtiene la data de la base de datos.
        /// Espera como parámetro un string que definirá la consulta en caso de buscar algo en específico.
        /// Retorna la data en formato de DataTable
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public static DataTable ListarOrdenesDetalles(int order)
        {
            //string strSQL = "select * from `order details`";
            string strSQL = "select * from v_od";
            strSQL += " where OrderID = "+ order;
            return Configuracion.GetDataTable(strSQL);
        }

        public static DataTable obtenerTotal(int order)
        {
            string strSQL = "select sum(UnitPrice * Quantity) Total from `order details` od where OrderID = "+order;
            return Configuracion.GetDataTable(strSQL);
        }
    }
}
