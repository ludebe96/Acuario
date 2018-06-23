namespace Acuario.Forms
{
    partial class FormComprar
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
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnGenerarCompra = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnRemover = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnSeleccionarCuenta = new MetroFramework.Controls.MetroButton();
            this.textboxCuenta = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panelGrid = new MetroFramework.Controls.MetroPanel();
            this.gridItems = new MetroFramework.Controls.MetroGrid();
            this.columnIdPez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarItem = new MetroFramework.Controls.MetroButton();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.textboxSubtotal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.textboxCantidad = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.textboxPez = new MetroFramework.Controls.MetroTextBox();
            this.btnSeleccionarPez = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).BeginInit();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCancelar.Location = new System.Drawing.Point(717, 358);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 30);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGenerarCompra
            // 
            this.btnGenerarCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGenerarCompra.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnGenerarCompra.Location = new System.Drawing.Point(23, 358);
            this.btnGenerarCompra.Margin = new System.Windows.Forms.Padding(0);
            this.btnGenerarCompra.Name = "btnGenerarCompra";
            this.btnGenerarCompra.Size = new System.Drawing.Size(330, 30);
            this.btnGenerarCompra.TabIndex = 21;
            this.btnGenerarCompra.Text = "GENERAR COMPRA";
            this.btnGenerarCompra.UseSelectable = true;
            this.btnGenerarCompra.Click += new System.EventHandler(this.btnGenerarCompra_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.metroPanel1.Size = new System.Drawing.Size(799, 292);
            this.metroPanel1.TabIndex = 20;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemover.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnRemover.Location = new System.Drawing.Point(688, 252);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(105, 30);
            this.btnRemover.TabIndex = 20;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseSelectable = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.btnSeleccionarCuenta);
            this.metroPanel2.Controls.Add(this.textboxCuenta);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 3);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(392, 62);
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
            this.panelGrid.Size = new System.Drawing.Size(396, 243);
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
            this.columnPez,
            this.columnPrecioUnitario,
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
            this.gridItems.Size = new System.Drawing.Size(394, 241);
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
            // columnPez
            // 
            this.columnPez.HeaderText = "PEZ";
            this.columnPez.Name = "columnPez";
            this.columnPez.ReadOnly = true;
            this.columnPez.Width = 48;
            // 
            // columnPrecioUnitario
            // 
            this.columnPrecioUnitario.HeaderText = "PRECIO UNITARIO";
            this.columnPrecioUnitario.Name = "columnPrecioUnitario";
            this.columnPrecioUnitario.ReadOnly = true;
            this.columnPrecioUnitario.Width = 110;
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
            this.btnAgregarItem.Location = new System.Drawing.Point(3, 252);
            this.btnAgregarItem.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregarItem.Name = "btnAgregarItem";
            this.btnAgregarItem.Size = new System.Drawing.Size(392, 30);
            this.btnAgregarItem.TabIndex = 20;
            this.btnAgregarItem.Text = "Agregar a la Compra";
            this.btnAgregarItem.UseSelectable = true;
            this.btnAgregarItem.Click += new System.EventHandler(this.btnAgregarItem_Click);
            // 
            // metroPanel3
            // 
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.metroLabel4);
            this.metroPanel3.Controls.Add(this.textboxSubtotal);
            this.metroPanel3.Controls.Add(this.metroLabel2);
            this.metroPanel3.Controls.Add(this.textboxCantidad);
            this.metroPanel3.Controls.Add(this.metroLabel3);
            this.metroPanel3.Controls.Add(this.textboxPez);
            this.metroPanel3.Controls.Add(this.btnSeleccionarPez);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(3, 71);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(392, 174);
            this.metroPanel3.TabIndex = 18;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(18, 95);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(74, 25);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Subtotal";
            // 
            // textboxSubtotal
            // 
            // 
            // 
            // 
            this.textboxSubtotal.CustomButton.Image = null;
            this.textboxSubtotal.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.textboxSubtotal.CustomButton.Name = "";
            this.textboxSubtotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxSubtotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxSubtotal.CustomButton.TabIndex = 1;
            this.textboxSubtotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxSubtotal.CustomButton.UseSelectable = true;
            this.textboxSubtotal.CustomButton.Visible = false;
            this.textboxSubtotal.Lines = new string[0];
            this.textboxSubtotal.Location = new System.Drawing.Point(104, 97);
            this.textboxSubtotal.MaxLength = 32767;
            this.textboxSubtotal.Name = "textboxSubtotal";
            this.textboxSubtotal.PasswordChar = '\0';
            this.textboxSubtotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxSubtotal.SelectedText = "";
            this.textboxSubtotal.SelectionLength = 0;
            this.textboxSubtotal.SelectionStart = 0;
            this.textboxSubtotal.ShortcutsEnabled = true;
            this.textboxSubtotal.Size = new System.Drawing.Size(140, 23);
            this.textboxSubtotal.TabIndex = 19;
            this.textboxSubtotal.UseSelectable = true;
            this.textboxSubtotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxSubtotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(18, 66);
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
            this.textboxCantidad.Location = new System.Drawing.Point(104, 68);
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
            this.metroLabel3.Location = new System.Drawing.Point(18, 37);
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
            this.textboxPez.Location = new System.Drawing.Point(104, 39);
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
            this.btnSeleccionarPez.Location = new System.Drawing.Point(250, 39);
            this.btnSeleccionarPez.Name = "btnSeleccionarPez";
            this.btnSeleccionarPez.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionarPez.TabIndex = 16;
            this.btnSeleccionarPez.Text = "Seleccionar";
            this.btnSeleccionarPez.UseSelectable = true;
            this.btnSeleccionarPez.Click += new System.EventHandler(this.btnSeleccionarPez_Click);
            // 
            // FormComprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 420);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGenerarCompra);
            this.Controls.Add(this.metroPanel1);
            this.MinimumSize = new System.Drawing.Size(850, 420);
            this.Name = "FormComprar";
            this.Text = "FormComprar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormComprar_FormClosed);
            this.Load += new System.EventHandler(this.FormComprar_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnGenerarCompra;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnRemover;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton btnSeleccionarCuenta;
        private MetroFramework.Controls.MetroTextBox textboxCuenta;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel panelGrid;
        private MetroFramework.Controls.MetroGrid gridItems;
        private MetroFramework.Controls.MetroButton btnAgregarItem;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox textboxSubtotal;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox textboxCantidad;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox textboxPez;
        private MetroFramework.Controls.MetroButton btnSeleccionarPez;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdPez;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPez;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSubtotal;
    }
}