namespace Presentacion
{
    partial class UsuariosModificar
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
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.dtpUsuario = new System.Windows.Forms.DateTimePicker();
            this.cbxGerarquia = new System.Windows.Forms.ComboBox();
            this.btnAddLocalidad = new System.Windows.Forms.Button();
            this.cbxCodigoPostal = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(164, 80);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(185, 20);
            this.txtDni.TabIndex = 1038;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 1057;
            this.label3.Text = "Dni";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(164, 235);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(185, 20);
            this.txtPassword.TabIndex = 1048;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(166, 134);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(183, 20);
            this.txtDireccion.TabIndex = 1041;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(164, 54);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(185, 20);
            this.txtApellido.TabIndex = 1037;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(164, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(185, 20);
            this.txtNombre.TabIndex = 1036;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.Location = new System.Drawing.Point(164, 209);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(185, 20);
            this.lblLocalidad.TabIndex = 1056;
            // 
            // cbxSexo
            // 
            this.cbxSexo.BackColor = System.Drawing.SystemColors.Window;
            this.cbxSexo.DisplayMember = "Masculino";
            this.cbxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbxSexo.Location = new System.Drawing.Point(164, 160);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(185, 21);
            this.cbxSexo.TabIndex = 1043;
            this.cbxSexo.ValueMember = "Masculino";
            this.cbxSexo.SelectedIndexChanged += new System.EventHandler(this.cbxSexo_SelectedIndexChanged);
            // 
            // dtpUsuario
            // 
            this.dtpUsuario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUsuario.Location = new System.Drawing.Point(166, 107);
            this.dtpUsuario.Name = "dtpUsuario";
            this.dtpUsuario.Size = new System.Drawing.Size(183, 20);
            this.dtpUsuario.TabIndex = 1039;
            // 
            // cbxGerarquia
            // 
            this.cbxGerarquia.FormattingEnabled = true;
            this.cbxGerarquia.Location = new System.Drawing.Point(164, 261);
            this.cbxGerarquia.Name = "cbxGerarquia";
            this.cbxGerarquia.Size = new System.Drawing.Size(185, 21);
            this.cbxGerarquia.TabIndex = 1049;
            // 
            // btnAddLocalidad
            // 
            this.btnAddLocalidad.Location = new System.Drawing.Point(326, 185);
            this.btnAddLocalidad.Name = "btnAddLocalidad";
            this.btnAddLocalidad.Size = new System.Drawing.Size(23, 21);
            this.btnAddLocalidad.TabIndex = 1046;
            this.btnAddLocalidad.Text = "+";
            this.btnAddLocalidad.UseVisualStyleBackColor = true;
            this.btnAddLocalidad.Click += new System.EventHandler(this.btnAddLocalidad_Click);
            // 
            // cbxCodigoPostal
            // 
            this.cbxCodigoPostal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCodigoPostal.FormattingEnabled = true;
            this.cbxCodigoPostal.Location = new System.Drawing.Point(164, 186);
            this.cbxCodigoPostal.Name = "cbxCodigoPostal";
            this.cbxCodigoPostal.Size = new System.Drawing.Size(156, 21);
            this.cbxCodigoPostal.TabIndex = 1044;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(90, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 1055;
            this.label9.Text = "Gerarquia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(90, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 1053;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(90, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 1051;
            this.label7.Text = "Localidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(112, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 1050;
            this.label6.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 1047;
            this.label5.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 1045;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1042;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1040;
            this.label1.Text = "Apellido";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(246, 299);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 29);
            this.btnSalir.TabIndex = 1054;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(118, 299);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(103, 29);
            this.btnAceptar.TabIndex = 1052;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // UsuariosModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 382);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.cbxSexo);
            this.Controls.Add(this.dtpUsuario);
            this.Controls.Add(this.cbxGerarquia);
            this.Controls.Add(this.btnAddLocalidad);
            this.Controls.Add(this.cbxCodigoPostal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAceptar);
            this.Name = "UsuariosModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuariosModificar";
            this.Load += new System.EventHandler(this.UsuariosModificar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.DateTimePicker dtpUsuario;
        private System.Windows.Forms.ComboBox cbxGerarquia;
        private System.Windows.Forms.Button btnAddLocalidad;
        protected System.Windows.Forms.ComboBox cbxCodigoPostal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAceptar;
    }
}