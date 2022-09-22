﻿namespace CapaUI
{
    partial class Categorias
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
            this.dgCat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gControles = new System.Windows.Forms.GroupBox();
            this.btnImg = new System.Windows.Forms.Button();
            this.tbDescri = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbCatID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.panelEE = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgCat)).BeginInit();
            this.gControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.panelEE.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgCat
            // 
            this.dgCat.AllowUserToAddRows = false;
            this.dgCat.AllowUserToDeleteRows = false;
            this.dgCat.AllowUserToResizeColumns = false;
            this.dgCat.AllowUserToResizeRows = false;
            this.dgCat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCat.Location = new System.Drawing.Point(16, 171);
            this.dgCat.Margin = new System.Windows.Forms.Padding(4);
            this.dgCat.Name = "dgCat";
            this.dgCat.ReadOnly = true;
            this.dgCat.RowHeadersWidth = 51;
            this.dgCat.Size = new System.Drawing.Size(1213, 676);
            this.dgCat.TabIndex = 0;
            this.dgCat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCat_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "CATEGORIAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(1388, 668);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(116, 37);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(137, 2);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 37);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(5, 2);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(116, 37);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(1256, 668);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(116, 37);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gControles
            // 
            this.gControles.Controls.Add(this.btnImg);
            this.gControles.Controls.Add(this.tbDescri);
            this.gControles.Controls.Add(this.label4);
            this.gControles.Controls.Add(this.tbNombre);
            this.gControles.Controls.Add(this.tbCatID);
            this.gControles.Controls.Add(this.label3);
            this.gControles.Controls.Add(this.label2);
            this.gControles.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gControles.Location = new System.Drawing.Point(1236, 442);
            this.gControles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gControles.Name = "gControles";
            this.gControles.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gControles.Size = new System.Drawing.Size(279, 186);
            this.gControles.TabIndex = 10;
            this.gControles.TabStop = false;
            this.gControles.Text = "Datos";
            // 
            // btnImg
            // 
            this.btnImg.Location = new System.Drawing.Point(20, 138);
            this.btnImg.Margin = new System.Windows.Forms.Padding(4);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(228, 28);
            this.btnImg.TabIndex = 6;
            this.btnImg.Text = "Seleccionar imagen...";
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // tbDescri
            // 
            this.tbDescri.Location = new System.Drawing.Point(119, 106);
            this.tbDescri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDescri.Name = "tbDescri";
            this.tbDescri.Size = new System.Drawing.Size(129, 24);
            this.tbDescri.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Descripción";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(119, 70);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNombre.MaxLength = 20;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(129, 24);
            this.tbNombre.TabIndex = 3;
            this.tbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombre_KeyPress);
            // 
            // tbCatID
            // 
            this.tbCatID.Enabled = false;
            this.tbCatID.Location = new System.Drawing.Point(119, 33);
            this.tbCatID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCatID.Name = "tbCatID";
            this.tbCatID.Size = new System.Drawing.Size(129, 24);
            this.tbCatID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Categoria ID";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaUI.Properties.Resources.cateTitulo;
            this.pictureBox1.Location = new System.Drawing.Point(16, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1468, 135);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pbImagen
            // 
            this.pbImagen.BackColor = System.Drawing.Color.Gainsboro;
            this.pbImagen.Location = new System.Drawing.Point(1237, 171);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(4);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(279, 180);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 11;
            this.pbImagen.TabStop = false;
            // 
            // panelEE
            // 
            this.panelEE.Controls.Add(this.btnEliminar);
            this.panelEE.Controls.Add(this.btnEditar);
            this.panelEE.Enabled = false;
            this.panelEE.Location = new System.Drawing.Point(1251, 711);
            this.panelEE.Margin = new System.Windows.Forms.Padding(4);
            this.panelEE.Name = "panelEE";
            this.panelEE.Size = new System.Drawing.Size(259, 50);
            this.panelEE.TabIndex = 14;
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1532, 965);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panelEE);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.gControles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgCat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Categorias";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.Categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCat)).EndInit();
            this.gControles.ResumeLayout(false);
            this.gControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.panelEE.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox gControles;
        private System.Windows.Forms.TextBox tbDescri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbCatID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelEE;
    }
}