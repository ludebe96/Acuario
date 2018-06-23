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
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
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
            this.btnPeces.Location = new System.Drawing.Point(33, 165);
            this.btnPeces.Name = "btnPeces";
            this.btnPeces.Size = new System.Drawing.Size(75, 23);
            this.btnPeces.TabIndex = 2;
            this.btnPeces.Text = "Peces";
            this.btnPeces.UseVisualStyleBackColor = true;
            this.btnPeces.Click += new System.EventHandler(this.btnPeces_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(114, 165);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(75, 23);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Location = new System.Drawing.Point(33, 206);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(75, 23);
            this.btnVentas.TabIndex = 4;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(114, 206);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(75, 23);
            this.btnVender.TabIndex = 5;
            this.btnVender.Text = "VENDER";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.Location = new System.Drawing.Point(33, 246);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(75, 23);
            this.btnCompras.TabIndex = 6;
            this.btnCompras.Text = "Compras";
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(114, 246);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 7;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 559);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.btnCompras);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnClientes);
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
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnComprar;
    }
}

