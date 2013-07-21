namespace FrbaBus.Abm_Recorrido
{
    partial class Abm_Reco_Alta
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
            this.textBoxCodReco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxCiuOrigen = new System.Windows.Forms.ComboBox();
            this.comboBoxCiuDestino = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoServ = new System.Windows.Forms.ComboBox();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.botonRefrescar = new System.Windows.Forms.Button();
            this.numUpDownPrPas = new System.Windows.Forms.NumericUpDown();
            this.numUpDownPrEnco = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.botonRehab = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPrPas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPrEnco)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCodReco
            // 
            this.textBoxCodReco.Location = new System.Drawing.Point(168, 16);
            this.textBoxCodReco.Name = "textBoxCodReco";
            this.textBoxCodReco.Size = new System.Drawing.Size(154, 20);
            this.textBoxCodReco.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el código de recorrido:*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione ciudad de Origen:*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seleccione ciudad de Destino:*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Seleccione tipo de servicio:*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ingrese precio base del pasaje:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ingrese precio base por KG:";
            // 
            // comboBoxCiuOrigen
            // 
            this.comboBoxCiuOrigen.Location = new System.Drawing.Point(168, 59);
            this.comboBoxCiuOrigen.Name = "comboBoxCiuOrigen";
            this.comboBoxCiuOrigen.Size = new System.Drawing.Size(154, 21);
            this.comboBoxCiuOrigen.TabIndex = 7;
            // 
            // comboBoxCiuDestino
            // 
            this.comboBoxCiuDestino.FormattingEnabled = true;
            this.comboBoxCiuDestino.Location = new System.Drawing.Point(168, 92);
            this.comboBoxCiuDestino.Name = "comboBoxCiuDestino";
            this.comboBoxCiuDestino.Size = new System.Drawing.Size(154, 21);
            this.comboBoxCiuDestino.TabIndex = 8;
            // 
            // comboBoxTipoServ
            // 
            this.comboBoxTipoServ.FormattingEnabled = true;
            this.comboBoxTipoServ.Location = new System.Drawing.Point(168, 126);
            this.comboBoxTipoServ.Name = "comboBoxTipoServ";
            this.comboBoxTipoServ.Size = new System.Drawing.Size(154, 21);
            this.comboBoxTipoServ.TabIndex = 9;
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(149, 270);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(107, 41);
            this.botonAceptar.TabIndex = 13;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // botonRefrescar
            // 
            this.botonRefrescar.Location = new System.Drawing.Point(15, 270);
            this.botonRefrescar.Name = "botonRefrescar";
            this.botonRefrescar.Size = new System.Drawing.Size(106, 41);
            this.botonRefrescar.TabIndex = 14;
            this.botonRefrescar.Text = "Refrescar";
            this.botonRefrescar.UseVisualStyleBackColor = true;
            this.botonRefrescar.Click += new System.EventHandler(this.botonRefrescar_Click);
            // 
            // numUpDownPrPas
            // 
            this.numUpDownPrPas.DecimalPlaces = 2;
            this.numUpDownPrPas.Location = new System.Drawing.Point(168, 165);
            this.numUpDownPrPas.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            131072});
            this.numUpDownPrPas.Name = "numUpDownPrPas";
            this.numUpDownPrPas.Size = new System.Drawing.Size(154, 20);
            this.numUpDownPrPas.TabIndex = 15;
            // 
            // numUpDownPrEnco
            // 
            this.numUpDownPrEnco.DecimalPlaces = 2;
            this.numUpDownPrEnco.Location = new System.Drawing.Point(168, 199);
            this.numUpDownPrEnco.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUpDownPrEnco.Name = "numUpDownPrEnco";
            this.numUpDownPrEnco.Size = new System.Drawing.Size(154, 20);
            this.numUpDownPrEnco.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Los campos con un \" * \" son obligatorios";
            // 
            // botonRehab
            // 
            this.botonRehab.Location = new System.Drawing.Point(149, 374);
            this.botonRehab.Name = "botonRehab";
            this.botonRehab.Size = new System.Drawing.Size(107, 41);
            this.botonRehab.TabIndex = 18;
            this.botonRehab.Text = "Habilitar Recorrido Existente";
            this.botonRehab.UseVisualStyleBackColor = true;
            this.botonRehab.Click += new System.EventHandler(this.botonRehab_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(365, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Para volver a habilitar un recorrido que fue dado de baja clickee este boton:";
            // 
            // Abm_Reco_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 442);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.botonRehab);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numUpDownPrEnco);
            this.Controls.Add(this.numUpDownPrPas);
            this.Controls.Add(this.botonRefrescar);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.comboBoxTipoServ);
            this.Controls.Add(this.comboBoxCiuDestino);
            this.Controls.Add(this.comboBoxCiuOrigen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCodReco);
            this.Name = "Abm_Reco_Alta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Recorrido";
            this.Load += new System.EventHandler(this.Abm_Reco_Alta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPrPas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPrEnco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCodReco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxCiuOrigen;
        private System.Windows.Forms.ComboBox comboBoxCiuDestino;
        private System.Windows.Forms.ComboBox comboBoxTipoServ;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Button botonRefrescar;
        private System.Windows.Forms.NumericUpDown numUpDownPrPas;
        private System.Windows.Forms.NumericUpDown numUpDownPrEnco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button botonRehab;
        private System.Windows.Forms.Label label8;
    }
}