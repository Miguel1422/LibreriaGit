using System;
using System.Drawing;
using System.Windows.Forms;
using Libreria.archivos;
using Libreria.archivos.texto;
using Libreria.objetos;

namespace Libreria
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
            Archivo.createDir(Constantes.IMG_DIRECTORY);
            Archivo.createDir(Constantes.TEMP_DIRECTORY);
        }

        private void tbClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back
                && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void tbDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back
                && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Space
                && e.KeyChar != '#' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void tbCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back
                && !char.IsDigit(e.KeyChar) && e.KeyChar != '@'
                && e.KeyChar != '.' && e.KeyChar != '_'
                && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back
                && e.KeyChar != '+'
                && e.KeyChar != '(' && e.KeyChar != ')'
                && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (tbClave.Text.Equals(""))
            {
                MessageBox.Show("Ingresa la clave");
            }
            else if (tbNombre.Text.Equals(""))
            {
                MessageBox.Show("Ingresa el nombre");
            }
            else if (tbDireccion.Text.Equals(""))
            {
                MessageBox.Show("Ingresa la direccion");
            }
            else if (tbCorreo.Text.Equals(""))
            {
                MessageBox.Show("Ingresa el correo");
            }
            else if (tbTelefono.Text.Equals(""))
            {
                MessageBox.Show("Ingresa el telefono");
            } else if (pbImagen.Image == null)
            {
                MessageBox.Show("Ingresa la imagen");
            }

            Cliente cl = new Cliente(int.Parse(tbClave.Text), tbNombre.Text, tbDireccion.Text, 
                tbCorreo.Text, tbTelefono.Text, dtFecha.Text);
            Archivo.copyFile(Constantes.TEMP_DIRECTORY + "temp.jpg", Constantes.IMG_DIRECTORY + tbClave.Text + ".jpg");
            ArchivoTexto ar = new ArchivoTexto();
            ar.writeFile(Constantes.USER_FILE, cl.ToString(), true);
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagenes (*.jpg) | *.jpg";
            dialog.InitialDirectory = @"C:\";
            dialog.Title = "Please select an image file to encrypt.";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Archivo.copyFile(dialog.FileName, Constantes.TEMP_DIRECTORY + "temp.jpg");
                Image img = Image.FromFile(Constantes.TEMP_DIRECTORY + "temp.jpg");
                pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                pbImagen.Image = img;
            }
        }
    }
}
