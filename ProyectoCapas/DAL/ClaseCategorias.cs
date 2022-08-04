using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;

namespace DAL
{
    public class ClaseCategorias : Configuracion
    {
        public static DataTable ListarCategorias(string strCat)
        {
            string strSQL = "select * from categories";
            strSQL += " where CategoryName like '%" + strCat + "%'";
            return GetDataTable(strSQL);
        }

        public static bool InsertaCategoria(categorias categoria)
        {
            string strSQL = "Insert into categories (CategoryID, CategoryName, Description, Picture) values(";
            strSQL += "'" + categoria.CategoriaID + "',";
            strSQL += "'" + categoria.CategoryName + "',";
            strSQL += "'" + categoria.Description + "', NULL);";          
            return ExecTransaction(strSQL);
        }

        public static bool EliminaCategoria(int CatID)
        {
            string strSQL = "Delete from Categories where CategoryID=" + CatID;
            return ExecTransaction(strSQL);
        }

    }
}
