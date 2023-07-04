
namespace CapaVista
{
    partial class SolicitudCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolicitudCompra));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtDescripcionProducto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxIdProducto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new FontAwesome.Sharp.IconPictureBox();
            this.btnEliminar = new FontAwesome.Sharp.IconPictureBox();
            this.btnModificar = new FontAwesome.Sharp.IconPictureBox();
            this.btnReporte = new FontAwesome.Sharp.IconButton();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNuevo = new FontAwesome.Sharp.IconButton();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.lblDescripcionProducto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(767, 50);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nueva Solicitud de Compra";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(549, 16);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(58, 20);
            this.txtFecha.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(482, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(20, 13);
            this.textBox2.TabIndex = 41;
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.FormattingEnabled = true;
            this.txtDescripcionProducto.Location = new System.Drawing.Point(208, 85);
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.Size = new System.Drawing.Size(297, 21);
            this.txtDescripcionProducto.TabIndex = 40;
            this.txtDescripcionProducto.SelectedIndexChanged += new System.EventHandler(this.txtDescripcionProducto_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(209, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Descripción Producto:";
            // 
            // cbxIdProducto
            // 
            this.cbxIdProducto.FormattingEnabled = true;
            this.cbxIdProducto.Location = new System.Drawing.Point(95, 86);
            this.cbxIdProducto.Name = "cbxIdProducto";
            this.cbxIdProducto.Size = new System.Drawing.Size(107, 21);
            this.cbxIdProducto.TabIndex = 38;
            this.cbxIdProducto.SelectedIndexChanged += new System.EventHandler(this.cbxIdProducto_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(95, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Id. Producto:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtCantidad.Location = new System.Drawing.Point(511, 85);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(86, 20);
            this.txtCantidad.TabIndex = 42;
            this.txtCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(508, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 43;
            this.label9.Text = "Cantidad:";
            // 
            // dgvCompra
            // 
            this.dgvCompra.AllowUserToAddRows = false;
            this.dgvCompra.AllowUserToDeleteRows = false;
            this.dgvCompra.AllowUserToOrderColumns = true;
            this.dgvCompra.AllowUserToResizeRows = false;
            this.dgvCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.dgvCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(122)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompra.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCompra.EnableHeadersVisualStyles = false;
            this.dgvCompra.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            this.dgvCompra.Location = new System.Drawing.Point(16, 115);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.ReadOnly = true;
            this.dgvCompra.RowHeadersVisible = false;
            this.dgvCompra.RowTemplate.Height = 35;
            this.dgvCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompra.Size = new System.Drawing.Size(736, 370);
            this.dgvCompra.TabIndex = 44;
            this.dgvCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompra_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.ForeColor = System.Drawing.Color.Green;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAgregar.IconColor = System.Drawing.Color.Green;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 25;
            this.btnAgregar.Location = new System.Drawing.Point(603, 81);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(25, 26);
            this.btnAgregar.TabIndex = 45;
            this.btnAgregar.TabStop = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.ForeColor = System.Drawing.Color.Red;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnEliminar.IconColor = System.Drawing.Color.Red;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 25;
            this.btnEliminar.Location = new System.Drawing.Point(666, 81);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(25, 26);
            this.btnEliminar.TabIndex = 46;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.ForeColor = System.Drawing.Color.Yellow;
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnModificar.IconColor = System.Drawing.Color.Yellow;
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificar.IconSize = 25;
            this.btnModificar.Location = new System.Drawing.Point(634, 81);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(25, 26);
            this.btnModificar.TabIndex = 47;
            this.btnModificar.TabStop = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.DarkGray;
            this.btnReporte.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnReporte.IconColor = System.Drawing.Color.DarkGray;
            this.btnReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReporte.IconSize = 20;
            this.btnReporte.Location = new System.Drawing.Point(603, 491);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(145, 31);
            this.btnReporte.TabIndex = 48;
            this.btnReporte.Text = "Generar Solicitud";
            this.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(472, 16);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(71, 20);
            this.txtUsuario.TabIndex = 49;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(613, 16);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(68, 20);
            this.txtHora.TabIndex = 50;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtCodigo.Location = new System.Drawing.Point(14, 87);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(75, 17);
            this.txtCodigo.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(17, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Codigo:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.DarkGray;
            this.btnNuevo.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnNuevo.IconColor = System.Drawing.Color.DarkGray;
            this.btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevo.IconSize = 20;
            this.btnNuevo.Location = new System.Drawing.Point(12, 491);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(190, 31);
            this.btnNuevo.TabIndex = 53;
            this.btnNuevo.Text = "Realizar Nueva Solicitud";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Gainsboro;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 14;
            this.lineShape1.X2 = 87;
            this.lineShape1.Y1 = 107;
            this.lineShape1.Y2 = 107;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(765, 550);
            this.shapeContainer1.TabIndex = 54;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.Gainsboro;
            this.lineShape4.Enabled = false;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 511;
            this.lineShape4.X2 = 595;
            this.lineShape4.Y1 = 106;
            this.lineShape4.Y2 = 106;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.Gainsboro;
            this.lineShape3.Enabled = false;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 208;
            this.lineShape3.X2 = 503;
            this.lineShape3.Y1 = 106;
            this.lineShape3.Y2 = 106;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.Gainsboro;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 96;
            this.lineShape2.X2 = 200;
            this.lineShape2.Y1 = 107;
            this.lineShape2.Y2 = 107;
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProducto.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblIdProducto.Location = new System.Drawing.Point(95, 86);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(107, 21);
            this.lblIdProducto.TabIndex = 156;
            this.lblIdProducto.Text = "Seleccionar";
            this.lblIdProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIdProducto.Click += new System.EventHandler(this.lblIdProducto_Click);
            // 
            // lblDescripcionProducto
            // 
            this.lblDescripcionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionProducto.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDescripcionProducto.Location = new System.Drawing.Point(208, 84);
            this.lblDescripcionProducto.Name = "lblDescripcionProducto";
            this.lblDescripcionProducto.Size = new System.Drawing.Size(297, 21);
            this.lblDescripcionProducto.TabIndex = 157;
            this.lblDescripcionProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SolicitudCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(765, 550);
            this.Controls.Add(this.lblDescripcionProducto);
            this.Controls.Add(this.lblIdProducto);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvCompra);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtDescripcionProducto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxIdProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SolicitudCompra";
            this.Text = "Solicitud de Compra";
            this.Load += new System.EventHandler(this.SolicitudCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox txtDescripcionProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxIdProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvCompra;
        private FontAwesome.Sharp.IconPictureBox btnAgregar;
        private FontAwesome.Sharp.IconPictureBox btnEliminar;
        private FontAwesome.Sharp.IconPictureBox btnModificar;
        private FontAwesome.Sharp.IconButton btnReporte;
        private System.Windows.Forms.TextBox txtHora;
        public System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.Label lblDescripcionProducto;
    }
}