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
            foreach (Libro item in productos)
            {
                producto += item.Clave + " " + item.Titulo + " $" + item.Precio + " x" + item.Copias + " = " + (item.Precio * item.Copias)  +  "\n";
            }
            string aux = String.Join("\n", "No. de folio: " + folio, "Fecha " + fecha, cliente.Nombre, "Telefono " +cliente.Telefono, producto, "Total: " + Total);
            return aux;
        }
    }
}
