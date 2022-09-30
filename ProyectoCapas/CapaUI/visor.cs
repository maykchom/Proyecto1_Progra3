using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUI
{
    public partial class visor : Form
    {
        string parametroFactura;
        DataSet ds = new DataSet();
        DataTable dtOrden;
        DataTable dtListadodetalle;
        DataTable dtTotal;
        /// <summary>
        /// Se muestra el NoFactura en un Label
        /// </summary>
        /// <param name="NoFactura"></param>
        public visor(string NoFactura)
        {
            InitializeComponent();
            lbfactura.Text = NoFactura;
            parametroFactura = NoFactura;
            dtOrden = BLL.BLLvistaOrdenes.ListarOrden(parametroFactura);
            dtListadodetalle = BLL.BLLvistaOrdenes.ListarOrdenesDetalles(Convert.ToInt32(parametroFactura));
            dtTotal = BLL.BLLvistaOrdenes.obtenerTotal(Convert.ToInt32(parametroFactura));
            ds.Tables.Add(dtOrden);
            ds.Tables.Add(dtListadodetalle);
            ds.Tables.Add(dtTotal);
        }
        /// <summary>
        /// Evento de carga del formulario, ejecuta el método de Listar que muestra los productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void visor_Load(object sender, EventArgs e)
        {
            ReportDataSource fuenteE;
            ReportDataSource fuenteD;
            ReportDataSource fuenteT;
            fuenteE = new ReportDataSource("dtOrden", ds.Tables[0]);
            fuenteD = new ReportDataSource("dtDetalles", ds.Tables[1]);
            fuenteT = new ReportDataSource("dtTotal", ds.Tables[2]);            
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(fuenteE);
            reportViewer1.LocalReport.DataSources.Add(fuenteD);
            reportViewer1.LocalReport.DataSources.Add(fuenteT);
            this.reportViewer1.RefreshReport();           
        }
    }
}
