﻿using System;
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
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Categorias cat = new Categorias();
            cat.ShowDialog();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Proveedores pro = new Proveedores();
            pro.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Productos produc = new Productos();
            produc.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 reg = new Form1();
            reg.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            btCategoria.PerformClick();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            btProveedor.PerformClick();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            btProducto.PerformClick();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            btRegion.PerformClick();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Territorios pro = new Territorios();
            pro.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Shipper pro = new Shipper();
            pro.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Shipper pro = new Shipper();
            pro.ShowDialog();
        }

        private void btCustomers_Click(object sender, EventArgs e)
        {
            Clientes abrir = new Clientes();
            abrir.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            verOrdenes abrir = new verOrdenes();
            abrir.ShowDialog();
        }

        private void pbOrdenes_Click(object sender, EventArgs e)
        {
            verOrdenes abrir = new verOrdenes();
            abrir.ShowDialog();
        }

        private void pbCustomers_Click(object sender, EventArgs e)
        {
            Clientes abrir = new Clientes();
            abrir.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Territorios pro = new Territorios();
            pro.ShowDialog();
        }

        private void btEmployees_Click(object sender, EventArgs e)
        {
            Employeess abrir = new Employeess();
            abrir.ShowDialog();
        }

        private void pbEmployees_Click(object sender, EventArgs e)
        {
            Employeess abrir = new Employeess();
            abrir.ShowDialog();
        }
    }
}
