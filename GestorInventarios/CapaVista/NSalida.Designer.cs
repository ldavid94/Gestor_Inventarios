
namespace CapaVista
{
    partial class NSalida
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new FontAwesome.Sharp.IconPictureBox();
            this.btnNuevaEntrada = new System.Windows.Forms.Button();
            this.btnRealizarSalida = new System.Windows.Forms.Button();
            this.dgvSalida = new System.Windows.Forms.DataGridView();
            this.cbxSalidas = new System.Windows.Forms.ComboBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.cbxPVenta = new System.Windows.Forms.ComboBox();
            this.cbxPCompra = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxAlmacen = new System.Windows.Forms.ComboBox();
            this.lblAlmacen = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxProducto = new System.Windows.Forms.ComboBox();
            this.lblSProducto = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.ComboBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.cbxIdProducto = new System.Windows.Forms.ComboBox();
            this.cbxIdAlmacen = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(62)))), ((int)(((byte)(87)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 50);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(62)))), ((int)(((byte)(87)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 189;
            this.label2.Text = "Nueva Salida";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(62)))), ((int)(((byte)(87)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.ForeColor = System.Drawing.Color.Blue;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.btnSalir.IconColor = System.Drawing.Color.Blue;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.Location = new System.Drawing.Point(518, 8);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(32, 32);
            this.btnSalir.TabIndex = 190;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevaEntrada
            // 
            this.btnNuevaEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(62)))), ((int)(((byte)(87)))));
            this.btnNuevaEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaEntrada.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnNuevaEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnNuevaEntrada.Location = new System.Drawing.Point(44, 590);
            this.btnNuevaEntrada.Name = "btnNuevaEntrada";
            this.btnNuevaEntrada.Size = new System.Drawing.Size(154, 29);
            this.btnNuevaEntrada.TabIndex = 214;
            this.btnNuevaEntrada.Text = "Nueba Salida";
            this.btnNuevaEntrada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevaEntrada.UseVisualStyleBackColor = false;
            this.btnNuevaEntrada.Click += new System.EventHandler(this.btnNuevaEntrada_Click);
            // 
            // btnRealizarSalida
            // 
            this.btnRealizarSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(62)))), ((int)(((byte)(87)))));
            this.btnRealizarSalida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRealizarSalida.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnRealizarSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnRealizarSalida.Location = new System.Drawing.Point(372, 589);
            this.btnRealizarSalida.Name = "btnRealizarSalida";
            this.btnRealizarSalida.Size = new System.Drawing.Size(154, 29);
            this.btnRealizarSalida.TabIndex = 215;
            this.btnRealizarSalida.Text = "Registrar Salida";
            this.btnRealizarSalida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRealizarSalida.UseVisualStyleBackColor = false;
            this.btnRealizarSalida.Click += new System.EventHandler(this.btnRealizarSalida_Click);
            // 
            // dgvSalida
            // 
            this.dgvSalida.AllowUserToAddRows = false;
            this.dgvSalida.AllowUserToDeleteRows = false;
            this.dgvSalida.AllowUserToOrderColumns = true;
            this.dgvSalida.AllowUserToResizeRows = false;
            this.dgvSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSalida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalida.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.dgvSalida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSalida.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSalida.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(122)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalida.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSalida.EnableHeadersVisualStyles = false;
            this.dgvSalida.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            this.dgvSalida.Location = new System.Drawing.Point(5, 221);
            this.dgvSalida.Name = "dgvSalida";
            this.dgvSalida.ReadOnly = true;
            this.dgvSalida.RowHeadersVisible = false;
            this.dgvSalida.RowTemplate.Height = 35;
            this.dgvSalida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalida.Size = new System.Drawing.Size(558, 363);
            this.dgvSalida.TabIndex = 216;
            // 
            // cbxSalidas
            // 
            this.cbxSalidas.FormattingEnabled = true;
            this.cbxSalidas.Location = new System.Drawing.Point(458, 16);
            this.cbxSalidas.Name = "cbxSalidas";
            this.cbxSalidas.Size = new System.Drawing.Size(60, 21);
            this.cbxSalidas.TabIndex = 218;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(375, 16);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(77, 20);
            this.txtHora.TabIndex = 219;
            // 
            // cbxPVenta
            // 
            this.cbxPVenta.FormattingEnabled = true;
            this.cbxPVenta.Location = new System.Drawing.Point(133, 16);
            this.cbxPVenta.Name = "cbxPVenta";
            this.cbxPVenta.Size = new System.Drawing.Size(68, 21);
            this.cbxPVenta.TabIndex = 220;
            // 
            // cbxPCompra
            // 
            this.cbxPCompra.FormattingEnabled = true;
            this.cbxPCompra.Location = new System.Drawing.Point(210, 15);
            this.cbxPCompra.Name = "cbxPCompra";
            this.cbxPCompra.Size = new System.Drawing.Size(68, 21);
            this.cbxPCompra.TabIndex = 221;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(48)))), ((int)(((byte)(78)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.ForeColor = System.Drawing.Color.Green;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAgregar.IconColor = System.Drawing.Color.Green;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 25;
            this.btnAgregar.Location = new System.Drawing.Point(375, 189);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(25, 26);
            this.btnAgregar.TabIndex = 222;
            this.btnAgregar.TabStop = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(13, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 223;
            this.label3.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(79, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 16);
            this.txtNombre.TabIndex = 224;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(194, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 225;
            this.label5.Text = "Registro:";
            // 
            // txtRegistro
            // 
            this.txtRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.txtRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistro.ForeColor = System.Drawing.Color.White;
            this.txtRegistro.Location = new System.Drawing.Point(262, 80);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(100, 16);
            this.txtRegistro.TabIndex = 226;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(382, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 227;
            this.label4.Text = "Fecha:";
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.ForeColor = System.Drawing.Color.White;
            this.txtFecha.Location = new System.Drawing.Point(437, 80);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 16);
            this.txtFecha.TabIndex = 228;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(13, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 16);
            this.label12.TabIndex = 229;
            this.label12.Text = "Almacen:";
            // 
            // cbxAlmacen
            // 
            this.cbxAlmacen.FormattingEnabled = true;
            this.cbxAlmacen.Location = new System.Drawing.Point(79, 134);
            this.cbxAlmacen.Name = "cbxAlmacen";
            this.cbxAlmacen.Size = new System.Drawing.Size(121, 21);
            this.cbxAlmacen.TabIndex = 230;
            this.cbxAlmacen.SelectedIndexChanged += new System.EventHandler(this.cbxAlmacen_SelectedIndexChanged);
            // 
            // lblAlmacen
            // 
            this.lblAlmacen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.lblAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlmacen.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAlmacen.Location = new System.Drawing.Point(80, 133);
            this.lblAlmacen.Name = "lblAlmacen";
            this.lblAlmacen.Size = new System.Drawing.Size(121, 21);
            this.lblAlmacen.TabIndex = 231;
            this.lblAlmacen.Text = "Seleccionar";
            this.lblAlmacen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAlmacen.Click += new System.EventHandler(this.lblAlmacen_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(213, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 232;
            this.label7.Text = "Producto:";
            // 
            // cbxProducto
            // 
            this.cbxProducto.FormattingEnabled = true;
            this.cbxProducto.Location = new System.Drawing.Point(278, 134);
            this.cbxProducto.Name = "cbxProducto";
            this.cbxProducto.Size = new System.Drawing.Size(259, 21);
            this.cbxProducto.TabIndex = 233;
            this.cbxProducto.SelectedIndexChanged += new System.EventHandler(this.cbxProducto_SelectedIndexChanged);
            // 
            // lblSProducto
            // 
            this.lblSProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.lblSProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSProducto.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSProducto.Location = new System.Drawing.Point(278, 133);
            this.lblSProducto.Name = "lblSProducto";
            this.lblSProducto.Size = new System.Drawing.Size(259, 21);
            this.lblSProducto.TabIndex = 234;
            this.lblSProducto.Text = "Seleccionar";
            this.lblSProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSProducto.Click += new System.EventHandler(this.lblSProducto_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(13, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 235;
            this.label9.Text = "Stock:";
            // 
            // txtStock
            // 
            this.txtStock.FormattingEnabled = true;
            this.txtStock.Location = new System.Drawing.Point(64, 194);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(80, 21);
            this.txtStock.TabIndex = 236;
            this.txtStock.SelectedIndexChanged += new System.EventHandler(this.txtStock_SelectedIndexChanged);
            // 
            // lblStock
            // 
            this.lblStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblStock.Location = new System.Drawing.Point(64, 193);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(80, 21);
            this.lblStock.TabIndex = 237;
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(162, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 238;
            this.label10.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtCantidad.Location = new System.Drawing.Point(230, 193);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(120, 19);
            this.txtCantidad.TabIndex = 239;
            this.txtCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // cbxIdProducto
            // 
            this.cbxIdProducto.FormattingEnabled = true;
            this.cbxIdProducto.Location = new System.Drawing.Point(291, 14);
            this.cbxIdProducto.Name = "cbxIdProducto";
            this.cbxIdProducto.Size = new System.Drawing.Size(59, 21);
            this.cbxIdProducto.TabIndex = 240;
            this.cbxIdProducto.SelectedIndexChanged += new System.EventHandler(this.cbxIdProducto_SelectedIndexChanged);
            // 
            // cbxIdAlmacen
            // 
            this.cbxIdAlmacen.FormattingEnabled = true;
            this.cbxIdAlmacen.Location = new System.Drawing.Point(16, 234);
            this.cbxIdAlmacen.Name = "cbxIdAlmacen";
            this.cbxIdAlmacen.Size = new System.Drawing.Size(63, 21);
            this.cbxIdAlmacen.TabIndex = 241;
            // 
            // NSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(48)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(569, 626);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblSProducto);
            this.Controls.Add(this.cbxProducto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblAlmacen);
            this.Controls.Add(this.cbxAlmacen);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvSalida);
            this.Controls.Add(this.btnRealizarSalida);
            this.Controls.Add(this.btnNuevaEntrada);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxSalidas);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.cbxIdProducto);
            this.Controls.Add(this.cbxPCompra);
            this.Controls.Add(this.cbxPVenta);
            this.Controls.Add(this.cbxIdAlmacen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NSalida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevaSalida";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.NSalida_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox btnSalir;
        private System.Windows.Forms.Button btnNuevaEntrada;
        private System.Windows.Forms.Button btnRealizarSalida;
        private System.Windows.Forms.DataGridView dgvSalida;
        private System.Windows.Forms.ComboBox cbxSalidas;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.ComboBox cbxPVenta;
        private System.Windows.Forms.ComboBox cbxPCompra;
        private FontAwesome.Sharp.IconPictureBox btnAgregar;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxAlmacen;
        private System.Windows.Forms.Label lblAlmacen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxProducto;
        private System.Windows.Forms.Label lblSProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txtStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.ComboBox cbxIdProducto;
        private System.Windows.Forms.ComboBox cbxIdAlmacen;
    }
}