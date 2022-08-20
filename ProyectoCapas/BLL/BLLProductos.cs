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
    /// Método ListarProductos.
    /// Ejecuta el método ListarProductos de la clase "ClaseProductos" en la capa DAL
    /// Espera como parámetro un string que contendrá el valor de la consulta a buscar.
    /// La data que devolverá será en formato DataTable
    /// </summary>
    /// <param name="strProductos"></param>
    /// <returns></returns>
    public class BLLProductos
    {
        public static DataTable ListarProductos(string strCatt)
        {
            return ClaseProductos.ListarProductos(strCatt);
        }

        public static DataTable ConsultaAbierta(string campos, string consulta)
        {
            return ClaseProductos.ConsultaAbierta(campos, consulta);
        }
        /// <summary>
        /// Método InsertarProductos.
        /// Ejecuta el método InsertarProductos de la clase "ClaseProductos" en la capa DAL
        /// Espera como parámetro una clase que contendrá como atributos los valores de los campos a insertar.
        /// Retorna un valor booleano con el fin de informar el éxito que tuvo la transacción.
        /// </summary>
        /// <param name="Product"></param>
        /// <returns></returns>
        public static bool InsertarProducto(Productos producto)
        {
            return ClaseProductos.InsertaProducto(producto);
        }
        /// <summary>
        /// Método EliminaProductos.
        /// Ejecuta el método EliminaProductos de la clase "ClaseProductos" en la capa DAL
        /// Espera como parámetro un valor entero que tendrá el Id del Producto a eliminar.
        /// Retorna un valor booleano con el fin de informar el éxito que tuvo la transacción.
        /// </summary>
        /// <param name="ProductID"></param>
        /// <returns></returns>

        public static bool EliminaProductos(int ProductID)
        {
            return ClaseProductos.EliminaProductos(ProductID);
        }
        /// <summary>
        /// Método EditarProductos.
        /// Ejecuta el método EditarProductos de la clase "ClaseProductos" en la capa DAL
        /// Espera como parámetro una clase que contendrá como atributos los valores de los campos a editar.
        /// Retorna un valor booleano con el fin de informar el éxito que tuvo la transacción.
        /// </summary>
        /// <param name="Productos"></param>
        /// <returns></returns>
        public static bool EditarProducto(Entidades.Productos Producto)
        {
            return ClaseProductos.EditarProducto(Producto);
        }

        public static bool InsertarProductosSP(Productos productos)
        {
            return ClaseProductos.InsertaProductoSP(productos);
        }
    }

}

