namespace FrbaBus.Registrar_LLegada_Micro
{
    partial class FormularioDeArribo
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
            this.textBoxPatente = new System.Windows.Forms.TextBox();
            this.comboBoxOrigen = new System.Windows.Forms.ComboBox();
            this.comboBoxArribo = new System.Windows.Forms.ComboBox();
            this.labelfecha = new System.Windows.Forms.Label();
            this.labelpatente = new System.Windows.Forms.Label();
            this.labelorigen = new System.Windows.Forms.Label();
            this.labelarribo = new System.Windows.Forms.Label();
            this.labelhora = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.ComboBox();
            this.minutos = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBoxPatente
            // 
            this.textBoxPatente.Location = new System.Drawing.Point(317, 47);
            this.textBoxPatente.MaxLength = 6;
            this.textBoxPatente.Name = "textBoxPatente";
            this.textBoxPatente.Size = new System.Drawing.Size(78, 20);
            this.textBoxPatente.TabIndex = 1;
            this.textBoxPatente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPatente_KeyPress);
            // 
            // comboBoxOrigen
            // 
            this.comboBoxOrigen.FormattingEnabled = true;
            this.comboBoxOrigen.Location = new System.Drawing.Point(410, 46);
            this.comboBoxOrigen.Name = "comboBoxOrigen";
            this.comboBoxOrigen.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOrigen.TabIndex = 2;
            // 
            // comboBoxArribo
            // 
            this.comboBoxArribo.FormattingEnabled = true;
            this.comboBoxArribo.Location = new System.Drawing.Point(554, 46);
            this.comboBoxArribo.Name = "comboBoxArribo";
            this.comboBoxArribo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxArribo.TabIndex = 3;
            // 
            // labelfecha
            // 
            this.labelfecha.AutoSize = true;
            this.labelfecha.Location = new System.Drawing.Point(13, 30);
            this.labelfecha.Name = "labelfecha";
            this.labelfecha.Size = new System.Drawing.Size(156, 13);
            this.labelfecha.TabIndex = 4;
            this.labelfecha.Text = "Fecha de llegada (aaaa-mm-dd)";
            // 
            // labelpatente
            // 
            this.labelpatente.AutoSize = true;
            this.labelpatente.Location = new System.Drawing.Point(332, 31);
            this.labelpatente.Name = "labelpatente";
            this.labelpatente.Size = new System.Drawing.Size(44, 13);
            this.labelpatente.TabIndex = 5;
            this.labelpatente.Text = "Patente";
            // 
            // labelorigen
            // 
            this.labelorigen.AutoSize = true;
            this.labelorigen.Location = new System.Drawing.Point(429, 31);
            this.labelorigen.Name = "labelorigen";
            this.labelorigen.Size = new System.Drawing.Size(89, 13);
            this.labelorigen.TabIndex = 6;
            this.labelorigen.Text = "Ciudad de Origen";
            // 
            // labelarribo
            // 
            this.labelarribo.AutoSize = true;
            this.labelarribo.Location = new System.Drawing.Point(569, 30);
            this.labelarribo.Name = "labelarribo";
            this.labelarribo.Size = new System.Drawing.Size(82, 13);
            this.labelarribo.TabIndex = 7;
            this.labelarribo.Text = "Ciudad Arribada";
            // 
            // labelhora
            // 
            this.labelhora.AutoSize = true;
            this.labelhora.Location = new System.Drawing.Point(192, 30);
            this.labelhora.Name = "labelhora";
            this.labelhora.Size = new System.Drawing.Size(115, 13);
            this.labelhora.TabIndex = 10;
            this.labelhora.Text = "Hora        :       Minutos";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(582, 74);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 11;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(448, 73);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 12;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = ":";
            // 
            // hora
            // 
            this.hora.FormattingEnabled = true;
            this.hora.Location = new System.Drawing.Point(191, 47);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(42, 21);
            this.hora.TabIndex = 16;
            // 
            // minutos
            // 
            this.minutos.FormattingEnabled = true;
            this.minutos.Location = new System.Drawing.Point(265, 47);
            this.minutos.Name = "minutos";
            this.minutos.Size = new System.Drawing.Size(42, 21);
            this.minutos.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(166, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // FormularioDeArribo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 107);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.minutos);
            this.Controls.Add(this.hora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.labelhora);
            this.Controls.Add(this.labelarribo);
            this.Controls.Add(this.labelorigen);
            this.Controls.Add(this.labelpatente);
            this.Controls.Add(this.labelfecha);
            this.Controls.Add(this.comboBoxArribo);
            this.Controls.Add(this.comboBoxOrigen);
            this.Controls.Add(this.textBoxPatente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormularioDeArribo";
            this.Text = "Formulario De Arribo";
            this.Load += new System.EventHandler(this.FormularioDeArribo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPatente;
        private System.Windows.Forms.ComboBox comboBoxOrigen;
        private System.Windows.Forms.ComboBox comboBoxArribo;
        private System.Windows.Forms.Label labelfecha;
        private System.Windows.Forms.Label labelpatente;
        private System.Windows.Forms.Label labelorigen;
        private System.Windows.Forms.Label labelarribo;
        private System.Windows.Forms.Label labelhora;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox hora;
        private System.Windows.Forms.ComboBox minutos;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}