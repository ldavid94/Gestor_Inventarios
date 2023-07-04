
namespace CapaVista
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnLast30Day = new System.Windows.Forms.Button();
            this.btnLast7Days = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnCustomDate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblTotalSalidas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTotalGanancia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chrTopProductos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTotalEntradas = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblTotalProducto = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNumeroProveedores = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxSalidas = new System.Windows.Forms.ComboBox();
            this.cbxEntradas = new System.Windows.Forms.ComboBox();
            this.cbxGanancias = new System.Windows.Forms.ComboBox();
            this.cbxProveedores = new System.Windows.Forms.ComboBox();
            this.cbxProducto = new System.Windows.Forms.ComboBox();
            this.btnThisMonth = new System.Windows.Forms.Button();
            this.lblFecha1 = new System.Windows.Forms.Label();
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOkCustomDate = new System.Windows.Forms.Button();
            this.chrGraficaSalidas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrGraficaCompras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrTopProductos)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrGraficaSalidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrGraficaCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "yyyy-MM-dd";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(205, 18);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(101, 20);
            this.dtpStartDate.TabIndex = 1;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "yyyy-MM-dd";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(331, 18);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(101, 20);
            this.dtpEndDate.TabIndex = 2;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // btnLast30Day
            // 
            this.btnLast30Day.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLast30Day.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnLast30Day.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast30Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast30Day.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnLast30Day.Location = new System.Drawing.Point(927, 8);
            this.btnLast30Day.Name = "btnLast30Day";
            this.btnLast30Day.Size = new System.Drawing.Size(120, 30);
            this.btnLast30Day.TabIndex = 4;
            this.btnLast30Day.Text = "Últimos 30 días";
            this.btnLast30Day.UseVisualStyleBackColor = true;
            this.btnLast30Day.Click += new System.EventHandler(this.btnLast30Day_Click);
            // 
            // btnLast7Days
            // 
            this.btnLast7Days.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLast7Days.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnLast7Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast7Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast7Days.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnLast7Days.Location = new System.Drawing.Point(807, 8);
            this.btnLast7Days.Name = "btnLast7Days";
            this.btnLast7Days.Size = new System.Drawing.Size(120, 30);
            this.btnLast7Days.TabIndex = 5;
            this.btnLast7Days.Text = "Últimos 7 dias";
            this.btnLast7Days.UseVisualStyleBackColor = true;
            this.btnLast7Days.Click += new System.EventHandler(this.btnLast7Days_Click);
            // 
            // btnToday
            // 
            this.btnToday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnToday.Location = new System.Drawing.Point(687, 8);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(120, 30);
            this.btnToday.TabIndex = 6;
            this.btnToday.Text = "Hoy";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnCustomDate
            // 
            this.btnCustomDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomDate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnCustomDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnCustomDate.Location = new System.Drawing.Point(567, 8);
            this.btnCustomDate.Name = "btnCustomDate";
            this.btnCustomDate.Size = new System.Drawing.Size(120, 30);
            this.btnCustomDate.TabIndex = 7;
            this.btnCustomDate.Text = "Custom";
            this.btnCustomDate.UseVisualStyleBackColor = true;
            this.btnCustomDate.Click += new System.EventHandler(this.btnCustomDate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.lblTotalSalidas);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(6, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 67);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.pictureBox3.Image = global::CapaVista.Properties.Resources.Salidas;
            this.pictureBox3.Location = new System.Drawing.Point(12, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // lblTotalSalidas
            // 
            this.lblTotalSalidas.AutoSize = true;
            this.lblTotalSalidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSalidas.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTotalSalidas.Location = new System.Drawing.Point(86, 31);
            this.lblTotalSalidas.Name = "lblTotalSalidas";
            this.lblTotalSalidas.Size = new System.Drawing.Size(67, 25);
            this.lblTotalSalidas.TabIndex = 1;
            this.lblTotalSalidas.Text = "10000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label2.Location = new System.Drawing.Point(90, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Salidas";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblTotalGanancia);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(664, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 67);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.pictureBox1.Image = global::CapaVista.Properties.Resources.Ganancias;
            this.pictureBox1.Location = new System.Drawing.Point(28, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // lblTotalGanancia
            // 
            this.lblTotalGanancia.AutoSize = true;
            this.lblTotalGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGanancia.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTotalGanancia.Location = new System.Drawing.Point(100, 31);
            this.lblTotalGanancia.Name = "lblTotalGanancia";
            this.lblTotalGanancia.Size = new System.Drawing.Size(67, 25);
            this.lblTotalGanancia.TabIndex = 1;
            this.lblTotalGanancia.Text = "10000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label4.Location = new System.Drawing.Point(101, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ganancia";
            // 
            // chrTopProductos
            // 
            this.chrTopProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chrTopProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea1.Name = "ChartArea1";
            this.chrTopProductos.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.ForeColor = System.Drawing.Color.Gainsboro;
            legend1.Name = "Legend1";
            this.chrTopProductos.Legends.Add(legend1);
            this.chrTopProductos.Location = new System.Drawing.Point(807, 131);
            this.chrTopProductos.Name = "chrTopProductos";
            this.chrTopProductos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chrTopProductos.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(160)))), ((int)(((byte)(139))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(188)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(220)))), ((int)(((byte)(205))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(153)))), ((int)(((byte)(254)))))};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrTopProductos.Series.Add(series1);
            this.chrTopProductos.Size = new System.Drawing.Size(359, 534);
            this.chrTopProductos.TabIndex = 12;
            this.chrTopProductos.Text = "chartTopProducts";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title1.ForeColor = System.Drawing.Color.Gainsboro;
            title1.Name = "Title1";
            title1.Text = "Top 5 Productos";
            this.chrTopProductos.Titles.Add(title1);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.lblTotalEntradas);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(273, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 67);
            this.panel3.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.pictureBox2.Image = global::CapaVista.Properties.Resources.Entradas;
            this.pictureBox2.Location = new System.Drawing.Point(11, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // lblTotalEntradas
            // 
            this.lblTotalEntradas.AutoSize = true;
            this.lblTotalEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEntradas.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTotalEntradas.Location = new System.Drawing.Point(98, 31);
            this.lblTotalEntradas.Name = "lblTotalEntradas";
            this.lblTotalEntradas.Size = new System.Drawing.Size(67, 25);
            this.lblTotalEntradas.TabIndex = 1;
            this.lblTotalEntradas.Text = "10000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label6.Location = new System.Drawing.Point(100, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Entradas";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.lblTotalProducto);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.lblNumeroProveedores);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(6, 483);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(212, 182);
            this.panel4.TabIndex = 10;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.pictureBox5.Image = global::CapaVista.Properties.Resources.Producto;
            this.pictureBox5.Location = new System.Drawing.Point(14, 111);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.pictureBox4.Image = global::CapaVista.Properties.Resources.Proveedores;
            this.pictureBox4.Location = new System.Drawing.Point(14, 38);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // lblTotalProducto
            // 
            this.lblTotalProducto.AutoSize = true;
            this.lblTotalProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProducto.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTotalProducto.Location = new System.Drawing.Point(69, 135);
            this.lblTotalProducto.Name = "lblTotalProducto";
            this.lblTotalProducto.Size = new System.Drawing.Size(67, 25);
            this.lblTotalProducto.TabIndex = 4;
            this.lblTotalProducto.Text = "10000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label10.Location = new System.Drawing.Point(74, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "Producto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Contador Total";
            // 
            // lblNumeroProveedores
            // 
            this.lblNumeroProveedores.AutoSize = true;
            this.lblNumeroProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroProveedores.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNumeroProveedores.Location = new System.Drawing.Point(70, 55);
            this.lblNumeroProveedores.Name = "lblNumeroProveedores";
            this.lblNumeroProveedores.Size = new System.Drawing.Size(67, 25);
            this.lblNumeroProveedores.TabIndex = 1;
            this.lblNumeroProveedores.Text = "10000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label8.Location = new System.Drawing.Point(70, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = " Proveedores";
            // 
            // cbxSalidas
            // 
            this.cbxSalidas.FormattingEnabled = true;
            this.cbxSalidas.Location = new System.Drawing.Point(217, 168);
            this.cbxSalidas.Name = "cbxSalidas";
            this.cbxSalidas.Size = new System.Drawing.Size(75, 21);
            this.cbxSalidas.TabIndex = 13;
            this.cbxSalidas.SelectedIndexChanged += new System.EventHandler(this.cbxSalidas_SelectedIndexChanged);
            // 
            // cbxEntradas
            // 
            this.cbxEntradas.FormattingEnabled = true;
            this.cbxEntradas.Location = new System.Drawing.Point(342, 168);
            this.cbxEntradas.Name = "cbxEntradas";
            this.cbxEntradas.Size = new System.Drawing.Size(75, 21);
            this.cbxEntradas.TabIndex = 14;
            this.cbxEntradas.SelectedIndexChanged += new System.EventHandler(this.cbxEntradas_SelectedIndexChanged);
            // 
            // cbxGanancias
            // 
            this.cbxGanancias.FormattingEnabled = true;
            this.cbxGanancias.Location = new System.Drawing.Point(423, 168);
            this.cbxGanancias.Name = "cbxGanancias";
            this.cbxGanancias.Size = new System.Drawing.Size(75, 21);
            this.cbxGanancias.TabIndex = 15;
            this.cbxGanancias.SelectedIndexChanged += new System.EventHandler(this.cbxGanancias_SelectedIndexChanged);
            // 
            // cbxProveedores
            // 
            this.cbxProveedores.FormattingEnabled = true;
            this.cbxProveedores.Location = new System.Drawing.Point(504, 168);
            this.cbxProveedores.Name = "cbxProveedores";
            this.cbxProveedores.Size = new System.Drawing.Size(75, 21);
            this.cbxProveedores.TabIndex = 16;
            this.cbxProveedores.SelectedIndexChanged += new System.EventHandler(this.cbxProveedores_SelectedIndexChanged);
            // 
            // cbxProducto
            // 
            this.cbxProducto.FormattingEnabled = true;
            this.cbxProducto.Location = new System.Drawing.Point(586, 168);
            this.cbxProducto.Name = "cbxProducto";
            this.cbxProducto.Size = new System.Drawing.Size(75, 21);
            this.cbxProducto.TabIndex = 17;
            this.cbxProducto.SelectedIndexChanged += new System.EventHandler(this.cbxProducto_SelectedIndexChanged);
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThisMonth.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnThisMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThisMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThisMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnThisMonth.Location = new System.Drawing.Point(1047, 8);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(120, 30);
            this.btnThisMonth.TabIndex = 18;
            this.btnThisMonth.Text = "Este Mes";
            this.btnThisMonth.UseVisualStyleBackColor = true;
            this.btnThisMonth.Click += new System.EventHandler(this.btnThisMonth_Click_1);
            // 
            // lblFecha1
            // 
            this.lblFecha1.AutoSize = true;
            this.lblFecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha1.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFecha1.Location = new System.Drawing.Point(205, 18);
            this.lblFecha1.MinimumSize = new System.Drawing.Size(101, 0);
            this.lblFecha1.Name = "lblFecha1";
            this.lblFecha1.Size = new System.Drawing.Size(101, 18);
            this.lblFecha1.TabIndex = 2;
            this.lblFecha1.Text = "2023-05-03";
            this.lblFecha1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFecha1.Click += new System.EventHandler(this.lblFecha1_Click);
            // 
            // lblFecha2
            // 
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha2.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFecha2.Location = new System.Drawing.Point(331, 18);
            this.lblFecha2.MinimumSize = new System.Drawing.Size(101, 0);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(101, 18);
            this.lblFecha2.TabIndex = 19;
            this.lblFecha2.Text = "2023-05-03";
            this.lblFecha2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFecha2.Click += new System.EventHandler(this.lblFecha2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(314, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "-";
            // 
            // btnOkCustomDate
            // 
            this.btnOkCustomDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOkCustomDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.btnOkCustomDate.FlatAppearance.BorderSize = 0;
            this.btnOkCustomDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkCustomDate.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnOkCustomDate.Image = global::CapaVista.Properties.Resources.img_26;
            this.btnOkCustomDate.Location = new System.Drawing.Point(531, 8);
            this.btnOkCustomDate.Name = "btnOkCustomDate";
            this.btnOkCustomDate.Size = new System.Drawing.Size(34, 30);
            this.btnOkCustomDate.TabIndex = 8;
            this.btnOkCustomDate.UseVisualStyleBackColor = false;
            this.btnOkCustomDate.Click += new System.EventHandler(this.btnOkCustomDate_Click);
            // 
            // chrGraficaSalidas
            // 
            this.chrGraficaSalidas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chrGraficaSalidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea2.Name = "ChartArea1";
            this.chrGraficaSalidas.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            legend2.ForeColor = System.Drawing.Color.Gainsboro;
            legend2.Name = "Legend1";
            this.chrGraficaSalidas.Legends.Add(legend2);
            this.chrGraficaSalidas.Location = new System.Drawing.Point(6, 131);
            this.chrGraficaSalidas.Name = "chrGraficaSalidas";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chrGraficaSalidas.Series.Add(series2);
            this.chrGraficaSalidas.Size = new System.Drawing.Size(795, 346);
            this.chrGraficaSalidas.TabIndex = 21;
            this.chrGraficaSalidas.Text = "chart1";
            // 
            // chrGraficaCompras
            // 
            this.chrGraficaCompras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chrGraficaCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea3.Name = "ChartArea1";
            this.chrGraficaCompras.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            legend3.ForeColor = System.Drawing.Color.Gainsboro;
            legend3.Name = "Legend1";
            this.chrGraficaCompras.Legends.Add(legend3);
            this.chrGraficaCompras.Location = new System.Drawing.Point(224, 483);
            this.chrGraficaCompras.Name = "chrGraficaCompras";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chrGraficaCompras.Series.Add(series3);
            this.chrGraficaCompras.Size = new System.Drawing.Size(577, 182);
            this.chrGraficaCompras.TabIndex = 22;
            this.chrGraficaCompras.Text = "chart1";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1178, 671);
            this.Controls.Add(this.chrGraficaCompras);
            this.Controls.Add(this.chrGraficaSalidas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFecha2);
            this.Controls.Add(this.lblFecha1);
            this.Controls.Add(this.btnThisMonth);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.chrTopProductos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOkCustomDate);
            this.Controls.Add(this.btnCustomDate);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.btnLast7Days);
            this.Controls.Add(this.btnLast30Day);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxSalidas);
            this.Controls.Add(this.cbxEntradas);
            this.Controls.Add(this.cbxGanancias);
            this.Controls.Add(this.cbxProveedores);
            this.Controls.Add(this.cbxProducto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrTopProductos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrGraficaSalidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrGraficaCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnLast30Day;
        private System.Windows.Forms.Button btnLast7Days;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnCustomDate;
        private System.Windows.Forms.Button btnOkCustomDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalSalidas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalGanancia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrTopProductos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalEntradas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblNumeroProveedores;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxSalidas;
        private System.Windows.Forms.ComboBox cbxEntradas;
        private System.Windows.Forms.ComboBox cbxGanancias;
        private System.Windows.Forms.ComboBox cbxProveedores;
        private System.Windows.Forms.ComboBox cbxProducto;
        private System.Windows.Forms.Button btnThisMonth;
        private System.Windows.Forms.Label lblFecha1;
        private System.Windows.Forms.Label lblFecha2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrGraficaSalidas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrGraficaCompras;
    }
}