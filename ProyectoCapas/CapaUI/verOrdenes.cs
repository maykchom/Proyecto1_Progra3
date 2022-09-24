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
        string NoFactura;
        public verOrdenes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento de carga del formulario, ejecuta el método de Listar que muestra los productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void verOrdenes_Load(object sender, EventArgs e)
        {
            cargarOrdenes();
        }
        /// <summary>
        /// El método Cargar ordenes obtiene la data de la base de datos y la muestra através de una data grid view
        /// </summary>
        public void cargarOrdenes()
        {
            dtListado = BLL.BLLvistaOrdenes.ListarOrdenes("");
            dtgOrdenes.DataSource = dtListado;
           
        }
        /// <summary>
        /// El método cargarOrdenesDetalles obtiene la data de la base de datos y la muestra através de una data grid view
        /// </summary>
        public void cargarOrdenesDetalles(int order)
        {
            dtListado = BLL.BLLvistaOrdenes.ListarOrdenesDetalles(order);
            dtgOrdenesDetalle.DataSource = dtListado;
        }

        /// <summary>
        /// Evento que se acciona al hacer click en una celda del data grid view.
        /// Obtiene la coordenada de la fila y columna de la celda para obtener los datos deseados con el fin de aplicarle un mantenimiento posterior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgOrdenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowNo;
            RowNo = e.RowIndex;
            btImpri.Enabled = true;
            try
            {
                int order = Convert.ToInt32(dtgOrdenes.Rows[RowNo].Cells[0].Value.ToString());
                cargarOrdenesDetalles(order);
                NoFactura = dtgOrdenes.Rows[RowNo].Cells[0].Value.ToString();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                
            }

            DataGridViewColumn c1 = dtgOrdenesDetalle.Columns[1];
            c1.Visible = false;

        }
        /// <summary>
        /// Evento click del botón de imprimir.
        /// Realiza la presentacion de un nuevo form. llamado visor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btImpri_Click(object sender, EventArgs e)
        {
            visor settingsform = new visor(NoFactura);
            settingsform.ShowDialog();
  

        }
    }
}
