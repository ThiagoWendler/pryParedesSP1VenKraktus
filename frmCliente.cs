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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TextWriter CargaDatos = new StreamWriter("./cliente.txt", true);

            CargaDatos.WriteLine(Convert.ToString(txtClienteID.Text + " " + txtCliente.Text));
            CargaDatos.Close();

            MessageBox.Show("Cliente cargado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtCliente.Text = "";
            txtClienteID.Text = "";
            txtCliente.Focus();

           
            

            

        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtClienteID_TextChanged(object sender, EventArgs e)
        {
            if (txtClienteID.Text != "")
            {
                btnAceptar.Enabled = true;
            }
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan letras", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }


        }

        private void txtClienteID_KeyPress(object sender, KeyPressEventArgs e)
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
