using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUI
{
    public partial class Shipper : Form
    {
        private DataTable dtListado;
        string nombre;
        
        public Shipper()
        {
            InitializeComponent();
        }

        private void Shipper_Load(object sender, EventArgs e)
        {
            cargarShipper();
        }
        
        public void cargarShipper()
        {
            dtListado = BLL.BLLShipper.ListarShipper("");
            dgShipper.DataSource = dtListado;
        }
        public void Limpiarcontroles()
        {
            txCompany.Text = "";
            txphone.Text = "";
        }
       
        private void btNuevo_Click(object sender, EventArgs e)
        {
            Limpiarcontroles();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {

            bool resultado = false;
            Entidades.Shipper shipper = new Entidades.Shipper();
           // shipper.ShipperID = Convert.ToInt32(txShipper.Text);
            shipper.CompanyName = txCompany.Text;
            shipper.Phone = txphone.Text;


            resultado = BLL.BLLShipper.InsertarShipperSP(shipper);
            if (resultado)
            {
                MessageBox.Show("Registro ingresado correctamente");
                cargarShipper();

                Limpiarcontroles();
           
            }
            else
            {
                MessageBox.Show("No se pudo ingresar el registro");

            }
        }

        private void dgShipper_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Limpiarcontroles();
            int RowNo;
            RowNo = e.RowIndex;
            txShipper.Text = dgShipper.Rows[RowNo].Cells[0].Value.ToString();
            txCompany.Text = dgShipper.Rows[RowNo].Cells[1].Value.ToString();
            txphone.Text = dgShipper.Rows[RowNo].Cells[2].Value.ToString();
            
           
        }
    }
    
}
