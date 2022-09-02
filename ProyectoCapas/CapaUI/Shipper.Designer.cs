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
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgShipper)).BeginInit();
            this.SuspendLayout();
            // 
            // dgShipper
            // 
            this.dgShipper.AllowUserToAddRows = false;
            this.dgShipper.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgShipper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgShipper.Location = new System.Drawing.Point(453, 115);
            this.dgShipper.Margin = new System.Windows.Forms.Padding(2);
            this.dgShipper.Name = "dgShipper";
            this.dgShipper.RowHeadersWidth = 51;
            this.dgShipper.RowTemplate.Height = 24;
            this.dgShipper.Size = new System.Drawing.Size(422, 177);
            this.dgShipper.TabIndex = 0;
            this.dgShipper.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgShipper_CellClick);
            // 
            // txCompany
            // 
            this.txCompany.Location = new System.Drawing.Point(157, 187);
            this.txCompany.Margin = new System.Windows.Forms.Padding(2);
            this.txCompany.Name = "txCompany";
            this.txCompany.Size = new System.Drawing.Size(110, 24);
            this.txCompany.TabIndex = 1;
            this.txCompany.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txCompany_KeyPress);
            // 
            // txphone
            // 
            this.txphone.Location = new System.Drawing.Point(157, 234);
            this.txphone.Margin = new System.Windows.Forms.Padding(2);
            this.txphone.Name = "txphone";
            this.txphone.Size = new System.Drawing.Size(110, 24);
            this.txphone.TabIndex = 2;
            this.txphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txphone_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "CompanyName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 234);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "ShipperID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 6;
            // 
            // btNuevo
            // 
            this.btNuevo.Location = new System.Drawing.Point(459, 46);
            this.btNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(100, 64);
            this.btNuevo.TabIndex = 7;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.UseVisualStyleBackColor = true;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(564, 46);
            this.btEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(105, 64);
            this.btEditar.TabIndex = 8;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(673, 46);
            this.btGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(93, 64);
            this.btGuardar.TabIndex = 9;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btEli
            // 
            this.btEli.Location = new System.Drawing.Point(771, 46);
            this.btEli.Margin = new System.Windows.Forms.Padding(2);
            this.btEli.Name = "btEli";
            this.btEli.Size = new System.Drawing.Size(94, 64);
            this.btEli.TabIndex = 10;
            this.btEli.Text = "Eliminar";
            this.btEli.UseVisualStyleBackColor = true;
            this.btEli.Click += new System.EventHandler(this.btEli_Click);
            // 
            // txShipper
            // 
            this.txShipper.Enabled = false;
            this.txShipper.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txShipper.Location = new System.Drawing.Point(157, 133);
            this.txShipper.Margin = new System.Windows.Forms.Padding(2);
            this.txShipper.Name = "txShipper";
            this.txShipper.Size = new System.Drawing.Size(110, 24);
            this.txShipper.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 36);
            this.label5.TabIndex = 12;
            this.label5.Text = "SHIPPERS";
            // 
            // Shipper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 403);
            this.Controls.Add(this.label5);
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
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label label5;
    }
}