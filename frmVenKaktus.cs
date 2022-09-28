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
            //DialogResult, que se basa en el resultado que el usuario de cuando se muestre la MessageBox (Resultados de dialogo: Si - No)
            DialogResult s = MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //Si el resultado del dialogo es Si, la aplicacion se cierra
            if (s == DialogResult.Yes)
            {
                Application.Exit();
            }


        }

        private void registroDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Mostrar el formulario frmCliente
            frmCliente rcliente = new frmCliente();
            rcliente.ShowDialog();
        }

        private void registroDeVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Mostrar el formulario frmVendedor
            frmVendedor rvendedor = new frmVendedor();
            rvendedor.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Mostrar el formulario frmVentas
            frmVentas rventas = new frmVentas();
            rventas.ShowDialog();
        }

        private void frmVenKaktus_Load(object sender, EventArgs e)
        {

        }
    }
}
