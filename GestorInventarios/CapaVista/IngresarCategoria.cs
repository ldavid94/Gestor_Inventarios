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
    public partial class IngresarCategoria : Form
    {
        public IngresarCategoria()
        {
            InitializeComponent();
            actualizardvg();
            txtCodigo.Enabled = false;
        }

        Controlador sn = new Controlador();
        String tabla = "tbl_categoria";

        public void actualizardvg()
        {
            DataTable dt = sn.llenarTblC(tabla);
            dgvCategoria.DataSource = dt;
        }

        public void cleanTextbox()
        {
            txtCodigo.Text = "";
            txtCategoria.Text = "";
        }

        public void busqueda()
        {
            DataTable dt = sn.BusquedaCategoria(txtDatoBusqueda.Text);
            dgvCategoria.DataSource = dt;
        }

        private void icoBuscar_Click(object sender, EventArgs e)
        {
            busqueda();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            actualizardvg();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            sn.guardarCategoria(txtCategoria.Text);
            actualizardvg();
            cleanTextbox();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            sn.borrar_categoria(txtCodigo);
            actualizardvg();
            cleanTextbox();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cleanTextbox();
        }

        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvCategoria.CurrentRow.Cells[0].Value.ToString();
            txtCategoria.Text = dgvCategoria.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
