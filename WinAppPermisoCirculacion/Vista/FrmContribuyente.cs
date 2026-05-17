using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppPermisoCirculacion.Negocio;
using WinAppPermisoCirculacion.Control;

namespace WinAppPermisoCirculacion.Vista
{
    public partial class FrmContribuyente : Form
    {
        public FrmContribuyente()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Contribuyente con = new Contribuyente();
                TContribuyente tcon = new TContribuyente();
                con.rut = txtRut.Text;
                con.nombre = txtNombre.Text;
                con.apellido = txtApellido.Text;
                con.nacionalidad = txtNacionalidad.Text;
                con.direccion = txtDireccion.Text;
                con.comuna = txtComuna.Text;
                int resp = tcon.ingresarContribuyente(con);
                if (resp > 0)
                    MessageBox.Show("Contribuyente ingresado a la tabla!!!", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Ingreso de Contribuyente Fallado!!!", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            TContribuyente tcon = new TContribuyente();
            string rut = txtRutBus.Text;
            Contribuyente con = tcon.buscarContribuyente(rut);
            if (con != null)
            {
                txtRutEd.Text = con.rut;
                txtNombreEd.Text = con.nombre;
                txtApellidoEd.Text = con.apellido;
                txtNacionalidadEd.Text = con.nacionalidad;
                txtDireccionEd.Text = con.direccion;
                txtComunaEd.Text = con.comuna;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Contribuyente con = new Contribuyente();
                TContribuyente tcon = new TContribuyente();
                con.rut = txtRutEd.Text;
                con.nombre = txtNombreEd.Text;
                con.apellido = txtApellidoEd.Text;
                con.nacionalidad = txtNacionalidadEd.Text;
                con.direccion = txtDireccionEd.Text;
                con.comuna = txtComunaEd.Text;
                int resp = tcon.modificarContribuyente(con);
                if (resp > 0)
                    MessageBox.Show("Contribuyente Modificado en la tabla!!!", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Modificación de Contribuyente Fallada!!!", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                TContribuyente tcon = new TContribuyente();
                string rut = txtRutBus.Text;
                int resp = tcon.eliminarContribuyente(rut);
                if (resp > 0)
                    MessageBox.Show("Contribuyente Eliminado de la tabla!!!", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Eliminación de Contribuyente Fallada!!!", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dataContribuyentes.DataSource = TContribuyente.listarContribuyente();
        }
    }
}
