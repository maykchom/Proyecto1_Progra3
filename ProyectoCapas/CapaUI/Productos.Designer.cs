﻿namespace CapaUI
{
    partial class Productos
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
            this.dgPro = new System.Windows.Forms.DataGridView();
            this.txProduct = new System.Windows.Forms.TextBox();
            this.txproName = new System.Windows.Forms.TextBox();
            this.txQuantity = new System.Windows.Forms.TextBox();
            this.txUnitPrice = new System.Windows.Forms.TextBox();
            this.txunitInstock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txUnitonOrder = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txRecorder = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtNuevo = new System.Windows.Forms.Button();
            this.BtEditar = new System.Windows.Forms.Button();
            this.BtGuardar = new System.Windows.Forms.Button();
            this.BtEliminar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.CbSupplier = new System.Windows.Forms.ComboBox();
            this.CbCategory = new System.Windows.Forms.ComboBox();
            this.cbDescon = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelEE = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgPro)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelEE.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgPro
            // 
            this.dgPro.AllowUserToAddRows = false;
            this.dgPro.AllowUserToDeleteRows = false;
            this.dgPro.AllowUserToResizeColumns = false;
            this.dgPro.AllowUserToResizeRows = false;
            this.dgPro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPro.Location = new System.Drawing.Point(15, 206);
            this.dgPro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgPro.Name = "dgPro";
            this.dgPro.ReadOnly = true;
            this.dgPro.RowHeadersWidth = 51;
            this.dgPro.RowTemplate.Height = 24;
            this.dgPro.Size = new System.Drawing.Size(1163, 665);
            this.dgPro.TabIndex = 0;
            this.dgPro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPro_CellClick);
            this.dgPro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPro_CellContentClick);
            // 
            // txProduct
            // 
            this.txProduct.Enabled = false;
            this.txProduct.Location = new System.Drawing.Point(167, 36);
            this.txProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txProduct.Name = "txProduct";
            this.txProduct.Size = new System.Drawing.Size(153, 24);
            this.txProduct.TabIndex = 1;
            // 
            // txproName
            // 
            this.txproName.Location = new System.Drawing.Point(167, 76);
            this.txproName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txproName.MaxLength = 40;
            this.txproName.Name = "txproName";
            this.txproName.Size = new System.Drawing.Size(153, 24);
            this.txproName.TabIndex = 2;
            // 
            // txQuantity
            // 
            this.txQuantity.Location = new System.Drawing.Point(167, 190);
            this.txQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txQuantity.MaxLength = 20;
            this.txQuantity.Name = "txQuantity";
            this.txQuantity.Size = new System.Drawing.Size(153, 24);
            this.txQuantity.TabIndex = 5;
            // 
            // txUnitPrice
            // 
            this.txUnitPrice.Location = new System.Drawing.Point(167, 228);
            this.txUnitPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txUnitPrice.MaxLength = 10;
            this.txUnitPrice.Name = "txUnitPrice";
            this.txUnitPrice.Size = new System.Drawing.Size(153, 24);
            this.txUnitPrice.TabIndex = 6;
            this.txUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txUnitPrice_KeyPress);
            // 
            // txunitInstock
            // 
            this.txunitInstock.Location = new System.Drawing.Point(167, 265);
            this.txunitInstock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txunitInstock.MaxLength = 3;
            this.txunitInstock.Name = "txunitInstock";
            this.txunitInstock.Size = new System.Drawing.Size(153, 24);
            this.txunitInstock.TabIndex = 7;
            this.txunitInstock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txunitInstock_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "ProductID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "ProductName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Suppliers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "QuantityPerUnit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "UnitPrice";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "UnitsInStock";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "UnitsOnOrder";
            // 
            // txUnitonOrder
            // 
            this.txUnitonOrder.Location = new System.Drawing.Point(167, 303);
            this.txUnitonOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txUnitonOrder.MaxLength = 2;
            this.txUnitonOrder.Name = "txUnitonOrder";
            this.txUnitonOrder.Size = new System.Drawing.Size(153, 24);
            this.txUnitonOrder.TabIndex = 15;
            this.txUnitonOrder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txUnitonOrder_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "RecorderLevel";
            // 
            // txRecorder
            // 
            this.txRecorder.Location = new System.Drawing.Point(167, 337);
            this.txRecorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txRecorder.MaxLength = 2;
            this.txRecorder.Name = "txRecorder";
            this.txRecorder.Size = new System.Drawing.Size(153, 24);
            this.txRecorder.TabIndex = 17;
            this.txRecorder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txRecorder_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 375);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "Discontinued";
            // 
            // BtNuevo
            // 
            this.BtNuevo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtNuevo.Location = new System.Drawing.Point(1205, 721);
            this.BtNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtNuevo.Name = "BtNuevo";
            this.BtNuevo.Size = new System.Drawing.Size(133, 44);
            this.BtNuevo.TabIndex = 21;
            this.BtNuevo.Text = "Nuevo";
            this.BtNuevo.UseVisualStyleBackColor = true;
            this.BtNuevo.Click += new System.EventHandler(this.BtNuevo_Click);
            // 
            // BtEditar
            // 
            this.BtEditar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEditar.Location = new System.Drawing.Point(3, 2);
            this.BtEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtEditar.Name = "BtEditar";
            this.BtEditar.Size = new System.Drawing.Size(133, 44);
            this.BtEditar.TabIndex = 22;
            this.BtEditar.Text = "Editar";
            this.BtEditar.UseVisualStyleBackColor = true;
            this.BtEditar.Click += new System.EventHandler(this.BtEditar_Click);
            // 
            // BtGuardar
            // 
            this.BtGuardar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtGuardar.Location = new System.Drawing.Point(1368, 721);
            this.BtGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtGuardar.Name = "BtGuardar";
            this.BtGuardar.Size = new System.Drawing.Size(133, 44);
            this.BtGuardar.TabIndex = 23;
            this.BtGuardar.Text = "Guardar";
            this.BtGuardar.UseVisualStyleBackColor = true;
            this.BtGuardar.Click += new System.EventHandler(this.BtGuardar_Click);
            // 
            // BtEliminar
            // 
            this.BtEliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEliminar.Location = new System.Drawing.Point(165, 2);
            this.BtEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Size = new System.Drawing.Size(133, 44);
            this.BtEliminar.TabIndex = 24;
            this.BtEliminar.Text = "Eliminar";
            this.BtEliminar.UseVisualStyleBackColor = true;
            this.BtEliminar.Click += new System.EventHandler(this.BtEliminar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 80);
            this.label11.MaximumSize = new System.Drawing.Size(3000000, 500000);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(330, 61);
            this.label11.TabIndex = 25;
            this.label11.Text = "PRODUCTOS";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CbSupplier
            // 
            this.CbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbSupplier.FormattingEnabled = true;
            this.CbSupplier.Location = new System.Drawing.Point(167, 116);
            this.CbSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbSupplier.Name = "CbSupplier";
            this.CbSupplier.Size = new System.Drawing.Size(153, 27);
            this.CbSupplier.TabIndex = 26;
            // 
            // CbCategory
            // 
            this.CbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCategory.FormattingEnabled = true;
            this.CbCategory.Location = new System.Drawing.Point(167, 153);
            this.CbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbCategory.Name = "CbCategory";
            this.CbCategory.Size = new System.Drawing.Size(153, 27);
            this.CbCategory.TabIndex = 27;
            // 
            // cbDescon
            // 
            this.cbDescon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDescon.FormattingEnabled = true;
            this.cbDescon.Items.AddRange(new object[] {
            "Falso",
            "Verdadero"});
            this.cbDescon.Location = new System.Drawing.Point(167, 375);
            this.cbDescon.Margin = new System.Windows.Forms.Padding(4);
            this.cbDescon.Name = "cbDescon";
            this.cbDescon.Size = new System.Drawing.Size(153, 27);
            this.cbDescon.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDescon);
            this.groupBox1.Controls.Add(this.txProduct);
            this.groupBox1.Controls.Add(this.CbCategory);
            this.groupBox1.Controls.Add(this.txproName);
            this.groupBox1.Controls.Add(this.CbSupplier);
            this.groupBox1.Controls.Add(this.txQuantity);
            this.groupBox1.Controls.Add(this.txUnitPrice);
            this.groupBox1.Controls.Add(this.txunitInstock);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txRecorder);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txUnitonOrder);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1184, 206);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(347, 423);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaUI.Properties.Resources.producTitulo;
            this.pictureBox1.Location = new System.Drawing.Point(15, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1468, 135);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // panelEE
            // 
            this.panelEE.Controls.Add(this.BtEditar);
            this.panelEE.Controls.Add(this.BtEliminar);
            this.panelEE.Enabled = false;
            this.panelEE.Location = new System.Drawing.Point(1203, 772);
            this.panelEE.Margin = new System.Windows.Forms.Padding(4);
            this.panelEE.Name = "panelEE";
            this.panelEE.Size = new System.Drawing.Size(311, 57);
            this.panelEE.TabIndex = 31;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1532, 965);
            this.Controls.Add(this.panelEE);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BtGuardar);
            this.Controls.Add(this.BtNuevo);
            this.Controls.Add(this.dgPro);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPro)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelEE.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPro;
        private System.Windows.Forms.TextBox txProduct;
        private System.Windows.Forms.TextBox txproName;
        private System.Windows.Forms.TextBox txQuantity;
        private System.Windows.Forms.TextBox txUnitPrice;
        private System.Windows.Forms.TextBox txunitInstock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txUnitonOrder;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txRecorder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtNuevo;
        private System.Windows.Forms.Button BtEditar;
        private System.Windows.Forms.Button BtGuardar;
        private System.Windows.Forms.Button BtEliminar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CbSupplier;
        private System.Windows.Forms.ComboBox CbCategory;
        private System.Windows.Forms.ComboBox cbDescon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelEE;
    }
}