namespace CapaUI
{
    partial class Shipper
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
            this.dgShipper = new System.Windows.Forms.DataGridView();
            this.txCompany = new System.Windows.Forms.TextBox();
            this.txphone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btNuevo = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btEli = new System.Windows.Forms.Button();
            this.txShipper = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgShipper)).BeginInit();
            this.SuspendLayout();
            // 
            // dgShipper
            // 
            this.dgShipper.AllowUserToAddRows = false;
            this.dgShipper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgShipper.Location = new System.Drawing.Point(383, 203);
            this.dgShipper.Name = "dgShipper";
            this.dgShipper.RowHeadersWidth = 51;
            this.dgShipper.RowTemplate.Height = 24;
            this.dgShipper.Size = new System.Drawing.Size(339, 180);
            this.dgShipper.TabIndex = 0;
            this.dgShipper.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgShipper_CellClick);
            // 
            // txCompany
            // 
            this.txCompany.Location = new System.Drawing.Point(205, 297);
            this.txCompany.Name = "txCompany";
            this.txCompany.Size = new System.Drawing.Size(100, 22);
            this.txCompany.TabIndex = 1;
            // 
            // txphone
            // 
            this.txphone.Location = new System.Drawing.Point(205, 343);
            this.txphone.Name = "txphone";
            this.txphone.Size = new System.Drawing.Size(100, 22);
            this.txphone.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "CompanyName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "ShipperID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 6;
            // 
            // btNuevo
            // 
            this.btNuevo.Location = new System.Drawing.Point(92, 85);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(75, 23);
            this.btNuevo.TabIndex = 7;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.UseVisualStyleBackColor = true;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(205, 85);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 8;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(336, 85);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 9;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btEli
            // 
            this.btEli.Location = new System.Drawing.Point(453, 85);
            this.btEli.Name = "btEli";
            this.btEli.Size = new System.Drawing.Size(75, 23);
            this.btEli.TabIndex = 10;
            this.btEli.Text = "Eliminar";
            this.btEli.UseVisualStyleBackColor = true;
            // 
            // txShipper
            // 
            this.txShipper.Enabled = false;
            this.txShipper.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txShipper.Location = new System.Drawing.Point(205, 243);
            this.txShipper.Name = "txShipper";
            this.txShipper.Size = new System.Drawing.Size(100, 22);
            this.txShipper.TabIndex = 11;
            // 
            // Shipper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txShipper);
            this.Controls.Add(this.btEli);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btNuevo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txphone);
            this.Controls.Add(this.txCompany);
            this.Controls.Add(this.dgShipper);
            this.Name = "Shipper";
            this.Text = "Shipper";
            this.Load += new System.EventHandler(this.Shipper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgShipper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgShipper;
        private System.Windows.Forms.TextBox txCompany;
        private System.Windows.Forms.TextBox txphone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btEli;
        private System.Windows.Forms.TextBox txShipper;
    }
}