namespace CapaUI
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
            this.txSupplier = new System.Windows.Forms.TextBox();
            this.txCategory = new System.Windows.Forms.TextBox();
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
            this.txDiscontinued = new System.Windows.Forms.TextBox();
            this.BtNuevo = new System.Windows.Forms.Button();
            this.BtEditar = new System.Windows.Forms.Button();
            this.BtGuardar = new System.Windows.Forms.Button();
            this.BtEliminar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPro
            // 
            this.dgPro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPro.Location = new System.Drawing.Point(202, 172);
            this.dgPro.Margin = new System.Windows.Forms.Padding(2);
            this.dgPro.Name = "dgPro";
            this.dgPro.RowHeadersWidth = 51;
            this.dgPro.RowTemplate.Height = 24;
            this.dgPro.Size = new System.Drawing.Size(659, 284);
            this.dgPro.TabIndex = 0;
            this.dgPro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPro_CellClick);
            this.dgPro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPro_CellContentClick);
            // 
            // txProduct
            // 
            this.txProduct.Location = new System.Drawing.Point(112, 167);
            this.txProduct.Margin = new System.Windows.Forms.Padding(2);
            this.txProduct.Name = "txProduct";
            this.txProduct.Size = new System.Drawing.Size(76, 20);
            this.txProduct.TabIndex = 1;
            // 
            // txproName
            // 
            this.txproName.Location = new System.Drawing.Point(112, 200);
            this.txproName.Margin = new System.Windows.Forms.Padding(2);
            this.txproName.Name = "txproName";
            this.txproName.Size = new System.Drawing.Size(76, 20);
            this.txproName.TabIndex = 2;
            // 
            // txSupplier
            // 
            this.txSupplier.Location = new System.Drawing.Point(112, 231);
            this.txSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.txSupplier.Name = "txSupplier";
            this.txSupplier.Size = new System.Drawing.Size(76, 20);
            this.txSupplier.TabIndex = 3;
            // 
            // txCategory
            // 
            this.txCategory.Location = new System.Drawing.Point(112, 261);
            this.txCategory.Margin = new System.Windows.Forms.Padding(2);
            this.txCategory.Name = "txCategory";
            this.txCategory.Size = new System.Drawing.Size(76, 20);
            this.txCategory.TabIndex = 4;
            // 
            // txQuantity
            // 
            this.txQuantity.Location = new System.Drawing.Point(112, 292);
            this.txQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txQuantity.Name = "txQuantity";
            this.txQuantity.Size = new System.Drawing.Size(76, 20);
            this.txQuantity.TabIndex = 5;
            // 
            // txUnitPrice
            // 
            this.txUnitPrice.Location = new System.Drawing.Point(112, 323);
            this.txUnitPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txUnitPrice.Name = "txUnitPrice";
            this.txUnitPrice.Size = new System.Drawing.Size(76, 20);
            this.txUnitPrice.TabIndex = 6;
            // 
            // txunitInstock
            // 
            this.txunitInstock.Location = new System.Drawing.Point(112, 353);
            this.txunitInstock.Margin = new System.Windows.Forms.Padding(2);
            this.txunitInstock.Name = "txunitInstock";
            this.txunitInstock.Size = new System.Drawing.Size(76, 20);
            this.txunitInstock.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "ProductID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "ProductName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "SupplierID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "CategoryID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 297);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "QuantityPerUnit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 327);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "UnitPrice";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 358);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "UnitsInStock";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 389);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "UnitsOnOrder";
            // 
            // txUnitonOrder
            // 
            this.txUnitonOrder.Location = new System.Drawing.Point(112, 384);
            this.txUnitonOrder.Margin = new System.Windows.Forms.Padding(2);
            this.txUnitonOrder.Name = "txUnitonOrder";
            this.txUnitonOrder.Size = new System.Drawing.Size(76, 20);
            this.txUnitonOrder.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 417);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "RecorderLevel";
            // 
            // txRecorder
            // 
            this.txRecorder.Location = new System.Drawing.Point(112, 412);
            this.txRecorder.Margin = new System.Windows.Forms.Padding(2);
            this.txRecorder.Name = "txRecorder";
            this.txRecorder.Size = new System.Drawing.Size(76, 20);
            this.txRecorder.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 444);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Discontinued";
            // 
            // txDiscontinued
            // 
            this.txDiscontinued.Location = new System.Drawing.Point(112, 439);
            this.txDiscontinued.Margin = new System.Windows.Forms.Padding(2);
            this.txDiscontinued.Name = "txDiscontinued";
            this.txDiscontinued.Size = new System.Drawing.Size(76, 20);
            this.txDiscontinued.TabIndex = 19;
            // 
            // BtNuevo
            // 
            this.BtNuevo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtNuevo.Location = new System.Drawing.Point(128, 82);
            this.BtNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.BtNuevo.Name = "BtNuevo";
            this.BtNuevo.Size = new System.Drawing.Size(100, 52);
            this.BtNuevo.TabIndex = 21;
            this.BtNuevo.Text = "Nuevo";
            this.BtNuevo.UseVisualStyleBackColor = true;
            this.BtNuevo.Click += new System.EventHandler(this.BtNuevo_Click);
            // 
            // BtEditar
            // 
            this.BtEditar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEditar.Location = new System.Drawing.Point(244, 82);
            this.BtEditar.Margin = new System.Windows.Forms.Padding(2);
            this.BtEditar.Name = "BtEditar";
            this.BtEditar.Size = new System.Drawing.Size(100, 52);
            this.BtEditar.TabIndex = 22;
            this.BtEditar.Text = "Editar";
            this.BtEditar.UseVisualStyleBackColor = true;
            this.BtEditar.Click += new System.EventHandler(this.BtEditar_Click);
            // 
            // BtGuardar
            // 
            this.BtGuardar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtGuardar.Location = new System.Drawing.Point(363, 82);
            this.BtGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtGuardar.Name = "BtGuardar";
            this.BtGuardar.Size = new System.Drawing.Size(100, 52);
            this.BtGuardar.TabIndex = 23;
            this.BtGuardar.Text = "Guardar";
            this.BtGuardar.UseVisualStyleBackColor = true;
            this.BtGuardar.Click += new System.EventHandler(this.BtGuardar_Click);
            // 
            // BtEliminar
            // 
            this.BtEliminar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEliminar.Location = new System.Drawing.Point(488, 82);
            this.BtEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Size = new System.Drawing.Size(100, 52);
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
            this.label11.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(323, 32);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.MaximumSize = new System.Drawing.Size(2250000, 406250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 32);
            this.label11.TabIndex = 25;
            this.label11.Text = "PRODUCTOS";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(871, 500);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BtEliminar);
            this.Controls.Add(this.BtGuardar);
            this.Controls.Add(this.BtEditar);
            this.Controls.Add(this.BtNuevo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txDiscontinued);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txRecorder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txUnitonOrder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txunitInstock);
            this.Controls.Add(this.txUnitPrice);
            this.Controls.Add(this.txQuantity);
            this.Controls.Add(this.txCategory);
            this.Controls.Add(this.txSupplier);
            this.Controls.Add(this.txproName);
            this.Controls.Add(this.txProduct);
            this.Controls.Add(this.dgPro);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPro;
        private System.Windows.Forms.TextBox txProduct;
        private System.Windows.Forms.TextBox txproName;
        private System.Windows.Forms.TextBox txSupplier;
        private System.Windows.Forms.TextBox txCategory;
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
        private System.Windows.Forms.TextBox txDiscontinued;
        private System.Windows.Forms.Button BtNuevo;
        private System.Windows.Forms.Button BtEditar;
        private System.Windows.Forms.Button BtGuardar;
        private System.Windows.Forms.Button BtEliminar;
        private System.Windows.Forms.Label label11;
    }
}