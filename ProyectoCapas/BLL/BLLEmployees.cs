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
    public class BLLEmployees
    {
        /// <summary>
        /// Método ListarEmployees.
        /// Ejecuta el método ListarEmployees de la clase "ClaseEmployees" en la capa DAL
        /// Espera como parámetro un string que contendrá el valor de la consulta a buscar.
        /// La data que devolverá será en formato DataTable
        /// </summary>
        /// <param name="strEmpl"></param>
        /// <returns></returns>
        public static DataTable ListarEmployees(string strEmpl)
        {
            return ClaseEmployees.ListarEmployees(strEmpl);
        }
        
        /// <summary>
        /// Método InsertaEmployees.
        /// Ejecuta el método InsertaEmployees de la clase "ClaseEmployees" en la capa DAL
        /// Espera como parámetro una clase que contendrá como atributos los valores de los campos a insertar.
        /// Retorna un valor booleano con el fin de informar el éxito que tuvo la transacción.
        /// </summary>
        /// <param name="employees"></param>
        /// <returns></returns>
       
        public static bool InsertaEmployees(Employees employees)
        {
            return ClaseEmployees.InsertarEmployees(employees);
            
        }
        /// <summary>
        /// Método EditarEmployees
        /// Ejecuta el método EditarEmployees de la clase "ClaseEmployees" en la capa DAL
        /// Espera como parámetro una clase que contendrá como atributos los valores de los campos a editar.
        /// Retorna un valor booleano con el fin de informar el éxito que tuvo la transacción.
        /// </summary>
        /// <param name="employees"></param>
        /// <returns></returns>
        public static bool EditarEmployees(Employees employees)
        {
            return ClaseEmployees.EditarEmployees(employees);

        }
        /// <summary>
        /// Método EliminarEmployees.
        /// Ejecuta el método EliminarEmployees de la clase "ClaseEmployees" en la capa DAL
        /// Espera como parámetro un valor entero que tendrá el Id de la región a eliminar.
        /// Retorna un valor booleano con el fin de informar el éxito que tuvo la transacción. 
        /// </summary>
        /// <param name="employees"></param>
        /// <returns></returns>
        public static bool EliminarEmployees(Employees employees)
        {
            return ClaseEmployees.EliminaEmployees(employees);
        }
    }
}
