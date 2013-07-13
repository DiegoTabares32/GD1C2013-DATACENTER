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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cargar_pas_boton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_boton
            // 
            this.login_boton.Location = new System.Drawing.Point(649, 3);
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
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese Fecha de Viaje";
            // 
            // fecha_tbox
            // 
            this.fecha_tbox.Location = new System.Drawing.Point(183, 45);
            this.fecha_tbox.Name = "fecha_tbox";
            this.fecha_tbox.Size = new System.Drawing.Size(150, 20);
            this.fecha_tbox.TabIndex = 3;
            // 
            // select_boton
            // 
            this.select_boton.Location = new System.Drawing.Point(215, 85);
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
            this.label2.Location = new System.Drawing.Point(13, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingrese Ciudad Origen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ingrese Ciudad Destino";
            // 
            // ciu_orig_list
            // 
            this.ciu_orig_list.FormattingEnabled = true;
            this.ciu_orig_list.Location = new System.Drawing.Point(183, 140);
            this.ciu_orig_list.Name = "ciu_orig_list";
            this.ciu_orig_list.Size = new System.Drawing.Size(150, 21);
            this.ciu_orig_list.TabIndex = 10;
            // 
            // ciu_dest_list
            // 
            this.ciu_dest_list.FormattingEnabled = true;
            this.ciu_dest_list.Location = new System.Drawing.Point(183, 184);
            this.ciu_dest_list.Name = "ciu_dest_list";
            this.ciu_dest_list.Size = new System.Drawing.Size(150, 21);
            this.ciu_dest_list.TabIndex = 11;
            // 
            // busc_viaje_boton
            // 
            this.busc_viaje_boton.Location = new System.Drawing.Point(215, 228);
            this.busc_viaje_boton.Name = "busc_viaje_boton";
            this.busc_viaje_boton.Size = new System.Drawing.Size(118, 31);
            this.busc_viaje_boton.TabIndex = 12;
            this.busc_viaje_boton.Text = "Buscar Viajes";
            this.busc_viaje_boton.UseVisualStyleBackColor = true;
            this.busc_viaje_boton.Click += new System.EventHandler(this.busc_viaje_boton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ingrese Cantidad de Pasajes a comprar:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 8);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // cargar_pas_boton
            // 
            this.cargar_pas_boton.Location = new System.Drawing.Point(216, 394);
            this.cargar_pas_boton.Name = "cargar_pas_boton";
            this.cargar_pas_boton.Size = new System.Drawing.Size(117, 30);
            this.cargar_pas_boton.TabIndex = 18;
            this.cargar_pas_boton.Text = "Cargar Pasajero";
            this.cargar_pas_boton.UseVisualStyleBackColor = true;
            this.cargar_pas_boton.Click += new System.EventHandler(this.cargar_pas_boton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(216, 325);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 19;
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 499);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cargar_pas_boton);
            this.Controls.Add(this.dateTimePicker1);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_boton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button select_boton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox fecha_tbox;
        private System.Windows.Forms.Button busc_viaje_boton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button cargar_pas_boton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.ComboBox ciu_orig_list;
        public System.Windows.Forms.ComboBox ciu_dest_list;
    }
}