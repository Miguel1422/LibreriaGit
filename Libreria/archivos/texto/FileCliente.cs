using System;
using Libreria.objetos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

        public bool eliminarCliente(int key)
        {
            StreamReader st = null;
            StreamWriter sw = null;
            bool eliminado = false;
            try
            {
                st = new StreamReader(Constantes.USER_FILE);
                sw = new StreamWriter(Constantes.TEMP_DIRECTORY + "temp.txt");


                string l;
                while ((l = st.ReadLine()) != null)
                {

                    int clave = int.Parse(l.Split('|')[0]);
                    if (clave != key)
                    {
                        sw.WriteLine(l);
                        
                    }
                    else
                    {
                        eliminado = true;
                    }
                }
                
            }
            catch (Exception)
            {

            }
            finally
            {
                st.Close();
                sw.Close();
            }

            if (eliminado)
            {
                copyFile(Constantes.TEMP_DIRECTORY + "temp.txt", Constantes.USER_FILE);
            }
            

            return eliminado;
        }



        public bool editarCliente(int key, Cliente nuevo)
        {

            StreamReader st = null;
            StreamWriter sw = null;
            bool eliminado = false;
            try
            {
                st = new StreamReader(Constantes.USER_FILE);
                sw = new StreamWriter(Constantes.TEMP_DIRECTORY + "temp.txt");


                string l;
                while ((l = st.ReadLine()) != null)
                {

                    int clave = int.Parse(l.Split('|')[0]);
                    if (clave != key)
                    {
                        sw.WriteLine(l);

                    }
                    else
                    {
                        sw.WriteLine(nuevo.ToString());
                        eliminado = true;
                    }
                }

            }
            catch (Exception)
            {

            }
            finally
            {
                st.Close();
                sw.Close();
            }

            if (eliminado)
            {
                copyFile(Constantes.TEMP_DIRECTORY + "temp.txt", Constantes.USER_FILE);
            }


            return eliminado;
        }

    }
}
