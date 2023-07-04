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
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.Odbc;

namespace CapaVista
{
    public partial class Dashboard2 : Form
    {

        private Button currentButton;

        public Dashboard2()
        {
            InitializeComponent();
            desabilitar();
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

        public void grafica1()
        {
            DataTable dt = sn.llenarGrafica1(dtpStartDate.Text, dtpEndDate.Text);
            chrGraficaEntrada.Series.Clear();
            chrGraficaEntrada.ChartAreas.Clear();
            chrGraficaEntrada.Palette = ChartColorPalette.Excel;
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
            aregrafico.AxisY.IsMarginVisible = false;
            chrGraficaEntrada.ChartAreas.Add(aregrafico);
            Series series = new Series("Producto");
            series.ChartType = SeriesChartType.Column;
            series.BackGradientStyle = GradientStyle.LeftRight;
            series.Color = Color.FromArgb(241, 88, 127);
            series.BackSecondaryColor = Color.FromArgb(107, 83, 255);
            series.XValueMember = "IdProducto";
            series.YValueMembers = "Total";
            chrGraficaEntrada.Series.Add(series);
            chrGraficaEntrada.DataSource = dt;
        }

        public void grafica2()
        {
            DataTable dt = sn.llenarGrafica2(dtpStartDate.Text, dtpEndDate.Text);
            chrGraficaSalida.Series.Clear();
            chrGraficaSalida.ChartAreas.Clear();
            chrGraficaEntrada.Palette = ChartColorPalette.Excel;
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
            aregrafico.AxisY.IsMarginVisible = false;
            chrGraficaSalida.ChartAreas.Add(aregrafico);
            Series series = new Series("Producto");
            series.ChartType = SeriesChartType.Column;
            series.BackGradientStyle = GradientStyle.LeftRight;
            series.Color = Color.FromArgb(241, 88, 127);
            series.BackSecondaryColor = Color.FromArgb(107, 83, 255);
            series.XValueMember = "IdProducto";
            series.YValueMembers = "Total";
            chrGraficaSalida.Series.Add(series);
            chrGraficaSalida.DataSource = dt;
        }

        private void btnOkCustomDate_Click(object sender, EventArgs e)
        {
            grafica1();
            grafica2();
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;

            MenuButton(sender);
            desabilitar();
            grafica1();
            grafica2();
        }

        private void btnLast30Day_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;

            MenuButton(sender);
            desabilitar();
            grafica1();
            grafica2();
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;

            MenuButton(sender);
            desabilitar();
            grafica1();
            grafica2();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;

            MenuButton(sender);
            desabilitar();
            grafica1();
            grafica2();
        }

        private void btnCustomDate_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            habilitar();
            MenuButton(sender);
        }

        private void lblFecha1_Click(object sender, EventArgs e)
        {
            if (currentButton == btnCustomDate)
            {
                dtpStartDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void lblFecha2_Click(object sender, EventArgs e)
        {
            if (currentButton == btnCustomDate)
            {
                dtpEndDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            lblFecha1.Text = dtpStartDate.Text;
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            lblFecha2.Text = dtpEndDate.Text;
        }
    }
}
