using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryParedesSP1VenKraktus
{
    public partial class frmVenKaktus : Form
    {
        public frmVenKaktus()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult s = MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (s == DialogResult.Yes)
            {
                Application.Exit();
            }
            
            
        }

        private void registroDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente rcliente = new frmCliente();
            rcliente.ShowDialog();
        }

        private void registroDeVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendedor rvendedor = new frmVendedor();  
            rvendedor.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentas rventas = new frmVentas();
            rventas.ShowDialog();
        }
    }
}
