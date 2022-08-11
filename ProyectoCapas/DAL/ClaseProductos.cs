using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;

namespace DAL
{
    public class ClaseProductos
    {
        public static DataTable ListarProductos(string Productos)
        {
            string strSQL = "select * from Products";
            strSQL += " where ProductName like '%" + Productos + "%'";
            return Configuracion.GetDataTable(strSQL);
        }
        public static bool InsertaProducto(Productos producto)
        {
            string strSQL = "Insert into Products (ProductID, ProductName, SupplierID, CategoryID, QuatityPerUnit, UnitPrice, UnitInStock, UnitsOnOrder, RecorderLevel, Discontinued) values(";
            strSQL += "'" + producto.ProductID + "',";
            strSQL += "'" + producto.ProductName + "',";
            strSQL += "'" + producto.SupplierID + "',";
            strSQL += "'" + producto.CategoryID + "',";
            strSQL += "'" + producto.QuantityPerUnit + "',";
            strSQL += "'" + producto.UnitPrice + "',";
            strSQL += "'" + producto.UnitsInStock + "',";
            strSQL += "'" + producto.UnitsonOrder + "',";
            strSQL += "'" + producto.RecorderLevel + "',";
            strSQL += "'" + producto.Discontinued + "');";
            return Configuracion.ExecTransaction(strSQL);
        }
        public static bool EditarProducto(Productos Producto)
        {
            string strSQL = "Update Product set ProductName = '" + Producto.ProductName  + "',SupplierID='" +Producto.SupplierID + "',CategoryID='" + Producto.CategoryID + "',QuantityPerUnit='" + Producto.QuantityPerUnit + "',UnitPrice='" + Producto.UnitPrice + "',UnitsInStock='" + Producto.UnitsInStock + "',UnitsOnOrder='" + Producto.UnitsonOrder + "',RecorderLevel='" + Producto.RecorderLevel + "',Discontinued='" + Producto.Discontinued + "' where ProductID = " + Producto.ProductID ;
            return Configuracion.ExecTransaction(strSQL);
        }
        public static bool EliminaProductos(int ProductID)
        {
            string strSQL = "Delete from Products where ProductsID=" + ProductID;
            return Configuracion.ExecTransaction(strSQL);
        }

    }
}
