namespace App_Portomadero
{
    partial class fmrRecetas
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvIngredientes = new System.Windows.Forms.DataGridView();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lbCosto = new MaterialSkin.Controls.MaterialLabel();
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAñadir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Ingrediente = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lbReceta = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Estado,
            this.Editar});
            this.dgvProductos.Location = new System.Drawing.Point(181, 75);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(441, 162);
            this.dgvProductos.TabIndex = 42;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 250;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Modifica";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 80;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 40);
            this.label1.TabIndex = 43;
            this.label1.Text = "Lista de recetas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btnSalir.BackgroundImage = global::App_Portomadero.Properties.Resources.cerrar_sesion;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btnSalir.Location = new System.Drawing.Point(744, 547);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(44, 41);
            this.btnSalir.TabIndex = 45;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvIngredientes
            // 
            this.dgvIngredientes.AllowUserToAddRows = false;
            this.dgvIngredientes.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ingrediente,
            this.Cantidad,
            this.Unidad,
            this.Subtotal,
            this.Borrar});
            this.dgvIngredientes.Location = new System.Drawing.Point(69, 305);
            this.dgvIngredientes.Name = "dgvIngredientes";
            this.dgvIngredientes.Size = new System.Drawing.Size(659, 162);
            this.dgvIngredientes.TabIndex = 47;
            this.dgvIngredientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngredientes_CellContentClick);
            this.dgvIngredientes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngredientes_CellEndEdit);
            this.dgvIngredientes.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngredientes_CellValueChanged);
            this.dgvIngredientes.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvIngredientes_EditingControlShowing);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(465, 482);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(105, 19);
            this.materialLabel4.TabIndex = 48;
            this.materialLabel4.Text = "Total Costo: $";
            // 
            // lbCosto
            // 
            this.lbCosto.AutoSize = true;
            this.lbCosto.Depth = 0;
            this.lbCosto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbCosto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbCosto.Location = new System.Drawing.Point(576, 482);
            this.lbCosto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbCosto.Name = "lbCosto";
            this.lbCosto.Size = new System.Drawing.Size(13, 19);
            this.lbCosto.TabIndex = 49;
            this.lbCosto.Text = "-";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(69, 552);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(116, 31);
            this.btnGuardar.TabIndex = 50;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Depth = 0;
            this.btnAñadir.Enabled = false;
            this.btnAñadir.Location = new System.Drawing.Point(69, 477);
            this.btnAñadir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Primary = true;
            this.btnAñadir.Size = new System.Drawing.Size(149, 31);
            this.btnAñadir.TabIndex = 51;
            this.btnAñadir.Text = "Añadir Ingrediente";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // Ingrediente
            // 
            this.Ingrediente.HeaderText = "Ingrediente";
            this.Ingrediente.Name = "Ingrediente";
            this.Ingrediente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ingrediente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Ingrediente.Width = 250;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Unidad
            // 
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.Name = "Unidad";
            this.Unidad.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Name = "Borrar";
            this.Borrar.Width = 60;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(81, 283);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(63, 19);
            this.materialLabel1.TabIndex = 52;
            this.materialLabel1.Text = "Receta: ";
            // 
            // lbReceta
            // 
            this.lbReceta.AutoSize = true;
            this.lbReceta.Depth = 0;
            this.lbReceta.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbReceta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbReceta.Location = new System.Drawing.Point(150, 283);
            this.lbReceta.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbReceta.Name = "lbReceta";
            this.lbReceta.Size = new System.Drawing.Size(13, 19);
            this.lbReceta.TabIndex = 53;
            this.lbReceta.Text = "-";
            // 
            // fmrRecetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lbReceta);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lbCosto);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.dgvIngredientes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrRecetas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmrRecetas";
            this.Load += new System.EventHandler(this.fmrRecetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvIngredientes;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel lbCosto;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardar;
        private MaterialSkin.Controls.MaterialRaisedButton btnAñadir;
        private System.Windows.Forms.DataGridViewComboBoxColumn Ingrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewButtonColumn Borrar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lbReceta;
    }
}