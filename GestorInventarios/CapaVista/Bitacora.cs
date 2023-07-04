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
    public partial class Bitacora : Form
    {
        public Bitacora()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            desabilitado();
        }

        Controlador sn = new Controlador();
        String tabla1 = "tbl_bitacora_login";
        String tabla2 = "tbl_bitacora_entradas";
        String tabla3 = "tbl_bitacora_salidas";

        public void desabilitado()
        {
            dtpFecha.Visible = false;
            lblFecha.Visible = false;
        }

        public void habilitar()
        {
            lblFecha.Visible = true;
            dtpFecha.Visible = true;
        }

        public void Mostrar()
        {
            string d1 = "Login";
            string d2 = "Entradas";
            string d3 = "Salidas";

            if (cbxBitacora.Text == d1)
            {
                DataTable dt = sn.llenarTblBit(tabla1);
                dgvBitacora.DataSource = dt;
            }
            else if (cbxBitacora.Text == d2)
            {
                DataTable dt = sn.llenarTblBit(tabla2);
                dgvBitacora.DataSource = dt;
            }
            else if (cbxBitacora.Text == d3)
            {
                DataTable dt = sn.llenarTblBit(tabla3);
                dgvBitacora.DataSource = dt;
            }
        }

        public void busqueda()
        {
            string d1 = "Fecha";
            string d2 = "Nombre";

            string clave1 = "Fecha";
            string clave2 = "Nombre";

            if (cbxTipoBusqueda.Text == d1 && cbxBitacora.Text == "Login")
            {
                DataTable db = sn.datosBusquedaBit(tabla1, clave1, dtpFecha.Text);
                dgvBitacora.DataSource = db;

            }
            else if (cbxTipoBusqueda.Text == d2 && cbxBitacora.Text == "Login")
            {
                DataTable db = sn.datosBusquedaBit(tabla1, clave2, txtDatoBusqueda.Text);
                dgvBitacora.DataSource = db;

            }else if (cbxTipoBusqueda.Text == d1 && cbxBitacora.Text == "Entradas")
            {
                DataTable db = sn.datosBusquedaBit(tabla2, clave1, dtpFecha.Text);
                dgvBitacora.DataSource = db;

            }else if(cbxTipoBusqueda.Text == d2 && cbxBitacora.Text == "Entradas")
            {
                DataTable db = sn.datosBusquedaBit(tabla2, clave2, txtDatoBusqueda.Text);
                dgvBitacora.DataSource = db;

            }
            else if (cbxTipoBusqueda.Text == d1 && cbxBitacora.Text == "Salida")
            {
                DataTable db = sn.datosBusquedaBit(tabla3, clave1, dtpFecha.Text);
                dgvBitacora.DataSource = db;

            }
            else if (cbxTipoBusqueda.Text == d2 && cbxBitacora.Text == "Salida")
            {
                DataTable db = sn.datosBusquedaBit(tabla3, clave2, txtDatoBusqueda.Text);
                dgvBitacora.DataSource = db;

            }
        }

        private void btnSalir_Click(object sender, EventArgs e){ }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void btnBuscarGeneral_Click(object sender, EventArgs e){ }

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
            if(cbxTipoBusqueda.Text == "Fecha")
            {
                habilitar();
            }else if(cbxTipoBusqueda.Text == "Nombre")
            {
                desabilitado();
            }
        }

        private void lblBitacora_Click(object sender, EventArgs e)
        {
            cbxBitacora.Select();
            SendKeys.Send("%{DOWN}");
        }

        private void cbxBitacora_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBitacora.Text = cbxBitacora.Text;
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {
            dtpFecha.Select();
            SendKeys.Send("%{DOWN}");
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            lblFecha.Text = dtpFecha.Text;
        }
    }
}
