using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class ClaseProductos
    {
        /// <summary>
        /// Método ListarProductos
        /// Ejecuta una consulta SQL de tipo "Select" que obtiene la data de la base de datos.
        /// Espera como parámetro un string que definirá la consulta en caso de buscar algo en específico.
        /// Retorna la data en formato de DataTable
        /// </summary>
        /// <param name="strProductos"></param>
        /// <returns></returns>
        public static DataTable ListarProductos(string Productos)
        {
            string strSQL = "SELECT P.PRODUCTID as IDProducto, P.PRODUCTNAME as NombreProducto, S.CompanyName as Compañia, C.CATEGORYNAME as Categoria, P.QuantityPerUnit as CantPorUni, P.UnitPrice as PrecioUnit, P.UnitsInStock as UnidadesStock, P.UnitsOnOrder as UniOrden, P.ReorderLevel, P.Discontinued FROM PRODUCTS AS P INNER JOIN SUPPLIERS AS S ON S.SUPPLIERID = P.SUPPLIERID INNER JOIN CATEGORIES AS C ON C.CATEGORYID = P.CATEGORYID " + "where P.ProductName like '%" + Productos + "%' ORDER BY P.PRODUCTID";
            //string strSQL = "select * from Products";
            //strSQL += " where ProductName like '%" + Productos + "%'";
            return Configuracion.GetDataTable(strSQL);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="campos"></param>
        /// <param name="consulta"></param>
        /// <returns></returns>
        public static DataTable ConsultaAbierta(string campos, string consulta)
        {
            string cadena = "select " + campos + " from " + consulta;
            return Configuracion.GetDataTable(cadena);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Region"></param>
        /// <returns></returns>
        public static bool InsertaProductoSP(Productos productos)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "InsertaProductos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ProducName", productos.ProductName);
            cmd.Parameters["@ProducName"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@SupplierID", productos.SupplierID);
            cmd.Parameters["@SupplierID"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@CatID", productos.CategoryID);
            cmd.Parameters["@CatID"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@PerUnit", productos.QuantityPerUnit);
            cmd.Parameters["@PerUnit"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@UnitPrice", productos.UnitPrice);
            cmd.Parameters["@UnitPrice"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@UnitsStock", productos.UnitsInStock);
            cmd.Parameters["@UnitsStock"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@UnitsOrder", productos.UnitsonOrder);
            cmd.Parameters["@UnitsOrder"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@ReorderLevel", productos.RecorderLevel);
            cmd.Parameters["@ReorderLevel"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Discontinued", productos.Discontinued);
            cmd.Parameters["@Discontinued"].Direction = ParameterDirection.Input;
            return Configuracion.ExecTransactionParameters(cmd);
        }



        /// <summary>
        /// Método InsertarProductos
        /// Ejecuta una consulta SQL de tipo "Insert" que inserta un nuevo registro a la tabla de producto.
        /// Espera como parámetro una clase que contiene los atributos que son equivalentes a los campos de la tabla Products que se desean insertar.
        /// Retorna un valor booleano con el fin de informar el éxito que tuvo la transacción.
        /// </summary>
        /// <param name="Products"></param>
        /// <returns></returns>
        public static bool InsertaProducto(Productos producto)
        {
            string strSQL = "Insert into Products (ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued) values(";
            strSQL += " " + producto.ProductID + ",";
            strSQL += "'" + producto.ProductName + "',";
            strSQL += "" + producto.SupplierID + ",";
            strSQL += "" + producto.CategoryID + ",";
            strSQL += "'" + producto.QuantityPerUnit + "',";
            strSQL += "" + producto.UnitPrice + ",";
            strSQL += "" + producto.UnitsInStock + ",";
            strSQL += "" + producto.UnitsonOrder + ",";
            strSQL += "" + producto.RecorderLevel + ",";
            strSQL += "" + producto.Discontinued + ");";
            return Configuracion.ExecTransaction(strSQL);
        }
        /// <summary>
        /// Método EditarProductos
        /// Ejecuta una consulta SQL de tipo "Update" que actualiza un registro en específico de la tabla Productos.
        /// Espera como parámetro una clase que contiene los atributos que son equivalentes a los campos de la tabla Products que se desean actualizar.
        /// Retorna un valor booleano con el fin de informar el éxito que tuvo la transacción.
        /// </summary>
        /// <param name="Productos"></param>
        /// <returns></returns>
        public static bool EditarProducto(Productos Producto)
        {
            string strSQL = "Update Products set ProductName = '" + Producto.ProductName  + "',SupplierID='" +Producto.SupplierID + "',CategoryID='" + Producto.CategoryID + "',QuantityPerUnit='" + Producto.QuantityPerUnit + "',UnitPrice='" + Producto.UnitPrice + "',UnitsInStock='" + Producto.UnitsInStock + "',UnitsOnOrder='" + Producto.UnitsonOrder + "',ReorderLevel='" + Producto.RecorderLevel + "',Discontinued='" + Producto.Discontinued + "' where ProductID = " + Producto.ProductID ;
            return Configuracion.ExecTransaction(strSQL);
        }
        /// <summary>
        /// Método EliminarProductos
        /// Ejecuta una consulta SQL de tipo "Delete" que actualiza un registro en específico de la tabla Products.
        /// Espera como parámetro un valor entero que contiene el ID del Producto a eliminar.
        /// Retorna un valor booleano con el fin de informar el éxito que tuvo la transacción.
        /// </summary>
        /// <param name="Productos"></param>
        /// <returns></returns>
        public static bool EliminaProductos(int ProductID)
        {
            string strSQL = "Delete from Products where ProductID=" + ProductID;
            return Configuracion.ExecTransaction(strSQL);
        }

    }
}
