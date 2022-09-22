﻿namespace CapaUI
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
            this.txtPaginaWeb = new System.Windows.Forms.TextBox();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelEE = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgProveedores)).BeginInit();
            this.gControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelEE.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 52);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(456, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROVEEDORES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgProveedores
            // 
            this.dgProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProveedores.Location = new System.Drawing.Point(15, 177);
            this.dgProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgProveedores.Name = "dgProveedores";
            this.dgProveedores.ReadOnly = true;
            this.dgProveedores.RowHeadersWidth = 51;
            this.dgProveedores.RowTemplate.Height = 24;
            this.dgProveedores.Size = new System.Drawing.Size(1156, 699);
            this.dgProveedores.TabIndex = 1;
            this.dgProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProveedores_CellClick);
            this.dgProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // butNuevo
            // 
            this.butNuevo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butNuevo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNuevo.Location = new System.Drawing.Point(1244, 762);
            this.butNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.butEditar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEditar.Location = new System.Drawing.Point(12, 2);
            this.butEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.butELiminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butELiminar.Location = new System.Drawing.Point(112, 2);
            this.butELiminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butELiminar.Name = "butELiminar";
            this.butELiminar.Size = new System.Drawing.Size(111, 48);
            this.butELiminar.TabIndex = 4;
            this.butELiminar.Text = "Eliminar";
            this.butELiminar.UseVisualStyleBackColor = false;
            this.butELiminar.Click += new System.EventHandler(this.butELiminar_Click);
            // 
            // butGuardar
            // 
            this.butGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butGuardar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGuardar.Location = new System.Drawing.Point(1344, 762);
            this.butGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butGuardar.Name = "butGuardar";
            this.butGuardar.Size = new System.Drawing.Size(111, 48);
            this.butGuardar.TabIndex = 5;
            this.butGuardar.Text = "Guardar";
            this.butGuardar.UseVisualStyleBackColor = false;
            this.butGuardar.Click += new System.EventHandler(this.butGuardar_Click);
            // 
            // gControles
            // 
            this.gControles.Controls.Add(this.txtPaginaWeb);
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
            this.gControles.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gControles.Location = new System.Drawing.Point(1176, 177);
            this.gControles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gControles.Name = "gControles";
            this.gControles.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gControles.Size = new System.Drawing.Size(341, 556);
            this.gControles.TabIndex = 7;
            this.gControles.TabStop = false;
            this.gControles.Text = "Datos";
            // 
            // txtPaginaWeb
            // 
            this.txtPaginaWeb.Location = new System.Drawing.Point(180, 507);
            this.txtPaginaWeb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPaginaWeb.Name = "txtPaginaWeb";
            this.txtPaginaWeb.Size = new System.Drawing.Size(129, 24);
            this.txtPaginaWeb.TabIndex = 23;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(180, 466);
            this.txtFax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFax.MaxLength = 24;
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(129, 24);
            this.txtFax.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 507);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "Pagina Web:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(117, 466);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 19);
            this.label11.TabIndex = 20;
            this.label11.Text = "Fax:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(180, 423);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.MaxLength = 24;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(129, 24);
            this.txtTelefono.TabIndex = 19;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(180, 382);
            this.txtPais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPais.MaxLength = 20;
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(129, 24);
            this.txtPais.TabIndex = 18;
            this.txtPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPais_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(83, 423);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 19);
            this.label12.TabIndex = 17;
            this.label12.Text = "Teléfono:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(115, 382);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 19);
            this.label13.TabIndex = 16;
            this.label13.Text = "País:";
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(180, 341);
            this.txtCodigoPostal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoPostal.MaxLength = 10;
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(129, 24);
            this.txtCodigoPostal.TabIndex = 15;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(180, 300);
            this.txtRegion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRegion.MaxLength = 20;
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(129, 24);
            this.txtRegion.TabIndex = 14;
            this.txtRegion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegion_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Codigo Postal:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Región:";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(180, 257);
            this.txtCiudad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCiudad.MaxLength = 20;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(129, 24);
            this.txtCiudad.TabIndex = 11;
            this.txtCiudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCiudad_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(180, 215);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccion.MaxLength = 60;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(129, 24);
            this.txtDireccion.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Ciudad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Dirección:";
            // 
            // txtCargoContacto
            // 
            this.txtCargoContacto.Location = new System.Drawing.Point(180, 176);
            this.txtCargoContacto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCargoContacto.MaxLength = 30;
            this.txtCargoContacto.Name = "txtCargoContacto";
            this.txtCargoContacto.Size = new System.Drawing.Size(129, 24);
            this.txtCargoContacto.TabIndex = 7;
            this.txtCargoContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCargoContacto_KeyPress);
            // 
            // txtNombreContacto
            // 
            this.txtNombreContacto.Location = new System.Drawing.Point(180, 135);
            this.txtNombreContacto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreContacto.MaxLength = 30;
            this.txtNombreContacto.Name = "txtNombreContacto";
            this.txtNombreContacto.Size = new System.Drawing.Size(129, 24);
            this.txtNombreContacto.TabIndex = 6;
            this.txtNombreContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreContacto_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cargo Contacto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre Contacto:";
            // 
            // txtCompania
            // 
            this.txtCompania.Location = new System.Drawing.Point(180, 92);
            this.txtCompania.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCompania.MaxLength = 40;
            this.txtCompania.Name = "txtCompania";
            this.txtCompania.Size = new System.Drawing.Size(129, 24);
            this.txtCompania.TabIndex = 3;
            // 
            // txtProveedorID
            // 
            this.txtProveedorID.Enabled = false;
            this.txtProveedorID.Location = new System.Drawing.Point(180, 50);
            this.txtProveedorID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProveedorID.Name = "txtProveedorID";
            this.txtProveedorID.Size = new System.Drawing.Size(129, 24);
            this.txtProveedorID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Compania:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Proveedor ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaUI.Properties.Resources.proveeTitulo;
            this.pictureBox1.Location = new System.Drawing.Point(15, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1468, 135);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // panelEE
            // 
            this.panelEE.Controls.Add(this.butELiminar);
            this.panelEE.Controls.Add(this.butEditar);
            this.panelEE.Enabled = false;
            this.panelEE.Location = new System.Drawing.Point(1231, 818);
            this.panelEE.Margin = new System.Windows.Forms.Padding(4);
            this.panelEE.Name = "panelEE";
            this.panelEE.Size = new System.Drawing.Size(256, 58);
            this.panelEE.TabIndex = 15;
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1532, 965);
            this.Controls.Add(this.panelEE);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gControles);
            this.Controls.Add(this.butGuardar);
            this.Controls.Add(this.dgProveedores);
            this.Controls.Add(this.butNuevo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProveedores)).EndInit();
            this.gControles.ResumeLayout(false);
            this.gControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelEE.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtPaginaWeb;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelEE;
    }
}