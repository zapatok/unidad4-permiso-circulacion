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
    public partial class FrmVehiculo : Form
    {
        public FrmVehiculo()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Vehiculo veh = new Vehiculo();
                TVehiculo tveh = new TVehiculo();
                veh.patente = txtPatente.Text;
                veh.marca = txtMarca.Text;
                veh.modelo = txtModelo.Text;
                veh.color = txtColor.Text;
                veh.anio = Convert.ToInt32(txtAnio.Text);
                veh.rut = txtRut.Text;
                int resp = tveh.ingresarVehiculo(veh);
                if (resp > 0)
                    MessageBox.Show("Vehículo ingresado a la tabla!!!", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Ingreso de Vehículo Fallado!!!", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            TVehiculo tveh = new TVehiculo();
            string patente = txtPatenteBus.Text;
            Vehiculo veh = tveh.buscarVehiculo(patente);
            if (veh != null)
            {
                txtPatenteEd.Text = veh.patente;
                txtMarcaEd.Text = veh.marca;
                txtModeloEd.Text = veh.modelo;
                txtColorEd.Text = veh.color;
                txtAnioEd.Text = veh.anio.ToString();
                txtRutEd.Text = veh.rut;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Vehiculo veh = new Vehiculo();
                TVehiculo tveh = new TVehiculo();
                veh.patente = txtPatenteEd.Text;
                veh.marca = txtMarcaEd.Text;
                veh.modelo = txtModeloEd.Text;
                veh.color = txtColorEd.Text;
                veh.anio = Convert.ToInt32(txtAnioEd.Text);
                veh.rut = txtRutEd.Text;
                int resp = tveh.modificarVehiculo(veh);
                if (resp > 0)
                    MessageBox.Show("Vehículo Modificado en la tabla!!!", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Modificación de Vehículo Fallada!!!", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                TVehiculo tveh = new TVehiculo();
                string patente = txtPatenteBus.Text;
                int resp = tveh.eliminarVehiculo(patente);
                if (resp > 0)
                    MessageBox.Show("Vehículo Eliminado de la tabla!!!", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Eliminación de Vehículo Fallada!!!", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dataVehiculos.DataSource = TVehiculo.listarVehiculo();
        }
    }
}
