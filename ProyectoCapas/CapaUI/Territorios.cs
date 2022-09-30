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
    public partial class Territorios : Form
    {
        private DataTable dtListado;
        public Territorios()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evento de carga del formulario, ejecuta el método de Listar que muestra los productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Territorios_Load(object sender, EventArgs e)
        {
            Listar();
        }
        /// <summary>
        /// El método Listar obtiene la data de la base de datos y la muestra através de una data grid view
        /// </summary>
        private void Listar()
        {
            dtListado = BLL.BLLTerritorios.ListarTerritorios();
            dgTerritorios.DataSource = dtListado;

        }

        /// <summary>
        /// 
        /// </summary>
        private void cargarRegiones()
        {
            DataTable dtz = new DataTable();
            dtz.Clear();
            dtz = BLL.BLLProductos.ConsultaAbierta("RegionID, RegionDescription", "Region");
            cbRegion.DisplayMember = "RegionDescription";
            cbRegion.ValueMember = "RegionID";
            cbRegion.DataSource = dtz;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Evento de click del botón "Nuevo", ejecuta el método "Limpiarcontroles".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butNuevo_Click(object sender, EventArgs e)
        {
            Limpiarcontroles();
            panelEE.Enabled = false;
        }
        /// <summary>
        /// El evento Limpiarcontroles borra el texto ingresado en los TextBox para un posterior ingreso de datos
        /// </summary>
        public void Limpiarcontroles()
        {
            txtTerritorioID.Text = "";
            txtDescripcionTerritorio.Text = "";            
            txtDescripcionTerritorio.Focus();            
        }
        /// <summary>
        /// Evento click del botón editar.
        /// Realiza la función de editar un registro en Territorios.
        /// Ejecuta método de EditarTerritorios con los parámetros previamente asigandos a la clase de Territorios
        /// Verifica si la transacción resultó exitosa para mostrar un mensaje correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butEditar_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtDescripcionTerritorio.Text)))
            {
                MessageBox.Show("Campo(s) vacio(s), revise");
            }
            else
            {
                bool resultado = false;
                Entidades.Territorios Territorio = new Entidades.Territorios();
                Territorio.TerritoryID = Convert.ToInt32(txtTerritorioID.Text);
                Territorio.TerritoryDescription = txtDescripcionTerritorio.Text;
                Territorio.RegionID = Convert.ToInt32(cbRegion.SelectedValue);
          

                resultado = BLL.BLLTerritorios.EditarTerritorios(Territorio);
                if (resultado)
                {
                    MessageBox.Show("Registro editado correctamente");
                    Limpiarcontroles();
                    Listar();
                    panelEE.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No se pudo editar el registro");
                }
            }
        }
        /// <summary>
        /// Evento click del botón de eliminar.
        /// Realiza la acción de eliminar un registro de territorios.
        /// Ejecuta el método de EliminaTerritorios con el ID del territorio como parámetro
        /// Verifica si la transacción fué exitosa para mostrar el mensaje correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butELiminar_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            Entidades.Territorios territorios = new Entidades.Territorios();
            territorios.TerritoryID = Convert.ToInt32(txtTerritorioID.Text);
            resultado = BLL.BLLTerritorios.EliminaTerritorios(territorios);
            if (resultado)
            //bool resultado = false;
            //resultado = BLL.BLLTerritorios.EliminaTerritorios(Convert.ToInt32(txtTerritorioID.Text));
            //if (resultado)
            {
                MessageBox.Show("Registro Eliminado correctamente");
                Limpiarcontroles();
                Listar();
                panelEE.Enabled = false;
            }
            else
            {
                MessageBox.Show("No se pudo Eliminar el registro");
            }
        }

        /// <summary>
        /// Evento click del botón guardar.
        /// Realiza la función de agregar un registro a los territorios.
        /// Ejecuta método de InsertarTerritorios con los parámetros previamente asigandos a la clase territorios
        /// Verifica si la transacción resultó exitosa para mostrar un mensaje correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butGuardar_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtDescripcionTerritorio.Text)))
            {
                MessageBox.Show("Campo(s) vacio(s), revise");
            }
            else
            {
                bool resultado = false;
                Entidades.Territorios Territorio = new Entidades.Territorios();
                Territorio.TerritoryDescription = txtDescripcionTerritorio.Text;
                Territorio.RegionID = Convert.ToInt32(cbRegion.SelectedValue);

                resultado = BLL.BLLTerritorios.InsertarTerritorios(Territorio);
                if (resultado)
                {
                    MessageBox.Show("Registro ingresado correctamente");
                    Limpiarcontroles();
                    Listar();
                    dgTerritorios.FirstDisplayedScrollingRowIndex = dgTerritorios.RowCount - 1;
                    cbRegion.SelectedIndex = 0;
                    panelEE.Enabled = false;
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
        private void dgTerritorios_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                panelEE.Enabled = true;
                Limpiarcontroles();
                int RowNo;
                RowNo = e.RowIndex;
                txtTerritorioID.Text = dgTerritorios.Rows[RowNo].Cells[0].Value.ToString();
                txtDescripcionTerritorio.Text = dgTerritorios.Rows[RowNo].Cells[1].Value.ToString();

                //Obtener el ID de la region
                DataTable tablaSup = new DataTable();
                string regBus = dgTerritorios.Rows[RowNo].Cells[2].Value.ToString();
                tablaSup = BLLProductos.ConsultaAbierta("RegionID", "Region where RegionDescription = \"" + regBus + "\"");
                int IdReg = Convert.ToInt32(tablaSup.Rows[0][0]);
                cbRegion.SelectedValue = IdReg;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                panelEE.Enabled = false;
            }
        }
        /// <summary>
        /// Evento listar territorios y ejecuta el método "Limpiarcontroles".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Territorios_Load_1(object sender, EventArgs e)
        {
            Listar();
            Limpiarcontroles();
            cargarRegiones();
        }

        //En el txtbox de DescripcionTerritorio solo permite el ingreso de letras
        private void txtDescripcionTerritorio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }
        //En el txtbox de RegionID solo permite el ingreso de numeros enteros
        private void txtRegionID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }
    }
}
