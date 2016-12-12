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
        public int restarProducto(int key, int valor)
        {
            
            using (BinaryReader binR = new BinaryReader(File.Open(Constantes.PRODUCT_FILE, FileMode.Open)))
            using (BinaryWriter binW = new BinaryWriter(File.Open(Constantes.TEMP_DIRECTORY + "temp.dat", FileMode.OpenOrCreate)))
            {
                string l;

                while (binR.PeekChar() != -1 && binR.BaseStream.Position != binR.BaseStream.Length)
                {
                    try
                    {
                        l = binR.ReadString();
                        string[] token = l.Split('|');
                        int clave = int.Parse(token[0]);
                        if (clave != key)
                        {
                            //binW.Write(l);
                            binW.Write(new Libro(int.Parse(token[0]), token[1], token[2], token[3], token[4], int.Parse(token[5]), double.Parse(token[6])).ToString());
                        }
                        else
                        {
                            int can = int.Parse(token[5]) - valor < 0 ? 0 : int.Parse(token[5]) - valor;
                            binW.Write(new Libro(clave, token[1], token[2], token[3], token[4], can, double.Parse(token[6])).ToString());
                            binW.Close();
                            binR.Close();
                            //Archivo.copyFile(Constantes.TEMP_DIRECTORY + "temp.dat", Constantes.PRODUCT_FILE);
                            return int.Parse(token[5]) - can;
                        }
                    }
                    catch (Exception)
                    {
                        return -1;
                    }
                    
                }
            }

            
            return -1;
        }

        public Libro buscarLibro(int key)
        {

            Console.WriteLine();
            using (BinaryReader binR = new BinaryReader(File.Open(Constantes.PRODUCT_FILE, FileMode.Open)))

            {
                string l;
                while ((l = binR.ReadString()) != null)
                {
                    string[] token = l.Split('|');
                    int clave = int.Parse(token[0]);
                    if (clave == key)
                    {
                        return new Libro(clave, token[1], token[2], token[3], token[4], int.Parse(token[5]), double.Parse(token[6]));
                    }
                }
            }
            return null;
        }


        public bool eliminarLibro(int key)
        {
            bool encontrado = false;

            using (BinaryReader binR = new BinaryReader(File.Open(Constantes.PRODUCT_FILE, FileMode.Open)))
            using (BinaryWriter binW = new BinaryWriter(File.Open(Constantes.TEMP_DIRECTORY + "temp.dat", FileMode.Create)))
            {
                string l;

                while (binR.PeekChar() != -1 && binR.BaseStream.Position != binR.BaseStream.Length)
                {
                    try
                    {
                        l = binR.ReadString();
                        string[] token = l.Split('|');
                        int clave = int.Parse(token[0]);
                        if (clave != key)
                        {
                            //binW.Write(l);
                            binW.Write(new Libro(int.Parse(token[0]), token[1], token[2], token[3], token[4], int.Parse(token[5]), double.Parse(token[6])).ToString());

                        } else
                        {
                            encontrado = true;
                        }

                    }
                    catch (Exception)
                    {
                        return encontrado;
                    }

                }

                return encontrado;
            }
        }



        public bool editarLibro(int key, Libro li)
        {
            bool encontrado = false;

            using (BinaryReader binR = new BinaryReader(File.Open(Constantes.PRODUCT_FILE, FileMode.Open)))
            using (BinaryWriter binW = new BinaryWriter(File.Open(Constantes.TEMP_DIRECTORY + "temp.dat", FileMode.OpenOrCreate)))
            {
                string l;

                while (binR.PeekChar() != -1 && binR.BaseStream.Position != binR.BaseStream.Length)
                {
                    try
                    {
                        l = binR.ReadString();
                        string[] token = l.Split('|');
                        int clave = int.Parse(token[0]);
                        if (clave != key)
                        {
                            //binW.Write(l);
                            binW.Write(new Libro(int.Parse(token[0]), token[1], token[2], token[3], token[4], int.Parse(token[5]), double.Parse(token[6])).ToString());

                        }
                        else
                        {
                            binW.Write(li.ToString());
                            encontrado = true;
                        }

                    }
                    catch (Exception)
                    {
                        return encontrado;
                    }

                }

                return encontrado;
            }
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
