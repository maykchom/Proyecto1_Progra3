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
            this.butNUEVO = new System.Windows.Forms.Button();
            this.butEDITAR = new System.Windows.Forms.Button();
            this.butELIMINAR = new System.Windows.Forms.Button();
            this.butGUARDAR = new System.Windows.Forms.Button();
            this.gControles = new System.Windows.Forms.GroupBox();
            this.txtPROVEEDOR_NOMBRE = new System.Windows.Forms.TextBox();
            this.txtPROVEEDOR_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgProveedores)).BeginInit();
            this.gControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 43);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(312, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROVEEDORES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgProveedores
            // 
            this.dgProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProveedores.Location = new System.Drawing.Point(60, 319);
            this.dgProveedores.Name = "dgProveedores";
            this.dgProveedores.RowHeadersWidth = 51;
            this.dgProveedores.RowTemplate.Height = 24;
            this.dgProveedores.Size = new System.Drawing.Size(643, 238);
            this.dgProveedores.TabIndex = 1;
            this.dgProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // butNUEVO
            // 
            this.butNUEVO.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butNUEVO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNUEVO.Location = new System.Drawing.Point(122, 105);
            this.butNUEVO.Name = "butNUEVO";
            this.butNUEVO.Size = new System.Drawing.Size(95, 48);
            this.butNUEVO.TabIndex = 2;
            this.butNUEVO.Text = "Nuevo";
            this.butNUEVO.UseVisualStyleBackColor = false;
            this.butNUEVO.Click += new System.EventHandler(this.button1_Click);
            // 
            // butEDITAR
            // 
            this.butEDITAR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butEDITAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEDITAR.Location = new System.Drawing.Point(254, 105);
            this.butEDITAR.Name = "butEDITAR";
            this.butEDITAR.Size = new System.Drawing.Size(95, 48);
            this.butEDITAR.TabIndex = 3;
            this.butEDITAR.Text = "Editar";
            this.butEDITAR.UseVisualStyleBackColor = false;
            this.butEDITAR.Click += new System.EventHandler(this.button2_Click);
            // 
            // butELIMINAR
            // 
            this.butELIMINAR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butELIMINAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butELIMINAR.Location = new System.Drawing.Point(399, 105);
            this.butELIMINAR.Name = "butELIMINAR";
            this.butELIMINAR.Size = new System.Drawing.Size(95, 48);
            this.butELIMINAR.TabIndex = 4;
            this.butELIMINAR.Text = "Eliminar";
            this.butELIMINAR.UseVisualStyleBackColor = false;
            // 
            // butGUARDAR
            // 
            this.butGUARDAR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butGUARDAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGUARDAR.Location = new System.Drawing.Point(538, 105);
            this.butGUARDAR.Name = "butGUARDAR";
            this.butGUARDAR.Size = new System.Drawing.Size(95, 48);
            this.butGUARDAR.TabIndex = 5;
            this.butGUARDAR.Text = "Guardar";
            this.butGUARDAR.UseVisualStyleBackColor = false;
            // 
            // gControles
            // 
            this.gControles.Controls.Add(this.txtPROVEEDOR_NOMBRE);
            this.gControles.Controls.Add(this.txtPROVEEDOR_ID);
            this.gControles.Controls.Add(this.label3);
            this.gControles.Controls.Add(this.label2);
            this.gControles.Location = new System.Drawing.Point(237, 178);
            this.gControles.Margin = new System.Windows.Forms.Padding(2);
            this.gControles.Name = "gControles";
            this.gControles.Padding = new System.Windows.Forms.Padding(2);
            this.gControles.Size = new System.Drawing.Size(306, 126);
            this.gControles.TabIndex = 7;
            this.gControles.TabStop = false;
            this.gControles.Text = "Datos";
            // 
            // txtPROVEEDOR_NOMBRE
            // 
            this.txtPROVEEDOR_NOMBRE.Location = new System.Drawing.Point(119, 71);
            this.txtPROVEEDOR_NOMBRE.Margin = new System.Windows.Forms.Padding(2);
            this.txtPROVEEDOR_NOMBRE.Name = "txtPROVEEDOR_NOMBRE";
            this.txtPROVEEDOR_NOMBRE.Size = new System.Drawing.Size(130, 22);
            this.txtPROVEEDOR_NOMBRE.TabIndex = 3;
            // 
            // txtPROVEEDOR_ID
            // 
            this.txtPROVEEDOR_ID.Location = new System.Drawing.Point(119, 33);
            this.txtPROVEEDOR_ID.Margin = new System.Windows.Forms.Padding(2);
            this.txtPROVEEDOR_ID.Name = "txtPROVEEDOR_ID";
            this.txtPROVEEDOR_ID.Size = new System.Drawing.Size(130, 22);
            this.txtPROVEEDOR_ID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Proveedor ID";
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 585);
            this.Controls.Add(this.gControles);
            this.Controls.Add(this.butGUARDAR);
            this.Controls.Add(this.butELIMINAR);
            this.Controls.Add(this.butEDITAR);
            this.Controls.Add(this.dgProveedores);
            this.Controls.Add(this.butNUEVO);
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
        private System.Windows.Forms.Button butNUEVO;
        private System.Windows.Forms.Button butEDITAR;
        private System.Windows.Forms.Button butELIMINAR;
        private System.Windows.Forms.Button butGUARDAR;
        private System.Windows.Forms.GroupBox gControles;
        private System.Windows.Forms.TextBox txtPROVEEDOR_NOMBRE;
        private System.Windows.Forms.TextBox txtPROVEEDOR_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}