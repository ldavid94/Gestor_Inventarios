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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using System.Drawing.Drawing2D;

namespace CapaVista
{
    public partial class NSalida : Form
    {

        private int borderRadius = 30;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(226, 62, 87);

        public NSalida()
        {
            InitializeComponent();
        }

        public NSalida(String texto)
        {
            InitializeComponent();
            llenarcbxNombreAlmacenes();
            actualizardvg();
            txtNombre.Text = texto;
            txtNombre.Enabled = false;
            txtRegistro.Text = "Salida";
            txtRegistro.Enabled = false;
            txtFecha.Enabled = false;
            DateTime fh = DateTime.Now;
            txtFecha.Text = fh.ToString("yyyy'-'MM'-'dd");
            txtHora.Text = fh.ToString("HH':'mm");
        }

        Controlador sn = new Controlador();
        String tabla = "tbl_control";

        private GraphicsPath GetRoundedPath(System.Drawing.Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        System.Drawing.Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);
                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);
                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }

        public void llenarcbxNombreAlmacenes()
        {
            try
            {
                cbxAlmacen.Items.Clear();
                OdbcDataReader datareader = sn.llenarcbxNombreA();
                while (datareader.Read())
                {
                    cbxAlmacen.Items.Add(datareader[0].ToString());
                }
                cbxAlmacen.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        public void llenartxtStock()
        {
            try
            {
                txtStock.Items.Clear();
                OdbcDataReader datareader = sn.llenartxtStock(cbxIdProducto.Text);
                while (datareader.Read())
                {
                    txtStock.Items.Add(datareader[0].ToString());
                }
                txtStock.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
        }

        public void llenartxtsalida()
        {
            try
            {
                cbxSalidas.Items.Clear();
                OdbcDataReader datareader = sn.llenartxtsalida(cbxIdProducto.Text);
                while (datareader.Read())
                {
                    cbxSalidas.Items.Add(datareader[0].ToString());
                }
                cbxSalidas.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
        }

        public void llenarcbxPrecioC()
        {
            try
            {
                cbxPCompra.Items.Clear();
                OdbcDataReader datareader = sn.llenarcbxPC(cbxIdProducto.Text);
                while (datareader.Read())
                {
                    cbxPCompra.Items.Add(datareader[0].ToString());
                }
                cbxPCompra.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
        }

        public void llenarcbxPrecioV()
        {
            try
            {
                cbxPVenta.Items.Clear();
                OdbcDataReader datareader = sn.llenarcbxPV(cbxIdProducto.Text);
                while (datareader.Read())
                {
                    cbxPVenta.Items.Add(datareader[0].ToString());
                }
                cbxPVenta.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
        }

        public void llenartxtIDProducto()
        {
            try
            {
                cbxIdProducto.Items.Clear();
                OdbcDataReader datareader = sn.llenarcbxIDprodu(cbxProducto.Text);
                while (datareader.Read())
                {
                    cbxIdProducto.Items.Add(datareader[0].ToString());
                }
                cbxIdProducto.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
        }

        public void llenartxtNProducto()
        {
            try
            {
                cbxProducto.Items.Clear();
                OdbcDataReader datareader = sn.llenarcbxNomProducto(cbxAlmacen.Text);
                while (datareader.Read())
                {
                    cbxProducto.Items.Add(datareader[0].ToString());
                }
                cbxProducto.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
        }

        public void llenartxtidAlmaceno()
        {
            try
            {
                cbxIdAlmacen.Items.Clear();
                OdbcDataReader datareader = sn.llenarcbxIDAlm(cbxAlmacen.Text);
                while (datareader.Read())
                {
                    cbxIdAlmacen.Items.Add(datareader[0].ToString());
                }
                cbxIdAlmacen.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
        }

        public void actualizardvg()
        {
            DataTable dt = sn.llenarTblCon(tabla);
            dgvSalida.DataSource = dt;
        }

        public void cleanTextbox()
        {
            txtCantidad.Text = "1";   
        }

        private void cbxAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenartxtidAlmaceno();
            llenartxtNProducto();
            lblAlmacen.Text = cbxAlmacen.Text;
        }

        private void lblAlmacen_Click(object sender, EventArgs e)
        {
            cbxAlmacen.Select();
            SendKeys.Send("%{DOWN}");
        }

        private void cbxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenartxtIDProducto();
            lblSProducto.Text = cbxProducto.Text;
        }

        private void lblSProducto_Click(object sender, EventArgs e)
        {
            cbxProducto.Select();
            SendKeys.Send("%{DOWN}");
        }

        private void txtStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblStock.Text = txtStock.Text;
        }

        private void btnNuevaEntrada_Click(object sender, EventArgs e)
        {
            sn.NuevoRegistro(tabla);
            actualizardvg();
        }

        private void cbxIdProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarcbxPrecioV();
            llenarcbxPrecioC();
            llenartxtsalida();
            llenartxtStock();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            int d1, d2, d3;

            d1 = (int)txtCantidad.Value;
            d2 = Convert.ToInt32(txtStock.Text);
            d3 = Convert.ToInt32(cbxSalidas.Text);

            if (d2 == 0)
            {
                MessageBox.Show("No hay producto en Bodega");
            }
            else if (d2 >= d1)
                {

                string cantidad;
                cantidad = txtCantidad.Value.ToString();

                sn.relizarControl(cbxIdProducto.Text, cbxProducto.Text, cantidad);
                sn.guardarSalida(txtFecha.Text, txtNombre.Text, cbxIdAlmacen.Text, cbxAlmacen.Text, cbxIdProducto.Text, cbxProducto.Text, cantidad);

                int total1, total2;

                total1 = d2 - d1;
                total2 = d3 + d1;

                string entrada1, entrada2;
                entrada1 = Convert.ToString(total1);
                entrada2 = Convert.ToString(total2);

                sn.guardarSalidaInventario(entrada1, entrada2, cbxIdProducto.Text);

                double com, ven, can, res, mul;
                string total;

                com = Convert.ToDouble(cbxPCompra.Text);
                ven = Convert.ToDouble(cbxPVenta.Text);
                can = Convert.ToInt32(cantidad);

                res = ven - com;
                mul = res * can;

                total = Convert.ToString(mul);

                sn.guardarGanancia(txtFecha.Text, total);
                }
                else
                    {
                        MessageBox.Show("No hay suficiente producto para generar la salida");
                    }
            actualizardvg();
            cleanTextbox();
        }

        private void btnRealizarSalida_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = DateTime.Now.ToString("yyyy'-'MM'-'dd") + " - " + txtNombre.Text + " " + txtRegistro.Text + ".pdf";
            guardar.ShowDialog();

            string paginahtml_texto = Properties.Resources.plantilla3.ToString();
            paginahtml_texto = paginahtml_texto.Replace("@USUARIO", txtNombre.Text);
            paginahtml_texto = paginahtml_texto.Replace("@REGISTRO", txtRegistro.Text);
            paginahtml_texto = paginahtml_texto.Replace("@FECHA", DateTime.Now.ToString("yyyy'/'MM'/'dd"));
            paginahtml_texto = paginahtml_texto.Replace("@ALMACEN", lblAlmacen.Text);

            string filas = string.Empty;
            int total = 0;

            foreach (DataGridViewRow row in dgvSalida.Rows)
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
            sn.relizarRegistroS(txtFecha.Text, txtHora.Text, txtRegistro.Text, cbxAlmacen.Text, txtNombre.Text, total.ToString());
            sn.guardarBitacoraSalidas(txtFecha.Text, txtHora.Text, txtNombre.Text, total.ToString());
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir? ", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void NSalida_Paint(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }
    }
}
