namespace App_Portomadero
{
    partial class fmrListaFacturas
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
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtFecha = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtCliente = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtVendedor = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtNumero = new MaterialSkin.Controls.MaterialRadioButton();
            this.lbInicial = new MaterialSkin.Controls.MaterialLabel();
            this.lbFinal = new MaterialSkin.Controls.MaterialLabel();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.rbtProducto = new MaterialSkin.Controls.MaterialRadioButton();
            this.NumFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFactura
            // 
            this.dgvFactura.AllowUserToAddRows = false;
            this.dgvFactura.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumFactura,
            this.Fecha,
            this.Subtotal,
            this.Vendedor,
            this.Cliente,
            this.Ver,
            this.Borrar});
            this.dgvFactura.Location = new System.Drawing.Point(42, 65);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.ReadOnly = true;
            this.dgvFactura.Size = new System.Drawing.Size(713, 221);
            this.dgvFactura.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 40);
            this.label1.TabIndex = 15;
            this.label1.Text = "Lista de Facturas";
            // 
            // rbtFecha
            // 
            this.rbtFecha.AutoSize = true;
            this.rbtFecha.Depth = 0;
            this.rbtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtFecha.Location = new System.Drawing.Point(118, 333);
            this.rbtFecha.Margin = new System.Windows.Forms.Padding(0);
            this.rbtFecha.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtFecha.Name = "rbtFecha";
            this.rbtFecha.Ripple = true;
            this.rbtFecha.Size = new System.Drawing.Size(66, 30);
            this.rbtFecha.TabIndex = 17;
            this.rbtFecha.TabStop = true;
            this.rbtFecha.Text = "Fecha";
            this.rbtFecha.UseVisualStyleBackColor = true;
            this.rbtFecha.CheckedChanged += new System.EventHandler(this.rbtFecha_CheckedChanged);
            // 
            // rbtCliente
            // 
            this.rbtCliente.AutoSize = true;
            this.rbtCliente.Depth = 0;
            this.rbtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtCliente.Location = new System.Drawing.Point(118, 417);
            this.rbtCliente.Margin = new System.Windows.Forms.Padding(0);
            this.rbtCliente.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtCliente.Name = "rbtCliente";
            this.rbtCliente.Ripple = true;
            this.rbtCliente.Size = new System.Drawing.Size(72, 30);
            this.rbtCliente.TabIndex = 18;
            this.rbtCliente.TabStop = true;
            this.rbtCliente.Text = "Cliente";
            this.rbtCliente.UseVisualStyleBackColor = true;
            this.rbtCliente.CheckedChanged += new System.EventHandler(this.rbtCliente_CheckedChanged);
            // 
            // rbtVendedor
            // 
            this.rbtVendedor.AutoSize = true;
            this.rbtVendedor.Depth = 0;
            this.rbtVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtVendedor.Location = new System.Drawing.Point(118, 377);
            this.rbtVendedor.Margin = new System.Windows.Forms.Padding(0);
            this.rbtVendedor.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtVendedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtVendedor.Name = "rbtVendedor";
            this.rbtVendedor.Ripple = true;
            this.rbtVendedor.Size = new System.Drawing.Size(88, 30);
            this.rbtVendedor.TabIndex = 19;
            this.rbtVendedor.TabStop = true;
            this.rbtVendedor.Text = "Vendedor";
            this.rbtVendedor.UseVisualStyleBackColor = true;
            this.rbtVendedor.CheckedChanged += new System.EventHandler(this.rbtVendedor_CheckedChanged);
            // 
            // rbtNumero
            // 
            this.rbtNumero.AutoSize = true;
            this.rbtNumero.Depth = 0;
            this.rbtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtNumero.Location = new System.Drawing.Point(118, 292);
            this.rbtNumero.Margin = new System.Windows.Forms.Padding(0);
            this.rbtNumero.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtNumero.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtNumero.Name = "rbtNumero";
            this.rbtNumero.Ripple = true;
            this.rbtNumero.Size = new System.Drawing.Size(78, 30);
            this.rbtNumero.TabIndex = 20;
            this.rbtNumero.TabStop = true;
            this.rbtNumero.Text = "Número";
            this.rbtNumero.UseVisualStyleBackColor = true;
            this.rbtNumero.CheckedChanged += new System.EventHandler(this.rbtNumero_CheckedChanged);
            // 
            // lbInicial
            // 
            this.lbInicial.AutoSize = true;
            this.lbInicial.Depth = 0;
            this.lbInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbInicial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbInicial.Location = new System.Drawing.Point(373, 368);
            this.lbInicial.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbInicial.Name = "lbInicial";
            this.lbInicial.Size = new System.Drawing.Size(31, 18);
            this.lbInicial.TabIndex = 22;
            this.lbInicial.Text = "De:";
            this.lbInicial.Visible = false;
            // 
            // lbFinal
            // 
            this.lbFinal.AutoSize = true;
            this.lbFinal.Depth = 0;
            this.lbFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbFinal.Location = new System.Drawing.Point(578, 368);
            this.lbFinal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbFinal.Name = "lbFinal";
            this.lbFinal.Size = new System.Drawing.Size(51, 18);
            this.lbFinal.TabIndex = 23;
            this.lbFinal.Text = "Hasta:";
            this.lbFinal.Visible = false;
            // 
            // dtpInicial
            // 
            this.dtpInicial.Location = new System.Drawing.Point(284, 390);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(200, 20);
            this.dtpInicial.TabIndex = 24;
            this.dtpInicial.Visible = false;
            // 
            // dtpFinal
            // 
            this.dtpFinal.Location = new System.Drawing.Point(502, 390);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpFinal.TabIndex = 25;
            this.dtpFinal.Visible = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "";
            this.txtBuscar.Location = new System.Drawing.Point(275, 368);
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(418, 23);
            this.txtBuscar.TabIndex = 27;
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.Visible = false;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.BackgroundImage = global::App_Portomadero.Properties.Resources.recuperacion_de_datos;
            this.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Location = new System.Drawing.Point(699, 292);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(56, 50);
            this.btnRestaurar.TabIndex = 28;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackgroundImage = global::App_Portomadero.Properties.Resources.busqueda;
            this.btnFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Location = new System.Drawing.Point(467, 427);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(56, 50);
            this.btnFiltrar.TabIndex = 26;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btnSalir.BackgroundImage = global::App_Portomadero.Properties.Resources.cerrar_sesion;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btnSalir.Location = new System.Drawing.Point(744, 447);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(44, 41);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cbProducto
            // 
            this.cbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(349, 368);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(263, 21);
            this.cbProducto.TabIndex = 29;
            this.cbProducto.Visible = false;
            // 
            // rbtProducto
            // 
            this.rbtProducto.AutoSize = true;
            this.rbtProducto.Depth = 0;
            this.rbtProducto.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtProducto.Location = new System.Drawing.Point(118, 460);
            this.rbtProducto.Margin = new System.Windows.Forms.Padding(0);
            this.rbtProducto.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtProducto.Name = "rbtProducto";
            this.rbtProducto.Ripple = true;
            this.rbtProducto.Size = new System.Drawing.Size(85, 30);
            this.rbtProducto.TabIndex = 30;
            this.rbtProducto.TabStop = true;
            this.rbtProducto.Text = "Producto";
            this.rbtProducto.UseVisualStyleBackColor = true;
            this.rbtProducto.CheckedChanged += new System.EventHandler(this.rbtProducto_CheckedChanged);
            // 
            // NumFactura
            // 
            this.NumFactura.HeaderText = "Número";
            this.NumFactura.Name = "NumFactura";
            this.NumFactura.ReadOnly = true;
            this.NumFactura.Width = 70;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 80;
            // 
            // Vendedor
            // 
            this.Vendedor.HeaderText = "Vendedor";
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.ReadOnly = true;
            this.Vendedor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Vendedor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Vendedor.Width = 140;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 140;
            // 
            // Ver
            // 
            this.Ver.HeaderText = "Ver";
            this.Ver.Name = "Ver";
            this.Ver.ReadOnly = true;
            this.Ver.Width = 60;
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Name = "Borrar";
            this.Borrar.ReadOnly = true;
            this.Borrar.Width = 60;
            // 
            // fmrListaFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.rbtProducto);
            this.Controls.Add(this.cbProducto);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.dtpInicial);
            this.Controls.Add(this.lbFinal);
            this.Controls.Add(this.lbInicial);
            this.Controls.Add(this.rbtNumero);
            this.Controls.Add(this.rbtVendedor);
            this.Controls.Add(this.rbtCliente);
            this.Controls.Add(this.rbtFecha);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrListaFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmrListaFacturas";
            this.Load += new System.EventHandler(this.fmrListaFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private MaterialSkin.Controls.MaterialRadioButton rbtFecha;
        private MaterialSkin.Controls.MaterialRadioButton rbtCliente;
        private MaterialSkin.Controls.MaterialRadioButton rbtVendedor;
        private MaterialSkin.Controls.MaterialRadioButton rbtNumero;
        private MaterialSkin.Controls.MaterialLabel lbInicial;
        private MaterialSkin.Controls.MaterialLabel lbFinal;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Button btnFiltrar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.ComboBox cbProducto;
        private MaterialSkin.Controls.MaterialRadioButton rbtProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewButtonColumn Ver;
        private System.Windows.Forms.DataGridViewButtonColumn Borrar;
    }
}