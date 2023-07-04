
namespace CapaVista
{
    partial class ReporteFecha
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteFecha));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHoy = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxTablas = new System.Windows.Forms.ComboBox();
            this.dtpFechainicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btn7Dias = new System.Windows.Forms.Button();
            this.btnMes = new System.Windows.Forms.Button();
            this.btn30Dias = new System.Windows.Forms.Button();
            this.btnAño = new System.Windows.Forms.Button();
            this.btnCustom = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblTabla = new System.Windows.Forms.Label();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lblFecha1 = new System.Windows.Forms.Label();
            this.lblFecha2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(801, 50);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Generar Reporte";
            // 
            // btnHoy
            // 
            this.btnHoy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnHoy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnHoy.Location = new System.Drawing.Point(16, 114);
            this.btnHoy.Name = "btnHoy";
            this.btnHoy.Size = new System.Drawing.Size(178, 28);
            this.btnHoy.TabIndex = 26;
            this.btnHoy.Text = "Hoy";
            this.btnHoy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHoy.UseVisualStyleBackColor = true;
            this.btnHoy.Click += new System.EventHandler(this.btnHoy_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(13, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 134;
            this.label5.Text = "Seleccionar Tabla:";
            // 
            // cbxTablas
            // 
            this.cbxTablas.FormattingEnabled = true;
            this.cbxTablas.Items.AddRange(new object[] {
            "Entradas",
            "Salidas"});
            this.cbxTablas.Location = new System.Drawing.Point(16, 87);
            this.cbxTablas.Name = "cbxTablas";
            this.cbxTablas.Size = new System.Drawing.Size(178, 21);
            this.cbxTablas.TabIndex = 135;
            this.cbxTablas.SelectedIndexChanged += new System.EventHandler(this.cbxTablas_SelectedIndexChanged);
            // 
            // dtpFechainicial
            // 
            this.dtpFechainicial.CustomFormat = "yyyy-MM-dd";
            this.dtpFechainicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechainicial.Location = new System.Drawing.Point(103, 328);
            this.dtpFechainicial.Name = "dtpFechainicial";
            this.dtpFechainicial.Size = new System.Drawing.Size(91, 20);
            this.dtpFechainicial.TabIndex = 136;
            this.dtpFechainicial.ValueChanged += new System.EventHandler(this.dtpFechainicial_ValueChanged);
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFinal.Location = new System.Drawing.Point(103, 354);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(91, 20);
            this.dtpFechaFinal.TabIndex = 137;
            this.dtpFechaFinal.ValueChanged += new System.EventHandler(this.dtpFechaFinal_ValueChanged);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAplicar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnAplicar.Location = new System.Drawing.Point(16, 380);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(178, 28);
            this.btnAplicar.TabIndex = 138;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // btn7Dias
            // 
            this.btn7Dias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7Dias.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btn7Dias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7Dias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7Dias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btn7Dias.Location = new System.Drawing.Point(16, 148);
            this.btn7Dias.Name = "btn7Dias";
            this.btn7Dias.Size = new System.Drawing.Size(178, 28);
            this.btn7Dias.TabIndex = 139;
            this.btn7Dias.Text = "Últimos 7 Dias";
            this.btn7Dias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn7Dias.UseVisualStyleBackColor = true;
            this.btn7Dias.Click += new System.EventHandler(this.btn7Dias_Click);
            // 
            // btnMes
            // 
            this.btnMes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnMes.Location = new System.Drawing.Point(16, 182);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(178, 28);
            this.btnMes.TabIndex = 140;
            this.btnMes.Text = "Este Mes";
            this.btnMes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMes.UseVisualStyleBackColor = true;
            this.btnMes.Click += new System.EventHandler(this.btnMes_Click);
            // 
            // btn30Dias
            // 
            this.btn30Dias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn30Dias.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btn30Dias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn30Dias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn30Dias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btn30Dias.Location = new System.Drawing.Point(16, 216);
            this.btn30Dias.Name = "btn30Dias";
            this.btn30Dias.Size = new System.Drawing.Size(178, 28);
            this.btn30Dias.TabIndex = 141;
            this.btn30Dias.Text = "Últimos 30 Dias";
            this.btn30Dias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn30Dias.UseVisualStyleBackColor = true;
            this.btn30Dias.Click += new System.EventHandler(this.btn30Dias_Click);
            // 
            // btnAño
            // 
            this.btnAño.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAño.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnAño.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAño.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnAño.Location = new System.Drawing.Point(16, 250);
            this.btnAño.Name = "btnAño";
            this.btnAño.Size = new System.Drawing.Size(178, 28);
            this.btnAño.TabIndex = 142;
            this.btnAño.Text = "Este Año";
            this.btnAño.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAño.UseVisualStyleBackColor = true;
            this.btnAño.Click += new System.EventHandler(this.btnAño_Click);
            // 
            // btnCustom
            // 
            this.btnCustom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustom.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnCustom.Location = new System.Drawing.Point(16, 284);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(178, 28);
            this.btnCustom.TabIndex = 143;
            this.btnCustom.Text = "Custom";
            this.btnCustom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(13, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 144;
            this.label3.Text = "Fecha Inicial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(15, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 145;
            this.label4.Text = "Fecha Final:";
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.AllowUserToOrderColumns = true;
            this.dgvResultado.AllowUserToResizeRows = false;
            this.dgvResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.dgvResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResultado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvResultado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(122)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResultado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResultado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            this.dgvResultado.Location = new System.Drawing.Point(214, 85);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.RowHeadersVisible = false;
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(574, 287);
            this.dgvResultado.TabIndex = 146;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnGenerar.Location = new System.Drawing.Point(610, 380);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(178, 28);
            this.btnGenerar.TabIndex = 147;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(331, 20);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 148;
            // 
            // lblTabla
            // 
            this.lblTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabla.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTabla.Location = new System.Drawing.Point(16, 87);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(178, 21);
            this.lblTabla.TabIndex = 156;
            this.lblTabla.Text = "Seleccionar";
            this.lblTabla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTabla.Click += new System.EventHandler(this.lblTabla_Click);
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.Gainsboro;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 17;
            this.lineShape2.X2 = 190;
            this.lineShape2.Y1 = 108;
            this.lineShape2.Y2 = 108;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(800, 418);
            this.shapeContainer1.TabIndex = 157;
            this.shapeContainer1.TabStop = false;
            // 
            // lblFecha1
            // 
            this.lblFecha1.AutoSize = true;
            this.lblFecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha1.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFecha1.Location = new System.Drawing.Point(100, 328);
            this.lblFecha1.MinimumSize = new System.Drawing.Size(101, 0);
            this.lblFecha1.Name = "lblFecha1";
            this.lblFecha1.Size = new System.Drawing.Size(101, 18);
            this.lblFecha1.TabIndex = 158;
            this.lblFecha1.Text = "2023-05-03";
            this.lblFecha1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFecha1.Click += new System.EventHandler(this.lblFecha1_Click);
            // 
            // lblFecha2
            // 
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha2.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFecha2.Location = new System.Drawing.Point(100, 354);
            this.lblFecha2.MinimumSize = new System.Drawing.Size(101, 0);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(101, 18);
            this.lblFecha2.TabIndex = 159;
            this.lblFecha2.Text = "2023-05-03";
            this.lblFecha2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFecha2.Click += new System.EventHandler(this.lblFecha2_Click);
            // 
            // ReporteFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(800, 418);
            this.Controls.Add(this.lblFecha2);
            this.Controls.Add(this.lblFecha1);
            this.Controls.Add(this.lblTabla);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.btnAño);
            this.Controls.Add(this.btn30Dias);
            this.Controls.Add(this.btnMes);
            this.Controls.Add(this.btn7Dias);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.dtpFechainicial);
            this.Controls.Add(this.cbxTablas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnHoy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteFecha";
            this.Text = "Generar Reporte";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHoy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxTablas;
        private System.Windows.Forms.DateTimePicker dtpFechainicial;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btn7Dias;
        private System.Windows.Forms.Button btnMes;
        private System.Windows.Forms.Button btn30Dias;
        private System.Windows.Forms.Button btnAño;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Button btnGenerar;
        public System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblTabla;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label lblFecha1;
        private System.Windows.Forms.Label lblFecha2;
    }
}