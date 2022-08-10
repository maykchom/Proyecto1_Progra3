using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
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

        public static bool InsertaCategoriaFoto(categorias categoria)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Insert into categories (CategoryID, CategoryName, Description, Picture) values(@id, @cat, @description, @picture)";
            cmd.Parameters.AddWithValue("@id", categoria.CategoriaID);
            cmd.Parameters.AddWithValue("@cat", categoria.CategoryName);
            cmd.Parameters.AddWithValue("@description", categoria.Description);
            cmd.Parameters.AddWithValue("@picture", categoria.Picture);
            return Configuracion.ExecTransactionParameters(cmd);
        }

        public static bool EditarCategoriaFoto(categorias categoria)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Update categories set CategoryName = @cat, Description = @description, Picture = @picture where CategoryID = @id";
            cmd.Parameters.AddWithValue("@id", categoria.CategoriaID);
            cmd.Parameters.AddWithValue("@cat", categoria.CategoryName);
            cmd.Parameters.AddWithValue("@description", categoria.Description);
            cmd.Parameters.AddWithValue("@picture", categoria.Picture);
            return Configuracion.ExecTransactionParameters(cmd);
        }

        public static bool EliminaCategoria(int CatID)
        {
            string strSQL = "Delete from Categories where CategoryID=" + CatID;
            return ExecTransaction(strSQL);
        }

    }
}
