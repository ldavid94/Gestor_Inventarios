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
using System.Data.Odbc;

namespace CapaVista
{
    public partial class ReporteBitacora : Form
    {

        private Button currentButton;

        public ReporteBitacora()
        {
            InitializeComponent();
            desabilitar();
            llenarcbxUsuarios();
        }

        public ReporteBitacora(String texto)
        {
            InitializeComponent();
            desabilitar();
            llenarcbxUsuarios();
            txtUsuario.Text = texto;
        }

        Controlador sn = new Controlador();

        public void llenarcbxUsuarios()
        {
            try
            {
                cbxUsuario.Items.Clear();
                OdbcDataReader datareader = sn.llenarcbxUsuario();
                while (datareader.Read())
                {
                    cbxUsuario.Items.Add(datareader[0].ToString());
                }
                //cbxUsuario.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

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

        public void buscar()
        {
            string d1 = "Entradas", d2 = "Salidas", d3 = "Login", d4 = "Compras";
            if(cbxTablas.Text == d1)
            {
                DataTable db = sn.BusquedaReporteEB(dtpFechainicial.Text, dtpFechaFinal.Text, cbxUsuario.Text);
                dgvResultado.DataSource = db;
            }
            else if(cbxTablas.Text == d2)
            {
                DataTable db = sn.BusquedaReporteSB(dtpFechainicial.Text, dtpFechaFinal.Text, cbxUsuario.Text);
                dgvResultado.DataSource = db;

            }
            else if(cbxTablas.Text == d3)
            {
                DataTable db = sn.BusquedaReporteLB(dtpFechainicial.Text, dtpFechaFinal.Text, cbxUsuario.Text);
                dgvResultado.DataSource = db;

            }
            else if (cbxTablas.Text == d4)
            {
                DataTable db = sn.BusquedaReporteCB(dtpFechainicial.Text, dtpFechaFinal.Text, cbxUsuario.Text);
                dgvResultado.DataSource = db;
            }
        }

        private void btnHoy_Click(object sender, EventArgs e)
        {
            dtpFechainicial.Value = DateTime.Now;
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

        private void lblFecha1_Click(object sender, EventArgs e)
        {
            dtpFechainicial.Select();
            SendKeys.Send("%{DOWN}");
        }

        private void lblFecha2_Click(object sender, EventArgs e)
        {
            dtpFechaFinal.Select();
            SendKeys.Send("%{DOWN}");
        }

        private void dtpFechainicial_ValueChanged(object sender, EventArgs e)
        {
            lblFecha1.Text = dtpFechainicial.Text;
        }

        private void dtpFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            lblFecha2.Text = dtpFechaFinal.Text;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string d1 = "Entradas", d2 = "Salidas", d3 = "Login", d4 = "Compras";
            if(cbxTablas.Text == d1 || cbxTablas.Text == d2)
            {
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.FileName = dtpFechainicial.Text + " - " + dtpFechaFinal.Text + " " + cbxTablas.Text + ".pdf";
                guardar.ShowDialog();

                string paginahtml_texto = Properties.Resources.plantilla4.ToString();
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
            else if(cbxTablas.Text == d3)
            {
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.FileName = dtpFechainicial.Text + " - " + dtpFechaFinal.Text + " " + cbxTablas.Text + ".pdf";
                guardar.ShowDialog();

                string paginahtml_texto = Properties.Resources.plantilla5.ToString();
                paginahtml_texto = paginahtml_texto.Replace("@USUARIO", txtUsuario.Text);
                paginahtml_texto = paginahtml_texto.Replace("@REPORTE", cbxTablas.Text);
                paginahtml_texto = paginahtml_texto.Replace("@FECHA", DateTime.Now.ToString("yyyy'/'MM'/'dd"));

                string filas = string.Empty;               

                foreach (DataGridViewRow row in dgvResultado.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells[0].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells[1].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells[2].Value.ToString() + "</td>";
                    filas += "</tr>";
                }

                paginahtml_texto = paginahtml_texto.Replace("@FILAS", filas);

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
            else if(cbxTablas.Text == d4)
            {
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.FileName = dtpFechainicial.Text + " - " + dtpFechaFinal.Text + " " + cbxTablas.Text + ".pdf";
                guardar.ShowDialog();

                string paginahtml_texto = Properties.Resources.plantilla6.ToString();
                paginahtml_texto = paginahtml_texto.Replace("@USUARIO", txtUsuario.Text);
                paginahtml_texto = paginahtml_texto.Replace("@REPORTE", cbxTablas.Text);
                paginahtml_texto = paginahtml_texto.Replace("@FECHA", DateTime.Now.ToString("yyyy'/'MM'/'dd"));

                string filas = string.Empty;

                foreach (DataGridViewRow row in dgvResultado.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells[0].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells[1].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells[2].Value.ToString() + "</td>";
                    filas += "</tr>";
                }

                paginahtml_texto = paginahtml_texto.Replace("@FILAS", filas);

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

        private void lblUsuario_Click(object sender, EventArgs e)
        {
            cbxUsuario.Select();
            SendKeys.Send("%{DOWN}");
        }

        private void cbxUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblUsuario.Text = cbxUsuario.Text;
        }
    }
}
