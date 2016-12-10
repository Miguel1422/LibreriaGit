using System;
using System.IO;
using System.Text;

namespace Libreria.archivos.texto
{
    class ArchivoTexto:Archivo
    {
        public override void writeFile(string texto, string archivo)
        {
            writeFile(texto, archivo, true);
        }

        public override string readFile(string archivo)
        {
            using (StreamReader sr = new StreamReader(archivo))
            {
                return sr.ReadToEnd();
            }

        }

        public override bool writeFile(string file, string text, bool append)
        {
            using (StreamWriter sw = new StreamWriter(file, append, Encoding.Unicode))
            {
                sw.WriteLine(text);
                sw.Close();
                return true;
            }

            //return false;
        }
    }
}
