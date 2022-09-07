namespace pryParedesSP1VenKraktus
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.cbxClienteID = new System.Windows.Forms.ComboBox();
            this.cbxVendedorID = new System.Windows.Forms.ComboBox();
            this.lblClienteID = new System.Windows.Forms.Label();
            this.lblVendedorID = new System.Windows.Forms.Label();
            this.cbxFactura = new System.Windows.Forms.ComboBox();
            this.lblFactura = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.lblNumeroDeFactura = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.gbxIDs = new System.Windows.Forms.GroupBox();
            this.gbxFactura = new System.Windows.Forms.GroupBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbxIDs.SuspendLayout();
            this.gbxFactura.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxClienteID
            // 
            this.cbxClienteID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClienteID.FormattingEnabled = true;
            this.cbxClienteID.Location = new System.Drawing.Point(262, 19);
            this.cbxClienteID.Name = "cbxClienteID";
            this.cbxClienteID.Size = new System.Drawing.Size(121, 21);
            this.cbxClienteID.TabIndex = 0;
            // 
            // cbxVendedorID
            // 
            this.cbxVendedorID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVendedorID.FormattingEnabled = true;
            this.cbxVendedorID.Location = new System.Drawing.Point(262, 50);
            this.cbxVendedorID.Name = "cbxVendedorID";
            this.cbxVendedorID.Size = new System.Drawing.Size(121, 21);
            this.cbxVendedorID.TabIndex = 1;
            // 
            // lblClienteID
            // 
            this.lblClienteID.AutoSize = true;
            this.lblClienteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteID.Location = new System.Drawing.Point(15, 22);
            this.lblClienteID.Name = "lblClienteID";
            this.lblClienteID.Size = new System.Drawing.Size(211, 18);
            this.lblClienteID.TabIndex = 2;
            this.lblClienteID.Text = "Seleccione la ID del cliente";
            // 
            // lblVendedorID
            // 
            this.lblVendedorID.AutoSize = true;
            this.lblVendedorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedorID.Location = new System.Drawing.Point(15, 53);
            this.lblVendedorID.Name = "lblVendedorID";
            this.lblVendedorID.Size = new System.Drawing.Size(231, 18);
            this.lblVendedorID.TabIndex = 3;
            this.lblVendedorID.Text = "Seleccione la ID del vendedor";
            // 
            // cbxFactura
            // 
            this.cbxFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFactura.FormattingEnabled = true;
            this.cbxFactura.Items.AddRange(new object[] {
            "Factura A",
            "Factura B",
            "Factura C",
            "Factura M",
            "Factura E",
            "Factura T"});
            this.cbxFactura.Location = new System.Drawing.Point(182, 19);
            this.cbxFactura.Name = "cbxFactura";
            this.cbxFactura.Size = new System.Drawing.Size(121, 21);
            this.cbxFactura.TabIndex = 4;
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactura.Location = new System.Drawing.Point(29, 130);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(121, 18);
            this.lblFactura.TabIndex = 5;
            this.lblFactura.Text = "Tipo de factura";
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(182, 56);
            this.txtFactura.MaxLength = 4;
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(121, 20);
            this.txtFactura.TabIndex = 6;
            this.txtFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFactura_KeyPress);
            // 
            // lblNumeroDeFactura
            // 
            this.lblNumeroDeFactura.AutoSize = true;
            this.lblNumeroDeFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDeFactura.Location = new System.Drawing.Point(17, 58);
            this.lblNumeroDeFactura.Name = "lblNumeroDeFactura";
            this.lblNumeroDeFactura.Size = new System.Drawing.Size(148, 18);
            this.lblNumeroDeFactura.TabIndex = 7;
            this.lblNumeroDeFactura.Text = "Número de factura";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(158, 251);
            this.dtpFecha.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(237, 20);
            this.dtpFecha.TabIndex = 8;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(182, 92);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(121, 20);
            this.txtMonto.TabIndex = 9;
            this.txtMonto.TextChanged += new System.EventHandler(this.txtMonto_TextChanged);
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(18, 94);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(56, 18);
            this.lblMonto.TabIndex = 10;
            this.lblMonto.Text = "Monto";
            // 
            // gbxIDs
            // 
            this.gbxIDs.Controls.Add(this.cbxVendedorID);
            this.gbxIDs.Controls.Add(this.cbxClienteID);
            this.gbxIDs.Controls.Add(this.lblClienteID);
            this.gbxIDs.Controls.Add(this.lblVendedorID);
            this.gbxIDs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxIDs.Location = new System.Drawing.Point(12, 12);
            this.gbxIDs.Name = "gbxIDs";
            this.gbxIDs.Size = new System.Drawing.Size(402, 91);
            this.gbxIDs.TabIndex = 11;
            this.gbxIDs.TabStop = false;
            this.gbxIDs.Text = "ID Cliente y Vendedor";
            // 
            // gbxFactura
            // 
            this.gbxFactura.Controls.Add(this.txtMonto);
            this.gbxFactura.Controls.Add(this.lblMonto);
            this.gbxFactura.Controls.Add(this.txtFactura);
            this.gbxFactura.Controls.Add(this.cbxFactura);
            this.gbxFactura.Controls.Add(this.lblNumeroDeFactura);
            this.gbxFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFactura.Location = new System.Drawing.Point(12, 109);
            this.gbxFactura.Name = "gbxFactura";
            this.gbxFactura.Size = new System.Drawing.Size(402, 128);
            this.gbxFactura.TabIndex = 12;
            this.gbxFactura.TabStop = false;
            this.gbxFactura.Text = "Factura";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(27, 253);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(105, 18);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha Actual";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(12, 284);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(402, 32);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 326);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFactura);
            this.Controls.Add(this.gbxIDs);
            this.Controls.Add(this.gbxFactura);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.gbxIDs.ResumeLayout(false);
            this.gbxIDs.PerformLayout();
            this.gbxFactura.ResumeLayout(false);
            this.gbxFactura.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxClienteID;
        private System.Windows.Forms.ComboBox cbxVendedorID;
        private System.Windows.Forms.Label lblClienteID;
        private System.Windows.Forms.Label lblVendedorID;
        private System.Windows.Forms.ComboBox cbxFactura;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Label lblNumeroDeFactura;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.GroupBox gbxIDs;
        private System.Windows.Forms.GroupBox gbxFactura;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnAceptar;
    }
}