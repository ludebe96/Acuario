namespace Acuario.Forms
{
    partial class FormCompras
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
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.textboxNroCompra = new MetroFramework.Controls.MetroTextBox();
            this.dateTimeHasta = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dateTimeDesde = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.panelGrid = new MetroFramework.Controls.MetroPanel();
            this.gridCompras = new MetroFramework.Controls.MetroGrid();
            this.columnIdCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNroCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnVerDetalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDeshacerCompra = new MetroFramework.Controls.MetroButton();
            this.btnDetalles = new MetroFramework.Controls.MetroButton();
            this.btnComprar = new MetroFramework.Controls.MetroButton();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(23, 60);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(107, 25);
            this.metroLabel4.TabIndex = 43;
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
            this.textboxNroCompra.Location = new System.Drawing.Point(136, 65);
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
            // dateTimeHasta
            // 
            this.dateTimeHasta.Location = new System.Drawing.Point(441, 94);
            this.dateTimeHasta.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimeHasta.Name = "dateTimeHasta";
            this.dateTimeHasta.Size = new System.Drawing.Size(239, 29);
            this.dateTimeHasta.TabIndex = 3;
            this.dateTimeHasta.ValueChanged += new System.EventHandler(this.dateTimeHasta_ValueChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(381, 97);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 25);
            this.metroLabel1.TabIndex = 37;
            this.metroLabel1.Text = "Hasta";
            // 
            // dateTimeDesde
            // 
            this.dateTimeDesde.Location = new System.Drawing.Point(136, 95);
            this.dateTimeDesde.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimeDesde.Name = "dateTimeDesde";
            this.dateTimeDesde.Size = new System.Drawing.Size(239, 29);
            this.dateTimeDesde.TabIndex = 2;
            this.dateTimeDesde.ValueChanged += new System.EventHandler(this.dateTimeDesde_ValueChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(23, 97);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 25);
            this.metroLabel2.TabIndex = 35;
            this.metroLabel2.Text = "Desde";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBuscar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnBuscar.Location = new System.Drawing.Point(698, 94);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 29);
            this.btnBuscar.TabIndex = 4;
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
            this.panelGrid.Controls.Add(this.gridCompras);
            this.panelGrid.HorizontalScrollbarBarColor = true;
            this.panelGrid.HorizontalScrollbarHighlightOnWheel = false;
            this.panelGrid.HorizontalScrollbarSize = 10;
            this.panelGrid.Location = new System.Drawing.Point(23, 129);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(795, 239);
            this.panelGrid.TabIndex = 44;
            this.panelGrid.VerticalScrollbarBarColor = true;
            this.panelGrid.VerticalScrollbarHighlightOnWheel = false;
            this.panelGrid.VerticalScrollbarSize = 10;
            // 
            // gridCompras
            // 
            this.gridCompras.AllowUserToAddRows = false;
            this.gridCompras.AllowUserToDeleteRows = false;
            this.gridCompras.AllowUserToResizeRows = false;
            this.gridCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridCompras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCompras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridCompras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIdCompra,
            this.columnId,
            this.columnNroCompra,
            this.columnCuenta,
            this.columnTotal,
            this.columnFechaHora,
            this.columnVerDetalle});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCompras.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCompras.EnableHeadersVisualStyles = false;
            this.gridCompras.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridCompras.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridCompras.Location = new System.Drawing.Point(0, 0);
            this.gridCompras.Name = "gridCompras";
            this.gridCompras.ReadOnly = true;
            this.gridCompras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCompras.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridCompras.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCompras.Size = new System.Drawing.Size(793, 237);
            this.gridCompras.TabIndex = 2;
            this.gridCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCompras_CellContentClick);
            // 
            // columnIdCompra
            // 
            this.columnIdCompra.HeaderText = "ID COMPRA";
            this.columnIdCompra.Name = "columnIdCompra";
            this.columnIdCompra.ReadOnly = true;
            this.columnIdCompra.Visible = false;
            this.columnIdCompra.Width = 90;
            // 
            // columnId
            // 
            this.columnId.HeaderText = "ID CUENTA";
            this.columnId.Name = "columnId";
            this.columnId.ReadOnly = true;
            this.columnId.Visible = false;
            this.columnId.Width = 84;
            // 
            // columnNroCompra
            // 
            this.columnNroCompra.HeaderText = "NRO COMPRA";
            this.columnNroCompra.Name = "columnNroCompra";
            this.columnNroCompra.ReadOnly = true;
            this.columnNroCompra.Width = 94;
            // 
            // columnCuenta
            // 
            this.columnCuenta.HeaderText = "CUENTA";
            this.columnCuenta.Name = "columnCuenta";
            this.columnCuenta.ReadOnly = true;
            this.columnCuenta.Width = 70;
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
            this.columnFechaHora.Width = 90;
            // 
            // columnVerDetalle
            // 
            this.columnVerDetalle.HeaderText = "";
            this.columnVerDetalle.Name = "columnVerDetalle";
            this.columnVerDetalle.ReadOnly = true;
            this.columnVerDetalle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnVerDetalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columnVerDetalle.Width = 17;
            // 
            // btnDeshacerCompra
            // 
            this.btnDeshacerCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeshacerCompra.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDeshacerCompra.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDeshacerCompra.Location = new System.Drawing.Point(23, 371);
            this.btnDeshacerCompra.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeshacerCompra.Name = "btnDeshacerCompra";
            this.btnDeshacerCompra.Size = new System.Drawing.Size(165, 30);
            this.btnDeshacerCompra.TabIndex = 5;
            this.btnDeshacerCompra.Text = "Deshacer compra";
            this.btnDeshacerCompra.UseCustomForeColor = true;
            this.btnDeshacerCompra.UseSelectable = true;
            this.btnDeshacerCompra.Click += new System.EventHandler(this.btnDeshacerCompra_Click);
            // 
            // btnDetalles
            // 
            this.btnDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetalles.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDetalles.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnDetalles.Location = new System.Drawing.Point(653, 370);
            this.btnDetalles.Margin = new System.Windows.Forms.Padding(0);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(165, 30);
            this.btnDetalles.TabIndex = 7;
            this.btnDetalles.Text = "Detalles";
            this.btnDetalles.UseSelectable = true;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComprar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnComprar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnComprar.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnComprar.Location = new System.Drawing.Point(488, 370);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(0);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(165, 30);
            this.btnComprar.TabIndex = 6;
            this.btnComprar.Text = "COMPRAR";
            this.btnComprar.UseCustomForeColor = true;
            this.btnComprar.UseSelectable = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // FormCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 425);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.btnDeshacerCompra);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.textboxNroCompra);
            this.Controls.Add(this.dateTimeHasta);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dateTimeDesde);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnBuscar);
            this.MinimumSize = new System.Drawing.Size(842, 425);
            this.Name = "FormCompras";
            this.Text = "Compras";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCompras_FormClosed);
            this.Load += new System.EventHandler(this.FormCompras_Load);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox textboxNroCompra;
        private MetroFramework.Controls.MetroDateTime dateTimeHasta;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime dateTimeDesde;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroPanel panelGrid;
        private MetroFramework.Controls.MetroGrid gridCompras;
        private MetroFramework.Controls.MetroButton btnDeshacerCompra;
        private MetroFramework.Controls.MetroButton btnDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNroCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFechaHora;
        private System.Windows.Forms.DataGridViewButtonColumn columnVerDetalle;
        private MetroFramework.Controls.MetroButton btnComprar;
    }
}