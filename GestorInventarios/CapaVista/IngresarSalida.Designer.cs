
namespace CapaVista
{
    partial class IngresarSalida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresarSalida));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dvgSalida = new System.Windows.Forms.DataGridView();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.cbxSalidas = new System.Windows.Forms.ComboBox();
            this.txtUsuario3 = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.cbxPVenta = new System.Windows.Forms.ComboBox();
            this.cbxPCompra = new System.Windows.Forms.ComboBox();
            this.btnNuevo = new FontAwesome.Sharp.IconButton();
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dvgSalida)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.label1.Location = new System.Drawing.Point(-1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(763, 50);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(10, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nueva Salida";
            // 
            // dvgSalida
            // 
            this.dvgSalida.AllowUserToAddRows = false;
            this.dvgSalida.AllowUserToDeleteRows = false;
            this.dvgSalida.AllowUserToOrderColumns = true;
            this.dvgSalida.AllowUserToResizeRows = false;
            this.dvgSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgSalida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgSalida.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.dvgSalida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgSalida.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvgSalida.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgSalida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(122)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgSalida.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvgSalida.EnableHeadersVisualStyles = false;
            this.dvgSalida.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            this.dvgSalida.Location = new System.Drawing.Point(14, 87);
            this.dvgSalida.Name = "dvgSalida";
            this.dvgSalida.ReadOnly = true;
            this.dvgSalida.RowHeadersVisible = false;
            this.dvgSalida.RowTemplate.Height = 35;
            this.dvgSalida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgSalida.Size = new System.Drawing.Size(736, 447);
            this.dvgSalida.TabIndex = 19;
            this.dvgSalida.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgSalida_CellContentClick);
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFecha.Location = new System.Drawing.Point(365, 17);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(85, 13);
            this.txtFecha.TabIndex = 21;
            // 
            // cbxSalidas
            // 
            this.cbxSalidas.FormattingEnabled = true;
            this.cbxSalidas.Location = new System.Drawing.Point(539, 14);
            this.cbxSalidas.Name = "cbxSalidas";
            this.cbxSalidas.Size = new System.Drawing.Size(60, 21);
            this.cbxSalidas.TabIndex = 28;
            // 
            // txtUsuario3
            // 
            this.txtUsuario3.Location = new System.Drawing.Point(605, 14);
            this.txtUsuario3.Name = "txtUsuario3";
            this.txtUsuario3.Size = new System.Drawing.Size(77, 20);
            this.txtUsuario3.TabIndex = 29;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(456, 14);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(77, 20);
            this.txtHora.TabIndex = 30;
            // 
            // cbxPVenta
            // 
            this.cbxPVenta.FormattingEnabled = true;
            this.cbxPVenta.Location = new System.Drawing.Point(214, 14);
            this.cbxPVenta.Name = "cbxPVenta";
            this.cbxPVenta.Size = new System.Drawing.Size(68, 21);
            this.cbxPVenta.TabIndex = 31;
            // 
            // cbxPCompra
            // 
            this.cbxPCompra.FormattingEnabled = true;
            this.cbxPCompra.Location = new System.Drawing.Point(291, 13);
            this.cbxPCompra.Name = "cbxPCompra";
            this.cbxPCompra.Size = new System.Drawing.Size(68, 21);
            this.cbxPCompra.TabIndex = 32;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnNuevo.IconColor = System.Drawing.Color.White;
            this.btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevo.IconSize = 20;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(644, 58);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(109, 23);
            this.btnNuevo.TabIndex = 165;
            this.btnNuevo.Text = "Nueva Entrada";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.IconChar = FontAwesome.Sharp.IconChar.ArrowRightRotate;
            this.btnActualizar.IconColor = System.Drawing.Color.White;
            this.btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizar.IconSize = 20;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(14, 58);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(80, 23);
            this.btnActualizar.TabIndex = 166;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // IngresarSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(765, 546);
            this.ControlBox = false;
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dvgSalida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxSalidas);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtUsuario3);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.cbxPVenta);
            this.Controls.Add(this.cbxPCompra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IngresarSalida";
            this.Text = ".: Ingresar Salida :.";
            ((System.ComponentModel.ISupportInitialize)(this.dvgSalida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dvgSalida;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.ComboBox cbxSalidas;
        private System.Windows.Forms.TextBox txtHora;
        public System.Windows.Forms.TextBox txtUsuario3;
        private System.Windows.Forms.ComboBox cbxPVenta;
        private System.Windows.Forms.ComboBox cbxPCompra;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnActualizar;
    }
}