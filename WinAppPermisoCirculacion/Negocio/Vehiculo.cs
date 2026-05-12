using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppPermisoCirculacion.Negocio
{
    public class Vehiculo
    {   public string patente { get; set; }
        public string marca   { get; set; }
        public string modelo  { get; set; }
        public string color   { get; set; }
        public int    anio    { get; set; }
        public string rut     { get; set; }
        //Constructor s/p
        public Vehiculo() { }
        //Constructor con parametros
        public Vehiculo(string patente, string marca, string modelo, string color, int anio, string rut)
        {
            this.patente = patente;
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.anio = anio;
            this.rut = rut;
        }
    }
}
