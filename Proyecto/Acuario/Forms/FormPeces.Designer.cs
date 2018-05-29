namespace Acuario.Forms
{
    partial class FormPeces
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
            this.gridPeces = new MetroFramework.Controls.MetroGrid();
            this.columIdPez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdEspecie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdVariedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdTamaño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEspecie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnVariedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTamaño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrecioMenor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrecioMayor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrecioOferta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrecioDistribuidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelGrid = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.comboboxEspecies = new MetroFramework.Controls.MetroComboBox();
            this.comboboxVariedades = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.btnNuevoPez = new MetroFramework.Controls.MetroButton();
            this.textboxNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.bnEliminar = new MetroFramework.Controls.MetroButton();
            this.btnModificar = new MetroFramework.Controls.MetroButton();
            this.btnVerVariedades = new MetroFramework.Controls.MetroButton();
            this.btnVerEspecies = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridPeces)).BeginInit();
            this.panelGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridPeces
            // 
            this.gridPeces.AllowUserToAddRows = false;
            this.gridPeces.AllowUserToDeleteRows = false;
            this.gridPeces.AllowUserToResizeRows = false;
            this.gridPeces.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridPeces.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridPeces.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPeces.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridPeces.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPeces.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPeces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPeces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columIdPez,
            this.columnIdEspecie,
            this.columnIdVariedad,
            this.columnIdTamaño,
            this.columnIdPrecio,
            this.columnNombre,
            this.columnEspecie,
            this.columnVariedad,
            this.columnTamaño,
            this.columnStock,
            this.columnPrecioMenor,
            this.columnPrecioMayor,
            this.columnPrecioOferta,
            this.columnPrecioDistribuidor});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPeces.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridPeces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPeces.EnableHeadersVisualStyles = false;
            this.gridPeces.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridPeces.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridPeces.Location = new System.Drawing.Point(0, 0);
            this.gridPeces.Name = "gridPeces";
            this.gridPeces.ReadOnly = true;
            this.gridPeces.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPeces.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridPeces.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridPeces.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPeces.Size = new System.Drawing.Size(792, 316);
            this.gridPeces.TabIndex = 2;
            // 
            // columIdPez
            // 
            this.columIdPez.HeaderText = "ID PEZ";
            this.columIdPez.Name = "columIdPez";
            this.columIdPez.ReadOnly = true;
            this.columIdPez.Visible = false;
            // 
            // columnIdEspecie
            // 
            this.columnIdEspecie.HeaderText = "ID ESPECIE";
            this.columnIdEspecie.Name = "columnIdEspecie";
            this.columnIdEspecie.ReadOnly = true;
            this.columnIdEspecie.Visible = false;
            // 
            // columnIdVariedad
            // 
            this.columnIdVariedad.HeaderText = "ID VARIEDAD";
            this.columnIdVariedad.Name = "columnIdVariedad";
            this.columnIdVariedad.ReadOnly = true;
            this.columnIdVariedad.Visible = false;
            // 
            // columnIdTamaño
            // 
            this.columnIdTamaño.HeaderText = "ID TAMAÑO";
            this.columnIdTamaño.Name = "columnIdTamaño";
            this.columnIdTamaño.ReadOnly = true;
            this.columnIdTamaño.Visible = false;
            // 
            // columnIdPrecio
            // 
            this.columnIdPrecio.HeaderText = "ID PRECIO";
            this.columnIdPrecio.Name = "columnIdPrecio";
            this.columnIdPrecio.ReadOnly = true;
            this.columnIdPrecio.Visible = false;
            // 
            // columnNombre
            // 
            this.columnNombre.HeaderText = "NOMBRE";
            this.columnNombre.Name = "columnNombre";
            this.columnNombre.ReadOnly = true;
            this.columnNombre.Width = 77;
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
            // columnTamaño
            // 
            this.columnTamaño.HeaderText = "TAMAÑO";
            this.columnTamaño.Name = "columnTamaño";
            this.columnTamaño.ReadOnly = true;
            this.columnTamaño.Width = 75;
            // 
            // columnStock
            // 
            this.columnStock.HeaderText = "STOCK";
            this.columnStock.Name = "columnStock";
            this.columnStock.ReadOnly = true;
            this.columnStock.Width = 62;
            // 
            // columnPrecioMenor
            // 
            this.columnPrecioMenor.HeaderText = "PRECIO MENOR";
            this.columnPrecioMenor.Name = "columnPrecioMenor";
            this.columnPrecioMenor.ReadOnly = true;
            this.columnPrecioMenor.Width = 102;
            // 
            // columnPrecioMayor
            // 
            this.columnPrecioMayor.HeaderText = "PRECIO MAYOR";
            this.columnPrecioMayor.Name = "columnPrecioMayor";
            this.columnPrecioMayor.ReadOnly = true;
            this.columnPrecioMayor.Width = 99;
            // 
            // columnPrecioOferta
            // 
            this.columnPrecioOferta.HeaderText = "PRECIO OFERTA";
            this.columnPrecioOferta.Name = "columnPrecioOferta";
            this.columnPrecioOferta.ReadOnly = true;
            this.columnPrecioOferta.Width = 101;
            // 
            // columnPrecioDistribuidor
            // 
            this.columnPrecioDistribuidor.HeaderText = "PRECIO DISTRIBUIDOR";
            this.columnPrecioDistribuidor.Name = "columnPrecioDistribuidor";
            this.columnPrecioDistribuidor.ReadOnly = true;
            this.columnPrecioDistribuidor.Width = 132;
            // 
            // panelGrid
            // 
            this.panelGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrid.Controls.Add(this.gridPeces);
            this.panelGrid.HorizontalScrollbarBarColor = true;
            this.panelGrid.HorizontalScrollbarHighlightOnWheel = false;
            this.panelGrid.HorizontalScrollbarSize = 10;
            this.panelGrid.Location = new System.Drawing.Point(23, 126);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(794, 318);
            this.panelGrid.TabIndex = 3;
            this.panelGrid.VerticalScrollbarBarColor = true;
            this.panelGrid.VerticalScrollbarHighlightOnWheel = false;
            this.panelGrid.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(251, 91);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 25);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Especie";
            // 
            // comboboxEspecies
            // 
            this.comboboxEspecies.FormattingEnabled = true;
            this.comboboxEspecies.ItemHeight = 23;
            this.comboboxEspecies.Location = new System.Drawing.Point(325, 91);
            this.comboboxEspecies.Name = "comboboxEspecies";
            this.comboboxEspecies.Size = new System.Drawing.Size(159, 29);
            this.comboboxEspecies.TabIndex = 5;
            this.comboboxEspecies.UseSelectable = true;
            this.comboboxEspecies.SelectedIndexChanged += new System.EventHandler(this.comboboxEspecies_SelectedIndexChanged);
            // 
            // comboboxVariedades
            // 
            this.comboboxVariedades.FormattingEnabled = true;
            this.comboboxVariedades.ItemHeight = 23;
            this.comboboxVariedades.Location = new System.Drawing.Point(574, 91);
            this.comboboxVariedades.Name = "comboboxVariedades";
            this.comboboxVariedades.Size = new System.Drawing.Size(159, 29);
            this.comboboxVariedades.TabIndex = 7;
            this.comboboxVariedades.UseSelectable = true;
            this.comboboxVariedades.SelectedIndexChanged += new System.EventHandler(this.comboboxVariedades_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(490, 91);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 25);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Variedad";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(741, 91);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 29);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNuevoPez
            // 
            this.btnNuevoPez.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoPez.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnNuevoPez.Location = new System.Drawing.Point(24, 450);
            this.btnNuevoPez.Margin = new System.Windows.Forms.Padding(0);
            this.btnNuevoPez.Name = "btnNuevoPez";
            this.btnNuevoPez.Size = new System.Drawing.Size(165, 30);
            this.btnNuevoPez.TabIndex = 11;
            this.btnNuevoPez.Text = "Nuevo Pez";
            this.btnNuevoPez.UseSelectable = true;
            this.btnNuevoPez.Click += new System.EventHandler(this.btnNuevoPez_Click);
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
            this.textboxNombre.Location = new System.Drawing.Point(105, 93);
            this.textboxNombre.MaxLength = 32767;
            this.textboxNombre.Name = "textboxNombre";
            this.textboxNombre.PasswordChar = '\0';
            this.textboxNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxNombre.SelectedText = "";
            this.textboxNombre.SelectionLength = 0;
            this.textboxNombre.SelectionStart = 0;
            this.textboxNombre.ShortcutsEnabled = true;
            this.textboxNombre.Size = new System.Drawing.Size(140, 23);
            this.textboxNombre.TabIndex = 12;
            this.textboxNombre.UseSelectable = true;
            this.textboxNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(24, 91);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(75, 25);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Nombre";
            // 
            // bnEliminar
            // 
            this.bnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bnEliminar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bnEliminar.Location = new System.Drawing.Point(189, 480);
            this.bnEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.bnEliminar.Name = "bnEliminar";
            this.bnEliminar.Size = new System.Drawing.Size(165, 30);
            this.bnEliminar.TabIndex = 14;
            this.bnEliminar.Text = "Eliminar";
            this.bnEliminar.UseSelectable = true;
            this.bnEliminar.Click += new System.EventHandler(this.bnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnModificar.Location = new System.Drawing.Point(24, 480);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(0);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(165, 30);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseSelectable = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnVerVariedades
            // 
            this.btnVerVariedades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerVariedades.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnVerVariedades.Location = new System.Drawing.Point(652, 450);
            this.btnVerVariedades.Margin = new System.Windows.Forms.Padding(0);
            this.btnVerVariedades.Name = "btnVerVariedades";
            this.btnVerVariedades.Size = new System.Drawing.Size(165, 30);
            this.btnVerVariedades.TabIndex = 16;
            this.btnVerVariedades.Text = "Ver Variedades";
            this.btnVerVariedades.UseSelectable = true;
            this.btnVerVariedades.Click += new System.EventHandler(this.btnVerVariedades_Click);
            // 
            // btnVerEspecies
            // 
            this.btnVerEspecies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerEspecies.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnVerEspecies.Location = new System.Drawing.Point(490, 450);
            this.btnVerEspecies.Margin = new System.Windows.Forms.Padding(0);
            this.btnVerEspecies.Name = "btnVerEspecies";
            this.btnVerEspecies.Size = new System.Drawing.Size(165, 30);
            this.btnVerEspecies.TabIndex = 17;
            this.btnVerEspecies.Text = "Ver Especies";
            this.btnVerEspecies.UseSelectable = true;
            this.btnVerEspecies.Click += new System.EventHandler(this.btnVerEspecies_Click);
            // 
            // FormPeces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 530);
            this.Controls.Add(this.btnVerEspecies);
            this.Controls.Add(this.btnVerVariedades);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.bnEliminar);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.textboxNombre);
            this.Controls.Add(this.btnNuevoPez);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.comboboxVariedades);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.comboboxEspecies);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.panelGrid);
            this.MinimumSize = new System.Drawing.Size(840, 530);
            this.Name = "FormPeces";
            this.Text = "Peces";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPeces_FormClosed);
            this.Load += new System.EventHandler(this.FormPeces_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPeces)).EndInit();
            this.panelGrid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid gridPeces;
        private MetroFramework.Controls.MetroPanel panelGrid;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox comboboxEspecies;
        private MetroFramework.Controls.MetroComboBox comboboxVariedades;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroButton btnNuevoPez;
        private MetroFramework.Controls.MetroTextBox textboxNombre;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn columIdPez;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdEspecie;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdVariedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdTamaño;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEspecie;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnVariedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTamaño;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrecioMenor;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrecioMayor;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrecioOferta;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrecioDistribuidor;
        private MetroFramework.Controls.MetroButton bnEliminar;
        private MetroFramework.Controls.MetroButton btnModificar;
        private MetroFramework.Controls.MetroButton btnVerVariedades;
        private MetroFramework.Controls.MetroButton btnVerEspecies;
    }
}