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
        private int supplierIDactual;
        public Productos()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evento de carga del formulario, ejecuta el método de Listar que muestra los productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Productos_Load(object sender, EventArgs e)
        {
            Listar();
            cargarSuppliers();
            cargarCategory();        }

        /// <summary>
        /// El método Listar obtiene la data de la base de datos y la muestra através de una data grid view
        /// </summary>
        private void Listar()
        {
            dtListado = BLL.BLLProductos.ListarProductos("");
            dgPro.DataSource = dtListado;

        }

        private void cargarSuppliers()
        {
            DataTable dtz = new DataTable();
            dtz.Clear();
            dtz = BLL.BLLProductos.ConsultaAbierta("SupplierID, CompanyName", "Suppliers");
            CbSupplier.DisplayMember = "CompanyName";
            CbSupplier.ValueMember = "SupplierID";
            CbSupplier.DataSource = dtz;
        }
            private void cargarCategory()
            {
                DataTable dtz = new DataTable();
                dtz.Clear();
                dtz = BLL.BLLProductos.ConsultaAbierta("CategoryID, CategoryName", "Categories");
                CbCategory.DisplayMember = "CategoryName";
                CbCategory.ValueMember = "CategoryID";
                CbCategory.DataSource = dtz;
            }

            /// <summary>
            /// El evento Limpiarcontroles borra el texto ingresado en los TextBox para un posterior ingreso de datos
            /// </summary>
            public void Limpiarcontroles()
            {
                txProduct.Text = "";
                txproName.Text = "";
                txQuantity.Text = "";
                txUnitPrice.Text = "";
                txunitInstock.Text = "";
                txUnitonOrder.Text = "";
                txRecorder.Text = "";
                txDiscontinued.Text = "";

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
            private void BtGuardar_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            Entidades.Productos Productos = new Entidades.Productos();
            //Productos.ProductID = Convert.ToInt32(txProduct.Text);
            Productos.ProductName = txproName.Text;
            Productos.SupplierID = Convert.ToInt32(CbSupplier.SelectedValue);
            Productos.CategoryID = Convert.ToInt32(CbCategory.SelectedValue);
            Productos.QuantityPerUnit = Convert.ToString(txQuantity.Text);
            Productos.UnitPrice = Convert.ToDouble(txUnitPrice.Text);
            Productos.UnitsInStock = Convert.ToInt32(txunitInstock.Text);
            Productos.UnitsonOrder = Convert.ToInt32(txUnitonOrder.Text);
            Productos.RecorderLevel = Convert.ToInt32(txRecorder.Text);
            Productos.Discontinued = Convert.ToInt32(txDiscontinued.Text);

            resultado = BLL.BLLProductos.InsertarProductosSP(Productos);
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
        /// <summary>
        /// Evento de click del botón "Nuevo", ejecuta el método "Limpiarcontroles".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            productos.SupplierID = Convert.ToInt32(CbSupplier.SelectedValue);
            productos.CategoryID = Convert.ToInt32(CbCategory.SelectedValue);
            productos.QuantityPerUnit = Convert.ToString(txQuantity.Text);
            productos.UnitPrice = Convert.ToDouble(txUnitPrice.Text);
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
        /// <summary>
        /// Evento click del botón de eliminar.
        /// Realiza la acción de eliminar un registro de productos.
        /// Ejecuta el método de EliminarProductos con el ID del producto como parámetro
        /// Verifica si la transacción fué exitosa para mostrar el mensaje correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void dgPro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// Evento que se acciona al hacer click en una celda del data grid view.
        /// Obtiene la coordenada de la fila y columna de la celda para obtener los datos deseados con el fin de aplicarle un mantenimiento posterior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgPro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowNo;
            RowNo = e.RowIndex;
            Limpiarcontroles();

            //Obtener el ID de la suppliers
            DataTable tablaSup = new DataTable();
            string SupBus = dgPro.Rows[RowNo].Cells[2].Value.ToString();
            tablaSup = BLLProductos.ConsultaAbierta("SupplierID", "Suppliers where companyName = \""+SupBus+ "\"");            
            int SupID = Convert.ToInt32(tablaSup.Rows[0][0]);

            //Obtener el ID de la cateogoria
            DataTable tablaCat = new DataTable();
            string CatBus = dgPro.Rows[RowNo].Cells[3].Value.ToString();
            tablaCat = BLLProductos.ConsultaAbierta("CategoryID", "Categories where CategoryName = \"" + CatBus + "\"");
            int CatID = Convert.ToInt32(tablaCat.Rows[0][0]);

            //Asignar datos a componentes          
            txProduct.Text = dgPro.Rows[RowNo].Cells[0].Value.ToString();
            txproName.Text = dgPro.Rows[RowNo].Cells[1].Value.ToString();
            CbSupplier.SelectedValue = SupID;
            CbCategory.SelectedValue = CatID;
            //CbCategory.SelectedValue = 4;
            CbCategory.SelectedItem = "Pavlova, Ltd.";
            txQuantity.Text = dgPro.Rows[RowNo].Cells[4].Value.ToString();
            txUnitPrice.Text = dgPro.Rows[RowNo].Cells[5].Value.ToString();
            txunitInstock.Text = dgPro.Rows[RowNo].Cells[6].Value.ToString();
            txUnitonOrder.Text = dgPro.Rows[RowNo].Cells[7].Value.ToString();
            txRecorder.Text = dgPro.Rows[RowNo].Cells[8].Value.ToString();
            txDiscontinued.Text = dgPro.Rows[RowNo].Cells[9].Value.ToString();
        }

        public void obtenerIDSupplier(string valor)
        {
            BLL.BLLProductos.ConsultaAbierta("SupplierID", "CompanyName = " + valor);
        }
    }
}
