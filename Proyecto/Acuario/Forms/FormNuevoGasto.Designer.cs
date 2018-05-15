namespace Acuario.Forms
{
    partial class FormNuevoGasto
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
            this.btnGenerar = new MetroFramework.Controls.MetroButton();
            this.textboxDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.comboBoxCategorias = new MetroFramework.Controls.MetroComboBox();
            this.datetimeFecha = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.textboxMonto = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerar.Location = new System.Drawing.Point(23, 187);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(0);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(583, 30);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseSelectable = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // textboxDescripcion
            // 
            // 
            // 
            // 
            this.textboxDescripcion.CustomButton.Image = null;
            this.textboxDescripcion.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.textboxDescripcion.CustomButton.Name = "";
            this.textboxDescripcion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxDescripcion.CustomButton.TabIndex = 1;
            this.textboxDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxDescripcion.CustomButton.UseSelectable = true;
            this.textboxDescripcion.CustomButton.Visible = false;
            this.textboxDescripcion.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textboxDescripcion.Lines = new string[0];
            this.textboxDescripcion.Location = new System.Drawing.Point(137, 17);
            this.textboxDescripcion.MaxLength = 32767;
            this.textboxDescripcion.Name = "textboxDescripcion";
            this.textboxDescripcion.PasswordChar = '\0';
            this.textboxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxDescripcion.SelectedText = "";
            this.textboxDescripcion.SelectionLength = 0;
            this.textboxDescripcion.SelectionStart = 0;
            this.textboxDescripcion.ShortcutsEnabled = true;
            this.textboxDescripcion.Size = new System.Drawing.Size(94, 23);
            this.textboxDescripcion.TabIndex = 1;
            this.textboxDescripcion.UseSelectable = true;
            this.textboxDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxDescripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(19, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Descripción";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.comboBoxCategorias);
            this.metroPanel1.Controls.Add(this.datetimeFecha);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.textboxMonto);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.textboxDescripcion);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(583, 121);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(269, 50);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(92, 25);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Categorias";
            // 
            // comboBoxCategorias
            // 
            this.comboBoxCategorias.FormattingEnabled = true;
            this.comboBoxCategorias.ItemHeight = 23;
            this.comboBoxCategorias.Location = new System.Drawing.Point(378, 50);
            this.comboBoxCategorias.Name = "comboBoxCategorias";
            this.comboBoxCategorias.Size = new System.Drawing.Size(200, 29);
            this.comboBoxCategorias.TabIndex = 8;
            this.comboBoxCategorias.UseSelectable = true;
            // 
            // datetimeFecha
            // 
            this.datetimeFecha.Location = new System.Drawing.Point(378, 15);
            this.datetimeFecha.MinimumSize = new System.Drawing.Size(0, 29);
            this.datetimeFecha.Name = "datetimeFecha";
            this.datetimeFecha.Size = new System.Drawing.Size(200, 29);
            this.datetimeFecha.TabIndex = 7;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(269, 15);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 25);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Fecha";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(19, 44);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 25);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Monto";
            // 
            // textboxMonto
            // 
            // 
            // 
            // 
            this.textboxMonto.CustomButton.Image = null;
            this.textboxMonto.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.textboxMonto.CustomButton.Name = "";
            this.textboxMonto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxMonto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxMonto.CustomButton.TabIndex = 1;
            this.textboxMonto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxMonto.CustomButton.UseSelectable = true;
            this.textboxMonto.CustomButton.Visible = false;
            this.textboxMonto.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textboxMonto.Lines = new string[0];
            this.textboxMonto.Location = new System.Drawing.Point(137, 46);
            this.textboxMonto.MaxLength = 32767;
            this.textboxMonto.Name = "textboxMonto";
            this.textboxMonto.PasswordChar = '\0';
            this.textboxMonto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxMonto.SelectedText = "";
            this.textboxMonto.SelectionLength = 0;
            this.textboxMonto.SelectionStart = 0;
            this.textboxMonto.ShortcutsEnabled = true;
            this.textboxMonto.Size = new System.Drawing.Size(94, 23);
            this.textboxMonto.TabIndex = 3;
            this.textboxMonto.UseSelectable = true;
            this.textboxMonto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxMonto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FormNuevoGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 250);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btnGenerar);
            this.Name = "FormNuevoGasto";
            this.Text = "Nuevo Gasto";
            this.Load += new System.EventHandler(this.FormNuevoGasto_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnGenerar;
        private MetroFramework.Controls.MetroTextBox textboxDescripcion;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox textboxMonto;
        private MetroFramework.Controls.MetroDateTime datetimeFecha;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox comboBoxCategorias;
    }
}