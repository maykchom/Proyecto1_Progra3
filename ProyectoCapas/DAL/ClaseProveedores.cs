using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;

namespace DAL
{
    public class ClaseProveedores : Configuracion
    {
        public static DataTable ListarProveedores(string strProveedor)
        {
            string strSQL = "select * from Suppliers";
            strSQL += " where CompanyName like '%" + strProveedor + "%'";
            return GetDataTable(strSQL);
        }

        public static bool InsertaProveedores(Proveedores Proveedor)
        {
            string strSQL = "Insert into Suppliers (SupplierID,CompanyName,ContactTitle,Address,City,Region ) values(";
            strSQL += "'" + Region.RegionID + "',";
            strSQL += "'" + Region.RegionDescripcion + "');";
            return ExecTransaction(strSQL);
        }
    }
}
