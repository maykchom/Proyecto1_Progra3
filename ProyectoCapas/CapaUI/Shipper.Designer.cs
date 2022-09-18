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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelEE = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgShipper)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelEE.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgShipper
            // 
            this.dgShipper.AllowUserToAddRows = false;
            this.dgShipper.AllowUserToDeleteRows = false;
            this.dgShipper.AllowUserToResizeColumns = false;
            this.dgShipper.AllowUserToResizeRows = false;
            this.dgShipper.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgShipper.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgShipper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgShipper.Location = new System.Drawing.Point(12, 216);
            this.dgShipper.Margin = new System.Windows.Forms.Padding(2);
            this.dgShipper.Name = "dgShipper";
            this.dgShipper.ReadOnly = true;
            this.dgShipper.RowHeadersWidth = 51;
            this.dgShipper.RowTemplate.Height = 24;
            this.dgShipper.Size = new System.Drawing.Size(857, 466);
            this.dgShipper.TabIndex = 0;
            this.dgShipper.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgShipper_CellClick);
            // 
            // txCompany
            // 
            this.txCompany.Location = new System.Drawing.Point(110, 66);
            this.txCompany.Margin = new System.Windows.Forms.Padding(2);
            this.txCompany.Name = "txCompany";
            this.txCompany.Size = new System.Drawing.Size(110, 21);
            this.txCompany.TabIndex = 1;
            this.txCompany.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txCompany_KeyPress);
            // 
            // txphone
            // 
            this.txphone.Location = new System.Drawing.Point(111, 105);
            this.txphone.Margin = new System.Windows.Forms.Padding(2);
            this.txphone.Name = "txphone";
            this.txphone.Size = new System.Drawing.Size(110, 21);
            this.txphone.TabIndex = 2;
            this.txphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txphone_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "CompanyName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "ShipperID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 6;
            // 
            // btNuevo
            // 
            this.btNuevo.Location = new System.Drawing.Point(891, 484);
            this.btNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(100, 37);
            this.btNuevo.TabIndex = 7;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.UseVisualStyleBackColor = true;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(2, 2);
            this.btEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(100, 37);
            this.btEditar.TabIndex = 8;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(1022, 484);
            this.btGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(100, 37);
            this.btGuardar.TabIndex = 9;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btEli
            // 
            this.btEli.Location = new System.Drawing.Point(133, 2);
            this.btEli.Margin = new System.Windows.Forms.Padding(2);
            this.btEli.Name = "btEli";
            this.btEli.Size = new System.Drawing.Size(100, 37);
            this.btEli.TabIndex = 10;
            this.btEli.Text = "Eliminar";
            this.btEli.UseVisualStyleBackColor = true;
            this.btEli.Click += new System.EventHandler(this.btEli_Click);
            // 
            // txShipper
            // 
            this.txShipper.Enabled = false;
            this.txShipper.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txShipper.Location = new System.Drawing.Point(110, 29);
            this.txShipper.Margin = new System.Windows.Forms.Padding(2);
            this.txShipper.Name = "txShipper";
            this.txShipper.Size = new System.Drawing.Size(110, 21);
            this.txShipper.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 49);
            this.label5.TabIndex = 12;
            this.label5.Text = "SHIPPERS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txCompany);
            this.groupBox1.Controls.Add(this.txShipper);
            this.groupBox1.Controls.Add(this.txphone);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(877, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 154);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaUI.Properties.Resources.ExpenTItulo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1101, 110);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // panelEE
            // 
            this.panelEE.Controls.Add(this.btEditar);
            this.panelEE.Controls.Add(this.btEli);
            this.panelEE.Enabled = false;
            this.panelEE.Location = new System.Drawing.Point(890, 526);
            this.panelEE.Name = "panelEE";
            this.panelEE.Size = new System.Drawing.Size(248, 46);
            this.panelEE.TabIndex = 16;
            // 
            // Shipper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1151, 786);
            this.Controls.Add(this.panelEE);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btNuevo);
            this.Controls.Add(this.dgShipper);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Shipper";
            this.Text = "Shipper";
            this.Load += new System.EventHandler(this.Shipper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgShipper)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelEE.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelEE;
    }
}