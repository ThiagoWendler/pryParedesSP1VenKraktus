using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryParedesSP1VenKraktus
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            StreamReader clienteID = new StreamReader("./cliente.txt");
            StreamReader vendedorID = new StreamReader("./vendedor.txt");

            char separador = Convert.ToChar(" ");

            while (!clienteID.EndOfStream)
            {
                string[] cliente = clienteID.ReadLine().Split(separador);
                cbxClienteID.Items.Add(cliente[0]);
            }
            while (!vendedorID.EndOfStream)
            {
                string[] vendedor = vendedorID.ReadLine().Split(separador);
                cbxVendedorID.Items.Add(vendedor[0]);
            }

            clienteID.Close();
            vendedorID.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TextWriter eVentas = new StreamWriter("./ventas.txt", true);

            eVentas.WriteLine(Convert.ToString("ID del Cliente: " + cbxClienteID.Text + "\nID del Vendedor: " + cbxVendedorID.Text + "\nTipo de Factura: " + cbxFactura.Text + "\nNumero de factura: " + txtFactura.Text + "\nMonto: " + txtMonto.Text + "\nFecha: " + dtpFecha.Text));
            eVentas.Close();

            DialogResult ndatos = MessageBox.Show("¡Datos registrados con exito!" + "\n¿Desea registrar nuevamente mas datos?", "Exito", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ndatos == DialogResult.Yes)
            {
                cbxClienteID.Text = "";
                cbxVendedorID.Text = "";
                cbxFactura.Text = "";
                txtFactura.Text = "";
                txtMonto.Text = "";
            }
            if (ndatos == DialogResult.No)
            {
                this.Close();
            }
        }

        private void txtFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan numeros", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
                    
            }
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan numeros", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }
    }
}
