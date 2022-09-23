using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Employees representa a la entidad employees de la base de datos
    /// Los atributos de la clase representan a los campos de la entidad employees
    /// </summary>
    public class Employees
    {
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public string Extension { get; set; }
        public Byte[] Photo { get; set; }
        public string Notes { get; set; }
        public int ReportsTo { get; set; }
        public string PhotoPath { get; set; }
        public decimal Salary { get; set; }


    }
}
