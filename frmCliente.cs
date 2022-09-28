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
            //La clase StreamWriter se usa para escribir caracteres en una secuencia.
            //Utiliza la clase TextWriter como clase base y proporciona los métodos de sobrecarga para escribir datos en un archivo.
            //StreamWriter se utiliza principalmente para escribir varios caracteres de datos en un archivo.
            TextWriter CargaDatos = new StreamWriter("./cliente.txt", true);

            CargaDatos.WriteLine(Convert.ToString(txtClienteID.Text + " " + txtCliente.Text));
            CargaDatos.Close();

            //Aparece una MessageBox y te informa sobre la carga de datos
            MessageBox.Show("Cliente cargado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Limpia las TextBox
            txtCliente.Text = "";
            txtClienteID.Text = "";
            txtCliente.Focus();






        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtClienteID_TextChanged(object sender, EventArgs e)
        {
            //Si la TextBox es diferente a nada (null)
            //El boton btnAceptar se activa (Propiedad .Enabled)
            if (txtClienteID.Text != "")
            {
                btnAceptar.Enabled = true;
            }
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtClienteID_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
