﻿namespace Presentacion
{
    partial class Marcass
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
            this.lblCantidadMarcas = new System.Windows.Forms.Label();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCrearMarca = new System.Windows.Forms.Button();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCantidadMarcas
            // 
            this.lblCantidadMarcas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidadMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadMarcas.Location = new System.Drawing.Point(12, 34);
            this.lblCantidadMarcas.Name = "lblCantidadMarcas";
            this.lblCantidadMarcas.Size = new System.Drawing.Size(61, 28);
            this.lblCantidadMarcas.TabIndex = 59;
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Location = new System.Drawing.Point(664, 197);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(107, 32);
            this.btnEliminarMarca.TabIndex = 55;
            this.btnEliminarMarca.Text = "Eliminar";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(664, 312);
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
            this.label10.Location = new System.Drawing.Point(288, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 18);
            this.label10.TabIndex = 58;
            this.label10.Text = "MARCAS";
            // 
            // btnCrearMarca
            // 
            this.btnCrearMarca.Location = new System.Drawing.Point(664, 158);
            this.btnCrearMarca.Name = "btnCrearMarca";
            this.btnCrearMarca.Size = new System.Drawing.Size(107, 33);
            this.btnCrearMarca.TabIndex = 53;
            this.btnCrearMarca.Text = "Crear";
            this.btnCrearMarca.UseVisualStyleBackColor = true;
            this.btnCrearMarca.Click += new System.EventHandler(this.btnCrearMarca_Click);
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMarcas.Location = new System.Drawing.Point(12, 75);
            this.dgvMarcas.MultiSelect = false;
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(631, 298);
            this.dgvMarcas.TabIndex = 57;
            // 
            // Marcass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCantidadMarcas);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCrearMarca);
            this.Controls.Add(this.dgvMarcas);
            this.Name = "Marcass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.Marcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantidadMarcas;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCrearMarca;
        private System.Windows.Forms.DataGridView dgvMarcas;
    }
}