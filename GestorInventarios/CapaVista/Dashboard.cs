using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Windows.Forms.DataVisualization.Charting;
using CapaControlador;

namespace CapaVista
{
    public partial class Dashboard : Form
    {

        private Button currentButton;

        public Dashboard()
        {
            InitializeComponent();
            desabilitar();
            totalProveedores();
            totalProducto();
            grafica3();
        }
        
        Controlador sn = new Controlador();
        
        public void desabilitar()
        {
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            btnOkCustomDate.Visible = false;
        }

        public void habilitar()
        {
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;
            btnOkCustomDate.Visible = true;
        }

        public void MenuButton(object buton)
        {
            var btn = (Button)buton;
            btn.BackColor = btnLast30Day.FlatAppearance.BorderColor;
            btn.ForeColor = Color.White;
            if (currentButton != null && currentButton != btn)
            {
                currentButton.BackColor = this.BackColor;
                currentButton.ForeColor = Color.FromArgb(124, 141, 181);
            }
            currentButton = btn;
        }

        public void totalSalidas()
        {
            try
            {
                cbxSalidas.Items.Clear();
                OdbcDataReader datareader = sn.DashboardTotalS(dtpStartDate.Text, dtpEndDate.Text);
                while (datareader.Read())
                {
                    cbxSalidas.Items.Add(datareader[0].ToString());
                }
                cbxSalidas.SelectedIndex = 0;
            }catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        public void totalEntradas()
        {
            try
            {
                cbxEntradas.Items.Clear();
                OdbcDataReader datareader = sn.DashboardTotalE(dtpStartDate.Text, dtpEndDate.Text);
                while (datareader.Read())
                {
                    cbxEntradas.Items.Add(datareader[0].ToString());
                }
                cbxEntradas.SelectedIndex = 0;
            }catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        public void totalGanancias()
        {
            try
            {
                cbxGanancias.Items.Clear();
                OdbcDataReader datareader = sn.DashboardTotalI(dtpStartDate.Text, dtpEndDate.Text);
                while (datareader.Read())
                {
                    cbxGanancias.Items.Add(datareader[0].ToString());
                }
                cbxGanancias.SelectedIndex = 0;
            }catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        public void totalProveedores()
        {
            try
            {
                cbxProveedores.Items.Clear();
                OdbcDataReader datareader = sn.DashboardTotalpro();
                while (datareader.Read())
                {
                    cbxProveedores.Items.Add(datareader[0].ToString());
                }
                cbxProveedores.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        public void totalProducto()
        {
            try
            {
                cbxProducto.Items.Clear();
                OdbcDataReader datareader = sn.DashboardTotalprod(dtpStartDate.Text, dtpEndDate.Text);
                while (datareader.Read())
                {
                    cbxProducto.Items.Add(datareader[0].ToString());
                }
                cbxProducto.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;

            MenuButton(sender);
            desabilitar();
            totalSalidas();
            totalEntradas();
            totalGanancias();
            totalProveedores();
            totalProducto();
            grafica1();
            grafica2();

        }

        private void btnOkCustomDate_Click(object sender, EventArgs e)
        {
            totalSalidas();
            totalEntradas();
            totalGanancias();
            totalProveedores();
            totalProducto();
            grafica1();
            grafica2();
        }

        public void grafica1()
        {
            DataTable dt = sn.llenarGBarras(dtpStartDate.Text, dtpEndDate.Text);
            chrGraficaSalidas.Series.Clear();
            chrGraficaSalidas.ChartAreas.Clear();
            chrGraficaSalidas.Palette = ChartColorPalette.Excel;
            ChartArea aregrafico = new ChartArea();
            aregrafico.BackColor = Color.FromArgb(42, 45, 86);
            aregrafico.AxisX.LineWidth = 0;
            aregrafico.AxisX.MajorGrid.LineWidth = 0;
            aregrafico.AxisX.MajorTickMark.LineColor = Color.FromArgb(73, 75, 111);
            aregrafico.AxisX.MajorTickMark.Size = 3;
            aregrafico.AxisX.LabelStyle.ForeColor = Color.Silver;
            aregrafico.AxisX.IsMarginVisible = false;
            aregrafico.AxisY.LineWidth = 0;
            aregrafico.AxisY.MajorGrid.LineColor = Color.FromArgb(73, 75, 111);
            aregrafico.AxisY.MajorTickMark.LineColor = Color.FromArgb(73, 75, 111);
            aregrafico.AxisY.LabelStyle.ForeColor = Color.Silver;
            aregrafico.AxisX.IsMarginVisible = false;
            chrGraficaSalidas.ChartAreas.Add(aregrafico);
            Series series = new Series("Fechas");
            series.ChartType = SeriesChartType.Column;
            series.BackGradientStyle = GradientStyle.LeftRight;
            series.Color = Color.FromArgb(241, 88, 127);
            series.BackSecondaryColor = Color.FromArgb(107, 83, 255);
            series.XValueMember = "Fecha";
            series.YValueMembers = "Total";
            chrGraficaSalidas.Series.Add(series);
            chrGraficaSalidas.DataSource = dt;
        }

        public void grafica2()
        {
            DataTable dt = sn.llenarGpastel(dtpStartDate.Text, dtpEndDate.Text);
            chrTopProductos.Series.Clear();
            chrTopProductos.ChartAreas.Clear();
            ChartArea aregrafico = new ChartArea();
            aregrafico.BackColor = Color.FromArgb(42, 45, 86);
            chrTopProductos.ChartAreas.Add(aregrafico);
            Series series = new Series("Productos");
            series.ChartType = SeriesChartType.Doughnut;
            series.XValueMember = "Descripcion";
            series.YValueMembers = "Cantidad";
            series.IsValueShownAsLabel = true;
            series.BorderWidth = 5;
            series.BorderColor = Color.FromArgb(32, 47, 66);
            series.BackGradientStyle = GradientStyle.DiagonalRight;
            series.Color = Color.FromArgb(192, 192, 255);
            series.BackSecondaryColor = Color.FromArgb(255, 159, 255);
            chrTopProductos.Series.Add(series);
            chrTopProductos.DataSource = dt;
        }

        public void grafica3()
        {
            DataTable dt = sn.llenarGbarrashorizontal();
            chrGraficaCompras.Series.Clear();
            chrGraficaCompras.ChartAreas.Clear();
            chrGraficaCompras.Palette = ChartColorPalette.Excel;
            ChartArea aregrafico = new ChartArea();
            aregrafico.BackColor = Color.FromArgb(42, 45, 86);
            aregrafico.AxisX.LineWidth = 0;
            aregrafico.AxisX.MajorGrid.LineWidth = 0;
            aregrafico.AxisX.MajorTickMark.LineColor = Color.FromArgb(73, 75, 111);
            aregrafico.AxisX.MajorTickMark.Size = 3;
            aregrafico.AxisX.LabelStyle.ForeColor = Color.Silver;
            aregrafico.AxisY.LineWidth = 0;
            aregrafico.AxisY.MajorGrid.LineColor = Color.FromArgb(73, 75, 111);
            aregrafico.AxisY.MajorTickMark.LineColor = Color.FromArgb(73, 75, 111);
            aregrafico.AxisY.LabelStyle.ForeColor = Color.Silver;
            chrGraficaCompras.ChartAreas.Add(aregrafico);
            Series series = new Series("Compras");
            series.ChartType = SeriesChartType.Bar;
            series.XValueMember = "Proveedores";
            series.YValueMembers = "Total";
            chrGraficaCompras.Series.Add(series);
            chrGraficaCompras.DataSource = dt;
        }

        private void cbxSalidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTotalSalidas.Text = cbxSalidas.Text;
        }

        private void btnLast30Day_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;

            MenuButton(sender);
            desabilitar();
            totalSalidas();
            totalEntradas();
            totalGanancias();
            totalProveedores();
            totalProducto();
            grafica1();
            grafica2();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;

            MenuButton(sender);
            desabilitar();
            totalSalidas();
            totalEntradas();
            totalGanancias();
            totalProveedores();
            totalProducto();
            grafica1();
            grafica2();

        }

        private void btnThisMonth_Click(object sender, EventArgs e){ }

        private void btnCustomDate_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            habilitar();
            MenuButton(sender);
        }

        private void cbxEntradas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTotalEntradas.Text = cbxEntradas.Text;
        }

        private void cbxGanancias_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTotalGanancia.Text = "Q" + cbxGanancias.Text;
        }

        private void cbxProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNumeroProveedores.Text = cbxProveedores.Text;
        }

        private void cbxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTotalProducto.Text = cbxProducto.Text;
        }

        private void btnThisMonth_Click_1(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;

            MenuButton(sender);
            desabilitar();
            totalSalidas();
            totalEntradas();
            totalGanancias();
            totalProveedores();
            totalProducto();
            grafica1();
            grafica2();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            lblFecha1.Text = dtpStartDate.Text;
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            lblFecha2.Text = dtpEndDate.Text;
        }

        private void lblFecha1_Click(object sender, EventArgs e)
        {
            if(currentButton == btnCustomDate)
            {
                dtpStartDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void lblFecha2_Click(object sender, EventArgs e)
        {
            if(currentButton == btnCustomDate)
            {
                dtpEndDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblFecha1.Text = dtpStartDate.Text;
            lblFecha2.Text = dtpEndDate.Text;
        }
    }
}
