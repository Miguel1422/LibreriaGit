using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria.objetos;

namespace Libreria.archivos.texto
{
    class FileTicket:ArchivoTexto
    {

        public void guardarTicket(Ticket cl)
        {
            writeFile(Constantes.FOLIO_DIRECTORY + cl.Folio + ".txt", cl.ToString(), false);
        }
    }
}
