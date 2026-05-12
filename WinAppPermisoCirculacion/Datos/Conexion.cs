using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinAppPermisoCirculacion.Datos
{
    public class Conexion
    {
        public static MySqlConnection abrirConexion()
        {
            MySqlConnection canal = null;
            try
            {
                canal = new MySqlConnection("server=127.0.0.1;database=bdpermisos;Uid=root;pwd=;");
                canal.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CONEXION FALLADA...VERIFIQUE..." + ex.ToString());
            }
            return canal;
        }
    }
}
