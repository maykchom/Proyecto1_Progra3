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
            string strSQL = "select * from Productos";
            strSQL += " where ProductName like '%" + Productos + "%'";
            return Configuracion.GetDataTable(strSQL);
        }
        public static bool InsertaProducto(Productos producto)
        {
            string strSQL = "Insert into region (ProductID, ProductName, SupplierID, CategoryID, QuatityPerUnit, UnitPrice, UnitInStock, UnitsOnOrder, RecorderLevel, Discontinued) values(";
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
            string strSQL = "Update ProductID set ProductName = '" + Producto.ProductName + "' where ProductID = " + Producto.ProductID;
            return Configuracion.ExecTransaction(strSQL);
        }
        public static bool EliminaProductos(int ProductID)
        {
            string strSQL = "Delete from Productos where ProductsID=" + ProductID;
            return Configuracion.ExecTransaction(strSQL);
        }

    }
}
