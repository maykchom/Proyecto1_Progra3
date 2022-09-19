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
    public class ClaseOrdenes
    {

        public static DataTable ConsultaAbierta(string consulta)
        {
            string cadena = consulta;
            return Configuracion.GetDataTable(cadena);
        }

    }
}
