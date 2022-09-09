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
        public visor(string NoFactura)
        {
            InitializeComponent();
            lbfactura.Text = NoFactura;
            parametroFactura = NoFactura;
            dtOrden = BLL.BLLvistaOrdenes.ListarOrden(parametroFactura);
            dtListadodetalle = BLL.BLLvistaOrdenes.ListarOrdenesDetalles(Convert.ToInt32(parametroFactura));
            ds.Tables.Add(dtOrden);
            ds.Tables.Add(dtListadodetalle);
        }

        private void visor_Load(object sender, EventArgs e)
        {
            ReportDataSource fuenteE;
            ReportDataSource fuenteD;
            fuenteE = new ReportDataSource("dtOrden", ds.Tables[0]);
            fuenteD = new ReportDataSource("dtDetalles", ds.Tables[1]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(fuenteE);
            reportViewer1.LocalReport.DataSources.Add(fuenteD);
            this.reportViewer1.RefreshReport();           
        }
    }
}
