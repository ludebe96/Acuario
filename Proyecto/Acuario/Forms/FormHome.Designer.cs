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
            this.panelNavegacion = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCaja = new MetroFramework.Controls.MetroTile();
            this.btnPez = new MetroFramework.Controls.MetroTile();
            this.btnVentas = new MetroFramework.Controls.MetroTile();
            this.btnCompras = new MetroFramework.Controls.MetroTile();
            this.btnGastos = new MetroFramework.Controls.MetroTile();
            this.btnClientes = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnResumenesGenerales = new MetroFramework.Controls.MetroButton();
            this.btnNavegacion = new MetroFramework.Controls.MetroButton();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.btnComprar = new MetroFramework.Controls.MetroButton();
            this.btnVender = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.labelBalance = new MetroFramework.Controls.MetroLabel();
            this.panelResumenesGenerales = new MetroFramework.Controls.MetroPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.labelGastos = new MetroFramework.Controls.MetroLabel();
            this.labelIngresos = new MetroFramework.Controls.MetroLabel();
            this.labelVersion = new MetroFramework.Controls.MetroLabel();
            this.panelNavegacion.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.panelResumenesGenerales.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavegacion
            // 
            this.panelNavegacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNavegacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNavegacion.Controls.Add(this.btnCaja);
            this.panelNavegacion.Controls.Add(this.btnPez);
            this.panelNavegacion.Controls.Add(this.btnVentas);
            this.panelNavegacion.Controls.Add(this.btnCompras);
            this.panelNavegacion.Controls.Add(this.btnGastos);
            this.panelNavegacion.Controls.Add(this.btnClientes);
            this.panelNavegacion.Location = new System.Drawing.Point(189, 63);
            this.panelNavegacion.Name = "panelNavegacion";
            this.panelNavegacion.Size = new System.Drawing.Size(502, 474);
            this.panelNavegacion.TabIndex = 0;
            // 
            // btnCaja
            // 
            this.btnCaja.ActiveControl = null;
            this.btnCaja.Location = new System.Drawing.Point(0, 0);
            this.btnCaja.Margin = new System.Windows.Forms.Padding(0);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(100, 100);
            this.btnCaja.TabIndex = 0;
            this.btnCaja.Text = "CAJA";
            this.btnCaja.TileImage = global::Acuario.Properties.Resources.caja;
            this.btnCaja.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCaja.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnCaja.UseSelectable = true;
            this.btnCaja.UseTileImage = true;
            this.btnCaja.Click += new System.EventHandler(this.btnCaja_Click);
            // 
            // btnPez
            // 
            this.btnPez.ActiveControl = null;
            this.btnPez.BackColor = System.Drawing.Color.Transparent;
            this.btnPez.Location = new System.Drawing.Point(100, 0);
            this.btnPez.Margin = new System.Windows.Forms.Padding(0);
            this.btnPez.Name = "btnPez";
            this.btnPez.Size = new System.Drawing.Size(100, 100);
            this.btnPez.TabIndex = 1;
            this.btnPez.Text = "PECES";
            this.btnPez.TileImage = global::Acuario.Properties.Resources.pez;
            this.btnPez.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPez.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnPez.UseSelectable = true;
            this.btnPez.UseTileImage = true;
            this.btnPez.Click += new System.EventHandler(this.btnPez_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.ActiveControl = null;
            this.btnVentas.Location = new System.Drawing.Point(200, 0);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(0);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(100, 100);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.Text = "VENTAS";
            this.btnVentas.TileImage = global::Acuario.Properties.Resources.venta;
            this.btnVentas.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVentas.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnVentas.UseSelectable = true;
            this.btnVentas.UseTileImage = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.ActiveControl = null;
            this.btnCompras.Location = new System.Drawing.Point(300, 0);
            this.btnCompras.Margin = new System.Windows.Forms.Padding(0);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(100, 100);
            this.btnCompras.TabIndex = 3;
            this.btnCompras.Text = "COMPRAS";
            this.btnCompras.TileImage = global::Acuario.Properties.Resources.compra;
            this.btnCompras.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCompras.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnCompras.UseSelectable = true;
            this.btnCompras.UseTileImage = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnGastos
            // 
            this.btnGastos.ActiveControl = null;
            this.btnGastos.Location = new System.Drawing.Point(400, 0);
            this.btnGastos.Margin = new System.Windows.Forms.Padding(0);
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.Size = new System.Drawing.Size(100, 100);
            this.btnGastos.TabIndex = 4;
            this.btnGastos.Text = "GASTOS";
            this.btnGastos.TileImage = global::Acuario.Properties.Resources.gasto;
            this.btnGastos.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGastos.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnGastos.UseSelectable = true;
            this.btnGastos.UseTileImage = true;
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.ActiveControl = null;
            this.btnClientes.Location = new System.Drawing.Point(0, 100);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(0);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(100, 100);
            this.btnClientes.TabIndex = 5;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.TileImage = global::Acuario.Properties.Resources.clientes;
            this.btnClientes.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClientes.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnClientes.UseSelectable = true;
            this.btnClientes.UseTileImage = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.btnResumenesGenerales);
            this.metroPanel1.Controls.Add(this.btnNavegacion);
            this.metroPanel1.Controls.Add(this.btnSalir);
            this.metroPanel1.Controls.Add(this.btnComprar);
            this.metroPanel1.Controls.Add(this.btnVender);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(160, 474);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnResumenesGenerales
            // 
            this.btnResumenesGenerales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResumenesGenerales.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnResumenesGenerales.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnResumenesGenerales.Location = new System.Drawing.Point(0, 35);
            this.btnResumenesGenerales.Margin = new System.Windows.Forms.Padding(0);
            this.btnResumenesGenerales.Name = "btnResumenesGenerales";
            this.btnResumenesGenerales.Size = new System.Drawing.Size(158, 35);
            this.btnResumenesGenerales.TabIndex = 10;
            this.btnResumenesGenerales.Text = "RESUMENES GENERALES";
            this.btnResumenesGenerales.UseSelectable = true;
            this.btnResumenesGenerales.Click += new System.EventHandler(this.btnResumenesGenerales_Click);
            // 
            // btnNavegacion
            // 
            this.btnNavegacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavegacion.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnNavegacion.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnNavegacion.Location = new System.Drawing.Point(0, 0);
            this.btnNavegacion.Margin = new System.Windows.Forms.Padding(0);
            this.btnNavegacion.Name = "btnNavegacion";
            this.btnNavegacion.Size = new System.Drawing.Size(158, 35);
            this.btnNavegacion.TabIndex = 9;
            this.btnNavegacion.Text = "NAVEGACION";
            this.btnNavegacion.UseSelectable = true;
            this.btnNavegacion.Click += new System.EventHandler(this.btnNavegacion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSalir.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSalir.Location = new System.Drawing.Point(-1, 437);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(159, 35);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseSelectable = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComprar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnComprar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnComprar.Location = new System.Drawing.Point(-1, 138);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(0);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(159, 35);
            this.btnComprar.TabIndex = 7;
            this.btnComprar.Text = "COMPRAR";
            this.btnComprar.UseCustomForeColor = true;
            this.btnComprar.UseSelectable = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnVender
            // 
            this.btnVender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVender.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnVender.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnVender.Location = new System.Drawing.Point(0, 103);
            this.btnVender.Margin = new System.Windows.Forms.Padding(0);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(158, 35);
            this.btnVender.TabIndex = 6;
            this.btnVender.Text = "VENDER";
            this.btnVender.UseCustomForeColor = true;
            this.btnVender.UseSelectable = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel1.Location = new System.Drawing.Point(117, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(92, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "INGRESOS";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel2.Location = new System.Drawing.Point(304, 78);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 25);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "GASTOS";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(3, 224);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(504, 25);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "BALANCE";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // labelBalance
            // 
            this.labelBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBalance.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelBalance.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelBalance.ForeColor = System.Drawing.Color.DarkGray;
            this.labelBalance.Location = new System.Drawing.Point(3, 249);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(504, 25);
            this.labelBalance.TabIndex = 5;
            this.labelBalance.Text = "$0,00";
            this.labelBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBalance.UseCustomForeColor = true;
            // 
            // panelResumenesGenerales
            // 
            this.panelResumenesGenerales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelResumenesGenerales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResumenesGenerales.Controls.Add(this.metroLabel4);
            this.panelResumenesGenerales.Controls.Add(this.labelGastos);
            this.panelResumenesGenerales.Controls.Add(this.labelIngresos);
            this.panelResumenesGenerales.Controls.Add(this.labelBalance);
            this.panelResumenesGenerales.Controls.Add(this.metroLabel3);
            this.panelResumenesGenerales.Controls.Add(this.metroLabel2);
            this.panelResumenesGenerales.Controls.Add(this.metroLabel1);
            this.panelResumenesGenerales.HorizontalScrollbarBarColor = true;
            this.panelResumenesGenerales.HorizontalScrollbarHighlightOnWheel = false;
            this.panelResumenesGenerales.HorizontalScrollbarSize = 10;
            this.panelResumenesGenerales.Location = new System.Drawing.Point(179, 63);
            this.panelResumenesGenerales.Name = "panelResumenesGenerales";
            this.panelResumenesGenerales.Size = new System.Drawing.Size(512, 474);
            this.panelResumenesGenerales.TabIndex = 2;
            this.panelResumenesGenerales.VerticalScrollbarBarColor = true;
            this.panelResumenesGenerales.VerticalScrollbarHighlightOnWheel = false;
            this.panelResumenesGenerales.VerticalScrollbarSize = 10;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.DimGray;
            this.metroLabel4.Location = new System.Drawing.Point(3, 3);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(504, 25);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "RESUMEN GENERAL DEL DÍA";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // labelGastos
            // 
            this.labelGastos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGastos.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelGastos.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelGastos.ForeColor = System.Drawing.Color.DarkRed;
            this.labelGastos.Location = new System.Drawing.Point(239, 106);
            this.labelGastos.Name = "labelGastos";
            this.labelGastos.Size = new System.Drawing.Size(200, 25);
            this.labelGastos.TabIndex = 7;
            this.labelGastos.Text = "$0,00";
            this.labelGastos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelGastos.UseCustomForeColor = true;
            // 
            // labelIngresos
            // 
            this.labelIngresos.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelIngresos.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelIngresos.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelIngresos.Location = new System.Drawing.Point(59, 103);
            this.labelIngresos.Name = "labelIngresos";
            this.labelIngresos.Size = new System.Drawing.Size(200, 25);
            this.labelIngresos.TabIndex = 6;
            this.labelIngresos.Text = "$0,00";
            this.labelIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelIngresos.UseCustomForeColor = true;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelVersion.ForeColor = System.Drawing.Color.DarkGray;
            this.labelVersion.Location = new System.Drawing.Point(639, 540);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(43, 15);
            this.labelVersion.TabIndex = 3;
            this.labelVersion.Text = "v1.0.0.0";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelVersion.UseCustomForeColor = true;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 560);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.panelNavegacion);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.panelResumenesGenerales);
            this.MinimumSize = new System.Drawing.Size(704, 560);
            this.Name = "FormHome";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.panelNavegacion.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.panelResumenesGenerales.ResumeLayout(false);
            this.panelResumenesGenerales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelNavegacion;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile btnCaja;
        private MetroFramework.Controls.MetroTile btnPez;
        private MetroFramework.Controls.MetroTile btnVentas;
        private MetroFramework.Controls.MetroTile btnCompras;
        private MetroFramework.Controls.MetroTile btnGastos;
        private MetroFramework.Controls.MetroTile btnClientes;
        private MetroFramework.Controls.MetroButton btnComprar;
        private MetroFramework.Controls.MetroButton btnVender;
        private MetroFramework.Controls.MetroButton btnSalir;
        private MetroFramework.Controls.MetroButton btnResumenesGenerales;
        private MetroFramework.Controls.MetroButton btnNavegacion;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel labelBalance;
        private MetroFramework.Controls.MetroPanel panelResumenesGenerales;
        private MetroFramework.Controls.MetroLabel labelGastos;
        private MetroFramework.Controls.MetroLabel labelIngresos;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel labelVersion;
    }
}

