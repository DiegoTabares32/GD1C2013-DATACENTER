namespace FrbaBus.Compra_de_Pasajes
{
    partial class Form_encomienda
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
            this.label11 = new System.Windows.Forms.Label();
            this.fem_radButton = new System.Windows.Forms.RadioButton();
            this.mascul_radioBut = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mail_Tbox = new System.Windows.Forms.TextBox();
            this.tel_Tbox = new System.Windows.Forms.TextBox();
            this.dir_Tbox = new System.Windows.Forms.TextBox();
            this.apell_Tbox = new System.Windows.Forms.TextBox();
            this.nombre_Tbox = new System.Windows.Forms.TextBox();
            this.DNI_Tbox = new System.Windows.Forms.TextBox();
            this.limpiar_boton = new System.Windows.Forms.Button();
            this.guardar_boton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.peso_encom_tbox = new System.Windows.Forms.TextBox();
            this.check_peso_encom_boton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.precio_encomiendaTbox = new System.Windows.Forms.TextBox();
            this.discapacitado_checkB = new System.Windows.Forms.CheckBox();
            this.pensionado_checkB = new System.Windows.Forms.CheckBox();
            this.jubilado_checkB = new System.Windows.Forms.CheckBox();
            this.fecNacDateTimeP = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese datos del Cliente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(140, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "formato: dd/mm/aaaa";
            // 
            // fem_radButton
            // 
            this.fem_radButton.AutoSize = true;
            this.fem_radButton.Location = new System.Drawing.Point(143, 334);
            this.fem_radButton.Name = "fem_radButton";
            this.fem_radButton.Size = new System.Drawing.Size(71, 17);
            this.fem_radButton.TabIndex = 49;
            this.fem_radButton.TabStop = true;
            this.fem_radButton.Text = "Femenino";
            this.fem_radButton.UseVisualStyleBackColor = true;
            // 
            // mascul_radioBut
            // 
            this.mascul_radioBut.AutoSize = true;
            this.mascul_radioBut.Location = new System.Drawing.Point(143, 311);
            this.mascul_radioBut.Name = "mascul_radioBut";
            this.mascul_radioBut.Size = new System.Drawing.Size(73, 17);
            this.mascul_radioBut.TabIndex = 48;
            this.mascul_radioBut.TabStop = true;
            this.mascul_radioBut.Text = "Masculino";
            this.mascul_radioBut.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Sexo (*):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Mail:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 493);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "(*) Campos Obligatorios";
            // 
            // mail_Tbox
            // 
            this.mail_Tbox.Location = new System.Drawing.Point(143, 226);
            this.mail_Tbox.Name = "mail_Tbox";
            this.mail_Tbox.Size = new System.Drawing.Size(138, 20);
            this.mail_Tbox.TabIndex = 43;
            // 
            // tel_Tbox
            // 
            this.tel_Tbox.Location = new System.Drawing.Point(143, 192);
            this.tel_Tbox.Name = "tel_Tbox";
            this.tel_Tbox.Size = new System.Drawing.Size(138, 20);
            this.tel_Tbox.TabIndex = 42;
            this.tel_Tbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tel_Tbox_KeyPress);
            // 
            // dir_Tbox
            // 
            this.dir_Tbox.Location = new System.Drawing.Point(143, 158);
            this.dir_Tbox.Name = "dir_Tbox";
            this.dir_Tbox.Size = new System.Drawing.Size(138, 20);
            this.dir_Tbox.TabIndex = 41;
            this.dir_Tbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dir_Tbox_KeyPress);
            // 
            // apell_Tbox
            // 
            this.apell_Tbox.Location = new System.Drawing.Point(143, 118);
            this.apell_Tbox.Name = "apell_Tbox";
            this.apell_Tbox.Size = new System.Drawing.Size(138, 20);
            this.apell_Tbox.TabIndex = 40;
            this.apell_Tbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apell_Tbox_KeyPress);
            // 
            // nombre_Tbox
            // 
            this.nombre_Tbox.Location = new System.Drawing.Point(143, 82);
            this.nombre_Tbox.Name = "nombre_Tbox";
            this.nombre_Tbox.Size = new System.Drawing.Size(138, 20);
            this.nombre_Tbox.TabIndex = 39;
            this.nombre_Tbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_Tbox_KeyPress);
            // 
            // DNI_Tbox
            // 
            this.DNI_Tbox.Location = new System.Drawing.Point(143, 49);
            this.DNI_Tbox.Name = "DNI_Tbox";
            this.DNI_Tbox.Size = new System.Drawing.Size(138, 20);
            this.DNI_Tbox.TabIndex = 38;
            this.DNI_Tbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DNI_Tbox_KeyPress);
            // 
            // limpiar_boton
            // 
            this.limpiar_boton.Location = new System.Drawing.Point(23, 447);
            this.limpiar_boton.Name = "limpiar_boton";
            this.limpiar_boton.Size = new System.Drawing.Size(122, 32);
            this.limpiar_boton.TabIndex = 37;
            this.limpiar_boton.Text = "Limpiar";
            this.limpiar_boton.UseVisualStyleBackColor = true;
            this.limpiar_boton.Click += new System.EventHandler(this.limpiar_boton_Click);
            // 
            // guardar_boton
            // 
            this.guardar_boton.Location = new System.Drawing.Point(293, 447);
            this.guardar_boton.Name = "guardar_boton";
            this.guardar_boton.Size = new System.Drawing.Size(122, 32);
            this.guardar_boton.TabIndex = 36;
            this.guardar_boton.Text = "Guardar";
            this.guardar_boton.UseVisualStyleBackColor = true;
            this.guardar_boton.Click += new System.EventHandler(this.guardar_boton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Fecha de Nacimiento (*):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Telefono (*):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Dirección (*):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "DNI (*):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Apellido (*):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nombre (*):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 371);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "Peso de encomienda";
            // 
            // peso_encom_tbox
            // 
            this.peso_encom_tbox.Location = new System.Drawing.Point(167, 371);
            this.peso_encom_tbox.Name = "peso_encom_tbox";
            this.peso_encom_tbox.Size = new System.Drawing.Size(113, 20);
            this.peso_encom_tbox.TabIndex = 52;
            this.peso_encom_tbox.Text = "0";
            this.peso_encom_tbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.peso_encom_tbox_KeyPress);
            // 
            // check_peso_encom_boton
            // 
            this.check_peso_encom_boton.Location = new System.Drawing.Point(309, 362);
            this.check_peso_encom_boton.Name = "check_peso_encom_boton";
            this.check_peso_encom_boton.Size = new System.Drawing.Size(117, 37);
            this.check_peso_encom_boton.TabIndex = 53;
            this.check_peso_encom_boton.Text = "Validar Peso";
            this.check_peso_encom_boton.UseVisualStyleBackColor = true;
            this.check_peso_encom_boton.Click += new System.EventHandler(this.check_peso_encom_boton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(92, 419);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "Precio: ";
            // 
            // precio_encomiendaTbox
            // 
            this.precio_encomiendaTbox.Enabled = false;
            this.precio_encomiendaTbox.Location = new System.Drawing.Point(167, 412);
            this.precio_encomiendaTbox.Name = "precio_encomiendaTbox";
            this.precio_encomiendaTbox.Size = new System.Drawing.Size(114, 20);
            this.precio_encomiendaTbox.TabIndex = 55;
            this.precio_encomiendaTbox.Text = "0";
            // 
            // discapacitado_checkB
            // 
            this.discapacitado_checkB.AutoSize = true;
            this.discapacitado_checkB.Location = new System.Drawing.Point(293, 312);
            this.discapacitado_checkB.Name = "discapacitado_checkB";
            this.discapacitado_checkB.Size = new System.Drawing.Size(97, 17);
            this.discapacitado_checkB.TabIndex = 56;
            this.discapacitado_checkB.Text = "Discapacitado ";
            this.discapacitado_checkB.UseVisualStyleBackColor = true;
            // 
            // pensionado_checkB
            // 
            this.pensionado_checkB.AutoSize = true;
            this.pensionado_checkB.Location = new System.Drawing.Point(293, 339);
            this.pensionado_checkB.Name = "pensionado_checkB";
            this.pensionado_checkB.Size = new System.Drawing.Size(82, 17);
            this.pensionado_checkB.TabIndex = 57;
            this.pensionado_checkB.Text = "Pensionado";
            this.pensionado_checkB.UseVisualStyleBackColor = true;
            // 
            // jubilado_checkB
            // 
            this.jubilado_checkB.AutoSize = true;
            this.jubilado_checkB.Enabled = false;
            this.jubilado_checkB.Location = new System.Drawing.Point(293, 289);
            this.jubilado_checkB.Name = "jubilado_checkB";
            this.jubilado_checkB.Size = new System.Drawing.Size(65, 17);
            this.jubilado_checkB.TabIndex = 58;
            this.jubilado_checkB.Text = "Jubilado";
            this.jubilado_checkB.UseVisualStyleBackColor = true;
            // 
            // fecNacDateTimeP
            // 
            this.fecNacDateTimeP.CustomFormat = "dd/MM/yyyy";
            this.fecNacDateTimeP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecNacDateTimeP.Location = new System.Drawing.Point(143, 256);
            this.fecNacDateTimeP.Name = "fecNacDateTimeP";
            this.fecNacDateTimeP.Size = new System.Drawing.Size(96, 20);
            this.fecNacDateTimeP.TabIndex = 117;
            // 
            // Form_encomienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 515);
            this.Controls.Add(this.fecNacDateTimeP);
            this.Controls.Add(this.jubilado_checkB);
            this.Controls.Add(this.pensionado_checkB);
            this.Controls.Add(this.discapacitado_checkB);
            this.Controls.Add(this.precio_encomiendaTbox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.check_peso_encom_boton);
            this.Controls.Add(this.peso_encom_tbox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.fem_radButton);
            this.Controls.Add(this.mascul_radioBut);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mail_Tbox);
            this.Controls.Add(this.tel_Tbox);
            this.Controls.Add(this.dir_Tbox);
            this.Controls.Add(this.apell_Tbox);
            this.Controls.Add(this.nombre_Tbox);
            this.Controls.Add(this.DNI_Tbox);
            this.Controls.Add(this.limpiar_boton);
            this.Controls.Add(this.guardar_boton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_encomienda";
            this.Text = "Encomienda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_encomienda_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.RadioButton fem_radButton;
        public System.Windows.Forms.RadioButton mascul_radioBut;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox mail_Tbox;
        public System.Windows.Forms.TextBox tel_Tbox;
        public System.Windows.Forms.TextBox dir_Tbox;
        public System.Windows.Forms.TextBox apell_Tbox;
        public System.Windows.Forms.TextBox nombre_Tbox;
        private System.Windows.Forms.Button limpiar_boton;
        private System.Windows.Forms.Button guardar_boton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button check_peso_encom_boton;
        public System.Windows.Forms.TextBox peso_encom_tbox;
        public System.Windows.Forms.TextBox DNI_Tbox;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox precio_encomiendaTbox;
        public System.Windows.Forms.CheckBox discapacitado_checkB;
        public System.Windows.Forms.CheckBox pensionado_checkB;
        public System.Windows.Forms.CheckBox jubilado_checkB;
        public System.Windows.Forms.DateTimePicker fecNacDateTimeP;
    }
}