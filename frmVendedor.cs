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
    public partial class frmVendedor : Form
    {
        public frmVendedor()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            //Uso de condicional "If" para saber si el vendedor cobra comision o no y si es activo o no.

            //Si la checkboxActivo esta marcada (.Checked) == true 
            if (chkActivo.Checked == true)
            {
                //Si la checkboxComision esta marcada (.Checked) == true 
                if (chkComision.Checked == true)
                {
                    TextWriter escribirVendedorActivo = new StreamWriter("./vendedor.txt", true);

                    escribirVendedorActivo.WriteLine(Convert.ToString(txtVendedorID.Text + " " + txtVendedor.Text + " " + "-Activo: SI-" + " // " + "-Cobra Comisión: SI"));
                    escribirVendedorActivo.Close();
                    MessageBox.Show("Vendedor cargado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //Si la checkboxComision NO esta marcada (.Checked) == false
                if (chkComision.Checked == false)
                {
                    TextWriter escribirVendedorActivo = new StreamWriter("./vendedor.txt", true);

                    escribirVendedorActivo.WriteLine(Convert.ToString(txtVendedorID.Text + " " + txtVendedor.Text + " " + "-Activo: SI-" + " // " + "-Cobra Comisión: NO"));
                    escribirVendedorActivo.Close();
                    MessageBox.Show("Vendedor cargado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            //Si la checkboxActivo NO esta marcada (.Checked) == false 
            if (chkActivo.Checked == false)
            {
                //Si la checkboxComision esta marcada (.Checked) == true 
                if (chkComision.Checked == true)
                {
                    TextWriter escribirVendedorActivo = new StreamWriter("./vendedor.txt", true);

                    escribirVendedorActivo.WriteLine(Convert.ToString(txtVendedorID.Text + " " + txtVendedor.Text + " " + "-Activo: NO-" + " // " + "-Cobra Comisión: SI"));
                    escribirVendedorActivo.Close();
                    MessageBox.Show("Vendedor cargado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                //Si la checkboxComision NO esta marcada (.Checked) == false
                if (chkComision.Checked == false)
                {
                    TextWriter escribirVendedorActivo = new StreamWriter("./vendedor.txt", true);

                    escribirVendedorActivo.WriteLine(Convert.ToString(txtVendedorID.Text + " " + txtVendedor.Text + " " + "-Activo: NO-" + " // " + "-Cobra Comisión: NO"));
                    escribirVendedorActivo.Close();
                    MessageBox.Show("Vendedor cargado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }




        }

        private void txtVendedor_TextChanged(object sender, EventArgs e)
        {
            
            
            
        }

        private void txtVendedorID_TextChanged(object sender, EventArgs e)
        {
            if (txtVendedorID.Text != "")
            {
                btnAceptar.Enabled = true;
            }
        }

        private void txtVendedorID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Identificacion si el usuario apreta una tecla que no este permitida en la TextBox a traves del uso del evento "KeyPress"
            //Uso de codigo ASCII
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan numeros", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtVendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Identificacion si el usuario apreta una tecla que no este permitida en la TextBox a traves del uso del evento "KeyPress"
            //Uso de codigo ASCII
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan letras", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
