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

        public static bool InsertarProducto(Productos producto)
        {
            return ClaseProductos.InsertaProducto(producto);
        }

       // public static bool InsertarCategoriasFot(Productos producto)
        //{
         //   return ClaseCategorias.InsertaCategoriaFoto(Pr);
        //}

        public static bool EliminaProductos(int ProductID)
        {
            return ClaseProductos.EliminaProductos(ProductID);
        }
        public static bool EditarProducto(Entidades.Productos Producto)
        {
            return ClaseProductos.EditarProducto(Producto);
        }
    }

}

