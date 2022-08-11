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
    public  class BLLProveedores
    {
        public static DataTable ListarProveedores(string strProveedores)
        {
            return ClaseProveedores.ListarProveedores(strProveedores);
        }

        public static bool InsertarProveedores(Proveedores Proveedor)
        {
            return ClaseProveedores.InsertaProveedores(Proveedor);
        }

        public static bool EliminaProveedores(int ProveedorID)
        {
            return ClaseProveedores.EliminaProveedor(ProveedorID);
        }

        public static bool EditarProveedores(Proveedores Proveedor)
        {
            return ClaseProveedores.EditarProveedor(Proveedor);
        }
    }
}
