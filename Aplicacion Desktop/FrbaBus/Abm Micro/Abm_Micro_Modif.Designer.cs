namespace FrbaBus.Abm_Micro
{
    partial class Abm_Micro_Modif
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
            this.labelPatente = new System.Windows.Forms.Label();
            this.labelFechaReingreso = new System.Windows.Forms.Label();
            this.textBoxPatente = new System.Windows.Forms.TextBox();
            this.dateTimePickerFechaReingreso = new System.Windows.Forms.DateTimePicker();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.labelEnunciado = new System.Windows.Forms.Label();
            this.labelFechaBajaTemporaria = new System.Windows.Forms.Label();
            this.dateTimePickerFechaBajaTemporaria = new System.Windows.Forms.DateTimePicker();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPatente
            // 
            this.labelPatente.AutoSize = true;
            this.labelPatente.Location = new System.Drawing.Point(12, 53);
            this.labelPatente.Name = "labelPatente";
            this.labelPatente.Size = new System.Drawing.Size(47, 13);
            this.labelPatente.TabIndex = 0;
            this.labelPatente.Text = "Patente:";
            // 
            // labelFechaReingreso
            // 
            this.labelFechaReingreso.AutoSize = true;
            this.labelFechaReingreso.Location = new System.Drawing.Point(11, 110);
            this.labelFechaReingreso.Name = "labelFechaReingreso";
            this.labelFechaReingreso.Size = new System.Drawing.Size(106, 13);
            this.labelFechaReingreso.TabIndex = 1;
            this.labelFechaReingreso.Text = "Fecha de Reingreso:";
            // 
            // textBoxPatente
            // 
            this.textBoxPatente.Location = new System.Drawing.Point(147, 50);
            this.textBoxPatente.MaxLength = 6;
            this.textBoxPatente.Name = "textBoxPatente";
            this.textBoxPatente.Size = new System.Drawing.Size(136, 20);
            this.textBoxPatente.TabIndex = 2;
            // 
            // dateTimePickerFechaReingreso
            // 
            this.dateTimePickerFechaReingreso.Location = new System.Drawing.Point(147, 110);
            this.dateTimePickerFechaReingreso.Name = "dateTimePickerFechaReingreso";
            this.dateTimePickerFechaReingreso.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaReingreso.TabIndex = 3;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(81, 156);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 4;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // labelEnunciado
            // 
            this.labelEnunciado.AutoSize = true;
            this.labelEnunciado.Location = new System.Drawing.Point(12, 22);
            this.labelEnunciado.Name = "labelEnunciado";
            this.labelEnunciado.Size = new System.Drawing.Size(282, 13);
            this.labelEnunciado.TabIndex = 5;
            this.labelEnunciado.Text = "Ingrese datos del micro que estará FUERA DE SERVICIO:";
            // 
            // labelFechaBajaTemporaria
            // 
            this.labelFechaBajaTemporaria.AutoSize = true;
            this.labelFechaBajaTemporaria.Location = new System.Drawing.Point(11, 82);
            this.labelFechaBajaTemporaria.Name = "labelFechaBajaTemporaria";
            this.labelFechaBajaTemporaria.Size = new System.Drawing.Size(135, 13);
            this.labelFechaBajaTemporaria.TabIndex = 6;
            this.labelFechaBajaTemporaria.Text = "Fecha de Baja Temporaria:";
            // 
            // dateTimePickerFechaBajaTemporaria
            // 
            this.dateTimePickerFechaBajaTemporaria.Location = new System.Drawing.Point(147, 80);
            this.dateTimePickerFechaBajaTemporaria.Name = "dateTimePickerFechaBajaTemporaria";
            this.dateTimePickerFechaBajaTemporaria.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaBajaTemporaria.TabIndex = 7;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(201, 156);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // Abm_Micro_Modif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 191);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.dateTimePickerFechaBajaTemporaria);
            this.Controls.Add(this.labelFechaBajaTemporaria);
            this.Controls.Add(this.labelEnunciado);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.dateTimePickerFechaReingreso);
            this.Controls.Add(this.textBoxPatente);
            this.Controls.Add(this.labelFechaReingreso);
            this.Controls.Add(this.labelPatente);
            this.Name = "Abm_Micro_Modif";
            this.Text = "Modificación de Micro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPatente;
        private System.Windows.Forms.Label labelFechaReingreso;
        private System.Windows.Forms.TextBox textBoxPatente;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaReingreso;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label labelEnunciado;
        private System.Windows.Forms.Label labelFechaBajaTemporaria;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaBajaTemporaria;
        private System.Windows.Forms.Button buttonCancelar;
    }
}