namespace App_Portomadero
{
    partial class fmrMenu
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
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tcControl = new MaterialSkin.Controls.MaterialTabControl();
            this.HOME = new System.Windows.Forms.TabPage();
            this.lbNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.VENTA = new System.Windows.Forms.TabPage();
            this.btnListPed = new System.Windows.Forms.Button();
            this.btnListaFac = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnPedido = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.PERSONAL = new System.Windows.Forms.TabPage();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnRoles = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.INVENTARIO = new System.Windows.Forms.TabPage();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.RESERVAS = new System.Windows.Forms.TabPage();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tcControl.SuspendLayout();
            this.HOME.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.VENTA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PERSONAL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.INVENTARIO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.RESERVAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialTabSelector1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 54);
            this.panel1.TabIndex = 7;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tcControl;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(800, 54);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // tcControl
            // 
            this.tcControl.Controls.Add(this.HOME);
            this.tcControl.Controls.Add(this.VENTA);
            this.tcControl.Controls.Add(this.PERSONAL);
            this.tcControl.Controls.Add(this.INVENTARIO);
            this.tcControl.Controls.Add(this.RESERVAS);
            this.tcControl.Controls.Add(this.tabPage1);
            this.tcControl.Controls.Add(this.tabPage2);
            this.tcControl.Depth = 0;
            this.tcControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcControl.Location = new System.Drawing.Point(0, 54);
            this.tcControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcControl.Name = "tcControl";
            this.tcControl.SelectedIndex = 0;
            this.tcControl.Size = new System.Drawing.Size(800, 396);
            this.tcControl.TabIndex = 16;
            // 
            // HOME
            // 
            this.HOME.Controls.Add(this.lbNombre);
            this.HOME.Controls.Add(this.label1);
            this.HOME.Controls.Add(this.pictureBox1);
            this.HOME.Location = new System.Drawing.Point(4, 22);
            this.HOME.Name = "HOME";
            this.HOME.Padding = new System.Windows.Forms.Padding(3);
            this.HOME.Size = new System.Drawing.Size(792, 370);
            this.HOME.TabIndex = 0;
            this.HOME.Text = "HOME";
            this.HOME.UseVisualStyleBackColor = true;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(219, 178);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(109, 42);
            this.lbNombre.TabIndex = 29;
            this.lbNombre.Text = "-------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 42);
            this.label1.TabIndex = 28;
            this.label1.Text = "Bienvenid@ a la app ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App_Portomadero.Properties.Resources.Logo_Portomadero;
            this.pictureBox1.Location = new System.Drawing.Point(8, 253);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // VENTA
            // 
            this.VENTA.Controls.Add(this.btnListPed);
            this.VENTA.Controls.Add(this.btnListaFac);
            this.VENTA.Controls.Add(this.pictureBox2);
            this.VENTA.Controls.Add(this.btnPedido);
            this.VENTA.Controls.Add(this.btnFacturar);
            this.VENTA.Location = new System.Drawing.Point(4, 22);
            this.VENTA.Name = "VENTA";
            this.VENTA.Padding = new System.Windows.Forms.Padding(3);
            this.VENTA.Size = new System.Drawing.Size(792, 370);
            this.VENTA.TabIndex = 1;
            this.VENTA.Text = "VENTA";
            this.VENTA.UseVisualStyleBackColor = true;
            // 
            // btnListPed
            // 
            this.btnListPed.BackgroundImage = global::App_Portomadero.Properties.Resources.orden_aprobada;
            this.btnListPed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnListPed.FlatAppearance.BorderSize = 0;
            this.btnListPed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListPed.Location = new System.Drawing.Point(593, 20);
            this.btnListPed.Name = "btnListPed";
            this.btnListPed.Size = new System.Drawing.Size(135, 180);
            this.btnListPed.TabIndex = 28;
            this.btnListPed.Text = "Lista de pedidos";
            this.btnListPed.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListPed.UseVisualStyleBackColor = true;
            // 
            // btnListaFac
            // 
            this.btnListaFac.BackgroundImage = global::App_Portomadero.Properties.Resources.portafolio;
            this.btnListaFac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnListaFac.FlatAppearance.BorderSize = 0;
            this.btnListaFac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaFac.Location = new System.Drawing.Point(400, 20);
            this.btnListaFac.Name = "btnListaFac";
            this.btnListaFac.Size = new System.Drawing.Size(135, 180);
            this.btnListaFac.TabIndex = 27;
            this.btnListaFac.Text = "Lista de facturas";
            this.btnListaFac.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListaFac.UseVisualStyleBackColor = true;
            this.btnListaFac.Click += new System.EventHandler(this.btnListaFac_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::App_Portomadero.Properties.Resources.Logo_Portomadero;
            this.pictureBox2.Location = new System.Drawing.Point(8, 253);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(144, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // btnPedido
            // 
            this.btnPedido.BackgroundImage = global::App_Portomadero.Properties.Resources.pedido_en_linea;
            this.btnPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPedido.FlatAppearance.BorderSize = 0;
            this.btnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.Location = new System.Drawing.Point(206, 20);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(135, 180);
            this.btnPedido.TabIndex = 22;
            this.btnPedido.Text = "Pedido";
            this.btnPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackgroundImage = global::App_Portomadero.Properties.Resources.cuenta;
            this.btnFacturar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFacturar.FlatAppearance.BorderSize = 0;
            this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Location = new System.Drawing.Point(17, 20);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(135, 180);
            this.btnFacturar.TabIndex = 21;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // PERSONAL
            // 
            this.PERSONAL.Controls.Add(this.btnUsuarios);
            this.PERSONAL.Controls.Add(this.btnRoles);
            this.PERSONAL.Controls.Add(this.pictureBox3);
            this.PERSONAL.Controls.Add(this.btnEmpleados);
            this.PERSONAL.Controls.Add(this.btnClientes);
            this.PERSONAL.Location = new System.Drawing.Point(4, 22);
            this.PERSONAL.Name = "PERSONAL";
            this.PERSONAL.Size = new System.Drawing.Size(792, 370);
            this.PERSONAL.TabIndex = 2;
            this.PERSONAL.Text = "PERSONAL";
            this.PERSONAL.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackgroundImage = global::App_Portomadero.Properties.Resources.avatar;
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Location = new System.Drawing.Point(592, 18);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(135, 180);
            this.btnUsuarios.TabIndex = 29;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnRoles
            // 
            this.btnRoles.BackgroundImage = global::App_Portomadero.Properties.Resources.management;
            this.btnRoles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRoles.FlatAppearance.BorderSize = 0;
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoles.Location = new System.Drawing.Point(409, 18);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(135, 180);
            this.btnRoles.TabIndex = 28;
            this.btnRoles.Text = "Roles";
            this.btnRoles.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRoles.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::App_Portomadero.Properties.Resources.Logo_Portomadero;
            this.pictureBox3.Location = new System.Drawing.Point(8, 253);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(144, 109);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackgroundImage = global::App_Portomadero.Properties.Resources.pasar;
            this.btnEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Location = new System.Drawing.Point(17, 18);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(135, 180);
            this.btnEmpleados.TabIndex = 25;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            this.btnClientes.BackgroundImage = global::App_Portomadero.Properties.Resources.comentarios_de_los_clientes;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(213, 18);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(135, 180);
            this.btnClientes.TabIndex = 26;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // INVENTARIO
            // 
            this.INVENTARIO.Controls.Add(this.btnInventario);
            this.INVENTARIO.Controls.Add(this.btnProducto);
            this.INVENTARIO.Controls.Add(this.pictureBox4);
            this.INVENTARIO.Location = new System.Drawing.Point(4, 22);
            this.INVENTARIO.Name = "INVENTARIO";
            this.INVENTARIO.Size = new System.Drawing.Size(792, 370);
            this.INVENTARIO.TabIndex = 3;
            this.INVENTARIO.Text = "INVENTARIO";
            this.INVENTARIO.UseVisualStyleBackColor = true;
            // 
            // btnInventario
            // 
            this.btnInventario.BackgroundImage = global::App_Portomadero.Properties.Resources.inventario;
            this.btnInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.Location = new System.Drawing.Point(200, 25);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(135, 180);
            this.btnInventario.TabIndex = 29;
            this.btnInventario.Text = "Lista productos";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInventario.UseVisualStyleBackColor = true;
            // 
            // btnProducto
            // 
            this.btnProducto.BackgroundImage = global::App_Portomadero.Properties.Resources.caja;
            this.btnProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProducto.FlatAppearance.BorderSize = 0;
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.Location = new System.Drawing.Point(17, 25);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(135, 180);
            this.btnProducto.TabIndex = 28;
            this.btnProducto.Text = "Producto nuevo";
            this.btnProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::App_Portomadero.Properties.Resources.Logo_Portomadero;
            this.pictureBox4.Location = new System.Drawing.Point(8, 253);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(144, 109);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // RESERVAS
            // 
            this.RESERVAS.Controls.Add(this.pictureBox5);
            this.RESERVAS.Location = new System.Drawing.Point(4, 22);
            this.RESERVAS.Name = "RESERVAS";
            this.RESERVAS.Size = new System.Drawing.Size(792, 370);
            this.RESERVAS.TabIndex = 4;
            this.RESERVAS.Text = "RESERVAS";
            this.RESERVAS.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::App_Portomadero.Properties.Resources.Logo_Portomadero;
            this.pictureBox5.Location = new System.Drawing.Point(8, 253);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(144, 109);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 28;
            this.pictureBox5.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(792, 370);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "INFORMES";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(792, 370);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "ACERCA DE";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(752, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(48, 396);
            this.panel2.TabIndex = 17;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::App_Portomadero.Properties.Resources.cerrar_sesion;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(7, 354);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(34, 35);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // fmrMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tcControl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.tcControl.ResumeLayout(false);
            this.HOME.ResumeLayout(false);
            this.HOME.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.VENTA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PERSONAL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.INVENTARIO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.RESERVAS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTabControl tcControl;
        private System.Windows.Forms.TabPage HOME;
        private System.Windows.Forms.TabPage VENTA;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.TabPage PERSONAL;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.TabPage INVENTARIO;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnListaFac;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnListPed;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage RESERVAS;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnInventario;
    }
}