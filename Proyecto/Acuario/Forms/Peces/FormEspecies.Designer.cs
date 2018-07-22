namespace Acuario.Forms
{
    partial class FormEspecies
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
            this.gridEspecies = new MetroFramework.Controls.MetroGrid();
            this.columnIdEspecie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEspecie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCrear = new MetroFramework.Controls.MetroButton();
            this.btnModificar = new MetroFramework.Controls.MetroButton();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.textboxEspecie = new MetroFramework.Controls.MetroTextBox();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEspecies)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGrid
            // 
            this.panelGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrid.Controls.Add(this.gridEspecies);
            this.panelGrid.HorizontalScrollbarBarColor = true;
            this.panelGrid.HorizontalScrollbarHighlightOnWheel = false;
            this.panelGrid.HorizontalScrollbarSize = 10;
            this.panelGrid.Location = new System.Drawing.Point(23, 95);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(494, 222);
            this.panelGrid.TabIndex = 0;
            this.panelGrid.VerticalScrollbarBarColor = true;
            this.panelGrid.VerticalScrollbarHighlightOnWheel = false;
            this.panelGrid.VerticalScrollbarSize = 10;
            // 
            // gridEspecies
            // 
            this.gridEspecies.AllowUserToAddRows = false;
            this.gridEspecies.AllowUserToDeleteRows = false;
            this.gridEspecies.AllowUserToResizeRows = false;
            this.gridEspecies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridEspecies.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridEspecies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridEspecies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridEspecies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEspecies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridEspecies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEspecies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIdEspecie,
            this.columnEspecie});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridEspecies.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridEspecies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEspecies.EnableHeadersVisualStyles = false;
            this.gridEspecies.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridEspecies.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridEspecies.Location = new System.Drawing.Point(0, 0);
            this.gridEspecies.Name = "gridEspecies";
            this.gridEspecies.ReadOnly = true;
            this.gridEspecies.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEspecies.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridEspecies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridEspecies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEspecies.Size = new System.Drawing.Size(492, 220);
            this.gridEspecies.TabIndex = 2;
            // 
            // columnIdEspecie
            // 
            this.columnIdEspecie.HeaderText = "ID ESPECIE";
            this.columnIdEspecie.Name = "columnIdEspecie";
            this.columnIdEspecie.ReadOnly = true;
            this.columnIdEspecie.Visible = false;
            // 
            // columnEspecie
            // 
            this.columnEspecie.HeaderText = "ESPECIE";
            this.columnEspecie.Name = "columnEspecie";
            this.columnEspecie.ReadOnly = true;
            this.columnEspecie.Width = 70;
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCrear.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCrear.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnCrear.Location = new System.Drawing.Point(23, 320);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(0);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(165, 30);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Nueva Especie";
            this.btnCrear.UseSelectable = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnModificar.Location = new System.Drawing.Point(188, 320);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(0);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(165, 30);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseSelectable = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnEliminar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnEliminar.Location = new System.Drawing.Point(353, 320);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(164, 30);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseCustomForeColor = true;
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(23, 60);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 25);
            this.metroLabel3.TabIndex = 23;
            this.metroLabel3.Text = "Especie";
            // 
            // textboxEspecie
            // 
            // 
            // 
            // 
            this.textboxEspecie.CustomButton.Image = null;
            this.textboxEspecie.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.textboxEspecie.CustomButton.Name = "";
            this.textboxEspecie.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxEspecie.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxEspecie.CustomButton.TabIndex = 1;
            this.textboxEspecie.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxEspecie.CustomButton.UseSelectable = true;
            this.textboxEspecie.CustomButton.Visible = false;
            this.textboxEspecie.Lines = new string[0];
            this.textboxEspecie.Location = new System.Drawing.Point(97, 62);
            this.textboxEspecie.MaxLength = 32767;
            this.textboxEspecie.Name = "textboxEspecie";
            this.textboxEspecie.PasswordChar = '\0';
            this.textboxEspecie.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxEspecie.SelectedText = "";
            this.textboxEspecie.SelectionLength = 0;
            this.textboxEspecie.SelectionStart = 0;
            this.textboxEspecie.ShortcutsEnabled = true;
            this.textboxEspecie.Size = new System.Drawing.Size(140, 23);
            this.textboxEspecie.TabIndex = 1;
            this.textboxEspecie.UseSelectable = true;
            this.textboxEspecie.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxEspecie.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textboxEspecie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxEspecie_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBuscar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnBuscar.Location = new System.Drawing.Point(397, 60);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 29);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FormEspecies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 370);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.textboxEspecie);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.panelGrid);
            this.MinimumSize = new System.Drawing.Size(540, 370);
            this.Name = "FormEspecies";
            this.Text = "Especies";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEspecies_FormClosed);
            this.Load += new System.EventHandler(this.FormEspecies_Load);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEspecies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelGrid;
        private MetroFramework.Controls.MetroGrid gridEspecies;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdEspecie;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEspecie;
        private MetroFramework.Controls.MetroButton btnCrear;
        private MetroFramework.Controls.MetroButton btnModificar;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox textboxEspecie;
        private MetroFramework.Controls.MetroButton btnBuscar;
    }
}