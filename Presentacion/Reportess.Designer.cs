﻿namespace Presentacion
{
    partial class Reportess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportess));
            this.txtFacID = new System.Windows.Forms.TextBox();
            this.btnFacturaID = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.btnReporte2 = new System.Windows.Forms.Button();
            this.btnReporte1 = new System.Windows.Forms.Button();
            this.DgvFacturacion = new System.Windows.Forms.DataGridView();
            this.btnExcel = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFacturacion)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFacID
            // 
            this.txtFacID.Location = new System.Drawing.Point(472, 9);
            this.txtFacID.Name = "txtFacID";
            this.txtFacID.Size = new System.Drawing.Size(111, 20);
            this.txtFacID.TabIndex = 44;
            // 
            // btnFacturaID
            // 
            this.btnFacturaID.Location = new System.Drawing.Point(371, 410);
            this.btnFacturaID.Name = "btnFacturaID";
            this.btnFacturaID.Size = new System.Drawing.Size(144, 36);
            this.btnFacturaID.TabIndex = 43;
            this.btnFacturaID.Text = "Imprimir con ID";
            this.btnFacturaID.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(371, 366);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(144, 36);
            this.btnImprimir.TabIndex = 42;
            this.btnImprimir.Text = "Imprimir Factura";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(647, 388);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(141, 36);
            this.BtnSalir.TabIndex = 41;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // btnReporte2
            // 
            this.btnReporte2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte2.Location = new System.Drawing.Point(162, 364);
            this.btnReporte2.Name = "btnReporte2";
            this.btnReporte2.Size = new System.Drawing.Size(141, 38);
            this.btnReporte2.TabIndex = 38;
            this.btnReporte2.Text = "DETALLE POR FACTURA";
            this.btnReporte2.UseVisualStyleBackColor = true;
            this.btnReporte2.Click += new System.EventHandler(this.btnReporte2_Click);
            // 
            // btnReporte1
            // 
            this.btnReporte1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte1.Location = new System.Drawing.Point(12, 364);
            this.btnReporte1.Name = "btnReporte1";
            this.btnReporte1.Size = new System.Drawing.Size(144, 38);
            this.btnReporte1.TabIndex = 37;
            this.btnReporte1.Text = "FACTURAS GENERADAS";
            this.btnReporte1.UseVisualStyleBackColor = true;
            this.btnReporte1.Click += new System.EventHandler(this.btnReporte1_Click);
            // 
            // DgvFacturacion
            // 
            this.DgvFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFacturacion.Location = new System.Drawing.Point(12, 49);
            this.DgvFacturacion.Name = "DgvFacturacion";
            this.DgvFacturacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvFacturacion.Size = new System.Drawing.Size(714, 309);
            this.DgvFacturacion.TabIndex = 40;
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Location = new System.Drawing.Point(86, 408);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(141, 38);
            this.btnExcel.TabIndex = 39;
            this.btnExcel.Text = "EXPORTAR A EXCEL";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(290, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 18);
            this.label10.TabIndex = 66;
            this.label10.Text = "REPORTES";
            // 
            // Reportess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtFacID);
            this.Controls.Add(this.btnFacturaID);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.btnReporte2);
            this.Controls.Add(this.btnReporte1);
            this.Controls.Add(this.DgvFacturacion);
            this.Controls.Add(this.btnExcel);
            this.Name = "Reportess";
            this.Text = "Reportess";
            ((System.ComponentModel.ISupportInitialize)(this.DgvFacturacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFacID;
        private System.Windows.Forms.Button btnFacturaID;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button btnReporte2;
        private System.Windows.Forms.Button btnReporte1;
        private System.Windows.Forms.DataGridView DgvFacturacion;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label label10;
    }
}