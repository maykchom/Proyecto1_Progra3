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
    public class ClaseVistaOrdenes
    {
        public static DataTable ListarOrdenes(string strShipper)
        {
            string strSQL = "select * from vistaOrdenes";
            ///strSQL += " where CompanyName like '%" + strShipper + "%'";
            return Configuracion.GetDataTable(strSQL);
        }
    }
}
