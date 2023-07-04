
namespace CapaVista
{
    partial class NEntrada
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxIdProveedores = new System.Windows.Forms.ComboBox();
            this.txtStock = new System.Windows.Forms.ComboBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.cbxIdProducto = new System.Windows.Forms.ComboBox();
            this.txtEntrada = new System.Windows.Forms.ComboBox();
            this.btnSalir = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxAlmacen = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxProveedor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblISProveedor = new System.Windows.Forms.Label();
            this.lblAlmacen = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxProducto = new System.Windows.Forms.ComboBox();
            this.lblSProducto = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.btnAgregar = new FontAwesome.Sharp.IconPictureBox();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvEntrada = new System.Windows.Forms.DataGridView();
            this.btnNuevaEntrada = new System.Windows.Forms.Button();
            this.btnRealizarEntrada = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrada)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(62)))), ((int)(((byte)(87)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 50);
            this.label1.TabIndex = 5;
            // 
            // cbxIdProveedores
            // 
            this.cbxIdProveedores.FormattingEnabled = true;
            this.cbxIdProveedores.Location = new System.Drawing.Point(145, 12);
            this.cbxIdProveedores.Name = "cbxIdProveedores";
            this.cbxIdProveedores.Size = new System.Drawing.Size(74, 21);
            this.cbxIdProveedores.TabIndex = 182;
            // 
            // txtStock
            // 
            this.txtStock.FormattingEnabled = true;
            this.txtStock.Location = new System.Drawing.Point(225, 12);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(57, 21);
            this.txtStock.TabIndex = 183;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(288, 13);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(62, 20);
            this.txtHora.TabIndex = 184;
            // 
            // cbxIdProducto
            // 
            this.cbxIdProducto.FormattingEnabled = true;
            this.cbxIdProducto.Location = new System.Drawing.Point(356, 13);
            this.cbxIdProducto.Name = "cbxIdProducto";
            this.cbxIdProducto.Size = new System.Drawing.Size(59, 21);
            this.cbxIdProducto.TabIndex = 185;
            this.cbxIdProducto.SelectedIndexChanged += new System.EventHandler(this.cbxIdProducto_SelectedIndexChanged);
            // 
            // txtEntrada
            // 
            this.txtEntrada.FormattingEnabled = true;
            this.txtEntrada.Location = new System.Drawing.Point(421, 13);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(68, 21);
            this.txtEntrada.TabIndex = 186;
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
            this.btnSalir.Location = new System.Drawing.Point(520, 8);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(32, 32);
            this.btnSalir.TabIndex = 187;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(62)))), ((int)(((byte)(87)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(8, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 188;
            this.label2.Text = "Nueva Entrada";
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.ForeColor = System.Drawing.Color.White;
            this.txtFecha.Location = new System.Drawing.Point(439, 83);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 16);
            this.txtFecha.TabIndex = 194;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(198, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 193;
            this.label5.Text = "Registro:";
            // 
            // txtRegistro
            // 
            this.txtRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.txtRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistro.ForeColor = System.Drawing.Color.White;
            this.txtRegistro.Location = new System.Drawing.Point(269, 83);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(100, 16);
            this.txtRegistro.TabIndex = 192;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(384, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 191;
            this.label4.Text = "Fecha:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(82, 82);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 16);
            this.txtNombre.TabIndex = 190;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(16, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 189;
            this.label3.Text = "Nombre:";
            // 
            // cbxAlmacen
            // 
            this.cbxAlmacen.FormattingEnabled = true;
            this.cbxAlmacen.Location = new System.Drawing.Point(419, 140);
            this.cbxAlmacen.Name = "cbxAlmacen";
            this.cbxAlmacen.Size = new System.Drawing.Size(121, 21);
            this.cbxAlmacen.TabIndex = 198;
            this.cbxAlmacen.SelectedIndexChanged += new System.EventHandler(this.cbxAlmacen_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(348, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 16);
            this.label12.TabIndex = 197;
            this.label12.Text = "Almacen:";
            // 
            // cbxProveedor
            // 
            this.cbxProveedor.FormattingEnabled = true;
            this.cbxProveedor.Location = new System.Drawing.Point(98, 140);
            this.cbxProveedor.Name = "cbxProveedor";
            this.cbxProveedor.Size = new System.Drawing.Size(234, 21);
            this.cbxProveedor.TabIndex = 196;
            this.cbxProveedor.SelectedIndexChanged += new System.EventHandler(this.cbxProveedor_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(17, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 195;
            this.label6.Text = "Proveedor:";
            // 
            // lblISProveedor
            // 
            this.lblISProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.lblISProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISProveedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblISProveedor.Location = new System.Drawing.Point(98, 140);
            this.lblISProveedor.Name = "lblISProveedor";
            this.lblISProveedor.Size = new System.Drawing.Size(234, 21);
            this.lblISProveedor.TabIndex = 199;
            this.lblISProveedor.Text = "Seleccionar";
            this.lblISProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblISProveedor.Click += new System.EventHandler(this.lblISProveedor_Click);
            // 
            // lblAlmacen
            // 
            this.lblAlmacen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.lblAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlmacen.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAlmacen.Location = new System.Drawing.Point(419, 140);
            this.lblAlmacen.Name = "lblAlmacen";
            this.lblAlmacen.Size = new System.Drawing.Size(121, 21);
            this.lblAlmacen.TabIndex = 200;
            this.lblAlmacen.Text = "Seleccionar";
            this.lblAlmacen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAlmacen.Click += new System.EventHandler(this.lblAlmacen_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(17, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 201;
            this.label7.Text = "Producto:";
            // 
            // cbxProducto
            // 
            this.cbxProducto.FormattingEnabled = true;
            this.cbxProducto.Location = new System.Drawing.Point(98, 198);
            this.cbxProducto.Name = "cbxProducto";
            this.cbxProducto.Size = new System.Drawing.Size(234, 21);
            this.cbxProducto.TabIndex = 202;
            this.cbxProducto.SelectedIndexChanged += new System.EventHandler(this.cbxProducto_SelectedIndexChanged);
            // 
            // lblSProducto
            // 
            this.lblSProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.lblSProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSProducto.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSProducto.Location = new System.Drawing.Point(98, 198);
            this.lblSProducto.Name = "lblSProducto";
            this.lblSProducto.Size = new System.Drawing.Size(234, 21);
            this.lblSProducto.TabIndex = 203;
            this.lblSProducto.Text = "Seleccionar";
            this.lblSProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSProducto.Click += new System.EventHandler(this.lblSProducto_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(338, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 204;
            this.label8.Text = "Precio Compra:";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.txtPrecioCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCompra.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtPrecioCompra.Location = new System.Drawing.Point(439, 203);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(100, 16);
            this.txtPrecioCompra.TabIndex = 205;
            this.txtPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCompra_KeyPress);
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
            this.btnAgregar.Location = new System.Drawing.Point(451, 244);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(25, 26);
            this.btnAgregar.TabIndex = 210;
            this.btnAgregar.TabStop = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtCantidad.Location = new System.Drawing.Point(307, 250);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(120, 19);
            this.txtCantidad.TabIndex = 209;
            this.txtCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(236, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 208;
            this.label10.Text = "Cantidad:";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtPrecioVenta.Location = new System.Drawing.Point(112, 251);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(100, 16);
            this.txtPrecioVenta.TabIndex = 207;
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(18, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 206;
            this.label9.Text = "Precio Venta:";
            // 
            // dgvEntrada
            // 
            this.dgvEntrada.AllowUserToAddRows = false;
            this.dgvEntrada.AllowUserToDeleteRows = false;
            this.dgvEntrada.AllowUserToOrderColumns = true;
            this.dgvEntrada.AllowUserToResizeRows = false;
            this.dgvEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEntrada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEntrada.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.dgvEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEntrada.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEntrada.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntrada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(122)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEntrada.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEntrada.EnableHeadersVisualStyles = false;
            this.dgvEntrada.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            this.dgvEntrada.Location = new System.Drawing.Point(3, 276);
            this.dgvEntrada.Name = "dgvEntrada";
            this.dgvEntrada.ReadOnly = true;
            this.dgvEntrada.RowHeadersVisible = false;
            this.dgvEntrada.RowTemplate.Height = 35;
            this.dgvEntrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntrada.Size = new System.Drawing.Size(558, 309);
            this.dgvEntrada.TabIndex = 211;
            // 
            // btnNuevaEntrada
            // 
            this.btnNuevaEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(62)))), ((int)(((byte)(87)))));
            this.btnNuevaEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaEntrada.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnNuevaEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnNuevaEntrada.Location = new System.Drawing.Point(31, 591);
            this.btnNuevaEntrada.Name = "btnNuevaEntrada";
            this.btnNuevaEntrada.Size = new System.Drawing.Size(154, 29);
            this.btnNuevaEntrada.TabIndex = 213;
            this.btnNuevaEntrada.Text = "Nueba Entrada";
            this.btnNuevaEntrada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevaEntrada.UseVisualStyleBackColor = false;
            this.btnNuevaEntrada.Click += new System.EventHandler(this.btnNuevaEntrada_Click);
            // 
            // btnRealizarEntrada
            // 
            this.btnRealizarEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(62)))), ((int)(((byte)(87)))));
            this.btnRealizarEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRealizarEntrada.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnRealizarEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnRealizarEntrada.Location = new System.Drawing.Point(372, 591);
            this.btnRealizarEntrada.Name = "btnRealizarEntrada";
            this.btnRealizarEntrada.Size = new System.Drawing.Size(154, 29);
            this.btnRealizarEntrada.TabIndex = 212;
            this.btnRealizarEntrada.Text = "Registrar Entrada";
            this.btnRealizarEntrada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRealizarEntrada.UseVisualStyleBackColor = false;
            this.btnRealizarEntrada.Click += new System.EventHandler(this.btnRealizarEntrada_Click);
            // 
            // NEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(48)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(569, 626);
            this.Controls.Add(this.btnNuevaEntrada);
            this.Controls.Add(this.btnRealizarEntrada);
            this.Controls.Add(this.dgvEntrada);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblSProducto);
            this.Controls.Add(this.cbxProducto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblAlmacen);
            this.Controls.Add(this.lblISProveedor);
            this.Controls.Add(this.cbxAlmacen);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbxProveedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.cbxIdProducto);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.cbxIdProveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NEntrada";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.NEntrada_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxIdProveedores;
        private System.Windows.Forms.ComboBox txtStock;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.ComboBox cbxIdProducto;
        private System.Windows.Forms.ComboBox txtEntrada;
        private FontAwesome.Sharp.IconPictureBox btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxAlmacen;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxProveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblISProveedor;
        private System.Windows.Forms.Label lblAlmacen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxProducto;
        private System.Windows.Forms.Label lblSProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private FontAwesome.Sharp.IconPictureBox btnAgregar;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvEntrada;
        private System.Windows.Forms.Button btnNuevaEntrada;
        private System.Windows.Forms.Button btnRealizarEntrada;
    }
}