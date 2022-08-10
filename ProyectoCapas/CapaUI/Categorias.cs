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
        /// Evento de carga del formulario, ejecuta el método de Listar que muestra las categorias
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Categorias_Load(object sender, EventArgs e)
        {
            cargarCategorias();
        }

        /// <summary>
        /// El método Listar obtiene la data de la base de datos y la muestra através de una data grid view
        /// </summary>
        public void cargarCategorias()
        {
            dataCat = BLL.BLLCategorias.ListarCategorias("");
            dgCat.DataSource = dataCat;
        }

        /// <summary>
        /// Evento click del botón editar.
        /// Realiza la función de agregar un registro a las regiones.
        /// Implementa una instancia de la clase regiones para la asignación de atributos (RegionID y RegionDescripcion)
        /// Ejecuta método de InsertarRegiones con los parámetros previamente asigandos a la clase Regiones
        /// Verifica si la transacción resultó exitosa para mostrar un mensaje correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
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
            resultado = BLL.BLLCategorias.InsertarCategoriasFotos(categorias);
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
        /// El evento Limpiarcontroles borra el texto ingresado en los TextBox de regionID y regionDescription para un posterior ingreso de datos
        /// </summary>
        private void Limpiarcontroles()
        {
            tbCatID.Clear();
            tbNombre.Clear();
            tbDescri.Clear();
            tbCatID.Focus();
        }


        /// <summary>
        /// Evento Click del botón seleccionar imagen
        /// Se utilza la herrmaienta "OpenFileDialog" que nos permite abrir el explotador de archivos y seleccionar una imagen
        /// Se almacena el nombre de la imagen en una variable global
        /// Se muestra la imagen seleccionada en un PictureBox
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
        /// Realiza la acción de eliminar un registro de catergorias.
        /// Ejecuta el método de EliminarCategorias con el ID de la categoria como parámetro
        /// Verifica si la transacción fué exitosa para mostrar el mensaje correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            resultado = BLL.BLLCategorias.EliminarCategoria(Convert.ToInt32(tbCatID .Text));
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
        /// Evento click del botón editar.
        /// Realiza la función de modificar un registro de las categorias.
        /// Implementa una instancia de la clase categorias para la asignación de atributos
        /// Ejecuta método de EditarCategorias con los parámetros previamente asigandos a la clase Categorias
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
        /// Evento que se acciona al hacer click en una celda del data grid view.
        /// Obtiene la coordenada de la fila y columna de la celda para obtener los datos deseados con el fin de aplicarle un mantenimiento posterior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgCat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowNo;
            RowNo = e.RowIndex;
            tbCatID.Text = dgCat.Rows[RowNo].Cells[0].Value.ToString();
            tbNombre.Text = dgCat.Rows[RowNo].Cells[1].Value.ToString();
            tbDescri.Text = dgCat.Rows[RowNo].Cells[2].Value.ToString();
            pbImagen.Image = (Bitmap)((new ImageConverter()).ConvertFrom(dgCat.Rows[RowNo].Cells[3].Value));
        }
    }
}
