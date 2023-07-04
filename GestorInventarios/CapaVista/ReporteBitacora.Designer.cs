
namespace CapaVista
{
    partial class ReporteBitacora
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTabla = new System.Windows.Forms.Label();
            this.cbxTablas = new System.Windows.Forms.ComboBox();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnHoy = new System.Windows.Forms.Button();
            this.btnMes = new System.Windows.Forms.Button();
            this.btnAño = new System.Windows.Forms.Button();
            this.btnCustom = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFechainicial = new System.Windows.Forms.DateTimePicker();
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.lblFecha1 = new System.Windows.Forms.Label();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxUsuario = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(801, 50);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Generar Reporte";
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(122)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResultado.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvResultado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            this.dgvResultado.Location = new System.Drawing.Point(214, 68);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.RowHeadersVisible = false;
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(574, 274);
            this.dgvResultado.TabIndex = 147;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnGenerar.Location = new System.Drawing.Point(610, 346);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(178, 28);
            this.btnGenerar.TabIndex = 148;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(13, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 149;
            this.label5.Text = "Seleccionar Tabla:";
            // 
            // lblTabla
            // 
            this.lblTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabla.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTabla.Location = new System.Drawing.Point(12, 85);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(178, 21);
            this.lblTabla.TabIndex = 157;
            this.lblTabla.Text = "Seleccionar";
            this.lblTabla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTabla.Click += new System.EventHandler(this.lblTabla_Click);
            // 
            // cbxTablas
            // 
            this.cbxTablas.FormattingEnabled = true;
            this.cbxTablas.Items.AddRange(new object[] {
            "Entradas",
            "Salidas",
            "Login",
            "Compras"});
            this.cbxTablas.Location = new System.Drawing.Point(12, 85);
            this.cbxTablas.Name = "cbxTablas";
            this.cbxTablas.Size = new System.Drawing.Size(178, 21);
            this.cbxTablas.TabIndex = 158;
            this.cbxTablas.SelectedIndexChanged += new System.EventHandler(this.cbxTablas_SelectedIndexChanged);
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.Gainsboro;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 15;
            this.lineShape2.X2 = 188;
            this.lineShape2.Y1 = 106;
            this.lineShape2.Y2 = 106;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(800, 386);
            this.shapeContainer1.TabIndex = 159;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Gainsboro;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 16;
            this.lineShape1.X2 = 189;
            this.lineShape1.Y1 = 152;
            this.lineShape1.Y2 = 152;
            // 
            // btnHoy
            // 
            this.btnHoy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnHoy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnHoy.Location = new System.Drawing.Point(16, 160);
            this.btnHoy.Name = "btnHoy";
            this.btnHoy.Size = new System.Drawing.Size(178, 28);
            this.btnHoy.TabIndex = 160;
            this.btnHoy.Text = "Hoy";
            this.btnHoy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHoy.UseVisualStyleBackColor = true;
            this.btnHoy.Click += new System.EventHandler(this.btnHoy_Click);
            // 
            // btnMes
            // 
            this.btnMes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnMes.Location = new System.Drawing.Point(15, 194);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(178, 28);
            this.btnMes.TabIndex = 161;
            this.btnMes.Text = "Este Mes";
            this.btnMes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMes.UseVisualStyleBackColor = true;
            this.btnMes.Click += new System.EventHandler(this.btnMes_Click);
            // 
            // btnAño
            // 
            this.btnAño.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAño.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnAño.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAño.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnAño.Location = new System.Drawing.Point(15, 228);
            this.btnAño.Name = "btnAño";
            this.btnAño.Size = new System.Drawing.Size(178, 28);
            this.btnAño.TabIndex = 162;
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
            this.btnCustom.Location = new System.Drawing.Point(15, 262);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(178, 28);
            this.btnCustom.TabIndex = 163;
            this.btnCustom.Text = "Custom";
            this.btnCustom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(15, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 165;
            this.label4.Text = "Fecha Final:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(13, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 164;
            this.label3.Text = "Fecha Inicial:";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFinal.Location = new System.Drawing.Point(103, 322);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(91, 20);
            this.dtpFechaFinal.TabIndex = 167;
            this.dtpFechaFinal.ValueChanged += new System.EventHandler(this.dtpFechaFinal_ValueChanged);
            // 
            // dtpFechainicial
            // 
            this.dtpFechainicial.CustomFormat = "yyyy-MM-dd";
            this.dtpFechainicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechainicial.Location = new System.Drawing.Point(103, 296);
            this.dtpFechainicial.Name = "dtpFechainicial";
            this.dtpFechainicial.Size = new System.Drawing.Size(91, 20);
            this.dtpFechainicial.TabIndex = 166;
            this.dtpFechainicial.ValueChanged += new System.EventHandler(this.dtpFechainicial_ValueChanged);
            // 
            // lblFecha2
            // 
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha2.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFecha2.Location = new System.Drawing.Point(100, 322);
            this.lblFecha2.MinimumSize = new System.Drawing.Size(101, 0);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(101, 18);
            this.lblFecha2.TabIndex = 169;
            this.lblFecha2.Text = "2023-05-03";
            this.lblFecha2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFecha2.Click += new System.EventHandler(this.lblFecha2_Click);
            // 
            // lblFecha1
            // 
            this.lblFecha1.AutoSize = true;
            this.lblFecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha1.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFecha1.Location = new System.Drawing.Point(100, 296);
            this.lblFecha1.MinimumSize = new System.Drawing.Size(101, 0);
            this.lblFecha1.Name = "lblFecha1";
            this.lblFecha1.Size = new System.Drawing.Size(101, 18);
            this.lblFecha1.TabIndex = 168;
            this.lblFecha1.Text = "2023-05-03";
            this.lblFecha1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFecha1.Click += new System.EventHandler(this.lblFecha1_Click);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAplicar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnAplicar.Location = new System.Drawing.Point(16, 346);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(178, 28);
            this.btnAplicar.TabIndex = 170;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(185, 15);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(56, 20);
            this.txtUsuario.TabIndex = 171;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(15, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 16);
            this.label6.TabIndex = 172;
            this.label6.Text = "Seleccionar Usuario:";
            // 
            // cbxUsuario
            // 
            this.cbxUsuario.FormattingEnabled = true;
            this.cbxUsuario.Location = new System.Drawing.Point(15, 131);
            this.cbxUsuario.Name = "cbxUsuario";
            this.cbxUsuario.Size = new System.Drawing.Size(178, 21);
            this.cbxUsuario.TabIndex = 173;
            this.cbxUsuario.SelectedIndexChanged += new System.EventHandler(this.cbxUsuario_SelectedIndexChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUsuario.Location = new System.Drawing.Point(15, 131);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(178, 21);
            this.lblUsuario.TabIndex = 174;
            this.lblUsuario.Text = "Seleccionar";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // ReporteBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(800, 386);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.cbxUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.lblFecha2);
            this.Controls.Add(this.lblFecha1);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.dtpFechainicial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.btnAño);
            this.Controls.Add(this.btnMes);
            this.Controls.Add(this.btnHoy);
            this.Controls.Add(this.lblTabla);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTablas);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "ReporteBitacora";
            this.Text = "Reporte Bitacora";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTabla;
        private System.Windows.Forms.ComboBox cbxTablas;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Button btnHoy;
        private System.Windows.Forms.Button btnMes;
        private System.Windows.Forms.Button btnAño;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechainicial;
        private System.Windows.Forms.Label lblFecha2;
        private System.Windows.Forms.Label lblFecha1;
        private System.Windows.Forms.Button btnAplicar;
        public System.Windows.Forms.TextBox txtUsuario;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxUsuario;
        private System.Windows.Forms.Label lblUsuario;
    }
}