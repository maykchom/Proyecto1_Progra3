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
    public partial class verOrdenes : Form
    {

        private DataTable dtListado;
        String NoFactura;
        public verOrdenes()
        {
            InitializeComponent();
        }

        private void verOrdenes_Load(object sender, EventArgs e)
        {
            cargarOrdenes();
        }
        public void cargarOrdenes()
        {
            dtListado = BLL.BLLvistaOrdenes.ListarOrdenes("");
            dtgOrdenes.DataSource = dtListado;
           
        }

        public void cargarOrdenesDetalles(int order)
        {
            dtListado = BLL.BLLvistaOrdenes.ListarOrdenesDetalles(order);
            dtgOrdenesDetalle.DataSource = dtListado;
        }


        private void dtgOrdenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowNo;
            RowNo = e.RowIndex;
            int order = Convert.ToInt32(dtgOrdenes.Rows[RowNo].Cells[0].Value.ToString());
            cargarOrdenesDetalles(order);
            NoFactura = dtgOrdenes.Rows[RowNo].Cells[0].Value.ToString();

        }

        private void btImpri_Click(object sender, EventArgs e)
        {
            visor settingsform = new visor(NoFactura);
            settingsform.Show();
  

        }
    }
}
