using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using CapaControlador;
using FontAwesome.Sharp;

namespace CapaVista
{
    public partial class Menu : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public Menu()
        {
            InitializeComponent();
            customizeDesing();
            actualizardvg();
            llenarcbxTotalProvedor();
            llenarcbxTotalCategoria();
            llenarcbxTotalProducto();
            llenarcbxTotalVentas();
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

        Controlador sn = new Controlador();
        String tabla = "tbl_inventario";

        public void actualizardvg()
        {
            DataTable dt = sn.llenarTblSto(tabla);
            dvgBajoStock.DataSource = dt;
        }

        public void llenarcbxTotalProvedor()
        {
            try
            {
                cbxUsuarios.Items.Clear();
                OdbcDataReader datareader = sn.llenarcbxTprov();
                while (datareader.Read())
                {
                    cbxUsuarios.Items.Add(datareader[0].ToString());
                }
                cbxUsuarios.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        public void llenarcbxTotalCategoria()
        {
            try
            {
                cbxCategorias.Items.Clear();
                OdbcDataReader datareader = sn.llenarcbxTCat();
                while (datareader.Read())
                {
                    cbxCategorias.Items.Add(datareader[0].ToString());
                }
                cbxCategorias.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        public void llenarcbxTotalProducto()
        {
            try
            {
                cbxProductos.Items.Clear();
                OdbcDataReader datareader = sn.llenarcbxTProd();
                while (datareader.Read())
                {
                    cbxProductos.Items.Add(datareader[0].ToString());
                }
                cbxProductos.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        public void llenarcbxTotalVentas()
        {
            try
            {
                cbxGanancias.Items.Clear();
                OdbcDataReader datareader = sn.llenarcbxGanancias();
                while (datareader.Read())
                {
                    cbxGanancias.Items.Add(datareader[0].ToString());
                }
                cbxGanancias.SelectedIndex = 0;
            }catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void customizeDesing()
        {
            panelMenuSalida.Visible = false;
            panel1.Visible = false;
            panelMenuProducto.Visible = false;
            panelMenu4.Visible = false;
            panelReportes.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelMenuSalida.Visible == true)
                panelMenuSalida.Visible = false;
            if (panel1.Visible == true)
                panel1.Visible = false;
            if (panelMenuProducto.Visible == true)
                panelMenuProducto.Visible = false;
            if (panelReportes.Visible == true)
                panelReportes.Visible = false;
            if (panelMenu4.Visible == true)
                panelMenu4.Visible = false;
            
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

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(0, 0, 192);
            public static Color color8 = Color.FromArgb(249, 118, 176);
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

        private void btnSalidas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            showSubMenu(panelMenuSalida);
        }

        private void btnEntradas_Click(object sender, EventArgs e) { }
        private void btnProductos_Click(object sender, EventArgs e) { }
        private void btnAlmacen_Click(object sender, EventArgs e) { }
        private void btnProveedores_Click(object sender, EventArgs e) { }
        private void btnInventario_Click(object sender, EventArgs e) { }
        private void btnConfiguracion_Click(object sender, EventArgs e){ }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            actualizardvg();
            llenarcbxTotalProvedor();
            llenarcbxTotalCategoria();
            llenarcbxTotalProducto();
            Reset();
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

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnEntradas_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            showSubMenu(panel1);
        }

        private void btnProductos_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            showSubMenu(panelMenuProducto);
        }

        private void btnAlmacen_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new IngresarAlmacen());
        }

        private void btnProveedores_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new IngresarProveedores());
        }

        private void btnInventario_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new BuscarInventario());
        }

        private void btnConfiguracion_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            showSubMenu(panelMenu4);
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

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Usuarios());
            hideSubMenu();
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Bitacora());
            hideSubMenu();
        }

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

        private void Hora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void cbxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblProveedores.Text = cbxUsuarios.Text;
        }

        private void cbxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCategorias.Text = cbxCategorias.Text;
        }

        private void cbxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblProductos.Text = cbxProductos.Text;
        }

        private void btnGraficas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            showSubMenu(panelReportes);
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            String texto = txtUsuario1.Text;
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new SolicitudCompra(texto));
        }

        private void cbxUsuarios_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lblProveedores.Text = cbxUsuarios.Text;
        }

        private void cbxCategorias_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lblCategorias.Text = cbxCategorias.Text;
        }

        private void cbxProductos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lblProductos.Text = cbxProductos.Text;
        }

        private void cbxGanancias_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblVentas.Text = "Q" + cbxGanancias.Text;
        }

        private void btnRGeneral_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dashboard());
            hideSubMenu();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            String texto = txtUsuario1.Text;
            OpenChildForm(new ReporteFecha(texto));
            hideSubMenu();
        }

        private void btnDashboard2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dashboard2());
            hideSubMenu();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new IngresarCategoria());
        }

        private void btnReporteBitacora_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReporteBitacora());
            hideSubMenu();
        }
    }
}
