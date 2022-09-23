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
    public partial class Employeess : Form
    {
        private DataTable dataEmpl;
        string nombre;
        public Employeess()
        {
            InitializeComponent();
        }

        // Evento de carga del formulario, ejecuta el método de Listar que muestra los Employeess
        private void Employeess_Load(object sender, EventArgs e)
        {
            cargarEmployees();
            txLNam.Focus();
        }

        // El método Cargar obtiene la data de la base de datos y la muestra através de una data grid view
        public void cargarEmployees()
        {
            dataEmpl = BLLEmployees.ListarEmployees("");
            dgEmpl.DataSource = dataEmpl;
        }

        /// <summary>
        /// Evento click del botón de Guardar.
        /// Realiza la acción de agregar un registro de employeess.
        /// Ejecuta el método de InsertaEmployees con los parámetros previamente asigandos a la clase employeess
        /// Verifica si la transacción fué exitosa para mostrar el mensaje correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btGuardar_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            Employees employees = new Employees();
            //employees.EmployeeID = Convert.ToInt32(txEmpID.Text);
            employees.LastName = txLNam.Text.ToString();
            employees.FirstName = txFsNam.Text.ToString();
            employees.Title = txTitle.Text.ToString();
            employees.TitleOfCourtesy = txTitCourt.Text.ToString();
            employees.BirthDate = Convert.ToDateTime(dtpBirth.Text);
            employees.HireDate = Convert.ToDateTime(dtpHire.Text);
            employees.Address = txAddress.Text.ToString();
            employees.City = txCity.Text.ToString();
            employees.Region = txRegion.Text.ToString();
            employees.PostalCode = txPCode.Text.ToString();
            employees.Country = txCountry.Text.ToString();
            employees.HomePhone = txHPhone.Text.ToString();
            employees.Extension = txExtens.Text.ToString();
            employees.Notes = txNots.Text.ToString();
            employees.ReportsTo = Convert.ToInt32(txReports.Text);
            //employees.ReportsTo = 2;
            employees.PhotoPath = txPhotPath.Text.ToString();
            employees.Salary = Convert.ToDecimal(txSalary.Text);
            MemoryStream ms = new MemoryStream();
            Image photo = Image.FromFile(nombre);
            photo.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            employees.Photo = (ms.ToArray());
            resultado = BLL.BLLEmployees.InsertaEmployees(employees);
            if (resultado)
            {
                MessageBox.Show("Registro ingresado correctamente");
                Limpiarcontroles();
                cargarEmployees();
                dgEmpl.FirstDisplayedScrollingRowIndex = dgEmpl.RowCount - 1;
            }
            else
            {
                MessageBox.Show("No se pudo ingresar el registro");
            }
        }

        // El evento Limpiarcontroles borra el texto ingresado en los TextBox para un posterior ingreso de datos.
        
        private void Limpiarcontroles()
        {
            txEmpID.Clear();
            txLNam.Clear();
            txFsNam.Clear();
            txTitle.Clear();
            txTitCourt.Clear();
            dtpBirth.Value = Convert.ToDateTime(DateTime.Now);
            dtpHire.Value = Convert.ToDateTime(DateTime.Now);
            txAddress.Clear();
            txCity.Clear();
            txRegion.Clear();
            txPCode.Clear();
            txCountry.Clear();
            txHPhone.Clear();
            txExtens.Clear();
            txNots.Clear();
            txReports.Clear();
            txPhotPath.Clear();
            txSalary.Clear();
            txEmpID.Focus();
            txLNam.Focus();
        }

        /// <summary>
        /// Evento click del botón SelectPho.
        /// Realiza la acción de agregar una imagen al registro de employeess.
        /// Verifica si la transacción fué exitosa para mostrar el mensaje correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSelectPho_Click(object sender, EventArgs e)
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
                    pbPhoto.Image = new Bitmap(openFileDialog1.FileName);
                }
                catch (IOException)
                {

                    throw;
                }

            }
        }

        /// <summary>
        /// Evento click del botón de eliminar.
        /// Realiza la acción de eliminar un registro de employees.
        /// Ejecuta el método de EliminarEmployees con el ID del Employeess como parámetro
        /// Verifica si la transacción fué exitosa para mostrar el mensaje correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEliminar_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            Employees em = new Employees();
            em.EmployeeID = Convert.ToInt32(txEmpID.Text);
            resultado = BLL.BLLEmployees.EliminarEmployees(em);
            if (resultado)
            {
                MessageBox.Show("Registro Eliminado correctamente");
                Limpiarcontroles();
                cargarEmployees();
            }
            else
            {
                MessageBox.Show("No se pudo Eliminar el registro");
            }

        }

        /// <summary>
        /// evento que se acciona al hacer click en una celda del dgCatEmpl para obtener los datos deseados en los tx
        /// con el fin de aplicarle un mantenimiento posterior.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgEmpl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                panelEE.Enabled = true;
                Limpiarcontroles();

                int RowNo;
                RowNo = e.RowIndex;
                txEmpID.Text = dgEmpl.Rows[RowNo].Cells[0].Value.ToString();
                txLNam.Text = dgEmpl.Rows[RowNo].Cells[1].Value.ToString();
                txFsNam.Text = dgEmpl.Rows[RowNo].Cells[2].Value.ToString();
                txTitle.Text = dgEmpl.Rows[RowNo].Cells[3].Value.ToString();
                txTitCourt.Text = dgEmpl.Rows[RowNo].Cells[4].Value.ToString();
                dtpBirth.Text = dgEmpl.Rows[RowNo].Cells[5].Value.ToString();
                dtpHire.Text = dgEmpl.Rows[RowNo].Cells[6].Value.ToString();
                txAddress.Text = dgEmpl.Rows[RowNo].Cells[7].Value.ToString();
                txCity.Text = dgEmpl.Rows[RowNo].Cells[8].Value.ToString();
                txRegion.Text = dgEmpl.Rows[RowNo].Cells[9].Value.ToString();
                txPCode.Text = dgEmpl.Rows[RowNo].Cells[10].Value.ToString();
                txCountry.Text = dgEmpl.Rows[RowNo].Cells[11].Value.ToString();
                txHPhone.Text = dgEmpl.Rows[RowNo].Cells[12].Value.ToString();
                txExtens.Text = dgEmpl.Rows[RowNo].Cells[13].Value.ToString();
                txNots.Text = dgEmpl.Rows[RowNo].Cells[15].Value.ToString();
                txReports.Text = dgEmpl.Rows[RowNo].Cells[16].Value.ToString();
                txPhotPath.Text = dgEmpl.Rows[RowNo].Cells[17].Value.ToString();
                txSalary.Text = dgEmpl.Rows[RowNo].Cells[18].Value.ToString();


                //Verificamos si el registro de la imagen es nulo para evitar errores en el picture box
                if (dgEmpl.Rows[RowNo].Cells[14].Value != DBNull.Value)
                {
                   pbPhoto.Image = (Bitmap)((new ImageConverter()).ConvertFrom(dgEmpl.Rows[RowNo].Cells[14].Value));
                }
                else
                {
                    pbPhoto.Image = null;
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Limpiarcontroles();
                panelEE.Enabled = false;
                pbPhoto.Image = null;
            }
            
        }

        /// <summary>
        /// Evento click del botón editar.
        /// Realiza la función de editar un registro de employeess.
        /// Ejecuta método de EditarEmployees con los parámetros previamente asigandos a la clase de employeess
        /// Verifica si la transacción resultó exitosa para mostrar un mensaje correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEditar_Click(object sender, EventArgs e)
        {

            bool resultado = false;
            Employees employees = new Employees();
            employees.EmployeeID = Convert.ToInt32(txEmpID.Text);
            employees.LastName = txLNam.Text.ToString();
            employees.FirstName = txFsNam.Text.ToString();
            employees.Title = txTitle.Text.ToString();
            employees.TitleOfCourtesy = txTitCourt.Text.ToString();
            employees.BirthDate = Convert.ToDateTime(dtpBirth.Text);
            employees.HireDate = Convert.ToDateTime(dtpHire.Text);
            employees.Address = txAddress.Text.ToString();
            employees.City = txCity.Text.ToString();
            employees.Region = txRegion.Text.ToString();
            employees.PostalCode = txPCode.Text.ToString();
            employees.Country = txCountry.Text.ToString();
            employees.HomePhone = txHPhone.Text.ToString();
            employees.Extension = txExtens.Text.ToString();
            employees.Notes = txNots.Text.ToString();
            employees.ReportsTo = Convert.ToInt32(txReports.Text);
            employees.PhotoPath = txPhotPath.Text.ToString();
            employees.Salary = Convert.ToDecimal(txSalary.Text);
            MemoryStream ms = new MemoryStream();
            Image photo = Image.FromFile(nombre);
            photo.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            employees.Photo = (ms.ToArray());
            resultado = BLL.BLLEmployees.EditarEmployees(employees);
            if (resultado)
            {
                MessageBox.Show("Registro editado correctamente");
                Limpiarcontroles();
                cargarEmployees();
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
        private void btNuevo_Click(object sender, EventArgs e)
        {
            Limpiarcontroles();
            panelEE.Enabled = false;
            pbPhoto.Image = null;
        }

        //En el txtbox de LastName solo permite el ingreso de letras
        private void txLNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }
        //En el txtbox de FirstName solo permite el ingreso de letras
        private void txFsNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }
        //En el txtbox de Title solo permite el ingreso de letras
        private void txTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }
        //En el txtbox de Region solo permite el ingreso de letras
        private void txRegion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }
        //En el txtbox de Country solo permite el ingreso de letras
        private void txCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }
        //En el txtbox de Extension solo permite el ingreso de numeros enteros
        private void txExtens_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }
        //En el txtbox de Salary permite el ingreso de numeros enteros con decimal
        private void txSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        //En el txtbox de Reports solo permite el ingreso de numeros enteros
        private void txReports_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }
    }
}
