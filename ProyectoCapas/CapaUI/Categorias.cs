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
using System.IO;

namespace CapaUI
{
    public partial class Categorias : Form
    {
        private DataTable dataCat;
        string nombre;
        public Categorias()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evento de carga del formulario, ejecuta el método de Listar que muestra las cataegorias
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Categorias_Load(object sender, EventArgs e)
        {
            cargarCategorias();
            tbNombre.Focus();
        }

        /// <summary>
        /// El método Cargar obtiene la data de la base de datos y la muestra através de una data grid view
        /// </summary>
        public void cargarCategorias()
        {
            dataCat = BLL.BLLCategorias.ListarCategorias("");
            dgCat.DataSource = dataCat;
        }

        /// <summary>
        /// Evento click del botón de Guardar.
        /// Realiza la acción de agregar un registro de categorias.
        /// Ejecuta el método de InsertarCategoriasSP con los parámetros previamente asigandos a la clase categorias
        /// Verifica si la transacción fué exitosa para mostrar el mensaje correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            categorias categorias = new categorias();
            //categorias.CategoriaID = Convert.ToInt32(tbCatID.Text);
            categorias.CategoryName = tbNombre.Text.ToString();
            categorias.Description = tbDescri.Text.ToString();
            MemoryStream ms = new MemoryStream();
            Image image = Image.FromFile(nombre);
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            categorias.Picture = (ms.ToArray());
            resultado = BLL.BLLCategorias.InsertarCategoriasSP(categorias);
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

        /// <summary>
        /// El evento Limpiarcontroles borra el texto ingresado en los TextBox para un posterior ingreso de datos
        /// </summary>
        private void Limpiarcontroles()
        {
            tbCatID.Clear();
            tbNombre.Clear();
            tbDescri.Clear();
            tbCatID.Focus();
            pbImagen.Image = null;
            tbNombre.Focus();
        }
        /// <summary>
        /// Evento click del botón btnImg_Click.
        /// Realiza la acción de agregar una imagen al registro de categorias.
        /// Verifica si la transacción fué exitosa para mostrar el mensaje correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImg_Click(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                nombre = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                    pbImagen.Image = new Bitmap(openFileDialog1.FileName);
                }
                catch (IOException)
                {

                    throw;
                }

            }
        }
        /// <summary>
        /// Evento click del botón de eliminar.
        /// Realiza la acción de eliminar un registro de categorias.
        /// Ejecuta el método de EliminarCategorias con el ID del Categoria como parámetro
        /// Verifica si la transacción fué exitosa para mostrar el mensaje correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            resultado = BLL.BLLCategorias.EliminarCategoria(Convert.ToInt32(tbCatID.Text));
            if (resultado)
            {
                MessageBox.Show("Registro Eliminado correctamente");
                Limpiarcontroles();
                cargarCategorias();
            }
            else
            {
                MessageBox.Show("No se pudo Eliminar el registro");
            }
        }

        /// <summary>
        /// evento que se acciona al hacer click en una celda del dgCat
        /// Obtiene la coordenada de la fila y columna de la celda para obtener los datos deseados 
        /// con el fin de aplicarle un mantenimiento posterior.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgCat_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                panelEE.Enabled = true;
                int RowNo;
                RowNo = e.RowIndex;
                tbCatID.Text = dgCat.Rows[RowNo].Cells[0].Value.ToString();
                tbNombre.Text = dgCat.Rows[RowNo].Cells[1].Value.ToString();
                tbDescri.Text = dgCat.Rows[RowNo].Cells[2].Value.ToString();

                //Verificamos si el registro de la imagen es nulo para evitar errores en el picture box
                if (dgCat.Rows[RowNo].Cells[3].Value != DBNull.Value)
                {
                    pbImagen.Image = (Bitmap)((new ImageConverter()).ConvertFrom(dgCat.Rows[RowNo].Cells[3].Value));
                }
                else
                {
                    pbImagen.Image = null;
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Limpiarcontroles();
                panelEE.Enabled =false;
            }
        }

        /// <summary>
        /// Evento click del botón editar.
        /// Realiza la función de editar un registro en las categorias.
        /// Ejecuta método de EditarCategoriasFotos con los parámetros previamente asigandos a la clase de categorias
        /// Verifica si la transacción resultó exitosa para mostrar un mensaje correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            categorias categorias = new categorias();
            categorias.CategoriaID = Convert.ToInt32(tbCatID.Text);
            categorias.CategoryName = tbNombre.Text.ToString();
            categorias.Description = tbDescri.Text.ToString();
            MemoryStream ms = new MemoryStream();
            Image image = Image.FromFile(nombre);
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            categorias.Picture = (ms.ToArray());
            resultado = BLL.BLLCategorias.EditarCategoriasFotos(categorias);
            if (resultado)
            {
                MessageBox.Show("Registro editado correctamente");
                Limpiarcontroles();
                cargarCategorias();
            }
            else
            {
                MessageBox.Show("No se pudo editar el registro");
            }
        }

        /// <summary>
        /// Evento click del botón nuevo.
        /// Realiza la función de limpiar los controles de categorias.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiarcontroles();
            panelEE.Enabled = false;
        }
        
        //En el txtbox permite solo el ingreso de letras
        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }
    }
}
