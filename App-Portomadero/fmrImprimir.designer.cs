namespace App_Portomadero
{
    partial class fmrImprimir
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
            this.label9 = new System.Windows.Forms.Label();
            this.lbRemigen = new System.Windows.Forms.Label();
            this.lbCiudad = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbNit = new System.Windows.Forms.Label();
            this.lbSigFac = new System.Windows.Forms.Label();
            this.lbNumFac = new System.Windows.Forms.Label();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.NumFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbCliente = new System.Windows.Forms.Label();
            this.lbCambio = new System.Windows.Forms.Label();
            this.lbPagar = new System.Windows.Forms.Label();
            this.lbUbicacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNomVendedor = new System.Windows.Forms.Label();
            this.lbNomCliente = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Factura #";
            // 
            // lbRemigen
            // 
            this.lbRemigen.AutoSize = true;
            this.lbRemigen.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRemigen.Location = new System.Drawing.Point(87, 131);
            this.lbRemigen.Name = "lbRemigen";
            this.lbRemigen.Size = new System.Drawing.Size(123, 16);
            this.lbRemigen.TabIndex = 23;
            this.lbRemigen.Text = "Regimen Simple";
            // 
            // lbCiudad
            // 
            this.lbCiudad.AutoSize = true;
            this.lbCiudad.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCiudad.Location = new System.Drawing.Point(4, 147);
            this.lbCiudad.Name = "lbCiudad";
            this.lbCiudad.Size = new System.Drawing.Size(284, 16);
            this.lbCiudad.TabIndex = 24;
            this.lbCiudad.Text = "San Pedro de los Milagros, Antioquia";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDireccion.Location = new System.Drawing.Point(53, 163);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(176, 16);
            this.lbDireccion.TabIndex = 25;
            this.lbDireccion.Text = "Carrera 48A # 50 - 47";
            // 
            // lbNit
            // 
            this.lbNit.AutoSize = true;
            this.lbNit.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNit.Location = new System.Drawing.Point(68, 195);
            this.lbNit.Name = "lbNit";
            this.lbNit.Size = new System.Drawing.Size(137, 16);
            this.lbNit.TabIndex = 26;
            this.lbNit.Text = "NIT: 1152202498";
            // 
            // lbSigFac
            // 
            this.lbSigFac.AutoSize = true;
            this.lbSigFac.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSigFac.Location = new System.Drawing.Point(126, 305);
            this.lbSigFac.Name = "lbSigFac";
            this.lbSigFac.Size = new System.Drawing.Size(79, 20);
            this.lbSigFac.TabIndex = 27;
            this.lbSigFac.Text = "PORT - ";
            // 
            // lbNumFac
            // 
            this.lbNumFac.AutoSize = true;
            this.lbNumFac.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumFac.Location = new System.Drawing.Point(189, 305);
            this.lbNumFac.Name = "lbNumFac";
            this.lbNumFac.Size = new System.Drawing.Size(22, 20);
            this.lbNumFac.TabIndex = 28;
            this.lbNumFac.Text = "N";
            // 
            // dgvFactura
            // 
            this.dgvFactura.AllowUserToAddRows = false;
            this.dgvFactura.BackgroundColor = System.Drawing.Color.White;
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumFactura,
            this.Fecha,
            this.Valor,
            this.Subtotal});
            this.dgvFactura.Location = new System.Drawing.Point(6, 328);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.ReadOnly = true;
            this.dgvFactura.Size = new System.Drawing.Size(288, 215);
            this.dgvFactura.TabIndex = 29;
            // 
            // NumFactura
            // 
            this.NumFactura.HeaderText = "Producto";
            this.NumFactura.Name = "NumFactura";
            this.NumFactura.ReadOnly = true;
            this.NumFactura.Width = 80;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Cantidad";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 55;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Precio";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 50;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 60;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 606);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 20);
            this.label12.TabIndex = 32;
            this.label12.Text = "Cambio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 575);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Pago Cliente:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 546);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Total a Pagar:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(186, 546);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(187, 606);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 20);
            this.label11.TabIndex = 34;
            this.label11.Text = "$";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(186, 575);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 20);
            this.label13.TabIndex = 35;
            this.label13.Text = "$";
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCliente.Location = new System.Drawing.Point(212, 575);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(22, 20);
            this.lbCliente.TabIndex = 38;
            this.lbCliente.Text = "N";
            // 
            // lbCambio
            // 
            this.lbCambio.AutoSize = true;
            this.lbCambio.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCambio.Location = new System.Drawing.Point(213, 606);
            this.lbCambio.Name = "lbCambio";
            this.lbCambio.Size = new System.Drawing.Size(22, 20);
            this.lbCambio.TabIndex = 37;
            this.lbCambio.Text = "N";
            // 
            // lbPagar
            // 
            this.lbPagar.AutoSize = true;
            this.lbPagar.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPagar.Location = new System.Drawing.Point(212, 546);
            this.lbPagar.Name = "lbPagar";
            this.lbPagar.Size = new System.Drawing.Size(22, 20);
            this.lbPagar.TabIndex = 36;
            this.lbPagar.Text = "N";
            // 
            // lbUbicacion
            // 
            this.lbUbicacion.AutoSize = true;
            this.lbUbicacion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUbicacion.Location = new System.Drawing.Point(57, 179);
            this.lbUbicacion.Name = "lbUbicacion";
            this.lbUbicacion.Size = new System.Drawing.Size(167, 16);
            this.lbUbicacion.TabIndex = 39;
            this.lbUbicacion.Text = "Parqueadero La Vega";
            this.lbUbicacion.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Vendedor:";
            // 
            // lbNomVendedor
            // 
            this.lbNomVendedor.AutoSize = true;
            this.lbNomVendedor.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomVendedor.Location = new System.Drawing.Point(103, 276);
            this.lbNomVendedor.Name = "lbNomVendedor";
            this.lbNomVendedor.Size = new System.Drawing.Size(18, 16);
            this.lbNomVendedor.TabIndex = 45;
            this.lbNomVendedor.Text = "N";
            // 
            // lbNomCliente
            // 
            this.lbNomCliente.AutoSize = true;
            this.lbNomCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomCliente.Location = new System.Drawing.Point(85, 250);
            this.lbNomCliente.Name = "lbNomCliente";
            this.lbNomCliente.Size = new System.Drawing.Size(18, 16);
            this.lbNomCliente.TabIndex = 46;
            this.lbNomCliente.Text = "N";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.Location = new System.Drawing.Point(19, 211);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(53, 16);
            this.lbFecha.TabIndex = 47;
            this.lbFecha.Text = "Fecha";
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.Location = new System.Drawing.Point(105, 226);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(53, 16);
            this.lbHora.TabIndex = 48;
            this.lbHora.Text = "Fecha";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = global::App_Portomadero.Properties.Resources.boton_de_quitar_cuadrado;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(269, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.TabIndex = 42;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.BackgroundImage = global::App_Portomadero.Properties.Resources.ahorrar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 642);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 55);
            this.button1.TabIndex = 41;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImprimir.BackgroundImage = global::App_Portomadero.Properties.Resources.impresora;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(234, 642);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(55, 55);
            this.btnImprimir.TabIndex = 40;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App_Portomadero.Properties.Resources.Logo_Portomadero;
            this.pictureBox1.Location = new System.Drawing.Point(71, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 116);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // fmrImprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 700);
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbNomCliente);
            this.Controls.Add(this.lbNomVendedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lbUbicacion);
            this.Controls.Add(this.lbCliente);
            this.Controls.Add(this.lbCambio);
            this.Controls.Add(this.lbPagar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvFactura);
            this.Controls.Add(this.lbNumFac);
            this.Controls.Add(this.lbSigFac);
            this.Controls.Add(this.lbNit);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.lbCiudad);
            this.Controls.Add(this.lbRemigen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrImprimir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmrImprimir";
            this.Load += new System.EventHandler(this.fmrImprimir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbRemigen;
        private System.Windows.Forms.Label lbCiudad;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbNit;
        private System.Windows.Forms.Label lbSigFac;
        private System.Windows.Forms.Label lbNumFac;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Label lbCambio;
        private System.Windows.Forms.Label lbPagar;
        private System.Windows.Forms.Label lbUbicacion;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNomVendedor;
        private System.Windows.Forms.Label lbNomCliente;
        private System.Windows.Forms.Label lbFecha;
        public System.Windows.Forms.Label lbHora;
    }
}