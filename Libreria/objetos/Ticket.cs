using System;
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
        

        Dictionary<Libro, int> productos;

        public Ticket(string folio, string fecha, Cliente cliente, double total, Dictionary<Libro, int> productos)
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

        public Dictionary<Libro, int> Productos
        {
            get { return productos; }
            set { productos = value; }
        }


        private double sacarTotal()
        {
            double total = 0;
            foreach(KeyValuePair<Libro, int> l in productos){
                total += l.Key.Precio * l.Value;
            }

            return total;
        }
    }
}
