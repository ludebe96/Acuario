namespace Acuario.Forms
{
    partial class FormTransferir
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridDe = new MetroFramework.Controls.MetroGrid();
            this.panelGrillaDe = new MetroFramework.Controls.MetroPanel();
            this.panelGrillaA = new MetroFramework.Controls.MetroPanel();
            this.gridA = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.textboxMonto = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.buttonTransferir = new MetroFramework.Controls.MetroButton();
            this.columnIdCuentaA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCuentaA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnBalanceActualA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdCuentaDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCuentaDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnBalanceActualDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridDe)).BeginInit();
            this.panelGrillaDe.SuspendLayout();
            this.panelGrillaA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridA)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDe
            // 
            this.gridDe.AllowUserToAddRows = false;
            this.gridDe.AllowUserToDeleteRows = false;
            this.gridDe.AllowUserToResizeRows = false;
            this.gridDe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridDe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridDe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIdCuentaDe,
            this.columnCuentaDe,
            this.columnBalanceActualDe});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDe.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDe.EnableHeadersVisualStyles = false;
            this.gridDe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridDe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridDe.Location = new System.Drawing.Point(0, 0);
            this.gridDe.MultiSelect = false;
            this.gridDe.Name = "gridDe";
            this.gridDe.ReadOnly = true;
            this.gridDe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDe.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridDe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridDe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDe.Size = new System.Drawing.Size(282, 282);
            this.gridDe.TabIndex = 3;
            // 
            // panelGrillaDe
            // 
            this.panelGrillaDe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrillaDe.Controls.Add(this.gridDe);
            this.panelGrillaDe.HorizontalScrollbarBarColor = true;
            this.panelGrillaDe.HorizontalScrollbarHighlightOnWheel = false;
            this.panelGrillaDe.HorizontalScrollbarSize = 10;
            this.panelGrillaDe.Location = new System.Drawing.Point(23, 106);
            this.panelGrillaDe.Name = "panelGrillaDe";
            this.panelGrillaDe.Size = new System.Drawing.Size(284, 284);
            this.panelGrillaDe.TabIndex = 4;
            this.panelGrillaDe.VerticalScrollbarBarColor = true;
            this.panelGrillaDe.VerticalScrollbarHighlightOnWheel = false;
            this.panelGrillaDe.VerticalScrollbarSize = 10;
            // 
            // panelGrillaA
            // 
            this.panelGrillaA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrillaA.Controls.Add(this.gridA);
            this.panelGrillaA.HorizontalScrollbarBarColor = true;
            this.panelGrillaA.HorizontalScrollbarHighlightOnWheel = false;
            this.panelGrillaA.HorizontalScrollbarSize = 10;
            this.panelGrillaA.Location = new System.Drawing.Point(313, 106);
            this.panelGrillaA.Name = "panelGrillaA";
            this.panelGrillaA.Size = new System.Drawing.Size(284, 284);
            this.panelGrillaA.TabIndex = 5;
            this.panelGrillaA.VerticalScrollbarBarColor = true;
            this.panelGrillaA.VerticalScrollbarHighlightOnWheel = false;
            this.panelGrillaA.VerticalScrollbarSize = 10;
            // 
            // gridA
            // 
            this.gridA.AllowUserToAddRows = false;
            this.gridA.AllowUserToDeleteRows = false;
            this.gridA.AllowUserToResizeRows = false;
            this.gridA.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIdCuentaA,
            this.columnCuentaA,
            this.columnBalanceActualA});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridA.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridA.EnableHeadersVisualStyles = false;
            this.gridA.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridA.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridA.Location = new System.Drawing.Point(0, 0);
            this.gridA.MultiSelect = false;
            this.gridA.Name = "gridA";
            this.gridA.ReadOnly = true;
            this.gridA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridA.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridA.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridA.Size = new System.Drawing.Size(282, 282);
            this.gridA.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(24, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 25);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "De:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(314, 79);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(27, 25);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "A:";
            // 
            // textboxMonto
            // 
            // 
            // 
            // 
            this.textboxMonto.CustomButton.Image = null;
            this.textboxMonto.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.textboxMonto.CustomButton.Name = "";
            this.textboxMonto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxMonto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxMonto.CustomButton.TabIndex = 1;
            this.textboxMonto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxMonto.CustomButton.UseSelectable = true;
            this.textboxMonto.CustomButton.Visible = false;
            this.textboxMonto.Lines = new string[0];
            this.textboxMonto.Location = new System.Drawing.Point(182, 398);
            this.textboxMonto.MaxLength = 32767;
            this.textboxMonto.Name = "textboxMonto";
            this.textboxMonto.PasswordChar = '\0';
            this.textboxMonto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxMonto.SelectedText = "";
            this.textboxMonto.SelectionLength = 0;
            this.textboxMonto.SelectionStart = 0;
            this.textboxMonto.ShortcutsEnabled = true;
            this.textboxMonto.Size = new System.Drawing.Size(205, 23);
            this.textboxMonto.TabIndex = 1;
            this.textboxMonto.UseSelectable = true;
            this.textboxMonto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxMonto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textboxMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxMonto_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(23, 396);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(153, 25);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Monto a transferir:";
            // 
            // buttonTransferir
            // 
            this.buttonTransferir.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.buttonTransferir.Location = new System.Drawing.Point(429, 396);
            this.buttonTransferir.Name = "buttonTransferir";
            this.buttonTransferir.Size = new System.Drawing.Size(168, 30);
            this.buttonTransferir.TabIndex = 2;
            this.buttonTransferir.Text = "Realizar Transferencia";
            this.buttonTransferir.UseSelectable = true;
            this.buttonTransferir.Click += new System.EventHandler(this.buttonTransferir_Click);
            // 
            // columnIdCuentaA
            // 
            this.columnIdCuentaA.HeaderText = "ID Cuenta";
            this.columnIdCuentaA.Name = "columnIdCuentaA";
            this.columnIdCuentaA.ReadOnly = true;
            this.columnIdCuentaA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnIdCuentaA.Visible = false;
            // 
            // columnCuentaA
            // 
            this.columnCuentaA.HeaderText = "Cuenta";
            this.columnCuentaA.Name = "columnCuentaA";
            this.columnCuentaA.ReadOnly = true;
            this.columnCuentaA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnCuentaA.Width = 122;
            // 
            // columnBalanceActualA
            // 
            this.columnBalanceActualA.HeaderText = "Balance Actual";
            this.columnBalanceActualA.Name = "columnBalanceActualA";
            this.columnBalanceActualA.ReadOnly = true;
            this.columnBalanceActualA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnBalanceActualA.Width = 122;
            // 
            // columnIdCuentaDe
            // 
            this.columnIdCuentaDe.HeaderText = "ID Cuenta";
            this.columnIdCuentaDe.Name = "columnIdCuentaDe";
            this.columnIdCuentaDe.ReadOnly = true;
            this.columnIdCuentaDe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnIdCuentaDe.Visible = false;
            // 
            // columnCuentaDe
            // 
            this.columnCuentaDe.HeaderText = "Cuenta";
            this.columnCuentaDe.Name = "columnCuentaDe";
            this.columnCuentaDe.ReadOnly = true;
            this.columnCuentaDe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnCuentaDe.Width = 122;
            // 
            // columnBalanceActualDe
            // 
            this.columnBalanceActualDe.HeaderText = "Balance Actual";
            this.columnBalanceActualDe.Name = "columnBalanceActualDe";
            this.columnBalanceActualDe.ReadOnly = true;
            this.columnBalanceActualDe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnBalanceActualDe.Width = 122;
            // 
            // FormTransferir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 452);
            this.Controls.Add(this.buttonTransferir);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.textboxMonto);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.panelGrillaA);
            this.Controls.Add(this.panelGrillaDe);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(617, 452);
            this.MinimumSize = new System.Drawing.Size(617, 452);
            this.Name = "FormTransferir";
            this.Text = "Transferencias";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTransferir_FormClosed);
            this.Load += new System.EventHandler(this.FormTransferir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDe)).EndInit();
            this.panelGrillaDe.ResumeLayout(false);
            this.panelGrillaA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid gridDe;
        private MetroFramework.Controls.MetroPanel panelGrillaDe;
        private MetroFramework.Controls.MetroPanel panelGrillaA;
        private MetroFramework.Controls.MetroGrid gridA;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox textboxMonto;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton buttonTransferir;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdCuentaA;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCuentaA;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBalanceActualA;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdCuentaDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCuentaDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBalanceActualDe;
    }
}