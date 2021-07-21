namespace Dashboard
{
    partial class Form1
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
            this.panelSlideMenu = new System.Windows.Forms.Panel();
            this.panelVentas = new System.Windows.Forms.Panel();
            this.btnDocumentoVenta = new System.Windows.Forms.Button();
            this.btnGuiaSalida = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.panelCompras = new System.Windows.Forms.Panel();
            this.btnGuiaEntrada = new System.Windows.Forms.Button();
            this.btnFacturaCompra = new System.Windows.Forms.Button();
            this.btnCotizaciones = new System.Windows.Forms.Button();
            this.btnOrdenCompra = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.panelAlmacen = new System.Windows.Forms.Panel();
            this.btnGenerarInventario = new System.Windows.Forms.Button();
            this.btnProductosFaltantes = new System.Windows.Forms.Button();
            this.btnAlmacen = new System.Windows.Forms.Button();
            this.panelReportes = new System.Windows.Forms.Panel();
            this.btnListarProveedores = new System.Windows.Forms.Button();
            this.btnListarClientes = new System.Windows.Forms.Button();
            this.btnVentasMensuales = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnsettings = new System.Windows.Forms.Button();
            this.btnDashbord = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbltitle = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panelSlideMenu.SuspendLayout();
            this.panelVentas.SuspendLayout();
            this.panelCompras.SuspendLayout();
            this.panelAlmacen.SuspendLayout();
            this.panelReportes.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSlideMenu
            // 
            this.panelSlideMenu.AutoScroll = true;
            this.panelSlideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelSlideMenu.Controls.Add(this.panelVentas);
            this.panelSlideMenu.Controls.Add(this.btnVentas);
            this.panelSlideMenu.Controls.Add(this.panelCompras);
            this.panelSlideMenu.Controls.Add(this.btnCompras);
            this.panelSlideMenu.Controls.Add(this.panelAlmacen);
            this.panelSlideMenu.Controls.Add(this.btnAlmacen);
            this.panelSlideMenu.Controls.Add(this.panelReportes);
            this.panelSlideMenu.Controls.Add(this.pnlNav);
            this.panelSlideMenu.Controls.Add(this.btnsettings);
            this.panelSlideMenu.Controls.Add(this.btnDashbord);
            this.panelSlideMenu.Controls.Add(this.panel2);
            this.panelSlideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSlideMenu.Name = "panelSlideMenu";
            this.panelSlideMenu.Size = new System.Drawing.Size(189, 600);
            this.panelSlideMenu.TabIndex = 0;
            // 
            // panelVentas
            // 
            this.panelVentas.Controls.Add(this.btnDocumentoVenta);
            this.panelVentas.Controls.Add(this.btnGuiaSalida);
            this.panelVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVentas.Location = new System.Drawing.Point(0, 706);
            this.panelVentas.Name = "panelVentas";
            this.panelVentas.Size = new System.Drawing.Size(172, 86);
            this.panelVentas.TabIndex = 19;
            // 
            // btnDocumentoVenta
            // 
            this.btnDocumentoVenta.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDocumentoVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocumentoVenta.FlatAppearance.BorderSize = 0;
            this.btnDocumentoVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocumentoVenta.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDocumentoVenta.Location = new System.Drawing.Point(0, 42);
            this.btnDocumentoVenta.Name = "btnDocumentoVenta";
            this.btnDocumentoVenta.Size = new System.Drawing.Size(172, 42);
            this.btnDocumentoVenta.TabIndex = 2;
            this.btnDocumentoVenta.Text = "Documento Venta";
            this.btnDocumentoVenta.UseVisualStyleBackColor = false;
            this.btnDocumentoVenta.Click += new System.EventHandler(this.btnDocumentoVenta_Click);
            // 
            // btnGuiaSalida
            // 
            this.btnGuiaSalida.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGuiaSalida.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuiaSalida.FlatAppearance.BorderSize = 0;
            this.btnGuiaSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuiaSalida.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnGuiaSalida.Location = new System.Drawing.Point(0, 0);
            this.btnGuiaSalida.Name = "btnGuiaSalida";
            this.btnGuiaSalida.Size = new System.Drawing.Size(172, 42);
            this.btnGuiaSalida.TabIndex = 1;
            this.btnGuiaSalida.Text = "Guia Salida";
            this.btnGuiaSalida.UseVisualStyleBackColor = false;
            this.btnGuiaSalida.Click += new System.EventHandler(this.btnGuiaSalida_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnVentas.Image = global::Dashboard.Properties.Resources.home;
            this.btnVentas.Location = new System.Drawing.Point(0, 664);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(172, 42);
            this.btnVentas.TabIndex = 18;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentasClick);
            this.btnVentas.Leave += new System.EventHandler(this.btnVentasLeave);
            // 
            // panelCompras
            // 
            this.panelCompras.Controls.Add(this.btnGuiaEntrada);
            this.panelCompras.Controls.Add(this.btnFacturaCompra);
            this.panelCompras.Controls.Add(this.btnCotizaciones);
            this.panelCompras.Controls.Add(this.btnOrdenCompra);
            this.panelCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCompras.Location = new System.Drawing.Point(0, 494);
            this.panelCompras.Name = "panelCompras";
            this.panelCompras.Size = new System.Drawing.Size(172, 170);
            this.panelCompras.TabIndex = 17;
            // 
            // btnGuiaEntrada
            // 
            this.btnGuiaEntrada.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGuiaEntrada.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuiaEntrada.FlatAppearance.BorderSize = 0;
            this.btnGuiaEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuiaEntrada.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnGuiaEntrada.Location = new System.Drawing.Point(0, 126);
            this.btnGuiaEntrada.Name = "btnGuiaEntrada";
            this.btnGuiaEntrada.Size = new System.Drawing.Size(172, 42);
            this.btnGuiaEntrada.TabIndex = 5;
            this.btnGuiaEntrada.Text = "Guia de Entrada";
            this.btnGuiaEntrada.UseVisualStyleBackColor = false;
            this.btnGuiaEntrada.Click += new System.EventHandler(this.btnGuiaEntrada_Click);
            // 
            // btnFacturaCompra
            // 
            this.btnFacturaCompra.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFacturaCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacturaCompra.FlatAppearance.BorderSize = 0;
            this.btnFacturaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturaCompra.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnFacturaCompra.Location = new System.Drawing.Point(0, 84);
            this.btnFacturaCompra.Name = "btnFacturaCompra";
            this.btnFacturaCompra.Size = new System.Drawing.Size(172, 42);
            this.btnFacturaCompra.TabIndex = 4;
            this.btnFacturaCompra.Text = "Factura de Compra";
            this.btnFacturaCompra.UseVisualStyleBackColor = false;
            this.btnFacturaCompra.Click += new System.EventHandler(this.btnFacturaCompra_Click);
            // 
            // btnCotizaciones
            // 
            this.btnCotizaciones.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCotizaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCotizaciones.FlatAppearance.BorderSize = 0;
            this.btnCotizaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCotizaciones.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCotizaciones.Location = new System.Drawing.Point(0, 42);
            this.btnCotizaciones.Name = "btnCotizaciones";
            this.btnCotizaciones.Size = new System.Drawing.Size(172, 42);
            this.btnCotizaciones.TabIndex = 3;
            this.btnCotizaciones.Text = "Cotizaciones";
            this.btnCotizaciones.UseVisualStyleBackColor = false;
            this.btnCotizaciones.Click += new System.EventHandler(this.btnCotizaciones_Click);
            // 
            // btnOrdenCompra
            // 
            this.btnOrdenCompra.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOrdenCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrdenCompra.FlatAppearance.BorderSize = 0;
            this.btnOrdenCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenCompra.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnOrdenCompra.Location = new System.Drawing.Point(0, 0);
            this.btnOrdenCompra.Name = "btnOrdenCompra";
            this.btnOrdenCompra.Size = new System.Drawing.Size(172, 42);
            this.btnOrdenCompra.TabIndex = 1;
            this.btnOrdenCompra.Text = "Orden de Compra";
            this.btnOrdenCompra.UseVisualStyleBackColor = false;
            this.btnOrdenCompra.Click += new System.EventHandler(this.btnOrdenCompra_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCompras.Image = global::Dashboard.Properties.Resources.home;
            this.btnCompras.Location = new System.Drawing.Point(0, 452);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(172, 42);
            this.btnCompras.TabIndex = 16;
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnComprasClick);
            this.btnCompras.Leave += new System.EventHandler(this.btnComprasLeave);
            // 
            // panelAlmacen
            // 
            this.panelAlmacen.Controls.Add(this.btnGenerarInventario);
            this.panelAlmacen.Controls.Add(this.btnProductosFaltantes);
            this.panelAlmacen.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAlmacen.Location = new System.Drawing.Point(0, 364);
            this.panelAlmacen.Name = "panelAlmacen";
            this.panelAlmacen.Size = new System.Drawing.Size(172, 88);
            this.panelAlmacen.TabIndex = 15;
            // 
            // btnGenerarInventario
            // 
            this.btnGenerarInventario.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGenerarInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenerarInventario.FlatAppearance.BorderSize = 0;
            this.btnGenerarInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarInventario.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnGenerarInventario.Location = new System.Drawing.Point(0, 42);
            this.btnGenerarInventario.Name = "btnGenerarInventario";
            this.btnGenerarInventario.Size = new System.Drawing.Size(172, 42);
            this.btnGenerarInventario.TabIndex = 2;
            this.btnGenerarInventario.Text = "Generar Inventario";
            this.btnGenerarInventario.UseVisualStyleBackColor = false;
            this.btnGenerarInventario.Click += new System.EventHandler(this.btnGenerarInventario_Click);
            // 
            // btnProductosFaltantes
            // 
            this.btnProductosFaltantes.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnProductosFaltantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductosFaltantes.FlatAppearance.BorderSize = 0;
            this.btnProductosFaltantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductosFaltantes.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnProductosFaltantes.Location = new System.Drawing.Point(0, 0);
            this.btnProductosFaltantes.Name = "btnProductosFaltantes";
            this.btnProductosFaltantes.Size = new System.Drawing.Size(172, 42);
            this.btnProductosFaltantes.TabIndex = 1;
            this.btnProductosFaltantes.Text = "Productos Faltantes";
            this.btnProductosFaltantes.UseVisualStyleBackColor = false;
            this.btnProductosFaltantes.Click += new System.EventHandler(this.btnProductosFaltantes_Click);
            // 
            // btnAlmacen
            // 
            this.btnAlmacen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlmacen.FlatAppearance.BorderSize = 0;
            this.btnAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlmacen.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlmacen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAlmacen.Image = global::Dashboard.Properties.Resources.home;
            this.btnAlmacen.Location = new System.Drawing.Point(0, 322);
            this.btnAlmacen.Name = "btnAlmacen";
            this.btnAlmacen.Size = new System.Drawing.Size(172, 42);
            this.btnAlmacen.TabIndex = 14;
            this.btnAlmacen.Text = "Almacen";
            this.btnAlmacen.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAlmacen.UseVisualStyleBackColor = true;
            this.btnAlmacen.Click += new System.EventHandler(this.btnAlmacenClick);
            this.btnAlmacen.Leave += new System.EventHandler(this.btnAlmacenLeave);
            // 
            // panelReportes
            // 
            this.panelReportes.Controls.Add(this.btnListarProveedores);
            this.panelReportes.Controls.Add(this.btnListarClientes);
            this.panelReportes.Controls.Add(this.btnVentasMensuales);
            this.panelReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReportes.Location = new System.Drawing.Point(0, 193);
            this.panelReportes.Name = "panelReportes";
            this.panelReportes.Size = new System.Drawing.Size(172, 129);
            this.panelReportes.TabIndex = 13;
            // 
            // btnListarProveedores
            // 
            this.btnListarProveedores.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnListarProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListarProveedores.FlatAppearance.BorderSize = 0;
            this.btnListarProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarProveedores.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnListarProveedores.Location = new System.Drawing.Point(0, 84);
            this.btnListarProveedores.Name = "btnListarProveedores";
            this.btnListarProveedores.Size = new System.Drawing.Size(172, 42);
            this.btnListarProveedores.TabIndex = 2;
            this.btnListarProveedores.Text = "Listar Proveedores";
            this.btnListarProveedores.UseVisualStyleBackColor = false;
            this.btnListarProveedores.Click += new System.EventHandler(this.btnListarProveedores_Click);
            // 
            // btnListarClientes
            // 
            this.btnListarClientes.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnListarClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListarClientes.FlatAppearance.BorderSize = 0;
            this.btnListarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarClientes.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnListarClientes.Location = new System.Drawing.Point(0, 42);
            this.btnListarClientes.Name = "btnListarClientes";
            this.btnListarClientes.Size = new System.Drawing.Size(172, 42);
            this.btnListarClientes.TabIndex = 1;
            this.btnListarClientes.Text = "Listar Clientes";
            this.btnListarClientes.UseVisualStyleBackColor = false;
            this.btnListarClientes.Click += new System.EventHandler(this.btnListarClientes_Click);
            // 
            // btnVentasMensuales
            // 
            this.btnVentasMensuales.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVentasMensuales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentasMensuales.FlatAppearance.BorderSize = 0;
            this.btnVentasMensuales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentasMensuales.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnVentasMensuales.Location = new System.Drawing.Point(0, 0);
            this.btnVentasMensuales.Name = "btnVentasMensuales";
            this.btnVentasMensuales.Size = new System.Drawing.Size(172, 42);
            this.btnVentasMensuales.TabIndex = 0;
            this.btnVentasMensuales.Text = "Ventas Mensuales";
            this.btnVentasMensuales.UseVisualStyleBackColor = false;
            this.btnVentasMensuales.Click += new System.EventHandler(this.btnVentasMensuales_Click);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 193);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 2;
            // 
            // btnsettings
            // 
            this.btnsettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnsettings.FlatAppearance.BorderSize = 0;
            this.btnsettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsettings.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnsettings.Image = global::Dashboard.Properties.Resources.settings;
            this.btnsettings.Location = new System.Drawing.Point(0, 792);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Size = new System.Drawing.Size(172, 42);
            this.btnsettings.TabIndex = 1;
            this.btnsettings.Text = "Settings";
            this.btnsettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnsettings.UseVisualStyleBackColor = true;
            this.btnsettings.Click += new System.EventHandler(this.btnsettings_Click);
            this.btnsettings.Leave += new System.EventHandler(this.btnsettings_Leave);
            // 
            // btnDashbord
            // 
            this.btnDashbord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashbord.FlatAppearance.BorderSize = 0;
            this.btnDashbord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashbord.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashbord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDashbord.Image = global::Dashboard.Properties.Resources.home;
            this.btnDashbord.Location = new System.Drawing.Point(0, 151);
            this.btnDashbord.Name = "btnDashbord";
            this.btnDashbord.Size = new System.Drawing.Size(172, 42);
            this.btnDashbord.TabIndex = 1;
            this.btnDashbord.Text = "Reportes";
            this.btnDashbord.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDashbord.UseVisualStyleBackColor = true;
            this.btnDashbord.Click += new System.EventHandler(this.btnDashbord_Click);
            this.btnDashbord.Leave += new System.EventHandler(this.btnDashbord_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblUser);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 151);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(33, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Some User Text Here";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblUser.Location = new System.Drawing.Point(48, 97);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(41, 16);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dashboard.Properties.Resources.Untitled_11;
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1150, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 12;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbltitle.Location = new System.Drawing.Point(280, 13);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(163, 32);
            this.lbltitle.TabIndex = 10;
            this.lbltitle.Text = "Dashboard";
            // 
            // panelChildForm
            // 
            this.panelChildForm.Location = new System.Drawing.Point(203, 74);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(972, 504);
            this.panelChildForm.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(213, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 41);
            this.button2.TabIndex = 14;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.panelSlideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSlideMenu.ResumeLayout(false);
            this.panelVentas.ResumeLayout(false);
            this.panelCompras.ResumeLayout(false);
            this.panelAlmacen.ResumeLayout(false);
            this.panelReportes.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSlideMenu;
        private System.Windows.Forms.Button btnDashbord;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnsettings;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel panelVentas;
        private System.Windows.Forms.Button btnDocumentoVenta;
        private System.Windows.Forms.Button btnGuiaSalida;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Panel panelCompras;
        private System.Windows.Forms.Button btnGuiaEntrada;
        private System.Windows.Forms.Button btnFacturaCompra;
        private System.Windows.Forms.Button btnCotizaciones;
        private System.Windows.Forms.Button btnOrdenCompra;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Panel panelAlmacen;
        private System.Windows.Forms.Button btnGenerarInventario;
        private System.Windows.Forms.Button btnProductosFaltantes;
        private System.Windows.Forms.Button btnAlmacen;
        private System.Windows.Forms.Panel panelReportes;
        private System.Windows.Forms.Button btnListarProveedores;
        private System.Windows.Forms.Button btnListarClientes;
        private System.Windows.Forms.Button btnVentasMensuales;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button button2;
    }
}

