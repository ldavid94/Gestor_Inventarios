using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using CapaControlador;

namespace CapaVista
{
    public partial class IngresarSalida : Form
    {
        public IngresarSalida()
        {
            InitializeComponent();
        }

        public IngresarSalida(String texto)
        {
            InitializeComponent();
            actualizardvg();
            txtUsuario3.Text = texto;
            this.StartPosition = FormStartPosition.CenterScreen;
            txtFecha.Enabled = false;
            DateTime fh = DateTime.Now;
            txtFecha.Text = fh.ToString("yyyy'-'MM'-'dd");
            txtHora.Text = fh.ToString("HH':'mm");
        }

        Controlador sn = new Controlador();
        String tabla = "tbl_registro_salidas";
        
        private void btnSalir_Click(object sender, EventArgs e){ }
        
        public void actualizardvg()
        {
            DateTime fh = DateTime.Now;
            DataTable dt = sn.llenarTblS(tabla, fh.ToString("yyyy'-'MM'-'dd"), txtUsuario3.Text);
            dvgSalida.DataSource = dt;
        }

        private void dvgSalida_CellContentClick(object sender, DataGridViewCellEventArgs e){}
        private void btnRegistrar_Click(object sender, EventArgs e){}
        private void cbxIdProducto_SelectedIndexChanged(object sender, EventArgs e){}
        private void cbxIdAlmacen_SelectedIndexChanged(object sender, EventArgs e){}
        private void lblIdAlmacen_Click(object sender, EventArgs e){}
        private void txtNombreAlmacen_SelectedIndexChanged(object sender, EventArgs e){}
        private void lblIdProducto_Click(object sender, EventArgs e){}
        private void lblDescripcionProducto_Click(object sender, EventArgs e){}
        private void txtDescripcionProducto_SelectedIndexChanged(object sender, EventArgs e){}
        private void txtStock_SelectedIndexChanged(object sender, EventArgs e){}
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e){}

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NSalida frm = new NSalida(txtUsuario3.Text);
            frm.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizardvg();
        }
    }
}
