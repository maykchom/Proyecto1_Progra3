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
        /// <summary>
        /// Evento de carga del formulario, ejecuta el método de Listar que muestra las ordenes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ordenes_Load(object sender, EventArgs e)
        {
            cargarClientes();
            cargarEmpleados();
            cargarExpendedores();
            cargarProductos();
            btAgregar.Enabled = false;
        }

        /// <summary>
        /// El método Cargar obtiene la data de la base de datos y la muestra através de una data grid view
        /// </summary>
        private void cargarProductos()
        {
            dtListado = BLL.BLLOrdenes.ConsultaAbierta("Select * from vista_productos_orden");
            dgvProductos.DataSource = dtListado;
        }
        /// <summary>
        /// El método CargarClientes obtiene dos campos que son CUSTOMERID, COMPANYNAME de CUSTOMERS
        /// </summary>
        private void cargarClientes()
        {
            DataTable dtz = new DataTable();
            dtz.Clear();
            dtz = BLL.BLLOrdenes.ConsultaAbierta("SELECT CUSTOMERID, COMPANYNAME FROM CUSTOMERS");
            cbCliente.DisplayMember = "CompanyName";
            cbCliente.ValueMember = "CUSTOMERID";
            cbCliente.DataSource = dtz;
        }
        /// <summary>
        /// El método CargarEmpleados obtiene dos campos que son EMPLOYEEID, FIRSTNAME de EMPLOYEES 
        /// </summary>
        private void cargarEmpleados()
        {
            DataTable dtz = new DataTable();
            dtz.Clear();
            dtz = BLL.BLLOrdenes.ConsultaAbierta("SELECT EMPLOYEEID, FIRSTNAME FROM EMPLOYEES");
            cbEmpleado.DisplayMember = "FIRSTNAME";
            cbEmpleado.ValueMember = "EMPLOYEEID";
            cbEmpleado.DataSource = dtz;
        }
        /// <summary>
        /// El método cargarExpendedores obtiene dos campos que son SHIPPERID, COMPANYNAME de SHIPPERS
        /// </summary>
        private void cargarExpendedores()
        {
            DataTable dtz = new DataTable();
            dtz.Clear();
            dtz = BLL.BLLOrdenes.ConsultaAbierta("SELECT SHIPPERID, COMPANYNAME FROM SHIPPERS");
            cbShipper.DisplayMember = "COMPANYNAME";
            cbShipper.ValueMember = "SHIPPERID";
            cbShipper.DataSource = dtz;
        }
        /// <summary>
        /// evento que se acciona al hacer click en una celda del dgCat
        /// Obtiene la coordenada de la fila y columna de la celda para obtener los datos deseados 
        /// con el fin de aplicarle un mantenimiento posterior.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Evento click del botón de Agregar.
        /// Realiza la acción de agregar un registro de productos a la orden.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (disProsele >= Convert.ToInt32(tbCantidad.Text))
            {
                if (Convert.ToInt32(tbCantidad.Text) > 0)
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
                    lbAviso.Text = "Revise" + "\n" + "la cantidad";
                }
            }
            else
            {
                btAgregar.Enabled = false;
                lbAviso.Text = "¡Unidades" + "\n" + "insuficientes!";
            }
        }
        /// <summary>
        /// Evento de insertarOrden.
        /// Realiza la acción de insertar un registro de productos a la orden.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// El boton, lo que hace es mostrar el formulario de las ordenes registradas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            verOrdenes vo = new verOrdenes();
            vo.ShowDialog();
        }
        /// <summary>
        /// Evento de insertarOrdenDetails.
        /// Realiza la acción de insertar un registro de productos detallados a la orden.
        /// Ejecuta el método de InsertarOrdenDetails con los parámetros previamente asigandos a la clase ordenes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// El tb ordenar, lo que hace es enviar los datos completos a la orden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btOrdenar_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(tbFreight.Text)) || (string.IsNullOrEmpty(tbShipName.Text)) || (string.IsNullOrEmpty(tbShipAddress.Text)) || (string.IsNullOrEmpty(tbShipCity.Text)) || (string.IsNullOrEmpty(tbRegDes.Text)) || (string.IsNullOrEmpty(tbCodPosDes.Text)) || (string.IsNullOrEmpty(tbPaisDes.Text)))
            {
                MessageBox.Show("Datos de orden faltantes, favor de revisar", "Revise...", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                //MessageBox.Show("Datos correctos");
                insertarOrden();
                insertaOrdenDetails();
                limpiarControles();
            }
        }
        /// <summary>
        /// El evento Limpiarcontroles borra el texto ingresado en los TextBox para un posterior ingreso de datos
        /// </summary>
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
        /// <summary>
        /// evento que se acciona al hacer doble click en una celda del dgCat
        /// Obtiene la coordenada de la fila y columna de la celda para obtener los datos deseados 
        /// con el fin de editar los datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    //MessageBox.Show(cantidadStock.ToString());
                    break;
                }
            }

            tbCantidadEdit.Text = cantidad.ToString();
            tbDescuEdit.Text = descuento.ToString();
            panelEditar.Visible = true;
        }
        /// <summary>
        /// Evento click del botón editar.
        /// Realiza la función de editar la cantidad de producto y el descuento.
        /// Verifica si la transacción resultó exitosa para mostrar un mensaje correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                panelEditar.Visible = false;
            }
        }
        //En el txtbox de Cantidad solo permite el ingreso de numeros enteros
        private void tbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }
        //En el txtbox de Freight permite el ingreso de numeros enteros con decimal
        private void tbFreight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        //En el txtbox de RegionDestino solo permite el ingreso de letras
        private void tbRegDes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }
        //En el txtbox de PaísDestino solo permite el ingreso de letras
        private void tbPaisDes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        //En el txtbox de Descuento permite el ingreso de numeros enteros con decimal
        private void tbDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        //En el txtbox de EditarCantidad solo permite el ingreso de numeros enteros
        private void tbCantidadEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        //En el txtbox de EditarDescuento permite el ingreso de numeros enteros con decimal
        private void tbDescuEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

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
