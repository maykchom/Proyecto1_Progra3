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
        public static DataTable ListarEmployees(string strEmpl)
        {
            return ClaseEmployees.ListarEmployees(strEmpl);
        }
        public static bool InsertaEmployees(Employees employees)
        {
            return ClaseEmployees.InsertarEmployees(employees);
            
        }
        public static bool EditarEmployees(Employees employees)
        {
            return ClaseEmployees.EditarEmployees(employees);

        }

        public static bool EliminarEmployees(Employees employees)
        {
            return ClaseEmployees.EliminaEmployees(employees);
        }
    }
}
