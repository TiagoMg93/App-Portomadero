namespace App_Portomadero
{
    partial class fmrEmpleado
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDocumento = new System.Windows.Forms.Label();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.cbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.txtDocumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnSiguiente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAnterior = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtFoto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnModificar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnFoto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbObligatorio = new System.Windows.Forms.Label();
            this.lbObligatorio2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(27, 10);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(233, 24);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre del empleado";
            // 
            // lbDocumento
            // 
            this.lbDocumento.AutoSize = true;
            this.lbDocumento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDocumento.Location = new System.Drawing.Point(143, 42);
            this.lbDocumento.Name = "lbDocumento";
            this.lbDocumento.Size = new System.Drawing.Size(215, 24);
            this.lbDocumento.TabIndex = 3;
            this.lbDocumento.Text = "Numero Documento";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(10, 126);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(448, 10);
            this.materialDivider1.TabIndex = 4;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // cbTipoDocumento
            // 
            this.cbTipoDocumento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoDocumento.FormattingEnabled = true;
            this.cbTipoDocumento.Items.AddRange(new object[] {
            "CC",
            "TI",
            "CE",
            "RC",
            "DNI",
            "CI"});
            this.cbTipoDocumento.Location = new System.Drawing.Point(31, 42);
            this.cbTipoDocumento.Name = "cbTipoDocumento";
            this.cbTipoDocumento.Size = new System.Drawing.Size(58, 30);
            this.cbTipoDocumento.TabIndex = 1;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Depth = 0;
            this.txtDocumento.Hint = "Escribe aqui el número de documento";
            this.txtDocumento.Location = new System.Drawing.Point(144, 49);
            this.txtDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.PasswordChar = '\0';
            this.txtDocumento.SelectedText = "";
            this.txtDocumento.SelectionLength = 0;
            this.txtDocumento.SelectionStart = 0;
            this.txtDocumento.Size = new System.Drawing.Size(298, 23);
            this.txtDocumento.TabIndex = 2;
            this.txtDocumento.UseSystemPasswordChar = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "Escribe aqui el nombre completo del nuevo empleado";
            this.txtNombre.Location = new System.Drawing.Point(28, 11);
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(414, 23);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Location = new System.Drawing.Point(1, 139);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(600, 500);
            this.pnlPrincipal.TabIndex = 63;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::App_Portomadero.Properties.Resources.disquete;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(479, 647);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(45, 41);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btnSalir.BackgroundImage = global::App_Portomadero.Properties.Resources.cerrar_sesion;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btnSalir.Location = new System.Drawing.Point(544, 647);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(44, 41);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.Image = global::App_Portomadero.Properties.Resources.sin_fotografia;
            this.pbFoto.Location = new System.Drawing.Point(464, 11);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(124, 121);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Depth = 0;
            this.btnSiguiente.Location = new System.Drawing.Point(298, 650);
            this.btnSiguiente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Primary = true;
            this.btnSiguiente.Size = new System.Drawing.Size(82, 35);
            this.btnSiguiente.TabIndex = 5;
            this.btnSiguiente.Text = "SIGUIENTE";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Depth = 0;
            this.btnAnterior.Location = new System.Drawing.Point(187, 650);
            this.btnAnterior.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Primary = true;
            this.btnAnterior.Size = new System.Drawing.Size(82, 35);
            this.btnAnterior.TabIndex = 4;
            this.btnAnterior.Text = "ANTERIOR";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // txtFoto
            // 
            this.txtFoto.Depth = 0;
            this.txtFoto.Hint = "";
            this.txtFoto.Location = new System.Drawing.Point(329, 101);
            this.txtFoto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.PasswordChar = '\0';
            this.txtFoto.SelectedText = "";
            this.txtFoto.SelectionLength = 0;
            this.txtFoto.SelectionStart = 0;
            this.txtFoto.Size = new System.Drawing.Size(75, 23);
            this.txtFoto.TabIndex = 101;
            this.txtFoto.UseSystemPasswordChar = false;
            this.txtFoto.Visible = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Depth = 0;
            this.btnModificar.Location = new System.Drawing.Point(225, 85);
            this.btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Primary = true;
            this.btnModificar.Size = new System.Drawing.Size(82, 35);
            this.btnModificar.TabIndex = 102;
            this.btnModificar.Text = "MODIFICAR NOMBRE";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Visible = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnFoto
            // 
            this.btnFoto.Depth = 0;
            this.btnFoto.Location = new System.Drawing.Point(360, 85);
            this.btnFoto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Primary = true;
            this.btnFoto.Size = new System.Drawing.Size(82, 35);
            this.btnFoto.TabIndex = 3;
            this.btnFoto.Text = "CARGAR FOTO";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // lbObligatorio
            // 
            this.lbObligatorio.AutoSize = true;
            this.lbObligatorio.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObligatorio.ForeColor = System.Drawing.Color.Red;
            this.lbObligatorio.Location = new System.Drawing.Point(433, 49);
            this.lbObligatorio.Name = "lbObligatorio";
            this.lbObligatorio.Size = new System.Drawing.Size(21, 25);
            this.lbObligatorio.TabIndex = 0;
            this.lbObligatorio.Text = "*";
            // 
            // lbObligatorio2
            // 
            this.lbObligatorio2.AutoSize = true;
            this.lbObligatorio2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObligatorio2.ForeColor = System.Drawing.Color.Red;
            this.lbObligatorio2.Location = new System.Drawing.Point(433, 9);
            this.lbObligatorio2.Name = "lbObligatorio2";
            this.lbObligatorio2.Size = new System.Drawing.Size(21, 25);
            this.lbObligatorio2.TabIndex = 104;
            this.lbObligatorio2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(95, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 25);
            this.label1.TabIndex = 105;
            this.label1.Text = "*";
            // 
            // fmrEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(600, 700);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbObligatorio2);
            this.Controls.Add(this.lbObligatorio);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtFoto);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.cbTipoDocumento);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.lbDocumento);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.pbFoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmrEmpleado";
            this.Load += new System.EventHandler(this.fmrEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDocumento;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.ComboBox cbTipoDocumento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDocumento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Button btnGuardar;
        public MaterialSkin.Controls.MaterialRaisedButton btnSiguiente;
        private MaterialSkin.Controls.MaterialRaisedButton btnAnterior;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFoto;
        public MaterialSkin.Controls.MaterialRaisedButton btnModificar;
        public MaterialSkin.Controls.MaterialRaisedButton btnFoto;
        private System.Windows.Forms.Label lbObligatorio;
        private System.Windows.Forms.Label lbObligatorio2;
        private System.Windows.Forms.Label label1;
    }
}