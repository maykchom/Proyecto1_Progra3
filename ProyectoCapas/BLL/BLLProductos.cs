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

        public static bool EliminarProductos(int ProductID)
        {
            return ClaseProductos.EliminaProductos(ProductID);
        }
        public static bool EditarProducto(Entidades.Productos Producto)
        {
            return ClaseProductos.EditarProducto(Producto);
        }
    }

}

