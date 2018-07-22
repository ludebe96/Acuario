namespace Acuario.Forms
{
    partial class FormCaja
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
            this.mPanelGrid = new MetroFramework.Controls.MetroPanel();
            this.gridCuentas = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mLabelTotalCuentas = new MetroFramework.Controls.MetroLabel();
            this.mPanelGridTotales = new MetroFramework.Controls.MetroPanel();
            this.btnAjustarBalanceCuentas = new MetroFramework.Controls.MetroButton();
            this.btnAjustarBalanceAhorros = new MetroFramework.Controls.MetroButton();
            this.panelAhorros = new MetroFramework.Controls.MetroPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.labelTotalAhorros = new MetroFramework.Controls.MetroLabel();
            this.btnTransferencias = new MetroFramework.Controls.MetroButton();
            this.columnIdCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnBalanceActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mPanelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCuentas)).BeginInit();
            this.mPanelGridTotales.SuspendLayout();
            this.panelAhorros.SuspendLayout();
            this.SuspendLayout();
            // 
            // mPanelGrid
            // 
            this.mPanelGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mPanelGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mPanelGrid.Controls.Add(this.gridCuentas);
            this.mPanelGrid.HorizontalScrollbarBarColor = true;
            this.mPanelGrid.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanelGrid.HorizontalScrollbarSize = 10;
            this.mPanelGrid.Location = new System.Drawing.Point(3, 3);
            this.mPanelGrid.Name = "mPanelGrid";
            this.mPanelGrid.Size = new System.Drawing.Size(537, 100);
            this.mPanelGrid.TabIndex = 1;
            this.mPanelGrid.VerticalScrollbarBarColor = true;
            this.mPanelGrid.VerticalScrollbarHighlightOnWheel = false;
            this.mPanelGrid.VerticalScrollbarSize = 10;
            // 
            // gridCuentas
            // 
            this.gridCuentas.AllowUserToAddRows = false;
            this.gridCuentas.AllowUserToDeleteRows = false;
            this.gridCuentas.AllowUserToResizeRows = false;
            this.gridCuentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCuentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridCuentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCuentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridCuentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCuentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIdCuenta,
            this.columnCuenta,
            this.columnBalanceActual});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCuentas.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridCuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCuentas.EnableHeadersVisualStyles = false;
            this.gridCuentas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridCuentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridCuentas.Location = new System.Drawing.Point(0, 0);
            this.gridCuentas.MultiSelect = false;
            this.gridCuentas.Name = "gridCuentas";
            this.gridCuentas.ReadOnly = true;
            this.gridCuentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCuentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridCuentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCuentas.Size = new System.Drawing.Size(535, 98);
            this.gridCuentas.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(4, 105);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Total:";
            // 
            // mLabelTotalCuentas
            // 
            this.mLabelTotalCuentas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mLabelTotalCuentas.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mLabelTotalCuentas.Location = new System.Drawing.Point(310, 106);
            this.mLabelTotalCuentas.Name = "mLabelTotalCuentas";
            this.mLabelTotalCuentas.Size = new System.Drawing.Size(229, 24);
            this.mLabelTotalCuentas.TabIndex = 3;
            this.mLabelTotalCuentas.Text = "$0,00";
            this.mLabelTotalCuentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mPanelGridTotales
            // 
            this.mPanelGridTotales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mPanelGridTotales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mPanelGridTotales.Controls.Add(this.metroLabel1);
            this.mPanelGridTotales.Controls.Add(this.mLabelTotalCuentas);
            this.mPanelGridTotales.Controls.Add(this.mPanelGrid);
            this.mPanelGridTotales.HorizontalScrollbarBarColor = true;
            this.mPanelGridTotales.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanelGridTotales.HorizontalScrollbarSize = 10;
            this.mPanelGridTotales.Location = new System.Drawing.Point(20, 60);
            this.mPanelGridTotales.Margin = new System.Windows.Forms.Padding(0);
            this.mPanelGridTotales.Name = "mPanelGridTotales";
            this.mPanelGridTotales.Size = new System.Drawing.Size(545, 138);
            this.mPanelGridTotales.TabIndex = 4;
            this.mPanelGridTotales.VerticalScrollbarBarColor = true;
            this.mPanelGridTotales.VerticalScrollbarHighlightOnWheel = false;
            this.mPanelGridTotales.VerticalScrollbarSize = 10;
            // 
            // btnAjustarBalanceCuentas
            // 
            this.btnAjustarBalanceCuentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjustarBalanceCuentas.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAjustarBalanceCuentas.Location = new System.Drawing.Point(20, 201);
            this.btnAjustarBalanceCuentas.Name = "btnAjustarBalanceCuentas";
            this.btnAjustarBalanceCuentas.Size = new System.Drawing.Size(545, 30);
            this.btnAjustarBalanceCuentas.TabIndex = 1;
            this.btnAjustarBalanceCuentas.Text = "Ajustar Balance";
            this.btnAjustarBalanceCuentas.UseSelectable = true;
            this.btnAjustarBalanceCuentas.Click += new System.EventHandler(this.btnAjustarBalanceCuentas_Click);
            // 
            // btnAjustarBalanceAhorros
            // 
            this.btnAjustarBalanceAhorros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjustarBalanceAhorros.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAjustarBalanceAhorros.Location = new System.Drawing.Point(20, 349);
            this.btnAjustarBalanceAhorros.Name = "btnAjustarBalanceAhorros";
            this.btnAjustarBalanceAhorros.Size = new System.Drawing.Size(545, 30);
            this.btnAjustarBalanceAhorros.TabIndex = 2;
            this.btnAjustarBalanceAhorros.Text = "Ajustar Balance";
            this.btnAjustarBalanceAhorros.UseSelectable = true;
            this.btnAjustarBalanceAhorros.Click += new System.EventHandler(this.btnAjustarBalanceAhorros_Click);
            // 
            // panelAhorros
            // 
            this.panelAhorros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAhorros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAhorros.Controls.Add(this.metroLabel4);
            this.panelAhorros.Controls.Add(this.metroLabel2);
            this.panelAhorros.Controls.Add(this.labelTotalAhorros);
            this.panelAhorros.HorizontalScrollbarBarColor = true;
            this.panelAhorros.HorizontalScrollbarHighlightOnWheel = false;
            this.panelAhorros.HorizontalScrollbarSize = 10;
            this.panelAhorros.Location = new System.Drawing.Point(20, 271);
            this.panelAhorros.Margin = new System.Windows.Forms.Padding(0);
            this.panelAhorros.Name = "panelAhorros";
            this.panelAhorros.Size = new System.Drawing.Size(545, 75);
            this.panelAhorros.TabIndex = 6;
            this.panelAhorros.VerticalScrollbarBarColor = true;
            this.panelAhorros.VerticalScrollbarHighlightOnWheel = false;
            this.panelAhorros.VerticalScrollbarSize = 10;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(4, 10);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(97, 25);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "AHORROS";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(4, 49);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Total:";
            // 
            // labelTotalAhorros
            // 
            this.labelTotalAhorros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalAhorros.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelTotalAhorros.Location = new System.Drawing.Point(310, 50);
            this.labelTotalAhorros.Name = "labelTotalAhorros";
            this.labelTotalAhorros.Size = new System.Drawing.Size(229, 24);
            this.labelTotalAhorros.TabIndex = 3;
            this.labelTotalAhorros.Text = "$0,00";
            this.labelTotalAhorros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnTransferencias
            // 
            this.btnTransferencias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransferencias.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnTransferencias.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnTransferencias.Location = new System.Drawing.Point(292, 385);
            this.btnTransferencias.Name = "btnTransferencias";
            this.btnTransferencias.Size = new System.Drawing.Size(273, 30);
            this.btnTransferencias.TabIndex = 3;
            this.btnTransferencias.Text = "Transferencias";
            this.btnTransferencias.UseSelectable = true;
            this.btnTransferencias.Click += new System.EventHandler(this.btnTransferencias_Click);
            // 
            // columnIdCuenta
            // 
            this.columnIdCuenta.HeaderText = "ID Cuenta";
            this.columnIdCuenta.Name = "columnIdCuenta";
            this.columnIdCuenta.ReadOnly = true;
            this.columnIdCuenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnIdCuenta.Visible = false;
            // 
            // columnCuenta
            // 
            this.columnCuenta.HeaderText = "Cuenta";
            this.columnCuenta.Name = "columnCuenta";
            this.columnCuenta.ReadOnly = true;
            this.columnCuenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // columnBalanceActual
            // 
            this.columnBalanceActual.HeaderText = "Balance Actual";
            this.columnBalanceActual.Name = "columnBalanceActual";
            this.columnBalanceActual.ReadOnly = true;
            this.columnBalanceActual.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FormCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 445);
            this.Controls.Add(this.btnTransferencias);
            this.Controls.Add(this.btnAjustarBalanceAhorros);
            this.Controls.Add(this.panelAhorros);
            this.Controls.Add(this.btnAjustarBalanceCuentas);
            this.Controls.Add(this.mPanelGridTotales);
            this.MinimumSize = new System.Drawing.Size(585, 445);
            this.Name = "FormCaja";
            this.Text = "Caja";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCaja_FormClosed);
            this.Load += new System.EventHandler(this.FormCaja_Load);
            this.mPanelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCuentas)).EndInit();
            this.mPanelGridTotales.ResumeLayout(false);
            this.mPanelGridTotales.PerformLayout();
            this.panelAhorros.ResumeLayout(false);
            this.panelAhorros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel mPanelGrid;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel mLabelTotalCuentas;
        private MetroFramework.Controls.MetroPanel mPanelGridTotales;
        private MetroFramework.Controls.MetroButton btnAjustarBalanceCuentas;
        private MetroFramework.Controls.MetroGrid gridCuentas;
        private MetroFramework.Controls.MetroButton btnAjustarBalanceAhorros;
        private MetroFramework.Controls.MetroPanel panelAhorros;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel labelTotalAhorros;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnTransferencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBalanceActual;
    }
}