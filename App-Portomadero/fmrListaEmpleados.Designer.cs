namespace App_Portomadero
{
    partial class fmrListaEmpleados
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBusqueda = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cbBusqueda = new System.Windows.Forms.ComboBox();
            this.rbtID = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtEstado = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtNombre = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtCargo = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnRestaurar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(579, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 40);
            this.label1.TabIndex = 16;
            this.label1.Text = "Empleados";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Edad,
            this.Cargo,
            this.Estado,
            this.Ver,
            this.Borrar});
            this.dgvEmpleados.Location = new System.Drawing.Point(12, 191);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.Size = new System.Drawing.Size(746, 221);
            this.dgvEmpleados.TabIndex = 17;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFactura_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 80;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 250;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            this.Edad.Width = 50;
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            this.Cargo.Width = 120;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 80;
            // 
            // Ver
            // 
            this.Ver.HeaderText = "Editar";
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
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btnNuevo.BackgroundImage = global::App_Portomadero.Properties.Resources.agregar_usuario;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btnNuevo.Location = new System.Drawing.Point(623, 414);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(73, 59);
            this.btnNuevo.TabIndex = 19;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.button1_Click);
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
            this.btnSalir.TabIndex = 18;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App_Portomadero.Properties.Resources.empleados;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(561, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Depth = 0;
            this.txtBusqueda.Hint = "Escribe el número del documento";
            this.txtBusqueda.Location = new System.Drawing.Point(298, 509);
            this.txtBusqueda.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.PasswordChar = '\0';
            this.txtBusqueda.SelectedText = "";
            this.txtBusqueda.SelectionLength = 0;
            this.txtBusqueda.SelectionStart = 0;
            this.txtBusqueda.Size = new System.Drawing.Size(238, 23);
            this.txtBusqueda.TabIndex = 28;
            this.txtBusqueda.UseSystemPasswordChar = false;
            this.txtBusqueda.Visible = false;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackgroundImage = global::App_Portomadero.Properties.Resources.busqueda;
            this.btnFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Location = new System.Drawing.Point(387, 538);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(56, 50);
            this.btnFiltrar.TabIndex = 29;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cbBusqueda
            // 
            this.cbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBusqueda.FormattingEnabled = true;
            this.cbBusqueda.Location = new System.Drawing.Point(288, 511);
            this.cbBusqueda.Name = "cbBusqueda";
            this.cbBusqueda.Size = new System.Drawing.Size(263, 21);
            this.cbBusqueda.TabIndex = 30;
            this.cbBusqueda.Visible = false;
            // 
            // rbtID
            // 
            this.rbtID.AutoSize = true;
            this.rbtID.Depth = 0;
            this.rbtID.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtID.Location = new System.Drawing.Point(97, 432);
            this.rbtID.Margin = new System.Windows.Forms.Padding(0);
            this.rbtID.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtID.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtID.Name = "rbtID";
            this.rbtID.Ripple = true;
            this.rbtID.Size = new System.Drawing.Size(100, 30);
            this.rbtID.TabIndex = 34;
            this.rbtID.TabStop = true;
            this.rbtID.Text = "Documento";
            this.rbtID.UseVisualStyleBackColor = true;
            this.rbtID.CheckedChanged += new System.EventHandler(this.rbtID_CheckedChanged);
            // 
            // rbtEstado
            // 
            this.rbtEstado.AutoSize = true;
            this.rbtEstado.Depth = 0;
            this.rbtEstado.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtEstado.Location = new System.Drawing.Point(97, 548);
            this.rbtEstado.Margin = new System.Windows.Forms.Padding(0);
            this.rbtEstado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtEstado.Name = "rbtEstado";
            this.rbtEstado.Ripple = true;
            this.rbtEstado.Size = new System.Drawing.Size(71, 30);
            this.rbtEstado.TabIndex = 33;
            this.rbtEstado.TabStop = true;
            this.rbtEstado.Text = "Estado";
            this.rbtEstado.UseVisualStyleBackColor = true;
            this.rbtEstado.CheckedChanged += new System.EventHandler(this.rbtEstado_CheckedChanged);
            // 
            // rbtNombre
            // 
            this.rbtNombre.AutoSize = true;
            this.rbtNombre.Depth = 0;
            this.rbtNombre.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtNombre.Location = new System.Drawing.Point(97, 475);
            this.rbtNombre.Margin = new System.Windows.Forms.Padding(0);
            this.rbtNombre.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtNombre.Name = "rbtNombre";
            this.rbtNombre.Ripple = true;
            this.rbtNombre.Size = new System.Drawing.Size(78, 30);
            this.rbtNombre.TabIndex = 32;
            this.rbtNombre.TabStop = true;
            this.rbtNombre.Text = "Nombre";
            this.rbtNombre.UseVisualStyleBackColor = true;
            this.rbtNombre.CheckedChanged += new System.EventHandler(this.rbtNombre_CheckedChanged);
            // 
            // rbtCargo
            // 
            this.rbtCargo.AutoSize = true;
            this.rbtCargo.Depth = 0;
            this.rbtCargo.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtCargo.Location = new System.Drawing.Point(97, 511);
            this.rbtCargo.Margin = new System.Windows.Forms.Padding(0);
            this.rbtCargo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtCargo.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtCargo.Name = "rbtCargo";
            this.rbtCargo.Ripple = true;
            this.rbtCargo.Size = new System.Drawing.Size(66, 30);
            this.rbtCargo.TabIndex = 31;
            this.rbtCargo.TabStop = true;
            this.rbtCargo.Text = "Cargo";
            this.rbtCargo.UseVisualStyleBackColor = true;
            this.rbtCargo.CheckedChanged += new System.EventHandler(this.rbtCargo_CheckedChanged);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.BackgroundImage = global::App_Portomadero.Properties.Resources.recuperacion_de_datos;
            this.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Location = new System.Drawing.Point(702, 418);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(56, 50);
            this.btnRestaurar.TabIndex = 35;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // fmrListaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.rbtID);
            this.Controls.Add(this.rbtEstado);
            this.Controls.Add(this.rbtNombre);
            this.Controls.Add(this.rbtCargo);
            this.Controls.Add(this.cbBusqueda);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrListaEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmrEmpleados";
            this.Load += new System.EventHandler(this.fmrListaEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBusqueda;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cbBusqueda;
        private MaterialSkin.Controls.MaterialRadioButton rbtID;
        private MaterialSkin.Controls.MaterialRadioButton rbtEstado;
        private MaterialSkin.Controls.MaterialRadioButton rbtNombre;
        private MaterialSkin.Controls.MaterialRadioButton rbtCargo;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewButtonColumn Ver;
        private System.Windows.Forms.DataGridViewButtonColumn Borrar;
    }
}