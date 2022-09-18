﻿using System;
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
    public partial class Clientes : Form
    {
        private DataTable dtListado;
        //string nombre;
        public Clientes()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evento de carga del formulario, ejecuta el método de Listar que muestra los clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clientes_Load(object sender, EventArgs e)
        {
            Listar();
            Limpiarcontroles();
        }
        /// <summary>
        /// El método Cargar obtiene la data de la base de datos y la muestra através de una data grid view
        /// </summary>
        private void Listar()
        {
            dtListado = BLL.BLLClientes.ListarClientes("");
            dgClientes.DataSource = dtListado;

        }
        /// <summary>
        /// El evento Limpiarcontroles borra el texto ingresado en los TextBox para un posterior ingreso de datos
        /// </summary>



        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        
        {
            Limpiarcontroles();
            panelEE.Enabled = false;
        }
        public void Limpiarcontroles()
        {
            txtClienteID.Text = "";
            txtCompania.Text = "";
            txtNombreContacto.Text = "";
            txtCargoContacto.Text = "";
            txtDireccion.Text = "";
            txtCiudad.Text = "";
            txtRegion.Text = "";
            txtCodigoPostal.Text = "";
            txtPais.Text = "";
            txtTelefono.Text = "";
            txtFax.Text = "";
            txtCompania.Focus();
        }
        /// <summary>
        /// Evento click del botón editar.
        /// Realiza la función de agregar un registro a los clientes.
        /// Implementa una instancia de la clase regiones para la asignación de atributos 
        /// Ejecuta método de InsertarClientes con los parámetros previamente asigandos a la clase Clientes
        /// Verifica si la transacción resultó exitosa para mostrar un mensaje correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Editar_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            Entidades.Clientes Cliente = new Entidades.Clientes();
            Cliente.CustomerID = txtClienteID.Text;
            Cliente.CompanyName = txtCompania.Text;
            Cliente.ContactName = txtNombreContacto.Text;
            Cliente.ContactTitle = txtCargoContacto.Text;
            Cliente.Address = txtDireccion.Text;
            Cliente.City = txtCiudad.Text;
            Cliente.Region = txtRegion.Text;
            Cliente.PostalCode = txtCodigoPostal.Text;
            Cliente.Country = txtCiudad.Text;
            Cliente.Phone = txtTelefono.Text;
            Cliente.Fax = txtFax.Text;
        

            resultado = BLL.BLLClientes.EditarClientes(Cliente);
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
        /// <summary>
        /// Evento click del botón de eliminar.
        /// Realiza la acción de eliminar un registro de clientes.
        /// Ejecuta el método de EliminarCliente con el ID del Cliente como parámetro
        /// Verifica si la transacción fué exitosa para mostrar el mensaje correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butEliminar_Click(object sender, EventArgs e)

        {
            bool resultado = false;
         
            resultado = BLL.BLLClientes.EliminaClientes(txtClienteID.Text);
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




        private void butGuardar_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            Entidades.Clientes Cliente= new Entidades.Clientes();
            Cliente.CustomerID = txtClienteID.Text;
            Cliente.CompanyName = txtCompania.Text;
            Cliente.ContactName = txtNombreContacto.Text;
            Cliente.ContactTitle = txtCargoContacto.Text;
            Cliente.Address = txtDireccion.Text;
            Cliente.City = txtCiudad.Text;
            Cliente.Region = txtRegion.Text;
            Cliente.PostalCode = txtCodigoPostal.Text;
            Cliente.Country = txtCiudad.Text;
            Cliente.Phone = txtTelefono.Text;
            Cliente.Fax = txtFax.Text;
            

            resultado = BLL.BLLClientes.InsertaClientes(Cliente);
            if (resultado)
            {
                MessageBox.Show("Registro ingresado correctamente");
                Limpiarcontroles();
                Listar();
                dgClientes.FirstDisplayedScrollingRowIndex = dgClientes.RowCount - 1;
            }
            else
            {
                MessageBox.Show("No se pudo ingresar el registro");
            }
        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                panelEE.Enabled = true;
                Limpiarcontroles();
                int RowNo;
                RowNo = e.RowIndex;
                txtClienteID.Text = dgClientes.Rows[RowNo].Cells[0].Value.ToString();
                txtCompania.Text = dgClientes.Rows[RowNo].Cells[1].Value.ToString();
                txtNombreContacto.Text = dgClientes.Rows[RowNo].Cells[2].Value.ToString();
                txtCargoContacto.Text = dgClientes.Rows[RowNo].Cells[3].Value.ToString();
                txtDireccion.Text = dgClientes.Rows[RowNo].Cells[4].Value.ToString();
                txtCiudad.Text = dgClientes.Rows[RowNo].Cells[5].Value.ToString();
                txtRegion.Text = dgClientes.Rows[RowNo].Cells[6].Value.ToString();
                txtCodigoPostal.Text = dgClientes.Rows[RowNo].Cells[7].Value.ToString();
                txtPais.Text = dgClientes.Rows[RowNo].Cells[8].Value.ToString();
                txtTelefono.Text = dgClientes.Rows[RowNo].Cells[9].Value.ToString();
                txtFax.Text = dgClientes.Rows[RowNo].Cells[10].Value.ToString();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Limpiarcontroles();
                panelEE.Enabled = false;
            }
        }

        private void txtCompania_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClienteID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
