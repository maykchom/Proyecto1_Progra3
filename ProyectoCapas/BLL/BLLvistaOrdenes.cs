﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using Entidades;

namespace BLL
{
    public class BLLvistaOrdenes
    {
        public static DataTable ListarOrdenes(string strShipper)
        {
            return ClaseVistaOrdenes.ListarOrdenes(strShipper);
        }
        public static DataTable ListarOrden(string NoFactura)
        {
            return ClaseVistaOrdenes.ListarOrden(NoFactura);
        }

        public static DataTable ListarOrdenesDetalles(int order)
        {
            return ClaseVistaOrdenes.ListarOrdenesDetalles(order);
        }
    }
}
