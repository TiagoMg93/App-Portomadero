namespace App_Portomadero
{
    partial class fmrConfReserva
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSabado = new System.Windows.Forms.Button();
            this.btnDomingo = new System.Windows.Forms.Button();
            this.btnJueves = new System.Windows.Forms.Button();
            this.btnViernes = new System.Windows.Forms.Button();
            this.btnMiercoles = new System.Windows.Forms.Button();
            this.btnMartes = new System.Windows.Forms.Button();
            this.btnLunes = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbCierre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbApertura = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvConfiguracion = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbHoras = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMinutos = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfiguracion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSabado);
            this.groupBox1.Controls.Add(this.btnDomingo);
            this.groupBox1.Controls.Add(this.btnJueves);
            this.groupBox1.Controls.Add(this.btnViernes);
            this.groupBox1.Controls.Add(this.btnMiercoles);
            this.groupBox1.Controls.Add(this.btnMartes);
            this.groupBox1.Controls.Add(this.btnLunes);
            this.groupBox1.Location = new System.Drawing.Point(34, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 374);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dias de la semana";
            // 
            // btnSabado
            // 
            this.btnSabado.BackColor = System.Drawing.Color.White;
            this.btnSabado.FlatAppearance.BorderSize = 0;
            this.btnSabado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSabado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSabado.Location = new System.Drawing.Point(39, 274);
            this.btnSabado.Name = "btnSabado";
            this.btnSabado.Size = new System.Drawing.Size(88, 30);
            this.btnSabado.TabIndex = 6;
            this.btnSabado.Text = "Sábado";
            this.btnSabado.UseVisualStyleBackColor = false;
            this.btnSabado.Click += new System.EventHandler(this.btnSabado_Click);
            // 
            // btnDomingo
            // 
            this.btnDomingo.BackColor = System.Drawing.Color.White;
            this.btnDomingo.FlatAppearance.BorderSize = 0;
            this.btnDomingo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDomingo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDomingo.Location = new System.Drawing.Point(39, 320);
            this.btnDomingo.Name = "btnDomingo";
            this.btnDomingo.Size = new System.Drawing.Size(88, 30);
            this.btnDomingo.TabIndex = 3;
            this.btnDomingo.Text = "Domingo";
            this.btnDomingo.UseVisualStyleBackColor = false;
            this.btnDomingo.Click += new System.EventHandler(this.btnDomingo_Click);
            // 
            // btnJueves
            // 
            this.btnJueves.BackColor = System.Drawing.Color.White;
            this.btnJueves.FlatAppearance.BorderSize = 0;
            this.btnJueves.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJueves.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJueves.Location = new System.Drawing.Point(39, 178);
            this.btnJueves.Name = "btnJueves";
            this.btnJueves.Size = new System.Drawing.Size(88, 30);
            this.btnJueves.TabIndex = 4;
            this.btnJueves.Text = "Jueves";
            this.btnJueves.UseVisualStyleBackColor = false;
            this.btnJueves.Click += new System.EventHandler(this.btnJueves_Click);
            // 
            // btnViernes
            // 
            this.btnViernes.BackColor = System.Drawing.Color.White;
            this.btnViernes.FlatAppearance.BorderSize = 0;
            this.btnViernes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViernes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViernes.Location = new System.Drawing.Point(39, 226);
            this.btnViernes.Name = "btnViernes";
            this.btnViernes.Size = new System.Drawing.Size(88, 30);
            this.btnViernes.TabIndex = 5;
            this.btnViernes.Text = "Viernes";
            this.btnViernes.UseVisualStyleBackColor = false;
            this.btnViernes.Click += new System.EventHandler(this.btnViernes_Click);
            // 
            // btnMiercoles
            // 
            this.btnMiercoles.BackColor = System.Drawing.Color.White;
            this.btnMiercoles.FlatAppearance.BorderSize = 0;
            this.btnMiercoles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMiercoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiercoles.Location = new System.Drawing.Point(39, 131);
            this.btnMiercoles.Name = "btnMiercoles";
            this.btnMiercoles.Size = new System.Drawing.Size(88, 30);
            this.btnMiercoles.TabIndex = 2;
            this.btnMiercoles.Text = "Miércoles";
            this.btnMiercoles.UseVisualStyleBackColor = false;
            this.btnMiercoles.Click += new System.EventHandler(this.btnMiercoles_Click);
            // 
            // btnMartes
            // 
            this.btnMartes.BackColor = System.Drawing.Color.White;
            this.btnMartes.FlatAppearance.BorderSize = 0;
            this.btnMartes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMartes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMartes.Location = new System.Drawing.Point(39, 84);
            this.btnMartes.Name = "btnMartes";
            this.btnMartes.Size = new System.Drawing.Size(88, 30);
            this.btnMartes.TabIndex = 1;
            this.btnMartes.Text = "Martes";
            this.btnMartes.UseVisualStyleBackColor = false;
            this.btnMartes.Click += new System.EventHandler(this.btnMartes_Click);
            // 
            // btnLunes
            // 
            this.btnLunes.BackColor = System.Drawing.Color.White;
            this.btnLunes.FlatAppearance.BorderSize = 0;
            this.btnLunes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLunes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLunes.Location = new System.Drawing.Point(39, 35);
            this.btnLunes.Name = "btnLunes";
            this.btnLunes.Size = new System.Drawing.Size(88, 30);
            this.btnLunes.TabIndex = 0;
            this.btnLunes.Text = "Lunes";
            this.btnLunes.UseVisualStyleBackColor = false;
            this.btnLunes.Click += new System.EventHandler(this.btnLunes_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbCierre);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbApertura);
            this.groupBox2.Location = new System.Drawing.Point(264, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 110);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Horarios";
            // 
            // cbCierre
            // 
            this.cbCierre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCierre.FormattingEnabled = true;
            this.cbCierre.Items.AddRange(new object[] {
            "00:00",
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00"});
            this.cbCierre.Location = new System.Drawing.Point(146, 51);
            this.cbCierre.Name = "cbCierre";
            this.cbCierre.Size = new System.Drawing.Size(67, 21);
            this.cbCierre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cierre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Apertura";
            // 
            // cbApertura
            // 
            this.cbApertura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbApertura.FormattingEnabled = true;
            this.cbApertura.Items.AddRange(new object[] {
            "00:00",
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00"});
            this.cbApertura.Location = new System.Drawing.Point(23, 51);
            this.cbApertura.Name = "cbApertura";
            this.cbApertura.Size = new System.Drawing.Size(67, 21);
            this.cbApertura.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(520, 40);
            this.label4.TabIndex = 41;
            this.label4.Text = "Configuración de las reservas";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btnSalir.BackgroundImage = global::App_Portomadero.Properties.Resources.cerrar_sesion;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btnSalir.Location = new System.Drawing.Point(609, 471);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(44, 41);
            this.btnSalir.TabIndex = 45;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::App_Portomadero.Properties.Resources.disquete;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(431, 471);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(45, 41);
            this.btnGuardar.TabIndex = 46;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 47;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(264, 82);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(239, 54);
            this.textBox1.TabIndex = 48;
            this.textBox1.Text = "Seleccione el dia y los horarios correspondientes de apertura y cierre, si se eli" +
    "ge dos veces el mismo dia los datos se sobreescribiran";
            // 
            // dgvConfiguracion
            // 
            this.dgvConfiguracion.AllowUserToAddRows = false;
            this.dgvConfiguracion.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvConfiguracion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConfiguracion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Dia,
            this.Apertura,
            this.Cierre,
            this.Modifica,
            this.Horas,
            this.Minutos});
            this.dgvConfiguracion.Location = new System.Drawing.Point(232, 284);
            this.dgvConfiguracion.Name = "dgvConfiguracion";
            this.dgvConfiguracion.ReadOnly = true;
            this.dgvConfiguracion.Size = new System.Drawing.Size(410, 172);
            this.dgvConfiguracion.TabIndex = 49;
            // 
            // Num
            // 
            this.Num.HeaderText = "Num";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            this.Num.Visible = false;
            // 
            // Dia
            // 
            this.Dia.HeaderText = "Dia";
            this.Dia.Name = "Dia";
            this.Dia.ReadOnly = true;
            // 
            // Apertura
            // 
            this.Apertura.HeaderText = "Apertura";
            this.Apertura.Name = "Apertura";
            this.Apertura.ReadOnly = true;
            this.Apertura.Width = 80;
            // 
            // Cierre
            // 
            this.Cierre.HeaderText = "Cierre";
            this.Cierre.Name = "Cierre";
            this.Cierre.ReadOnly = true;
            this.Cierre.Width = 80;
            // 
            // Modifica
            // 
            this.Modifica.HeaderText = "Modifica";
            this.Modifica.Name = "Modifica";
            this.Modifica.ReadOnly = true;
            // 
            // Horas
            // 
            this.Horas.HeaderText = "Horas";
            this.Horas.Name = "Horas";
            this.Horas.ReadOnly = true;
            this.Horas.Visible = false;
            // 
            // Minutos
            // 
            this.Minutos.HeaderText = "Minutos";
            this.Minutos.Name = "Minutos";
            this.Minutos.ReadOnly = true;
            this.Minutos.Visible = false;
            // 
            // cbHoras
            // 
            this.cbHoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHoras.FormattingEnabled = true;
            this.cbHoras.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbHoras.Location = new System.Drawing.Point(528, 144);
            this.cbHoras.Name = "cbHoras";
            this.cbHoras.Size = new System.Drawing.Size(75, 21);
            this.cbHoras.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(609, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "hrs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(609, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "min";
            // 
            // cbMinutos
            // 
            this.cbMinutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMinutos.FormattingEnabled = true;
            this.cbMinutos.Items.AddRange(new object[] {
            "0",
            "15",
            "30",
            "45"});
            this.cbMinutos.Location = new System.Drawing.Point(528, 184);
            this.cbMinutos.Name = "cbMinutos";
            this.cbMinutos.Size = new System.Drawing.Size(75, 21);
            this.cbMinutos.TabIndex = 51;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(530, 93);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(102, 28);
            this.textBox2.TabIndex = 53;
            this.textBox2.Text = "Duración promedio de las reservas";
            // 
            // fmrConfReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(665, 524);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbMinutos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvConfiguracion);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbHoras);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrConfReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmrReserva";
            this.Load += new System.EventHandler(this.fmrConfReserva_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfiguracion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSabado;
        private System.Windows.Forms.Button btnDomingo;
        private System.Windows.Forms.Button btnJueves;
        private System.Windows.Forms.Button btnViernes;
        private System.Windows.Forms.Button btnMiercoles;
        private System.Windows.Forms.Button btnMartes;
        private System.Windows.Forms.Button btnLunes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbCierre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbApertura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvConfiguracion;
        private System.Windows.Forms.ComboBox cbHoras;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMinutos;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modifica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Minutos;
    }
}