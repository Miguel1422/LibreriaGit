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
        abstract public void writeFile(string file, string text, bool append);

        abstract public string readFile(string archivo);





        public static bool createDir(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                return true;

            }
            return false;
        }

        public static bool createFile(string file)
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

        public static bool copyFile(string file, string to)
        {

            File.Copy(file, to, true);
            
            return true;
        }
    }
}
