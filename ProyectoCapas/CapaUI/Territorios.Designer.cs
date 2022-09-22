﻿namespace CapaUI
{
    partial class Territorios
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
            this.butGuardar = new System.Windows.Forms.Button();
            this.butELiminar = new System.Windows.Forms.Button();
            this.butEditar = new System.Windows.Forms.Button();
            this.butNuevo = new System.Windows.Forms.Button();
            this.gControles = new System.Windows.Forms.GroupBox();
            this.txtRegionID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcionTerritorio = new System.Windows.Forms.TextBox();
            this.txtTerritorioID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgTerritorios = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelEE = new System.Windows.Forms.Panel();
            this.gControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTerritorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelEE.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 87);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(386, 74);
            this.label1.TabIndex = 1;
            this.label1.Text = "TERRITORIOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // butGuardar
            // 
            this.butGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butGuardar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGuardar.Location = new System.Drawing.Point(1355, 634);
            this.butGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butGuardar.Name = "butGuardar";
            this.butGuardar.Size = new System.Drawing.Size(111, 48);
            this.butGuardar.TabIndex = 9;
            this.butGuardar.Text = "Guardar";
            this.butGuardar.UseVisualStyleBackColor = false;
            this.butGuardar.Click += new System.EventHandler(this.butGuardar_Click);
            // 
            // butELiminar
            // 
            this.butELiminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butELiminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butELiminar.Location = new System.Drawing.Point(136, 12);
            this.butELiminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butELiminar.Name = "butELiminar";
            this.butELiminar.Size = new System.Drawing.Size(111, 48);
            this.butELiminar.TabIndex = 8;
            this.butELiminar.Text = "Eliminar";
            this.butELiminar.UseVisualStyleBackColor = false;
            this.butELiminar.Click += new System.EventHandler(this.butELiminar_Click);
            // 
            // butEditar
            // 
            this.butEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butEditar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEditar.Location = new System.Drawing.Point(8, 12);
            this.butEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butEditar.Name = "butEditar";
            this.butEditar.Size = new System.Drawing.Size(111, 48);
            this.butEditar.TabIndex = 7;
            this.butEditar.Text = "Editar";
            this.butEditar.UseVisualStyleBackColor = false;
            this.butEditar.Click += new System.EventHandler(this.butEditar_Click);
            // 
            // butNuevo
            // 
            this.butNuevo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butNuevo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNuevo.Location = new System.Drawing.Point(1227, 634);
            this.butNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butNuevo.Name = "butNuevo";
            this.butNuevo.Size = new System.Drawing.Size(111, 48);
            this.butNuevo.TabIndex = 6;
            this.butNuevo.Text = "Nuevo";
            this.butNuevo.UseVisualStyleBackColor = false;
            this.butNuevo.Click += new System.EventHandler(this.butNuevo_Click);
            // 
            // gControles
            // 
            this.gControles.Controls.Add(this.txtRegionID);
            this.gControles.Controls.Add(this.label5);
            this.gControles.Controls.Add(this.txtDescripcionTerritorio);
            this.gControles.Controls.Add(this.txtTerritorioID);
            this.gControles.Controls.Add(this.label3);
            this.gControles.Controls.Add(this.label2);
            this.gControles.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gControles.Location = new System.Drawing.Point(1175, 366);
            this.gControles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gControles.Name = "gControles";
            this.gControles.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gControles.Size = new System.Drawing.Size(341, 177);
            this.gControles.TabIndex = 10;
            this.gControles.TabStop = false;
            this.gControles.Text = "Datos";
            // 
            // txtRegionID
            // 
            this.txtRegionID.Location = new System.Drawing.Point(180, 119);
            this.txtRegionID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRegionID.MaxLength = 11;
            this.txtRegionID.Name = "txtRegionID";
            this.txtRegionID.Size = new System.Drawing.Size(129, 24);
            this.txtRegionID.TabIndex = 6;
            this.txtRegionID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegionID_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Región ID:";
            // 
            // txtDescripcionTerritorio
            // 
            this.txtDescripcionTerritorio.Location = new System.Drawing.Point(180, 76);
            this.txtDescripcionTerritorio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcionTerritorio.MaxLength = 50;
            this.txtDescripcionTerritorio.Name = "txtDescripcionTerritorio";
            this.txtDescripcionTerritorio.Size = new System.Drawing.Size(129, 24);
            this.txtDescripcionTerritorio.TabIndex = 3;
            this.txtDescripcionTerritorio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcionTerritorio_KeyPress);
            // 
            // txtTerritorioID
            // 
            this.txtTerritorioID.Enabled = false;
            this.txtTerritorioID.Location = new System.Drawing.Point(180, 34);
            this.txtTerritorioID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTerritorioID.Name = "txtTerritorioID";
            this.txtTerritorioID.Size = new System.Drawing.Size(129, 24);
            this.txtTerritorioID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Decripción Territorio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Territorio ID:";
            // 
            // dgTerritorios
            // 
            this.dgTerritorios.AllowUserToAddRows = false;
            this.dgTerritorios.AllowUserToDeleteRows = false;
            this.dgTerritorios.AllowUserToResizeColumns = false;
            this.dgTerritorios.AllowUserToResizeRows = false;
            this.dgTerritorios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTerritorios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgTerritorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTerritorios.Location = new System.Drawing.Point(15, 207);
            this.dgTerritorios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgTerritorios.Name = "dgTerritorios";
            this.dgTerritorios.ReadOnly = true;
            this.dgTerritorios.RowHeadersWidth = 51;
            this.dgTerritorios.RowTemplate.Height = 24;
            this.dgTerritorios.Size = new System.Drawing.Size(1140, 580);
            this.dgTerritorios.TabIndex = 11;
            this.dgTerritorios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTerritorios_CellClick_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaUI.Properties.Resources.terriTitulo;
            this.pictureBox1.Location = new System.Drawing.Point(17, 65);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1468, 135);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // panelEE
            // 
            this.panelEE.Controls.Add(this.butELiminar);
            this.panelEE.Controls.Add(this.butEditar);
            this.panelEE.Enabled = false;
            this.panelEE.Location = new System.Drawing.Point(1219, 688);
            this.panelEE.Margin = new System.Windows.Forms.Padding(4);
            this.panelEE.Name = "panelEE";
            this.panelEE.Size = new System.Drawing.Size(267, 74);
            this.panelEE.TabIndex = 16;
            // 
            // Territorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1535, 967);
            this.Controls.Add(this.panelEE);
            this.Controls.Add(this.butNuevo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butGuardar);
            this.Controls.Add(this.dgTerritorios);
            this.Controls.Add(this.gControles);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Territorios";
            this.Text = "Territorios";
            this.Load += new System.EventHandler(this.Territorios_Load_1);
            this.gControles.ResumeLayout(false);
            this.gControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTerritorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelEE.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butGuardar;
        private System.Windows.Forms.Button butELiminar;
        private System.Windows.Forms.Button butEditar;
        private System.Windows.Forms.Button butNuevo;
        private System.Windows.Forms.GroupBox gControles;
        private System.Windows.Forms.TextBox txtRegionID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcionTerritorio;
        private System.Windows.Forms.TextBox txtTerritorioID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgTerritorios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelEE;
    }
}