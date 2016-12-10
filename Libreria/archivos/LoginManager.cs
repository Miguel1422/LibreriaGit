using System;
using System.IO;

namespace Libreria.archivos
{
    class LoginManager:ArchivoTexto
    {

        public static int NO_ENCONTRADO = 0;
        public static int ADMIN = 1;
        public static int USER = 2;
        private void createLogin()
        {
            createDir(Constantes.FILE_DIRECTORY);
            createFile(Constantes.LOGIN_FILE);
            writeFile(Constantes.LOGIN_FILE, "admin 123 admin", false);
            writeFile(Constantes.LOGIN_FILE, "user 123 user", true);
        }

        private void createLogin(string name, string pass, string tipo)
        {
            createDir(Constantes.FILE_DIRECTORY);
            createFile(Constantes.LOGIN_FILE);
            writeFile(Constantes.LOGIN_FILE, name  + " " + pass + " " + tipo, false);
        }

        public int findUser(string user, string pass, string file)
        {
            if (!File.Exists(file))
            {
                createLogin();
            }

            using (StreamReader sr = new StreamReader(file))
            {
                string l;
                while ((l = sr.ReadLine()) != null)
                {
                    if (!l.StartsWith("#"))
                    {
                        string[] spli = l.Split();
                        if (spli.Length < 3)
                        {
                            continue;
                        }
                        string userTmp = spli[0];
                        string passTmp = spli[1];
                        string tipo = spli[2];

                        //if (user.Equals(userTmp) && passTmp.Equals(encrypt(pass)))
                        if (user.Equals(userTmp) && passTmp.Equals(pass))
                        {
                            sr.Close();
                            if (tipo.Equals("admin"))
                            {
                                return ADMIN;
                            }
                            else
                            {
                                return USER;
                            }
                        }
                    }
                }

                sr.Close();
            }

            return NO_ENCONTRADO;
        }


        public int findUser(string user, string pass)
        {
            return findUser(user, pass, Constantes.LOGIN_FILE);
        }
        public bool adddUser(string user, string pass, string file)
        {
            writeFile(file, user + " " + pass, true);
            /*using (StreamWriter sr = new StreamWriter(file, true))
            {

                //sr.WriteLine("{0} {1}", user, encrypt(pass));
                sr.WriteLine("{0} {1}", user, pass);
                sr.Close();
            }*/

            return false;
        }
        public bool adddUser(string user, string pass)
        {
            return adddUser(user, pass, Constantes.LOGIN_FILE);
        }
    }
}
