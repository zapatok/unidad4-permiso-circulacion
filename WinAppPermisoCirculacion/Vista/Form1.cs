using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppPermisoCirculacion.Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gestionContribuyentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContribuyente frmCon = new FrmContribuyente();
            frmCon.Show();
        }

        private void gestionVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVehiculo frmVeh = new FrmVehiculo();
            frmVeh.Show();
        }

        private void salirDeAplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Desea salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
                Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
