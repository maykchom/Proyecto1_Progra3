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
//Evento carga de formulario, ejecula el metodo listar.

        private void Proveedores_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void Listar()
        {
            dtListado = BLL.BLLProveedores.ListarProveedores("");
            dgProveedores.DataSource = dtListado;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //boton de Editar

        private void button2_Click(object sender, EventArgs e)
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
        //Boton Nuevo
        // Ejecuta el metodo de LIMPIAR BOTONES

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiarcontroles();
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

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
        // boton de Eliminar
        //ELIMINA UN REGISTRO
        //REALIZA LA ACCION DE ELIMINAR UN REGISTRO DE PROVEEDORES

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

        //Boton de Guardar

        private void butGuardar_Click(object sender, EventArgs e)
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

            resultado = BLL.BLLProveedores.InsertarProveedores(Proveedor);
            if (resultado)
            {
                MessageBox.Show("Registro ingresado correctamente");
                Limpiarcontroles();
                Listar();
            }
            else
            {
                MessageBox.Show("No se pudo ingresar el registro");
            }
        }

        private void dgProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
    }
}
