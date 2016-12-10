using System;
using System.IO;

namespace Libreria.archivos
{
    class ArchivoTexto
    {
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


        public bool writeFile(string file, string text, bool append)
        {
            using (StreamWriter sw = new StreamWriter(file, append))
            {
                sw.WriteLine(text);
                sw.Close();
                return true;
            }

            //return false;
        }
    }
}
