using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.objetos
{
    class Ticket
    {
        string folio;
        string fecha;
        Cliente cliente;
        double total;
        

        ArrayList productos;

        public Ticket(string folio, string fecha, Cliente cliente, double total, ArrayList productos)
        {
            this.folio = folio;
            this.fecha = fecha;
            this.cliente = cliente;
            this.total = total;
            this.productos = productos;
        }


        public string Folio
        {
            get { return folio; }
            set { folio = value; }
        }

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public Cliente GetCliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public double Total
        {
            get { return sacarTotal(); }
            set { total = value; }
        }

        public ArrayList Productos
        {
            get { return productos; }
            set { productos = value; }
        }


        private double sacarTotal()
        {
            double total = 0;
            foreach(Libro l in productos){
                total += l.Precio * l.Copias;
            }

            return total;
        }

        public override string ToString()
        {
            string producto = "";
            producto+= String.Format("{0,-3}  {1,-28} {2,-6}  {3:6}  {4,5}\n", "No.", "Titulo", "Precio", "Copias", "Total");
            foreach (Libro item in productos)
            {
                string a = String.Format("{0,3}  {1,-28} {2,6}  {3,6}  {4,5}\n", item.Clave, item.Titulo, "$" + item.Precio, item.Copias, "$" + (item.Precio * item.Copias));
                //producto += item.Clave + " " + item.Titulo + " $" + item.Precio + " x" + item.Copias + " = " + (item.Precio * item.Copias)  +  "\n";
                producto += a;
            }
            string foli = String.Format("No. de folio {0,42}", folio);
            string fech = String.Format("Fecha:{0,49}", fecha);
            string dat = String.Format("{0,-35} Tel:{1,15}", cliente.Nombre, cliente.Telefono);
            string tot = String.Format("{0,54}", "Total: " + Total);
            string aux = String.Join("\n", foli, fech, dat,"\n", producto, tot);
            return aux;
        }
    }
}
