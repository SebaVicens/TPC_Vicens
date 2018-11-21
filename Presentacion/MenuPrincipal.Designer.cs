namespace Presentacion
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TsmArticulos = new System.Windows.Forms.ToolStripMenuItem();
            this.aRTICULOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cATEGXARTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mARCASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmArticulos,
            this.mARCASToolStripMenuItem,
            this.TsmClientes,
            this.TsmProveedores,
            this.TsmCompras,
            this.TsmVentas,
            this.TsmUsuarios,
            this.rEPORTESToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TsmArticulos
            // 
            this.TsmArticulos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aRTICULOSToolStripMenuItem,
            this.cATEGXARTToolStripMenuItem});
            this.TsmArticulos.Name = "TsmArticulos";
            this.TsmArticulos.Size = new System.Drawing.Size(115, 20);
            this.TsmArticulos.Text = "ARTICULO ITEMS";
            this.TsmArticulos.Click += new System.EventHandler(this.TsmArticulos_Click);
            // 
            // aRTICULOSToolStripMenuItem
            // 
            this.aRTICULOSToolStripMenuItem.Name = "aRTICULOSToolStripMenuItem";
            this.aRTICULOSToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aRTICULOSToolStripMenuItem.Text = "ARTICULOS";
            this.aRTICULOSToolStripMenuItem.Click += new System.EventHandler(this.aRTICULOSToolStripMenuItem_Click);
            // 
            // cATEGXARTToolStripMenuItem
            // 
            this.cATEGXARTToolStripMenuItem.Name = "cATEGXARTToolStripMenuItem";
            this.cATEGXARTToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cATEGXARTToolStripMenuItem.Text = "CATEG. X ART.";
            this.cATEGXARTToolStripMenuItem.Click += new System.EventHandler(this.cATEGXARTToolStripMenuItem_Click);
            // 
            // mARCASToolStripMenuItem
            // 
            this.mARCASToolStripMenuItem.Name = "mARCASToolStripMenuItem";
            this.mARCASToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.mARCASToolStripMenuItem.Text = "MARCAS";
            this.mARCASToolStripMenuItem.Click += new System.EventHandler(this.mARCASToolStripMenuItem_Click);
            // 
            // TsmClientes
            // 
            this.TsmClientes.Name = "TsmClientes";
            this.TsmClientes.Size = new System.Drawing.Size(71, 20);
            this.TsmClientes.Text = "CLIENTES";
            this.TsmClientes.Click += new System.EventHandler(this.TsmClientes_Click);
            // 
            // TsmProveedores
            // 
            this.TsmProveedores.Name = "TsmProveedores";
            this.TsmProveedores.Size = new System.Drawing.Size(102, 20);
            this.TsmProveedores.Text = "PROVEEDORES";
            this.TsmProveedores.Click += new System.EventHandler(this.TsmProveedores_Click);
            // 
            // TsmCompras
            // 
            this.TsmCompras.Name = "TsmCompras";
            this.TsmCompras.Size = new System.Drawing.Size(76, 20);
            this.TsmCompras.Text = "COMPRAS";
            this.TsmCompras.Click += new System.EventHandler(this.TsmCompras_Click);
            // 
            // TsmVentas
            // 
            this.TsmVentas.Name = "TsmVentas";
            this.TsmVentas.Size = new System.Drawing.Size(63, 20);
            this.TsmVentas.Text = "VENTAS";
            this.TsmVentas.Click += new System.EventHandler(this.TsmVentas_Click);
            // 
            // TsmUsuarios
            // 
            this.TsmUsuarios.Name = "TsmUsuarios";
            this.TsmUsuarios.Size = new System.Drawing.Size(80, 20);
            this.TsmUsuarios.Text = "USUARIOS";
            this.TsmUsuarios.Click += new System.EventHandler(this.TsmUsuarios_Click);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // rEPORTESToolStripMenuItem
            // 
            this.rEPORTESToolStripMenuItem.Name = "rEPORTESToolStripMenuItem";
            this.rEPORTESToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.rEPORTESToolStripMenuItem.Text = "REPORTES";
            this.rEPORTESToolStripMenuItem.Click += new System.EventHandler(this.rEPORTESToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU PRINCIPAL";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TsmArticulos;
        private System.Windows.Forms.ToolStripMenuItem TsmCompras;
        private System.Windows.Forms.ToolStripMenuItem TsmVentas;
        private System.Windows.Forms.ToolStripMenuItem TsmClientes;
        private System.Windows.Forms.ToolStripMenuItem TsmProveedores;
        private System.Windows.Forms.ToolStripMenuItem TsmUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mARCASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cATEGXARTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aRTICULOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTESToolStripMenuItem;
    }
}

