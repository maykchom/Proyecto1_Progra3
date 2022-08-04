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
    public partial class Categorias : Form
    {
        private DataTable dataCat;
        public Categorias()
        {
            InitializeComponent();
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            cargarCategorias();
        }

        public void cargarCategorias()
        {
            dataCat = BLL.BLLCategorias.ListarCategorias("");
            dgCat.DataSource = dataCat;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            categorias categorias = new categorias();
            categorias.CategoriaID = Convert.ToInt32(tbCatID.Text);
            categorias.CategoryName = tbNombre.Text.ToString();
            categorias.Description = tbDescri.Text.ToString();
            resultado = BLL.BLLCategorias.InsertarCategorias(categorias);
            if (resultado)
            {
                MessageBox.Show("Registro ingresado correctamente");
                Limpiarcontroles();
                cargarCategorias();
            }
            else
            {
                MessageBox.Show("No se pudo ingresar el registro");
            }
        }

        private void Limpiarcontroles()
        {
            tbCatID.Clear();
            tbNombre.Clear();
            tbDescri.Clear();
            tbCatID.Focus();
        }
    }
}
