using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppPermisoCirculacion.Login;

namespace WinAppPermisoCirculacion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicacion.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }
    }
}
