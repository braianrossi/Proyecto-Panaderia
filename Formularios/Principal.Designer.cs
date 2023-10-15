namespace Proyecto_Panaderia
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vENTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROVEEDORESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarListaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.lblListaProductos = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vENTASToolStripMenuItem,
            this.pROVEEDORESToolStripMenuItem,
            this.pRODUCTOSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vENTASToolStripMenuItem
            // 
            this.vENTASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaVentaToolStripMenuItem,
            this.actualizarPToolStripMenuItem,
            this.actualizarPedidoToolStripMenuItem});
            this.vENTASToolStripMenuItem.Name = "vENTASToolStripMenuItem";
            this.vENTASToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.vENTASToolStripMenuItem.Text = "VENTAS";
            // 
            // nuevaVentaToolStripMenuItem
            // 
            this.nuevaVentaToolStripMenuItem.Name = "nuevaVentaToolStripMenuItem";
            this.nuevaVentaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.nuevaVentaToolStripMenuItem.Text = "Nueva venta";
            this.nuevaVentaToolStripMenuItem.Click += new System.EventHandler(this.nuevaVentaToolStripMenuItem_Click);
            // 
            // actualizarPToolStripMenuItem
            // 
            this.actualizarPToolStripMenuItem.Name = "actualizarPToolStripMenuItem";
            this.actualizarPToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.actualizarPToolStripMenuItem.Text = "Nuevo pedido";
            // 
            // actualizarPedidoToolStripMenuItem
            // 
            this.actualizarPedidoToolStripMenuItem.Name = "actualizarPedidoToolStripMenuItem";
            this.actualizarPedidoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.actualizarPedidoToolStripMenuItem.Text = "Actualizar pedido";
            // 
            // pROVEEDORESToolStripMenuItem
            // 
            this.pROVEEDORESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeProveedoresToolStripMenuItem,
            this.nuevoProveedorToolStripMenuItem,
            this.informacionDeProveedoresToolStripMenuItem});
            this.pROVEEDORESToolStripMenuItem.Name = "pROVEEDORESToolStripMenuItem";
            this.pROVEEDORESToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.pROVEEDORESToolStripMenuItem.Text = "PROVEEDORES";
            // 
            // listaDeProveedoresToolStripMenuItem
            // 
            this.listaDeProveedoresToolStripMenuItem.Name = "listaDeProveedoresToolStripMenuItem";
            this.listaDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.listaDeProveedoresToolStripMenuItem.Text = "Lista de proveedores";
            // 
            // nuevoProveedorToolStripMenuItem
            // 
            this.nuevoProveedorToolStripMenuItem.Name = "nuevoProveedorToolStripMenuItem";
            this.nuevoProveedorToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.nuevoProveedorToolStripMenuItem.Text = "Nuevo proveedor";
            // 
            // informacionDeProveedoresToolStripMenuItem
            // 
            this.informacionDeProveedoresToolStripMenuItem.Name = "informacionDeProveedoresToolStripMenuItem";
            this.informacionDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.informacionDeProveedoresToolStripMenuItem.Text = "Informacion de proveedores";
            // 
            // pRODUCTOSToolStripMenuItem
            // 
            this.pRODUCTOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoProductoToolStripMenuItem,
            this.actualizarProductoToolStripMenuItem,
            this.actualizarListaDeProductosToolStripMenuItem});
            this.pRODUCTOSToolStripMenuItem.Name = "pRODUCTOSToolStripMenuItem";
            this.pRODUCTOSToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.pRODUCTOSToolStripMenuItem.Text = "PRODUCTOS";
            // 
            // nuevoProductoToolStripMenuItem
            // 
            this.nuevoProductoToolStripMenuItem.Name = "nuevoProductoToolStripMenuItem";
            this.nuevoProductoToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.nuevoProductoToolStripMenuItem.Text = "Nuevo producto";
            this.nuevoProductoToolStripMenuItem.Click += new System.EventHandler(this.nuevoProductoToolStripMenuItem_Click);
            // 
            // actualizarProductoToolStripMenuItem
            // 
            this.actualizarProductoToolStripMenuItem.Name = "actualizarProductoToolStripMenuItem";
            this.actualizarProductoToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.actualizarProductoToolStripMenuItem.Text = "Actualizar producto";
            // 
            // actualizarListaDeProductosToolStripMenuItem
            // 
            this.actualizarListaDeProductosToolStripMenuItem.Name = "actualizarListaDeProductosToolStripMenuItem";
            this.actualizarListaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.actualizarListaDeProductosToolStripMenuItem.Text = "Actualizar lista de productos";
            this.actualizarListaDeProductosToolStripMenuItem.Click += new System.EventHandler(this.actualizarListaDeProductosToolStripMenuItem_Click);
            // 
            // lstProductos
            // 
            this.lstProductos.BackColor = System.Drawing.Color.OldLace;
            this.lstProductos.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProductos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.ItemHeight = 25;
            this.lstProductos.Location = new System.Drawing.Point(12, 80);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(628, 354);
            this.lstProductos.TabIndex = 2;
            this.lstProductos.SelectedIndexChanged += new System.EventHandler(this.lstProductos_SelectedIndexChanged);
            // 
            // lblListaProductos
            // 
            this.lblListaProductos.AutoSize = true;
            this.lblListaProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaProductos.Location = new System.Drawing.Point(23, 35);
            this.lblListaProductos.Name = "lblListaProductos";
            this.lblListaProductos.Size = new System.Drawing.Size(164, 25);
            this.lblListaProductos.TabIndex = 4;
            this.lblListaProductos.Text = "Lista de precios";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblListaProductos);
            this.Controls.Add(this.lstProductos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vENTASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROVEEDORESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarListaDeProductosToolStripMenuItem;
        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.Label lblListaProductos;
    }
}

