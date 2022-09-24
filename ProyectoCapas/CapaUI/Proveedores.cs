using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL;
using Entidades;

namespace CapaUI
{
    public partial class Proveedores : Form
    {
        private DataTable dtListado;
        public Proveedores()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento carga de formulario, ejecula el metodo listar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Proveedores_Load(object sender, EventArgs e)
        {
            Listar();
            Limpiarcontroles();
        }
        /// <summary>
        /// El método Listar obtiene la data de la base de datos y la muestra através de una data grid view
        /// </summary>
        private void Listar()
        {
            dtListado = BLL.BLLProveedores.ListarProveedores("");
            dgProveedores.DataSource = dtListado;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// boton de Editar
        /// Realiza la función de editar un registro en productos.
        /// Ejecuta método de EditarProveedores con los parámetros previamente asigandos a la clase de proveedores
        /// Verifica si la transacción resultó exitosa para mostrar un mensaje correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtCompania.Text)) || (string.IsNullOrEmpty(txtNombreContacto.Text)) || (string.IsNullOrEmpty(txtCargoContacto.Text)) || (string.IsNullOrEmpty(txtDireccion.Text)))
            {
                MessageBox.Show("Algunos campos no deben quedar vacíos");
            }
            else
            {             
                bool resultado = false;
                Entidades.Proveedores Proveedor = new Entidades.Proveedores();
                Proveedor.SupplierID = Convert.ToInt32(txtProveedorID.Text);
                Proveedor.CompanyName = txtCompania.Text;
                Proveedor.ContactName = txtNombreContacto.Text;
                Proveedor.ContactTitle = txtCargoContacto.Text;
                Proveedor.Address = txtDireccion.Text;
                Proveedor.City = txtCiudad.Text;
                Proveedor.Region = txtRegion.Text;
                Proveedor.PostalCode = txtCodigoPostal.Text;
                Proveedor.Country = txtCiudad.Text;
                Proveedor.Phone = txtTelefono.Text;
                Proveedor.Fax = txtFax.Text;
                Proveedor.HomePage = txtPaginaWeb.Text;
         
                resultado = BLL.BLLProveedores.EditarProveedores(Proveedor);
                if (resultado)
                {
                    MessageBox.Show("Registro editado correctamente");
                    Limpiarcontroles();
                    Listar();
                }
                else
                {
                    MessageBox.Show("No se pudo editar el registro");
                }
            }
        }
        /// <summary>
        /// BtNuevo
        /// Evento de click del botón "Nuevo", ejecuta el método "Limpiarcontroles".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
    
