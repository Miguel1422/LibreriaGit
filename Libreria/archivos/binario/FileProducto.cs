using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria.objetos;
using System.IO;

namespace Libreria.archivos.binario
{
    class FileProducto
    {
        public bool restarProducto(int key, int valor)
        {
            using (BinaryReader binR = new BinaryReader(File.Open(Constantes.PRODUCT_FILE, FileMode.Open)))
            using (BinaryWriter binW = new BinaryWriter(File.Open(Constantes.TEMP_DIRECTORY + "temp.dat", FileMode.OpenOrCreate)))
            {
                string l;
                while ((l = binR.ReadString()) != null)
                {
                    string[] token = l.Split('|');
                    int clave = int.Parse(token[0]);
                    if (clave != key)
                    {
                        binW.Write(l);
                    } else
                    {
                        int can = int.Parse(token[5]) - valor < 0 ? 0 : int.Parse(token[5]) - valor;
                        binW.Write(new Libro(clave,token[1],token[2], token[3], token[4], can, double.Parse(token[6])).ToString());
                        return true;
                    }
                }
            }
            return false;
        }

        public void guardarProducto(Libro l)
        {
            using (BinaryWriter binWriter =
               new BinaryWriter(File.Open(Constantes.PRODUCT_FILE, FileMode.Append)))
            {
                binWriter.Write(l.ToString());
            }
        }

    }
}
