namespace FrbaBus.GenerarViaje
{
    partial class Alta_Viaje
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerSalida = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerLlegada = new System.Windows.Forms.DateTimePicker();
            this.textBoxFecLleg = new System.Windows.Forms.TextBox();
            this.textBoxMicro = new System.Windows.Forms.TextBox();
            this.textBoxReco = new System.Windows.Forms.TextBox();
            this.botonSelMicro = new System.Windows.Forms.Button();
            this.botonSelReco = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de Salida:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de Llegada Estimada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Llegada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Micro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Recorrido";
            // 
            // dateTimePickerSalida
            // 
            this.dateTimePickerSalida.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePickerSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSalida.Location = new System.Drawing.Point(160, 18);
            this.dateTimePickerSalida.MaxDate = new System.DateTime(2023, 7, 1, 0, 0, 0, 0);
            this.dateTimePickerSalida.MinDate = new System.DateTime(2013, 7, 1, 0, 0, 0, 0);
            this.dateTimePickerSalida.Name = "dateTimePickerSalida";
            this.dateTimePickerSalida.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerSalida.TabIndex = 5;
            this.dateTimePickerSalida.Value = new System.DateTime(2013, 7, 19, 0, 0, 0, 0);
            this.dateTimePickerSalida.ValueChanged += new System.EventHandler(this.dateTimePickerSalida_ValueChanged);
            // 
            // dateTimePickerLlegada
            // 
            this.dateTimePickerLlegada.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePickerLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerLlegada.Location = new System.Drawing.Point(160, 57);
            this.dateTimePickerLlegada.MaxDate = new System.DateTime(2023, 7, 2, 0, 0, 0, 0);
            this.dateTimePickerLlegada.MinDate = new System.DateTime(2013, 7, 1, 0, 0, 0, 0);
            this.dateTimePickerLlegada.Name = "dateTimePickerLlegada";
            this.dateTimePickerLlegada.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerLlegada.TabIndex = 6;
            this.dateTimePickerLlegada.Value = new System.DateTime(2013, 7, 19, 0, 0, 0, 0);
            // 
            // textBoxFecLleg
            // 
            this.textBoxFecLleg.Location = new System.Drawing.Point(160, 96);
            this.textBoxFecLleg.Name = "textBoxFecLleg";
            this.textBoxFecLleg.ReadOnly = true;
            this.textBoxFecLleg.Size = new System.Drawing.Size(200, 20);
            this.textBoxFecLleg.TabIndex = 7;
            // 
            // textBoxMicro
            // 
            this.textBoxMicro.Location = new System.Drawing.Point(160, 168);
            this.textBoxMicro.Name = "textBoxMicro";
            this.textBoxMicro.ReadOnly = true;
            this.textBoxMicro.Size = new System.Drawing.Size(200, 20);
            this.textBoxMicro.TabIndex = 8;
            // 
            // textBoxReco
            // 
            this.textBoxReco.Location = new System.Drawing.Point(160, 132);
            this.textBoxReco.Name = "textBoxReco";
            this.textBoxReco.ReadOnly = true;
            this.textBoxReco.Size = new System.Drawing.Size(200, 20);
            this.textBoxReco.TabIndex = 9;
            this.textBoxReco.TextChanged += new System.EventHandler(this.textBoxReco_TextChanged);
            // 
            // botonSelMicro
            // 
            this.botonSelMicro.Enabled = false;
            this.botonSelMicro.Location = new System.Drawing.Point(366, 168);
            this.botonSelMicro.Name = "botonSelMicro";
            this.botonSelMicro.Size = new System.Drawing.Size(75, 23);
            this.botonSelMicro.TabIndex = 10;
            this.botonSelMicro.Text = "Seleccionar";
            this.botonSelMicro.UseVisualStyleBackColor = true;
            this.botonSelMicro.Click += new System.EventHandler(this.botonSelMicro_Click);
            // 
            // botonSelReco
            // 
            this.botonSelReco.Location = new System.Drawing.Point(366, 129);
            this.botonSelReco.Name = "botonSelReco";
            this.botonSelReco.Size = new System.Drawing.Size(75, 23);
            this.botonSelReco.TabIndex = 11;
            this.botonSelReco.Text = "Seleccionar";
            this.botonSelReco.UseVisualStyleBackColor = true;
            this.botonSelReco.Click += new System.EventHandler(this.botonSelReco_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(79, 233);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 12;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(266, 233);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(75, 23);
            this.botonGuardar.TabIndex = 13;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // Alta_Viaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 282);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonSelReco);
            this.Controls.Add(this.botonSelMicro);
            this.Controls.Add(this.textBoxReco);
            this.Controls.Add(this.textBoxMicro);
            this.Controls.Add(this.textBoxFecLleg);
            this.Controls.Add(this.dateTimePickerLlegada);
            this.Controls.Add(this.dateTimePickerSalida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Alta_Viaje";
            this.Text = "Alta_Viaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxFecLleg;
        public System.Windows.Forms.TextBox textBoxMicro;
        public System.Windows.Forms.TextBox textBoxReco;
        private System.Windows.Forms.Button botonSelMicro;
        private System.Windows.Forms.Button botonSelReco;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Button botonGuardar;
        public System.Windows.Forms.DateTimePicker dateTimePickerSalida;
        public System.Windows.Forms.DateTimePicker dateTimePickerLlegada;
    }
}