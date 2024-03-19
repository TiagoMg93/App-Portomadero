namespace App_Portomadero
{
    partial class fmrListaPedidos
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
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.NumFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mesero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Terminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFiltrar = new System.Windows.Forms.ComboBox();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.rbtMesero = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtEstado = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtMesa = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumFactura,
            this.Mesero,
            this.Mesa,
            this.Estado,
            this.Pago,
            this.Terminar,
            this.Ver,
            this.Borrar});
            this.dgvPedidos.Location = new System.Drawing.Point(102, 78);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.Size = new System.Drawing.Size(579, 144);
            this.dgvPedidos.TabIndex = 15;
            this.dgvPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellContentClick);
            // 
            // NumFactura
            // 
            this.NumFactura.HeaderText = "ID";
            this.NumFactura.Name = "NumFactura";
            this.NumFactura.ReadOnly = true;
            this.NumFactura.Width = 70;
            // 
            // Mesero
            // 
            this.Mesero.HeaderText = "Mesero";
            this.Mesero.Name = "Mesero";
            this.Mesero.ReadOnly = true;
            // 
            // Mesa
            // 
            this.Mesa.HeaderText = "Mesa";
            this.Mesa.Name = "Mesa";
            this.Mesa.ReadOnly = true;
            this.Mesa.Width = 50;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Estado.Width = 80;
            // 
            // Pago
            // 
            this.Pago.HeaderText = "Pago";
            this.Pago.Name = "Pago";
            this.Pago.ReadOnly = true;
            this.Pago.Width = 50;
            // 
            // Terminar
            // 
            this.Terminar.HeaderText = "Terminar";
            this.Terminar.Name = "Terminar";
            this.Terminar.ReadOnly = true;
            this.Terminar.Width = 60;
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
            this.Borrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Borrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Borrar.Width = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 40);
            this.label1.TabIndex = 16;
            this.label1.Text = "Lista de Pedidos";
            // 
            // cbFiltrar
            // 
            this.cbFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltrar.Enabled = false;
            this.cbFiltrar.FormattingEnabled = true;
            this.cbFiltrar.Location = new System.Drawing.Point(307, 317);
            this.cbFiltrar.Name = "cbFiltrar";
            this.cbFiltrar.Size = new System.Drawing.Size(263, 21);
            this.cbFiltrar.TabIndex = 43;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.BackgroundImage = global::App_Portomadero.Properties.Resources.recuperacion_de_datos;
            this.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Location = new System.Drawing.Point(625, 228);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(56, 50);
            this.btnRestaurar.TabIndex = 42;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackgroundImage = global::App_Portomadero.Properties.Resources.busqueda;
            this.btnFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Location = new System.Drawing.Point(408, 350);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(56, 50);
            this.btnFiltrar.TabIndex = 40;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // rbtMesero
            // 
            this.rbtMesero.AutoSize = true;
            this.rbtMesero.Depth = 0;
            this.rbtMesero.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtMesero.Location = new System.Drawing.Point(127, 276);
            this.rbtMesero.Margin = new System.Windows.Forms.Padding(0);
            this.rbtMesero.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtMesero.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtMesero.Name = "rbtMesero";
            this.rbtMesero.Ripple = true;
            this.rbtMesero.Size = new System.Drawing.Size(75, 30);
            this.rbtMesero.TabIndex = 35;
            this.rbtMesero.TabStop = true;
            this.rbtMesero.Text = "Mesero";
            this.rbtMesero.UseVisualStyleBackColor = true;
            this.rbtMesero.CheckedChanged += new System.EventHandler(this.rbtMesero_CheckedChanged);
            // 
            // rbtEstado
            // 
            this.rbtEstado.AutoSize = true;
            this.rbtEstado.Depth = 0;
            this.rbtEstado.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtEstado.Location = new System.Drawing.Point(127, 361);
            this.rbtEstado.Margin = new System.Windows.Forms.Padding(0);
            this.rbtEstado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtEstado.Name = "rbtEstado";
            this.rbtEstado.Ripple = true;
            this.rbtEstado.Size = new System.Drawing.Size(71, 30);
            this.rbtEstado.TabIndex = 34;
            this.rbtEstado.TabStop = true;
            this.rbtEstado.Text = "Estado";
            this.rbtEstado.UseVisualStyleBackColor = true;
            this.rbtEstado.CheckedChanged += new System.EventHandler(this.rbtEstado_CheckedChanged);
            // 
            // rbtMesa
            // 
            this.rbtMesa.AutoSize = true;
            this.rbtMesa.Depth = 0;
            this.rbtMesa.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtMesa.Location = new System.Drawing.Point(127, 317);
            this.rbtMesa.Margin = new System.Windows.Forms.Padding(0);
            this.rbtMesa.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtMesa.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtMesa.Name = "rbtMesa";
            this.rbtMesa.Ripple = true;
            this.rbtMesa.Size = new System.Drawing.Size(63, 30);
            this.rbtMesa.TabIndex = 32;
            this.rbtMesa.TabStop = true;
            this.rbtMesa.Text = "Mesa";
            this.rbtMesa.UseVisualStyleBackColor = true;
            this.rbtMesa.CheckedChanged += new System.EventHandler(this.rbtMesa_CheckedChanged);
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
            this.btnSalir.TabIndex = 31;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // fmrListaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.cbFiltrar);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.rbtMesero);
            this.Controls.Add(this.rbtEstado);
            this.Controls.Add(this.rbtMesa);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrListaPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmrListaPedidos";
            this.Load += new System.EventHandler(this.fmrListaPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFiltrar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnFiltrar;
        private MaterialSkin.Controls.MaterialRadioButton rbtMesero;
        private MaterialSkin.Controls.MaterialRadioButton rbtEstado;
        private MaterialSkin.Controls.MaterialRadioButton rbtMesa;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mesero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pago;
        private System.Windows.Forms.DataGridViewButtonColumn Terminar;
        private System.Windows.Forms.DataGridViewButtonColumn Ver;
        private System.Windows.Forms.DataGridViewButtonColumn Borrar;
    }
}