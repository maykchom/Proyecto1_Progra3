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
    
        public class BLLShipper
        {
            public static DataTable ListarShipper(string strShipper)
            {
                return ClaseShipper.ListarShipper(strShipper);
            }

            public static bool InsertaShipperSP(Shipper Shipper)
            {
                return ClaseShipper.InsertaShipperSP(Shipper);
            }

            public static bool EliminaShipper(int ShipperID)
            {
                return ClaseShipper.EliminaShipper(ShipperID);
            }

            public static bool EditarShipper(Shipper Shipper)
            {
                return ClaseShipper.EditarShipper(Shipper);
            }

            public static bool InsertarShipperSP(Shipper Shipper)
            {
                return ClaseShipper.InsertaShipperSP(Shipper);
            }
        }

    }

