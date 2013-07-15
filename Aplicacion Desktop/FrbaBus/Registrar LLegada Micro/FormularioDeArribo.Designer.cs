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
            this.textBoxFechallegada = new System.Windows.Forms.TextBox();
            this.textBoxHorallegada = new System.Windows.Forms.TextBox();
            this.labelhora = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPatente
            // 
            this.textBoxPatente.Location = new System.Drawing.Point(317, 47);
            this.textBoxPatente.Name = "textBoxPatente";
            this.textBoxPatente.Size = new System.Drawing.Size(78, 20);
            this.textBoxPatente.TabIndex = 1;
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
            // textBoxFechallegada
            // 
            this.textBoxFechallegada.Location = new System.Drawing.Point(14, 46);
            this.textBoxFechallegada.Name = "textBoxFechallegada";
            this.textBoxFechallegada.Size = new System.Drawing.Size(154, 20);
            this.textBoxFechallegada.TabIndex = 8;
            // 
            // textBoxHorallegada
            // 
            this.textBoxHorallegada.Location = new System.Drawing.Point(178, 46);
            this.textBoxHorallegada.Name = "textBoxHorallegada";
            this.textBoxHorallegada.Size = new System.Drawing.Size(127, 20);
            this.textBoxHorallegada.TabIndex = 9;
            // 
            // labelhora
            // 
            this.labelhora.AutoSize = true;
            this.labelhora.Location = new System.Drawing.Point(180, 30);
            this.labelhora.Name = "labelhora";
            this.labelhora.Size = new System.Drawing.Size(126, 13);
            this.labelhora.TabIndex = 10;
            this.labelhora.Text = "Hora de Llegada (hh:mm)";
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
            // FormularioDeArribo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 107);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.labelhora);
            this.Controls.Add(this.textBoxHorallegada);
            this.Controls.Add(this.textBoxFechallegada);
            this.Controls.Add(this.labelarribo);
            this.Controls.Add(this.labelorigen);
            this.Controls.Add(this.labelpatente);
            this.Controls.Add(this.labelfecha);
            this.Controls.Add(this.comboBoxArribo);
            this.Controls.Add(this.comboBoxOrigen);
            this.Controls.Add(this.textBoxPatente);
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
        private System.Windows.Forms.TextBox textBoxFechallegada;
        private System.Windows.Forms.TextBox textBoxHorallegada;
        private System.Windows.Forms.Label labelhora;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonLimpiar;
    }
}