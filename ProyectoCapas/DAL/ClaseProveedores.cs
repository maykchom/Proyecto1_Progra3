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
            string strSQL = "Insert into Suppliers (SupplierID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax,HomePage ) values(";
            strSQL += "'" + Proveedor.SupplierID + "',";
            strSQL += "'" + Proveedor.CompanyName + "');";
            strSQL += "'" + Proveedor.ContactName + "');";
            strSQL += "'" + Proveedor. ContactTitle + "');";
            strSQL += "'" + Proveedor.Address + "');";
            strSQL += "'" + Proveedor.City + "');";
            strSQL += "'" + Proveedor.Region + "');";
            strSQL += "'" + Proveedor.PostalCode + "');";
            strSQL += "'" + Proveedor.Country + "');";
            strSQL += "'" + Proveedor.Phone + "');";
            strSQL += "'" + Proveedor.Fax + "');";
            strSQL += "'" + Proveedor.HomePage + "');";
            return ExecTransaction(strSQL);
        }

        public static bool EliminaProveedor(int ProveedorID )
        {
            string strSQL = "Delete from Supplier where SupplierID="+ ProveedorID;
            return ExecTransaction(strSQL);
        }

        public static bool EditarProveedor(Proveedores Proveedor)
        {
            string strSQL = "Update  set CompanyName = '" + Proveedor.CompanyName + "' where SupplierID = " + Proveedor.SupplierID;
            return ExecTransaction(strSQL);
        }

    }
}
