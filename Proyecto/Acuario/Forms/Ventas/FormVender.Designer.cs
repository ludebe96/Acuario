namespace Acuario.Forms
{
    partial class FormVender
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.panelSubtotal = new MetroFramework.Controls.MetroPanel();
            this.labelTotal = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.btnRemover = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnSeleccionarCuenta = new MetroFramework.Controls.MetroButton();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.textboxCuenta = new MetroFramework.Controls.MetroTextBox();
            this.btnSeleccionarCliente = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.textboxCliente = new MetroFramework.Controls.MetroTextBox();
            this.panelGrid = new MetroFramework.Controls.MetroPanel();
            this.gridItems = new MetroFramework.Controls.MetroGrid();
            this.columnIdPez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrecioDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarItem = new MetroFramework.Controls.MetroButton();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.rBtnOtro = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.textboxOtro = new MetroFramework.Controls.MetroTextBox();
            this.rBtnDistribuidor = new MetroFramework.Controls.MetroRadioButton();
            this.rBtnOferta = new MetroFramework.Controls.MetroRadioButton();
            this.rBtnMayorista = new MetroFramework.Controls.MetroRadioButton();
            this.rBtnMinorista = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.textboxDistribuidor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.textboxOferta = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.textboxMayorista = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.textboxMinorista = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.textboxCantidad = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.textboxPez = new MetroFramework.Controls.MetroTextBox();
            this.btnSeleccionarPez = new MetroFramework.Controls.MetroButton();
            this.btnGenerarVenta = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.checkBoxImprimir = new MetroFramework.Controls.MetroCheckBox();
            this.metroPanel1.SuspendLayout();
            this.panelSubtotal.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).BeginInit();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.panelSubtotal);
            this.metroPanel1.Controls.Add(this.btnRemover);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Controls.Add(this.panelGrid);
            this.metroPanel1.Controls.Add(this.btnAgregarItem);
            this.metroPanel1.Controls.Add(this.metroPanel3);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(799, 464);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // panelSubtotal
            // 
            this.panelSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSubtotal.Controls.Add(this.labelTotal);
            this.panelSubtotal.Controls.Add(this.metroLabel10);
            this.panelSubtotal.HorizontalScrollbarBarColor = true;
            this.panelSubtotal.HorizontalScrollbarHighlightOnWheel = false;
            this.panelSubtotal.HorizontalScrollbarSize = 10;
            this.panelSubtotal.Location = new System.Drawing.Point(399, 394);
            this.panelSubtotal.Name = "panelSubtotal";
            this.panelSubtotal.Size = new System.Drawing.Size(394, 30);
            this.panelSubtotal.TabIndex = 22;
            this.panelSubtotal.VerticalScrollbarBarColor = true;
            this.panelSubtotal.VerticalScrollbarHighlightOnWheel = false;
            this.panelSubtotal.VerticalScrollbarSize = 10;
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotal.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelTotal.Location = new System.Drawing.Point(72, 3);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(317, 25);
            this.labelTotal.TabIndex = 24;
            this.labelTotal.Text = "$0,00";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.Location = new System.Drawing.Point(3, 3);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(63, 25);
            this.metroLabel10.TabIndex = 23;
            this.metroLabel10.Text = "TOTAL:";
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemover.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnRemover.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRemover.Location = new System.Drawing.Point(676, 427);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(118, 30);
            this.btnRemover.TabIndex = 20;
            this.btnRemover.Text = "Remover Item";
            this.btnRemover.UseCustomForeColor = true;
            this.btnRemover.UseSelectable = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.btnSeleccionarCuenta);
            this.metroPanel2.Controls.Add(this.metroLabel9);
            this.metroPanel2.Controls.Add(this.textboxCuenta);
            this.metroPanel2.Controls.Add(this.btnSeleccionarCliente);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.textboxCliente);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 3);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(392, 104);
            this.metroPanel2.TabIndex = 18;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnSeleccionarCuenta
            // 
            this.btnSeleccionarCuenta.Location = new System.Drawing.Point(250, 17);
            this.btnSeleccionarCuenta.Name = "btnSeleccionarCuenta";
            this.btnSeleccionarCuenta.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionarCuenta.TabIndex = 23;
            this.btnSeleccionarCuenta.Text = "Seleccionar";
            this.btnSeleccionarCuenta.UseSelectable = true;
            this.btnSeleccionarCuenta.Click += new System.EventHandler(this.btnSeleccionarCuenta_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.Location = new System.Drawing.Point(20, 44);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(64, 25);
            this.metroLabel9.TabIndex = 22;
            this.metroLabel9.Text = "Cliente";
            // 
            // textboxCuenta
            // 
            // 
            // 
            // 
            this.textboxCuenta.CustomButton.Image = null;
            this.textboxCuenta.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.textboxCuenta.CustomButton.Name = "";
            this.textboxCuenta.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxCuenta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxCuenta.CustomButton.TabIndex = 1;
            this.textboxCuenta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxCuenta.CustomButton.UseSelectable = true;
            this.textboxCuenta.CustomButton.Visible = false;
            this.textboxCuenta.Enabled = false;
            this.textboxCuenta.Lines = new string[0];
            this.textboxCuenta.Location = new System.Drawing.Point(104, 17);
            this.textboxCuenta.MaxLength = 32767;
            this.textboxCuenta.Name = "textboxCuenta";
            this.textboxCuenta.PasswordChar = '\0';
            this.textboxCuenta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxCuenta.SelectedText = "";
            this.textboxCuenta.SelectionLength = 0;
            this.textboxCuenta.SelectionStart = 0;
            this.textboxCuenta.ShortcutsEnabled = true;
            this.textboxCuenta.Size = new System.Drawing.Size(140, 23);
            this.textboxCuenta.TabIndex = 21;
            this.textboxCuenta.UseSelectable = true;
            this.textboxCuenta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxCuenta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(250, 46);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionarCliente.TabIndex = 20;
            this.btnSeleccionarCliente.Text = "Seleccionar";
            this.btnSeleccionarCliente.UseSelectable = true;
            this.btnSeleccionarCliente.Click += new System.EventHandler(this.btnSeleccionarCliente_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(20, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 25);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Cuenta";
            // 
            // textboxCliente
            // 
            // 
            // 
            // 
            this.textboxCliente.CustomButton.Image = null;
            this.textboxCliente.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.textboxCliente.CustomButton.Name = "";
            this.textboxCliente.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxCliente.CustomButton.TabIndex = 1;
            this.textboxCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxCliente.CustomButton.UseSelectable = true;
            this.textboxCliente.CustomButton.Visible = false;
            this.textboxCliente.Enabled = false;
            this.textboxCliente.Lines = new string[0];
            this.textboxCliente.Location = new System.Drawing.Point(104, 46);
            this.textboxCliente.MaxLength = 32767;
            this.textboxCliente.Name = "textboxCliente";
            this.textboxCliente.PasswordChar = '\0';
            this.textboxCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxCliente.SelectedText = "";
            this.textboxCliente.SelectionLength = 0;
            this.textboxCliente.SelectionStart = 0;
            this.textboxCliente.ShortcutsEnabled = true;
            this.textboxCliente.Size = new System.Drawing.Size(140, 23);
            this.textboxCliente.TabIndex = 18;
            this.textboxCliente.UseSelectable = true;
            this.textboxCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panelGrid
            // 
            this.panelGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrid.Controls.Add(this.gridItems);
            this.panelGrid.HorizontalScrollbarBarColor = true;
            this.panelGrid.HorizontalScrollbarHighlightOnWheel = false;
            this.panelGrid.HorizontalScrollbarSize = 10;
            this.panelGrid.Location = new System.Drawing.Point(398, 3);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(396, 388);
            this.panelGrid.TabIndex = 21;
            this.panelGrid.VerticalScrollbarBarColor = true;
            this.panelGrid.VerticalScrollbarHighlightOnWheel = false;
            this.panelGrid.VerticalScrollbarSize = 10;
            // 
            // gridItems
            // 
            this.gridItems.AllowUserToAddRows = false;
            this.gridItems.AllowUserToDeleteRows = false;
            this.gridItems.AllowUserToResizeRows = false;
            this.gridItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIdPez,
            this.columnIdPrecio,
            this.columnPez,
            this.columnPrecio,
            this.columnPrecioDesc,
            this.columnCantidad,
            this.columnSubtotal});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridItems.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridItems.EnableHeadersVisualStyles = false;
            this.gridItems.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridItems.Location = new System.Drawing.Point(0, 0);
            this.gridItems.Name = "gridItems";
            this.gridItems.ReadOnly = true;
            this.gridItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridItems.Size = new System.Drawing.Size(394, 386);
            this.gridItems.TabIndex = 17;
            // 
            // columnIdPez
            // 
            this.columnIdPez.HeaderText = "ID PEZ";
            this.columnIdPez.Name = "columnIdPez";
            this.columnIdPez.ReadOnly = true;
            this.columnIdPez.Visible = false;
            this.columnIdPez.Width = 62;
            // 
            // columnIdPrecio
            // 
            this.columnIdPrecio.HeaderText = "ID PRECIO";
            this.columnIdPrecio.Name = "columnIdPrecio";
            this.columnIdPrecio.ReadOnly = true;
            this.columnIdPrecio.Visible = false;
            this.columnIdPrecio.Width = 82;
            // 
            // columnPez
            // 
            this.columnPez.HeaderText = "PEZ";
            this.columnPez.Name = "columnPez";
            this.columnPez.ReadOnly = true;
            this.columnPez.Width = 48;
            // 
            // columnPrecio
            // 
            this.columnPrecio.HeaderText = "PRECIO";
            this.columnPrecio.Name = "columnPrecio";
            this.columnPrecio.ReadOnly = true;
            this.columnPrecio.Width = 68;
            // 
            // columnPrecioDesc
            // 
            this.columnPrecioDesc.HeaderText = "PRECIO DESC";
            this.columnPrecioDesc.Name = "columnPrecioDesc";
            this.columnPrecioDesc.ReadOnly = true;
            this.columnPrecioDesc.Width = 98;
            // 
            // columnCantidad
            // 
            this.columnCantidad.HeaderText = "CANTIDAD";
            this.columnCantidad.Name = "columnCantidad";
            this.columnCantidad.ReadOnly = true;
            this.columnCantidad.Width = 83;
            // 
            // columnSubtotal
            // 
            this.columnSubtotal.HeaderText = "SUBTOTAL";
            this.columnSubtotal.Name = "columnSubtotal";
            this.columnSubtotal.ReadOnly = true;
            this.columnSubtotal.Width = 80;
            // 
            // btnAgregarItem
            // 
            this.btnAgregarItem.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAgregarItem.Location = new System.Drawing.Point(4, 393);
            this.btnAgregarItem.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregarItem.Name = "btnAgregarItem";
            this.btnAgregarItem.Size = new System.Drawing.Size(392, 30);
            this.btnAgregarItem.TabIndex = 20;
            this.btnAgregarItem.Text = "Agregar a la Venta >>";
            this.btnAgregarItem.UseSelectable = true;
            this.btnAgregarItem.Click += new System.EventHandler(this.btnAgregarItem_Click);
            // 
            // metroPanel3
            // 
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.rBtnOtro);
            this.metroPanel3.Controls.Add(this.metroLabel11);
            this.metroPanel3.Controls.Add(this.textboxOtro);
            this.metroPanel3.Controls.Add(this.rBtnDistribuidor);
            this.metroPanel3.Controls.Add(this.rBtnOferta);
            this.metroPanel3.Controls.Add(this.rBtnMayorista);
            this.metroPanel3.Controls.Add(this.rBtnMinorista);
            this.metroPanel3.Controls.Add(this.metroLabel8);
            this.metroPanel3.Controls.Add(this.textboxDistribuidor);
            this.metroPanel3.Controls.Add(this.metroLabel7);
            this.metroPanel3.Controls.Add(this.textboxOferta);
            this.metroPanel3.Controls.Add(this.metroLabel6);
            this.metroPanel3.Controls.Add(this.textboxMayorista);
            this.metroPanel3.Controls.Add(this.metroLabel5);
            this.metroPanel3.Controls.Add(this.metroLabel4);
            this.metroPanel3.Controls.Add(this.textboxMinorista);
            this.metroPanel3.Controls.Add(this.metroLabel2);
            this.metroPanel3.Controls.Add(this.textboxCantidad);
            this.metroPanel3.Controls.Add(this.metroLabel3);
            this.metroPanel3.Controls.Add(this.textboxPez);
            this.metroPanel3.Controls.Add(this.btnSeleccionarPez);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(3, 113);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(392, 277);
            this.metroPanel3.TabIndex = 18;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // rBtnOtro
            // 
            this.rBtnOtro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rBtnOtro.AutoSize = true;
            this.rBtnOtro.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rBtnOtro.Location = new System.Drawing.Point(284, 232);
            this.rBtnOtro.Name = "rBtnOtro";
            this.rBtnOtro.Size = new System.Drawing.Size(29, 19);
            this.rBtnOtro.TabIndex = 34;
            this.rBtnOtro.Text = " ";
            this.rBtnOtro.UseSelectable = true;
            this.rBtnOtro.CheckedChanged += new System.EventHandler(this.rBtnOtro_CheckedChanged);
            // 
            // metroLabel11
            // 
            this.metroLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.Location = new System.Drawing.Point(20, 230);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(51, 25);
            this.metroLabel11.TabIndex = 33;
            this.metroLabel11.Text = "Otro:";
            // 
            // textboxOtro
            // 
            this.textboxOtro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.textboxOtro.CustomButton.Image = null;
            this.textboxOtro.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.textboxOtro.CustomButton.Name = "";
            this.textboxOtro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxOtro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxOtro.CustomButton.TabIndex = 1;
            this.textboxOtro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxOtro.CustomButton.UseSelectable = true;
            this.textboxOtro.CustomButton.Visible = false;
            this.textboxOtro.Enabled = false;
            this.textboxOtro.Lines = new string[0];
            this.textboxOtro.Location = new System.Drawing.Point(138, 232);
            this.textboxOtro.MaxLength = 32767;
            this.textboxOtro.Name = "textboxOtro";
            this.textboxOtro.PasswordChar = '\0';
            this.textboxOtro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxOtro.SelectedText = "";
            this.textboxOtro.SelectionLength = 0;
            this.textboxOtro.SelectionStart = 0;
            this.textboxOtro.ShortcutsEnabled = true;
            this.textboxOtro.Size = new System.Drawing.Size(140, 23);
            this.textboxOtro.TabIndex = 32;
            this.textboxOtro.UseSelectable = true;
            this.textboxOtro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxOtro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rBtnDistribuidor
            // 
            this.rBtnDistribuidor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rBtnDistribuidor.AutoSize = true;
            this.rBtnDistribuidor.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rBtnDistribuidor.Location = new System.Drawing.Point(284, 203);
            this.rBtnDistribuidor.Name = "rBtnDistribuidor";
            this.rBtnDistribuidor.Size = new System.Drawing.Size(29, 19);
            this.rBtnDistribuidor.TabIndex = 31;
            this.rBtnDistribuidor.Text = " ";
            this.rBtnDistribuidor.UseSelectable = true;
            this.rBtnDistribuidor.CheckedChanged += new System.EventHandler(this.rBtnDistribuidor_CheckedChanged);
            // 
            // rBtnOferta
            // 
            this.rBtnOferta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rBtnOferta.AutoSize = true;
            this.rBtnOferta.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rBtnOferta.Location = new System.Drawing.Point(284, 174);
            this.rBtnOferta.Name = "rBtnOferta";
            this.rBtnOferta.Size = new System.Drawing.Size(29, 19);
            this.rBtnOferta.TabIndex = 30;
            this.rBtnOferta.Text = " ";
            this.rBtnOferta.UseSelectable = true;
            this.rBtnOferta.CheckedChanged += new System.EventHandler(this.rBtnOferta_CheckedChanged);
            // 
            // rBtnMayorista
            // 
            this.rBtnMayorista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rBtnMayorista.AutoSize = true;
            this.rBtnMayorista.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rBtnMayorista.Location = new System.Drawing.Point(284, 145);
            this.rBtnMayorista.Name = "rBtnMayorista";
            this.rBtnMayorista.Size = new System.Drawing.Size(29, 19);
            this.rBtnMayorista.TabIndex = 29;
            this.rBtnMayorista.Text = " ";
            this.rBtnMayorista.UseSelectable = true;
            this.rBtnMayorista.CheckedChanged += new System.EventHandler(this.rBtnMayorista_CheckedChanged);
            // 
            // rBtnMinorista
            // 
            this.rBtnMinorista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rBtnMinorista.AutoSize = true;
            this.rBtnMinorista.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rBtnMinorista.Location = new System.Drawing.Point(284, 116);
            this.rBtnMinorista.Name = "rBtnMinorista";
            this.rBtnMinorista.Size = new System.Drawing.Size(29, 19);
            this.rBtnMinorista.TabIndex = 28;
            this.rBtnMinorista.Text = " ";
            this.rBtnMinorista.UseSelectable = true;
            this.rBtnMinorista.CheckedChanged += new System.EventHandler(this.rBtnMinorista_CheckedChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(20, 201);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(95, 25);
            this.metroLabel8.TabIndex = 27;
            this.metroLabel8.Text = "Proveedor:";
            // 
            // textboxDistribuidor
            // 
            this.textboxDistribuidor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.textboxDistribuidor.CustomButton.Image = null;
            this.textboxDistribuidor.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.textboxDistribuidor.CustomButton.Name = "";
            this.textboxDistribuidor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxDistribuidor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxDistribuidor.CustomButton.TabIndex = 1;
            this.textboxDistribuidor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxDistribuidor.CustomButton.UseSelectable = true;
            this.textboxDistribuidor.CustomButton.Visible = false;
            this.textboxDistribuidor.Enabled = false;
            this.textboxDistribuidor.Lines = new string[0];
            this.textboxDistribuidor.Location = new System.Drawing.Point(138, 203);
            this.textboxDistribuidor.MaxLength = 32767;
            this.textboxDistribuidor.Name = "textboxDistribuidor";
            this.textboxDistribuidor.PasswordChar = '\0';
            this.textboxDistribuidor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxDistribuidor.SelectedText = "";
            this.textboxDistribuidor.SelectionLength = 0;
            this.textboxDistribuidor.SelectionStart = 0;
            this.textboxDistribuidor.ShortcutsEnabled = true;
            this.textboxDistribuidor.Size = new System.Drawing.Size(140, 23);
            this.textboxDistribuidor.TabIndex = 26;
            this.textboxDistribuidor.UseSelectable = true;
            this.textboxDistribuidor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxDistribuidor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(20, 172);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(65, 25);
            this.metroLabel7.TabIndex = 25;
            this.metroLabel7.Text = "Oferta:";
            // 
            // textboxOferta
            // 
            this.textboxOferta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.textboxOferta.CustomButton.Image = null;
            this.textboxOferta.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.textboxOferta.CustomButton.Name = "";
            this.textboxOferta.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxOferta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxOferta.CustomButton.TabIndex = 1;
            this.textboxOferta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxOferta.CustomButton.UseSelectable = true;
            this.textboxOferta.CustomButton.Visible = false;
            this.textboxOferta.Enabled = false;
            this.textboxOferta.Lines = new string[0];
            this.textboxOferta.Location = new System.Drawing.Point(138, 174);
            this.textboxOferta.MaxLength = 32767;
            this.textboxOferta.Name = "textboxOferta";
            this.textboxOferta.PasswordChar = '\0';
            this.textboxOferta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxOferta.SelectedText = "";
            this.textboxOferta.SelectionLength = 0;
            this.textboxOferta.SelectionStart = 0;
            this.textboxOferta.ShortcutsEnabled = true;
            this.textboxOferta.Size = new System.Drawing.Size(140, 23);
            this.textboxOferta.TabIndex = 24;
            this.textboxOferta.UseSelectable = true;
            this.textboxOferta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxOferta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(20, 143);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(89, 25);
            this.metroLabel6.TabIndex = 23;
            this.metroLabel6.Text = "Mayorista:";
            // 
            // textboxMayorista
            // 
            this.textboxMayorista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.textboxMayorista.CustomButton.Image = null;
            this.textboxMayorista.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.textboxMayorista.CustomButton.Name = "";
            this.textboxMayorista.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxMayorista.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxMayorista.CustomButton.TabIndex = 1;
            this.textboxMayorista.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxMayorista.CustomButton.UseSelectable = true;
            this.textboxMayorista.CustomButton.Visible = false;
            this.textboxMayorista.Enabled = false;
            this.textboxMayorista.Lines = new string[0];
            this.textboxMayorista.Location = new System.Drawing.Point(138, 145);
            this.textboxMayorista.MaxLength = 32767;
            this.textboxMayorista.Name = "textboxMayorista";
            this.textboxMayorista.PasswordChar = '\0';
            this.textboxMayorista.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxMayorista.SelectedText = "";
            this.textboxMayorista.SelectionLength = 0;
            this.textboxMayorista.SelectionStart = 0;
            this.textboxMayorista.ShortcutsEnabled = true;
            this.textboxMayorista.Size = new System.Drawing.Size(140, 23);
            this.textboxMayorista.TabIndex = 22;
            this.textboxMayorista.UseSelectable = true;
            this.textboxMayorista.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxMayorista.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(20, 114);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(86, 25);
            this.metroLabel5.TabIndex = 21;
            this.metroLabel5.Text = "Minorista:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(92, 88);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(124, 25);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Precio Unitario";
            // 
            // textboxMinorista
            // 
            this.textboxMinorista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.textboxMinorista.CustomButton.Image = null;
            this.textboxMinorista.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.textboxMinorista.CustomButton.Name = "";
            this.textboxMinorista.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxMinorista.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxMinorista.CustomButton.TabIndex = 1;
            this.textboxMinorista.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxMinorista.CustomButton.UseSelectable = true;
            this.textboxMinorista.CustomButton.Visible = false;
            this.textboxMinorista.Enabled = false;
            this.textboxMinorista.Lines = new string[0];
            this.textboxMinorista.Location = new System.Drawing.Point(138, 116);
            this.textboxMinorista.MaxLength = 32767;
            this.textboxMinorista.Name = "textboxMinorista";
            this.textboxMinorista.PasswordChar = '\0';
            this.textboxMinorista.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxMinorista.SelectedText = "";
            this.textboxMinorista.SelectionLength = 0;
            this.textboxMinorista.SelectionStart = 0;
            this.textboxMinorista.ShortcutsEnabled = true;
            this.textboxMinorista.Size = new System.Drawing.Size(140, 23);
            this.textboxMinorista.TabIndex = 19;
            this.textboxMinorista.UseSelectable = true;
            this.textboxMinorista.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxMinorista.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(20, 43);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 25);
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "Cantidad";
            // 
            // textboxCantidad
            // 
            // 
            // 
            // 
            this.textboxCantidad.CustomButton.Image = null;
            this.textboxCantidad.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.textboxCantidad.CustomButton.Name = "";
            this.textboxCantidad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxCantidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxCantidad.CustomButton.TabIndex = 1;
            this.textboxCantidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxCantidad.CustomButton.UseSelectable = true;
            this.textboxCantidad.CustomButton.Visible = false;
            this.textboxCantidad.Lines = new string[0];
            this.textboxCantidad.Location = new System.Drawing.Point(106, 45);
            this.textboxCantidad.MaxLength = 32767;
            this.textboxCantidad.Name = "textboxCantidad";
            this.textboxCantidad.PasswordChar = '\0';
            this.textboxCantidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxCantidad.SelectedText = "";
            this.textboxCantidad.SelectionLength = 0;
            this.textboxCantidad.SelectionStart = 0;
            this.textboxCantidad.ShortcutsEnabled = true;
            this.textboxCantidad.Size = new System.Drawing.Size(140, 23);
            this.textboxCantidad.TabIndex = 17;
            this.textboxCantidad.UseSelectable = true;
            this.textboxCantidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxCantidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(20, 14);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(38, 25);
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "Pez";
            // 
            // textboxPez
            // 
            // 
            // 
            // 
            this.textboxPez.CustomButton.Image = null;
            this.textboxPez.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.textboxPez.CustomButton.Name = "";
            this.textboxPez.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxPez.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxPez.CustomButton.TabIndex = 1;
            this.textboxPez.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxPez.CustomButton.UseSelectable = true;
            this.textboxPez.CustomButton.Visible = false;
            this.textboxPez.Enabled = false;
            this.textboxPez.Lines = new string[0];
            this.textboxPez.Location = new System.Drawing.Point(106, 16);
            this.textboxPez.MaxLength = 32767;
            this.textboxPez.Name = "textboxPez";
            this.textboxPez.PasswordChar = '\0';
            this.textboxPez.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxPez.SelectedText = "";
            this.textboxPez.SelectionLength = 0;
            this.textboxPez.SelectionStart = 0;
            this.textboxPez.ShortcutsEnabled = true;
            this.textboxPez.Size = new System.Drawing.Size(140, 23);
            this.textboxPez.TabIndex = 14;
            this.textboxPez.UseSelectable = true;
            this.textboxPez.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxPez.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSeleccionarPez
            // 
            this.btnSeleccionarPez.Location = new System.Drawing.Point(252, 16);
            this.btnSeleccionarPez.Name = "btnSeleccionarPez";
            this.btnSeleccionarPez.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionarPez.TabIndex = 16;
            this.btnSeleccionarPez.Text = "Seleccionar";
            this.btnSeleccionarPez.UseSelectable = true;
            this.btnSeleccionarPez.Click += new System.EventHandler(this.btnSeleccionarPez_Click);
            // 
            // btnGenerarVenta
            // 
            this.btnGenerarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGenerarVenta.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnGenerarVenta.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnGenerarVenta.Location = new System.Drawing.Point(23, 530);
            this.btnGenerarVenta.Margin = new System.Windows.Forms.Padding(0);
            this.btnGenerarVenta.Name = "btnGenerarVenta";
            this.btnGenerarVenta.Size = new System.Drawing.Size(330, 30);
            this.btnGenerarVenta.TabIndex = 18;
            this.btnGenerarVenta.Text = "GENERAR VENTA";
            this.btnGenerarVenta.UseCustomForeColor = true;
            this.btnGenerarVenta.UseSelectable = true;
            this.btnGenerarVenta.Click += new System.EventHandler(this.btnGenerarVenta_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCancelar.Location = new System.Drawing.Point(717, 530);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 30);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // checkBoxImprimir
            // 
            this.checkBoxImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxImprimir.AutoSize = true;
            this.checkBoxImprimir.Checked = true;
            this.checkBoxImprimir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxImprimir.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.checkBoxImprimir.Location = new System.Drawing.Point(371, 533);
            this.checkBoxImprimir.Name = "checkBoxImprimir";
            this.checkBoxImprimir.Size = new System.Drawing.Size(157, 25);
            this.checkBoxImprimir.TabIndex = 23;
            this.checkBoxImprimir.Text = "Imprimir Factura";
            this.checkBoxImprimir.UseSelectable = true;
            // 
            // FormVender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 585);
            this.Controls.Add(this.checkBoxImprimir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGenerarVenta);
            this.Controls.Add(this.metroPanel1);
            this.MinimumSize = new System.Drawing.Size(845, 585);
            this.Name = "FormVender";
            this.Text = "Vender";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVender_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormVender_FormClosed);
            this.Load += new System.EventHandler(this.FormVender_Load);
            this.metroPanel1.ResumeLayout(false);
            this.panelSubtotal.ResumeLayout(false);
            this.panelSubtotal.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnGenerarVenta;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox textboxPez;
        private MetroFramework.Controls.MetroButton btnSeleccionarPez;
        private MetroFramework.Controls.MetroGrid gridItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdPez;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPez;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrecioDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSubtotal;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton btnSeleccionarCliente;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox textboxCliente;
        private MetroFramework.Controls.MetroPanel panelGrid;
        private MetroFramework.Controls.MetroButton btnAgregarItem;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroRadioButton rBtnMinorista;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox textboxDistribuidor;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox textboxOferta;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox textboxMayorista;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox textboxMinorista;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox textboxCantidad;
        private MetroFramework.Controls.MetroRadioButton rBtnDistribuidor;
        private MetroFramework.Controls.MetroRadioButton rBtnOferta;
        private MetroFramework.Controls.MetroRadioButton rBtnMayorista;
        private MetroFramework.Controls.MetroButton btnRemover;
        private MetroFramework.Controls.MetroButton btnSeleccionarCuenta;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox textboxCuenta;
        private MetroFramework.Controls.MetroPanel panelSubtotal;
        private MetroFramework.Controls.MetroLabel labelTotal;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroCheckBox checkBoxImprimir;
        private MetroFramework.Controls.MetroRadioButton rBtnOtro;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox textboxOtro;
    }
}