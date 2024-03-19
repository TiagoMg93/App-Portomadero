namespace App_Portomadero
{
    partial class fmrListaReservas
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
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFecha = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFinal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbInicio = new System.Windows.Forms.ComboBox();
            this.btnHora = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbEspacio = new System.Windows.Forms.ComboBox();
            this.btnEspacio = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.btnCliente = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Espacio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Hora,
            this.Cliente,
            this.Espacio,
            this.Modifica,
            this.Comentario,
            this.Ver,
            this.Borrar});
            this.dgvReservas.Location = new System.Drawing.Point(37, 90);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.Size = new System.Drawing.Size(725, 221);
            this.dgvReservas.TabIndex = 18;
            this.dgvReservas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservas_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 40);
            this.label1.TabIndex = 19;
            this.label1.Text = "Lista de Reservas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.BackgroundImage = global::App_Portomadero.Properties.Resources.recuperacion_de_datos;
            this.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Location = new System.Drawing.Point(706, 317);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(56, 50);
            this.btnRestaurar.TabIndex = 36;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpFinal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpInicio);
            this.groupBox1.Location = new System.Drawing.Point(25, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 91);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro de fecha";
            // 
            // btnFecha
            // 
            this.btnFecha.BackgroundImage = global::App_Portomadero.Properties.Resources.busqueda;
            this.btnFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFecha.FlatAppearance.BorderSize = 0;
            this.btnFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecha.Location = new System.Drawing.Point(517, 26);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(56, 50);
            this.btnFecha.TabIndex = 39;
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hasta";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Location = new System.Drawing.Point(263, 42);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpFinal.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "De";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(23, 42);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpInicio.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btnSalir.BackgroundImage = global::App_Portomadero.Properties.Resources.cerrar_sesion;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btnSalir.Location = new System.Drawing.Point(744, 637);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(44, 41);
            this.btnSalir.TabIndex = 38;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbFinal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbInicio);
            this.groupBox2.Controls.Add(this.btnHora);
            this.groupBox2.Location = new System.Drawing.Point(25, 425);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 91);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtro de hora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Hasta";
            // 
            // cbFinal
            // 
            this.cbFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFinal.FormattingEnabled = true;
            this.cbFinal.Location = new System.Drawing.Point(192, 42);
            this.cbFinal.Name = "cbFinal";
            this.cbFinal.Size = new System.Drawing.Size(121, 21);
            this.cbFinal.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "De";
            // 
            // cbInicio
            // 
            this.cbInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInicio.FormattingEnabled = true;
            this.cbInicio.Location = new System.Drawing.Point(23, 42);
            this.cbInicio.Name = "cbInicio";
            this.cbInicio.Size = new System.Drawing.Size(121, 21);
            this.cbInicio.TabIndex = 40;
            // 
            // btnHora
            // 
            this.btnHora.BackgroundImage = global::App_Portomadero.Properties.Resources.busqueda;
            this.btnHora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHora.FlatAppearance.BorderSize = 0;
            this.btnHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHora.Location = new System.Drawing.Point(348, 26);
            this.btnHora.Name = "btnHora";
            this.btnHora.Size = new System.Drawing.Size(56, 50);
            this.btnHora.TabIndex = 39;
            this.btnHora.UseVisualStyleBackColor = true;
            this.btnHora.Click += new System.EventHandler(this.btnHora_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cbEspacio);
            this.groupBox3.Controls.Add(this.btnEspacio);
            this.groupBox3.Location = new System.Drawing.Point(455, 425);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 91);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtro de espacios";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Espacios";
            // 
            // cbEspacio
            // 
            this.cbEspacio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEspacio.FormattingEnabled = true;
            this.cbEspacio.Location = new System.Drawing.Point(56, 42);
            this.cbEspacio.Name = "cbEspacio";
            this.cbEspacio.Size = new System.Drawing.Size(121, 21);
            this.cbEspacio.TabIndex = 40;
            // 
            // btnEspacio
            // 
            this.btnEspacio.BackgroundImage = global::App_Portomadero.Properties.Resources.busqueda;
            this.btnEspacio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEspacio.FlatAppearance.BorderSize = 0;
            this.btnEspacio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEspacio.Location = new System.Drawing.Point(202, 26);
            this.btnEspacio.Name = "btnEspacio";
            this.btnEspacio.Size = new System.Drawing.Size(56, 50);
            this.btnEspacio.TabIndex = 39;
            this.btnEspacio.UseVisualStyleBackColor = true;
            this.btnEspacio.Click += new System.EventHandler(this.btnEspacio_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.cbCliente);
            this.groupBox4.Controls.Add(this.btnCliente);
            this.groupBox4.Location = new System.Drawing.Point(25, 533);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(392, 91);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filtro de cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Cliente";
            // 
            // cbCliente
            // 
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(23, 42);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(290, 21);
            this.cbCliente.TabIndex = 40;
            // 
            // btnCliente
            // 
            this.btnCliente.BackgroundImage = global::App_Portomadero.Properties.Resources.busqueda;
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Location = new System.Drawing.Point(330, 26);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(56, 50);
            this.btnCliente.TabIndex = 39;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.cbUsuario);
            this.groupBox5.Controls.Add(this.btnUsuario);
            this.groupBox5.Location = new System.Drawing.Point(463, 533);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(299, 91);
            this.groupBox5.TabIndex = 46;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Filtro de usuario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Usuario";
            // 
            // cbUsuario
            // 
            this.cbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(50, 42);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(132, 21);
            this.cbUsuario.TabIndex = 40;
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackgroundImage = global::App_Portomadero.Properties.Resources.busqueda;
            this.btnUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Location = new System.Drawing.Point(194, 26);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(56, 50);
            this.btnUsuario.TabIndex = 39;
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 80;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            this.Hora.Width = 70;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 200;
            // 
            // Espacio
            // 
            this.Espacio.HeaderText = "Espacio";
            this.Espacio.Name = "Espacio";
            this.Espacio.ReadOnly = true;
            // 
            // Modifica
            // 
            this.Modifica.HeaderText = "Modifica";
            this.Modifica.Name = "Modifica";
            this.Modifica.ReadOnly = true;
            // 
            // Comentario
            // 
            this.Comentario.HeaderText = "Comentario";
            this.Comentario.Name = "Comentario";
            this.Comentario.ReadOnly = true;
            this.Comentario.Visible = false;
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
            // fmrListaReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 690);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReservas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrListaReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmrListaReservas";
            this.Load += new System.EventHandler(this.fmrListaReservas_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbInicio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbEspacio;
        private System.Windows.Forms.Button btnEspacio;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Espacio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modifica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentario;
        private System.Windows.Forms.DataGridViewButtonColumn Ver;
        private System.Windows.Forms.DataGridViewButtonColumn Borrar;
    }
}