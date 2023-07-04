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
using System.Data.Odbc;

namespace CapaVista
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();     
        }

        Controlador sn = new Controlador();

        public void llenarcbxpermisos(string usuario)
        {
            try
            {
                cbxPermiso.Items.Clear();
                OdbcDataReader datareader = sn.llenarPermisos(usuario);
                while (datareader.Read())
                {
                    cbxPermiso.Items.Add(datareader[0].ToString());
                }
                cbxPermiso.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            circularProgressBar1.Value += 1;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString();
            if (circularProgressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                int per;
                per = Convert.ToInt32(cbxPermiso.Text);

                if(per == 1)
                {
                    Menu adm = new Menu();
                    adm.txtUsuario1.Text = cbxUsuario.Text;
                    adm.Show();
                }else if(per == 2)
                {
                    Menu2 emp = new Menu2();
                    emp.txtUsuario1.Text = cbxUsuario.Text;
                    emp.Show();
                }
                this.Close();
            }
        }

        private void Bienvenida_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            timer1.Start();
        }

        private void cbxUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
