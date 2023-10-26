namespace Proyecto_Panaderia.Formularios
{
    partial class NuevoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoProducto));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcionProductoNuevo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstProductosNuevaVenta = new System.Windows.Forms.ListBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            resources.ApplyResources(this.btnAgregar, "btnAgregar");
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            resources.ApplyResources(this.btnSalir, "btnSalir");
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtNombreProducto
            // 
            resources.ApplyResources(this.txtNombreProducto, "txtNombreProducto");
            this.txtNombreProducto.Name = "txtNombreProducto";
            // 
            // lblNombre
            // 
            resources.ApplyResources(this.lblNombre, "lblNombre");
            this.lblNombre.Name = "lblNombre";
            // 
            // lblDescripcion
            // 
            resources.ApplyResources(this.lblDescripcion, "lblDescripcion");
            this.lblDescripcion.Name = "lblDescripcion";
            // 
            // txtDescripcionProductoNuevo
            // 
            resources.ApplyResources(this.txtDescripcionProductoNuevo, "txtDescripcionProductoNuevo");
            this.txtDescripcionProductoNuevo.Name = "txtDescripcionProductoNuevo";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lstProductosNuevaVenta
            // 
            this.lstProductosNuevaVenta.BackColor = System.Drawing.Color.PapayaWhip;
            resources.ApplyResources(this.lstProductosNuevaVenta, "lstProductosNuevaVenta");
            this.lstProductosNuevaVenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lstProductosNuevaVenta.FormattingEnabled = true;
            this.lstProductosNuevaVenta.Name = "lstProductosNuevaVenta";
            // 
            // txtPrecio
            // 
            resources.ApplyResources(this.txtPrecio, "txtPrecio");
            this.txtPrecio.Name = "txtPrecio";
            // 
            // lblPrecio
            // 
            resources.ApplyResources(this.lblPrecio, "lblPrecio");
            this.lblPrecio.Name = "lblPrecio";
            // 
            // NuevoProducto
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lstProductosNuevaVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcionProductoNuevo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KeyPreview = true;
            this.Name = "NuevoProducto";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.NuevoProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcionProductoNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstProductosNuevaVenta;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
    }
}