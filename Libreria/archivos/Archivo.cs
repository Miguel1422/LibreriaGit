using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.archivos
{
    abstract class Archivo
    {



        abstract public void writeFile(string texto, string archivo);
        abstract public bool writeFile(string file, string text, bool append);

        abstract public string readFile(string archivo);





        public bool createDir(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                return true;

            }
            return false;
        }

        public bool createFile(string file)
        {
            if (!File.Exists(file))
            {
                using (StreamWriter tw = new StreamWriter(file))
                {
                    tw.Close();
                    return true;
                }
            }
            return false;
        }
    }
}
