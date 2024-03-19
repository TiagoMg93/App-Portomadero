namespace App_Portomadero
{
    partial class fmrListaProductos
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
            this.rbtCategoria = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtNombre = new MaterialSkin.Controls.MaterialRadioButton();
            this.cbBusqueda = new System.Windows.Forms.ComboBox();
            this.txtBusqueda = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stoke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtCategoria
            // 
            this.rbtCategoria.AutoSize = true;
            this.rbtCategoria.Depth = 0;
            this.rbtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtCategoria.Location = new System.Drawing.Point(143, 372);
            this.rbtCategoria.Margin = new System.Windows.Forms.Padding(0);
            this.rbtCategoria.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtCategoria.Name = "rbtCategoria";
            this.rbtCategoria.Ripple = true;
            this.rbtCategoria.Size = new System.Drawing.Size(89, 30);
            this.rbtCategoria.TabIndex = 45;
            this.rbtCategoria.TabStop = true;
            this.rbtCategoria.Text = "Categoria";
            this.rbtCategoria.UseVisualStyleBackColor = true;
            this.rbtCategoria.CheckedChanged += new System.EventHandler(this.rbtCategoria_CheckedChanged);
            // 
            // rbtNombre
            // 
            this.rbtNombre.AutoSize = true;
            this.rbtNombre.Depth = 0;
            this.rbtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtNombre.Location = new System.Drawing.Point(143, 415);
            this.rbtNombre.Margin = new System.Windows.Forms.Padding(0);
            this.rbtNombre.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtNombre.Name = "rbtNombre";
            this.rbtNombre.Ripple = true;
            this.rbtNombre.Size = new System.Drawing.Size(78, 30);
            this.rbtNombre.TabIndex = 43;
            this.rbtNombre.TabStop = true;
            this.rbtNombre.Text = "Nombre";
            this.rbtNombre.UseVisualStyleBackColor = true;
            this.rbtNombre.CheckedChanged += new System.EventHandler(this.rbtNombre_CheckedChanged);
            // 
            // cbBusqueda
            // 
            this.cbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBusqueda.FormattingEnabled = true;
            this.cbBusqueda.Location = new System.Drawing.Point(325, 402);
            this.cbBusqueda.Name = "cbBusqueda";
            this.cbBusqueda.Size = new System.Drawing.Size(263, 21);
            this.cbBusqueda.TabIndex = 41;
            this.cbBusqueda.Visible = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Depth = 0;
            this.txtBusqueda.Hint = "Escribe el nombre del producto";
            this.txtBusqueda.Location = new System.Drawing.Point(335, 400);
            this.txtBusqueda.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.PasswordChar = '\0';
            this.txtBusqueda.SelectedText = "";
            this.txtBusqueda.SelectionLength = 0;
            this.txtBusqueda.SelectionStart = 0;
            this.txtBusqueda.Size = new System.Drawing.Size(238, 23);
            this.txtBusqueda.TabIndex = 39;
            this.txtBusqueda.UseSystemPasswordChar = false;
            this.txtBusqueda.Visible = false;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Categoria,
            this.Costo,
            this.Precio,
            this.Stoke,
            this.Ver});
            this.dgvProductos.Location = new System.Drawing.Point(36, 91);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(727, 221);
            this.dgvProductos.TabIndex = 36;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 40);
            this.label1.TabIndex = 47;
            this.label1.Text = "Lista de productos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.BackgroundImage = global::App_Portomadero.Properties.Resources.recuperacion_de_datos;
            this.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Location = new System.Drawing.Point(707, 318);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(56, 50);
            this.btnRestaurar.TabIndex = 46;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackgroundImage = global::App_Portomadero.Properties.Resources.busqueda;
            this.btnFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Location = new System.Drawing.Point(424, 429);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(56, 50);
            this.btnFiltrar.TabIndex = 40;
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
            this.btnSalir.TabIndex = 37;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 250;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            this.Costo.Width = 70;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 70;
            // 
            // Stoke
            // 
            this.Stoke.HeaderText = "Stoke";
            this.Stoke.Name = "Stoke";
            this.Stoke.ReadOnly = true;
            this.Stoke.Width = 70;
            // 
            // Ver
            // 
            this.Ver.HeaderText = "Editar";
            this.Ver.Name = "Ver";
            this.Ver.ReadOnly = true;
            this.Ver.Width = 60;
            // 
            // fmrListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.rbtCategoria);
            this.Controls.Add(this.rbtNombre);
            this.Controls.Add(this.cbBusqueda);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrListaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmrListaProductos";
            this.Load += new System.EventHandler(this.fmrListaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRestaurar;
        private MaterialSkin.Controls.MaterialRadioButton rbtCategoria;
        private MaterialSkin.Controls.MaterialRadioButton rbtNombre;
        private System.Windows.Forms.ComboBox cbBusqueda;
        private System.Windows.Forms.Button btnFiltrar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBusqueda;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stoke;
        private System.Windows.Forms.DataGridViewButtonColumn Ver;
    }
}