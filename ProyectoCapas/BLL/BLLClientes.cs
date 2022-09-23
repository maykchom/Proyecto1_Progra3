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
    /// <summary>
    /// Método ListarClientes.
    /// Ejecuta el método ListarShipper de la clase "ClaseClientes" en la capa DAL
    /// Espera como parámetro un string que contendrá el valor de la consulta a buscar.
    /// La data que devolverá será en formato DataTable
    /// </summary>
    /// <param name="strCliente"></param>
    /// <returns></returns>
    public class BLLClientes
    {
        public static DataTable ListarClientes(string strClientes)
        {
            return ClaseClientes.ListarClientes(strClientes);
        }
        public static bool InsertaClientes(Clientes Cliente)
        {
            return ClaseClientes.InsertarClientes(Cliente);
        }
        /// <summary>
        /// Método EliminaClientes.
        /// Ejecuta el método EliminaClientes de la clase "ClaseClientes" en la capa DAL
        /// Espera como parámetro un valor entero que tendrá el Id del cliente a eliminar.
        /// Retorna un valor booleano con el fin de informar el éxito que tuvo la transacción.
        /// </summary>
        /// <param name="ClienteID"></param>
        /// <returns></returns>
        public static bool EliminaClientes(string ClienteID)
        {
            return ClaseClientes.EliminarCustomer(ClienteID);
        }
        /// <summary>
        /// Ejecuta el método EditarCliente de la clase "ClaseClientes" en la capa DAL
        /// Espera como parámetro una clase que contendrá como atributos los valores de los campos a editar.
        /// Retorna un valor booleano con el fin de informar el éxito que tuvo la transacción.
        /// </summary>
        /// <param name="Cliente"></param>
        /// <returns></returns>
        public static bool EditarClientes(Clientes Cliente)
        {
            return ClaseClientes.EditarCliente(Cliente);
        }

    }
}