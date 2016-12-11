using System;
using System.Windows.Forms;
using Libreria.archivos;
using Libreria.archivos.texto;
using Libreria.archivos.binario;
using Libreria.objetos;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Drawing.Printing;
using System.Drawing;

namespace Libreria
{
    public partial class FrmVentas : Form
    {
        Cliente c;
        Ticket t;
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void tbFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbNoControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbClaveP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnBuscarC_Click(object sender, EventArgs e)
        {

            if (tbClaveC.Text.Equals(""))
            {
                MessageBox.Show("Ingresa la clave del cliente");
                return;
            }
            FileCliente fc = new FileCliente();
            try
            {
                c = fc.buscarCliente(int.Parse(tbClaveC.Text));
                tbNombre.Text = c.Nombre;
                tbTelefono.Text = c.Telefono;
                tbDireccion.Text = c.Direccion;
            }
            catch (Exception)
            {
                MessageBox.Show("Cliente no encontrado");
            }

        }

        private void btnBuscarP_Click(object sender, EventArgs e)
        {
            if (tbClaveP.Text.Equals(""))
            {
                MessageBox.Show("Ingresa la clave del producto");
                return;
            }
            FileProducto fc = new FileProducto();
            try
            {
                Libro c = fc.buscarLibro(int.Parse(tbClaveP.Text));
                tbProducto.Text = c.Titulo;
                tbExistencia.Text = c.Copias + "";
                tbPrecio.Text = c.Precio + "";
            }
            catch (Exception)
            {
                MessageBox.Show("Producto no encontrado");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (tbProducto.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el producto");
                return;
            }
            else if (tbCantidad.Text.Equals(""))
            {
                MessageBox.Show("Ingrese la cantidad");
                return;
            }

            DataGridViewRow row = (DataGridViewRow)dgProductos.Rows[0].Clone();
            row.Cells[0].Value = tbClaveP.Text;
            row.Cells[1].Value = tbProducto.Text;
            row.Cells[2].Value = tbPrecio.Text;
            row.Cells[3].Value = tbCantidad.Text;
            row.Cells[4].Value = double.Parse(tbPrecio.Text) * 
                int.Parse(tbCantidad.Text);
            dgProductos.Rows.Add(row);

            //dgProductos.Rows.Add(tbProducto.Text, tbPrecio.Text, tbCantidad.Text, 
            //double.Parse(tbPrecio.Text) * int.Parse(tbCantidad.Text));
            actualizarPrecio();

        }

        private void actualizarPrecio()
        {
            int n = dgProductos.RowCount;
            double total = 0;
            foreach (DataGridViewRow row in dgProductos.Rows)
            {
                if ((row.Cells[4]).Value != null)
                    total += double.Parse((row.Cells[4]).Value.ToString());
            }

            tbTotal.Text = "" + total;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!comprobarCampos())
            {
                return;
            }

            ArrayList a = getLibros();

            
            FileProducto fp = new FileProducto();
            foreach (Libro item in a)
            {
                if (fp.restarProducto(item.Clave, item.Copias) != item.Copias)
                {
                    MessageBox.Show("No exite tanto inventario para " + item.Titulo );
                    return;
                } else
                {
                    Archivo.copyFile(Constantes.TEMP_DIRECTORY + "temp.dat", 
                        Constantes.PRODUCT_FILE);
                }
                
            }

            t = new Ticket(tbFolio.Text, dtFecha.Text, c, 
                double.Parse(tbTotal.Text), a);

            Console.WriteLine(t.ToString());

            FileTicket ft = new FileTicket();

            ft.guardarTicket(t);

            btnImprimir.Enabled = true;


        }

        private ArrayList getLibros()
        {
            ArrayList temp = new ArrayList();

            foreach (DataGridViewRow row in dgProductos.Rows)
            {
                if ((row.Cells[3]).Value != null)
                {
                    Libro aux = new FileProducto().
                        buscarLibro(int.Parse((row.Cells[0]).Value.ToString()));
                    aux.Copias = int.Parse((row.Cells[3]).Value.ToString());
                    temp.Add(aux);
                }

            }
            return temp;
        }


        private bool comprobarCampos()
        {
            if (tbFolio.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el folio");
                return false;
            }
            else if (tbNombre.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el cliente");
                return false;
            }
            else if (dgProductos.RowCount < 2)
            {
                MessageBox.Show("Ingrese los productos");
                return false;
            }

            return true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgProductos.SelectedRows)
            {
                if (dgProductos.RowCount > 1)
                {
                    try
                    {
                        dgProductos.Rows.RemoveAt(item.Index);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Intentando eliminar fila invalida");
                    }

                }

            }

            actualizarPrecio();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            
            print(Constantes.FOLIO_DIRECTORY + t.Folio + ".txt");
        }


        private void print(string file)
        {
            Font printFont = new Font("Arial", 10);
            using (StreamReader Printfile = new StreamReader(file))
            {
                try
                {
                    PrintDocument docToPrint = new PrintDocument();
                    docToPrint.DocumentName = "Ticket"; //Name that appears in the printer queue
                    docToPrint.PrintPage += (s, ev) =>
                    {
                        float linesPerPage = 0;
                        float yPos = 0;
                        int count = 0;
                        float leftMargin = ev.MarginBounds.Left;
                        float topMargin = ev.MarginBounds.Top;
                        string line = null;

                        // Calculate the number of lines per page.
                        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);

                        // Print each line of the file. 
                        while (count < linesPerPage && ((line = Printfile.ReadLine()) != null))
                        {
                            yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
                            ev.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
                            count++;
                        }

                        // If more lines exist, print another page. 
                        if (line != null)
                            ev.HasMorePages = true;
                        else
                            ev.HasMorePages = false;
                    };
                    docToPrint.Print();
                }
                catch (System.Exception f)
                {
                    MessageBox.Show(f.Message);
                }
            }
        }


    }
}
