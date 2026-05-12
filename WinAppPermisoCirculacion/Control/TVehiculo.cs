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
    public class TVehiculo
    {
        public int ingresarVehiculo(Vehiculo veh)
        {
            int resp = 0;
            MySqlConnection conex = Conexion.abrirConexion();
            MySqlCommand orden = new MySqlCommand(string.Format("INSERT INTO VEHICULO(PATENTE,MARCA,MODELO,COLOR,ANIO,RUT) " +
                "VALUES ('{0}','{1}','{2}','{3}',{4},'{5}')", veh.patente, veh.marca, veh.modelo, veh.color, veh.anio, veh.rut), conex);
            resp = orden.ExecuteNonQuery();
            conex.Close();
            return resp;
        }

        public int modificarVehiculo(Vehiculo veh)
        {
            int resp = 0;
            MySqlConnection conex = Conexion.abrirConexion();
            MySqlCommand orden = new MySqlCommand(string.Format("UPDATE VEHICULO SET MARCA='{0}',MODELO='{1}',COLOR='{2}',ANIO={3},RUT='{4}' WHERE PATENTE='{5}'",
                veh.marca, veh.modelo, veh.color, veh.anio, veh.rut, veh.patente), conex);
            resp = orden.ExecuteNonQuery();
            conex.Close();
            return resp;
        }

        public int eliminarVehiculo(string patente)
        {
            int resp = 0;
            MySqlConnection conex = Conexion.abrirConexion();
            MySqlCommand orden = new MySqlCommand(string.Format("DELETE FROM VEHICULO WHERE PATENTE='{0}'", patente), conex);
            resp = orden.ExecuteNonQuery();
            conex.Close();
            return resp;
        }

        public Vehiculo buscarVehiculo(string patente)
        {
            Vehiculo veh = new Vehiculo();
            MySqlConnection conex = Conexion.abrirConexion();
            MySqlCommand orden = new MySqlCommand(string.Format("SELECT * FROM VEHICULO WHERE PATENTE=@patente"), conex);
            orden.Parameters.AddWithValue("@patente", patente);
            MySqlDataReader lector = orden.ExecuteReader();
            if (lector.Read())
            {
                veh.patente = lector.GetString(0);
                veh.marca = lector.GetString(1);
                veh.modelo = lector.GetString(2);
                veh.color = lector.GetString(3);
                veh.anio = lector.GetInt32(4);
                veh.rut = lector.GetString(5);
            }
            conex.Close();
            return veh;
        }

        public static List<Vehiculo> listarVehiculo()
        {
            List<Vehiculo> lista = new List<Vehiculo>();
            MySqlConnection conex = Conexion.abrirConexion();
            MySqlCommand orden = new MySqlCommand(string.Format("SELECT * FROM VEHICULO"), conex);
            MySqlDataReader lector = orden.ExecuteReader();
            while (lector.Read())
            {
                Vehiculo veh = new Vehiculo();
                veh.patente = lector.GetString(0);
                veh.marca = lector.GetString(1);
                veh.modelo = lector.GetString(2);
                veh.color = lector.GetString(3);
                veh.anio = lector.GetInt32(4);
                veh.rut = lector.GetString(5);
                lista.Add(veh);
            }
            conex.Close();
            return lista;
        }
    }
}
