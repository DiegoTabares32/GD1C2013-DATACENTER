namespace FrbaBus.Abm_Micro
{
    partial class Abm_Micro_Alta
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
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.labelPatente = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelEnunciado = new System.Windows.Forms.Label();
            this.labelServicio = new System.Windows.Forms.Label();
            this.labelButacas = new System.Windows.Forms.Label();
            this.labelKGDisp = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.textBoxCButacas = new System.Windows.Forms.TextBox();
            this.textBoxCKGDisp = new System.Windows.Forms.TextBox();
            this.comboBoxServicio = new System.Windows.Forms.ComboBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.labelFechaAlta = new System.Windows.Forms.Label();
            this.dateTimePickerFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPatente
            // 
            this.textBoxPatente.Location = new System.Drawing.Point(101, 53);
            this.textBoxPatente.MaxLength = 6;
            this.textBoxPatente.Name = "textBoxPatente";
            this.textBoxPatente.Size = new System.Drawing.Size(136, 20);
            this.textBoxPatente.TabIndex = 0;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(179, 283);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 1;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // labelPatente
            // 
            this.labelPatente.AutoSize = true;
            this.labelPatente.Location = new System.Drawing.Point(31, 57);
            this.labelPatente.Name = "labelPatente";
            this.labelPatente.Size = new System.Drawing.Size(50, 13);
            this.labelPatente.TabIndex = 2;
            this.labelPatente.Text = "Patente: ";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(31, 87);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(40, 13);
            this.labelMarca.TabIndex = 3;
            this.labelMarca.Text = "Marca:";
            // 
            // labelEnunciado
            // 
            this.labelEnunciado.AutoSize = true;
            this.labelEnunciado.Location = new System.Drawing.Point(30, 20);
            this.labelEnunciado.Name = "labelEnunciado";
            this.labelEnunciado.Size = new System.Drawing.Size(140, 13);
            this.labelEnunciado.TabIndex = 4;
            this.labelEnunciado.Text = "Ingrese los siguientes datos:";
            // 
            // labelServicio
            // 
            this.labelServicio.AutoSize = true;
            this.labelServicio.Location = new System.Drawing.Point(30, 150);
            this.labelServicio.Name = "labelServicio";
            this.labelServicio.Size = new System.Drawing.Size(48, 13);
            this.labelServicio.TabIndex = 6;
            this.labelServicio.Text = "Servicio:";
            // 
            // labelButacas
            // 
            this.labelButacas.AutoSize = true;
            this.labelButacas.Location = new System.Drawing.Point(30, 182);
            this.labelButacas.Name = "labelButacas";
            this.labelButacas.Size = new System.Drawing.Size(91, 13);
            this.labelButacas.TabIndex = 7;
            this.labelButacas.Text = "Cant. de butacas:";
            // 
            // labelKGDisp
            // 
            this.labelKGDisp.AutoSize = true;
            this.labelKGDisp.Location = new System.Drawing.Point(30, 211);
            this.labelKGDisp.Name = "labelKGDisp";
            this.labelKGDisp.Size = new System.Drawing.Size(93, 13);
            this.labelKGDisp.TabIndex = 8;
            this.labelKGDisp.Text = "Cant. de KG disp.:";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(31, 117);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(42, 13);
            this.labelModelo.TabIndex = 9;
            this.labelModelo.Text = "Modelo";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(102, 114);
            this.textBoxModelo.MaxLength = 255;
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(136, 20);
            this.textBoxModelo.TabIndex = 10;
            this.textBoxModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMarca_KeyPress);
            // 
            // textBoxCButacas
            // 
            this.textBoxCButacas.Location = new System.Drawing.Point(129, 180);
            this.textBoxCButacas.Name = "textBoxCButacas";
            this.textBoxCButacas.Size = new System.Drawing.Size(108, 20);
            this.textBoxCButacas.TabIndex = 12;
            this.textBoxCButacas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // textBoxCKGDisp
            // 
            this.textBoxCKGDisp.Location = new System.Drawing.Point(129, 208);
            this.textBoxCKGDisp.Name = "textBoxCKGDisp";
            this.textBoxCKGDisp.Size = new System.Drawing.Size(108, 20);
            this.textBoxCKGDisp.TabIndex = 13;
            this.textBoxCKGDisp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // comboBoxServicio
            // 
            this.comboBoxServicio.FormattingEnabled = true;
            this.comboBoxServicio.Location = new System.Drawing.Point(101, 144);
            this.comboBoxServicio.Name = "comboBoxServicio";
            this.comboBoxServicio.Size = new System.Drawing.Size(137, 21);
            this.comboBoxServicio.TabIndex = 14;
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(101, 84);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(137, 21);
            this.comboBoxMarca.TabIndex = 15;
            // 
            // labelFechaAlta
            // 
            this.labelFechaAlta.AutoSize = true;
            this.labelFechaAlta.Location = new System.Drawing.Point(30, 240);
            this.labelFechaAlta.Name = "labelFechaAlta";
            this.labelFechaAlta.Size = new System.Drawing.Size(76, 13);
            this.labelFechaAlta.TabIndex = 16;
            this.labelFechaAlta.Text = "Fecha de Alta:";
            // 
            // dateTimePickerFechaAlta
            // 
            this.dateTimePickerFechaAlta.Location = new System.Drawing.Point(112, 239);
            this.dateTimePickerFechaAlta.Name = "dateTimePickerFechaAlta";
            this.dateTimePickerFechaAlta.Size = new System.Drawing.Size(194, 20);
            this.dateTimePickerFechaAlta.TabIndex = 17;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(65, 283);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 18;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // Abm_Micro_Alta
            // 
            this.AcceptButton = this.buttonAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 319);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.dateTimePickerFechaAlta);
            this.Controls.Add(this.labelFechaAlta);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.comboBoxServicio);
            this.Controls.Add(this.textBoxCKGDisp);
            this.Controls.Add(this.textBoxCButacas);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.labelKGDisp);
            this.Controls.Add(this.labelButacas);
            this.Controls.Add(this.labelServicio);
            this.Controls.Add(this.labelEnunciado);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.labelPatente);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxPatente);
            this.Name = "Abm_Micro_Alta";
            this.Text = "Alta de Micro";
            this.Load += new System.EventHandler(this.Abm_Micro_Alta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPatente;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label labelPatente;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelEnunciado;
        private System.Windows.Forms.Label labelServicio;
        private System.Windows.Forms.Label labelButacas;
        private System.Windows.Forms.Label labelKGDisp;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.TextBox textBoxCButacas;
        private System.Windows.Forms.TextBox textBoxCKGDisp;
        private System.Windows.Forms.ComboBox comboBoxServicio;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.Label labelFechaAlta;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaAlta;
        private System.Windows.Forms.Button buttonCancelar;
    }
}