using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class IngresarEntrada : Form
    {
        public IngresarEntrada()
        {
            InitializeComponent();
        }

        public IngresarEntrada(String texto)
        {
            InitializeComponent();
            actualizardvg();
            txtUsuario2.Text = texto;
            this.StartPosition = FormStartPosition.CenterScreen;
            txtFecha.Enabled = false;
            DateTime fh = DateTime.Now;
            txtFecha.Text = fh.ToString("yyyy'-'MM'-'dd");
            txtHora.Text = fh.ToString("HH':'mm");
        }

        Controlador sn = new Controlador();
        String tabla = "tbl_registro_entrada";

        private void btnSalir_Click(object sender, EventArgs e){ }

        public void actualizardvg()
        {
            DateTime fh = DateTime.Now;
            DataTable dt = sn.llenarTblE(tabla, fh.ToString("yyyy'-'MM'-'dd"), txtUsuario2.Text);
            dgvEntrada.DataSource = dt;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
        }
        private void cbxIdProducto_SelectedIndexChanged(object sender, EventArgs e){}
        private void cbxIdProveedores_SelectedIndexChanged(object sender, EventArgs e){}
        private void txtNombreProveedores_SelectedIndexChanged(object sender, EventArgs e){}
        private void txtDescripcionProducto_SelectedIndexChanged(object sender, EventArgs e){}
        private void lblIdProducto_Click(object sender, EventArgs e){}
        private void lblIdProveedores_Click(object sender, EventArgs e){}
        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e){}
        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e){}
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e){}

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NEntrada frm = new NEntrada(txtUsuario2.Text);
            frm.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizardvg();
        }
    }
}
