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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace CapaVista
{
    public partial class ReporteFecha : Form
    {
        private Button currentButton;
        public ReporteFecha()
        {
            InitializeComponent();
            desabilitar();
        }

        public ReporteFecha(String texto)
        {
            InitializeComponent();
            desabilitar();
            txtUsuario.Text = texto;
        }

        Controlador sn = new Controlador();

        public void MenuButton(object buton)
        {
            var btn = (Button)buton;
            btn.BackColor = btnHoy.FlatAppearance.BorderColor;
            btn.ForeColor = Color.White;
            if (currentButton != null && currentButton != btn)
            {
                currentButton.BackColor = this.BackColor;
                currentButton.ForeColor = Color.FromArgb(124, 141, 181);
            }
            currentButton = btn;
        }

        public void busqueda()
        {
            string d1 = "Entradas";
            string d2 = "Salidas";

            if (cbxTablas.Text == d1)
            {
                DataTable db = sn.BusquedaReporteE(dtpFechainicial.Text, dtpFechaFinal.Text);
                dgvResultado.DataSource = db;

                dgvResultado.Columns[0].HeaderText = "Id Producto";
                dgvResultado.Columns[1].HeaderText = "Descripción";
                dgvResultado.Columns[2].HeaderText = "Cantidad";
            }
            else if(cbxTablas.Text == d2)
            {
                DataTable db = sn.BusquedaReporteS(dtpFechainicial.Text, dtpFechaFinal.Text);
                dgvResultado.DataSource = db;

                dgvResultado.Columns[0].HeaderText = "Id Producto";
                dgvResultado.Columns[1].HeaderText = "Descripción";
                dgvResultado.Columns[2].HeaderText = "Cantidad";
            }
        }

        public void desabilitar()
        {
            dtpFechainicial.Enabled = false;
            dtpFechaFinal.Enabled = false;
        }

        public void habilitar()
        {
            dtpFechainicial.Enabled = true;
            dtpFechaFinal.Enabled = true;         
        }

        private void btnHoy_Click(object sender, EventArgs e)
        {
            dtpFechainicial.Value = DateTime.Now;
            dtpFechaFinal.Value = DateTime.Now;
            MenuButton(sender);
            desabilitar();
        }

        private void btn7Dias_Click(object sender, EventArgs e)
        {
            dtpFechainicial.Value = DateTime.Today.AddDays(-7);
            dtpFechaFinal.Value = DateTime.Now;
            MenuButton(sender);
            desabilitar();
        }

        private void btnMes_Click(object sender, EventArgs e)
        {
            dtpFechainicial.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpFechaFinal.Value = DateTime.Now;
            MenuButton(sender);
            desabilitar();
        }

        private void btn30Dias_Click(object sender, EventArgs e)
        {
            dtpFechainicial.Value = DateTime.Today.AddDays(-30);
            dtpFechaFinal.Value = DateTime.Now;
            MenuButton(sender);
            desabilitar();
        }

        private void btnAño_Click(object sender, EventArgs e)
        {
            dtpFechainicial.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpFechaFinal.Value = DateTime.Now;
            MenuButton(sender);
            desabilitar();
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            dtpFechainicial.Value = DateTime.Now;
            dtpFechaFinal.Value = DateTime.Now;
            MenuButton(sender);
            habilitar();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            busqueda();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = dtpFechainicial.Text + " - " + dtpFechaFinal.Text + " " + cbxTablas.Text + ".pdf"; 
            guardar.ShowDialog();

            string paginahtml_texto = Properties.Resources.plantilla.ToString();
            paginahtml_texto = paginahtml_texto.Replace("@USUARIO", txtUsuario.Text);
            paginahtml_texto = paginahtml_texto.Replace("@REPORTE", cbxTablas.Text);
            paginahtml_texto = paginahtml_texto.Replace("@FECHA", DateTime.Now.ToString("yyyy'/'MM'/'dd"));

            string filas = string.Empty;
            int total = 0;

            foreach (DataGridViewRow row in dgvResultado.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells[0].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[1].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[2].Value.ToString() + "</td>";
                filas += "</tr>";
                total += int.Parse(row.Cells[2].Value.ToString());
            }

            paginahtml_texto = paginahtml_texto.Replace("@FILAS", filas);
            paginahtml_texto = paginahtml_texto.Replace("@TOTAL", total.ToString());

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    pdfDoc.Add(new Phrase(""));

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.Logo, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(80, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);

                    using (StringReader sr = new StringReader(paginahtml_texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }
                
            }
        }

        private void lblTabla_Click(object sender, EventArgs e)
        {
            cbxTablas.Select();
            SendKeys.Send("%{DOWN}");
        }

        private void cbxTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTabla.Text = cbxTablas.Text;
        }

        private void lblFecha1_Click(object sender, EventArgs e)
        {
            dtpFechainicial.Select();
            SendKeys.Send("%{DOWN}");
        }

        private void dtpFechainicial_ValueChanged(object sender, EventArgs e)
        {
            lblFecha1.Text = dtpFechainicial.Text;
        }

        private void lblFecha2_Click(object sender, EventArgs e)
        {
            dtpFechaFinal.Select();
            SendKeys.Send("%{DOWN}");
        }

        private void dtpFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            lblFecha2.Text = dtpFechaFinal.Text;
        }
    }
}
