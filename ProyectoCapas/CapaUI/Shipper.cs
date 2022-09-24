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
            txShipper.Text = "";
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
        /// <summary>
        /// Evento click del botón de Guardar.
        /// Realiza la acción de agregar un registro de shipper.
        /// Ejecuta el método de InsertarShipperSP con los parámetros previamente asigandos a la clase categorias
        /// Verifica si la transacción fué exitosa para mostrar el mensaje correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btGuardar_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txCompany.Text)))
            {
                MessageBox.Show("Campo(s) vacio(s), revise");
            }
            else
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
                    panelEE.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No se pudo ingresar el registro");

                }
            }
        }
        /// <summary>
        /// evento que se acciona al hacer click en una celda del dgCat
        /// Obtiene la coordenada de la fila y columna de la celda para obtener los datos deseados 
        /// con el fin de aplicarle un mantenimiento posterior.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            if ((string.IsNullOrEmpty(txCompany.Text)))
            {
                MessageBox.Show("Campo(s) vacio(s), revise");
            }
            else
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
                    panelEE.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No se pudo editar el registro");
                }
            }
        }
        //En el txtbox de CompanyName solo permite el ingreso de letras
        private void txCompany_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }
        
        private void txphone_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
    
}
