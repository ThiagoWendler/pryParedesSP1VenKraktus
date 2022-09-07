namespace pryParedesSP1VenKraktus
{
    partial class frmVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendedor));
            this.lblVendedorID = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.txtVendedorID = new System.Windows.Forms.TextBox();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.chkComision = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVendedorID
            // 
            this.lblVendedorID.AutoSize = true;
            this.lblVendedorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedorID.Location = new System.Drawing.Point(49, 78);
            this.lblVendedorID.Name = "lblVendedorID";
            this.lblVendedorID.Size = new System.Drawing.Size(140, 20);
            this.lblVendedorID.TabIndex = 9;
            this.lblVendedorID.Text = "ID del Vendedor";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.Location = new System.Drawing.Point(30, 20);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(183, 20);
            this.lblVendedor.TabIndex = 8;
            this.lblVendedor.Text = "Nombre del Vendedor";
            // 
            // txtVendedorID
            // 
            this.txtVendedorID.Location = new System.Drawing.Point(65, 101);
            this.txtVendedorID.MaxLength = 3;
            this.txtVendedorID.Name = "txtVendedorID";
            this.txtVendedorID.Size = new System.Drawing.Size(100, 20);
            this.txtVendedorID.TabIndex = 7;
            this.txtVendedorID.TextChanged += new System.EventHandler(this.txtVendedorID_TextChanged);
            this.txtVendedorID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVendedorID_KeyPress);
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(66, 43);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(100, 20);
            this.txtVendedor.TabIndex = 6;
            this.txtVendedor.TextChanged += new System.EventHandler(this.txtVendedor_TextChanged);
            this.txtVendedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVendedor_KeyPress);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(66, 174);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 31);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivo.Location = new System.Drawing.Point(69, 127);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(91, 22);
            this.chkActivo.TabIndex = 10;
            this.chkActivo.Text = "¿Activo?";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // chkComision
            // 
            this.chkComision.AutoSize = true;
            this.chkComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkComision.Location = new System.Drawing.Point(34, 146);
            this.chkComision.Name = "chkComision";
            this.chkComision.Size = new System.Drawing.Size(168, 22);
            this.chkComision.TabIndex = 11;
            this.chkComision.Text = "¿Cobra Comisión?";
            this.chkComision.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // frmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 220);
            this.Controls.Add(this.chkComision);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.lblVendedorID);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.txtVendedorID);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Vendedor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVendedorID;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.TextBox txtVendedorID;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.CheckBox chkComision;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}