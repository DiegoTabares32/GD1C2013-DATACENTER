namespace FrbaBus.Abm_Micro
{
    partial class Abm_Micro_Baja
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.dateTimePickerFechaBajaDefinitiva = new System.Windows.Forms.DateTimePicker();
            this.labelFechaBajaDefinitiva = new System.Windows.Forms.Label();
            this.labelEnunciado = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.textBoxPatente = new System.Windows.Forms.TextBox();
            this.labelPatente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(193, 161);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 17;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // dateTimePickerFechaBajaDefinitiva
            // 
            this.dateTimePickerFechaBajaDefinitiva.Location = new System.Drawing.Point(130, 101);
            this.dateTimePickerFechaBajaDefinitiva.Name = "dateTimePickerFechaBajaDefinitiva";
            this.dateTimePickerFechaBajaDefinitiva.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaBajaDefinitiva.TabIndex = 16;
            // 
            // labelFechaBajaDefinitiva
            // 
            this.labelFechaBajaDefinitiva.AutoSize = true;
            this.labelFechaBajaDefinitiva.Location = new System.Drawing.Point(24, 103);
            this.labelFechaBajaDefinitiva.Name = "labelFechaBajaDefinitiva";
            this.labelFechaBajaDefinitiva.Size = new System.Drawing.Size(79, 13);
            this.labelFechaBajaDefinitiva.TabIndex = 15;
            this.labelFechaBajaDefinitiva.Text = "Fecha de Baja:";
            // 
            // labelEnunciado
            // 
            this.labelEnunciado.AutoSize = true;
            this.labelEnunciado.Location = new System.Drawing.Point(25, 27);
            this.labelEnunciado.Name = "labelEnunciado";
            this.labelEnunciado.Size = new System.Drawing.Size(283, 13);
            this.labelEnunciado.TabIndex = 14;
            this.labelEnunciado.Text = "Ingrese datos del micro que sufrirá una BAJA DEFINITIVA:";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(73, 161);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 13;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // textBoxPatente
            // 
            this.textBoxPatente.Location = new System.Drawing.Point(130, 71);
            this.textBoxPatente.MaxLength = 6;
            this.textBoxPatente.Name = "textBoxPatente";
            this.textBoxPatente.Size = new System.Drawing.Size(136, 20);
            this.textBoxPatente.TabIndex = 11;
            // 
            // labelPatente
            // 
            this.labelPatente.AutoSize = true;
            this.labelPatente.Location = new System.Drawing.Point(25, 74);
            this.labelPatente.Name = "labelPatente";
            this.labelPatente.Size = new System.Drawing.Size(47, 13);
            this.labelPatente.TabIndex = 9;
            this.labelPatente.Text = "Patente:";
            // 
            // Abm_Micro_Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 206);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.dateTimePickerFechaBajaDefinitiva);
            this.Controls.Add(this.labelFechaBajaDefinitiva);
            this.Controls.Add(this.labelEnunciado);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxPatente);
            this.Controls.Add(this.labelPatente);
            this.Name = "Abm_Micro_Baja";
            this.Text = "Baja de Micro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaBajaDefinitiva;
        private System.Windows.Forms.Label labelFechaBajaDefinitiva;
        private System.Windows.Forms.Label labelEnunciado;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.TextBox textBoxPatente;
        private System.Windows.Forms.Label labelPatente;
    }
}