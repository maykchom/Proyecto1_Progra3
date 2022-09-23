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
    
        public class BLLShipper
        {
        /// <summary>
        /// Método ListarShipper.
        /// Ejecuta el método ListarShipper de la clase "ClaseShipper" en la capa DAL
        /// Espera como parámetro un string que contendrá el valor de la consulta a buscar.
        /// La data que devolverá será en formato DataTable
        /// </summary>
        /// <param name="strShipper"></param>
        /// <returns></returns>
        public static DataTable ListarShipper(string strShipper)
            {
                return ClaseShipper.ListarShipper(strShipper);
            }
        /// <summary>
        /// Método EdirarShipper.
        /// Ejecuta el método InsertarShipper de la clase "ClaseShipper" en la capa DAL
        /// Espera como parámetro una clase que contendrá como atributos los valores de los campos a insertar.
        /// Retorna un valor booleano con el fin de informar el éxito que tuvo la transacción.
        /// </summary>
        /// <param name="Shipper"></param>
        /// <returns></returns>
       
        public static bool EditarShipper(Shipper Shipper)
            {
                return ClaseShipper.EditarShipper(Shipper);
            }
        /// <summary>
        /// Método InsertarShipper.
        /// Ejecuta el método InsertarShipper de la clase "ClaseShipper" en la capa DAL
        /// Espera como parámetro una clase que contendrá como atributos los valores de los campos a insertar.
        /// Retorna un valor booleano con el fin de informar el éxito que tuvo la transacción.
        /// </summary>
        /// <param name="Shipper"></param>
        /// <returns></returns>
        public static bool InsertarShipperSP(Shipper Shipper)
            {
                return ClaseShipper.InsertaShipperSP(Shipper);
            }
        /// <summary>
        /// Método EliminaShipper.
        /// Ejecuta el método EliminaProductos de la clase "ClaseShipper" en la capa DAL
        /// Espera como parámetro un valor entero que tendrá el Id del Producto a eliminar.
        /// Retorna un valor booleano con el fin de informar el éxito que tuvo la transacción.
        /// </summary>
        /// <param name="ProductID"></param>
        /// <returns></returns>
        public static bool EliminarExpendedores( Shipper Expendedores)
        {
            return ClaseShipper.EliminarExpendedores(   Expendedores);
        }
    }

    }

