using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Entidades;

namespace DAL
{
    public class ClaseOrdenes : Configuracion
    {

        public static DataTable ConsultaAbierta(string consulta)
        {
            string cadena = consulta;
            return Configuracion.GetDataTable(cadena);
        }
        /// <summary>
        /// Método InsertaOrdenES
        /// Ejecuta una consulta SQL de tipo "Insert" que inserta un nuevo registro a la tabla de Ordenes.
        /// Espera como parámetro una clase que contiene los atributos que son equivalentes a los campos de la tabla ordenes que se desean insertar.
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
        public static OrdenesRespuesta InsertaOrdenES(string customerID, int employeedID, DateTime orderDate, DateTime requiereDate, DateTime shippedDate, 
            int shipvia, double freight, string shipName, string shipAddress, string shipCity, string shipRegion, string shipPosCod, string shipCountry)
        {
            OrdenesRespuesta or = new OrdenesRespuesta();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "InsertaOrder";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ClienteID", customerID);
            cmd.Parameters["@ClienteID"].Direction = ParameterDirection.Input;

            cmd.Parameters.AddWithValue("@EmployID", employeedID);
            cmd.Parameters["@EmployID"].Direction = ParameterDirection.Input;

            cmd.Parameters.AddWithValue("@OrderDatee", orderDate);
            cmd.Parameters["@OrderDatee"].Direction = ParameterDirection.Input;

            cmd.Parameters.AddWithValue("@RequiredDatee", requiereDate);
            cmd.Parameters["@RequiredDatee"].Direction = ParameterDirection.Input;

            cmd.Parameters.AddWithValue("@ShippedDatee", shippedDate);
            cmd.Parameters["@ShippedDatee"].Direction = ParameterDirection.Input;

            cmd.Parameters.AddWithValue("@ShipViaa", shipvia);
            cmd.Parameters["@ShipViaa"].Direction = ParameterDirection.Input;

            cmd.Parameters.AddWithValue("@Freightt", freight);
            cmd.Parameters["@Freightt"].Direction = ParameterDirection.Input;

            cmd.Parameters.AddWithValue("@ShipNamee", shipName);
            cmd.Parameters["@ShipNamee"].Direction = ParameterDirection.Input;

            cmd.Parameters.AddWithValue("@ShipAddresss", shipAddress);
            cmd.Parameters["@ShipAddresss"].Direction = ParameterDirection.Input;

            cmd.Parameters.AddWithValue("@ShipCityy", shipCity);
            cmd.Parameters["@ShipCityy"].Direction = ParameterDirection.Input;

            cmd.Parameters.AddWithValue("@ShipRegionn", shipRegion);
            cmd.Parameters["@ShipRegionn"].Direction = ParameterDirection.Input;

            cmd.Parameters.AddWithValue("@ShipPostalCodee", shipPosCod);
            cmd.Parameters["@ShipPostalCodee"].Direction = ParameterDirection.Input;

            cmd.Parameters.AddWithValue("@ShipCountryy", shipCountry);
            cmd.Parameters["@ShipCountryy"].Direction = ParameterDirection.Input;

            cmd.Parameters.Add(new MySqlParameter("@IDOrder", MySqlDbType.Int32));
            cmd.Parameters["@IDOrder"].Direction = ParameterDirection.Output;
            or.respuesta = ExecTransactionParameters(cmd);
            var result = cmd.Parameters["@IDOrder"].Value;
            or.ID = (int)result;
            return or;            
        }
        /// <summary>
        /// Método InsertaOrdenDetails
        /// Ejecuta una consulta SQL de tipo "Insert" que inserta un nuevo registro a la tabla de Ordenes.
        /// Espera como parámetro una clase que contiene los atributos que son equivalentes a los campos de la tabla ordenes que se desean insertar.
        /// Retorna un valor booleano con el fin de informar el éxito que tuvo la transacción.
        /// </summary>
        /// <param name="OrderID"></param>
        /// <param name="ProductID"></param>
        /// <param name="UnitPrice"></param>
        /// <param name="Quantity"></param>
        /// <param name="Discount"></param>
        /// <returns></returns>
        public static bool InsertaOrdenDetails(int OrderID, int ProductID, decimal UnitPrice, int Quantity, double Discount)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "insertaOrderDetails";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@OrderIDD", OrderID);
            cmd.Parameters["@OrderIDD"].Direction = ParameterDirection.Input;

            cmd.Parameters.AddWithValue("@ProductIDD", ProductID);
            cmd.Parameters["@ProductIDD"].Direction = ParameterDirection.Input;

            cmd.Parameters.AddWithValue("@UnitPricee", UnitPrice);
            cmd.Parameters["@UnitPricee"].Direction = ParameterDirection.Input;

            cmd.Parameters.AddWithValue("@Quantityy", Quantity);
            cmd.Parameters["@Quantityy"].Direction = ParameterDirection.Input;

            cmd.Parameters.AddWithValue("@Discountt", Discount);
            cmd.Parameters["@Discountt"].Direction = ParameterDirection.Input;

            return Configuracion.ExecTransactionParameters(cmd);
        }
    }
}
