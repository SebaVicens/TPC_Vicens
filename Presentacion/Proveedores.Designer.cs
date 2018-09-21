namespace Presentacion
{
    partial class Proveedores
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
            this.lblCantidadProv = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.dgvProv = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCantidadProv
            // 
            this.lblCantidadProv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidadProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadProv.Location = new System.Drawing.Point(12, 36);
            this.lblCantidadProv.Name = "lblCantidadProv";
            this.lblCantidadProv.Size = new System.Drawing.Size(61, 28);
            this.lblCantidadProv.TabIndex = 59;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(664, 238);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 32);
            this.btnEliminar.TabIndex = 55;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(664, 303);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(107, 33);
            this.btnSalir.TabIndex = 56;
            this.btnSalir.Text = "Volver Menu";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(279, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 18);
            this.label10.TabIndex = 58;
            this.label10.Text = "PROVEEDORES";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(664, 160);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(107, 33);
            this.btnCrear.TabIndex = 53;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // dgvProv
            // 
            this.dgvProv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProv.Location = new System.Drawing.Point(12, 83);
            this.dgvProv.MultiSelect = false;
            this.dgvProv.Name = "dgvProv";
            this.dgvProv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProv.Size = new System.Drawing.Size(631, 298);
            this.dgvProv.TabIndex = 57;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(664, 199);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(107, 33);
            this.btnModificar.TabIndex = 54;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCantidadProv);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dgvProv);
            this.Controls.Add(this.btnModificar);
            this.Name = "Proveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantidadProv;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.DataGridView dgvProv;
        private System.Windows.Forms.Button btnModificar;
    }
}