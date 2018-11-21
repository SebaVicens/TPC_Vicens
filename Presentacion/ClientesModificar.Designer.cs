namespace Presentacion
{
    partial class ClientesModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesModificar));
            this.button1 = new System.Windows.Forms.Button();
            this.BtnCrearCli = new System.Windows.Forms.Button();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.btnAddLocalidad = new System.Windows.Forms.Button();
            this.cbxCodigoPostal = new System.Windows.Forms.ComboBox();
            this.cbxSexoCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 51);
            this.button1.TabIndex = 1050;
            this.button1.Text = "&Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCrearCli
            // 
            this.BtnCrearCli.Location = new System.Drawing.Point(290, 298);
            this.BtnCrearCli.Name = "BtnCrearCli";
            this.BtnCrearCli.Size = new System.Drawing.Size(114, 51);
            this.BtnCrearCli.TabIndex = 1049;
            this.BtnCrearCli.Text = "&Aceptar";
            this.BtnCrearCli.UseVisualStyleBackColor = true;
            this.BtnCrearCli.Click += new System.EventHandler(this.BtnCrearCli_Click);
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.Location = new System.Drawing.Point(183, 241);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(183, 20);
            this.lblLocalidad.TabIndex = 1048;
            // 
            // btnAddLocalidad
            // 
            this.btnAddLocalidad.Location = new System.Drawing.Point(331, 190);
            this.btnAddLocalidad.Name = "btnAddLocalidad";
            this.btnAddLocalidad.Size = new System.Drawing.Size(35, 21);
            this.btnAddLocalidad.TabIndex = 1037;
            this.btnAddLocalidad.Text = "+";
            this.btnAddLocalidad.UseVisualStyleBackColor = true;
            this.btnAddLocalidad.Click += new System.EventHandler(this.btnAddLocalidad_Click);
            // 
            // cbxCodigoPostal
            // 
            this.cbxCodigoPostal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCodigoPostal.FormattingEnabled = true;
            this.cbxCodigoPostal.Location = new System.Drawing.Point(183, 191);
            this.cbxCodigoPostal.Name = "cbxCodigoPostal";
            this.cbxCodigoPostal.Size = new System.Drawing.Size(142, 21);
            this.cbxCodigoPostal.TabIndex = 1036;
            this.cbxCodigoPostal.SelectedIndexChanged += new System.EventHandler(this.cbxCodigoPostal_SelectedIndexChanged);
            // 
            // cbxSexoCliente
            // 
            this.cbxSexoCliente.DisplayMember = "Masculino";
            this.cbxSexoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSexoCliente.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.cbxSexoCliente.Location = new System.Drawing.Point(551, 101);
            this.cbxSexoCliente.Name = "cbxSexoCliente";
            this.cbxSexoCliente.Size = new System.Drawing.Size(183, 21);
            this.cbxSexoCliente.TabIndex = 1038;
            this.cbxSexoCliente.ValueMember = "Masculino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(383, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 15);
            this.label3.TabIndex = 1047;
            this.label3.Text = "FECHA NACIMIENTO";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(551, 154);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(183, 20);
            this.dtpFechaNac.TabIndex = 1040;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(183, 101);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(183, 20);
            this.txtNombre.TabIndex = 1033;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtDni
            // 
            this.txtDni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDni.Location = new System.Drawing.Point(551, 128);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(183, 20);
            this.txtDni.TabIndex = 1039;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Location = new System.Drawing.Point(183, 160);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(183, 20);
            this.txtDireccion.TabIndex = 1035;
            // 
            // txtApellido
            // 
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Location = new System.Drawing.Point(183, 130);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(183, 20);
            this.txtApellido.TabIndex = 1034;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(487, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 1046;
            this.label7.Text = "DNI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(477, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 1045;
            this.label6.Text = "SEXO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 1044;
            this.label5.Text = "DIRECCION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 15);
            this.label4.TabIndex = 1043;
            this.label4.Text = "CODIGO POSTAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1042;
            this.label2.Text = "NOMBRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 1041;
            this.label1.Text = "APELLIDO";
            // 
            // ClientesModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnCrearCli);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.btnAddLocalidad);
            this.Controls.Add(this.cbxCodigoPostal);
            this.Controls.Add(this.cbxSexoCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClientesModificar";
            this.Text = "ClientesModificar";
            this.Load += new System.EventHandler(this.ClientesModificar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnCrearCli;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Button btnAddLocalidad;
        protected System.Windows.Forms.ComboBox cbxCodigoPostal;
        private System.Windows.Forms.ComboBox cbxSexoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}