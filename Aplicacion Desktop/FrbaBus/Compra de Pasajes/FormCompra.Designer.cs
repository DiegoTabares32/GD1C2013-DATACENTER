namespace FrbaBus.Compra_de_Pasajes
{
    partial class FormCompra
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
            this.login_boton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fecha_tbox = new System.Windows.Forms.TextBox();
            this.select_boton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ciu_orig_list = new System.Windows.Forms.ComboBox();
            this.ciu_dest_list = new System.Windows.Forms.ComboBox();
            this.busc_viaje_boton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.fechaActualDateTimeP = new System.Windows.Forms.DateTimePicker();
            this.cargar_pas_boton = new System.Windows.Forms.Button();
            this.CantPasaj_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.sub_total_pasaj_tbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cant_encomiendas_numUpdown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cant_totKg_tbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sub_tot_encom_tbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.total_tbox = new System.Windows.Forms.TextBox();
            this.aceptar_boton = new System.Windows.Forms.Button();
            this.cancelar_boton = new System.Windows.Forms.Button();
            this.carg_encom_boton = new System.Windows.Forms.Button();
            this.selec_viaje_encom_button = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonConsultaPuntos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CantPasaj_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cant_encomiendas_numUpdown)).BeginInit();
            this.SuspendLayout();
            // 
            // login_boton
            // 
            this.login_boton.Location = new System.Drawing.Point(506, 3);
            this.login_boton.Name = "login_boton";
            this.login_boton.Size = new System.Drawing.Size(64, 25);
            this.login_boton.TabIndex = 0;
            this.login_boton.Text = "login";
            this.login_boton.UseVisualStyleBackColor = true;
            this.login_boton.Click += new System.EventHandler(this.login_boton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese Fecha de Viaje (*):";
            // 
            // fecha_tbox
            // 
            this.fecha_tbox.Enabled = false;
            this.fecha_tbox.Location = new System.Drawing.Point(213, 45);
            this.fecha_tbox.Name = "fecha_tbox";
            this.fecha_tbox.Size = new System.Drawing.Size(150, 20);
            this.fecha_tbox.TabIndex = 3;
            // 
            // select_boton
            // 
            this.select_boton.Location = new System.Drawing.Point(246, 89);
            this.select_boton.Name = "select_boton";
            this.select_boton.Size = new System.Drawing.Size(118, 26);
            this.select_boton.TabIndex = 4;
            this.select_boton.Text = "Seleccionar Fecha";
            this.select_boton.UseVisualStyleBackColor = true;
            this.select_boton.Click += new System.EventHandler(this.select_boton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seleccione Ciudad Origen (*):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Seleccione Ciudad Destino (*):";
            // 
            // ciu_orig_list
            // 
            this.ciu_orig_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ciu_orig_list.FormattingEnabled = true;
            this.ciu_orig_list.Location = new System.Drawing.Point(213, 140);
            this.ciu_orig_list.Name = "ciu_orig_list";
            this.ciu_orig_list.Size = new System.Drawing.Size(150, 21);
            this.ciu_orig_list.TabIndex = 10;
            // 
            // ciu_dest_list
            // 
            this.ciu_dest_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ciu_dest_list.FormattingEnabled = true;
            this.ciu_dest_list.Location = new System.Drawing.Point(213, 179);
            this.ciu_dest_list.Name = "ciu_dest_list";
            this.ciu_dest_list.Size = new System.Drawing.Size(150, 21);
            this.ciu_dest_list.TabIndex = 11;
            // 
            // busc_viaje_boton
            // 
            this.busc_viaje_boton.Location = new System.Drawing.Point(232, 325);
            this.busc_viaje_boton.Name = "busc_viaje_boton";
            this.busc_viaje_boton.Size = new System.Drawing.Size(118, 31);
            this.busc_viaje_boton.TabIndex = 12;
            this.busc_viaje_boton.Text = "Seleccionar Viaje";
            this.busc_viaje_boton.UseVisualStyleBackColor = true;
            this.busc_viaje_boton.Click += new System.EventHandler(this.busc_viaje_boton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ingrese Cantidad de Pasajes a comprar:";
            // 
            // fechaActualDateTimeP
            // 
            this.fechaActualDateTimeP.Location = new System.Drawing.Point(41, 8);
            this.fechaActualDateTimeP.Name = "fechaActualDateTimeP";
            this.fechaActualDateTimeP.Size = new System.Drawing.Size(200, 20);
            this.fechaActualDateTimeP.TabIndex = 16;
            // 
            // cargar_pas_boton
            // 
            this.cargar_pas_boton.Location = new System.Drawing.Point(398, 298);
            this.cargar_pas_boton.Name = "cargar_pas_boton";
            this.cargar_pas_boton.Size = new System.Drawing.Size(117, 30);
            this.cargar_pas_boton.TabIndex = 18;
            this.cargar_pas_boton.Text = "Cargar Pasaje";
            this.cargar_pas_boton.UseVisualStyleBackColor = true;
            this.cargar_pas_boton.Click += new System.EventHandler(this.cargar_pas_boton_Click);
            // 
            // CantPasaj_numericUpDown
            // 
            this.CantPasaj_numericUpDown.Location = new System.Drawing.Point(243, 288);
            this.CantPasaj_numericUpDown.Name = "CantPasaj_numericUpDown";
            this.CantPasaj_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.CantPasaj_numericUpDown.TabIndex = 19;
            this.CantPasaj_numericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NroPasaj_numericUpDown_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "SubTotal Pasajes:";
            // 
            // sub_total_pasaj_tbox
            // 
            this.sub_total_pasaj_tbox.Enabled = false;
            this.sub_total_pasaj_tbox.Location = new System.Drawing.Point(232, 383);
            this.sub_total_pasaj_tbox.Name = "sub_total_pasaj_tbox";
            this.sub_total_pasaj_tbox.Size = new System.Drawing.Size(131, 20);
            this.sub_total_pasaj_tbox.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 431);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Ingrese Cantidad  de Encomiendas a Enviar";
            // 
            // cant_encomiendas_numUpdown
            // 
            this.cant_encomiendas_numUpdown.Location = new System.Drawing.Point(243, 429);
            this.cant_encomiendas_numUpdown.Name = "cant_encomiendas_numUpdown";
            this.cant_encomiendas_numUpdown.Size = new System.Drawing.Size(120, 20);
            this.cant_encomiendas_numUpdown.TabIndex = 23;
            this.cant_encomiendas_numUpdown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cant_encomiendas_numUpdown_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 582);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "SubTotal Encomiendas:";
            // 
            // cant_totKg_tbox
            // 
            this.cant_totKg_tbox.Enabled = false;
            this.cant_totKg_tbox.Location = new System.Drawing.Point(232, 542);
            this.cant_totKg_tbox.Name = "cant_totKg_tbox";
            this.cant_totKg_tbox.Size = new System.Drawing.Size(131, 20);
            this.cant_totKg_tbox.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 542);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Cantidad de KG totales a enviar:";
            // 
            // sub_tot_encom_tbox
            // 
            this.sub_tot_encom_tbox.Enabled = false;
            this.sub_tot_encom_tbox.Location = new System.Drawing.Point(232, 579);
            this.sub_tot_encom_tbox.Name = "sub_tot_encom_tbox";
            this.sub_tot_encom_tbox.Size = new System.Drawing.Size(132, 20);
            this.sub_tot_encom_tbox.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 644);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Total:";
            // 
            // total_tbox
            // 
            this.total_tbox.Enabled = false;
            this.total_tbox.Location = new System.Drawing.Point(79, 644);
            this.total_tbox.Name = "total_tbox";
            this.total_tbox.Size = new System.Drawing.Size(102, 20);
            this.total_tbox.TabIndex = 29;
            // 
            // aceptar_boton
            // 
            this.aceptar_boton.Location = new System.Drawing.Point(213, 638);
            this.aceptar_boton.Name = "aceptar_boton";
            this.aceptar_boton.Size = new System.Drawing.Size(115, 24);
            this.aceptar_boton.TabIndex = 30;
            this.aceptar_boton.Text = "Aceptar";
            this.aceptar_boton.UseVisualStyleBackColor = true;
            this.aceptar_boton.Click += new System.EventHandler(this.aceptar_boton_Click);
            // 
            // cancelar_boton
            // 
            this.cancelar_boton.Location = new System.Drawing.Point(371, 638);
            this.cancelar_boton.Name = "cancelar_boton";
            this.cancelar_boton.Size = new System.Drawing.Size(115, 24);
            this.cancelar_boton.TabIndex = 31;
            this.cancelar_boton.Text = "Cancelar";
            this.cancelar_boton.UseVisualStyleBackColor = true;
            this.cancelar_boton.Click += new System.EventHandler(this.cancelar_boton_Click);
            // 
            // carg_encom_boton
            // 
            this.carg_encom_boton.Location = new System.Drawing.Point(398, 442);
            this.carg_encom_boton.Name = "carg_encom_boton";
            this.carg_encom_boton.Size = new System.Drawing.Size(117, 30);
            this.carg_encom_boton.TabIndex = 32;
            this.carg_encom_boton.Text = "Cargar Encomienda";
            this.carg_encom_boton.UseVisualStyleBackColor = true;
            this.carg_encom_boton.Click += new System.EventHandler(this.carg_encom_boton_Click);
            // 
            // selec_viaje_encom_button
            // 
            this.selec_viaje_encom_button.Location = new System.Drawing.Point(233, 474);
            this.selec_viaje_encom_button.Name = "selec_viaje_encom_button";
            this.selec_viaje_encom_button.Size = new System.Drawing.Size(118, 31);
            this.selec_viaje_encom_button.TabIndex = 33;
            this.selec_viaje_encom_button.Text = "Seleccionar Viaje";
            this.selec_viaje_encom_button.UseVisualStyleBackColor = true;
            this.selec_viaje_encom_button.Click += new System.EventHandler(this.selec_viaje_encom_button_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(454, 684);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 13);
            this.label16.TabIndex = 81;
            this.label16.Text = "(*) Campos Obligatorios";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 13);
            this.label10.TabIndex = 82;
            this.label10.Text = "Seleccione Viaje para Pasaje :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 483);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 13);
            this.label11.TabIndex = 83;
            this.label11.Text = "Seleccione Viaje para Encomienda :";
            // 
            // buttonConsultaPuntos
            // 
            this.buttonConsultaPuntos.AutoSize = true;
            this.buttonConsultaPuntos.Location = new System.Drawing.Point(457, 52);
            this.buttonConsultaPuntos.Name = "buttonConsultaPuntos";
            this.buttonConsultaPuntos.Size = new System.Drawing.Size(109, 31);
            this.buttonConsultaPuntos.TabIndex = 84;
            this.buttonConsultaPuntos.Text = "Consulta de Puntos";
            this.buttonConsultaPuntos.UseVisualStyleBackColor = true;
            this.buttonConsultaPuntos.Click += new System.EventHandler(this.buttonConsultaPuntos_Click);
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 706);
            this.Controls.Add(this.buttonConsultaPuntos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.selec_viaje_encom_button);
            this.Controls.Add(this.carg_encom_boton);
            this.Controls.Add(this.cancelar_boton);
            this.Controls.Add(this.aceptar_boton);
            this.Controls.Add(this.total_tbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sub_tot_encom_tbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cant_totKg_tbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cant_encomiendas_numUpdown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sub_total_pasaj_tbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CantPasaj_numericUpDown);
            this.Controls.Add(this.cargar_pas_boton);
            this.Controls.Add(this.fechaActualDateTimeP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.busc_viaje_boton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ciu_dest_list);
            this.Controls.Add(this.fecha_tbox);
            this.Controls.Add(this.select_boton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ciu_orig_list);
            this.Controls.Add(this.login_boton);
            this.Name = "FormCompra";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.FormCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CantPasaj_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cant_encomiendas_numUpdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button select_boton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox fecha_tbox;
        private System.Windows.Forms.Button busc_viaje_boton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker fechaActualDateTimeP;
        private System.Windows.Forms.Button cargar_pas_boton;
        public System.Windows.Forms.ComboBox ciu_orig_list;
        public System.Windows.Forms.ComboBox ciu_dest_list;
        public System.Windows.Forms.NumericUpDown CantPasaj_numericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sub_total_pasaj_tbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown cant_encomiendas_numUpdown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button aceptar_boton;
        private System.Windows.Forms.Button cancelar_boton;
        private System.Windows.Forms.Button carg_encom_boton;
        private System.Windows.Forms.Button selec_viaje_encom_button;
        public System.Windows.Forms.TextBox cant_totKg_tbox;
        public System.Windows.Forms.TextBox sub_tot_encom_tbox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button login_boton;
        public System.Windows.Forms.TextBox total_tbox;
        private System.Windows.Forms.Button buttonConsultaPuntos;
    }
}