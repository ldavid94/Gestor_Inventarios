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
    public partial class BuscarProducto : Form
    {
        public BuscarProducto()
        {
            InitializeComponent();
            actualizardvg();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        Controlador sn = new Controlador();
        String tabla = "tbl_producto";

        private void btnSalir_Click(object sender, EventArgs e){ }

        public void actualizardvg()
        {
            DataTable dt = sn.llenarTblP(tabla);
            dgvProductos.DataSource = dt;
        }

        public void busqueda()
        {
            string d1 = "Codigo";
            string d2 = "Categoria";
            string d3 = "Almacen";

            if (cbxTipoBusqueda.Text == d1)
            {
                DataTable db = sn.datosBusquedaP(d1, txtDatoBusqueda.Text);
                dgvProductos.DataSource = db;

            }
            else if (cbxTipoBusqueda.Text == d2)
            {
                DataTable db = sn.datosBusquedaP(d2, txtDatoBusqueda.Text);
                dgvProductos.DataSource = db;

            }
            else if (cbxTipoBusqueda.Text == d3)
            {
                DataTable db = sn.datosBusquedaP(d3, txtDatoBusqueda.Text);
                dgvProductos.DataSource = db;
            }
        }

        private void btnBuscarGeneral_Click(object sender, EventArgs e){ }

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
