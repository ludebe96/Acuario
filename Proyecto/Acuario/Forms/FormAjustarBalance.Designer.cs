namespace Acuario.Forms
{
    partial class FormAjustarBalance
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
            this.textBoxBalancePrevio = new MetroFramework.Controls.MetroTextBox();
            this.textBoxBalanceNuevo = new MetroFramework.Controls.MetroTextBox();
            this.buttonCalculadora = new MetroFramework.Controls.MetroButton();
            this.buttonOk = new MetroFramework.Controls.MetroButton();
            this.buttonCancelar = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxBalancePrevio
            // 
            // 
            // 
            // 
            this.textBoxBalancePrevio.CustomButton.Image = null;
            this.textBoxBalancePrevio.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.textBoxBalancePrevio.CustomButton.Name = "";
            this.textBoxBalancePrevio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxBalancePrevio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxBalancePrevio.CustomButton.TabIndex = 1;
            this.textBoxBalancePrevio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxBalancePrevio.CustomButton.UseSelectable = true;
            this.textBoxBalancePrevio.CustomButton.Visible = false;
            this.textBoxBalancePrevio.Enabled = false;
            this.textBoxBalancePrevio.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBoxBalancePrevio.Lines = new string[0];
            this.textBoxBalancePrevio.Location = new System.Drawing.Point(81, 75);
            this.textBoxBalancePrevio.MaxLength = 32767;
            this.textBoxBalancePrevio.Name = "textBoxBalancePrevio";
            this.textBoxBalancePrevio.PasswordChar = '\0';
            this.textBoxBalancePrevio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxBalancePrevio.SelectedText = "";
            this.textBoxBalancePrevio.SelectionLength = 0;
            this.textBoxBalancePrevio.SelectionStart = 0;
            this.textBoxBalancePrevio.ShortcutsEnabled = true;
            this.textBoxBalancePrevio.Size = new System.Drawing.Size(175, 23);
            this.textBoxBalancePrevio.TabIndex = 0;
            this.textBoxBalancePrevio.UseSelectable = true;
            this.textBoxBalancePrevio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxBalancePrevio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxBalanceNuevo
            // 
            // 
            // 
            // 
            this.textBoxBalanceNuevo.CustomButton.Image = null;
            this.textBoxBalanceNuevo.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.textBoxBalanceNuevo.CustomButton.Name = "";
            this.textBoxBalanceNuevo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxBalanceNuevo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxBalanceNuevo.CustomButton.TabIndex = 1;
            this.textBoxBalanceNuevo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxBalanceNuevo.CustomButton.UseSelectable = true;
            this.textBoxBalanceNuevo.CustomButton.Visible = false;
            this.textBoxBalanceNuevo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBoxBalanceNuevo.Lines = new string[0];
            this.textBoxBalanceNuevo.Location = new System.Drawing.Point(81, 125);
            this.textBoxBalanceNuevo.MaxLength = 32767;
            this.textBoxBalanceNuevo.Name = "textBoxBalanceNuevo";
            this.textBoxBalanceNuevo.PasswordChar = '\0';
            this.textBoxBalanceNuevo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxBalanceNuevo.SelectedText = "";
            this.textBoxBalanceNuevo.SelectionLength = 0;
            this.textBoxBalanceNuevo.SelectionStart = 0;
            this.textBoxBalanceNuevo.ShortcutsEnabled = true;
            this.textBoxBalanceNuevo.Size = new System.Drawing.Size(175, 23);
            this.textBoxBalanceNuevo.TabIndex = 1;
            this.textBoxBalanceNuevo.UseSelectable = true;
            this.textBoxBalanceNuevo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxBalanceNuevo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxBalanceNuevo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBalanceNuevo_KeyPress);
            // 
            // buttonCalculadora
            // 
            this.buttonCalculadora.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.buttonCalculadora.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.buttonCalculadora.Location = new System.Drawing.Point(254, 3);
            this.buttonCalculadora.Name = "buttonCalculadora";
            this.buttonCalculadora.Size = new System.Drawing.Size(111, 30);
            this.buttonCalculadora.TabIndex = 6;
            this.buttonCalculadora.Text = "Calculadora";
            this.buttonCalculadora.UseSelectable = true;
            this.buttonCalculadora.Click += new System.EventHandler(this.buttonCalculadora_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.buttonOk.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.buttonOk.Location = new System.Drawing.Point(23, 256);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(111, 30);
            this.buttonOk.TabIndex = 7;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseSelectable = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.buttonCancelar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.buttonCancelar.Location = new System.Drawing.Point(282, 256);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(111, 30);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseSelectable = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.buttonCalculadora);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.textBoxBalancePrevio);
            this.metroPanel1.Controls.Add(this.textBoxBalanceNuevo);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(370, 187);
            this.metroPanel1.TabIndex = 10;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(106, 47);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(123, 25);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Balance Actual";
            // 
            // FormAjustarBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 326);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.buttonOk);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(416, 326);
            this.MinimumSize = new System.Drawing.Size(416, 326);
            this.Name = "FormAjustarBalance";
            this.Text = "FormAjustarBalance";
            this.Load += new System.EventHandler(this.FormAjustarBalance_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox textBoxBalancePrevio;
        private MetroFramework.Controls.MetroTextBox textBoxBalanceNuevo;
        private MetroFramework.Controls.MetroButton buttonCalculadora;
        private MetroFramework.Controls.MetroButton buttonOk;
        private MetroFramework.Controls.MetroButton buttonCancelar;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}