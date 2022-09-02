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
    public class BLLCategorias
    {
        /// <summary>
        /// Método ListarCategorias.
        /// Ejecuta el método ListarCategorias de la clase "ClaseCategorias" en la capa DAL
        /// Espera como parámetro un string que contendrá el valor de la consulta a buscar.
        /// La data que devolverá será en formato DataTable
        /// </summary>
        /// <param name="strCatt"></param>
        /// <returns></returns>
        public static DataTable ListarCategorias(string strCatt)
        {
            return ClaseCategorias.ListarCategorias(strCatt);
        }


        /// <summary>
        /// Método InsertarCategorias.
        /// Ejecuta el método InsertarCategoria de la clase "ClaseCategorias" en la capa DAL
        /// Espera como parámetro una clase que contendrá como atributos los valores de los campos a insertar.
        /// Retorna un valor booleano con el fin de informar el éxito que tuvo la transacción.
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns></returns>
        public static bool InsertarCategorias(categorias categoria)
        {
            return ClaseCategorias.InsertaCategoria(categoria);
        }

        /// <summary>
        /// Método InsertarCategorias.
        /// Ejecuta el método InsetarCategoriaFoto de la clase "ClaseCategorias" en la capa DAL
        /// Espera como parámetro una clase que contendrá como atributos los valores de los campos a insertar.
        /// Retorna un valor booleano con el fin de informar el éxito que tuvo la transacción.
        /// La forma de ejecutar la transaccion es distinta al método anterior
        /// Permite parámetros
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns></returns>
        public static bool InsertarCategoriasFotos(categorias categoria)
        {
            return ClaseCategorias.InsertaCategoriaFoto(categoria);
        }

        /// <summary>
        /// Ejecuta el método EditarCategoriaFoto de la clase "ClaseCategorias" en la capa DAL
        /// Espera como parámetro una clase que contendrá como atributos los valores de los campos a editar.
        /// Retorna un valor booleano con el fin de informar el éxito que tuvo la transacción.
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns></returns>
        public static bool EditarCategoriasFotos(categorias categoria)
        {
            return ClaseCategorias.EditarCategoriaFoto(categoria);
        }

        /// <summary>
        /// Método EliminarCategoria.
        /// Ejecuta el método EliminarCategoria de la clase "ClaseCategoria" en la capa DAL
        /// Espera como parámetro un valor entero que tendrá el Id de la región a eliminar.
        /// Retorna un valor booleano con el fin de informar el éxito que tuvo la transacción. 
        /// </summary>
        /// <param name="CatID"></param>
        /// <returns></returns>
        public static bool EliminarCategoria(int CatID)
        {
            return ClaseCategorias.EliminaCategoria(CatID);
        }

        public static bool InsertarCategoriasSP(categorias categorias)
        {
            return ClaseCategorias.InsertaCategoriasSP(categorias);
        }
        
    }
}
