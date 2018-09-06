namespace Acuario.Forms
{
    partial class FormVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.textboxNombre = new MetroFramework.Controls.MetroTextBox();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.panelGrid = new MetroFramework.Controls.MetroPanel();
            this.gridVentas = new MetroFramework.Controls.MetroGrid();
            this.columnIdVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNroVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnVerDetalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.columnVerFactura = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dateTimeHasta = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dateTimeDesde = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnDetalles = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.textboxNroVenta = new MetroFramework.Controls.MetroTextBox();
            this.btnDeshacerVenta = new MetroFramework.Controls.MetroButton();
            this.btnVender = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.labelSubtotal = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVentas)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(363, 58);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(64, 25);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Cliente";
            // 
            // textboxNombre
            // 
            // 
            // 
            // 
            this.textboxNombre.CustomButton.Image = null;
            this.textboxNombre.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.textboxNombre.CustomButton.Name = "";
            this.textboxNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxNombre.CustomButton.TabIndex = 1;
            this.textboxNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxNombre.CustomButton.UseSelectable = true;
            this.textboxNombre.CustomButton.Visible = false;
            this.textboxNombre.Lines = new string[0];
            this.textboxNombre.Location = new System.Drawing.Point(433, 63);
            this.textboxNombre.MaxLength = 32767;
            this.textboxNombre.Name = "textboxNombre";
            this.textboxNombre.PasswordChar = '\0';
            this.textboxNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxNombre.SelectedText = "";
            this.textboxNombre.SelectionLength = 0;
            this.textboxNombre.SelectionStart = 0;
            this.textboxNombre.ShortcutsEnabled = true;
            this.textboxNombre.Size = new System.Drawing.Size(140, 23);
            this.textboxNombre.TabIndex = 15;
            this.textboxNombre.UseSelectable = true;
            this.textboxNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textboxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxNombre_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBuscar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnBuscar.Location = new System.Drawing.Point(684, 91);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 29);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrid.Controls.Add(this.gridVentas);
            this.panelGrid.HorizontalScrollbarBarColor = true;
            this.panelGrid.HorizontalScrollbarHighlightOnWheel = false;
            this.panelGrid.HorizontalScrollbarSize = 10;
            this.panelGrid.Location = new System.Drawing.Point(23, 126);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(781, 203);
            this.panelGrid.TabIndex = 17;
            this.panelGrid.VerticalScrollbarBarColor = true;
            this.panelGrid.VerticalScrollbarHighlightOnWheel = false;
            this.panelGrid.VerticalScrollbarSize = 10;
            // 
            // gridVentas
            // 
            this.gridVentas.AllowUserToAddRows = false;
            this.gridVentas.AllowUserToDeleteRows = false;
            this.gridVentas.AllowUserToResizeRows = false;
            this.gridVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIdVenta,
            this.columnIdCuenta,
            this.columnIdCliente,
            this.columnNroVenta,
            this.columnCuenta,
            this.columnCliente,
            this.columnTotal,
            this.columnFechaHora,
            this.columnVerDetalle,
            this.columnVerFactura});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridVentas.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridVentas.EnableHeadersVisualStyles = false;
            this.gridVentas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridVentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridVentas.Location = new System.Drawing.Point(0, 0);
            this.gridVentas.MultiSelect = false;
            this.gridVentas.Name = "gridVentas";
            this.gridVentas.ReadOnly = true;
            this.gridVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridVentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridVentas.Size = new System.Drawing.Size(779, 201);
            this.gridVentas.TabIndex = 2;
            this.gridVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridVentas_CellContentClick);
            // 
            // columnIdVenta
            // 
            this.columnIdVenta.HeaderText = "ID VENTA";
            this.columnIdVenta.Name = "columnIdVenta";
            this.columnIdVenta.ReadOnly = true;
            this.columnIdVenta.Visible = false;
            this.columnIdVenta.Width = 76;
            // 
            // columnIdCuenta
            // 
            this.columnIdCuenta.HeaderText = "ID CUENTA";
            this.columnIdCuenta.Name = "columnIdCuenta";
            this.columnIdCuenta.ReadOnly = true;
            this.columnIdCuenta.Visible = false;
            this.columnIdCuenta.Width = 84;
            // 
            // columnIdCliente
            // 
            this.columnIdCliente.HeaderText = "ID CLIENTE";
            this.columnIdCliente.Name = "columnIdCliente";
            this.columnIdCliente.ReadOnly = true;
            this.columnIdCliente.Visible = false;
            this.columnIdCliente.Width = 84;
            // 
            // columnNroVenta
            // 
            this.columnNroVenta.HeaderText = "NRO VENTA";
            this.columnNroVenta.Name = "columnNroVenta";
            this.columnNroVenta.ReadOnly = true;
            this.columnNroVenta.Width = 89;
            // 
            // columnCuenta
            // 
            this.columnCuenta.HeaderText = "CUENTA";
            this.columnCuenta.Name = "columnCuenta";
            this.columnCuenta.ReadOnly = true;
            this.columnCuenta.Width = 70;
            // 
            // columnCliente
            // 
            this.columnCliente.HeaderText = "CLIENTE";
            this.columnCliente.Name = "columnCliente";
            this.columnCliente.ReadOnly = true;
            this.columnCliente.Width = 70;
            // 
            // columnTotal
            // 
            this.columnTotal.HeaderText = "TOTAL";
            this.columnTotal.Name = "columnTotal";
            this.columnTotal.ReadOnly = true;
            this.columnTotal.Width = 59;
            // 
            // columnFechaHora
            // 
            this.columnFechaHora.HeaderText = "FECHA HORA";
            this.columnFechaHora.Name = "columnFechaHora";
            this.columnFechaHora.ReadOnly = true;
            this.columnFechaHora.Width = 98;
            // 
            // columnVerDetalle
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.columnVerDetalle.DefaultCellStyle = dataGridViewCellStyle2;
            this.columnVerDetalle.HeaderText = "";
            this.columnVerDetalle.Name = "columnVerDetalle";
            this.columnVerDetalle.ReadOnly = true;
            this.columnVerDetalle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnVerDetalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columnVerDetalle.Text = "";
            this.columnVerDetalle.Width = 17;
            // 
            // columnVerFactura
            // 
            this.columnVerFactura.HeaderText = "";
            this.columnVerFactura.Name = "columnVerFactura";
            this.columnVerFactura.ReadOnly = true;
            this.columnVerFactura.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnVerFactura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columnVerFactura.Width = 17;
            // 
            // dateTimeHasta
            // 
            this.dateTimeHasta.Location = new System.Drawing.Point(433, 92);
            this.dateTimeHasta.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimeHasta.Name = "dateTimeHasta";
            this.dateTimeHasta.Size = new System.Drawing.Size(239, 29);
            this.dateTimeHasta.TabIndex = 13;
            this.dateTimeHasta.ValueChanged += new System.EventHandler(this.dateTimeHasta_ValueChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(363, 95);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 25);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Hasta";
            // 
            // dateTimeDesde
            // 
            this.dateTimeDesde.Location = new System.Drawing.Point(118, 92);
            this.dateTimeDesde.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimeDesde.Name = "dateTimeDesde";
            this.dateTimeDesde.Size = new System.Drawing.Size(239, 29);
            this.dateTimeDesde.TabIndex = 11;
            this.dateTimeDesde.ValueChanged += new System.EventHandler(this.dateTimeDesde_ValueChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(24, 95);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 25);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Desde";
            // 
            // btnDetalles
            // 
            this.btnDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetalles.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDetalles.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnDetalles.Location = new System.Drawing.Point(639, 367);
            this.btnDetalles.Margin = new System.Windows.Forms.Padding(0);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(165, 30);
            this.btnDetalles.TabIndex = 32;
            this.btnDetalles.Text = "Detalles";
            this.btnDetalles.UseSelectable = true;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(24, 58);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(88, 25);
            this.metroLabel4.TabIndex = 34;
            this.metroLabel4.Text = "Nro Venta";
            // 
            // textboxNroVenta
            // 
            // 
            // 
            // 
            this.textboxNroVenta.CustomButton.Image = null;
            this.textboxNroVenta.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.textboxNroVenta.CustomButton.Name = "";
            this.textboxNroVenta.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxNroVenta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxNroVenta.CustomButton.TabIndex = 1;
            this.textboxNroVenta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxNroVenta.CustomButton.UseSelectable = true;
            this.textboxNroVenta.CustomButton.Visible = false;
            this.textboxNroVenta.Lines = new string[0];
            this.textboxNroVenta.Location = new System.Drawing.Point(118, 62);
            this.textboxNroVenta.MaxLength = 32767;
            this.textboxNroVenta.Name = "textboxNroVenta";
            this.textboxNroVenta.PasswordChar = '\0';
            this.textboxNroVenta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxNroVenta.SelectedText = "";
            this.textboxNroVenta.SelectionLength = 0;
            this.textboxNroVenta.SelectionStart = 0;
            this.textboxNroVenta.ShortcutsEnabled = true;
            this.textboxNroVenta.Size = new System.Drawing.Size(140, 23);
            this.textboxNroVenta.TabIndex = 33;
            this.textboxNroVenta.UseSelectable = true;
            this.textboxNroVenta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxNroVenta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textboxNroVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxNroVenta_KeyPress);
            // 
            // btnDeshacerVenta
            // 
            this.btnDeshacerVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeshacerVenta.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDeshacerVenta.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDeshacerVenta.Location = new System.Drawing.Point(23, 367);
            this.btnDeshacerVenta.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeshacerVenta.Name = "btnDeshacerVenta";
            this.btnDeshacerVenta.Size = new System.Drawing.Size(165, 30);
            this.btnDeshacerVenta.TabIndex = 35;
            this.btnDeshacerVenta.Text = "Deshacer venta";
            this.btnDeshacerVenta.UseCustomForeColor = true;
            this.btnDeshacerVenta.UseSelectable = true;
            this.btnDeshacerVenta.Click += new System.EventHandler(this.btnDeshacerVenta_Click);
            // 
            // btnVender
            // 
            this.btnVender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVender.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnVender.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnVender.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnVender.Location = new System.Drawing.Point(474, 367);
            this.btnVender.Margin = new System.Windows.Forms.Padding(0);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(165, 30);
            this.btnVender.TabIndex = 36;
            this.btnVender.Text = "VENDER";
            this.btnVender.UseCustomForeColor = true;
            this.btnVender.UseSelectable = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.labelSubtotal);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 335);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(781, 29);
            this.metroPanel1.TabIndex = 37;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSubtotal.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelSubtotal.Location = new System.Drawing.Point(423, 2);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(353, 25);
            this.labelSubtotal.TabIndex = 3;
            this.labelSubtotal.Text = "$0,00";
            this.labelSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(3, 2);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(94, 25);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "SUBTOTAL:";
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 425);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.btnDeshacerVenta);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.textboxNroVenta);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.dateTimeHasta);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.dateTimeDesde);
            this.Controls.Add(this.textboxNombre);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnBuscar);
            this.MinimumSize = new System.Drawing.Size(829, 425);
            this.Name = "FormVentas";
            this.Text = "Ventas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormVentas_FormClosed);
            this.Load += new System.EventHandler(this.FormVentas_Load);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridVentas)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox textboxNombre;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroPanel panelGrid;
        private MetroFramework.Controls.MetroGrid gridVentas;
        private MetroFramework.Controls.MetroDateTime dateTimeHasta;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime dateTimeDesde;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnDetalles;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox textboxNroVenta;
        private MetroFramework.Controls.MetroButton btnDeshacerVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNroVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFechaHora;
        private System.Windows.Forms.DataGridViewButtonColumn columnVerDetalle;
        private System.Windows.Forms.DataGridViewButtonColumn columnVerFactura;
        private MetroFramework.Controls.MetroButton btnVender;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel labelSubtotal;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}