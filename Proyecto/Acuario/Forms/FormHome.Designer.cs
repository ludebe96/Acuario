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
            this.btnGastos = new System.Windows.Forms.Button();
            this.btnPeces = new System.Windows.Forms.Button();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
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
            // btnGastos
            // 
            this.btnGastos.Location = new System.Drawing.Point(114, 126);
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.Size = new System.Drawing.Size(75, 23);
            this.btnGastos.TabIndex = 1;
            this.btnGastos.Text = "Gastos";
            this.btnGastos.UseVisualStyleBackColor = true;
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click);
            // 
            // btnPeces
            // 
            this.btnPeces.Location = new System.Drawing.Point(64, 241);
            this.btnPeces.Name = "btnPeces";
            this.btnPeces.Size = new System.Drawing.Size(75, 23);
            this.btnPeces.TabIndex = 2;
            this.btnPeces.Text = "Peces";
            this.btnPeces.UseVisualStyleBackColor = true;
            this.btnPeces.Click += new System.EventHandler(this.btnPeces_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(545, 275);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.UseSelectable = true;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 559);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnPeces);
            this.Controls.Add(this.btnGastos);
            this.Controls.Add(this.buttonCaja);
            this.Name = "FormHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCaja;
        private System.Windows.Forms.Button btnGastos;
        private System.Windows.Forms.Button btnPeces;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

