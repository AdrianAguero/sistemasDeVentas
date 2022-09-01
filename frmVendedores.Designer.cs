namespace sistemasDeVentas
{
    partial class frmVendedores
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtVendedores = new System.Windows.Forms.TextBox();
            this.lstVendedores = new System.Windows.Forms.ListBox();
            this.btnEliminarVendedores = new System.Windows.Forms.Button();
            this.btnAgregarVendedores = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Vendedor";
            // 
            // txtVendedores
            // 
            this.txtVendedores.Location = new System.Drawing.Point(174, 39);
            this.txtVendedores.Name = "txtVendedores";
            this.txtVendedores.Size = new System.Drawing.Size(169, 20);
            this.txtVendedores.TabIndex = 1;
            this.txtVendedores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVendedores_KeyPress);
            // 
            // lstVendedores
            // 
            this.lstVendedores.FormattingEnabled = true;
            this.lstVendedores.Location = new System.Drawing.Point(34, 86);
            this.lstVendedores.Name = "lstVendedores";
            this.lstVendedores.Size = new System.Drawing.Size(309, 95);
            this.lstVendedores.TabIndex = 2;
            // 
            // btnEliminarVendedores
            // 
            this.btnEliminarVendedores.Location = new System.Drawing.Point(39, 227);
            this.btnEliminarVendedores.Name = "btnEliminarVendedores";
            this.btnEliminarVendedores.Size = new System.Drawing.Size(75, 55);
            this.btnEliminarVendedores.TabIndex = 3;
            this.btnEliminarVendedores.Text = "Eliminar";
            this.btnEliminarVendedores.UseVisualStyleBackColor = true;
            this.btnEliminarVendedores.Click += new System.EventHandler(this.btnEliminarVendedores_Click);
            // 
            // btnAgregarVendedores
            // 
            this.btnAgregarVendedores.Location = new System.Drawing.Point(269, 227);
            this.btnAgregarVendedores.Name = "btnAgregarVendedores";
            this.btnAgregarVendedores.Size = new System.Drawing.Size(75, 55);
            this.btnAgregarVendedores.TabIndex = 4;
            this.btnAgregarVendedores.Text = "Agregar";
            this.btnAgregarVendedores.UseVisualStyleBackColor = true;
            this.btnAgregarVendedores.Click += new System.EventHandler(this.btnAgregarVendedores_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.Location = new System.Drawing.Point(149, 228);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(80, 54);
            this.btnFacturacion.TabIndex = 11;
            this.btnFacturacion.Text = "ir a facturacion";
            this.btnFacturacion.UseVisualStyleBackColor = true;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click_1);
            // 
            // frmVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 305);
            this.Controls.Add(this.btnFacturacion);
            this.Controls.Add(this.btnAgregarVendedores);
            this.Controls.Add(this.btnEliminarVendedores);
            this.Controls.Add(this.lstVendedores);
            this.Controls.Add(this.txtVendedores);
            this.Controls.Add(this.label1);
            this.Name = "frmVendedores";
            this.Text = "frmVendedores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVendedores_FormClosing);
            this.Load += new System.EventHandler(this.frmVendedores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVendedores;
        private System.Windows.Forms.ListBox lstVendedores;
        private System.Windows.Forms.Button btnEliminarVendedores;
        private System.Windows.Forms.Button btnAgregarVendedores;
        private System.Windows.Forms.Button btnFacturacion;
    }
}