        private void button1_Click(object sender, EventArgs e)
        {
            Limpiarcontroles();
            panelEE.Enabled = false;
        }
        public void Limpiarcontroles()
        {
            txtProveedorID .Text = "";
            txtCompania .Text = "";
            txtNombreContacto. Text = "";
            txtCargoContacto.Text = "";
            txtDireccion .Text = "";
            txtCiudad .Text = "";
            txtRegion .Text = "";
            txtCodigoPostal .Text = "";
            txtPais .Text = "";
            txtTelefono .Text = "";
            txtFax. Text = "";
            txtPaginaWeb .Text = "";
            txtCompania.Focus();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        /// <summary>
        /// Evento click del botón de eliminar.
        /// Realiza la acción de eliminar un registro de productos.
        /// Ejecuta el método de EliminaProveedores con el ID del producto como parámetro
        /// Verifica si la transacción fué exitosa para mostrar el mensaje correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butELiminar_Click(object sender, EventArgs e)
        {

            bool resultado = false;
            resultado = BLL.BLLProveedores.EliminaProveedores(Convert.ToInt32(txtProveedorID.Text));
            if (resultado)
            {
                MessageBox.Show("Registro Eliminado correctamente");
                Limpiarcontroles();
                Listar();
            }
            else
            {
                MessageBox.Show("No se pudo Eliminar el registro");
            }
        }
        /// <summary>
        /// Evento click del botón editar.
        /// Realiza la función de agregar un registro a los proveedores.
        /// Ejecuta método de InsertarProveedores con los parámetros previamente asigandos a la clase Proveedores
        /// Verifica si la transacción resultó exitosa para mostrar un mensaje correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butGuardar_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtCompania.Text)) || (string.IsNullOrEmpty(txtNombreContacto.Text)) || (string.IsNullOrEmpty(txtCargoContacto.Text)) || (string.IsNullOrEmpty(txtDireccion.Text)))
            {
                MessageBox.Show("Algunos campos no deben quedar vacíos");
            }
            else
            {
                bool resultado = false;
                Entidades.Proveedores Proveedor = new Entidades.Proveedores();
                //Proveedor.SupplierID = Convert.ToInt32(txtProveedorID.Text);
                Proveedor.CompanyName = txtCompania.Text;
                Proveedor.ContactName = txtNombreContacto.Text;
                Proveedor.ContactTitle = txtCargoContacto.Text;
                Proveedor.Address = txtDireccion.Text;
                Proveedor.City = txtCiudad.Text;
                Proveedor.Region = txtRegion.Text;
                Proveedor.PostalCode = txtCodigoPostal.Text;
                Proveedor.Country = txtCiudad.Text;
                Proveedor.Phone = txtTelefono.Text;
                Proveedor.Fax = txtFax.Text;
                Proveedor.HomePage = txtPaginaWeb.Text;

                resultado = BLL.BLLProveedores.InsertarProveedores(Proveedor);
                if (resultado)
                {
                    MessageBox.Show("Registro ingresado correctamente");
                    Limpiarcontroles();
                    Listar();
                    dgProveedores.FirstDisplayedScrollingRowIndex = dgProveedores.RowCount - 1;
                }
                else
                {
                    MessageBox.Show("No se pudo ingresar el registro");
                }
            }
        }
        /// <summary>
        /// Evento que se acciona al hacer click en una celda del data grid view.
        /// Obtiene la coordenada de la fila y columna de la celda para obtener los datos deseados con el fin de aplicarle un mantenimiento posterior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                panelEE.Enabled = true;
                Limpiarcontroles();
                int RowNo;
                RowNo = e.RowIndex;
                txtProveedorID.Text = dgProveedores.Rows[RowNo].Cells[0].Value.ToString();
                txtCompania.Text = dgProveedores.Rows[RowNo].Cells[1].Value.ToString();
                txtNombreContacto.Text = dgProveedores.Rows[RowNo].Cells[2].Value.ToString();
                txtCargoContacto.Text = dgProveedores.Rows[RowNo].Cells[3].Value.ToString();
                txtDireccion.Text = dgProveedores.Rows[RowNo].Cells[4].Value.ToString();
                txtCiudad.Text = dgProveedores.Rows[RowNo].Cells[5].Value.ToString();
                txtRegion.Text = dgProveedores.Rows[RowNo].Cells[6].Value.ToString();
                txtCodigoPostal.Text = dgProveedores.Rows[RowNo].Cells[7].Value.ToString();
                txtPais.Text = dgProveedores.Rows[RowNo].Cells[8].Value.ToString();
                txtTelefono.Text = dgProveedores.Rows[RowNo].Cells[9].Value.ToString();
                txtFax.Text = dgProveedores.Rows[RowNo].Cells[10].Value.ToString();
                txtPaginaWeb.Text = dgProveedores.Rows[RowNo].Cells[11].Value.ToString();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Limpiarcontroles();
                panelEE.Enabled = false;
            }

        }

        //En el txtbox de NombreContacto solo permite el ingreso de letras
        private void txtNombreContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        //En el txtbox de CargoContacto solo permite el ingreso de letras
        private void txtCargoContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        //En el txtbox de Ciudad solo permite el ingreso de letras
        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        //En el txtbox de País solo permite el ingreso de letras
        private void txtPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        //En el txtbox de Region solo permite el ingreso de letras
        private void txtRegion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }
    }
}
