namespace Acuario.Forms
{
    partial class FormClientes
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panelGrid = new MetroFramework.Controls.MetroPanel();
            this.gridClientes = new MetroFramework.Controls.MetroGrid();
            this.columnIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTelefono1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTelefono2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTelefono3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textboxCliente = new MetroFramework.Controls.MetroTextBox();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.btnModificar = new MetroFramework.Controls.MetroButton();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.btnNuevo = new MetroFramework.Controls.MetroButton();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 25);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Cliente";
            // 
            // panelGrid
            // 
            this.panelGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrid.Controls.Add(this.gridClientes);
            this.panelGrid.HorizontalScrollbarBarColor = true;
            this.panelGrid.HorizontalScrollbarHighlightOnWheel = false;
            this.panelGrid.HorizontalScrollbarSize = 10;
            this.panelGrid.Location = new System.Drawing.Point(23, 95);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(634, 292);
            this.panelGrid.TabIndex = 6;
            this.panelGrid.VerticalScrollbarBarColor = true;
            this.panelGrid.VerticalScrollbarHighlightOnWheel = false;
            this.panelGrid.VerticalScrollbarSize = 10;
            // 
            // gridClientes
            // 
            this.gridClientes.AllowUserToAddRows = false;
            this.gridClientes.AllowUserToDeleteRows = false;
            this.gridClientes.AllowUserToResizeRows = false;
            this.gridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIdCliente,
            this.columnNombre,
            this.columnCUIT,
            this.columnMail,
            this.columnTelefono1,
            this.columnTelefono2,
            this.columnTelefono3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridClientes.EnableHeadersVisualStyles = false;
            this.gridClientes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridClientes.Location = new System.Drawing.Point(0, 0);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.ReadOnly = true;
            this.gridClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridClientes.Size = new System.Drawing.Size(632, 290);
            this.gridClientes.TabIndex = 1;
            // 
            // columnIdCliente
            // 
            this.columnIdCliente.HeaderText = "ID CLIENTE";
            this.columnIdCliente.Name = "columnIdCliente";
            this.columnIdCliente.ReadOnly = true;
            this.columnIdCliente.Visible = false;
            this.columnIdCliente.Width = 84;
            // 
            // columnNombre
            // 
            this.columnNombre.HeaderText = "NOMBRE";
            this.columnNombre.Name = "columnNombre";
            this.columnNombre.ReadOnly = true;
            this.columnNombre.Width = 77;
            // 
            // columnCUIT
            // 
            this.columnCUIT.HeaderText = "CUIT";
            this.columnCUIT.Name = "columnCUIT";
            this.columnCUIT.ReadOnly = true;
            this.columnCUIT.Width = 53;
            // 
            // columnMail
            // 
            this.columnMail.HeaderText = "MAIL";
            this.columnMail.Name = "columnMail";
            this.columnMail.ReadOnly = true;
            this.columnMail.Width = 55;
            // 
            // columnTelefono1
            // 
            this.columnTelefono1.HeaderText = "TELEFONO 1";
            this.columnTelefono1.Name = "columnTelefono1";
            this.columnTelefono1.ReadOnly = true;
            this.columnTelefono1.Width = 93;
            // 
            // columnTelefono2
            // 
            this.columnTelefono2.HeaderText = "TELEFONO 2";
            this.columnTelefono2.Name = "columnTelefono2";
            this.columnTelefono2.ReadOnly = true;
            this.columnTelefono2.Width = 93;
            // 
            // columnTelefono3
            // 
            this.columnTelefono3.HeaderText = "TELEFONO 3";
            this.columnTelefono3.Name = "columnTelefono3";
            this.columnTelefono3.ReadOnly = true;
            this.columnTelefono3.Width = 93;
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
            this.textboxCliente.Location = new System.Drawing.Point(121, 63);
            this.textboxCliente.MaxLength = 32767;
            this.textboxCliente.Name = "textboxCliente";
            this.textboxCliente.PasswordChar = '\0';
            this.textboxCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxCliente.SelectedText = "";
            this.textboxCliente.SelectionLength = 0;
            this.textboxCliente.SelectionStart = 0;
            this.textboxCliente.ShortcutsEnabled = true;
            this.textboxCliente.Size = new System.Drawing.Size(140, 23);
            this.textboxCliente.TabIndex = 13;
            this.textboxCliente.UseSelectable = true;
            this.textboxCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(267, 60);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 29);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnModificar.Location = new System.Drawing.Point(327, 390);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(0);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(165, 30);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseSelectable = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnEliminar.Location = new System.Drawing.Point(492, 390);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(165, 30);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnNuevo.Location = new System.Drawing.Point(24, 390);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(0);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(165, 30);
            this.btnNuevo.TabIndex = 16;
            this.btnNuevo.Text = "Nuevo Cliente";
            this.btnNuevo.UseSelectable = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 440);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textboxCliente);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.metroLabel1);
            this.MinimumSize = new System.Drawing.Size(680, 440);
            this.Name = "FormClientes";
            this.Text = "Clientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClientes_FormClosed);
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel panelGrid;
        private MetroFramework.Controls.MetroGrid gridClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTelefono1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTelefono2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTelefono3;
        private MetroFramework.Controls.MetroTextBox textboxCliente;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroButton btnModificar;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroButton btnNuevo;
    }
}