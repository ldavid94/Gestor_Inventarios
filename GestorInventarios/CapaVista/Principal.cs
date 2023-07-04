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
using System.Runtime.InteropServices;

namespace CapaVista
{
    public partial class Principal : Form
    {
        Controlador cn = new Controlador();
        public Principal()
        {
            InitializeComponent();
            DateTime fh = DateTime.Now;
            txtFecha.Text = fh.ToString("yyyy'-'MM'-'dd");
            txtHora.Text = fh.ToString("HH':'mm");
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
                txtUsuario.Text = "";
            txtUsuario.ForeColor = Color.LightGray;
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == ""){
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "") {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtContraseña.Text;

            cn.guardarBitacoraLogin(txtFecha.Text, txtHora.Text, txtUsuario.Text, "Login");

            if (usuario != "USUARIO")
            {
                if (password != "CONTRASEÑA")
                {
                    cn.verificarusuario(usuario, password);
                    this.Hide();
                }
                else msgError("Error falta la Contraseña");
            }
            else msgError("Error falta el Usuario");
        }

        private void msgError(string msg)
        {
            lblMensajeError.Text = "     " + msg;
            lblMensajeError.Visible = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            cn.guardarBitacoraLogin(txtFecha.Text, txtHora.Text, txtUsuario4.Text, "Sign Out");
            Application.Exit();
        }

        private void Principal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimixar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                msgError("Solo Numeros");
                e.Handled = true;
                return;
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                msgError("Solo Letras");
                e.Handled = true;
                return;
            }
        }
    }
}
