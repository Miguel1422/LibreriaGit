using System;
using Libreria.objetos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.archivos.texto
{
    class FileCliente : ArchivoTexto
    {
        public Cliente buscarCliente(int key)
        {
            string file = readFile(Constantes.USER_FILE);
            string[] lineas = file.Split('\n');

            for (int i = 0; i < lineas.Length; i++)
            {
                string[] ac = (lineas[i]).Split('|');
                int clave = int.Parse(ac[0]);
                if (key == clave)
                {
                    return new Cliente(clave, ac[1], ac[2], ac[3], ac[4], ac[5]);
                }
            }

            return null;
        }

    }
}
