using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using BLL;
using Entidades;

namespace CapaUI
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
               
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //boton de Editar
        private void button2_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            Proveedores Proveedor = new Proveedores();
            Proveedor.ProveedorID = Convert.ToInt32(txtProveedorID.Text);
            Proveedor.CompanyName = txtCompania.Text;

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
            txtCorreo .Text = "";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        // boton de Eliminar
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
            Proveedores Proveedor = new Proveedores();
            Proveedor.ProveedorID = Convert.ToInt32(txtProveedorID.Text);
            Proveedor.RegionDescripcion = txtRegionNombre.Text;
            resultado = BLL.BLLRegiones.InsertarRegiones(Region);
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
    }
}
