using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using WinAppPermisoCirculacion.Datos;
using WinAppPermisoCirculacion.Negocio;

namespace WinAppPermisoCirculacion.Control
{
    public class TContribuyente
    {
        public int ingresarContribuyente(Contribuyente con)
        {
            int resp = 0;
            MySqlConnection conex = Conexion.abrirConexion();
            MySqlCommand orden = new MySqlCommand(string.Format("INSERT INTO CONTRIBUYENTE(RUT,NOMBRE,APELLIDO,NACIONALIDAD,DIRECCION,COMUNA) " +
                "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", con.rut, con.nombre, con.apellido, con.nacionalidad, con.direccion, con.comuna), conex);
            resp = orden.ExecuteNonQuery();
            conex.Close();
            return resp;
        }

        public int modificarContribuyente(Contribuyente con)
        {
            int resp = 0;
            MySqlConnection conex = Conexion.abrirConexion();
            MySqlCommand orden = new MySqlCommand(string.Format("UPDATE CONTRIBUYENTE SET NOMBRE='{0}',APELLIDO='{1}',NACIONALIDAD='{2}',DIRECCION='{3}',COMUNA='{4}' WHERE RUT='{5}'",
                con.nombre, con.apellido, con.nacionalidad, con.direccion, con.comuna, con.rut), conex);
            resp = orden.ExecuteNonQuery();
            conex.Close();
            return resp;
        }

        public int eliminarContribuyente(string rut)
        {
            int resp = 0;
            MySqlConnection conex = Conexion.abrirConexion();
            MySqlCommand orden = new MySqlCommand(string.Format("DELETE FROM CONTRIBUYENTE WHERE RUT='{0}'", rut), conex);
            resp = orden.ExecuteNonQuery();
            conex.Close();
            return resp;
        }

        public Contribuyente buscarContribuyente(string rut)
        {
            Contribuyente con = new Contribuyente();
            MySqlConnection conex = Conexion.abrirConexion();
            MySqlCommand orden = new MySqlCommand(string.Format("SELECT * FROM CONTRIBUYENTE WHERE RUT=@rut"), conex);
            orden.Parameters.AddWithValue("@rut", rut);
            MySqlDataReader lector = orden.ExecuteReader();
            if (lector.Read())
            {
                con.rut = lector.GetString(0);
                con.nombre = lector.GetString(1);
                con.apellido = lector.GetString(2);
                con.nacionalidad = lector.GetString(3);
                con.direccion = lector.GetString(4);
                con.comuna = lector.GetString(5);
            }
            conex.Close();
            return con;
        }

        public static List<Contribuyente> listarContribuyente()
        {
            List<Contribuyente> lista = new List<Contribuyente>();
            MySqlConnection conex = Conexion.abrirConexion();
            MySqlCommand orden = new MySqlCommand(string.Format("SELECT * FROM CONTRIBUYENTE"), conex);
            MySqlDataReader lector = orden.ExecuteReader();
            while (lector.Read())
            {
                Contribuyente con = new Contribuyente();
                con.rut = lector.GetString(0);
                con.nombre = lector.GetString(1);
                con.apellido = lector.GetString(2);
                con.nacionalidad = lector.GetString(3);
                con.direccion = lector.GetString(4);
                con.comuna = lector.GetString(5);
                lista.Add(con);
            }
            conex.Close();
            return lista;
        }
    }
}
