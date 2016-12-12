
using System;
using System.Drawing;
using System.Windows.Forms;
using Libreria.archivos;
using Libreria.archivos.texto;
using Libreria.objetos;
using Libreria.otros;

namespace Libreria
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();

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
            if (!char.IsLetter(e.KeyChar)
                && e.KeyChar != (char)Keys.Back
                && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void tbDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar)
                && e.KeyChar != (char)Keys.Back
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != (char)Keys.Space
                && e.KeyChar != '#'
                && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void tbCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar)
                && e.KeyChar != (char)Keys.Back
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '@'
                && e.KeyChar != '.'
                && e.KeyChar != '_'
                && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar)
                && e.KeyChar != (char)Keys.Back
                && e.KeyChar != '+'
                && e.KeyChar != '('
                && e.KeyChar != ')'
                && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (!comprobarCampos())
            {
                return;
            }



            try
            {
                Cliente cl = new Cliente(int.Parse(tbClave.Text), tbNombre.Text, tbDireccion.Text,
                tbCorreo.Text, tbTelefono.Text, dtFecha.Text);

                Archivo.copyFile(Constantes.TEMP_DIRECTORY + "temp.jpg", Constantes.IMG_DIRECTORY + tbClave.Text + ".jpg");
                ArchivoTexto ar = new ArchivoTexto();
                FileCliente fc = new FileCliente();
                fc.guardarCliente(cl);
                //ar.writeFile(Constantes.USER_FILE, cl.ToString(), true);
                limpiarCampos();
            }
            catch (Exception)
            {
                MessageBox.Show("Error Cliente no encontrado");
            }




        }




        private Image getCopyImage(string path)
        {
            using (Image im = Image.FromFile(path))
            {
                Bitmap bm = new Bitmap(im);
                return bm;
            }
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagenes (*.jpg) | *.jpg";
            dialog.InitialDirectory = @"C:\";
            dialog.Title = "Selecciona una imagen";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Archivo.copyFile(dialog.FileName, Constantes.TEMP_DIRECTORY + "temp.jpg");
                //Image img = Image.FromFile(Constantes.TEMP_DIRECTORY + "temp.jpg");

                //pbImagen.Load(Constantes.TEMP_DIRECTORY + "temp.jpg");

                pbImagen.ImageLocation = Constantes.TEMP_DIRECTORY + "temp.jpg";
                pbImagen.Image = getCopyImage(Constantes.TEMP_DIRECTORY + "temp.jpg");

            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (tbClave.Text == "")
            {
                MessageBox.Show("Ingresa la clave");
                return;
            }

            FileCliente fc = new FileCliente();
            try
            {

                Cliente c = fc.buscarCliente(int.Parse(tbClave.Text));
                tbNombre.Text = c.Nombre;
                tbDireccion.Text = c.Direccion;
                tbCorreo.Text = c.Correo;
                tbTelefono.Text = c.Telefono;
                dtFecha.Text = c.Fecha;
                //pbImagen.Image = Image.FromFile(Constantes.IMG_DIRECTORY + c.Clave + ".jpg");

                //pbImagen.Load(Constantes.IMG_DIRECTORY + c.Clave + ".jpg");

                pbImagen.ImageLocation = Constantes.IMG_DIRECTORY + c.Clave + ".jpg";
                pbImagen.Image = getCopyImage(Constantes.IMG_DIRECTORY + c.Clave + ".jpg");
            }
            catch (Exception)
            {
                MessageBox.Show("Error Cliente no encontrado");
                limpiarCampos();
            }
            finally
            {
                fc = null;
                GC.Collect();

            }


        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (tbClave.Text == "")
            {
                MessageBox.Show("Ingresa la clave");
                return;
            }

            FileCliente fc = new FileCliente();
            try
            {
                if (!fc.eliminarCliente(int.Parse(tbClave.Text)))
                {
                    MessageBox.Show("Error Cliente no encontrado");

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error Cliente no encontrado");

            }
            finally
            {
                fc = null;
                limpiarCampos();
            }

        }

        private bool comprobarCampos()
        {
            if (tbClave.Text.Equals(""))
            {
                MessageBox.Show("Ingresa la clave");
                return false;
            }
            else if (tbNombre.Text.Equals(""))
            {
                MessageBox.Show("Ingresa el nombre");
                return false;
            }
            else if (tbDireccion.Text.Equals(""))
            {
                MessageBox.Show("Ingresa la direccion");
                return false;
            }
            else if (tbCorreo.Text.Equals(""))
            {
                MessageBox.Show("Ingresa el correo");
                return false;
            }
            else if (tbTelefono.Text.Equals(""))
            {
                MessageBox.Show("Ingresa el telefono");
                return false;
            }
            else if (pbImagen.Image == null)
            {
                MessageBox.Show("Ingresa la imagen");
                return false;
            }
            else if (!emailValido(tbCorreo.Text))
            {
                MessageBox.Show("Email invalido");
                return false;
            }
            return true;
        }

        private bool emailValido(string mail)
        {
            EmailValid am = new EmailValid();
            return am.IsValidEmail(mail);
        }

        private void limpiarCampos()
        {
            tbClave.Text = "";
            tbCorreo.Text = "";
            tbDireccion.Text = "";
            tbNombre.Text = "";
            tbTelefono.Text = "";
            pbImagen.Image = null;
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (!comprobarCampos())
            {
                return;
            }

            //Console.WriteLine(pbImagen.ImageLocation);


            try
            {
                Archivo.copyFile(pbImagen.ImageLocation, Constantes.TEMP_DIRECTORY + "temp.jpg");

                Cliente cl = new Cliente(int.Parse(tbClave.Text), tbNombre.Text, tbDireccion.Text,
                    tbCorreo.Text, tbTelefono.Text, dtFecha.Text);



                Archivo.copyFile(Constantes.TEMP_DIRECTORY + "temp.jpg", Constantes.IMG_DIRECTORY + tbClave.Text + ".jpg");

                pbImagen.ImageLocation = Constantes.TEMP_DIRECTORY + "temp.jpg";
                pbImagen.Image = getCopyImage(Constantes.TEMP_DIRECTORY + "temp.jpg");

                FileCliente fc = new FileCliente();

                fc.editarCliente(cl.Clave, cl);
                MessageBox.Show("Cambios guardados con exito");
            }
            catch (Exception)
            {
                MessageBox.Show("Error usuario no encontrado");
            }




        }
    }
}