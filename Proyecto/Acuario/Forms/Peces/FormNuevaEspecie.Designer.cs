namespace Acuario.Forms
{
    partial class FormNuevaEspecie
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.textboxNombre = new MetroFramework.Controls.MetroTextBox();
            this.btnCrearEspecie = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.textboxNombre);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(289, 62);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(12, 14);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 25);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Especie";
            // 
            // textboxNombre
            // 
            // 
            // 
            // 
            this.textboxNombre.CustomButton.Image = null;
            this.textboxNombre.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.textboxNombre.CustomButton.Name = "";
            this.textboxNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxNombre.CustomButton.TabIndex = 1;
            this.textboxNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxNombre.CustomButton.UseSelectable = true;
            this.textboxNombre.CustomButton.Visible = false;
            this.textboxNombre.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textboxNombre.Lines = new string[0];
            this.textboxNombre.Location = new System.Drawing.Point(130, 16);
            this.textboxNombre.MaxLength = 32767;
            this.textboxNombre.Name = "textboxNombre";
            this.textboxNombre.PasswordChar = '\0';
            this.textboxNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxNombre.SelectedText = "";
            this.textboxNombre.SelectionLength = 0;
            this.textboxNombre.SelectionStart = 0;
            this.textboxNombre.ShortcutsEnabled = true;
            this.textboxNombre.Size = new System.Drawing.Size(146, 23);
            this.textboxNombre.TabIndex = 1;
            this.textboxNombre.UseSelectable = true;
            this.textboxNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textboxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxNombre_KeyPress);
            // 
            // btnCrearEspecie
            // 
            this.btnCrearEspecie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearEspecie.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCrearEspecie.Location = new System.Drawing.Point(23, 128);
            this.btnCrearEspecie.Margin = new System.Windows.Forms.Padding(0);
            this.btnCrearEspecie.Name = "btnCrearEspecie";
            this.btnCrearEspecie.Size = new System.Drawing.Size(289, 30);
            this.btnCrearEspecie.TabIndex = 2;
            this.btnCrearEspecie.Text = "Crear Especie";
            this.btnCrearEspecie.UseSelectable = true;
            this.btnCrearEspecie.Click += new System.EventHandler(this.btnCrearEspecie_Click);
            // 
            // FormNuevaEspecie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 180);
            this.Controls.Add(this.btnCrearEspecie);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(335, 180);
            this.MinimumSize = new System.Drawing.Size(335, 180);
            this.Name = "FormNuevaEspecie";
            this.Text = "Nueva Especie";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNuevaEspecie_FormClosed);
            this.Load += new System.EventHandler(this.FormNuevaEspecie_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnCrearEspecie;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox textboxNombre;
    }
}