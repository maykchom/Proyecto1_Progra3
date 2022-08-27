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
        private void Territorios_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void Listar()
        {
            dtListado = BLL.BLLTerritorios.ListarTerritorios("");
            dgTerritorios.DataSource = dtListado;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //BOTON NUEVO, LIMPIA LAS CASILLAS.
        private void butNuevo_Click(object sender, EventArgs e)
        {
            Limpiarcontroles();
        }
        public void Limpiarcontroles()
        {
            txtTerritorioID.Text = "";
            txtDescripcionTerritorio.Text = "";
            txtRegionID.Text = "";          
        }
        // BOTON DE EDITAR
        private void butEditar_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            Entidades.Territorios Territorio = new Entidades.Territorios();
            Territorio.TerritoryID = Convert.ToInt32(txtTerritorioID.Text);
            Territorio.TerritoryDescription = txtDescripcionTerritorio.Text;
            Territorio.RegionID = Convert.ToInt32(txtRegionID.Text);
          

            resultado = BLL.BLLTerritorios.EditarTerritorios(Territorio);
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
        //BOTON ELIMINAR
        private void butELiminar_Click(object sender, EventArgs e)
        {

            bool resultado = false;
            resultado = BLL.BLLTerritorios.EliminaTerritorios(Convert.ToInt32(txtTerritorioID.Text));
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
        
        //BOTON GUARDAR
        private void butGuardar_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            Entidades.Territorios Territorio = new Entidades.Territorios();
            //Territorio.TerritoryID = Convert.ToInt32(txtTerritorioID.Text);
            Territorio.TerritoryDescription = txtDescripcionTerritorio.Text;
            Territorio.RegionID = Convert.ToInt32(txtRegionID.Text);
            

            resultado = BLL.BLLTerritorios.InsertarTerritorios(Territorio);
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

   
        private void dgTerritorios_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Limpiarcontroles();
            int RowNo;
            RowNo = e.RowIndex;
            txtTerritorioID.Text = dgTerritorios.Rows[RowNo].Cells[0].Value.ToString();
            txtDescripcionTerritorio.Text = dgTerritorios.Rows[RowNo].Cells[1].Value.ToString();
            txtRegionID.Text = dgTerritorios.Rows[RowNo].Cells[2].Value.ToString();
        }

        private void Territorios_Load_1(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
