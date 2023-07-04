
namespace CapaVista
{
    partial class BuscarInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarInventario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDatoBusqueda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxTipoBusqueda = new System.Windows.Forms.ComboBox();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.txtUsuario15 = new System.Windows.Forms.TextBox();
            this.icoBuscar = new FontAwesome.Sharp.IconButton();
            this.icoBuscarFecha = new FontAwesome.Sharp.IconButton();
            this.lblFecha1 = new System.Windows.Forms.Label();
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.label1.Location = new System.Drawing.Point(-1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1188, 50);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Inventario";
            // 
            // txtFechaFinal
            // 
            this.txtFechaFinal.CustomFormat = "yyyy-MM-dd";
            this.txtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaFinal.Location = new System.Drawing.Point(294, 61);
            this.txtFechaFinal.Name = "txtFechaFinal";
            this.txtFechaFinal.Size = new System.Drawing.Size(97, 20);
            this.txtFechaFinal.TabIndex = 141;
            this.txtFechaFinal.ValueChanged += new System.EventHandler(this.txtFechaFinal_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(218, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 140;
            this.label4.Text = "Fecha Fin:";
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.CustomFormat = "yyyy-MM-dd";
            this.txtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaInicio.Location = new System.Drawing.Point(101, 61);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(97, 20);
            this.txtFechaInicio.TabIndex = 139;
            this.txtFechaInicio.ValueChanged += new System.EventHandler(this.txtFechaInicio_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 138;
            this.label3.Text = "Fecha Inicio:";
            // 
            // txtDatoBusqueda
            // 
            this.txtDatoBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDatoBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.txtDatoBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDatoBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatoBusqueda.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtDatoBusqueda.Location = new System.Drawing.Point(1014, 106);
            this.txtDatoBusqueda.Name = "txtDatoBusqueda";
            this.txtDatoBusqueda.Size = new System.Drawing.Size(121, 17);
            this.txtDatoBusqueda.TabIndex = 145;
            this.txtDatoBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(796, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 144;
            this.label5.Text = "Buscar por:";
            // 
            // cbxTipoBusqueda
            // 
            this.cbxTipoBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTipoBusqueda.FormattingEnabled = true;
            this.cbxTipoBusqueda.Items.AddRange(new object[] {
            "Codigo Producto",
            "Almacen",
            "Categoria"});
            this.cbxTipoBusqueda.Location = new System.Drawing.Point(887, 106);
            this.cbxTipoBusqueda.Name = "cbxTipoBusqueda";
            this.cbxTipoBusqueda.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoBusqueda.TabIndex = 143;
            this.cbxTipoBusqueda.SelectedIndexChanged += new System.EventHandler(this.cbxTipoBusqueda_SelectedIndexChanged);
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToDeleteRows = false;
            this.dgvInventario.AllowUserToOrderColumns = true;
            this.dgvInventario.AllowUserToResizeRows = false;
            this.dgvInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.dgvInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(122)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventario.EnableHeadersVisualStyles = false;
            this.dgvInventario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            this.dgvInventario.Location = new System.Drawing.Point(12, 135);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInventario.RowHeadersVisible = false;
            this.dgvInventario.RowTemplate.Height = 35;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(1163, 423);
            this.dgvInventario.TabIndex = 147;
            this.dgvInventario.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvInventario_CellFormatting);
            // 
            // btnMostrar
            // 
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.DarkGray;
            this.btnMostrar.Location = new System.Drawing.Point(12, 106);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(113, 23);
            this.btnMostrar.TabIndex = 148;
            this.btnMostrar.Text = "Mostar Datos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // txtUsuario15
            // 
            this.txtUsuario15.Location = new System.Drawing.Point(816, 14);
            this.txtUsuario15.Name = "txtUsuario15";
            this.txtUsuario15.Size = new System.Drawing.Size(62, 20);
            this.txtUsuario15.TabIndex = 149;
            // 
            // icoBuscar
            // 
            this.icoBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icoBuscar.FlatAppearance.BorderSize = 0;
            this.icoBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.icoBuscar.IconColor = System.Drawing.Color.Gainsboro;
            this.icoBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBuscar.IconSize = 20;
            this.icoBuscar.Location = new System.Drawing.Point(1141, 105);
            this.icoBuscar.Name = "icoBuscar";
            this.icoBuscar.Size = new System.Drawing.Size(34, 23);
            this.icoBuscar.TabIndex = 150;
            this.icoBuscar.UseVisualStyleBackColor = true;
            this.icoBuscar.Click += new System.EventHandler(this.icoBuscar_Click);
            // 
            // icoBuscarFecha
            // 
            this.icoBuscarFecha.FlatAppearance.BorderSize = 0;
            this.icoBuscarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBuscarFecha.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.icoBuscarFecha.IconColor = System.Drawing.Color.Gainsboro;
            this.icoBuscarFecha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBuscarFecha.IconSize = 20;
            this.icoBuscarFecha.Location = new System.Drawing.Point(397, 58);
            this.icoBuscarFecha.Name = "icoBuscarFecha";
            this.icoBuscarFecha.Size = new System.Drawing.Size(34, 23);
            this.icoBuscarFecha.TabIndex = 151;
            this.icoBuscarFecha.UseVisualStyleBackColor = true;
            this.icoBuscarFecha.Click += new System.EventHandler(this.icoBuscarFecha_Click);
            // 
            // lblFecha1
            // 
            this.lblFecha1.AutoSize = true;
            this.lblFecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha1.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFecha1.Location = new System.Drawing.Point(101, 61);
            this.lblFecha1.MinimumSize = new System.Drawing.Size(101, 0);
            this.lblFecha1.Name = "lblFecha1";
            this.lblFecha1.Size = new System.Drawing.Size(101, 18);
            this.lblFecha1.TabIndex = 153;
            this.lblFecha1.Text = "2023-05-03";
            this.lblFecha1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFecha1.Click += new System.EventHandler(this.lblFecha1_Click);
            // 
            // lblFecha2
            // 
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha2.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFecha2.Location = new System.Drawing.Point(293, 61);
            this.lblFecha2.MinimumSize = new System.Drawing.Size(101, 0);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(101, 18);
            this.lblFecha2.TabIndex = 154;
            this.lblFecha2.Text = "2023-05-03";
            this.lblFecha2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFecha2.Click += new System.EventHandler(this.lblFecha2_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblBuscar.Location = new System.Drawing.Point(887, 105);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(121, 21);
            this.lblBuscar.TabIndex = 156;
            this.lblBuscar.Text = "Seleccionar";
            this.lblBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBuscar.Click += new System.EventHandler(this.lblBuscar_Click);
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape1.BorderColor = System.Drawing.Color.Gainsboro;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 890;
            this.lineShape1.X2 = 1005;
            this.lineShape1.Y1 = 128;
            this.lineShape1.Y2 = 128;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1187, 570);
            this.shapeContainer1.TabIndex = 157;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape2.BorderColor = System.Drawing.Color.Gainsboro;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 1016;
            this.lineShape2.X2 = 1131;
            this.lineShape2.Y1 = 127;
            this.lineShape2.Y2 = 127;
            // 
            // BuscarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1187, 570);
            this.ControlBox = false;
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.lblFecha2);
            this.Controls.Add(this.lblFecha1);
            this.Controls.Add(this.icoBuscarFecha);
            this.Controls.Add(this.icoBuscar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.txtDatoBusqueda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxTipoBusqueda);
            this.Controls.Add(this.txtFechaFinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuario15);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscarInventario";
            this.Text = ".: Inventario :.";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtFechaFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtFechaInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDatoBusqueda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxTipoBusqueda;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Button btnMostrar;
        public System.Windows.Forms.TextBox txtUsuario15;
        private FontAwesome.Sharp.IconButton icoBuscar;
        private FontAwesome.Sharp.IconButton icoBuscarFecha;
        private System.Windows.Forms.Label lblFecha1;
        private System.Windows.Forms.Label lblFecha2;
        private System.Windows.Forms.Label lblBuscar;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
    }
}