
namespace Login
{
    partial class ventanaPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.impVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtVentaEdit = new System.Windows.Forms.ToolStripTextBox();
            this.ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDescuentoEdit = new System.Windows.Forms.ToolStripTextBox();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rastrearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblPrecioSubtotal = new System.Windows.Forms.Label();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.txtClienteInfo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCantidadProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnumFactura = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.process1 = new System.Diagnostics.Process();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblitem1 = new System.Windows.Forms.Label();
            this.lblitem2 = new System.Windows.Forms.Label();
            this.lblImpVenta = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button1 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.horaFecha = new System.Windows.Forms.Timer(this.components);
            this.cmbDesc = new System.Windows.Forms.ComboBox();
            this.lblNameUsu = new System.Windows.Forms.Label();
            this.lblCi = new System.Windows.Forms.Label();
            this.dtgFacturacion = new System.Windows.Forms.DataGridView();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.materialContextMenuStrip2 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.pRruebaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialContextMenuStrip3 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblApeUsu = new System.Windows.Forms.Label();
            this.lblUsu = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFacturacion)).BeginInit();
            this.materialContextMenuStrip2.SuspendLayout();
            this.materialContextMenuStrip3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.usuariosToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.rastrearToolStripMenuItem,
            this.registroInventarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 403);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItem1.Text = "Ajustes";
            this.toolStripMenuItem1.Visible = false;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AutoSize = false;
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impVentaToolStripMenuItem,
            this.ToolStrip});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Im. Venta y descuentos";
            // 
            // impVentaToolStripMenuItem
            // 
            this.impVentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtVentaEdit});
            this.impVentaToolStripMenuItem.Name = "impVentaToolStripMenuItem";
            this.impVentaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.impVentaToolStripMenuItem.Text = "Imp. Venta";
            // 
            // txtVentaEdit
            // 
            this.txtVentaEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtVentaEdit.Name = "txtVentaEdit";
            this.txtVentaEdit.Size = new System.Drawing.Size(100, 23);
            this.txtVentaEdit.Text = "0";
            this.txtVentaEdit.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            this.txtVentaEdit.TextChanged += new System.EventHandler(this.txtVentaEdit_TextChanged);
            // 
            // ToolStrip
            // 
            this.ToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtDescuentoEdit});
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(130, 22);
            this.ToolStrip.Text = "Descuento";
            // 
            // txtDescuentoEdit
            // 
            this.txtDescuentoEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescuentoEdit.Name = "txtDescuentoEdit";
            this.txtDescuentoEdit.Size = new System.Drawing.Size(100, 23);
            this.txtDescuentoEdit.Text = "0";
            this.txtDescuentoEdit.Click += new System.EventHandler(this.toolStripTextBox2_Click);
            this.txtDescuentoEdit.TextChanged += new System.EventHandler(this.txtDescuentoEdit_TextChanged);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // rastrearToolStripMenuItem
            // 
            this.rastrearToolStripMenuItem.Name = "rastrearToolStripMenuItem";
            this.rastrearToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.rastrearToolStripMenuItem.Text = "Rastrear";
            this.rastrearToolStripMenuItem.Click += new System.EventHandler(this.rastrearToolStripMenuItem_Click);
            // 
            // registroInventarioToolStripMenuItem
            // 
            this.registroInventarioToolStripMenuItem.Name = "registroInventarioToolStripMenuItem";
            this.registroInventarioToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.registroInventarioToolStripMenuItem.Text = "Registro inventario";
            this.registroInventarioToolStripMenuItem.Visible = false;
            this.registroInventarioToolStripMenuItem.Click += new System.EventHandler(this.registroInventarioToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo producto:";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(465, 306);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(112, 20);
            this.txtCodigoProducto.TabIndex = 24;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(164)))), ((int)(((byte)(245)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(465, 334);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 56);
            this.btnAgregar.TabIndex = 26;
            this.btnAgregar.Text = "Agregar producto";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPrecioSubtotal
            // 
            this.lblPrecioSubtotal.AutoSize = true;
            this.lblPrecioSubtotal.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioSubtotal.Location = new System.Drawing.Point(19, 18);
            this.lblPrecioSubtotal.Name = "lblPrecioSubtotal";
            this.lblPrecioSubtotal.Size = new System.Drawing.Size(57, 28);
            this.lblPrecioSubtotal.TabIndex = 7;
            this.lblPrecioSubtotal.Text = "0.00";
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioTotal.Location = new System.Drawing.Point(12, 17);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(57, 28);
            this.lblPrecioTotal.TabIndex = 9;
            this.lblPrecioTotal.Text = "0.00";
            // 
            // txtClienteInfo
            // 
            this.txtClienteInfo.Location = new System.Drawing.Point(718, 30);
            this.txtClienteInfo.Multiline = true;
            this.txtClienteInfo.Name = "txtClienteInfo";
            this.txtClienteInfo.ReadOnly = true;
            this.txtClienteInfo.Size = new System.Drawing.Size(117, 19);
            this.txtClienteInfo.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(164)))), ((int)(((byte)(245)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(679, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 113);
            this.button2.TabIndex = 27;
            this.button2.Text = "Realizar compra";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.Location = new System.Drawing.Point(592, 306);
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.Size = new System.Drawing.Size(71, 20);
            this.txtCantidadProducto.TabIndex = 25;
            this.txtCantidadProducto.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(589, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cantidad";
            // 
            // txtnumFactura
            // 
            this.txtnumFactura.Location = new System.Drawing.Point(302, 30);
            this.txtnumFactura.Multiline = true;
            this.txtnumFactura.Name = "txtnumFactura";
            this.txtnumFactura.ReadOnly = true;
            this.txtnumFactura.Size = new System.Drawing.Size(76, 20);
            this.txtnumFactura.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(460, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Imp. Venta";
            this.label7.Visible = false;
            // 
            // txtVenta
            // 
            this.txtVenta.Location = new System.Drawing.Point(529, 32);
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.Size = new System.Drawing.Size(31, 20);
            this.txtVenta.TabIndex = 18;
            this.txtVenta.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Descuento";
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(45, 208);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(98, 17);
            this.lblCliente.TabIndex = 21;
            this.lblCliente.Text = "COD Cliente : ";
            this.lblCliente.Click += new System.EventHandler(this.lblCliente_Click);
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(48, 228);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(91, 20);
            this.txtCodigoCliente.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(928, 462);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "%";
            this.label10.Visible = false;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(48, 251);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(91, 27);
            this.btnBuscarCliente.TabIndex = 23;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // lblitem1
            // 
            this.lblitem1.AutoSize = true;
            this.lblitem1.Location = new System.Drawing.Point(50, 366);
            this.lblitem1.Name = "lblitem1";
            this.lblitem1.Size = new System.Drawing.Size(42, 13);
            this.lblitem1.TabIndex = 26;
            this.lblitem1.Text = "lblitem1";
            this.lblitem1.Visible = false;
            // 
            // lblitem2
            // 
            this.lblitem2.AutoSize = true;
            this.lblitem2.Location = new System.Drawing.Point(208, 356);
            this.lblitem2.Name = "lblitem2";
            this.lblitem2.Size = new System.Drawing.Size(42, 13);
            this.lblitem2.TabIndex = 27;
            this.lblitem2.Text = "lblitem2";
            this.lblitem2.Visible = false;
            // 
            // lblImpVenta
            // 
            this.lblImpVenta.AutoSize = true;
            this.lblImpVenta.Location = new System.Drawing.Point(103, 342);
            this.lblImpVenta.Name = "lblImpVenta";
            this.lblImpVenta.Size = new System.Drawing.Size(62, 13);
            this.lblImpVenta.TabIndex = 28;
            this.lblImpVenta.Text = "lblImpVenta";
            this.lblImpVenta.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Imprimir);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(164)))), ((int)(((byte)(245)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(592, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 56);
            this.button1.TabIndex = 29;
            this.button1.Text = "Vista previa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // horaFecha
            // 
            this.horaFecha.Enabled = true;
            this.horaFecha.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cmbDesc
            // 
            this.cmbDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesc.FormattingEnabled = true;
            this.cmbDesc.Items.AddRange(new object[] {
            "5%",
            "10%",
            "15%",
            "0%"});
            this.cmbDesc.Location = new System.Drawing.Point(393, 303);
            this.cmbDesc.Name = "cmbDesc";
            this.cmbDesc.Size = new System.Drawing.Size(48, 21);
            this.cmbDesc.TabIndex = 30;
            this.cmbDesc.SelectedIndexChanged += new System.EventHandler(this.cmbDesc_SelectedIndexChanged);
            // 
            // lblNameUsu
            // 
            this.lblNameUsu.AutoSize = true;
            this.lblNameUsu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameUsu.ForeColor = System.Drawing.Color.White;
            this.lblNameUsu.Location = new System.Drawing.Point(5, 25);
            this.lblNameUsu.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.lblNameUsu.Name = "lblNameUsu";
            this.lblNameUsu.Size = new System.Drawing.Size(58, 17);
            this.lblNameUsu.TabIndex = 31;
            this.lblNameUsu.Text = "Nombre";
            this.lblNameUsu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCi
            // 
            this.lblCi.AutoSize = true;
            this.lblCi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCi.ForeColor = System.Drawing.Color.White;
            this.lblCi.Location = new System.Drawing.Point(39, 107);
            this.lblCi.Name = "lblCi";
            this.lblCi.Size = new System.Drawing.Size(22, 17);
            this.lblCi.TabIndex = 32;
            this.lblCi.Text = "Ci:";
            // 
            // dtgFacturacion
            // 
            this.dtgFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFacturacion.Location = new System.Drawing.Point(182, 70);
            this.dtgFacturacion.Name = "dtgFacturacion";
            this.dtgFacturacion.ReadOnly = true;
            this.dtgFacturacion.Size = new System.Drawing.Size(661, 190);
            this.dtgFacturacion.TabIndex = 5;
            this.dtgFacturacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFacturacion_CellContentClick);
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // materialContextMenuStrip2
            // 
            this.materialContextMenuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip2.Depth = 0;
            this.materialContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pRruebaToolStripMenuItem});
            this.materialContextMenuStrip2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip2.Name = "materialContextMenuStrip2";
            this.materialContextMenuStrip2.Size = new System.Drawing.Size(119, 26);
            // 
            // pRruebaToolStripMenuItem
            // 
            this.pRruebaToolStripMenuItem.Name = "pRruebaToolStripMenuItem";
            this.pRruebaToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.pRruebaToolStripMenuItem.Text = "PRrueba";
            // 
            // materialContextMenuStrip3
            // 
            this.materialContextMenuStrip3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip3.Depth = 0;
            this.materialContextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.materialContextMenuStrip3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip3.Name = "materialContextMenuStrip3";
            this.materialContextMenuStrip3.Size = new System.Drawing.Size(181, 48);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "toolStripMenuItem4";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(164)))), ((int)(((byte)(245)))));
            this.groupBox1.Controls.Add(this.lblApeUsu);
            this.groupBox1.Controls.Add(this.lblUsu);
            this.groupBox1.Controls.Add(this.lblNameUsu);
            this.groupBox1.Controls.Add(this.lblCi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(19, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 136);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS:";
            // 
            // lblApeUsu
            // 
            this.lblApeUsu.AutoSize = true;
            this.lblApeUsu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblApeUsu.ForeColor = System.Drawing.Color.White;
            this.lblApeUsu.Location = new System.Drawing.Point(6, 51);
            this.lblApeUsu.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.lblApeUsu.Name = "lblApeUsu";
            this.lblApeUsu.Size = new System.Drawing.Size(57, 17);
            this.lblApeUsu.TabIndex = 34;
            this.lblApeUsu.Text = "Apellido";
            this.lblApeUsu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUsu
            // 
            this.lblUsu.AutoSize = true;
            this.lblUsu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblUsu.ForeColor = System.Drawing.Color.White;
            this.lblUsu.Location = new System.Drawing.Point(9, 77);
            this.lblUsu.Name = "lblUsu";
            this.lblUsu.Size = new System.Drawing.Size(54, 17);
            this.lblUsu.TabIndex = 33;
            this.lblUsu.Text = "Usuario";
            this.lblUsu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(202, 31);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(91, 19);
            this.materialLabel1.TabIndex = 37;
            this.materialLabel1.Text = "No. Factura:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(642, 29);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(64, 19);
            this.materialLabel2.TabIndex = 38;
            this.materialLabel2.Text = "Cliente: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPrecioSubtotal);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(211, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(95, 54);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SUBTOTAL:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblPrecioTotal);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(339, 340);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(85, 59);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "TOTAL:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(130, 365);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(35, 13);
            this.lblFecha.TabIndex = 41;
            this.lblFecha.Text = "label2";
            this.lblFecha.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(51, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 23);
            this.button3.TabIndex = 42;
            this.button3.Text = "Clientes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(164)))), ((int)(((byte)(245)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(776, 277);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 113);
            this.button4.TabIndex = 28;
            this.button4.Text = "Limpiar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(164)))), ((int)(((byte)(245)))));
            this.panel1.Location = new System.Drawing.Point(10, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 152);
            this.panel1.TabIndex = 35;
            // 
            // ventanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 427);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cmbDesc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblImpVenta);
            this.Controls.Add(this.lblitem2);
            this.Controls.Add(this.lblitem1);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCodigoCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtVenta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtnumFactura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCantidadProducto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtClienteInfo);
            this.Controls.Add(this.dtgFacturacion);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCodigoProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ventanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta - Empresa XYZ";
            this.Load += new System.EventHandler(this.ventanaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFacturacion)).EndInit();
            this.materialContextMenuStrip2.ResumeLayout(false);
            this.materialContextMenuStrip3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroInventarioToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblPrecioSubtotal;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.TextBox txtClienteInfo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCantidadProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnumFactura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVenta;
        private System.Windows.Forms.Label label8;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ToolStripMenuItem impVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtVentaEdit;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip;
        private System.Windows.Forms.ToolStripTextBox txtDescuentoEdit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblitem1;
        private System.Windows.Forms.Label lblitem2;
        private System.Windows.Forms.Label lblImpVenta;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Timer horaFecha;
        private System.Windows.Forms.ComboBox cmbDesc;
        public System.Windows.Forms.Label lblCi;
        public System.Windows.Forms.Label lblNameUsu;
        private System.Windows.Forms.DataGridView dtgFacturacion;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem pRruebaToolStripMenuItem;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Label lblUsu;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        public System.Windows.Forms.Label lblApeUsu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem rastrearToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}