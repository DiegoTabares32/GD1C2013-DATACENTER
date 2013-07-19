namespace FrbaBus.Compra_de_Pasajes
{
    partial class Form_Comprador
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
            this.label11 = new System.Windows.Forms.Label();
            this.fem_radButton = new System.Windows.Forms.RadioButton();
            this.mascul_radioBut = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mail_Tbox = new System.Windows.Forms.TextBox();
            this.tel_Tbox = new System.Windows.Forms.TextBox();
            this.dir_Tbox = new System.Windows.Forms.TextBox();
            this.apell_Tbox = new System.Windows.Forms.TextBox();
            this.nombre_Tbox = new System.Windows.Forms.TextBox();
            this.DNI_Tbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nro_tarj_tbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cod_Seg_tbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tipoTarj_comboBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cant_cuot_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.Limpiar_boton = new System.Windows.Forms.Button();
            this.aceptar_boton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.confirmar_boton = new System.Windows.Forms.Button();
            this.discapacitado_checkB = new System.Windows.Forms.CheckBox();
            this.jubilado_checkB = new System.Windows.Forms.CheckBox();
            this.pensionado_checkB = new System.Windows.Forms.CheckBox();
            this.fecNacDateTimeP = new System.Windows.Forms.DateTimePicker();
            this.fecVencDateTimeP = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.cant_cuot_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(181, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 13);
            this.label11.TabIndex = 69;
            this.label11.Text = "formato: dd/mm/aaaa";
            // 
            // fem_radButton
            // 
            this.fem_radButton.AutoSize = true;
            this.fem_radButton.Location = new System.Drawing.Point(143, 333);
            this.fem_radButton.Name = "fem_radButton";
            this.fem_radButton.Size = new System.Drawing.Size(71, 17);
            this.fem_radButton.TabIndex = 68;
            this.fem_radButton.TabStop = true;
            this.fem_radButton.Text = "Femenino";
            this.fem_radButton.UseVisualStyleBackColor = true;
            // 
            // mascul_radioBut
            // 
            this.mascul_radioBut.AutoSize = true;
            this.mascul_radioBut.Location = new System.Drawing.Point(143, 310);
            this.mascul_radioBut.Name = "mascul_radioBut";
            this.mascul_radioBut.Size = new System.Drawing.Size(73, 17);
            this.mascul_radioBut.TabIndex = 67;
            this.mascul_radioBut.TabStop = true;
            this.mascul_radioBut.Text = "Masculino";
            this.mascul_radioBut.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 66;
            this.label10.Text = "Sexo (*):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 64;
            this.label9.Text = "Mail:";
            // 
            // mail_Tbox
            // 
            this.mail_Tbox.Location = new System.Drawing.Point(143, 225);
            this.mail_Tbox.Name = "mail_Tbox";
            this.mail_Tbox.Size = new System.Drawing.Size(138, 20);
            this.mail_Tbox.TabIndex = 63;
            // 
            // tel_Tbox
            // 
            this.tel_Tbox.Location = new System.Drawing.Point(143, 191);
            this.tel_Tbox.Name = "tel_Tbox";
            this.tel_Tbox.Size = new System.Drawing.Size(138, 20);
            this.tel_Tbox.TabIndex = 62;
            this.tel_Tbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tel_Tbox_KeyPress);
            // 
            // dir_Tbox
            // 
            this.dir_Tbox.Location = new System.Drawing.Point(143, 157);
            this.dir_Tbox.Name = "dir_Tbox";
            this.dir_Tbox.Size = new System.Drawing.Size(138, 20);
            this.dir_Tbox.TabIndex = 61;
            this.dir_Tbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dir_Tbox_KeyPress);
            // 
            // apell_Tbox
            // 
            this.apell_Tbox.Location = new System.Drawing.Point(143, 117);
            this.apell_Tbox.Name = "apell_Tbox";
            this.apell_Tbox.Size = new System.Drawing.Size(138, 20);
            this.apell_Tbox.TabIndex = 60;
            this.apell_Tbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apell_Tbox_KeyPress);
            // 
            // nombre_Tbox
            // 
            this.nombre_Tbox.Location = new System.Drawing.Point(143, 81);
            this.nombre_Tbox.Name = "nombre_Tbox";
            this.nombre_Tbox.Size = new System.Drawing.Size(138, 20);
            this.nombre_Tbox.TabIndex = 59;
            this.nombre_Tbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_Tbox_KeyPress);
            // 
            // DNI_Tbox
            // 
            this.DNI_Tbox.Location = new System.Drawing.Point(143, 48);
            this.DNI_Tbox.Name = "DNI_Tbox";
            this.DNI_Tbox.Size = new System.Drawing.Size(138, 20);
            this.DNI_Tbox.TabIndex = 58;
            this.DNI_Tbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DNI_Tbox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Fecha de Nacimiento (*):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Telefono (*):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Dirección (*):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "DNI (*):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Apellido (*):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Nombre (*):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Ingrese datos del Comprador";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 13);
            this.label8.TabIndex = 70;
            this.label8.Text = "Ingrese Nro de Tarjeta de Credito (*):";
            // 
            // nro_tarj_tbox
            // 
            this.nro_tarj_tbox.Location = new System.Drawing.Point(220, 376);
            this.nro_tarj_tbox.MaxLength = 16;
            this.nro_tarj_tbox.Name = "nro_tarj_tbox";
            this.nro_tarj_tbox.Size = new System.Drawing.Size(145, 20);
            this.nro_tarj_tbox.TabIndex = 71;
            this.nro_tarj_tbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nro_tarj_tbox_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 421);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 13);
            this.label12.TabIndex = 72;
            this.label12.Text = "Ingrese Codigo de Seguridad(*)";
            // 
            // cod_Seg_tbox
            // 
            this.cod_Seg_tbox.Location = new System.Drawing.Point(220, 418);
            this.cod_Seg_tbox.MaxLength = 4;
            this.cod_Seg_tbox.Name = "cod_Seg_tbox";
            this.cod_Seg_tbox.Size = new System.Drawing.Size(145, 20);
            this.cod_Seg_tbox.TabIndex = 73;
            this.cod_Seg_tbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cod_Seg_tbox_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 459);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(161, 13);
            this.label13.TabIndex = 74;
            this.label13.Text = "Ingrese Fecha de Vencimiento(*)";
            // 
            // tipoTarj_comboBox
            // 
            this.tipoTarj_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoTarj_comboBox.FormattingEnabled = true;
            this.tipoTarj_comboBox.Location = new System.Drawing.Point(220, 522);
            this.tipoTarj_comboBox.Name = "tipoTarj_comboBox";
            this.tipoTarj_comboBox.Size = new System.Drawing.Size(145, 21);
            this.tipoTarj_comboBox.TabIndex = 76;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 525);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 13);
            this.label14.TabIndex = 77;
            this.label14.Text = "Seleccione Tipo de Tarjeta (*):";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 587);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(144, 13);
            this.label15.TabIndex = 78;
            this.label15.Text = "Ingrese Cantidad de Cuotas: ";
            // 
            // cant_cuot_numericUpDown
            // 
            this.cant_cuot_numericUpDown.Location = new System.Drawing.Point(218, 585);
            this.cant_cuot_numericUpDown.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.cant_cuot_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cant_cuot_numericUpDown.Name = "cant_cuot_numericUpDown";
            this.cant_cuot_numericUpDown.Size = new System.Drawing.Size(73, 20);
            this.cant_cuot_numericUpDown.TabIndex = 79;
            this.cant_cuot_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(437, 698);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 13);
            this.label16.TabIndex = 80;
            this.label16.Text = "(*) Campos Obligatorios";
            // 
            // Limpiar_boton
            // 
            this.Limpiar_boton.Location = new System.Drawing.Point(67, 649);
            this.Limpiar_boton.Name = "Limpiar_boton";
            this.Limpiar_boton.Size = new System.Drawing.Size(133, 32);
            this.Limpiar_boton.TabIndex = 81;
            this.Limpiar_boton.Text = "Limpiar";
            this.Limpiar_boton.UseVisualStyleBackColor = true;
            this.Limpiar_boton.Click += new System.EventHandler(this.Limpiar_boton_Click);
            // 
            // aceptar_boton
            // 
            this.aceptar_boton.Location = new System.Drawing.Point(271, 649);
            this.aceptar_boton.Name = "aceptar_boton";
            this.aceptar_boton.Size = new System.Drawing.Size(133, 32);
            this.aceptar_boton.TabIndex = 82;
            this.aceptar_boton.Text = "Aceptar";
            this.aceptar_boton.UseVisualStyleBackColor = true;
            this.aceptar_boton.Click += new System.EventHandler(this.aceptar_boton_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(217, 482);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 13);
            this.label17.TabIndex = 83;
            this.label17.Text = "Formato de Fecha MMAA";
            // 
            // confirmar_boton
            // 
            this.confirmar_boton.Location = new System.Drawing.Point(398, 516);
            this.confirmar_boton.Name = "confirmar_boton";
            this.confirmar_boton.Size = new System.Drawing.Size(139, 31);
            this.confirmar_boton.TabIndex = 84;
            this.confirmar_boton.Text = "Verificar tipo Tarjeta";
            this.confirmar_boton.UseVisualStyleBackColor = true;
            this.confirmar_boton.Click += new System.EventHandler(this.confirmar_boton_Click);
            // 
            // discapacitado_checkB
            // 
            this.discapacitado_checkB.AutoSize = true;
            this.discapacitado_checkB.Location = new System.Drawing.Point(290, 294);
            this.discapacitado_checkB.Name = "discapacitado_checkB";
            this.discapacitado_checkB.Size = new System.Drawing.Size(97, 17);
            this.discapacitado_checkB.TabIndex = 85;
            this.discapacitado_checkB.Text = "Discapacitado ";
            this.discapacitado_checkB.UseVisualStyleBackColor = true;
            // 
            // jubilado_checkB
            // 
            this.jubilado_checkB.AutoSize = true;
            this.jubilado_checkB.Enabled = false;
            this.jubilado_checkB.Location = new System.Drawing.Point(290, 317);
            this.jubilado_checkB.Name = "jubilado_checkB";
            this.jubilado_checkB.Size = new System.Drawing.Size(65, 17);
            this.jubilado_checkB.TabIndex = 86;
            this.jubilado_checkB.Text = "Jubilado";
            this.jubilado_checkB.UseVisualStyleBackColor = true;
            // 
            // pensionado_checkB
            // 
            this.pensionado_checkB.AutoSize = true;
            this.pensionado_checkB.Location = new System.Drawing.Point(290, 340);
            this.pensionado_checkB.Name = "pensionado_checkB";
            this.pensionado_checkB.Size = new System.Drawing.Size(82, 17);
            this.pensionado_checkB.TabIndex = 87;
            this.pensionado_checkB.Text = "Pensionado";
            this.pensionado_checkB.UseVisualStyleBackColor = true;
            // 
            // fecNacDateTimeP
            // 
            this.fecNacDateTimeP.CustomFormat = "dd/MM/yyyy";
            this.fecNacDateTimeP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecNacDateTimeP.Location = new System.Drawing.Point(147, 255);
            this.fecNacDateTimeP.Name = "fecNacDateTimeP";
            this.fecNacDateTimeP.Size = new System.Drawing.Size(96, 20);
            this.fecNacDateTimeP.TabIndex = 116;
            // 
            // fecVencDateTimeP
            // 
            this.fecVencDateTimeP.CustomFormat = "MM-yy";
            this.fecVencDateTimeP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecVencDateTimeP.Location = new System.Drawing.Point(218, 459);
            this.fecVencDateTimeP.Name = "fecVencDateTimeP";
            this.fecVencDateTimeP.Size = new System.Drawing.Size(73, 20);
            this.fecVencDateTimeP.TabIndex = 117;
            // 
            // Form_Comprador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 725);
            this.Controls.Add(this.fecVencDateTimeP);
            this.Controls.Add(this.fecNacDateTimeP);
            this.Controls.Add(this.pensionado_checkB);
            this.Controls.Add(this.jubilado_checkB);
            this.Controls.Add(this.discapacitado_checkB);
            this.Controls.Add(this.confirmar_boton);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.aceptar_boton);
            this.Controls.Add(this.Limpiar_boton);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cant_cuot_numericUpDown);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tipoTarj_comboBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cod_Seg_tbox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nro_tarj_tbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.fem_radButton);
            this.Controls.Add(this.mascul_radioBut);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mail_Tbox);
            this.Controls.Add(this.tel_Tbox);
            this.Controls.Add(this.dir_Tbox);
            this.Controls.Add(this.apell_Tbox);
            this.Controls.Add(this.nombre_Tbox);
            this.Controls.Add(this.DNI_Tbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Comprador";
            this.Text = "Compra con Tarjeta";
            this.Load += new System.EventHandler(this.Form_Comprador_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Comprador_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.cant_cuot_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.RadioButton fem_radButton;
        public System.Windows.Forms.RadioButton mascul_radioBut;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox mail_Tbox;
        public System.Windows.Forms.TextBox tel_Tbox;
        public System.Windows.Forms.TextBox dir_Tbox;
        public System.Windows.Forms.TextBox apell_Tbox;
        public System.Windows.Forms.TextBox nombre_Tbox;
        private System.Windows.Forms.TextBox DNI_Tbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nro_tarj_tbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox cod_Seg_tbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox tipoTarj_comboBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown cant_cuot_numericUpDown;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button Limpiar_boton;
        private System.Windows.Forms.Button aceptar_boton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button confirmar_boton;
        public System.Windows.Forms.CheckBox discapacitado_checkB;
        public System.Windows.Forms.CheckBox jubilado_checkB;
        public System.Windows.Forms.CheckBox pensionado_checkB;
        public System.Windows.Forms.DateTimePicker fecNacDateTimeP;
        private System.Windows.Forms.DateTimePicker fecVencDateTimeP;
    }
}