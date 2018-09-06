namespace Acuario.Forms
{
    partial class FormCompraItems
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
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.textboxNroCompra = new MetroFramework.Controls.MetroTextBox();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.panelGrid = new MetroFramework.Controls.MetroPanel();
            this.gridCompraItems = new MetroFramework.Controls.MetroGrid();
            this.columnIdCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdCompraItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdPez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNroCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPEZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompraItems)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(23, 60);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(107, 25);
            this.metroLabel4.TabIndex = 46;
            this.metroLabel4.Text = "Nro Compra";
            // 
            // textboxNroCompra
            // 
            // 
            // 
            // 
            this.textboxNroCompra.CustomButton.Image = null;
            this.textboxNroCompra.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.textboxNroCompra.CustomButton.Name = "";
            this.textboxNroCompra.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxNroCompra.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxNroCompra.CustomButton.TabIndex = 1;
            this.textboxNroCompra.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxNroCompra.CustomButton.UseSelectable = true;
            this.textboxNroCompra.CustomButton.Visible = false;
            this.textboxNroCompra.Lines = new string[0];
            this.textboxNroCompra.Location = new System.Drawing.Point(136, 63);
            this.textboxNroCompra.MaxLength = 32767;
            this.textboxNroCompra.Name = "textboxNroCompra";
            this.textboxNroCompra.PasswordChar = '\0';
            this.textboxNroCompra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxNroCompra.SelectedText = "";
            this.textboxNroCompra.SelectionLength = 0;
            this.textboxNroCompra.SelectionStart = 0;
            this.textboxNroCompra.ShortcutsEnabled = true;
            this.textboxNroCompra.Size = new System.Drawing.Size(140, 23);
            this.textboxNroCompra.TabIndex = 1;
            this.textboxNroCompra.UseSelectable = true;
            this.textboxNroCompra.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxNroCompra.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textboxNroCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxNroCompra_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBuscar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnBuscar.Location = new System.Drawing.Point(358, 60);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 30);
            this.btnBuscar.TabIndex = 2;
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
            this.panelGrid.Controls.Add(this.gridCompraItems);
            this.panelGrid.HorizontalScrollbarBarColor = true;
            this.panelGrid.HorizontalScrollbarHighlightOnWheel = false;
            this.panelGrid.HorizontalScrollbarSize = 10;
            this.panelGrid.Location = new System.Drawing.Point(23, 96);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(455, 287);
            this.panelGrid.TabIndex = 38;
            this.panelGrid.VerticalScrollbarBarColor = true;
            this.panelGrid.VerticalScrollbarHighlightOnWheel = false;
            this.panelGrid.VerticalScrollbarSize = 10;
            // 
            // gridCompraItems
            // 
            this.gridCompraItems.AllowUserToAddRows = false;
            this.gridCompraItems.AllowUserToDeleteRows = false;
            this.gridCompraItems.AllowUserToResizeRows = false;
            this.gridCompraItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridCompraItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridCompraItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCompraItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridCompraItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCompraItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCompraItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCompraItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIdCompra,
            this.columnIdCompraItem,
            this.columnIdPez,
            this.columnNroCompra,
            this.columnPEZ,
            this.columnCantidad,
            this.columnSubtotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCompraItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridCompraItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCompraItems.EnableHeadersVisualStyles = false;
            this.gridCompraItems.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridCompraItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridCompraItems.Location = new System.Drawing.Point(0, 0);
            this.gridCompraItems.MultiSelect = false;
            this.gridCompraItems.Name = "gridCompraItems";
            this.gridCompraItems.ReadOnly = true;
            this.gridCompraItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCompraItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridCompraItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridCompraItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCompraItems.Size = new System.Drawing.Size(453, 285);
            this.gridCompraItems.TabIndex = 2;
            // 
            // columnIdCompra
            // 
            this.columnIdCompra.HeaderText = "ID COMPRA";
            this.columnIdCompra.Name = "columnIdCompra";
            this.columnIdCompra.ReadOnly = true;
            this.columnIdCompra.Visible = false;
            this.columnIdCompra.Width = 90;
            // 
            // columnIdCompraItem
            // 
            this.columnIdCompraItem.HeaderText = "ID COMPRA ITEM";
            this.columnIdCompraItem.Name = "columnIdCompraItem";
            this.columnIdCompraItem.ReadOnly = true;
            this.columnIdCompraItem.Visible = false;
            this.columnIdCompraItem.Width = 117;
            // 
            // columnIdPez
            // 
            this.columnIdPez.HeaderText = "ID PEZ";
            this.columnIdPez.Name = "columnIdPez";
            this.columnIdPez.ReadOnly = true;
            this.columnIdPez.Visible = false;
            this.columnIdPez.Width = 62;
            // 
            // columnNroCompra
            // 
            this.columnNroCompra.HeaderText = "NRO COMPRA";
            this.columnNroCompra.Name = "columnNroCompra";
            this.columnNroCompra.ReadOnly = true;
            this.columnNroCompra.Width = 94;
            // 
            // columnPEZ
            // 
            this.columnPEZ.HeaderText = "PEZ";
            this.columnPEZ.Name = "columnPEZ";
            this.columnPEZ.ReadOnly = true;
            this.columnPEZ.Width = 48;
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
            // FormCompraItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 410);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.textboxNroCompra);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panelGrid);
            this.MinimumSize = new System.Drawing.Size(500, 410);
            this.Name = "FormCompraItems";
            this.Text = "Detalle de Compras";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCompraItems_FormClosed);
            this.Load += new System.EventHandler(this.FormCompraItems_Load);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCompraItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox textboxNroCompra;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroPanel panelGrid;
        private MetroFramework.Controls.MetroGrid gridCompraItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdCompraItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdPez;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNroCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPEZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSubtotal;
    }
}