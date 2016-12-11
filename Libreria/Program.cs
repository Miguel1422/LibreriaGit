using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria.archivos;

namespace Libreria
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmLogin());
            Archivo.createDir(Constantes.FILE_DIRECTORY);
            Archivo.createDir(Constantes.IMG_DIRECTORY);
            Archivo.createDir(Constantes.TEMP_DIRECTORY);
            Archivo.createDir(Constantes.FOLIO_DIRECTORY);

            //Archivo.createFile(Constantes.LOGIN_FILE);
            Archivo.createFile(Constantes.USER_FILE);
            Archivo.createFile(Constantes.PRODUCT_FILE);

            Application.Run(new FrmLogin());

            //Application.Run(new FrmVentas());
            //Application.Run(new FrmProductos());
        }
    }
}
