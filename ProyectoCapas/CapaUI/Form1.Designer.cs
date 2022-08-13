
namespace CapaUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgRegiones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gControles = new System.Windows.Forms.GroupBox();
            this.txtRegionNombre = new System.Windows.Forms.TextBox();
            this.txtRegionID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegiones)).BeginInit();
            this.gControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgRegiones
            // 
            this.dgRegiones.AllowUserToAddRows = false;
            this.dgRegiones.AllowUserToDeleteRows = false;
            this.dgRegiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRegiones.Location = new System.Drawing.Point(248, 166);
            this.dgRegiones.Margin = new System.Windows.Forms.Padding(2);
            this.dgRegiones.Name = "dgRegiones";
            this.dgRegiones.ReadOnly = true;
            this.dgRegiones.RowHeadersWidth = 82;
            this.dgRegiones.RowTemplate.Height = 33;
            this.dgRegiones.Size = new System.Drawing.Size(372, 202);
            this.dgRegiones.TabIndex = 0;
            this.dgRegiones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRegiones_CellClick);
            this.dgRegiones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRegiones_CellContentClick);
            this.dgRegiones.SelectionChanged += new System.EventHandler(this.dgRegiones_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGIONES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(144, 87);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(65, 48);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(222, 87);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(65, 48);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(303, 87);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(65, 48);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(380, 87);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(65, 48);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gControles
            // 
            this.gControles.Controls.Add(this.txtRegionNombre);
            this.gControles.Controls.Add(this.txtRegionID);
            this.gControles.Controls.Add(this.label3);
            this.gControles.Controls.Add(this.label2);
            this.gControles.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gControles.Location = new System.Drawing.Point(10, 161);
            this.gControles.Margin = new System.Windows.Forms.Padding(2);
            this.gControles.Name = "gControles";
            this.gControles.Padding = new System.Windows.Forms.Padding(2);
            this.gControles.Size = new System.Drawing.Size(230, 156);
            this.gControles.TabIndex = 6;
            this.gControles.TabStop = false;
            this.gControles.Text = "Datos";
            this.gControles.Enter += new System.EventHandler(this.gControles_Enter);
            // 
            // txtRegionNombre
            // 
            this.txtRegionNombre.Location = new System.Drawing.Point(89, 62);
            this.txtRegionNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegionNombre.Name = "txtRegionNombre";
            this.txtRegionNombre.Size = new System.Drawing.Size(98, 21);
            this.txtRegionNombre.TabIndex = 3;
            this.txtRegionNombre.TextChanged += new System.EventHandler(this.txtRegionNombre_TextChanged);
            // 
            // txtRegionID
            // 
            this.txtRegionID.Location = new System.Drawing.Point(89, 27);
            this.txtRegionID.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegionID.Name = "txtRegionID";
            this.txtRegionID.Size = new System.Drawing.Size(98, 21);
            this.txtRegionID.TabIndex = 2;
            this.txtRegionID.TextChanged += new System.EventHandler(this.txtRegionID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Region ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 379);
            this.Controls.Add(this.gControles);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgRegiones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRegiones)).EndInit();
            this.gControles.ResumeLayout(false);
            this.gControles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRegiones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gControles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegionNombre;
        private System.Windows.Forms.TextBox txtRegionID;
    }
}

