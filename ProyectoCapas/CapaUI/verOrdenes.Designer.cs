﻿namespace CapaUI
{
    partial class verOrdenes
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
            this.dtgOrdenes = new System.Windows.Forms.DataGridView();
            this.dgtOrdenesDetalle = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrdenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtOrdenesDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgOrdenes
            // 
            this.dtgOrdenes.AllowUserToAddRows = false;
            this.dtgOrdenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOrdenes.Location = new System.Drawing.Point(12, 12);
            this.dtgOrdenes.Name = "dtgOrdenes";
            this.dtgOrdenes.Size = new System.Drawing.Size(1165, 312);
            this.dtgOrdenes.TabIndex = 0;
            // 
            // dgtOrdenesDetalle
            // 
            this.dgtOrdenesDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtOrdenesDetalle.Location = new System.Drawing.Point(13, 340);
            this.dgtOrdenesDetalle.Name = "dgtOrdenesDetalle";
            this.dgtOrdenesDetalle.Size = new System.Drawing.Size(1164, 269);
            this.dgtOrdenesDetalle.TabIndex = 1;
            // 
            // verOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 621);
            this.Controls.Add(this.dgtOrdenesDetalle);
            this.Controls.Add(this.dtgOrdenes);
            this.Name = "verOrdenes";
            this.Text = "verOrdenes";
            this.Load += new System.EventHandler(this.verOrdenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrdenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtOrdenesDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgOrdenes;
        private System.Windows.Forms.DataGridView dgtOrdenesDetalle;
    }
}