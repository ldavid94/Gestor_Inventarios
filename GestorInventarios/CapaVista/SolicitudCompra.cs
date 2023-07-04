using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using CapaControlador;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace CapaVista
{
    public partial class SolicitudCompra : Form
    {
        public SolicitudCompra()
        {
            InitializeComponent();
        }

        public SolicitudCompra(String texto)
        {
            InitializeComponent();
            actualizardvg();
            llenarcbxidproductos();
            txtCodigo.Enabled = false;
            txtUsuario.Text = texto;
            DateTime fh = DateTime.Now;
            txtFecha.Text = fh.ToString("yyyy'-'MM'-'dd");
            txtHora.Text = fh.ToString("HH':'mm");
        }
        
        Controlador sn = new Controlador();
        String tabla = "tbl_compra";

        public void actualizardvg()
        {
            DataTable dt = sn.llenarTblCom(tabla);
            dgvCompra.DataSource = dt;
        }

        public void cleanTextbox()
        {
            cbxIdProducto.Text = "";
            txtDescripcionProducto.Text = "";
        }

        public void llenarcbxidproductos()
        {
            try
            {
                cbxIdProducto.Items.Clear();
                OdbcDataReader datareader = sn.llenarcbxIdProducto();
                while (datareader.Read())
                {
                    cbxIdProducto.Items.Add(datareader[0].ToString());
                }
                cbxIdProducto.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        public void llenartxtDescripiones()
        {
            try
            {
                txtDescripcionProducto.Items.Clear();
                OdbcDataReader datareader = sn.llenartxtDes(cbxIdProducto.Text);
                while (datareader.Read())
                {
                    txtDescripcionProducto.Items.Add(datareader[0].ToString());
                }
                txtDescripcionProducto.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string cantidad;
            cantidad = txtCantidad.Value.ToString();

            sn.guardarCompra(txtFecha.Text, cbxIdProducto.Text, txtDescripcionProducto.Text, cantidad);
            actualizardvg();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            sn.guardarBitacoraCompra(txtFecha.Text, txtHora.Text, txtUsuario.Text);
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = txtFecha.Text + " " + txtUsuario.Text + ".pdf";
            guardar.ShowDialog();

            string paginahtml_texto = Properties.Resources.plantilla7.ToString();
            paginahtml_texto = paginahtml_texto.Replace("@USUARIO", txtUsuario.Text);
            paginahtml_texto = paginahtml_texto.Replace("@FECHA", DateTime.Now.ToString("yyyy'/'MM'/'dd"));
            paginahtml_texto = paginahtml_texto.Replace("@HORA", DateTime.Now.ToString("HH':'mm"));

            string filas = string.Empty;

            foreach (DataGridViewRow row in dgvCompra.Rows)
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            sn.borrar_compra(txtCodigo.Text);
            actualizardvg();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string cantidad;
            cantidad = txtCantidad.Value.ToString();

            sn.guardarModificacionCompra(cantidad, txtCodigo.Text);
            actualizardvg();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        { 
            sn.NuevaCompra(tabla);
            actualizardvg();
        }

        private void SolicitudCompra_Load(object sender, EventArgs e){ }

        private void cbxIdProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenartxtDescripiones();
            lblIdProducto.Text = cbxIdProducto.Text;
        }

        private void dgvCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvCompra.CurrentRow.Cells[0].Value.ToString();
            cbxIdProducto.Text = dgvCompra.CurrentRow.Cells[1].Value.ToString();
            txtDescripcionProducto.Text = dgvCompra.CurrentRow.Cells[2].Value.ToString();
            txtCantidad.Text = dgvCompra.CurrentRow.Cells[3].Value.ToString();
        }

        private void lblIdProducto_Click(object sender, EventArgs e)
        {
            cbxIdProducto.Select();
            SendKeys.Send("%{DOWN}");
        }

        private void txtDescripcionProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDescripcionProducto.Text = txtDescripcionProducto.Text;
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
    }
}
