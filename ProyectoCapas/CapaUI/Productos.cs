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
    public partial class Productos : Form
    {
        private DataTable dtListado;
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void Listar()
        {
            dtListado = BLL.BLLProductos.ListarProductos("");
            dgPro.DataSource = dtListado;

        }
        public void Limpiarcontroles()
        {
            txProduct.Text = "";
            txproName.Text = "";
            txSupplier.Text = "";
            txCategory.Text = "";
            txQuantity.Text = "";
            txUnitPrice.Text = "";
            txunitInstock.Text = "";
            txUnitonOrder.Text = "";
           txRecorder.Text = "";
            txDiscontinued.Text = "";

        }
        private void BtGuardar_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            Entidades.Productos Productos = new Entidades.Productos();
            Productos.ProductID = Convert.ToInt32(txProduct.Text);
            Productos.ProductName = txproName.Text;
            Productos.SupplierID = Convert.ToInt32(txSupplier.Text);
            Productos.CategoryID = Convert.ToInt32(txCategory.Text);
            Productos.QuantityPerUnit = Convert.ToInt32(txQuantity.Text);
            Productos.UnitPrice = Convert.ToInt32(txUnitPrice.Text);
            Productos.UnitsInStock = Convert.ToInt32(txunitInstock.Text);
            Productos.UnitsonOrder = Convert.ToInt32(txUnitonOrder.Text);
            Productos.RecorderLevel = Convert.ToInt32(txRecorder.Text);
            Productos.Discontinued = Convert.ToInt32(txDiscontinued.Text);

            resultado = BLL.BLLProductos.InsertarProducto(Productos);
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

        private void BtNuevo_Click(object sender, EventArgs e)
        {
            Limpiarcontroles();
        }

        private void BtEditar_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            Entidades.Productos productos = new Entidades.Productos();
            productos.ProductID = Convert.ToInt32(txProduct.Text);
            productos.ProductName = txproName.Text;
            productos.SupplierID = Convert.ToInt32(txSupplier.Text);
            productos.CategoryID = Convert.ToInt32(txCategory.Text);
            productos.QuantityPerUnit = Convert.ToInt32(txQuantity.Text);
            productos.UnitPrice = Convert.ToInt32(txUnitPrice.Text);
            productos.UnitsInStock = Convert.ToInt32(txunitInstock.Text);
            productos.UnitsonOrder = Convert.ToInt32(txUnitonOrder.Text);
            productos.RecorderLevel = Convert.ToInt32(txRecorder.Text);
            productos.Discontinued = Convert.ToInt32(txDiscontinued.Text);


            resultado = BLL.BLLProductos.EditarProducto(productos);
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

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            bool resultado = false;


            resultado = BLL.BLLProductos.EliminaProductos(Convert.ToInt32(txProduct.Text));
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
    }
}
