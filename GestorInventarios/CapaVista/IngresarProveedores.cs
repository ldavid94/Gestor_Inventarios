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
    public partial class IngresarProveedores : Form
    {
        public IngresarProveedores()
        {
            InitializeComponent();
            actualizardvg();
            txtCodigo.Enabled = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        Controlador sn = new Controlador();
        String tabla = "tbl_proveedores";

        private void btnSalir_Click(object sender, EventArgs e){ }

        public void actualizardvg()
        {
            DataTable dt = sn.llenarTblPro(tabla);
            dgvProveedor.DataSource = dt;
        }

        public void cleanTextbox()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
        }

        public void busqueda()
        {
            string d1 = "Codigo";
            string d2 = "Nombre Proveedor";

            string clave1 = "Codigo";
            string clave2 = "Nombre";

            if (cbxTipoBusqueda.Text == d1)
            {
                DataTable db = sn.datosBusquedaPro(clave1, txtDatoBusqueda.Text);
                dgvProveedor.DataSource = db;

            }
            else if (cbxTipoBusqueda.Text == d2)
            {
                DataTable db = sn.datosBusquedaPro(clave2, txtDatoBusqueda.Text);
                dgvProveedor.DataSource = db;

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            sn.guardarProveedor(txtNombre.Text, txtTelefono.Text);
            actualizardvg();
            cleanTextbox();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            sn.borrar_proveedor(txtCodigo);
            actualizardvg();
            cleanTextbox();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cleanTextbox();
        }

        private void btnBuscarGeneral_Click(object sender, EventArgs e){ }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            actualizardvg();
        }

        private void icoBuscar_Click(object sender, EventArgs e)
        {
            busqueda();
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
