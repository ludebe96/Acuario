namespace Acuario.Forms
{
    partial class FormHome
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
            this.buttonCaja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCaja
            // 
            this.buttonCaja.Location = new System.Drawing.Point(33, 126);
            this.buttonCaja.Name = "buttonCaja";
            this.buttonCaja.Size = new System.Drawing.Size(75, 23);
            this.buttonCaja.TabIndex = 0;
            this.buttonCaja.Text = "Caja";
            this.buttonCaja.UseVisualStyleBackColor = true;
            this.buttonCaja.Click += new System.EventHandler(this.buttonCaja_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 559);
            this.Controls.Add(this.buttonCaja);
            this.Name = "FormHome";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCaja;
    }
}

