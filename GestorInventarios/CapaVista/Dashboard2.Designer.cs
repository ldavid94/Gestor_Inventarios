
namespace CapaVista
{
    partial class Dashboard2
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
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFecha1 = new System.Windows.Forms.Label();
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnOkCustomDate = new System.Windows.Forms.Button();
            this.btnThisMonth = new System.Windows.Forms.Button();
            this.btnCustomDate = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnLast7Days = new System.Windows.Forms.Button();
            this.btnLast30Day = new System.Windows.Forms.Button();
            this.chrGraficaEntrada = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrGraficaSalida = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelgrafica1 = new System.Windows.Forms.Panel();
            this.panelMargen = new System.Windows.Forms.Panel();
            this.panelgrafica2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chrGraficaEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrGraficaSalida)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelgrafica1.SuspendLayout();
            this.panelgrafica2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dashboard 2";
            // 
            // lblFecha1
            // 
            this.lblFecha1.AutoSize = true;
            this.lblFecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha1.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFecha1.Location = new System.Drawing.Point(212, 21);
            this.lblFecha1.MinimumSize = new System.Drawing.Size(101, 0);
            this.lblFecha1.Name = "lblFecha1";
            this.lblFecha1.Size = new System.Drawing.Size(101, 18);
            this.lblFecha1.TabIndex = 3;
            this.lblFecha1.Text = "2023-05-03";
            this.lblFecha1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFecha1.Click += new System.EventHandler(this.lblFecha1_Click);
            // 
            // lblFecha2
            // 
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha2.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFecha2.Location = new System.Drawing.Point(354, 21);
            this.lblFecha2.MinimumSize = new System.Drawing.Size(101, 0);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(101, 18);
            this.lblFecha2.TabIndex = 20;
            this.lblFecha2.Text = "2023-05-03";
            this.lblFecha2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFecha2.Click += new System.EventHandler(this.lblFecha2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(327, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "-";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "yyyy-MM-dd";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(212, 21);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(101, 20);
            this.dtpStartDate.TabIndex = 22;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "yyyy-MM-dd";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(354, 21);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(101, 20);
            this.dtpEndDate.TabIndex = 23;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // btnOkCustomDate
            // 
            this.btnOkCustomDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOkCustomDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.btnOkCustomDate.FlatAppearance.BorderSize = 0;
            this.btnOkCustomDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkCustomDate.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnOkCustomDate.Image = global::CapaVista.Properties.Resources.img_26;
            this.btnOkCustomDate.Location = new System.Drawing.Point(535, 14);
            this.btnOkCustomDate.Name = "btnOkCustomDate";
            this.btnOkCustomDate.Size = new System.Drawing.Size(34, 30);
            this.btnOkCustomDate.TabIndex = 24;
            this.btnOkCustomDate.UseVisualStyleBackColor = false;
            this.btnOkCustomDate.Click += new System.EventHandler(this.btnOkCustomDate_Click);
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThisMonth.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnThisMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThisMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThisMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnThisMonth.Location = new System.Drawing.Point(1055, 15);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(120, 30);
            this.btnThisMonth.TabIndex = 29;
            this.btnThisMonth.Text = "Este Mes";
            this.btnThisMonth.UseVisualStyleBackColor = true;
            this.btnThisMonth.Click += new System.EventHandler(this.btnThisMonth_Click);
            // 
            // btnCustomDate
            // 
            this.btnCustomDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomDate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnCustomDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnCustomDate.Location = new System.Drawing.Point(575, 15);
            this.btnCustomDate.Name = "btnCustomDate";
            this.btnCustomDate.Size = new System.Drawing.Size(120, 30);
            this.btnCustomDate.TabIndex = 28;
            this.btnCustomDate.Text = "Custom";
            this.btnCustomDate.UseVisualStyleBackColor = true;
            this.btnCustomDate.Click += new System.EventHandler(this.btnCustomDate_Click);
            // 
            // btnToday
            // 
            this.btnToday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnToday.Location = new System.Drawing.Point(695, 15);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(120, 30);
            this.btnToday.TabIndex = 27;
            this.btnToday.Text = "Hoy";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnLast7Days
            // 
            this.btnLast7Days.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLast7Days.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnLast7Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast7Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast7Days.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnLast7Days.Location = new System.Drawing.Point(815, 15);
            this.btnLast7Days.Name = "btnLast7Days";
            this.btnLast7Days.Size = new System.Drawing.Size(120, 30);
            this.btnLast7Days.TabIndex = 26;
            this.btnLast7Days.Text = "Últimos 7 dias";
            this.btnLast7Days.UseVisualStyleBackColor = true;
            this.btnLast7Days.Click += new System.EventHandler(this.btnLast7Days_Click);
            // 
            // btnLast30Day
            // 
            this.btnLast30Day.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLast30Day.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnLast30Day.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast30Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast30Day.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnLast30Day.Location = new System.Drawing.Point(935, 15);
            this.btnLast30Day.Name = "btnLast30Day";
            this.btnLast30Day.Size = new System.Drawing.Size(120, 30);
            this.btnLast30Day.TabIndex = 25;
            this.btnLast30Day.Text = "Últimos 30 días";
            this.btnLast30Day.UseVisualStyleBackColor = true;
            this.btnLast30Day.Click += new System.EventHandler(this.btnLast30Day_Click);
            // 
            // chrGraficaEntrada
            // 
            this.chrGraficaEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea1.Name = "ChartArea1";
            this.chrGraficaEntrada.ChartAreas.Add(chartArea1);
            this.chrGraficaEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.ForeColor = System.Drawing.Color.Gainsboro;
            legend1.Name = "Legend1";
            this.chrGraficaEntrada.Legends.Add(legend1);
            this.chrGraficaEntrada.Location = new System.Drawing.Point(0, 0);
            this.chrGraficaEntrada.Name = "chrGraficaEntrada";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrGraficaEntrada.Series.Add(series1);
            this.chrGraficaEntrada.Size = new System.Drawing.Size(1182, 300);
            this.chrGraficaEntrada.TabIndex = 32;
            this.chrGraficaEntrada.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title1.ForeColor = System.Drawing.Color.Gainsboro;
            title1.Name = "Title1";
            title1.Text = "Entradas";
            this.chrGraficaEntrada.Titles.Add(title1);
            // 
            // chrGraficaSalida
            // 
            this.chrGraficaSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea2.Name = "ChartArea1";
            this.chrGraficaSalida.ChartAreas.Add(chartArea2);
            this.chrGraficaSalida.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.ForeColor = System.Drawing.Color.Gainsboro;
            legend2.Name = "Legend1";
            this.chrGraficaSalida.Legends.Add(legend2);
            this.chrGraficaSalida.Location = new System.Drawing.Point(0, 0);
            this.chrGraficaSalida.Name = "chrGraficaSalida";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chrGraficaSalida.Series.Add(series2);
            this.chrGraficaSalida.Size = new System.Drawing.Size(1182, 300);
            this.chrGraficaSalida.TabIndex = 33;
            this.chrGraficaSalida.Text = "chart1";
            title2.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title2.ForeColor = System.Drawing.Color.Gainsboro;
            title2.Name = "Title1";
            title2.Text = "Salidas";
            this.chrGraficaSalida.Titles.Add(title2);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblFecha1);
            this.panel1.Controls.Add(this.dtpStartDate);
            this.panel1.Controls.Add(this.btnThisMonth);
            this.panel1.Controls.Add(this.btnCustomDate);
            this.panel1.Controls.Add(this.lblFecha2);
            this.panel1.Controls.Add(this.btnToday);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnLast7Days);
            this.panel1.Controls.Add(this.dtpEndDate);
            this.panel1.Controls.Add(this.btnLast30Day);
            this.panel1.Controls.Add(this.btnOkCustomDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 62);
            this.panel1.TabIndex = 34;
            // 
            // panelgrafica1
            // 
            this.panelgrafica1.Controls.Add(this.chrGraficaEntrada);
            this.panelgrafica1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelgrafica1.Location = new System.Drawing.Point(0, 62);
            this.panelgrafica1.Name = "panelgrafica1";
            this.panelgrafica1.Size = new System.Drawing.Size(1182, 300);
            this.panelgrafica1.TabIndex = 35;
            // 
            // panelMargen
            // 
            this.panelMargen.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMargen.Location = new System.Drawing.Point(0, 362);
            this.panelMargen.Name = "panelMargen";
            this.panelMargen.Size = new System.Drawing.Size(1182, 12);
            this.panelMargen.TabIndex = 36;
            // 
            // panelgrafica2
            // 
            this.panelgrafica2.Controls.Add(this.chrGraficaSalida);
            this.panelgrafica2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelgrafica2.Location = new System.Drawing.Point(0, 374);
            this.panelgrafica2.Name = "panelgrafica2";
            this.panelgrafica2.Size = new System.Drawing.Size(1182, 300);
            this.panelgrafica2.TabIndex = 37;
            // 
            // Dashboard2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1182, 679);
            this.Controls.Add(this.panelgrafica2);
            this.Controls.Add(this.panelMargen);
            this.Controls.Add(this.panelgrafica1);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard2";
            this.Text = "Dashboard 2";
            ((System.ComponentModel.ISupportInitialize)(this.chrGraficaEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrGraficaSalida)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelgrafica1.ResumeLayout(false);
            this.panelgrafica2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFecha1;
        private System.Windows.Forms.Label lblFecha2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnOkCustomDate;
        private System.Windows.Forms.Button btnThisMonth;
        private System.Windows.Forms.Button btnCustomDate;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnLast7Days;
        private System.Windows.Forms.Button btnLast30Day;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrGraficaEntrada;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrGraficaSalida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelgrafica1;
        private System.Windows.Forms.Panel panelMargen;
        private System.Windows.Forms.Panel panelgrafica2;
    }
}