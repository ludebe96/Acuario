namespace Acuario.Forms
{
    partial class FormVentaItems
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelGrid = new MetroFramework.Controls.MetroPanel();
            this.gridVentaItems = new MetroFramework.Controls.MetroGrid();
            this.columnIdVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdVentaItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdPez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNroVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPEZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMontoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.textboxCliente = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.textboxNroVenta = new MetroFramework.Controls.MetroTextBox();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVentaItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGrid
            // 
            this.panelGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrid.Controls.Add(this.gridVentaItems);
            this.panelGrid.HorizontalScrollbarBarColor = true;
            this.panelGrid.HorizontalScrollbarHighlightOnWheel = false;
            this.panelGrid.HorizontalScrollbarSize = 10;
            this.panelGrid.Location = new System.Drawing.Point(39, 96);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(530, 290);
            this.panelGrid.TabIndex = 18;
            this.panelGrid.VerticalScrollbarBarColor = true;
            this.panelGrid.VerticalScrollbarHighlightOnWheel = false;
            this.panelGrid.VerticalScrollbarSize = 10;
            // 
            // gridVentaItems
            // 
            this.gridVentaItems.AllowUserToAddRows = false;
            this.gridVentaItems.AllowUserToDeleteRows = false;
            this.gridVentaItems.AllowUserToResizeRows = false;
            this.gridVentaItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridVentaItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridVentaItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridVentaItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridVentaItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridVentaItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridVentaItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVentaItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIdVenta,
            this.columnIdVentaItem,
            this.columnIdPez,
            this.columnNroVenta,
            this.columnPEZ,
            this.columnMontoUnitario,
            this.columnCantidad,
            this.columnSubtotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridVentaItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridVentaItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridVentaItems.EnableHeadersVisualStyles = false;
            this.gridVentaItems.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridVentaItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridVentaItems.Location = new System.Drawing.Point(0, 0);
            this.gridVentaItems.Name = "gridVentaItems";
            this.gridVentaItems.ReadOnly = true;
            this.gridVentaItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridVentaItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridVentaItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridVentaItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridVentaItems.Size = new System.Drawing.Size(528, 288);
            this.gridVentaItems.TabIndex = 2;
            // 
            // columnIdVenta
            // 
            this.columnIdVenta.HeaderText = "ID VENTA";
            this.columnIdVenta.Name = "columnIdVenta";
            this.columnIdVenta.ReadOnly = true;
            this.columnIdVenta.Visible = false;
            this.columnIdVenta.Width = 76;
            // 
            // columnIdVentaItem
            // 
            this.columnIdVentaItem.HeaderText = "ID VENTA ITEM";
            this.columnIdVentaItem.Name = "columnIdVentaItem";
            this.columnIdVentaItem.ReadOnly = true;
            this.columnIdVentaItem.Visible = false;
            this.columnIdVentaItem.Width = 103;
            // 
            // columnIdPez
            // 
            this.columnIdPez.HeaderText = "ID PEZ";
            this.columnIdPez.Name = "columnIdPez";
            this.columnIdPez.ReadOnly = true;
            this.columnIdPez.Visible = false;
            this.columnIdPez.Width = 62;
            // 
            // columnNroVenta
            // 
            this.columnNroVenta.HeaderText = "NRO VENTA";
            this.columnNroVenta.Name = "columnNroVenta";
            this.columnNroVenta.ReadOnly = true;
            this.columnNroVenta.Width = 82;
            // 
            // columnPEZ
            // 
            this.columnPEZ.HeaderText = "PEZ";
            this.columnPEZ.Name = "columnPEZ";
            this.columnPEZ.ReadOnly = true;
            this.columnPEZ.Width = 48;
            // 
            // columnMontoUnitario
            // 
            this.columnMontoUnitario.HeaderText = "MONTO UNITARIO";
            this.columnMontoUnitario.Name = "columnMontoUnitario";
            this.columnMontoUnitario.ReadOnly = true;
            this.columnMontoUnitario.Width = 112;
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
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(496, 60);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(72, 30);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(279, 61);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(38, 25);
            this.metroLabel3.TabIndex = 24;
            this.metroLabel3.Text = "Pez";
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
            this.textboxCliente.Lines = new string[0];
            this.textboxCliente.Location = new System.Drawing.Point(323, 64);
            this.textboxCliente.MaxLength = 32767;
            this.textboxCliente.Name = "textboxCliente";
            this.textboxCliente.PasswordChar = '\0';
            this.textboxCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxCliente.SelectedText = "";
            this.textboxCliente.SelectionLength = 0;
            this.textboxCliente.SelectionStart = 0;
            this.textboxCliente.ShortcutsEnabled = true;
            this.textboxCliente.Size = new System.Drawing.Size(140, 23);
            this.textboxCliente.TabIndex = 23;
            this.textboxCliente.UseSelectable = true;
            this.textboxCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(39, 60);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(88, 25);
            this.metroLabel4.TabIndex = 36;
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
            this.textboxNroVenta.Location = new System.Drawing.Point(133, 63);
            this.textboxNroVenta.MaxLength = 32767;
            this.textboxNroVenta.Name = "textboxNroVenta";
            this.textboxNroVenta.PasswordChar = '\0';
            this.textboxNroVenta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxNroVenta.SelectedText = "";
            this.textboxNroVenta.SelectionLength = 0;
            this.textboxNroVenta.SelectionStart = 0;
            this.textboxNroVenta.ShortcutsEnabled = true;
            this.textboxNroVenta.Size = new System.Drawing.Size(140, 23);
            this.textboxNroVenta.TabIndex = 35;
            this.textboxNroVenta.UseSelectable = true;
            this.textboxNroVenta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxNroVenta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FormVentaItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 410);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.textboxNroVenta);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.textboxCliente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panelGrid);
            this.MinimumSize = new System.Drawing.Size(595, 410);
            this.Name = "FormVentaItems";
            this.Text = "Detalle de Ventas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormVentaItems_FormClosed);
            this.Load += new System.EventHandler(this.FormVentaItems_Load);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridVentaItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelGrid;
        private MetroFramework.Controls.MetroGrid gridVentaItems;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox textboxCliente;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox textboxNroVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdVentaItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdPez;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNroVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPEZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMontoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSubtotal;
    }
}