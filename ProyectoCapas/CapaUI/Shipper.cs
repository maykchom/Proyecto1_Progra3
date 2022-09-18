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
    public partial class Shipper : Form
    {
        private DataTable dtListado;
        //string nombre;
        
        public Shipper()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evento de carga del formulario, ejecuta el método de Listar que muestra los Shippers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Shipper_Load(object sender, EventArgs e)
        {
            cargarShipper();
            Limpiarcontroles();
        }
        /// <summary>
        /// El método Cargar obtiene la data de la base de datos y la muestra através de una data grid view
        /// </summary>
        public void cargarShipper()
        {
            dtListado = BLL.BLLShipper.ListarShipper("");
            dgShipper.DataSource = dtListado;
        }
        /// <summary>
        /// El evento Limpiarcontroles borra el texto ingresado en los TextBox para un posterior ingreso de datos
        /// </summary>
        public void Limpiarcontroles()
        {
            txCompany.Text = "";
            txphone.Text = "";
            txCompany.Focus();
        }
        /// <summary>
        /// Evento click del botón nuevo.
        /// Realiza la función de agregar un registro a los Shippers.
        /// Implementa una instancia de la clase regiones para la asignación de atributos 
        /// Ejecuta método de InsertarShippers con los parámetros previamente asigandos a la clase Shippers
        /// Verifica si la transacción resultó exitosa para mostrar un mensaje correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNuevo_Click(object sender, EventArgs e)
        {
            Limpiarcontroles();
            panelEE.Enabled = false;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {

            bool resultado = false;
            Entidades.Shipper shipper = new Entidades.Shipper();
           // shipper.ShipperID = Convert.ToInt32(txShipper.Text);
            shipper.CompanyName = txCompany.Text;
            shipper.Phone = txphone.Text;


            resultado = BLL.BLLShipper.InsertarShipperSP(shipper);
            if (resultado)
            {
                MessageBox.Show("Registro ingresado correctamente");
                cargarShipper();
                Limpiarcontroles();
                dgShipper.FirstDisplayedScrollingRowIndex = dgShipper.RowCount - 1;
            }
            else
            {
                MessageBox.Show("No se pudo ingresar el registro");

            }
        }

        private void dgShipper_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                panelEE.Enabled = true;
                Limpiarcontroles();
                int RowNo;
                RowNo = e.RowIndex;
                txShipper.Text = dgShipper.Rows[RowNo].Cells[0].Value.ToString();
                txCompany.Text = dgShipper.Rows[RowNo].Cells[1].Value.ToString();
                txphone.Text = dgShipper.Rows[RowNo].Cells[2].Value.ToString();            
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Limpiarcontroles();
                panelEE.Enabled = false;
            }
        }
        /// <summary>
        /// Evento click del botón de eliminar.
        /// Realiza la acción de eliminar un registro de productos.
        /// Ejecuta el método de EliminarShipper con el ID del Shipper como parámetro
        /// Verifica si la transacción fué exitosa para mostrar el mensaje correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEli_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            Entidades.Shipper Expendedores = new Entidades.Shipper();
            Expendedores.ShipperID = Convert.ToInt32(txShipper.Text);
            resultado = BLL.BLLShipper.EliminarExpendedores( Expendedores);
            if (resultado)
            {
                MessageBox.Show("Registro Eliminado correctamente");
                Limpiarcontroles();
                cargarShipper();
            }
            else
            {
                MessageBox.Show("No se pudo Eliminar el registro");
            }
        }
        /// <summary>
        /// Evento click del botón editar.
        /// Realiza la función de agregar un registro a los productos.
        /// Implementa una instancia de la clase regiones para la asignación de atributos 
        /// Ejecuta método de InsertarProductos con los parámetros previamente asigandos a la clase Productos
        /// Verifica si la transacción resultó exitosa para mostrar un mensaje correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEditar_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            Entidades.Shipper shipper = new Entidades.Shipper();
            shipper.ShipperID = Convert.ToInt32(txShipper.Text);
            shipper.CompanyName = (txCompany.Text);
            shipper.Phone = (txphone.Text);
            resultado = BLL.BLLShipper.EditarShipper(shipper);
            if (resultado)
            {
                MessageBox.Show("Registro editado correctamente");
                Limpiarcontroles();
                cargarShipper();
            }
            else
            {
                MessageBox.Show("No se pudo editar el registro");
            }
        }

        private void txCompany_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        /// <summary>
        /// Evento validacion de datos.
        /// Realiza la acción que no permite ingresar datos datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txphone_KeyPress(object sender, KeyPressEventArgs e)
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
    }
    
}
