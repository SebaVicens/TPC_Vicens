namespace Presentacion
{
    partial class Comprarr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comprarr));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCompra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxArticulos = new System.Windows.Forms.ComboBox();
            this.dtpFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxproveedor = new System.Windows.Forms.ComboBox();
            this.btnCompra = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvCompras = new System.Windows.Forms.DataGridView();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblusuariocomp = new System.Windows.Forms.Label();
            this.btnModificarArt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(206, 54);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 944;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(453, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 15);
            this.label7.TabIndex = 938;
            this.label7.Text = "Precio Venta";
            // 
            // txtCompra
            // 
            this.txtCompra.Location = new System.Drawing.Point(329, 147);
            this.txtCompra.Name = "txtCompra";
            this.txtCompra.ReadOnly = true;
            this.txtCompra.Size = new System.Drawing.Size(121, 20);
            this.txtCompra.TabIndex = 940;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(246, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 937;
            this.label5.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(249, 147);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(75, 20);
            this.txtStock.TabIndex = 942;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(328, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 936;
            this.label6.Text = "Precio Compra";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(456, 147);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(121, 20);
            this.txtPrecio.TabIndex = 941;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(34, 54);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(166, 24);
            this.btnIniciar.TabIndex = 920;
            this.btnIniciar.Text = "EMPEZAR COMPRAR";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(23, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 935;
            this.label4.Text = "Producto";
            // 
            // cbxArticulos
            // 
            this.cbxArticulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxArticulos.FormattingEnabled = true;
            this.cbxArticulos.Location = new System.Drawing.Point(27, 146);
            this.cbxArticulos.Name = "cbxArticulos";
            this.cbxArticulos.Size = new System.Drawing.Size(205, 21);
            this.cbxArticulos.TabIndex = 921;
            this.cbxArticulos.SelectedIndexChanged += new System.EventHandler(this.cbxArticulos_SelectedIndexChanged);
            // 
            // dtpFechaCompra
            // 
            this.dtpFechaCompra.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCompra.Location = new System.Drawing.Point(703, 24);
            this.dtpFechaCompra.Name = "dtpFechaCompra";
            this.dtpFechaCompra.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaCompra.TabIndex = 933;
            this.dtpFechaCompra.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(580, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 15);
            this.label13.TabIndex = 932;
            this.label13.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(583, 147);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(111, 20);
            this.txtCantidad.TabIndex = 922;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(700, 446);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 33);
            this.btnSalir.TabIndex = 926;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(557, 445);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(107, 34);
            this.lblTotal.TabIndex = 943;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(430, 452);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 18);
            this.label9.TabIndex = 931;
            this.label9.Text = "Total Compra";
            // 
            // cbxproveedor
            // 
            this.cbxproveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxproveedor.FormattingEnabled = true;
            this.cbxproveedor.Location = new System.Drawing.Point(34, 27);
            this.cbxproveedor.Name = "cbxproveedor";
            this.cbxproveedor.Size = new System.Drawing.Size(247, 21);
            this.cbxproveedor.TabIndex = 919;
            // 
            // btnCompra
            // 
            this.btnCompra.Location = new System.Drawing.Point(703, 340);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(103, 33);
            this.btnCompra.TabIndex = 925;
            this.btnCompra.Text = "Comprar";
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(703, 301);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 33);
            this.btnEliminar.TabIndex = 924;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 929;
            this.label1.Text = "Proveedor";
            // 
            // DgvCompras
            // 
            this.DgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCompras.Location = new System.Drawing.Point(26, 220);
            this.DgvCompras.Name = "DgvCompras";
            this.DgvCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCompras.Size = new System.Drawing.Size(668, 220);
            this.DgvCompras.TabIndex = 928;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(703, 262);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(103, 33);
            this.btnCargar.TabIndex = 923;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblusuariocomp
            // 
            this.lblusuariocomp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblusuariocomp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuariocomp.Location = new System.Drawing.Point(333, 28);
            this.lblusuariocomp.Name = "lblusuariocomp";
            this.lblusuariocomp.Size = new System.Drawing.Size(198, 20);
            this.lblusuariocomp.TabIndex = 945;
            // 
            // btnModificarArt
            // 
            this.btnModificarArt.Location = new System.Drawing.Point(724, 127);
            this.btnModificarArt.Name = "btnModificarArt";
            this.btnModificarArt.Size = new System.Drawing.Size(100, 59);
            this.btnModificarArt.TabIndex = 946;
            this.btnModificarArt.Text = "Modificar Articulo";
            this.btnModificarArt.UseVisualStyleBackColor = true;
            this.btnModificarArt.Click += new System.EventHandler(this.btnModificarArt_Click);
            // 
            // Comprarr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(854, 492);
            this.Controls.Add(this.btnModificarArt);
            this.Controls.Add(this.lblusuariocomp);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCompra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxArticulos);
            this.Controls.Add(this.dtpFechaCompra);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxproveedor);
            this.Controls.Add(this.btnCompra);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvCompras);
            this.Controls.Add(this.btnCargar);
            this.Name = "Comprarr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprarr";
            this.Load += new System.EventHandler(this.Comprarr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxArticulos;
        private System.Windows.Forms.DateTimePicker dtpFechaCompra;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxproveedor;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvCompras;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblusuariocomp;
        private System.Windows.Forms.Button btnModificarArt;
    }
}