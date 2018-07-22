namespace Acuario.Forms
{
    partial class FormNuevaVariedad
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.textboxNombre = new MetroFramework.Controls.MetroTextBox();
            this.comboboxEspecies = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnCrearVariedad = new MetroFramework.Controls.MetroButton();
            this.btnNuevaEspecie = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.textboxNombre);
            this.metroPanel1.Controls.Add(this.comboboxEspecies);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(332, 112);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // textboxNombre
            // 
            // 
            // 
            // 
            this.textboxNombre.CustomButton.Image = null;
            this.textboxNombre.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.textboxNombre.CustomButton.Name = "";
            this.textboxNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxNombre.CustomButton.TabIndex = 1;
            this.textboxNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxNombre.CustomButton.UseSelectable = true;
            this.textboxNombre.CustomButton.Visible = false;
            this.textboxNombre.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textboxNombre.Lines = new string[0];
            this.textboxNombre.Location = new System.Drawing.Point(98, 62);
            this.textboxNombre.MaxLength = 32767;
            this.textboxNombre.Name = "textboxNombre";
            this.textboxNombre.PasswordChar = '\0';
            this.textboxNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxNombre.SelectedText = "";
            this.textboxNombre.SelectionLength = 0;
            this.textboxNombre.SelectionStart = 0;
            this.textboxNombre.ShortcutsEnabled = true;
            this.textboxNombre.Size = new System.Drawing.Size(195, 23);
            this.textboxNombre.TabIndex = 2;
            this.textboxNombre.UseSelectable = true;
            this.textboxNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // comboboxEspecies
            // 
            this.comboboxEspecies.FormattingEnabled = true;
            this.comboboxEspecies.ItemHeight = 23;
            this.comboboxEspecies.Location = new System.Drawing.Point(98, 27);
            this.comboboxEspecies.Name = "comboboxEspecies";
            this.comboboxEspecies.Size = new System.Drawing.Size(195, 29);
            this.comboboxEspecies.TabIndex = 1;
            this.comboboxEspecies.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(17, 27);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 25);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Especie";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(17, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 25);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Nombre";
            // 
            // btnCrearVariedad
            // 
            this.btnCrearVariedad.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCrearVariedad.Location = new System.Drawing.Point(23, 178);
            this.btnCrearVariedad.Margin = new System.Windows.Forms.Padding(0);
            this.btnCrearVariedad.Name = "btnCrearVariedad";
            this.btnCrearVariedad.Size = new System.Drawing.Size(165, 30);
            this.btnCrearVariedad.TabIndex = 3;
            this.btnCrearVariedad.Text = "Crear Variedad";
            this.btnCrearVariedad.UseSelectable = true;
            this.btnCrearVariedad.Click += new System.EventHandler(this.btnCrearVariedad_Click);
            // 
            // btnNuevaEspecie
            // 
            this.btnNuevaEspecie.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnNuevaEspecie.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnNuevaEspecie.Location = new System.Drawing.Point(188, 178);
            this.btnNuevaEspecie.Margin = new System.Windows.Forms.Padding(0);
            this.btnNuevaEspecie.Name = "btnNuevaEspecie";
            this.btnNuevaEspecie.Size = new System.Drawing.Size(167, 30);
            this.btnNuevaEspecie.TabIndex = 4;
            this.btnNuevaEspecie.Text = "Nueva Especie";
            this.btnNuevaEspecie.UseSelectable = true;
            this.btnNuevaEspecie.Click += new System.EventHandler(this.btnNuevaEspecie_Click);
            // 
            // FormNuevaVariedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 230);
            this.Controls.Add(this.btnNuevaEspecie);
            this.Controls.Add(this.btnCrearVariedad);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(375, 230);
            this.MinimumSize = new System.Drawing.Size(375, 230);
            this.Name = "FormNuevaVariedad";
            this.Text = "Nueva Variedad";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNuevaVariedad_FormClosed);
            this.Load += new System.EventHandler(this.FormNuevaVariedad_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox textboxNombre;
        private MetroFramework.Controls.MetroComboBox comboboxEspecies;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnCrearVariedad;
        private MetroFramework.Controls.MetroButton btnNuevaEspecie;
    }
}