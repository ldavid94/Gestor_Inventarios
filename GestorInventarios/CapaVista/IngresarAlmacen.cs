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
    public partial class IngresarAlmacen : Form
    {
        public IngresarAlmacen()
        {
            InitializeComponent();
            actualizardvg();
            txtCodigo.Enabled = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        Controlador sn = new Controlador();
        String tabla = "tbl_almacen";

        private void btnSalir_Click(object sender, EventArgs e){ }

        public void cleanTextbox()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
        }
        
        public void actualizardvg()
        {
            DataTable dt = sn.llenarTblA(tabla);
            dvgAlmacenes.DataSource = dt;
        }

        public void busqueda()
        {
            string d1 = "Codigo";
            string d2 = "Nombre Almacen";

            string clave1 = "Codigo";
            string clave2 = "Almacen";

            if (cbxTipoBusqueda.Text == d1)
            {
                DataTable db = sn.datosBusquedaA(clave1, txtDatoBusqueda.Text);
                dvgAlmacenes.DataSource = db;

            }
            else if (cbxTipoBusqueda.Text == d2)
            {
                DataTable db = sn.datosBusquedaA(clave2, txtDatoBusqueda.Text);
                dvgAlmacenes.DataSource = db;

            }
            
        }

        private void dvgAlmacenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dvgAlmacenes.CurrentRow.Cells[0].Value.ToString();
            txtDescripcion.Text = dvgAlmacenes.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            sn.guardarAlmacen(txtDescripcion.Text);
            actualizardvg();
            cleanTextbox();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            sn.borrar_almacen(txtCodigo);
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

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras y Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
