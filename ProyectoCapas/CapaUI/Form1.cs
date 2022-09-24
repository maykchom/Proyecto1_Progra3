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
    public partial class Form1 : Form
    {
       private DataTable dtListado;
        public Form1()
        {
            InitializeComponent();
        }

        // Evento de carga del formulario, ejecuta el método de Listar que muestra las regiones
        private void Form1_Load(object sender, EventArgs e)
        {
            Listar();
            Limpiarcontroles(); 
        }

        // El método Cargar obtiene la data de la base de datos y la muestra através de una data grid view
        private void Listar()
        {
            dtListado = BLL.BLLRegiones.ListarRegiones("");
            dgRegiones.DataSource = dtListado;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // Evento click del botón de Guardar.
        // Realiza la acción de agregar un registro de regiones.
        // Ejecuta el método de InsertarRegionesSP con los parámetros previamente asigandos a la clase regiones
        // Verifica si la transacción fué exitosa para mostrar el mensaje correspondiente
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtRegionNombre.Text)))
            {
                MessageBox.Show("Campo(s) vacio(s), revise");
            }
            else
            {
                bool resultado = false;
                Regiones Region=new Regiones();
                //Region.RegionID = Convert.ToInt32(txtRegionID.Text);
                Region.RegionDescripcion = txtRegionNombre.Text;
                resultado = BLL.BLLRegiones.InsertarRegionesSP(Region);
                if (resultado)
                {
                    MessageBox.Show("Registro ingresado correctamente");
                    Limpiarcontroles();
                    Listar();
                    dgRegiones.FirstDisplayedScrollingRowIndex = dgRegiones.RowCount - 1;
                }
                else
                {
                    MessageBox.Show("No se pudo ingresar el registro");
                }
            }
        }

        // Evento click del botón nuevo.
        // Realiza la función de limpiar los controles de regiones.
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiarcontroles();
            panelEE.Enabled = false;
        }

        // El evento Limpiarcontroles borra el texto ingresado en los TextBox de regiones
        // para un posterior ingreso de datos
        public void Limpiarcontroles()
        {
            txtRegionID.Text = "";
            txtRegionNombre.Text = "";
            txtRegionNombre.Focus();
        }

        private void dgRegiones_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        // evento que se acciona al hacer click en una celda del dgCat
        // Obtiene la coordenada de la fila y columna de la celda para obtener los datos deseados 
        // con el fin de aplicarle un mantenimiento posterior.
        private void dgRegiones_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                panelEE.Enabled = true;
                Limpiarcontroles();
                int RowNo;
                RowNo = e.RowIndex;
                txtRegionID.Text = dgRegiones.Rows[RowNo].Cells[0].Value.ToString();
                txtRegionNombre.Text= dgRegiones.Rows[RowNo].Cells[1].Value.ToString();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Limpiarcontroles();
                panelEE.Enabled = false;
            }

        }

        // Evento click del botón de eliminar.
        // Realiza la acción de eliminar un registro de regiones.
        // Ejecuta el método de EliminaRegiones con el ID del region como parámetro
        // Verifica si la transacción fué exitosa para mostrar el mensaje correspondiente
        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
            bool resultado = false;
            resultado = BLL.BLLRegiones.EliminaRegiones(Convert.ToInt32(txtRegionID.Text));
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

        private void dgRegiones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtRegionID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegionNombre_TextChanged(object sender, EventArgs e)
        {

        }

        // Evento click del botón editar.
        // Realiza la función de editar un registro en las regiones.
        // Ejecuta método de EditarRegiones con los parámetros previamente asigandos a la clase de regiones
        // Verifica si la transacción resultó exitosa para mostrar un mensaje correspondiente
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtRegionNombre.Text)))
            {
                MessageBox.Show("Campo(s) vacio(s), revise");
            }
            else
            {
                bool resultado = false;
                Regiones Region = new Regiones();
                Region.RegionID = Convert.ToInt32(txtRegionID.Text);
                Region.RegionDescripcion = txtRegionNombre.Text;
                resultado = BLL.BLLRegiones.EditarRegiones(Region);
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

        private void gControles_Enter(object sender, EventArgs e)
        {

        }

        //En el txtbox de RegionNombre solo permite el ingreso de letras
        private void txtRegionNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }
    }
}
