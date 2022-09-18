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
    public partial class menu : Form
    {
        private Form formularioHijoActual;
        private Button botonActual;
        public menu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo que recibe como parámetro el formulario que se desea mostrar
        /// al realizar el llamda se asigna como formlario actual
        /// se le aplican algunos estilos al formulario
        /// se asigna al panel que mostrará le formulario
        /// </summary>
        /// <param name="formularioHijo"></param>
        private void abrirFormularioHijo(Form formularioHijo)
        {

            formularioHijoActual = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelItem.Controls.Add(formularioHijo);
            panelItem.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        /// <summary>
        /// Método que resalta graficamente el botón seleccionado
        /// Antes que nada se verifica que no sea nulo
        /// Luego se desactivan los efectos aplicados a botones previos
        /// Se aplican colores, alineaciones y estilos al botón.
        /// </summary>
        /// <param name="botonRemitente"></param>
        private void activarBoton(object botonRemitente)
        {
            if (botonRemitente != null)
            {
                desactivarBoton();

                botonActual = (Button)botonRemitente;
                botonActual.BackColor = Color.LightSlateGray;
                botonActual.ForeColor = Color.White;
                botonActual.Font = new System.Drawing.Font(botonActual.Font, FontStyle.Bold);
                botonActual.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        /// <summary>
        /// Metodo que reestablece el estilo a los botones a como 
        /// cuando no estan seleccionados
        /// Se le cambian colores y alineción.
        /// </summary>
        private void desactivarBoton()
        {
            btCategoria.BackColor = Color.White;
            btCategoria.ForeColor = Color.Black;
            btCategoria.TextAlign = ContentAlignment.MiddleLeft;
            btCategoria.Font = new System.Drawing.Font(btCategoria.Font, FontStyle.Regular);

            btProveedor.BackColor = Color.White;
            btProveedor.ForeColor = Color.Black;
            btProveedor.TextAlign = ContentAlignment.MiddleLeft;
            btProveedor.Font = new System.Drawing.Font(btProveedor.Font, FontStyle.Regular);

            btTerritorios.BackColor = Color.White;
            btTerritorios.ForeColor = Color.Black;
            btTerritorios.TextAlign = ContentAlignment.MiddleLeft;
            btTerritorios.Font = new System.Drawing.Font(btTerritorios.Font, FontStyle.Regular);

            btCustomers.BackColor = Color.White;
            btCustomers.ForeColor = Color.Black;
            btCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btCustomers.Font = new System.Drawing.Font(btCustomers.Font, FontStyle.Regular);

            btEmployees.BackColor = Color.White;
            btEmployees.ForeColor = Color.Black;
            btEmployees.TextAlign = ContentAlignment.MiddleLeft;
            btEmployees.Font = new System.Drawing.Font(btEmployees.Font, FontStyle.Regular);

            btProducto.BackColor = Color.White;
            btProducto.ForeColor = Color.Black;
            btProducto.TextAlign = ContentAlignment.MiddleLeft;
            btProducto.Font = new System.Drawing.Font(btProducto.Font, FontStyle.Regular);

            btRegion.BackColor = Color.White;
            btRegion.ForeColor = Color.Black;
            btRegion.TextAlign = ContentAlignment.MiddleLeft;
            btRegion.Font = new System.Drawing.Font(btRegion.Font, FontStyle.Regular);

            btExpendedores.BackColor = Color.White;
            btExpendedores.ForeColor = Color.Black;
            btExpendedores.TextAlign = ContentAlignment.MiddleLeft;
            btExpendedores.Font = new System.Drawing.Font(btExpendedores.Font, FontStyle.Regular);

            btOrdenes.BackColor = Color.White;
            btOrdenes.ForeColor = Color.Black;
            btOrdenes.TextAlign = ContentAlignment.MiddleLeft;
            btOrdenes.Font = new System.Drawing.Font(btOrdenes.Font, FontStyle.Regular);

            btCreditos.BackColor = Color.White;
            btCreditos.ForeColor = Color.FromName("Desktop");
            btCreditos.TextAlign = ContentAlignment.MiddleCenter;
            btCreditos.Font = new System.Drawing.Font(btCreditos.Font, FontStyle.Regular);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Categorias cat = new Categorias();
            //cat.ShowDialog();
            //this.Hide();
            activarBoton(sender);
            abrirFormularioHijo(new Categorias());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Proveedores pro = new Proveedores();
            //pro.ShowDialog();

            activarBoton(sender);
            abrirFormularioHijo(new Proveedores());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            activarBoton(sender);
            abrirFormularioHijo(new Productos());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            activarBoton(sender);
            abrirFormularioHijo(new Form1());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            activarBoton(sender);
            abrirFormularioHijo(new Territorios());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            activarBoton(sender);
            abrirFormularioHijo(new Shipper());
        }

        private void btCustomers_Click(object sender, EventArgs e)
        {
            //Clientes abrir = new Clientes();
            //abrir.ShowDialog();
            activarBoton(sender);
            abrirFormularioHijo(new Clientes());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            activarBoton(sender);
            abrirFormularioHijo(new verOrdenes());
        }

        private void pbCustomers_Click(object sender, EventArgs e)
        {
            Clientes abrir = new Clientes();
            abrir.ShowDialog();
        }

        private void btEmployees_Click(object sender, EventArgs e)
        {
            //Employeess abrir = new Employeess();
            //abrir.ShowDialog();
            activarBoton(sender);
            abrirFormularioHijo(new Employeess());
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            activarBoton(sender);
            abrirFormularioHijo(new Creditos());
        }
    }
}
