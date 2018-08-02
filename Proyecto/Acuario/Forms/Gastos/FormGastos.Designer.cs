namespace Acuario.Forms
{
    partial class FormGastos
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
            this.gridGastos = new MetroFramework.Controls.MetroGrid();
            this.columnIdGasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdGastoCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.comboBoxCategorias = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dateTimeDesde = new MetroFramework.Controls.MetroDateTime();
            this.dateTimeHasta = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnNuevoGasto = new MetroFramework.Controls.MetroButton();
            this.btnEliminarGasto = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.labelSubtotal = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGastos)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGrid
            // 
            this.panelGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrid.Controls.Add(this.gridGastos);
            this.panelGrid.HorizontalScrollbarBarColor = true;
            this.panelGrid.HorizontalScrollbarHighlightOnWheel = false;
            this.panelGrid.HorizontalScrollbarSize = 10;
            this.panelGrid.Location = new System.Drawing.Point(43, 133);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(774, 319);
            this.panelGrid.TabIndex = 0;
            this.panelGrid.VerticalScrollbarBarColor = true;
            this.panelGrid.VerticalScrollbarHighlightOnWheel = false;
            this.panelGrid.VerticalScrollbarSize = 10;
            // 
            // gridGastos
            // 
            this.gridGastos.AllowUserToAddRows = false;
            this.gridGastos.AllowUserToDeleteRows = false;
            this.gridGastos.AllowUserToResizeRows = false;
            this.gridGastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridGastos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridGastos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridGastos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridGastos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridGastos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGastos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIdGasto,
            this.columnIdGastoCategoria,
            this.columnIdCuenta,
            this.columnCategoria,
            this.columnDescripcion,
            this.columnMonto,
            this.columnFechaHora});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridGastos.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridGastos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGastos.EnableHeadersVisualStyles = false;
            this.gridGastos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridGastos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridGastos.Location = new System.Drawing.Point(0, 0);
            this.gridGastos.Name = "gridGastos";
            this.gridGastos.ReadOnly = true;
            this.gridGastos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridGastos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridGastos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridGastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridGastos.Size = new System.Drawing.Size(772, 317);
            this.gridGastos.TabIndex = 1;
            // 
            // columnIdGasto
            // 
            this.columnIdGasto.HeaderText = "id gasto";
            this.columnIdGasto.Name = "columnIdGasto";
            this.columnIdGasto.ReadOnly = true;
            this.columnIdGasto.Visible = false;
            // 
            // columnIdGastoCategoria
            // 
            this.columnIdGastoCategoria.HeaderText = "id gasto categoria";
            this.columnIdGastoCategoria.Name = "columnIdGastoCategoria";
            this.columnIdGastoCategoria.ReadOnly = true;
            this.columnIdGastoCategoria.Visible = false;
            // 
            // columnIdCuenta
            // 
            this.columnIdCuenta.HeaderText = "id cuenta";
            this.columnIdCuenta.Name = "columnIdCuenta";
            this.columnIdCuenta.ReadOnly = true;
            this.columnIdCuenta.Visible = false;
            // 
            // columnCategoria
            // 
            this.columnCategoria.HeaderText = "Categoria";
            this.columnCategoria.Name = "columnCategoria";
            this.columnCategoria.ReadOnly = true;
            this.columnCategoria.Width = 80;
            // 
            // columnDescripcion
            // 
            this.columnDescripcion.HeaderText = "Descripcion";
            this.columnDescripcion.Name = "columnDescripcion";
            this.columnDescripcion.ReadOnly = true;
            this.columnDescripcion.Width = 90;
            // 
            // columnMonto
            // 
            this.columnMonto.HeaderText = "Monto";
            this.columnMonto.Name = "columnMonto";
            this.columnMonto.ReadOnly = true;
            this.columnMonto.Width = 65;
            // 
            // columnFechaHora
            // 
            this.columnFechaHora.HeaderText = "Fecha";
            this.columnFechaHora.Name = "columnFechaHora";
            this.columnFechaHora.ReadOnly = true;
            this.columnFechaHora.Width = 60;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBuscar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnBuscar.Location = new System.Drawing.Point(697, 98);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 29);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(43, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(92, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Categorias";
            // 
            // comboBoxCategorias
            // 
            this.comboBoxCategorias.FormattingEnabled = true;
            this.comboBoxCategorias.ItemHeight = 23;
            this.comboBoxCategorias.Location = new System.Drawing.Point(141, 63);
            this.comboBoxCategorias.Name = "comboBoxCategorias";
            this.comboBoxCategorias.Size = new System.Drawing.Size(180, 29);
            this.comboBoxCategorias.TabIndex = 1;
            this.comboBoxCategorias.UseSelectable = true;
            this.comboBoxCategorias.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategorias_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(43, 102);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 25);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Desde";
            // 
            // dateTimeDesde
            // 
            this.dateTimeDesde.Location = new System.Drawing.Point(141, 98);
            this.dateTimeDesde.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimeDesde.Name = "dateTimeDesde";
            this.dateTimeDesde.Size = new System.Drawing.Size(239, 29);
            this.dateTimeDesde.TabIndex = 2;
            this.dateTimeDesde.ValueChanged += new System.EventHandler(this.dateTimeDesde_ValueChanged);
            // 
            // dateTimeHasta
            // 
            this.dateTimeHasta.Location = new System.Drawing.Point(446, 98);
            this.dateTimeHasta.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimeHasta.Name = "dateTimeHasta";
            this.dateTimeHasta.Size = new System.Drawing.Size(239, 29);
            this.dateTimeHasta.TabIndex = 3;
            this.dateTimeHasta.ValueChanged += new System.EventHandler(this.dateTimeHasta_ValueChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(386, 102);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(54, 25);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Hasta";
            // 
            // btnNuevoGasto
            // 
            this.btnNuevoGasto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoGasto.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnNuevoGasto.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnNuevoGasto.Location = new System.Drawing.Point(43, 489);
            this.btnNuevoGasto.Margin = new System.Windows.Forms.Padding(0);
            this.btnNuevoGasto.Name = "btnNuevoGasto";
            this.btnNuevoGasto.Size = new System.Drawing.Size(165, 30);
            this.btnNuevoGasto.TabIndex = 5;
            this.btnNuevoGasto.Text = "Nuevo Gasto";
            this.btnNuevoGasto.UseSelectable = true;
            this.btnNuevoGasto.Click += new System.EventHandler(this.btnNuevoGasto_Click);
            // 
            // btnEliminarGasto
            // 
            this.btnEliminarGasto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarGasto.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnEliminarGasto.ForeColor = System.Drawing.Color.DarkRed;
            this.btnEliminarGasto.Location = new System.Drawing.Point(652, 489);
            this.btnEliminarGasto.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminarGasto.Name = "btnEliminarGasto";
            this.btnEliminarGasto.Size = new System.Drawing.Size(165, 30);
            this.btnEliminarGasto.TabIndex = 6;
            this.btnEliminarGasto.Text = "Deshacer Gasto";
            this.btnEliminarGasto.UseCustomForeColor = true;
            this.btnEliminarGasto.UseSelectable = true;
            this.btnEliminarGasto.Click += new System.EventHandler(this.btnEliminarGasto_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.labelSubtotal);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(43, 457);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(774, 29);
            this.metroPanel1.TabIndex = 12;
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
            this.labelSubtotal.Size = new System.Drawing.Size(346, 25);
            this.labelSubtotal.TabIndex = 3;
            this.labelSubtotal.Text = "$0,00";
            this.labelSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(3, 2);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(94, 25);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "SUBTOTAL:";
            // 
            // FormGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 545);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btnEliminarGasto);
            this.Controls.Add(this.btnNuevoGasto);
            this.Controls.Add(this.dateTimeHasta);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.dateTimeDesde);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.comboBoxCategorias);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panelGrid);
            this.MinimumSize = new System.Drawing.Size(843, 545);
            this.Name = "FormGastos";
            this.Text = "Gastos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGastos_FormClosed);
            this.Load += new System.EventHandler(this.FormGastos_Load);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGastos)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelGrid;
        private MetroFramework.Controls.MetroGrid gridGastos;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox comboBoxCategorias;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime dateTimeDesde;
        private MetroFramework.Controls.MetroDateTime dateTimeHasta;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdGasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdGastoCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFechaHora;
        private MetroFramework.Controls.MetroButton btnNuevoGasto;
        private MetroFramework.Controls.MetroButton btnEliminarGasto;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel labelSubtotal;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}