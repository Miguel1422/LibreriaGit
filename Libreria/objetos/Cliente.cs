using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.objetos
{
    class Cliente
    {
        private int clave;
        private string nombre;
        private string direccion;
        private string correo;
        private string telefono;
        private string fecha;

        public Cliente(int clave, string nombre, string direccion, string correo, string telefono, string fecha)
        {
            this.clave = clave;
            this.nombre = nombre;
            this.direccion = direccion;
            this.correo = correo;
            this.telefono = telefono;
            this.fecha = fecha;
        }

        public int Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        


        public override string ToString()
        {
            string aux = String.Join("|", clave, nombre, direccion, correo, telefono, fecha);


            return aux;
        }

    }
}
