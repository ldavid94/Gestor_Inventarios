using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class Notificaciones : Form
    {
        public Notificaciones()
        {
            InitializeComponent();
        }
        public Notificaciones(string pTitulo, string pMsgIm, string pMsg, Color pColor, int pImg)
        {
            InitializeComponent();
            lblTitulo.Text = pTitulo;
            lblImagen.Text = pMsgIm;
            lblMsg.Text = pMsg;
            lblTitulo.BackColor = pColor;
            pRight.BackColor = pColor;
            pImagen.BackColor = pColor;
            
            if(pImg == 1)
            {
                pbDel.Visible = false;
                pbInfo.Visible = false;
            }else if(pImg == 2)
            {
                pbSuc.Visible = false;
                pbInfo.Visible = false;
            }else if(pImg == 3)
            {
                pbDel.Visible = false;
                pbSuc.Visible = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.ForeColor = Color.Red;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.ForeColor = Color.Black;
        }
    }
}
