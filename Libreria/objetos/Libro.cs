using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.objetos
{
    class Libro
    {
        private int clave;
        private string isbn;
        private string titulo;
        private string autor;
        private string editorial;
        private int copias;
        private double precio;

        public Libro(int clave, string isbn, string titulo, string autor, string editorial, int copias, double precio)
        {
            this.clave = clave;
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
            this.copias = copias;
            this.precio = precio;
        }

        public int Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public string Editorial
        {
            get { return editorial; }
            set { editorial = value; }
        }

        public int Copias
        {
            get { return copias; }
            set { copias = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public override string ToString()
        {
            string aux = String.Join("|", clave, isbn, titulo, autor, editorial, copias, precio);

            return aux;
        }
    }
}
