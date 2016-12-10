using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.archivos.binario
{
    class ArchivoBinario : Archivo
    {
        public override string readFile(string archivo)
        {
            return File.ReadAllBytes(archivo).ToString();
        }

        public override void writeFile(string texto, string archivo)
        {
            byte[] bytes = new byte[texto.Length];
            char [] arr = texto.ToCharArray();
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = (byte)arr[i];
            }

            File.WriteAllBytes(archivo, bytes);
            
        }

        public override void writeFile(string file, string texto, bool append)
        {
            byte[] bytes = new byte[texto.Length];
            char[] arr = texto.ToCharArray();
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = (byte)arr[i];
            }

            File.WriteAllBytes(file, bytes);

            
        }
    }
}
