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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tbImportante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbMision = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVision = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VENTA = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
            this.btnListaFac = new System.Windows.Forms.Button();
            this.btnListPed = new System.Windows.Forms.Button();
            this.PERSONAL = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnCargos = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnRoles = new System.Windows.Forms.Button();
            this.INVENTARIO = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnIngredientes = new System.Windows.Forms.Button();
            this.btnReceta = new System.Windows.Forms.Button();
            this.RESERVAS = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTurno = new System.Windows.Forms.Button();
            this.btnReserva = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnMesas = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCostos = new System.Windows.Forms.Button();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tcControl.SuspendLayout();
            this.HOME.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.VENTA.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.PERSONAL.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.INVENTARIO.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.RESERVAS.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
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
            this.HOME.Controls.Add(this.splitContainer2);
            this.HOME.Controls.Add(this.splitContainer1);
            this.HOME.Location = new System.Drawing.Point(4, 22);
            this.HOME.Name = "HOME";
            this.HOME.Padding = new System.Windows.Forms.Padding(3);
            this.HOME.Size = new System.Drawing.Size(792, 370);
            this.HOME.TabIndex = 0;
            this.HOME.Text = "HOME";
            this.HOME.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 182);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.pbLogo);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tbImportante);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Size = new System.Drawing.Size(786, 185);
            this.splitContainer2.SplitterDistance = 231;
            this.splitContainer2.TabIndex = 29;
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(5, 20);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(217, 150);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 27;
            this.pbLogo.TabStop = false;
            // 
            // tbImportante
            // 
            this.tbImportante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbImportante.Location = new System.Drawing.Point(20, 47);
            this.tbImportante.Multiline = true;
            this.tbImportante.Name = "tbImportante";
            this.tbImportante.ReadOnly = true;
            this.tbImportante.Size = new System.Drawing.Size(468, 123);
            this.tbImportante.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "IMPORTANTE:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbMision);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbVision);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(786, 179);
            this.splitContainer1.SplitterDistance = 383;
            this.splitContainer1.TabIndex = 28;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // tbMision
            // 
            this.tbMision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMision.Location = new System.Drawing.Point(9, 41);
            this.tbMision.Multiline = true;
            this.tbMision.Name = "tbMision";
            this.tbMision.ReadOnly = true;
            this.tbMision.Size = new System.Drawing.Size(357, 123);
            this.tbMision.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "MISIÓN:";
            // 
            // tbVision
            // 
            this.tbVision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVision.Location = new System.Drawing.Point(19, 41);
            this.tbVision.Multiline = true;
            this.tbVision.Name = "tbVision";
            this.tbVision.ReadOnly = true;
            this.tbVision.Size = new System.Drawing.Size(317, 123);
            this.tbVision.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "VISIÓN:";
            // 
            // VENTA
            // 
            this.VENTA.Controls.Add(this.flowLayoutPanel1);
            this.VENTA.Location = new System.Drawing.Point(4, 22);
            this.VENTA.Name = "VENTA";
            this.VENTA.Padding = new System.Windows.Forms.Padding(3);
            this.VENTA.Size = new System.Drawing.Size(792, 370);
            this.VENTA.TabIndex = 1;
            this.VENTA.Text = "VENTA";
            this.VENTA.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnFacturar);
            this.flowLayoutPanel1.Controls.Add(this.btnPedido);
            this.flowLayoutPanel1.Controls.Add(this.btnListaFac);
            this.flowLayoutPanel1.Controls.Add(this.btnListPed);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(746, 371);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackgroundImage = global::App_Portomadero.Properties.Resources.cuenta;
            this.btnFacturar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFacturar.FlatAppearance.BorderSize = 0;
            this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Location = new System.Drawing.Point(25, 5);
            this.btnFacturar.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(135, 180);
            this.btnFacturar.TabIndex = 29;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click_1);
            // 
            // btnPedido
            // 
            this.btnPedido.BackgroundImage = global::App_Portomadero.Properties.Resources.pedido_en_linea;
            this.btnPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPedido.FlatAppearance.BorderSize = 0;
            this.btnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.Location = new System.Drawing.Point(200, 5);
            this.btnPedido.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(135, 180);
            this.btnPedido.TabIndex = 30;
            this.btnPedido.Text = "Pedido";
            this.btnPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click_1);
            // 
            // btnListaFac
            // 
            this.btnListaFac.BackgroundImage = global::App_Portomadero.Properties.Resources.portafolio;
            this.btnListaFac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnListaFac.FlatAppearance.BorderSize = 0;
            this.btnListaFac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaFac.Location = new System.Drawing.Point(375, 5);
            this.btnListaFac.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnListaFac.Name = "btnListaFac";
            this.btnListaFac.Size = new System.Drawing.Size(135, 180);
            this.btnListaFac.TabIndex = 31;
            this.btnListaFac.Text = "Lista de facturas";
            this.btnListaFac.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListaFac.UseVisualStyleBackColor = true;
            this.btnListaFac.Click += new System.EventHandler(this.btnListaFac_Click_1);
            // 
            // btnListPed
            // 
            this.btnListPed.BackgroundImage = global::App_Portomadero.Properties.Resources.orden_aprobada;
            this.btnListPed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnListPed.FlatAppearance.BorderSize = 0;
            this.btnListPed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListPed.Location = new System.Drawing.Point(550, 5);
            this.btnListPed.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnListPed.Name = "btnListPed";
            this.btnListPed.Size = new System.Drawing.Size(135, 180);
            this.btnListPed.TabIndex = 32;
            this.btnListPed.Text = "Lista de pedidos";
            this.btnListPed.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListPed.UseVisualStyleBackColor = true;
            this.btnListPed.Click += new System.EventHandler(this.btnListPed_Click_1);
            // 
            // PERSONAL
            // 
            this.PERSONAL.Controls.Add(this.flowLayoutPanel2);
            this.PERSONAL.Location = new System.Drawing.Point(4, 22);
            this.PERSONAL.Name = "PERSONAL";
            this.PERSONAL.Size = new System.Drawing.Size(792, 370);
            this.PERSONAL.TabIndex = 2;
            this.PERSONAL.Text = "PERSONAL";
            this.PERSONAL.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel2.Controls.Add(this.btnEmpleados);
            this.flowLayoutPanel2.Controls.Add(this.btnCargos);
            this.flowLayoutPanel2.Controls.Add(this.btnUsuarios);
            this.flowLayoutPanel2.Controls.Add(this.btnClientes);
            this.flowLayoutPanel2.Controls.Add(this.btnRoles);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(747, 380);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackgroundImage = global::App_Portomadero.Properties.Resources.pasar;
            this.btnEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Location = new System.Drawing.Point(20, 0);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(135, 180);
            this.btnEmpleados.TabIndex = 31;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click_1);
            // 
            // btnCargos
            // 
            this.btnCargos.BackgroundImage = global::App_Portomadero.Properties.Resources.empleado;
            this.btnCargos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCargos.FlatAppearance.BorderSize = 0;
            this.btnCargos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargos.Location = new System.Drawing.Point(195, 0);
            this.btnCargos.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnCargos.Name = "btnCargos";
            this.btnCargos.Size = new System.Drawing.Size(135, 180);
            this.btnCargos.TabIndex = 35;
            this.btnCargos.Text = "Cargos";
            this.btnCargos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCargos.UseVisualStyleBackColor = true;
            this.btnCargos.Click += new System.EventHandler(this.btnCargos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackgroundImage = global::App_Portomadero.Properties.Resources.avatar;
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Location = new System.Drawing.Point(370, 0);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(135, 180);
            this.btnUsuarios.TabIndex = 34;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackgroundImage = global::App_Portomadero.Properties.Resources.comentarios_de_los_clientes;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(545, 0);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(135, 180);
            this.btnClientes.TabIndex = 32;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click_1);
            // 
            // btnRoles
            // 
            this.btnRoles.BackgroundImage = global::App_Portomadero.Properties.Resources.management;
            this.btnRoles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRoles.FlatAppearance.BorderSize = 0;
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoles.Location = new System.Drawing.Point(20, 180);
            this.btnRoles.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(135, 180);
            this.btnRoles.TabIndex = 33;
            this.btnRoles.Text = "Roles";
            this.btnRoles.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // INVENTARIO
            // 
            this.INVENTARIO.Controls.Add(this.flowLayoutPanel3);
            this.INVENTARIO.Location = new System.Drawing.Point(4, 22);
            this.INVENTARIO.Name = "INVENTARIO";
            this.INVENTARIO.Size = new System.Drawing.Size(792, 370);
            this.INVENTARIO.TabIndex = 3;
            this.INVENTARIO.Text = "INVENTARIO";
            this.INVENTARIO.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnProducto);
            this.flowLayoutPanel3.Controls.Add(this.btnInventario);
            this.flowLayoutPanel3.Controls.Add(this.btnCategorias);
            this.flowLayoutPanel3.Controls.Add(this.button6);
            this.flowLayoutPanel3.Controls.Add(this.btnIngredientes);
            this.flowLayoutPanel3.Controls.Add(this.btnReceta);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(792, 370);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // btnProducto
            // 
            this.btnProducto.BackgroundImage = global::App_Portomadero.Properties.Resources.caja;
            this.btnProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProducto.FlatAppearance.BorderSize = 0;
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.Location = new System.Drawing.Point(20, 0);
            this.btnProducto.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(135, 180);
            this.btnProducto.TabIndex = 30;
            this.btnProducto.Text = "Producto nuevo";
            this.btnProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click_1);
            // 
            // btnInventario
            // 
            this.btnInventario.BackgroundImage = global::App_Portomadero.Properties.Resources.inventario;
            this.btnInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.Location = new System.Drawing.Point(195, 0);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(135, 180);
            this.btnInventario.TabIndex = 31;
            this.btnInventario.Text = "Lista productos";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackgroundImage = global::App_Portomadero.Properties.Resources.afuera;
            this.btnCategorias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCategorias.FlatAppearance.BorderSize = 0;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.Location = new System.Drawing.Point(370, 0);
            this.btnCategorias.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(135, 180);
            this.btnCategorias.TabIndex = 32;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::App_Portomadero.Properties.Resources.lista_de_verificacion;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(545, 0);
            this.button6.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(135, 180);
            this.button6.TabIndex = 36;
            this.button6.Text = "Hacer inventario";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnIngredientes
            // 
            this.btnIngredientes.BackgroundImage = global::App_Portomadero.Properties.Resources.ingredientes;
            this.btnIngredientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIngredientes.FlatAppearance.BorderSize = 0;
            this.btnIngredientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngredientes.Location = new System.Drawing.Point(20, 180);
            this.btnIngredientes.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnIngredientes.Name = "btnIngredientes";
            this.btnIngredientes.Size = new System.Drawing.Size(135, 180);
            this.btnIngredientes.TabIndex = 33;
            this.btnIngredientes.Text = "Ingredientes";
            this.btnIngredientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIngredientes.UseVisualStyleBackColor = true;
            this.btnIngredientes.Click += new System.EventHandler(this.btnIngredientes_Click);
            // 
            // btnReceta
            // 
            this.btnReceta.BackgroundImage = global::App_Portomadero.Properties.Resources.libro_de_recetas;
            this.btnReceta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReceta.FlatAppearance.BorderSize = 0;
            this.btnReceta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceta.Location = new System.Drawing.Point(195, 180);
            this.btnReceta.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnReceta.Name = "btnReceta";
            this.btnReceta.Size = new System.Drawing.Size(135, 180);
            this.btnReceta.TabIndex = 34;
            this.btnReceta.Text = "Receta";
            this.btnReceta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReceta.UseVisualStyleBackColor = true;
            this.btnReceta.Click += new System.EventHandler(this.btnReceta_Click);
            // 
            // RESERVAS
            // 
            this.RESERVAS.Controls.Add(this.flowLayoutPanel4);
            this.RESERVAS.Location = new System.Drawing.Point(4, 22);
            this.RESERVAS.Name = "RESERVAS";
            this.RESERVAS.Size = new System.Drawing.Size(792, 370);
            this.RESERVAS.TabIndex = 4;
            this.RESERVAS.Text = "RESERVAS";
            this.RESERVAS.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.btnTurno);
            this.flowLayoutPanel4.Controls.Add(this.btnReserva);
            this.flowLayoutPanel4.Controls.Add(this.btnLista);
            this.flowLayoutPanel4.Controls.Add(this.btnMesas);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(749, 371);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // btnTurno
            // 
            this.btnTurno.BackgroundImage = global::App_Portomadero.Properties.Resources.configuraciones_de_la_cuenta;
            this.btnTurno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTurno.FlatAppearance.BorderSize = 0;
            this.btnTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurno.Location = new System.Drawing.Point(20, 0);
            this.btnTurno.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnTurno.Name = "btnTurno";
            this.btnTurno.Size = new System.Drawing.Size(160, 190);
            this.btnTurno.TabIndex = 33;
            this.btnTurno.Text = "Configurar reservas";
            this.btnTurno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTurno.UseVisualStyleBackColor = true;
            this.btnTurno.Click += new System.EventHandler(this.btnTurno_Click);
            // 
            // btnReserva
            // 
            this.btnReserva.BackgroundImage = global::App_Portomadero.Properties.Resources.reloj;
            this.btnReserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReserva.FlatAppearance.BorderSize = 0;
            this.btnReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserva.Location = new System.Drawing.Point(220, 0);
            this.btnReserva.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(135, 180);
            this.btnReserva.TabIndex = 30;
            this.btnReserva.Text = "Nueva reserva";
            this.btnReserva.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReserva.UseVisualStyleBackColor = true;
            this.btnReserva.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLista
            // 
            this.btnLista.BackgroundImage = global::App_Portomadero.Properties.Resources.fecha_del_calendario;
            this.btnLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLista.FlatAppearance.BorderSize = 0;
            this.btnLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLista.Location = new System.Drawing.Point(395, 0);
            this.btnLista.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(135, 180);
            this.btnLista.TabIndex = 31;
            this.btnLista.Text = "Reservas";
            this.btnLista.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnMesas
            // 
            this.btnMesas.BackgroundImage = global::App_Portomadero.Properties.Resources.mesa_del_comedor;
            this.btnMesas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMesas.FlatAppearance.BorderSize = 0;
            this.btnMesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesas.Location = new System.Drawing.Point(570, 0);
            this.btnMesas.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnMesas.Name = "btnMesas";
            this.btnMesas.Size = new System.Drawing.Size(135, 180);
            this.btnMesas.TabIndex = 32;
            this.btnMesas.Text = "Mesas";
            this.btnMesas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMesas.UseVisualStyleBackColor = true;
            this.btnMesas.Click += new System.EventHandler(this.btnMesas_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(792, 370);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "INFORMES";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.btnCostos);
            this.flowLayoutPanel5.Controls.Add(this.btnEmpresa);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(792, 370);
            this.flowLayoutPanel5.TabIndex = 2;
            // 
            // btnCostos
            // 
            this.btnCostos.BackgroundImage = global::App_Portomadero.Properties.Resources.centro_de_datos;
            this.btnCostos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCostos.FlatAppearance.BorderSize = 0;
            this.btnCostos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCostos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCostos.Location = new System.Drawing.Point(20, 0);
            this.btnCostos.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnCostos.Name = "btnCostos";
            this.btnCostos.Size = new System.Drawing.Size(135, 180);
            this.btnCostos.TabIndex = 36;
            this.btnCostos.Text = "Centros de costo";
            this.btnCostos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCostos.UseVisualStyleBackColor = true;
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.BackgroundImage = global::App_Portomadero.Properties.Resources.centro_de_datos;
            this.btnEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEmpresa.FlatAppearance.BorderSize = 0;
            this.btnEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpresa.Location = new System.Drawing.Point(195, 0);
            this.btnEmpresa.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(146, 180);
            this.btnEmpresa.TabIndex = 37;
            this.btnEmpresa.Text = "Datos de empresa";
            this.btnEmpresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpresa.UseVisualStyleBackColor = true;
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
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.VENTA.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.PERSONAL.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.INVENTARIO.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.RESERVAS.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTabControl tcControl;
        private System.Windows.Forms.TabPage HOME;
        private System.Windows.Forms.TabPage VENTA;
        private System.Windows.Forms.TabPage PERSONAL;
        private System.Windows.Forms.TabPage INVENTARIO;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TabPage RESERVAS;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbImportante;
        private System.Windows.Forms.TextBox tbMision;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVision;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnListPed;
        private System.Windows.Forms.Button btnListaFac;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnCargos;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnIngredientes;
        private System.Windows.Forms.Button btnReceta;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button btnReserva;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnMesas;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Button btnCostos;
        private System.Windows.Forms.Button btnTurno;
        private System.Windows.Forms.Button btnEmpresa;
    }
}