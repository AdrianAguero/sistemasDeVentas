namespace sistemasDeVentas
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAltaVendedoresMenu = new System.Windows.Forms.Button();
            this.btnAltaProductosMenu = new System.Windows.Forms.Button();
            this.btnAltaClientesMenu = new System.Windows.Forms.Button();
            this.btnFacturacionMenu = new System.Windows.Forms.Button();
            this.btnInformesMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAltaVendedoresMenu
            // 
            this.btnAltaVendedoresMenu.Location = new System.Drawing.Point(27, 30);
            this.btnAltaVendedoresMenu.Name = "btnAltaVendedoresMenu";
            this.btnAltaVendedoresMenu.Size = new System.Drawing.Size(122, 69);
            this.btnAltaVendedoresMenu.TabIndex = 0;
            this.btnAltaVendedoresMenu.Text = "Alta Vendedores";
            this.btnAltaVendedoresMenu.UseVisualStyleBackColor = true;
            this.btnAltaVendedoresMenu.Click += new System.EventHandler(this.btnAltaVendedoresMenu_Click);
            // 
            // btnAltaProductosMenu
            // 
            this.btnAltaProductosMenu.Location = new System.Drawing.Point(185, 30);
            this.btnAltaProductosMenu.Name = "btnAltaProductosMenu";
            this.btnAltaProductosMenu.Size = new System.Drawing.Size(122, 69);
            this.btnAltaProductosMenu.TabIndex = 1;
            this.btnAltaProductosMenu.Text = "Alta Productos";
            this.btnAltaProductosMenu.UseVisualStyleBackColor = true;
            this.btnAltaProductosMenu.Click += new System.EventHandler(this.btnAltaProductosMenu_Click);
            // 
            // btnAltaClientesMenu
            // 
            this.btnAltaClientesMenu.Location = new System.Drawing.Point(27, 145);
            this.btnAltaClientesMenu.Name = "btnAltaClientesMenu";
            this.btnAltaClientesMenu.Size = new System.Drawing.Size(122, 69);
            this.btnAltaClientesMenu.TabIndex = 2;
            this.btnAltaClientesMenu.Text = "Alta Clientes";
            this.btnAltaClientesMenu.UseVisualStyleBackColor = true;
            this.btnAltaClientesMenu.Click += new System.EventHandler(this.btnAltaClientesMenu_Click);
            // 
            // btnFacturacionMenu
            // 
            this.btnFacturacionMenu.Location = new System.Drawing.Point(185, 145);
            this.btnFacturacionMenu.Name = "btnFacturacionMenu";
            this.btnFacturacionMenu.Size = new System.Drawing.Size(122, 69);
            this.btnFacturacionMenu.TabIndex = 3;
            this.btnFacturacionMenu.Text = "Facturacion";
            this.btnFacturacionMenu.UseVisualStyleBackColor = true;
            this.btnFacturacionMenu.Click += new System.EventHandler(this.btnFacturacionMenu_Click);
            // 
            // btnInformesMenu
            // 
            this.btnInformesMenu.Location = new System.Drawing.Point(27, 246);
            this.btnInformesMenu.Name = "btnInformesMenu";
            this.btnInformesMenu.Size = new System.Drawing.Size(280, 48);
            this.btnInformesMenu.TabIndex = 4;
            this.btnInformesMenu.Text = "Informes";
            this.btnInformesMenu.UseVisualStyleBackColor = true;
            this.btnInformesMenu.Click += new System.EventHandler(this.btnInformesMenu_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 325);
            this.Controls.Add(this.btnInformesMenu);
            this.Controls.Add(this.btnFacturacionMenu);
            this.Controls.Add(this.btnAltaClientesMenu);
            this.Controls.Add(this.btnAltaProductosMenu);
            this.Controls.Add(this.btnAltaVendedoresMenu);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaVendedoresMenu;
        private System.Windows.Forms.Button btnAltaProductosMenu;
        private System.Windows.Forms.Button btnAltaClientesMenu;
        private System.Windows.Forms.Button btnFacturacionMenu;
        private System.Windows.Forms.Button btnInformesMenu;
    }
}

