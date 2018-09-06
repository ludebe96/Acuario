namespace Acuario.Forms
{
    partial class FormHome
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelNavegacion = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCaja = new MetroFramework.Controls.MetroTile();
            this.btnPez = new MetroFramework.Controls.MetroTile();
            this.btnVentas = new MetroFramework.Controls.MetroTile();
            this.btnCompras = new MetroFramework.Controls.MetroTile();
            this.btnGastos = new MetroFramework.Controls.MetroTile();
            this.btnClientes = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnBalances = new MetroFramework.Controls.MetroButton();
            this.btnNavegacion = new MetroFramework.Controls.MetroButton();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.btnComprar = new MetroFramework.Controls.MetroButton();
            this.btnVender = new MetroFramework.Controls.MetroButton();
            this.labelVersion = new MetroFramework.Controls.MetroLabel();
            this.panelGridBalanceDia = new MetroFramework.Controls.MetroPanel();
            this.gridBalanceDia = new MetroFramework.Controls.MetroGrid();
            this.columnIngresosDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEgresosDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnBalanceDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelGridBalanceMes = new MetroFramework.Controls.MetroPanel();
            this.gridBalanceMes = new MetroFramework.Controls.MetroGrid();
            this.columnIngresosMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEgresosMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnBalanceMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBalances = new System.Windows.Forms.TableLayoutPanel();
            this.panelNavegacion.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.panelGridBalanceDia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBalanceDia)).BeginInit();
            this.panelGridBalanceMes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBalanceMes)).BeginInit();
            this.panelBalances.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavegacion
            // 
            this.panelNavegacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNavegacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNavegacion.Controls.Add(this.btnCaja);
            this.panelNavegacion.Controls.Add(this.btnPez);
            this.panelNavegacion.Controls.Add(this.btnVentas);
            this.panelNavegacion.Controls.Add(this.btnCompras);
            this.panelNavegacion.Controls.Add(this.btnGastos);
            this.panelNavegacion.Controls.Add(this.btnClientes);
            this.panelNavegacion.Location = new System.Drawing.Point(189, 63);
            this.panelNavegacion.Name = "panelNavegacion";
            this.panelNavegacion.Size = new System.Drawing.Size(492, 474);
            this.panelNavegacion.TabIndex = 0;
            // 
            // btnCaja
            // 
            this.btnCaja.ActiveControl = null;
            this.btnCaja.Location = new System.Drawing.Point(0, 0);
            this.btnCaja.Margin = new System.Windows.Forms.Padding(0);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(100, 100);
            this.btnCaja.TabIndex = 0;
            this.btnCaja.Text = "CAJA";
            this.btnCaja.TileImage = global::Acuario.Properties.Resources.caja;
            this.btnCaja.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCaja.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnCaja.UseSelectable = true;
            this.btnCaja.UseTileImage = true;
            this.btnCaja.Click += new System.EventHandler(this.btnCaja_Click);
            // 
            // btnPez
            // 
            this.btnPez.ActiveControl = null;
            this.btnPez.BackColor = System.Drawing.Color.Transparent;
            this.btnPez.Location = new System.Drawing.Point(100, 0);
            this.btnPez.Margin = new System.Windows.Forms.Padding(0);
            this.btnPez.Name = "btnPez";
            this.btnPez.Size = new System.Drawing.Size(100, 100);
            this.btnPez.TabIndex = 1;
            this.btnPez.Text = "PECES";
            this.btnPez.TileImage = global::Acuario.Properties.Resources.pez;
            this.btnPez.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPez.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnPez.UseSelectable = true;
            this.btnPez.UseTileImage = true;
            this.btnPez.Click += new System.EventHandler(this.btnPez_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.ActiveControl = null;
            this.btnVentas.Location = new System.Drawing.Point(200, 0);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(0);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(100, 100);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.Text = "VENTAS";
            this.btnVentas.TileImage = global::Acuario.Properties.Resources.venta;
            this.btnVentas.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVentas.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnVentas.UseSelectable = true;
            this.btnVentas.UseTileImage = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.ActiveControl = null;
            this.btnCompras.Location = new System.Drawing.Point(300, 0);
            this.btnCompras.Margin = new System.Windows.Forms.Padding(0);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(100, 100);
            this.btnCompras.TabIndex = 3;
            this.btnCompras.Text = "COMPRAS";
            this.btnCompras.TileImage = global::Acuario.Properties.Resources.compra;
            this.btnCompras.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCompras.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnCompras.UseSelectable = true;
            this.btnCompras.UseTileImage = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnGastos
            // 
            this.btnGastos.ActiveControl = null;
            this.btnGastos.Location = new System.Drawing.Point(0, 100);
            this.btnGastos.Margin = new System.Windows.Forms.Padding(0);
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.Size = new System.Drawing.Size(100, 100);
            this.btnGastos.TabIndex = 4;
            this.btnGastos.Text = "GASTOS";
            this.btnGastos.TileImage = global::Acuario.Properties.Resources.gasto;
            this.btnGastos.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGastos.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnGastos.UseSelectable = true;
            this.btnGastos.UseTileImage = true;
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.ActiveControl = null;
            this.btnClientes.Location = new System.Drawing.Point(100, 100);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(0);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(100, 100);
            this.btnClientes.TabIndex = 5;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.TileImage = global::Acuario.Properties.Resources.clientes;
            this.btnClientes.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClientes.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnClientes.UseSelectable = true;
            this.btnClientes.UseTileImage = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.btnBalances);
            this.metroPanel1.Controls.Add(this.btnNavegacion);
            this.metroPanel1.Controls.Add(this.btnSalir);
            this.metroPanel1.Controls.Add(this.btnComprar);
            this.metroPanel1.Controls.Add(this.btnVender);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(160, 474);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnBalances
            // 
            this.btnBalances.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBalances.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBalances.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnBalances.Location = new System.Drawing.Point(0, 35);
            this.btnBalances.Margin = new System.Windows.Forms.Padding(0);
            this.btnBalances.Name = "btnBalances";
            this.btnBalances.Size = new System.Drawing.Size(158, 35);
            this.btnBalances.TabIndex = 10;
            this.btnBalances.Text = "BALANCES";
            this.btnBalances.UseSelectable = true;
            this.btnBalances.Click += new System.EventHandler(this.btnBalances_Click);
            // 
            // btnNavegacion
            // 
            this.btnNavegacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavegacion.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnNavegacion.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnNavegacion.Location = new System.Drawing.Point(0, 0);
            this.btnNavegacion.Margin = new System.Windows.Forms.Padding(0);
            this.btnNavegacion.Name = "btnNavegacion";
            this.btnNavegacion.Size = new System.Drawing.Size(158, 35);
            this.btnNavegacion.TabIndex = 9;
            this.btnNavegacion.Text = "NAVEGACION";
            this.btnNavegacion.UseSelectable = true;
            this.btnNavegacion.Click += new System.EventHandler(this.btnNavegacion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSalir.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSalir.Location = new System.Drawing.Point(-1, 437);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(159, 35);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseSelectable = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComprar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnComprar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnComprar.Location = new System.Drawing.Point(-1, 138);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(0);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(159, 35);
            this.btnComprar.TabIndex = 7;
            this.btnComprar.Text = "COMPRAR";
            this.btnComprar.UseCustomForeColor = true;
            this.btnComprar.UseSelectable = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnVender
            // 
            this.btnVender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVender.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnVender.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnVender.Location = new System.Drawing.Point(0, 103);
            this.btnVender.Margin = new System.Windows.Forms.Padding(0);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(158, 35);
            this.btnVender.TabIndex = 6;
            this.btnVender.Text = "VENDER";
            this.btnVender.UseCustomForeColor = true;
            this.btnVender.UseSelectable = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersion.AutoSize = true;
            this.labelVersion.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelVersion.ForeColor = System.Drawing.Color.DarkGray;
            this.labelVersion.Location = new System.Drawing.Point(629, 540);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(43, 15);
            this.labelVersion.TabIndex = 3;
            this.labelVersion.Text = "v1.2.0.0";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelVersion.UseCustomForeColor = true;
            // 
            // panelGridBalanceDia
            // 
            this.panelGridBalanceDia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGridBalanceDia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGridBalanceDia.Controls.Add(this.gridBalanceDia);
            this.panelGridBalanceDia.HorizontalScrollbarBarColor = true;
            this.panelGridBalanceDia.HorizontalScrollbarHighlightOnWheel = false;
            this.panelGridBalanceDia.HorizontalScrollbarSize = 10;
            this.panelGridBalanceDia.Location = new System.Drawing.Point(4, 4);
            this.panelGridBalanceDia.Name = "panelGridBalanceDia";
            this.panelGridBalanceDia.Size = new System.Drawing.Size(484, 229);
            this.panelGridBalanceDia.TabIndex = 2;
            this.panelGridBalanceDia.VerticalScrollbarBarColor = true;
            this.panelGridBalanceDia.VerticalScrollbarHighlightOnWheel = false;
            this.panelGridBalanceDia.VerticalScrollbarSize = 10;
            // 
            // gridBalanceDia
            // 
            this.gridBalanceDia.AllowUserToAddRows = false;
            this.gridBalanceDia.AllowUserToDeleteRows = false;
            this.gridBalanceDia.AllowUserToResizeRows = false;
            this.gridBalanceDia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBalanceDia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridBalanceDia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridBalanceDia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridBalanceDia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBalanceDia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridBalanceDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBalanceDia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIngresosDia,
            this.columnEgresosDia,
            this.columnBalanceDia});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridBalanceDia.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridBalanceDia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBalanceDia.EnableHeadersVisualStyles = false;
            this.gridBalanceDia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridBalanceDia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridBalanceDia.Location = new System.Drawing.Point(0, 0);
            this.gridBalanceDia.Name = "gridBalanceDia";
            this.gridBalanceDia.ReadOnly = true;
            this.gridBalanceDia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBalanceDia.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridBalanceDia.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridBalanceDia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridBalanceDia.Size = new System.Drawing.Size(482, 227);
            this.gridBalanceDia.TabIndex = 3;
            this.gridBalanceDia.SelectionChanged += new System.EventHandler(this.gridBalanceDia_SelectionChanged);
            // 
            // columnIngresosDia
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnIngresosDia.DefaultCellStyle = dataGridViewCellStyle2;
            this.columnIngresosDia.HeaderText = "INGRESOS";
            this.columnIngresosDia.Name = "columnIngresosDia";
            this.columnIngresosDia.ReadOnly = true;
            // 
            // columnEgresosDia
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnEgresosDia.DefaultCellStyle = dataGridViewCellStyle3;
            this.columnEgresosDia.HeaderText = "EGRESOS";
            this.columnEgresosDia.Name = "columnEgresosDia";
            this.columnEgresosDia.ReadOnly = true;
            // 
            // columnBalanceDia
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnBalanceDia.DefaultCellStyle = dataGridViewCellStyle4;
            this.columnBalanceDia.HeaderText = "BALANCE";
            this.columnBalanceDia.Name = "columnBalanceDia";
            this.columnBalanceDia.ReadOnly = true;
            // 
            // panelGridBalanceMes
            // 
            this.panelGridBalanceMes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGridBalanceMes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGridBalanceMes.Controls.Add(this.gridBalanceMes);
            this.panelGridBalanceMes.HorizontalScrollbarBarColor = true;
            this.panelGridBalanceMes.HorizontalScrollbarHighlightOnWheel = false;
            this.panelGridBalanceMes.HorizontalScrollbarSize = 10;
            this.panelGridBalanceMes.Location = new System.Drawing.Point(4, 240);
            this.panelGridBalanceMes.Name = "panelGridBalanceMes";
            this.panelGridBalanceMes.Size = new System.Drawing.Size(484, 230);
            this.panelGridBalanceMes.TabIndex = 3;
            this.panelGridBalanceMes.VerticalScrollbarBarColor = true;
            this.panelGridBalanceMes.VerticalScrollbarHighlightOnWheel = false;
            this.panelGridBalanceMes.VerticalScrollbarSize = 10;
            // 
            // gridBalanceMes
            // 
            this.gridBalanceMes.AllowUserToAddRows = false;
            this.gridBalanceMes.AllowUserToDeleteRows = false;
            this.gridBalanceMes.AllowUserToResizeRows = false;
            this.gridBalanceMes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBalanceMes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridBalanceMes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridBalanceMes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridBalanceMes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBalanceMes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridBalanceMes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBalanceMes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIngresosMes,
            this.columnEgresosMes,
            this.columnBalanceMes});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridBalanceMes.DefaultCellStyle = dataGridViewCellStyle11;
            this.gridBalanceMes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBalanceMes.EnableHeadersVisualStyles = false;
            this.gridBalanceMes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridBalanceMes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridBalanceMes.Location = new System.Drawing.Point(0, 0);
            this.gridBalanceMes.Name = "gridBalanceMes";
            this.gridBalanceMes.ReadOnly = true;
            this.gridBalanceMes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBalanceMes.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gridBalanceMes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridBalanceMes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridBalanceMes.Size = new System.Drawing.Size(482, 228);
            this.gridBalanceMes.TabIndex = 4;
            this.gridBalanceMes.SelectionChanged += new System.EventHandler(this.gridBalanceMes_SelectionChanged);
            // 
            // columnIngresosMes
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnIngresosMes.DefaultCellStyle = dataGridViewCellStyle8;
            this.columnIngresosMes.HeaderText = "INGRESOS";
            this.columnIngresosMes.Name = "columnIngresosMes";
            this.columnIngresosMes.ReadOnly = true;
            // 
            // columnEgresosMes
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnEgresosMes.DefaultCellStyle = dataGridViewCellStyle9;
            this.columnEgresosMes.HeaderText = "EGRESOS";
            this.columnEgresosMes.Name = "columnEgresosMes";
            this.columnEgresosMes.ReadOnly = true;
            // 
            // columnBalanceMes
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnBalanceMes.DefaultCellStyle = dataGridViewCellStyle10;
            this.columnBalanceMes.HeaderText = "BALANCE";
            this.columnBalanceMes.Name = "columnBalanceMes";
            this.columnBalanceMes.ReadOnly = true;
            // 
            // panelBalances
            // 
            this.panelBalances.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBalances.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.panelBalances.ColumnCount = 1;
            this.panelBalances.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelBalances.Controls.Add(this.panelGridBalanceDia, 0, 0);
            this.panelBalances.Controls.Add(this.panelGridBalanceMes, 0, 1);
            this.panelBalances.Location = new System.Drawing.Point(189, 63);
            this.panelBalances.Name = "panelBalances";
            this.panelBalances.RowCount = 2;
            this.panelBalances.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelBalances.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelBalances.Size = new System.Drawing.Size(492, 474);
            this.panelBalances.TabIndex = 4;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 560);
            this.Controls.Add(this.panelNavegacion);
            this.Controls.Add(this.panelBalances);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.metroPanel1);
            this.MinimumSize = new System.Drawing.Size(704, 560);
            this.Name = "FormHome";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.panelNavegacion.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.panelGridBalanceDia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBalanceDia)).EndInit();
            this.panelGridBalanceMes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBalanceMes)).EndInit();
            this.panelBalances.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelNavegacion;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile btnCaja;
        private MetroFramework.Controls.MetroTile btnPez;
        private MetroFramework.Controls.MetroTile btnVentas;
        private MetroFramework.Controls.MetroTile btnCompras;
        private MetroFramework.Controls.MetroTile btnGastos;
        private MetroFramework.Controls.MetroTile btnClientes;
        private MetroFramework.Controls.MetroButton btnComprar;
        private MetroFramework.Controls.MetroButton btnVender;
        private MetroFramework.Controls.MetroButton btnSalir;
        private MetroFramework.Controls.MetroButton btnBalances;
        private MetroFramework.Controls.MetroButton btnNavegacion;
        private MetroFramework.Controls.MetroLabel labelVersion;
        private MetroFramework.Controls.MetroPanel panelGridBalanceMes;
        private MetroFramework.Controls.MetroPanel panelGridBalanceDia;
        private MetroFramework.Controls.MetroGrid gridBalanceMes;
        private MetroFramework.Controls.MetroGrid gridBalanceDia;
        private System.Windows.Forms.TableLayoutPanel panelBalances;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIngresosMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEgresosMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBalanceMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIngresosDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEgresosDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBalanceDia;
    }
}

