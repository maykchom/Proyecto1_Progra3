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
    // METODO LISTAR PROVEEDORES.
    // Espera como parámetro un string que contendrá el valor de la consulta a buscar.
    // La data que devolverá será en formato DataTable
    public class BLLProveedores
    {
        public static DataTable ListarProveedores(string strProveedores)
        {
            return ClaseProveedores.ListarProveedores(strProveedores);
        }

        // METODO INSERTAR PROVEEDORES.
        /// Ejecuta el método InsertarProductos de la clase "ClaseProductos" en la capa DAL.
        public static bool InsertarProveedores(Proveedores Proveedor)
        {
            return ClaseProveedores.InsertaProveedores(Proveedor);
        }

        // METODO ELIMINAR PROVEEDORES
        // Ejecuta el método EliminaProductos de la clase "ClaseProductos" en la capa DAL.
        public static bool EliminaProveedores(int ProveedorID)
        {
            return ClaseProveedores.EliminaProveedor(ProveedorID);
        }

        // METODO EDITAR PROVEEDORES
        /// Ejecuta el método EditarProductos de la clase "ClaseProductos" en la capa DAL.
        public static bool EditarProveedores(Proveedores Proveedor)
        {
            return ClaseProveedores.EditarProveedor(Proveedor);
        }
    }
}
