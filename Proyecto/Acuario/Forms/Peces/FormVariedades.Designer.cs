namespace Acuario.Forms
{
    partial class FormVariedades
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
            this.gridVariedades = new MetroFramework.Controls.MetroGrid();
            this.columnIdEspecie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdVariedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEspecie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnVariedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.textboxVariedad = new MetroFramework.Controls.MetroTextBox();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.comboboxEspecies = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.btnModificar = new MetroFramework.Controls.MetroButton();
            this.btnCrear = new MetroFramework.Controls.MetroButton();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVariedades)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGrid
            // 
            this.panelGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrid.Controls.Add(this.gridVariedades);
            this.panelGrid.HorizontalScrollbarBarColor = true;
            this.panelGrid.HorizontalScrollbarHighlightOnWheel = false;
            this.panelGrid.HorizontalScrollbarSize = 10;
            this.panelGrid.Location = new System.Drawing.Point(23, 95);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(594, 240);
            this.panelGrid.TabIndex = 0;
            this.panelGrid.VerticalScrollbarBarColor = true;
            this.panelGrid.VerticalScrollbarHighlightOnWheel = false;
            this.panelGrid.VerticalScrollbarSize = 10;
            // 
            // gridVariedades
            // 
            this.gridVariedades.AllowUserToAddRows = false;
            this.gridVariedades.AllowUserToDeleteRows = false;
            this.gridVariedades.AllowUserToResizeRows = false;
            this.gridVariedades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridVariedades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridVariedades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridVariedades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridVariedades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridVariedades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridVariedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVariedades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIdEspecie,
            this.columnIdVariedad,
            this.columnEspecie,
            this.columnVariedad});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridVariedades.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridVariedades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridVariedades.EnableHeadersVisualStyles = false;
            this.gridVariedades.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridVariedades.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridVariedades.Location = new System.Drawing.Point(0, 0);
            this.gridVariedades.Name = "gridVariedades";
            this.gridVariedades.ReadOnly = true;
            this.gridVariedades.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridVariedades.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridVariedades.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridVariedades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridVariedades.Size = new System.Drawing.Size(592, 238);
            this.gridVariedades.TabIndex = 1;
            // 
            // columnIdEspecie
            // 
            this.columnIdEspecie.HeaderText = "ID ESPECIE";
            this.columnIdEspecie.Name = "columnIdEspecie";
            this.columnIdEspecie.ReadOnly = true;
            this.columnIdEspecie.Visible = false;
            this.columnIdEspecie.Width = 84;
            // 
            // columnIdVariedad
            // 
            this.columnIdVariedad.HeaderText = "ID VARIEDAD";
            this.columnIdVariedad.Name = "columnIdVariedad";
            this.columnIdVariedad.ReadOnly = true;
            this.columnIdVariedad.Visible = false;
            this.columnIdVariedad.Width = 96;
            // 
            // columnEspecie
            // 
            this.columnEspecie.HeaderText = "ESPECIE";
            this.columnEspecie.Name = "columnEspecie";
            this.columnEspecie.ReadOnly = true;
            this.columnEspecie.Width = 70;
            // 
            // columnVariedad
            // 
            this.columnVariedad.HeaderText = "VARIEDAD";
            this.columnVariedad.Name = "columnVariedad";
            this.columnVariedad.ReadOnly = true;
            this.columnVariedad.Width = 82;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(23, 60);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(78, 25);
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "Variedad";
            // 
            // textboxVariedad
            // 
            // 
            // 
            // 
            this.textboxVariedad.CustomButton.Image = null;
            this.textboxVariedad.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.textboxVariedad.CustomButton.Name = "";
            this.textboxVariedad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxVariedad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxVariedad.CustomButton.TabIndex = 1;
            this.textboxVariedad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxVariedad.CustomButton.UseSelectable = true;
            this.textboxVariedad.CustomButton.Visible = false;
            this.textboxVariedad.Lines = new string[0];
            this.textboxVariedad.Location = new System.Drawing.Point(107, 63);
            this.textboxVariedad.MaxLength = 32767;
            this.textboxVariedad.Name = "textboxVariedad";
            this.textboxVariedad.PasswordChar = '\0';
            this.textboxVariedad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxVariedad.SelectedText = "";
            this.textboxVariedad.SelectionLength = 0;
            this.textboxVariedad.SelectionStart = 0;
            this.textboxVariedad.ShortcutsEnabled = true;
            this.textboxVariedad.Size = new System.Drawing.Size(140, 23);
            this.textboxVariedad.TabIndex = 1;
            this.textboxVariedad.UseSelectable = true;
            this.textboxVariedad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxVariedad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textboxVariedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxVariedad_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBuscar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnBuscar.Location = new System.Drawing.Point(497, 60);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 29);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // comboboxEspecies
            // 
            this.comboboxEspecies.FormattingEnabled = true;
            this.comboboxEspecies.ItemHeight = 23;
            this.comboboxEspecies.Location = new System.Drawing.Point(327, 60);
            this.comboboxEspecies.Name = "comboboxEspecies";
            this.comboboxEspecies.Size = new System.Drawing.Size(159, 29);
            this.comboboxEspecies.TabIndex = 2;
            this.comboboxEspecies.UseSelectable = true;
            this.comboboxEspecies.SelectedIndexChanged += new System.EventHandler(this.comboboxEspecies_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(253, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 25);
            this.metroLabel1.TabIndex = 27;
            this.metroLabel1.Text = "Especie";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnEliminar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnEliminar.Location = new System.Drawing.Point(452, 337);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(165, 30);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseCustomForeColor = true;
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnModificar.Location = new System.Drawing.Point(287, 337);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(0);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(165, 30);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseSelectable = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCrear.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCrear.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnCrear.Location = new System.Drawing.Point(24, 337);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(0);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(165, 30);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "Nueva Variedad";
            this.btnCrear.UseSelectable = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // FormVariedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 400);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.comboboxEspecies);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.textboxVariedad);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panelGrid);
            this.MinimumSize = new System.Drawing.Size(642, 400);
            this.Name = "FormVariedades";
            this.Text = "Variedades";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormVariedades_FormClosed);
            this.Load += new System.EventHandler(this.FormVariedades_Load);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridVariedades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelGrid;
        private MetroFramework.Controls.MetroGrid gridVariedades;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox textboxVariedad;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroComboBox comboboxEspecies;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroButton btnModificar;
        private MetroFramework.Controls.MetroButton btnCrear;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdEspecie;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdVariedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEspecie;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnVariedad;
    }
}