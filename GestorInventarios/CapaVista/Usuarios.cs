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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            llenarcbxusuarios();
            actualizardvg();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        Controlador sn = new Controlador();
        String tabla = "tbl_usuarios";

        private void btnSalir_Click(object sender, EventArgs e){ }

        public void actualizardvg()
        {
            DataTable dt = sn.llenarTblU(tabla);
            dgvUsuarios.DataSource = dt;

            dgvUsuarios.Columns[2].HeaderText = "Contraseña";
        }

        public void cleanTextbox()
        {
            txtNombreApellido.Text = "";
            txtNombre.Text = "";
            txtContraseña.Text = "";
        }

        public void llenarcbxusuarios()
        {
            try
            {
                txtRol.Items.Clear();
                OdbcDataReader datareader = sn.llenarcbxUsu();
                while (datareader.Read())
                {
                    txtRol.Items.Add(datareader[0].ToString());
                }
                txtRol.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        public void llenartxtUsuarios()
        {
            try
            {
                txtIdTipo.Items.Clear();
                OdbcDataReader datareader = sn.llenartxtusuario(txtRol.Text);
                while (datareader.Read())
                {
                    txtIdTipo.Items.Add(datareader[0].ToString());
                }
                txtIdTipo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
        }

        public void busqueda()
        {
            string d1 = "Codigo";
            string d2 = "Nombre Usuario";
            
            string clave1 = "Codigo";
            string clave2 = "Usuario";
            
            if (cbxTipoBusqueda.Text == d1)
            {
                DataTable db = sn.datosBusquedaUsu(clave1, txtDatoBusqueda.Text);
                dgvUsuarios.DataSource = db;

            }
            else if (cbxTipoBusqueda.Text == d2)
            {
                DataTable db = sn.datosBusquedaUsu(clave2, txtDatoBusqueda.Text);
                dgvUsuarios.DataSource = db;

            }
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            sn.guardarUsuario(txtNombre.Text, txtContraseña.Text, txtNombreApellido.Text, txtIdTipo.Text);
            actualizardvg();
            cleanTextbox();
        }

        private void txtRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenartxtUsuarios();
            lblRol.Text = txtRol.Text;
        }

        private void btnBuscarGeneral_Click(object sender, EventArgs e){ }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            actualizardvg();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cleanTextbox();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            sn.borrar_usuario(txtNombreApellido);
            actualizardvg();
            cleanTextbox();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombreApellido.Text = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtContraseña.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
            txtRol.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
            txtIdTipo.Text = dgvUsuarios.CurrentRow.Cells[4].Value.ToString();

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

        private void lblRol_Click(object sender, EventArgs e)
        {
            txtRol.Select();
            SendKeys.Send("%{DOWN}");
        }

        private void txtNombreApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
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
