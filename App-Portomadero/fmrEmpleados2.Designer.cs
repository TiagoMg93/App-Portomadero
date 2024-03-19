namespace App_Portomadero
{
    partial class fmrEmpleados2
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
            this.cbMoneda = new System.Windows.Forms.ComboBox();
            this.materialLabel35 = new MaterialSkin.Controls.MaterialLabel();
            this.cbCargos = new System.Windows.Forms.ComboBox();
            this.lbIngresos = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel32 = new MaterialSkin.Controls.MaterialLabel();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.tbSalario = new System.Windows.Forms.TextBox();
            this.materialLabel24 = new MaterialSkin.Controls.MaterialLabel();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.materialLabel25 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel27 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTiempo = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel29 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.materialLabel31 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpRetiro = new System.Windows.Forms.DateTimePicker();
            this.txtRetiro = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.cbArl = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbMoneda
            // 
            this.cbMoneda.AutoCompleteCustomSource.AddRange(new string[] {
            "Activo",
            "Inactivo"});
            this.cbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMoneda.FormattingEnabled = true;
            this.cbMoneda.Items.AddRange(new object[] {
            "COP",
            "US",
            "LB",
            "EU"});
            this.cbMoneda.Location = new System.Drawing.Point(486, 201);
            this.cbMoneda.Name = "cbMoneda";
            this.cbMoneda.Size = new System.Drawing.Size(69, 26);
            this.cbMoneda.TabIndex = 4;
            // 
            // materialLabel35
            // 
            this.materialLabel35.AutoSize = true;
            this.materialLabel35.Depth = 0;
            this.materialLabel35.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel35.Location = new System.Drawing.Point(347, 203);
            this.materialLabel35.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel35.Name = "materialLabel35";
            this.materialLabel35.Size = new System.Drawing.Size(17, 19);
            this.materialLabel35.TabIndex = 132;
            this.materialLabel35.Text = "$";
            // 
            // cbCargos
            // 
            this.cbCargos.AutoCompleteCustomSource.AddRange(new string[] {
            "Activo",
            "Inactivo"});
            this.cbCargos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCargos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCargos.FormattingEnabled = true;
            this.cbCargos.Location = new System.Drawing.Point(85, 200);
            this.cbCargos.Name = "cbCargos";
            this.cbCargos.Size = new System.Drawing.Size(138, 26);
            this.cbCargos.TabIndex = 2;
            // 
            // lbIngresos
            // 
            this.lbIngresos.AutoSize = true;
            this.lbIngresos.Depth = 0;
            this.lbIngresos.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbIngresos.Location = new System.Drawing.Point(448, 144);
            this.lbIngresos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbIngresos.Name = "lbIngresos";
            this.lbIngresos.Size = new System.Drawing.Size(17, 19);
            this.lbIngresos.TabIndex = 128;
            this.lbIngresos.Text = "0";
            // 
            // materialLabel32
            // 
            this.materialLabel32.AutoSize = true;
            this.materialLabel32.Depth = 0;
            this.materialLabel32.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel32.Location = new System.Drawing.Point(280, 144);
            this.materialLabel32.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel32.Name = "materialLabel32";
            this.materialLabel32.Size = new System.Drawing.Size(162, 19);
            this.materialLabel32.TabIndex = 127;
            this.materialLabel32.Text = "Número de reingresos:";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripcion.Location = new System.Drawing.Point(110, 261);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.ReadOnly = true;
            this.tbDescripcion.Size = new System.Drawing.Size(439, 108);
            this.tbDescripcion.TabIndex = 5;
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.Location = new System.Drawing.Point(14, 293);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(89, 19);
            this.materialLabel16.TabIndex = 124;
            this.materialLabel16.Text = "Descripción";
            this.materialLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel17.Location = new System.Drawing.Point(17, 410);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(109, 19);
            this.materialLabel17.TabIndex = 122;
            this.materialLabel17.Text = "Fecha de retiro";
            // 
            // tbSalario
            // 
            this.tbSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalario.Location = new System.Drawing.Point(370, 200);
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(83, 24);
            this.tbSalario.TabIndex = 3;
            // 
            // materialLabel24
            // 
            this.materialLabel24.AutoSize = true;
            this.materialLabel24.Depth = 0;
            this.materialLabel24.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel24.Location = new System.Drawing.Point(14, 204);
            this.materialLabel24.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel24.Name = "materialLabel24";
            this.materialLabel24.Size = new System.Drawing.Size(53, 19);
            this.materialLabel24.TabIndex = 110;
            this.materialLabel24.Text = "Cargo:";
            // 
            // cbEstado
            // 
            this.cbEstado.AutoCompleteCustomSource.AddRange(new string[] {
            "Activo",
            "Inactivo"});
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbEstado.Location = new System.Drawing.Point(86, 141);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(138, 26);
            this.cbEstado.TabIndex = 1;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // materialLabel25
            // 
            this.materialLabel25.AutoSize = true;
            this.materialLabel25.Depth = 0;
            this.materialLabel25.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel25.Location = new System.Drawing.Point(14, 144);
            this.materialLabel25.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel25.Name = "materialLabel25";
            this.materialLabel25.Size = new System.Drawing.Size(60, 19);
            this.materialLabel25.TabIndex = 108;
            this.materialLabel25.Text = "Estado:";
            // 
            // materialLabel27
            // 
            this.materialLabel27.AutoSize = true;
            this.materialLabel27.Depth = 0;
            this.materialLabel27.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel27.Location = new System.Drawing.Point(254, 204);
            this.materialLabel27.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel27.Name = "materialLabel27";
            this.materialLabel27.Size = new System.Drawing.Size(96, 19);
            this.materialLabel27.TabIndex = 105;
            this.materialLabel27.Text = "Salario base:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 33);
            this.label1.TabIndex = 104;
            this.label1.Text = "Información laboral";
            // 
            // lbTiempo
            // 
            this.lbTiempo.AutoSize = true;
            this.lbTiempo.Depth = 0;
            this.lbTiempo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbTiempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTiempo.Location = new System.Drawing.Point(382, 109);
            this.lbTiempo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbTiempo.Name = "lbTiempo";
            this.lbTiempo.Size = new System.Drawing.Size(13, 19);
            this.lbTiempo.TabIndex = 103;
            this.lbTiempo.Text = "-";
            // 
            // materialLabel29
            // 
            this.materialLabel29.AutoSize = true;
            this.materialLabel29.Depth = 0;
            this.materialLabel29.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel29.Location = new System.Drawing.Point(385, 81);
            this.materialLabel29.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel29.Name = "materialLabel29";
            this.materialLabel29.Size = new System.Drawing.Size(162, 19);
            this.materialLabel29.TabIndex = 102;
            this.materialLabel29.Text = "Tiempo en la empresa:";
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIngreso.Location = new System.Drawing.Point(140, 80);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(200, 24);
            this.dtpIngreso.TabIndex = 0;
            this.dtpIngreso.ValueChanged += new System.EventHandler(this.dtpIngreso_ValueChanged);
            // 
            // materialLabel31
            // 
            this.materialLabel31.AutoSize = true;
            this.materialLabel31.Depth = 0;
            this.materialLabel31.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel31.Location = new System.Drawing.Point(14, 81);
            this.materialLabel31.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel31.Name = "materialLabel31";
            this.materialLabel31.Size = new System.Drawing.Size(123, 19);
            this.materialLabel31.TabIndex = 100;
            this.materialLabel31.Text = "Fecha de ingreso";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(14, 312);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(83, 19);
            this.materialLabel1.TabIndex = 134;
            this.materialLabel1.Text = "del puesto:";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpRetiro
            // 
            this.dtpRetiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRetiro.Location = new System.Drawing.Point(140, 405);
            this.dtpRetiro.Name = "dtpRetiro";
            this.dtpRetiro.Size = new System.Drawing.Size(200, 24);
            this.dtpRetiro.TabIndex = 6;
            // 
            // txtRetiro
            // 
            this.txtRetiro.Depth = 0;
            this.txtRetiro.Hint = "Escribe aquí el motivo del retiro";
            this.txtRetiro.Location = new System.Drawing.Point(97, 464);
            this.txtRetiro.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRetiro.Name = "txtRetiro";
            this.txtRetiro.PasswordChar = '\0';
            this.txtRetiro.SelectedText = "";
            this.txtRetiro.SelectionLength = 0;
            this.txtRetiro.SelectionStart = 0;
            this.txtRetiro.Size = new System.Drawing.Size(450, 23);
            this.txtRetiro.TabIndex = 8;
            this.txtRetiro.UseSystemPasswordChar = false;
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(14, 464);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(56, 19);
            this.materialLabel14.TabIndex = 136;
            this.materialLabel14.Text = "Motivo";
            // 
            // cbArl
            // 
            this.cbArl.AutoCompleteCustomSource.AddRange(new string[] {
            "Activo",
            "Inactivo"});
            this.cbArl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArl.FormattingEnabled = true;
            this.cbArl.Items.AddRange(new object[] {
            "Sura ARL",
            "Positiva",
            "Axa-Colpatria",
            "Colmena Seguros",
            "Seguros Bolivar",
            "Equidad Seguros",
            "Seguros Alfa",
            "Aurora SA",
            "Colsanitas",
            "Mapfre"});
            this.cbArl.Location = new System.Drawing.Point(411, 407);
            this.cbArl.Name = "cbArl";
            this.cbArl.Size = new System.Drawing.Size(138, 26);
            this.cbArl.TabIndex = 7;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(366, 410);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(40, 19);
            this.materialLabel2.TabIndex = 138;
            this.materialLabel2.Text = "ARL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(346, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 25);
            this.label5.TabIndex = 140;
            this.label5.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(230, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 25);
            this.label2.TabIndex = 141;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(230, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 25);
            this.label3.TabIndex = 142;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(459, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 25);
            this.label4.TabIndex = 143;
            this.label4.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(561, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 25);
            this.label6.TabIndex = 144;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(555, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 25);
            this.label7.TabIndex = 145;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(446, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 16);
            this.label8.TabIndex = 147;
            this.label8.Text = "campos obligatorios";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(566, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 16);
            this.label9.TabIndex = 146;
            this.label9.Text = "*";
            // 
            // fmrEmpleados2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(584, 511);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbArl);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtRetiro);
            this.Controls.Add(this.materialLabel14);
            this.Controls.Add(this.dtpRetiro);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cbMoneda);
            this.Controls.Add(this.materialLabel35);
            this.Controls.Add(this.cbCargos);
            this.Controls.Add(this.lbIngresos);
            this.Controls.Add(this.materialLabel32);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.materialLabel16);
            this.Controls.Add(this.materialLabel17);
            this.Controls.Add(this.tbSalario);
            this.Controls.Add(this.materialLabel24);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.materialLabel25);
            this.Controls.Add(this.materialLabel27);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTiempo);
            this.Controls.Add(this.materialLabel29);
            this.Controls.Add(this.dtpIngreso);
            this.Controls.Add(this.materialLabel31);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrEmpleados2";
            this.Text = "fmrEmpleados2";
            this.Load += new System.EventHandler(this.fmrEmpleados2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbMoneda;
        public MaterialSkin.Controls.MaterialLabel materialLabel35;
        public System.Windows.Forms.ComboBox cbCargos;
        public MaterialSkin.Controls.MaterialLabel lbIngresos;
        public MaterialSkin.Controls.MaterialLabel materialLabel32;
        public System.Windows.Forms.TextBox tbDescripcion;
        public MaterialSkin.Controls.MaterialLabel materialLabel16;
        public MaterialSkin.Controls.MaterialLabel materialLabel17;
        public System.Windows.Forms.TextBox tbSalario;
        public MaterialSkin.Controls.MaterialLabel materialLabel24;
        public System.Windows.Forms.ComboBox cbEstado;
        public MaterialSkin.Controls.MaterialLabel materialLabel25;
        public MaterialSkin.Controls.MaterialLabel materialLabel27;
        public MaterialSkin.Controls.MaterialLabel lbTiempo;
        public MaterialSkin.Controls.MaterialLabel materialLabel29;
        public System.Windows.Forms.DateTimePicker dtpIngreso;
        public MaterialSkin.Controls.MaterialLabel materialLabel31;
        public MaterialSkin.Controls.MaterialLabel materialLabel1;
        public System.Windows.Forms.DateTimePicker dtpRetiro;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtRetiro;
        public MaterialSkin.Controls.MaterialLabel materialLabel14;
        public System.Windows.Forms.ComboBox cbArl;
        public MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}