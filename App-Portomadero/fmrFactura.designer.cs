namespace App_Portomadero
{
    partial class fmrFactura
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.tbProducto = new System.Windows.Forms.TextBox();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.flpCategorias = new System.Windows.Forms.FlowLayoutPanel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.flpProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.NumFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVendedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPago = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbCambio = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbNumFac = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCantidad = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flpCategorias.SuspendLayout();
            this.flpProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbNombre);
            this.panel1.Controls.Add(this.tbProducto);
            this.panel1.Controls.Add(this.tbCantidad);
            this.panel1.Controls.Add(this.btnCantidad);
            this.panel1.Controls.Add(this.flpCategorias);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 134);
            this.panel1.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(795, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cantidad";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(795, 25);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(80, 20);
            this.lbNombre.TabIndex = 10;
            this.lbNombre.Text = "Producto";
            // 
            // tbProducto
            // 
            this.tbProducto.CausesValidation = false;
            this.tbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProducto.Location = new System.Drawing.Point(894, 19);
            this.tbProducto.Name = "tbProducto";
            this.tbProducto.ReadOnly = true;
            this.tbProducto.Size = new System.Drawing.Size(269, 29);
            this.tbProducto.TabIndex = 2;
            // 
            // tbCantidad
            // 
            this.tbCantidad.CausesValidation = false;
            this.tbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidad.Location = new System.Drawing.Point(894, 81);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(96, 29);
            this.tbCantidad.TabIndex = 3;
            // 
            // flpCategorias
            // 
            this.flpCategorias.AllowDrop = true;
            this.flpCategorias.AutoScroll = true;
            this.flpCategorias.Controls.Add(this.vScrollBar1);
            this.flpCategorias.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpCategorias.Location = new System.Drawing.Point(0, 0);
            this.flpCategorias.Name = "flpCategorias";
            this.flpCategorias.Size = new System.Drawing.Size(737, 134);
            this.flpCategorias.TabIndex = 0;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vScrollBar1.LargeChange = 13;
            this.vScrollBar1.Location = new System.Drawing.Point(0, 0);
            this.vScrollBar1.Maximum = 12;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.vScrollBar1.Size = new System.Drawing.Size(22, 134);
            this.vScrollBar1.TabIndex = 0;
            this.vScrollBar1.Visible = false;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            this.vScrollBar1.ValueChanged += new System.EventHandler(this.vScrollBar1_ValueChanged);
            // 
            // flpProductos
            // 
            this.flpProductos.AllowDrop = true;
            this.flpProductos.AutoScroll = true;
            this.flpProductos.Controls.Add(this.vScrollBar2);
            this.flpProductos.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpProductos.Location = new System.Drawing.Point(0, 134);
            this.flpProductos.Name = "flpProductos";
            this.flpProductos.Size = new System.Drawing.Size(737, 566);
            this.flpProductos.TabIndex = 1;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vScrollBar2.LargeChange = 13;
            this.vScrollBar2.Location = new System.Drawing.Point(0, 0);
            this.vScrollBar2.Maximum = 12;
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.vScrollBar2.Size = new System.Drawing.Size(22, 134);
            this.vScrollBar2.TabIndex = 1;
            this.vScrollBar2.Visible = false;
            // 
            // dgvFactura
            // 
            this.dgvFactura.AllowUserToAddRows = false;
            this.dgvFactura.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumFactura,
            this.Fecha,
            this.Valor,
            this.Subtotal,
            this.Borrar});
            this.dgvFactura.Location = new System.Drawing.Point(743, 259);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.ReadOnly = true;
            this.dgvFactura.Size = new System.Drawing.Size(445, 226);
            this.dgvFactura.TabIndex = 13;
            this.dgvFactura.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFactura_CellClick);
            // 
            // NumFactura
            // 
            this.NumFactura.HeaderText = "Producto";
            this.NumFactura.Name = "NumFactura";
            this.NumFactura.ReadOnly = true;
            this.NumFactura.Width = 130;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Cantidad";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 60;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Precio";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 80;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 80;
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Name = "Borrar";
            this.Borrar.ReadOnly = true;
            this.Borrar.Width = 50;
            // 
            // cbCliente
            // 
            this.cbCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(924, 155);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(264, 32);
            this.cbCliente.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(795, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Vendedor";
            // 
            // tbVendedor
            // 
            this.tbVendedor.CausesValidation = false;
            this.tbVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVendedor.Location = new System.Drawing.Point(924, 208);
            this.tbVendedor.Name = "tbVendedor";
            this.tbVendedor.ReadOnly = true;
            this.tbVendedor.Size = new System.Drawing.Size(264, 29);
            this.tbVendedor.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(795, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(818, 510);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Total a Pagar:";
            // 
            // tbPago
            // 
            this.tbPago.CausesValidation = false;
            this.tbPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPago.Location = new System.Drawing.Point(990, 504);
            this.tbPago.Name = "tbPago";
            this.tbPago.ReadOnly = true;
            this.tbPago.Size = new System.Drawing.Size(82, 29);
            this.tbPago.TabIndex = 16;
            this.tbPago.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(965, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1078, 510);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "COP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1078, 552);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "COP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(965, 552);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(818, 552);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Pago Cliente:";
            // 
            // tbCliente
            // 
            this.tbCliente.CausesValidation = false;
            this.tbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCliente.Location = new System.Drawing.Point(990, 546);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(82, 29);
            this.tbCliente.TabIndex = 7;
            this.tbCliente.Leave += new System.EventHandler(this.tbCliente_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1078, 595);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "COP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(965, 595);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(818, 595);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Cambio:";
            // 
            // tbCambio
            // 
            this.tbCambio.CausesValidation = false;
            this.tbCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCambio.Location = new System.Drawing.Point(990, 589);
            this.tbCambio.Name = "tbCambio";
            this.tbCambio.ReadOnly = true;
            this.tbCambio.Size = new System.Drawing.Size(82, 29);
            this.tbCambio.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(818, 656);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 20);
            this.label13.TabIndex = 91;
            this.label13.Text = "N";
            // 
            // lbNumFac
            // 
            this.lbNumFac.AutoSize = true;
            this.lbNumFac.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumFac.Location = new System.Drawing.Point(846, 656);
            this.lbNumFac.Name = "lbNumFac";
            this.lbNumFac.Size = new System.Drawing.Size(17, 20);
            this.lbNumFac.TabIndex = 92;
            this.lbNumFac.Text = "-";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btnSalir.BackgroundImage = global::App_Portomadero.Properties.Resources.cerrar_sesion;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btnSalir.Location = new System.Drawing.Point(1144, 647);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(44, 41);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImprimir.BackgroundImage = global::App_Portomadero.Properties.Resources.impresora;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(1012, 629);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(60, 59);
            this.btnImprimir.TabIndex = 8;
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCantidad
            // 
            this.btnCantidad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCantidad.BackgroundImage = global::App_Portomadero.Properties.Resources.perdida_de_dinero;
            this.btnCantidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCantidad.FlatAppearance.BorderSize = 0;
            this.btnCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCantidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCantidad.Location = new System.Drawing.Point(1030, 72);
            this.btnCantidad.Name = "btnCantidad";
            this.btnCantidad.Size = new System.Drawing.Size(60, 50);
            this.btnCantidad.TabIndex = 4;
            this.btnCantidad.UseVisualStyleBackColor = false;
            this.btnCantidad.Click += new System.EventHandler(this.btnCantidad_Click);
            // 
            // fmrFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.lbNumFac);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbCambio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPago);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.tbVendedor);
            this.Controls.Add(this.dgvFactura);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.flpProductos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmrFactura";
            this.Load += new System.EventHandler(this.fmrFactura_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flpCategorias.ResumeLayout(false);
            this.flpProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpCategorias;
        private System.Windows.Forms.FlowLayoutPanel flpProductos;
        private System.Windows.Forms.Button btnCantidad;
        private System.Windows.Forms.TextBox tbProducto;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVendedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewButtonColumn Borrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbCambio;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbNumFac;
    }
}