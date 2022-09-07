namespace pryParedesSP1VenKraktus
{
    partial class frmVenKaktus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenKaktus));
            this.mspRegistro = new System.Windows.Forms.MenuStrip();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeVendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.mspRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mspRegistro
            // 
            this.mspRegistro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.mspRegistro.Location = new System.Drawing.Point(0, 0);
            this.mspRegistro.Name = "mspRegistro";
            this.mspRegistro.Size = new System.Drawing.Size(340, 24);
            this.mspRegistro.TabIndex = 0;
            this.mspRegistro.Text = "menuStrip1";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeClienteToolStripMenuItem,
            this.registroDeVendedorToolStripMenuItem,
            this.ventasToolStripMenuItem});
            this.registroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroToolStripMenuItem.Image")));
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.registroToolStripMenuItem.Text = "Registro de datos";
            // 
            // registroDeClienteToolStripMenuItem
            // 
            this.registroDeClienteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroDeClienteToolStripMenuItem.Image")));
            this.registroDeClienteToolStripMenuItem.Name = "registroDeClienteToolStripMenuItem";
            this.registroDeClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registroDeClienteToolStripMenuItem.Text = "Cliente";
            this.registroDeClienteToolStripMenuItem.Click += new System.EventHandler(this.registroDeClienteToolStripMenuItem_Click);
            // 
            // registroDeVendedorToolStripMenuItem
            // 
            this.registroDeVendedorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroDeVendedorToolStripMenuItem.Image")));
            this.registroDeVendedorToolStripMenuItem.Name = "registroDeVendedorToolStripMenuItem";
            this.registroDeVendedorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registroDeVendedorToolStripMenuItem.Text = "Vendedor";
            this.registroDeVendedorToolStripMenuItem.Click += new System.EventHandler(this.registroDeVendedorToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ventasToolStripMenuItem.Image")));
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(35, 24);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(281, 81);
            this.lblBienvenido.TabIndex = 2;
            this.lblBienvenido.Text = "VenKaktus";
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.Location = new System.Drawing.Point(22, 101);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(294, 28);
            this.lblSlogan.TabIndex = 3;
            this.lblSlogan.Text = "\" Programado para su negocio\"";
            // 
            // frmVenKaktus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 172);
            this.Controls.Add(this.lblSlogan);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.mspRegistro);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mspRegistro;
            this.Name = "frmVenKaktus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa VenKaktus";
            this.mspRegistro.ResumeLayout(false);
            this.mspRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mspRegistro;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeVendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Label lblSlogan;
    }
}

