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
    public partial class BuscarInventario : Form
    {
        public BuscarInventario()
        {
            InitializeComponent();
            actualizardvg();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        Controlador sn = new Controlador();
        String tabla = "tbl_inventario";

        private void btnSalir_Click(object sender, EventArgs e){ }

        public void actualizardvg()
        {
            DataTable dt = sn.llenarTblI(tabla);
            dgvInventario.DataSource = dt;
        }

        public void busqueda()
        {
            string d1 = "Codigo Producto";
            string d2 = "Almacen";
            string d3 = "Categoria";

            string clave1 = "Codigo";
            string clave2 = "Almacen";
            string clave3 = "Categoria";

            if (cbxTipoBusqueda.Text == d1)
            {
                DataTable db = sn.datosBusquedaI(clave1, txtDatoBusqueda.Text);
                dgvInventario.DataSource = db;

            }
            else if (cbxTipoBusqueda.Text == d2)
            {
                DataTable db = sn.datosBusquedaI(clave2, txtDatoBusqueda.Text);
                dgvInventario.DataSource = db;

            }
            else if (cbxTipoBusqueda.Text == d3)
            {
                DataTable db = sn.datosBusquedaI(clave3, txtDatoBusqueda.Text);
                dgvInventario.DataSource = db;
            }
        }

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
            DataTable db = sn.BusquedaFechaI(txtFechaInicio.Text, txtFechaFinal.Text);
            dgvInventario.DataSource = db;
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

        private void dgvInventario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvInventario.Columns[e.ColumnIndex].Name == "Stock")
            {
                if(Convert.ToInt32(e.Value) <= 1000)
                {
                    e.CellStyle.BackColor = Color.Green;
                    if(Convert.ToInt32(e.Value) <= 20)
                    {
                        e.CellStyle.BackColor = Color.Yellow;
                        if(Convert.ToInt32(e.Value) <= 10)
                        {
                            e.CellStyle.BackColor = Color.Red;
                        }
                    }
                }
            }
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
