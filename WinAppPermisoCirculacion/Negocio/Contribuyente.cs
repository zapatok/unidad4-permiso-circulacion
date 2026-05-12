using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppPermisoCirculacion.Negocio
{
    public class Contribuyente
    {   public string rut          { get; set; }
        public string nombre       { get; set; }
        public string apellido     { get; set; }
        public string nacionalidad { get; set; }
        public string direccion    { get; set; }
        public string comuna       { get; set; }
        //Constructor s/p
        public Contribuyente() { }
        //Constructor con parametros
        public Contribuyente(string rut, string nombre, string apellido, string nacionalidad, string direccion, string comuna)
        {
            this.rut = rut;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
            this.direccion = direccion;
            this.comuna = comuna;
        }
    }
}
