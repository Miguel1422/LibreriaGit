﻿using System;
using System.Windows.Forms;
using Libreria.objetos;
using Libreria.archivos;
using Libreria.archivos.binario;

namespace Libreria
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
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

        private void tbIsbn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar)
                && e.KeyChar != (char)Keys.Back
                && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void tbAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back
                && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void tbCopias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!comprobarCampos())
            {
                return;
            }

            Libro l = new Libro(int.Parse(tbClave.Text), tbIsbn.Text,
                tbTitulo.Text, tbAutor.Text, tbEditorial.Text, 
                int.Parse(tbCopias.Text), double.Parse(tbPrecio.Text));
            FileProducto fp = new FileProducto();

            try
            {
                fp.guardarProducto(l);
                MessageBox.Show("Producto guardado");
                limpiarCampos();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            

        }



        private bool comprobarCampos()
        {
            if (tbClave.Text.Equals(""))
            {
                MessageBox.Show("Ingresa la clave");
                return false;
            }
            else if (tbIsbn.Text.Equals(""))
            {
                MessageBox.Show("Ingresa el ISBN");
                return false;
            }
            else if (tbTitulo.Text.Equals(""))
            {
                MessageBox.Show("Ingresa el titulo");
                return false;
            }
            else if (tbAutor.Text.Equals(""))
            {
                MessageBox.Show("Ingresa el autor");
                return false;
            }
            else if (tbEditorial.Text.Equals(""))
            {
                MessageBox.Show("Ingresa el editorial");
                return false;
            }
            else if (tbCopias.Text.Equals(""))
            {
                MessageBox.Show("Ingresa el numero de copias");
                return false;
            }
            else if (tbPrecio.Text.Equals(""))
            {
                MessageBox.Show("Ingresa el precio");
                return false;
            }


            return true;
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {

            if (tbClave.Text.Equals(""))
            {
                MessageBox.Show("Ingrese la clave");
                return;
            }

            try
            {
                FileProducto fp = new FileProducto();

                Libro l = fp.buscarLibro(int.Parse(tbClave.Text));

                tbIsbn.Text = l.Isbn;
                tbTitulo.Text = l.Titulo;
                tbAutor.Text = l.Autor;
                tbEditorial.Text = l.Editorial;
                tbCopias.Text = l.Copias + "";
                tbPrecio.Text = l.Precio + "";
            }
            catch (Exception)
            {

                MessageBox.Show("Libro no encontrado");
            }
            
            


        }

        private void btnElimina_Click(object sender, EventArgs e)
        {

            if (tbClave.Text.Equals(""))
            {
                MessageBox.Show("Ingrese la clave");
                return;
            }
            try
            {
                FileProducto fp = new FileProducto();
                if (fp.eliminarLibro(int.Parse(tbClave.Text)))
                {
                    limpiarCampos();
                    Archivo.copyFile(Constantes.TEMP_DIRECTORY + "temp.dat", Constantes.PRODUCT_FILE);
                    
                    MessageBox.Show("Producto eliminado");
                    

                } else
                {
                    MessageBox.Show("Producto no encontrado");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Producto no encontrado");
            }
            


        }


        private void limpiarCampos()
        {
            tbClave.Text = "";
            tbIsbn.Text = "";
            tbTitulo.Text = "";
            tbAutor.Text = "";
            tbEditorial.Text = "";
            tbCopias.Text = "";
            tbPrecio.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (!comprobarCampos())
            {
                return;
            }
            try
            {
                FileProducto fp = new FileProducto();
                Libro li = new Libro(int.Parse(tbClave.Text), tbIsbn.Text, tbTitulo.Text, tbAutor.Text,tbEditorial.Text,int.Parse(tbCopias.Text),double.Parse(tbPrecio.Text));
                if (fp.editarLibro(int.Parse(tbClave.Text), li))
                {
                    MessageBox.Show("Producto editado");
                    Archivo.copyFile(Constantes.TEMP_DIRECTORY + "temp.dat", Constantes.PRODUCT_FILE);
                }
                else
                {
                    MessageBox.Show("Producto no encontrado");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Producto no encontrado");
            }
        }
    }
}
