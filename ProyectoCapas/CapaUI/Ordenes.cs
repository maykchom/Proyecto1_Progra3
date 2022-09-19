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
    public partial class Ordenes : Form
    {
        private DataTable dtListado;
        private int idProdSele;
        private string nomProdSele;
        private decimal preProdSele;
        private int disProsele;
        public Ordenes()
        {
            InitializeComponent();
        }

        private void Ordenes_Load(object sender, EventArgs e)
        {
            cargarClientes();
            cargarEmpleados();
            cargarExpendedores();
            cargarProductos();
        }

        private void cargarProductos()
        {
            dtListado = BLL.BLLOrdenes.ConsultaAbierta("Select * from vista_productos_orden");
            dgvProductos.DataSource = dtListado;
        }

        private void cargarClientes()
        {
            DataTable dtz = new DataTable();
            dtz.Clear();
            dtz = BLL.BLLOrdenes.ConsultaAbierta("SELECT CUSTOMERID, COMPANYNAME FROM CUSTOMERS");
            cbCliente.DisplayMember = "CompanyName";
            cbCliente.ValueMember = "CUSTOMERID";
            cbCliente.DataSource = dtz;
        }

        private void cargarEmpleados()
        {
            DataTable dtz = new DataTable();
            dtz.Clear();
            dtz = BLL.BLLOrdenes.ConsultaAbierta("SELECT EMPLOYEEID, FIRSTNAME FROM EMPLOYEES");
            cbEmpleado.DisplayMember = "FIRSTNAME";
            cbEmpleado.ValueMember = "EMPLOYEEID";
            cbEmpleado.DataSource = dtz;
        }
        private void cargarExpendedores()
        {
            DataTable dtz = new DataTable();
            dtz.Clear();
            dtz = BLL.BLLOrdenes.ConsultaAbierta("SELECT SHIPPERID, COMPANYNAME FROM SHIPPERS");
            cbShipper.DisplayMember = "COMPANYNAME";
            cbShipper.ValueMember = "SHIPPERID";
            cbShipper.DataSource = dtz;
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int RowNo;
                RowNo = e.RowIndex;
                idProdSele = Convert.ToInt32(dgvProductos.Rows[RowNo].Cells[0].Value);
                nomProdSele = dgvProductos.Rows[RowNo].Cells[1].Value.ToString();
                preProdSele = Convert.ToDecimal(dgvProductos.Rows[RowNo].Cells[2].Value);
                disProsele= Convert.ToInt32(dgvProductos.Rows[RowNo].Cells[3].Value);
            }
            catch (System.ArgumentOutOfRangeException)
            {

            }
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            int nuevaRow = dgvOrden.Rows.Count;

            dgvOrden.Rows.Add(1);

            dgvOrden.Rows[nuevaRow].Cells[0].Value = idProdSele;
            dgvOrden.Rows[nuevaRow].Cells[1].Value = nomProdSele;
            dgvOrden.Rows[nuevaRow].Cells[2].Value = preProdSele;
            dgvOrden.Rows[nuevaRow].Cells[3].Value = tbCantidad.Text;
            dgvOrden.Rows[nuevaRow].Cells[4].Value = tbDescuento.Text;
        }
    }
}
