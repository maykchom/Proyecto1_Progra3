﻿namespace CapaUI
{
    partial class Ordenes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEmpleado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFeReque = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFeEnvi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbShipper = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbShipName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbShipAddress = new System.Windows.Forms.TextBox();
            this.tbShipCity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbRegDes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCodPosDes = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPaisDes = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbDescuento = new System.Windows.Forms.TextBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvOrden = new System.Windows.Forms.DataGridView();
            this.btOrdenar = new System.Windows.Forms.Button();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrden)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbHeight);
            this.groupBox1.Controls.Add(this.tbPaisDes);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tbCodPosDes);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbRegDes);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbShipCity);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbShipAddress);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbShipName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbShipper);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpFeEnvi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpFeReque);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbEmpleado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1012, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de orden";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // cbCliente
            // 
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(10, 51);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(121, 24);
            this.cbCliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empleado";
            // 
            // cbEmpleado
            // 
            this.cbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpleado.FormattingEnabled = true;
            this.cbEmpleado.Location = new System.Drawing.Point(166, 51);
            this.cbEmpleado.Name = "cbEmpleado";
            this.cbEmpleado.Size = new System.Drawing.Size(121, 24);
            this.cbEmpleado.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha requerida";
            // 
            // dtpFeReque
            // 
            this.dtpFeReque.Location = new System.Drawing.Point(313, 54);
            this.dtpFeReque.Name = "dtpFeReque";
            this.dtpFeReque.Size = new System.Drawing.Size(200, 21);
            this.dtpFeReque.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de envio";
            // 
            // dtpFeEnvi
            // 
            this.dtpFeEnvi.Location = new System.Drawing.Point(550, 55);
            this.dtpFeEnvi.Name = "dtpFeEnvi";
            this.dtpFeEnvi.Size = new System.Drawing.Size(200, 21);
            this.dtpFeEnvi.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(776, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Expendedor";
            // 
            // cbShipper
            // 
            this.cbShipper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShipper.FormattingEnabled = true;
            this.cbShipper.Location = new System.Drawing.Point(779, 55);
            this.cbShipper.Name = "cbShipper";
            this.cbShipper.Size = new System.Drawing.Size(121, 24);
            this.cbShipper.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Peso de envío";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nombre de envío";
            // 
            // tbShipName
            // 
            this.tbShipName.Location = new System.Drawing.Point(166, 123);
            this.tbShipName.Name = "tbShipName";
            this.tbShipName.Size = new System.Drawing.Size(121, 21);
            this.tbShipName.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(310, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Dirección de envio";
            // 
            // tbShipAddress
            // 
            this.tbShipAddress.Location = new System.Drawing.Point(313, 123);
            this.tbShipAddress.Name = "tbShipAddress";
            this.tbShipAddress.Size = new System.Drawing.Size(121, 21);
            this.tbShipAddress.TabIndex = 15;
            // 
            // tbShipCity
            // 
            this.tbShipCity.Location = new System.Drawing.Point(464, 123);
            this.tbShipCity.Name = "tbShipCity";
            this.tbShipCity.Size = new System.Drawing.Size(121, 21);
            this.tbShipCity.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(461, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Cuidad destino";
            // 
            // tbRegDes
            // 
            this.tbRegDes.Location = new System.Drawing.Point(605, 123);
            this.tbRegDes.Name = "tbRegDes";
            this.tbRegDes.Size = new System.Drawing.Size(121, 21);
            this.tbRegDes.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(602, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Región destino";
            // 
            // tbCodPosDes
            // 
            this.tbCodPosDes.Location = new System.Drawing.Point(745, 123);
            this.tbCodPosDes.Name = "tbCodPosDes";
            this.tbCodPosDes.Size = new System.Drawing.Size(121, 21);
            this.tbCodPosDes.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(742, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Cod. Pos. destino";
            // 
            // tbPaisDes
            // 
            this.tbPaisDes.Location = new System.Drawing.Point(885, 123);
            this.tbPaisDes.Name = "tbPaisDes";
            this.tbPaisDes.Size = new System.Drawing.Size(121, 21);
            this.tbPaisDes.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(882, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "País destino";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btAgregar);
            this.groupBox2.Controls.Add(this.tbDescuento);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.tbCantidad);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.dgvProductos);
            this.groupBox2.Location = new System.Drawing.Point(13, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 579);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selección de productos";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(21, 41);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(292, 519);
            this.dgvProductos.TabIndex = 1;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(319, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 16);
            this.label14.TabIndex = 2;
            this.label14.Text = "Cantidad";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(322, 61);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(100, 21);
            this.tbCantidad.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(319, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 16);
            this.label15.TabIndex = 4;
            this.label15.Text = "Descuento";
            // 
            // tbDescuento
            // 
            this.tbDescuento.Location = new System.Drawing.Point(322, 122);
            this.tbDescuento.Name = "tbDescuento";
            this.tbDescuento.Size = new System.Drawing.Size(100, 21);
            this.tbDescuento.TabIndex = 5;
            this.tbDescuento.Text = "0";
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(322, 175);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(100, 23);
            this.btAgregar.TabIndex = 6;
            this.btAgregar.Text = "Agregar ";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btOrdenar);
            this.groupBox3.Controls.Add(this.dgvOrden);
            this.groupBox3.Location = new System.Drawing.Point(453, 195);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(686, 579);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle de orden";
            // 
            // dgvOrden
            // 
            this.dgvOrden.AllowUserToAddRows = false;
            this.dgvOrden.AllowUserToDeleteRows = false;
            this.dgvOrden.AllowUserToResizeColumns = false;
            this.dgvOrden.AllowUserToResizeRows = false;
            this.dgvOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvOrden.Location = new System.Drawing.Point(23, 41);
            this.dgvOrden.Name = "dgvOrden";
            this.dgvOrden.ReadOnly = true;
            this.dgvOrden.Size = new System.Drawing.Size(549, 519);
            this.dgvOrden.TabIndex = 0;
            // 
            // btOrdenar
            // 
            this.btOrdenar.Location = new System.Drawing.Point(594, 537);
            this.btOrdenar.Name = "btOrdenar";
            this.btOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btOrdenar.TabIndex = 1;
            this.btOrdenar.Text = "Ordenar";
            this.btOrdenar.UseVisualStyleBackColor = true;
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(10, 123);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(121, 21);
            this.tbHeight.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(1033, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(106, 174);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bitácora";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ver ordenes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "IDPro";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Producto";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Cantidad";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "Descuento";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1151, 786);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ordenes";
            this.Text = "Ordenes";
            this.Load += new System.EventHandler(this.Ordenes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrden)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFeEnvi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFeReque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRegDes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbShipCity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbShipAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbShipName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbShipper;
        private System.Windows.Forms.TextBox tbPaisDes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbCodPosDes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.TextBox tbDescuento;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btOrdenar;
        private System.Windows.Forms.DataGridView dgvOrden;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}