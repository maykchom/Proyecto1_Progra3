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
    public class BLLOrdenes
    {

        public static DataTable ConsultaAbierta(string consulta)
        {
            return ClaseOrdenes.ConsultaAbierta(consulta);
        }

    }
}
