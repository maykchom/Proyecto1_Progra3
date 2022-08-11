namespace CapaUI
{
    partial class Proveedores
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgProveedores = new System.Windows.Forms.DataGridView();
            this.butNuevo = new System.Windows.Forms.Button();
            this.butEditar = new System.Windows.Forms.Button();
            this.butELiminar = new System.Windows.Forms.Button();
            this.butGuardar = new System.Windows.Forms.Button();
            this.gControles = new System.Windows.Forms.GroupBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCargoContacto = new System.Windows.Forms.TextBox();
            this.txtNombreContacto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCompania = new System.Windows.Forms.TextBox();
            this.txtProveedorID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgProveedores)).BeginInit();
            this.gControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(544, 27);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(442, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROVEEDORES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgProveedores
            // 
            this.dgProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProveedores.Location = new System.Drawing.Point(334, 109);
            this.dgProveedores.Name = "dgProveedores";
            this.dgProveedores.RowHeadersWidth = 51;
            this.dgProveedores.RowTemplate.Height = 24;
            this.dgProveedores.Size = new System.Drawing.Size(870, 238);
            this.dgProveedores.TabIndex = 1;
            this.dgProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // butNuevo
            // 
            this.butNuevo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNuevo.Location = new System.Drawing.Point(525, 399);
            this.butNuevo.Name = "butNuevo";
            this.butNuevo.Size = new System.Drawing.Size(95, 48);
            this.butNuevo.TabIndex = 2;
            this.butNuevo.Text = "Nuevo";
            this.butNuevo.UseVisualStyleBackColor = false;
            this.butNuevo.Click += new System.EventHandler(this.button1_Click);
            // 
            // butEditar
            // 
            this.butEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEditar.Location = new System.Drawing.Point(657, 399);
            this.butEditar.Name = "butEditar";
            this.butEditar.Size = new System.Drawing.Size(95, 48);
            this.butEditar.TabIndex = 3;
            this.butEditar.Text = "Editar";
            this.butEditar.UseVisualStyleBackColor = false;
            this.butEditar.Click += new System.EventHandler(this.button2_Click);
            // 
            // butELiminar
            // 
            this.butELiminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butELiminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butELiminar.Location = new System.Drawing.Point(802, 399);
            this.butELiminar.Name = "butELiminar";
            this.butELiminar.Size = new System.Drawing.Size(95, 48);
            this.butELiminar.TabIndex = 4;
            this.butELiminar.Text = "Eliminar";
            this.butELiminar.UseVisualStyleBackColor = false;
            this.butELiminar.Click += new System.EventHandler(this.butELiminar_Click);
            // 
            // butGuardar
            // 
            this.butGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGuardar.Location = new System.Drawing.Point(941, 399);
            this.butGuardar.Name = "butGuardar";
            this.butGuardar.Size = new System.Drawing.Size(95, 48);
            this.butGuardar.TabIndex = 5;
            this.butGuardar.Text = "Guardar";
            this.butGuardar.UseVisualStyleBackColor = false;
            this.butGuardar.Click += new System.EventHandler(this.butGuardar_Click);
            // 
            // gControles
            // 
            this.gControles.Controls.Add(this.txtCorreo);
            this.gControles.Controls.Add(this.txtFax);
            this.gControles.Controls.Add(this.label10);
            this.gControles.Controls.Add(this.label11);
            this.gControles.Controls.Add(this.txtTelefono);
            this.gControles.Controls.Add(this.txtPais);
            this.gControles.Controls.Add(this.label12);
            this.gControles.Controls.Add(this.label13);
            this.gControles.Controls.Add(this.txtCodigoPostal);
            this.gControles.Controls.Add(this.txtRegion);
            this.gControles.Controls.Add(this.label6);
            this.gControles.Controls.Add(this.label7);
            this.gControles.Controls.Add(this.txtCiudad);
            this.gControles.Controls.Add(this.txtDireccion);
            this.gControles.Controls.Add(this.label8);
            this.gControles.Controls.Add(this.label9);
            this.gControles.Controls.Add(this.txtCargoContacto);
            this.gControles.Controls.Add(this.txtNombreContacto);
            this.gControles.Controls.Add(this.label4);
            this.gControles.Controls.Add(this.label5);
            this.gControles.Controls.Add(this.txtCompania);
            this.gControles.Controls.Add(this.txtProveedorID);
            this.gControles.Controls.Add(this.label3);
            this.gControles.Controls.Add(this.label2);
            this.gControles.Location = new System.Drawing.Point(25, 27);
            this.gControles.Margin = new System.Windows.Forms.Padding(2);
            this.gControles.Name = "gControles";
            this.gControles.Padding = new System.Windows.Forms.Padding(2);
            this.gControles.Size = new System.Drawing.Size(286, 530);
            this.gControles.TabIndex = 7;
            this.gControles.TabStop = false;
            this.gControles.Text = "Datos";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(133, 491);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(130, 22);
            this.txtCorreo.TabIndex = 23;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(133, 450);
            this.txtFax.Margin = new System.Windows.Forms.Padding(2);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(130, 22);
            this.txtFax.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 491);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Correo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 450);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Fax:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(133, 407);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(130, 22);
            this.txtTelefono.TabIndex = 19;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(133, 366);
            this.txtPais.Margin = new System.Windows.Forms.Padding(2);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(130, 22);
            this.txtPais.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 407);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "Teléfono:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(44, 366);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 17);
            this.label13.TabIndex = 16;
            this.label13.Text = "País:";
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(133, 325);
            this.txtCodigoPostal.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(130, 22);
            this.txtCodigoPostal.TabIndex = 15;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(133, 284);
            this.txtRegion.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(130, 22);
            this.txtRegion.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 325);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Codigo Postal:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 284);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Región:";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(133, 241);
            this.txtCiudad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(130, 22);
            this.txtCiudad.TabIndex = 11;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(133, 200);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(130, 22);
            this.txtDireccion.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 241);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Ciudad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 200);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Dirección:";
            // 
            // txtCargoContacto
            // 
            this.txtCargoContacto.Location = new System.Drawing.Point(133, 160);
            this.txtCargoContacto.Margin = new System.Windows.Forms.Padding(2);
            this.txtCargoContacto.Name = "txtCargoContacto";
            this.txtCargoContacto.Size = new System.Drawing.Size(130, 22);
            this.txtCargoContacto.TabIndex = 7;
            // 
            // txtNombreContacto
            // 
            this.txtNombreContacto.Location = new System.Drawing.Point(133, 119);
            this.txtNombreContacto.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreContacto.Name = "txtNombreContacto";
            this.txtNombreContacto.Size = new System.Drawing.Size(130, 22);
            this.txtNombreContacto.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cargo Contacto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre Contacto:";
            // 
            // txtCompania
            // 
            this.txtCompania.Location = new System.Drawing.Point(133, 76);
            this.txtCompania.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompania.Name = "txtCompania";
            this.txtCompania.Size = new System.Drawing.Size(130, 22);
            this.txtCompania.TabIndex = 3;
            // 
            // txtProveedorID
            // 
            this.txtProveedorID.Location = new System.Drawing.Point(133, 35);
            this.txtProveedorID.Margin = new System.Windows.Forms.Padding(2);
            this.txtProveedorID.Name = "txtProveedorID";
            this.txtProveedorID.Size = new System.Drawing.Size(130, 22);
            this.txtProveedorID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Compania:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Proveedor ID:";
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 585);
            this.Controls.Add(this.gControles);
            this.Controls.Add(this.butGuardar);
            this.Controls.Add(this.butELiminar);
            this.Controls.Add(this.butEditar);
            this.Controls.Add(this.dgProveedores);
            this.Controls.Add(this.butNuevo);
            this.Controls.Add(this.label1);
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProveedores)).EndInit();
            this.gControles.ResumeLayout(false);
            this.gControles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgProveedores;
        private System.Windows.Forms.Button butNuevo;
        private System.Windows.Forms.Button butEditar;
        private System.Windows.Forms.Button butELiminar;
        private System.Windows.Forms.Button butGuardar;
        private System.Windows.Forms.GroupBox gControles;
        private System.Windows.Forms.TextBox txtCompania;
        private System.Windows.Forms.TextBox txtProveedorID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCargoContacto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreContacto;
    }
}