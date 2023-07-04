using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class BuscarSalida : Form
    {
        public BuscarSalida()
        {
            InitializeComponent();
            actualizardvg();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        Controlador sn = new Controlador();
        String tabla = "tbl_salidas";

        public void actualizardvg()
        {
            DataTable dt = sn.llenarTblS2(tabla);
            dgvSalidas.DataSource = dt;

            dgvSalidas.Columns[3].HeaderText = "Id Almacen";
            dgvSalidas.Columns[5].HeaderText = "Id Producto";
        }

        public void busqueda()
        {
            string d1 = "Codigo";
            string d2 = "Id. Almacen";
            string d3 = "Id. Producto";

            string clave1 = "Codigo";
            string clave2 = "IdAlmacen";
            string clave3 = "IdProducto";

            if (cbxTipoBusqueda.Text == d1)
            {
                DataTable db = sn.datosBusquedaS(clave1, txtDatoBusqueda.Text);
                dgvSalidas.DataSource = db;

            }
            else if (cbxTipoBusqueda.Text == d2)
            {
                DataTable db = sn.datosBusquedaS(clave2, txtDatoBusqueda.Text);
                dgvSalidas.DataSource = db;

            }
            else if (cbxTipoBusqueda.Text == d3)
            {
                DataTable db = sn.datosBusquedaS(clave3, txtDatoBusqueda.Text);
                dgvSalidas.DataSource = db;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e){ }

        private void btnBuscarGeneral_Click(object sender, EventArgs e){ }
        private void btnBuscarFecha_Click(object sender, EventArgs e){ }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            actualizardvg();
        }

        private void icoBuscar_Click(object sender, EventArgs e)
        {
            busqueda();
            txtDatoBusqueda.Text = "";
            lblBuscar.Text = "Seleccionar"; 
        }

        private void icoBuscarFecha_Click(object sender, EventArgs e)
        {
            DataTable db = sn.BusquedaFechaS(txtFechaInicio.Text, txtFechaFinal.Text);
            dgvSalidas.DataSource = db;
        }

        private void lblFecha1_Click(object sender, EventArgs e)
        {
            txtFechaInicio.Select();
            SendKeys.Send("%{DOWN}");
        }

        private void lblFecha2_Click(object sender, EventArgs e)
        {
            txtFechaFinal.Select();
            SendKeys.Send("%{DOWN}");
        }

        private void txtFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            lblFecha1.Text = txtFechaInicio.Text;
        }

        private void txtFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            lblFecha2.Text = txtFechaFinal.Text;
        }

        private void lblBuscar_Click(object sender, EventArgs e)
        {
            cbxTipoBusqueda.Select();
            SendKeys.Send("%{DOWN}");
        }

        private void cbxTipoBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBuscar.Text = cbxTipoBusqueda.Text;
        }
    }
}
