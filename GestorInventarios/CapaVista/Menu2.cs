using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class Menu2 : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public Menu2()
        {
            InitializeComponent();
            customizeDesing();
            this.StartPosition = FormStartPosition.CenterScreen;
            DateTime fh = DateTime.Now;
            txtFechaHora.Text = fh.ToString("HH':'mm '/' yyyy'-'MM'-'dd");
            txtFechaHora.Enabled = false;
            txtUsuario1.Enabled = false;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void customizeDesing()
        {
            panelMenuSalida.Visible = false;
            panelMenuEntradas.Visible = false;
            panelMenuProducto.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelMenuSalida.Visible == true)
                panelMenuSalida.Visible = false;
            if (panelMenuEntradas.Visible == true)
                panelMenuEntradas.Visible = false;
            if (panelMenuProducto.Visible == true)
                panelMenuProducto.Visible = false;
           
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(24, 28, 63);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconoFormulario.IconChar = currentBtn.IconChar;
                iconoFormulario.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(24, 28, 63);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitulo.Text = childForm.Text;
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconoFormulario.IconChar = IconChar.Home;
            iconoFormulario.IconColor = Color.Blue;
            lblTitulo.Text = "Home";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir: " + txtUsuario1.Text + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Principal frm = new Principal();
                frm.txtUsuario4.Text = txtUsuario1.Text;
                frm.Show();
                this.Hide();
            }
        }

        private void btnNuevo1_Click(object sender, EventArgs e)
        {
            String texto = txtUsuario1.Text;
            OpenChildForm(new IngresarSalida(texto));
            hideSubMenu();
        }

        private void btnBuscar1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BuscarSalida());
            hideSubMenu();
        }

        private void btnNuevo2_Click(object sender, EventArgs e)
        {
            String texto = txtUsuario1.Text;
            OpenChildForm(new IngresarEntrada(texto));
            hideSubMenu();
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BuscarEntrada());
            hideSubMenu();
        }

        private void btnNuevo3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new IngresarProductos());
            hideSubMenu();
        }

        private void btnBuscar3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BuscarProducto());
            hideSubMenu();
        }

        private void Hora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSalidas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            showSubMenu(panelMenuSalida);
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            showSubMenu(panelMenuEntradas);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            showSubMenu(panelMenuProducto);
        }

        private void Hora_Tick_1(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }
    }
}
