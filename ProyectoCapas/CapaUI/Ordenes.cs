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
        private int IdOrdenInsertada;
        private int filaEditar;        
        private int cantidadStock;
        //bool regAgreado = false;
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
            btAgregar.Enabled = false;
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
                lbAviso.Text = "";
                int RowNo;
                RowNo = e.RowIndex;
                idProdSele = Convert.ToInt32(dgvProductos.Rows[RowNo].Cells[0].Value);
                nomProdSele = dgvProductos.Rows[RowNo].Cells[1].Value.ToString();
                preProdSele = Convert.ToDecimal(dgvProductos.Rows[RowNo].Cells[2].Value);
                disProsele= Convert.ToInt32(dgvProductos.Rows[RowNo].Cells[3].Value);
                btAgregar.Enabled = true;


                //Verificar que no se puedan agregar dos veces un mismo producto

                int totalRegistros = dgvOrden.RowCount;
                
                for (int i = 0; i <= totalRegistros-1; i++)
                {
                    //MessageBox.Show("Vuelta: "+(i));
                    //MessageBox.Show("IDseleccionado: " + idProdSele.ToString() +" y IDorden: "+ dgvOrden.Rows[i].Cells[0].Value.ToString());
                    if (idProdSele == (Convert.ToInt32(dgvOrden.Rows[i].Cells[0].Value)))
                    {
                        //MessageBox.Show("Encontrado en registro: " + (i).ToString());
                        btAgregar.Enabled = false;
                        lbAviso.Text = "¡Producto ya" + "\n" + "agregado!";
                        break;
                    }
                    else
                    {
                        //MessageBox.Show("Se activo");
                        btAgregar.Enabled=true;
                        lbAviso.Text = "";
                    }
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {

            }
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (disProsele >= Convert.ToInt32(tbCantidad.Text))
            {
                int nuevaRow = dgvOrden.Rows.Count;

                dgvOrden.Rows.Add(1);

                dgvOrden.Rows[nuevaRow].Cells[0].Value = idProdSele;
                dgvOrden.Rows[nuevaRow].Cells[1].Value = nomProdSele;
                dgvOrden.Rows[nuevaRow].Cells[2].Value = preProdSele;
                dgvOrden.Rows[nuevaRow].Cells[3].Value = tbCantidad.Text;
                dgvOrden.Rows[nuevaRow].Cells[4].Value = tbDescuento.Text;

                btOrdenar.Enabled=true;
                btAgregar.Enabled = false;
                lbAviso.Text = "";
            }
            else
            {
                btAgregar.Enabled = false;
                lbAviso.Text = "¡Unidades" + "\n" + "insuficientes!";
            }
        }

        private void insertarOrden()
        {
            Entidades.OrdenesRespuesta resultado = new Entidades.OrdenesRespuesta();            
            lbClienteID.Text = cbCliente.SelectedValue.ToString();
            string customerID = lbClienteID.Text;
            int employID = Convert.ToInt32(cbEmpleado.SelectedValue);
            DateTime orderDate = DateTime.Now;
            DateTime requireDate = Convert.ToDateTime(dtpFeReque.Text);
            DateTime shippedDate = Convert.ToDateTime(dtpFeEnvi.Text);
            int shipVia = Convert.ToInt32(cbShipper.SelectedValue);
            double freight = Convert.ToDouble(tbFreight.Text);
            string shipName = tbShipName.Text;
            string shipAddress = tbShipAddress.Text;
            string shipCity = tbShipCity.Text;
            string shipRegion = tbRegDes.Text;
            string shipPosCod = tbCodPosDes.Text;
            string shipCountry = tbPaisDes.Text;

            
            resultado = BLL.BLLOrdenes.InsertarOrden(customerID, employID, orderDate, requireDate, shippedDate, shipVia, freight, shipName, shipAddress, shipCity, shipRegion, shipPosCod, shipCountry);
            if (resultado.respuesta)
            {
                IdOrdenInsertada = Convert.ToInt32(resultado.ID);
                MessageBox.Show("Registro ingresado correctamente, nuevo ID region " + resultado.ID);
                //Limpiarcontroles();
                //Listar();
            }
            else
            {
                MessageBox.Show("No se pudo ingresar el registro");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void insertaOrdenDetails()
        {
            bool resultado = false;
            int totalRegistros = dgvOrden.RowCount;
            for (int i = 1; i <= totalRegistros; i++)
            {
                int idProducto = Convert.ToInt32(dgvOrden.Rows[i-1].Cells[0].Value);
                decimal UnitPrice = Convert.ToDecimal(dgvOrden.Rows[i - 1].Cells[2].Value);
                int Quantity = Convert.ToInt32(dgvOrden.Rows[i - 1].Cells[3].Value);
                double Discount = Convert.ToDouble(dgvOrden.Rows[i - 1].Cells[4].Value);
                resultado = BLL.BLLOrdenes.InsertarOrdenDetails(IdOrdenInsertada, idProducto, UnitPrice, Quantity, Discount);
            }
            if (resultado)
            {
                MessageBox.Show("Registro ingresado correctamente");
                //Limpiarcontroles();
            }
            else
            {
                MessageBox.Show("No se pudo ingresar el registro");
            }
        }

        private void btOrdenar_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(tbFreight.Text)) || (string.IsNullOrEmpty(tbShipName.Text)) || (string.IsNullOrEmpty(tbShipAddress.Text)) || (string.IsNullOrEmpty(tbShipCity.Text)) || (string.IsNullOrEmpty(tbRegDes.Text)) || (string.IsNullOrEmpty(tbCodPosDes.Text)) || (string.IsNullOrEmpty(tbPaisDes.Text)))
            {
                MessageBox.Show("Datos faltantes, favor de revisar", "Revise...", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                //MessageBox.Show("Datos correctos");
                insertarOrden();
                insertaOrdenDetails();
                limpiarControles();
            }
        }

        private void limpiarControles()
        {
            cbCliente.SelectedIndex = 0;
            cbEmpleado.SelectedIndex = 0;
            dtpFeReque.Value = DateTime.Now;
            dtpFeEnvi.Value = DateTime.Now;
            cbShipper.SelectedIndex = 0;
            tbFreight.Text = "0";
            tbShipName.Clear();
            tbShipAddress.Clear();
            tbShipCity.Clear();
            tbRegDes.Clear();
            tbCodPosDes.Clear();
            tbPaisDes.Clear();
            tbCantidad.Text = "1";
            tbDescuento.Text = "0";
            dgvOrden.Rows.Clear();
        }

        private void dgvOrden_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            filaEditar = e.RowIndex;

            int idProductoBuscado = Convert.ToInt32(dgvOrden.Rows[filaEditar].Cells[0].Value);
            int cantidad = Convert.ToInt32(dgvOrden.Rows[filaEditar].Cells[3].Value);
            int descuento = Convert.ToInt32(dgvOrden.Rows[filaEditar].Cells[4].Value);

            int totalRegistros = dgvProductos.RowCount;
            for (int i = 0; i < totalRegistros; i++)
            {
                //MessageBox.Show("valor en tabla productos: " + dgvProductos.Rows[i].Cells[0].Value.ToString() + " Valor en orders: "+idProductoBuscado.ToString()); ;
                if (Convert.ToInt32(dgvProductos.Rows[i].Cells[0].Value) == idProductoBuscado)
                {
                    cantidadStock = Convert.ToInt32(dgvProductos.Rows[i].Cells[3].Value);
                    MessageBox.Show(cantidadStock.ToString());
                    break;
                }
            }

            tbCantidadEdit.Text = cantidad.ToString();
            tbDescuEdit.Text = descuento.ToString();
            panelEditar.Visible = true;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            int cantidadNueva = Convert.ToInt32(tbCantidadEdit.Text);
            if (cantidadNueva > cantidadStock)
            {
                MessageBox.Show("Sin unidades suficientes", "Revise...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dgvOrden.Rows[filaEditar].Cells[3].Value = cantidadNueva.ToString();
                dgvOrden.Rows[filaEditar].Cells[4].Value = tbDescuEdit.Text;
                MessageBox.Show("Listo");
            }
        }

        //DUDAAAAAAA
        //private int BuscarCantidad(int idPro)
        //{
        //    int totalRegistros = dgvProductos.RowCount;
        //    int cantidadBuscada;
        //    for (int i = 0; i < totalRegistros; i++)
        //    {                
        //        if (Convert.ToInt32(dgvProductos.Rows[i].Cells[0].Value) == idPro)
        //        {
        //            cantidadBuscada = Convert.ToInt32(dgvProductos.Rows[i].Cells[3].Value);
        //            MessageBox.Show(cantidadBuscada.ToString());
        //        }
        //    }
        //    return cantidadBuscada;
        //}
    }
}
