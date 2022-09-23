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
        /// <summary>
        /// Método ListarCategorias
        /// Ejecuta una consulta SQL de tipo "Select" que obtiene la data de la base de datos.
        /// Espera como parámetro un string que definirá la consulta en caso de buscar algo en específico.
        /// Retorna la data en formato de DataTable
        /// </summary>
        /// <param name="strCat"></param>
        /// <returns></returns>
        public static DataTable ListarCategorias(string strCat)
        {
            string strSQL = "select * from categories";
            strSQL += " where CategoryName like '%" + strCat + "%'";
            return GetDataTable(strSQL);
        }

        /// <summary>
        /// Método InsetarCategoria
        /// Ejecuta una consulta SQL de tipo "Insert" que inserta un nuevo registro a la tabla de categoria.
        /// Espera como parámetro una clase que contiene los atributos que son equivalentes a los campos de la tabla categoria que se desean insertar.
        /// Retorna un valor booleano con el fin de informar el éxito que tuvo la transacción.
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns></returns>
        public static bool InsertaCategoria(categorias categoria)
        {
            string strSQL = "Insert into categories (CategoryID, CategoryName, Description, Picture) values(";
            strSQL += "'" + categoria.CategoriaID + "',";
            strSQL += "'" + categoria.CategoryName + "',";
            strSQL += "'" + categoria.Description + "', NULL);";          
            return ExecTransaction(strSQL);
        }

        /// <summary>
        /// Método InsetarCategoriaFoto
        /// Ejecuta una consulta SQL de tipo "Insert" que inserta un nuevo registro a la tabla de categoria.
        /// Espera como parámetro una clase que contiene los atributos que son equivalentes a los campos de la tabla categoria que se desean insertar.
        /// Permite insetar una fotografia a la base de datos     
        /// Retorna un valor booleano con el fin de informar el éxito que tuvo la transacción.
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Método EditarCategoriaFoto
        /// Ejecuta una consulta SQL de tipo "Update" que actualiza un registro en específico de la tabla categoria.
        /// Espera como parámetro una clase que contiene los atributos que son equivalentes a los campos de la tabla categoria que se desean actualizar.
        /// Retorna un valor booleano con el fin de informar el éxito que tuvo la transacción.
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Método EliminarCategoria
        /// Ejecuta una consulta SQL de tipo "Delete" que actualiza un registro en específico de la tabla categoria.
        /// Espera como parámetro un valor entero que contiene el ID de la categoria a eliminar.
        /// Retorna un valor booleano con el fin de informar el éxito que tuvo la transacción.
        /// </summary>
        /// <param name="CatID"></param>
        /// <returns></returns>
        public static bool EliminaCategoria(int CatID)
        {
            string strSQL = "Delete from Categories where CategoryID=" + CatID;
            return ExecTransaction(strSQL);
        }

        /// <summary>
        /// Método InsetaCategoriasSP
        /// Ejecuta una consulta SQL de tipo "Insert" que inserta un nuevo registro a la tabla de categoria.
        /// Espera como parámetro una clase que contiene los atributos que son equivalentes a los campos de la tabla categoria que se desean insertar.
        /// Retorna un valor booleano con el fin de informar el éxito que tuvo la transacción.
        /// </summary>
        /// <param name="categorias"></param>
        /// <returns></returns>
        public static bool InsertaCategoriasSP(categorias categorias)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "InsertaCategorias";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombreCategoria", categorias.CategoryName);
            cmd.Parameters["@nombreCategoria"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Descri", categorias.Description);
            cmd.Parameters["@Descri"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Pic", categorias.Picture);
            cmd.Parameters["@Pic"].Direction = ParameterDirection.Input;
            return Configuracion.ExecTransactionParameters(cmd);
        }

    }
}
