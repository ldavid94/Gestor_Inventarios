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
    public partial class IngresarProductos : Form
    {
        public IngresarProductos()
        {
            InitializeComponent();
            actualizardvg();
            llenarcbxAlmacen();
            llenartxtCategorias();
            this.StartPosition = FormStartPosition.CenterScreen;
            txtFecha.Enabled = false;
            DateTime fh = DateTime.Now;
            txtFecha.Text = fh.ToString("yyyy'-'MM'-'dd");
        }

        Controlador sn = new Controlador();
        String tabla = "tbl_producto";

        private void btnSalir_Click(object sender, EventArgs e){ }

        public void actualizardvg()
        {
            DataTable dt = sn.llenarTblP(tabla);
            dgvProductos.DataSource = dt;
        }

        public void cleanTextbox()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtCategoria.Text = "";
            txtAlmacen.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            sn.guardarProducto(txtCodigo.Text, txtDescripcion.Text, txtCategoria.Text, txtAlmacen.Text, txtProveedor.Text);
            sn.guardarInventarioNuevo(txtFecha.Text, txtCodigo.Text, txtDescripcion.Text, txtCategoria.Text, txtAlmacen.Text);
            actualizardvg();
            cleanTextbox();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cleanTextbox();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            sn.borrar_producto(txtCodigo);
            actualizardvg();
            cleanTextbox();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
            txtDescripcion.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            txtCategoria.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
            txtAlmacen.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
        }

        public void llenarcbxAlmacen()
        {
            try
            {
                txtAlmacen.Items.Clear();
                OdbcDataReader datareader = sn.llenarcbxAlma();
                while (datareader.Read())
                {
                    txtAlmacen.Items.Add(datareader[0].ToString());
                }
                txtAlmacen.SelectedIndex = 0;
            }catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        public void llenartxtCategorias()
        {
            try
            {
                txtCategoria.Items.Clear();
                OdbcDataReader datareader = sn.llenartxtC();
                while (datareader.Read())
                {
                    txtCategoria.Items.Add(datareader[0].ToString());
                }
                txtCategoria.SelectedIndex = 0;
            }catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void lblAlmacen_Click(object sender, EventArgs e)
        {
            txtAlmacen.Select();
            SendKeys.Send("%{DOWN}");
        }

        private void txtAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAlmacen.Text = txtAlmacen.Text;
        }

        private void lblCategoria_Click(object sender, EventArgs e)
        {
            txtCategoria.Select();
            SendKeys.Send("%{DOWN}");
        }

        private void txtCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCategoria.Text = txtCategoria.Text;
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 44) || (e.KeyChar >= 46 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras, giones y Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
