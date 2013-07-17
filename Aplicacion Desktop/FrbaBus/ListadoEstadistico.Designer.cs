namespace FrbaBus
{
    partial class ListadoEstadistico
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
            this.comboBoxSemestre = new System.Windows.Forms.ComboBox();
            this.buttonDestinosMasPasajesComprados = new System.Windows.Forms.Button();
            this.buttonDestinosMicrosMasVacios = new System.Windows.Forms.Button();
            this.buttonClientesConMasPuntosAcumulados = new System.Windows.Forms.Button();
            this.buttonDestinosConPasajesCancelados = new System.Windows.Forms.Button();
            this.buttonMicrosDiasFueraServicio = new System.Windows.Forms.Button();
            this.textBoxAnio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el año: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione el Semestre: ";
            // 
            // comboBoxSemestre
            // 
            this.comboBoxSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSemestre.FormattingEnabled = true;
            this.comboBoxSemestre.Location = new System.Drawing.Point(154, 63);
            this.comboBoxSemestre.Name = "comboBoxSemestre";
            this.comboBoxSemestre.Size = new System.Drawing.Size(55, 21);
            this.comboBoxSemestre.Sorted = true;
            this.comboBoxSemestre.TabIndex = 3;
            // 
            // buttonDestinosMasPasajesComprados
            // 
            this.buttonDestinosMasPasajesComprados.AutoSize = true;
            this.buttonDestinosMasPasajesComprados.Location = new System.Drawing.Point(45, 109);
            this.buttonDestinosMasPasajesComprados.Name = "buttonDestinosMasPasajesComprados";
            this.buttonDestinosMasPasajesComprados.Size = new System.Drawing.Size(195, 23);
            this.buttonDestinosMasPasajesComprados.TabIndex = 4;
            this.buttonDestinosMasPasajesComprados.Text = "Destinos con mas pasajes comprados";
            this.buttonDestinosMasPasajesComprados.UseVisualStyleBackColor = true;
            this.buttonDestinosMasPasajesComprados.Click += new System.EventHandler(this.buttonDestinosMasPasajesComprados_Click);
            // 
            // buttonDestinosMicrosMasVacios
            // 
            this.buttonDestinosMicrosMasVacios.AutoSize = true;
            this.buttonDestinosMicrosMasVacios.Location = new System.Drawing.Point(45, 138);
            this.buttonDestinosMicrosMasVacios.Name = "buttonDestinosMicrosMasVacios";
            this.buttonDestinosMicrosMasVacios.Size = new System.Drawing.Size(195, 23);
            this.buttonDestinosMicrosMasVacios.TabIndex = 5;
            this.buttonDestinosMicrosMasVacios.Text = "Destinos con Micros más Vacíos";
            this.buttonDestinosMicrosMasVacios.UseVisualStyleBackColor = true;
            this.buttonDestinosMicrosMasVacios.Click += new System.EventHandler(this.buttonDestinosMicrosMasVacios_Click);
            // 
            // buttonClientesConMasPuntosAcumulados
            // 
            this.buttonClientesConMasPuntosAcumulados.AutoSize = true;
            this.buttonClientesConMasPuntosAcumulados.Location = new System.Drawing.Point(45, 167);
            this.buttonClientesConMasPuntosAcumulados.Name = "buttonClientesConMasPuntosAcumulados";
            this.buttonClientesConMasPuntosAcumulados.Size = new System.Drawing.Size(195, 23);
            this.buttonClientesConMasPuntosAcumulados.TabIndex = 6;
            this.buttonClientesConMasPuntosAcumulados.Text = "Clientes con más puntos acumulados";
            this.buttonClientesConMasPuntosAcumulados.UseVisualStyleBackColor = true;
            this.buttonClientesConMasPuntosAcumulados.Click += new System.EventHandler(this.buttonClientesConMasPuntosAcumulados_Click);
            // 
            // buttonDestinosConPasajesCancelados
            // 
            this.buttonDestinosConPasajesCancelados.AutoSize = true;
            this.buttonDestinosConPasajesCancelados.Location = new System.Drawing.Point(45, 196);
            this.buttonDestinosConPasajesCancelados.Name = "buttonDestinosConPasajesCancelados";
            this.buttonDestinosConPasajesCancelados.Size = new System.Drawing.Size(198, 23);
            this.buttonDestinosConPasajesCancelados.TabIndex = 7;
            this.buttonDestinosConPasajesCancelados.Text = "Destinos con mas pasajes cancelados";
            this.buttonDestinosConPasajesCancelados.UseVisualStyleBackColor = true;
            this.buttonDestinosConPasajesCancelados.Click += new System.EventHandler(this.buttonDestinosConPasajesCancelados_Click);
            // 
            // buttonMicrosDiasFueraServicio
            // 
            this.buttonMicrosDiasFueraServicio.AutoSize = true;
            this.buttonMicrosDiasFueraServicio.Location = new System.Drawing.Point(45, 227);
            this.buttonMicrosDiasFueraServicio.Name = "buttonMicrosDiasFueraServicio";
            this.buttonMicrosDiasFueraServicio.Size = new System.Drawing.Size(195, 23);
            this.buttonMicrosDiasFueraServicio.TabIndex = 8;
            this.buttonMicrosDiasFueraServicio.Text = "Micros con mas dias fuera de servicio";
            this.buttonMicrosDiasFueraServicio.UseVisualStyleBackColor = true;
            this.buttonMicrosDiasFueraServicio.Click += new System.EventHandler(this.buttonMicrosDiasFueraServicio_Click);
            // 
            // textBoxAnio
            // 
            this.textBoxAnio.Location = new System.Drawing.Point(128, 27);
            this.textBoxAnio.MaxLength = 4;
            this.textBoxAnio.Name = "textBoxAnio";
            this.textBoxAnio.Size = new System.Drawing.Size(100, 20);
            this.textBoxAnio.TabIndex = 9;
            // 
            // ListadoEstadistico
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(284, 263);
            this.Controls.Add(this.textBoxAnio);
            this.Controls.Add(this.buttonMicrosDiasFueraServicio);
            this.Controls.Add(this.buttonDestinosConPasajesCancelados);
            this.Controls.Add(this.buttonClientesConMasPuntosAcumulados);
            this.Controls.Add(this.buttonDestinosMicrosMasVacios);
            this.Controls.Add(this.buttonDestinosMasPasajesComprados);
            this.Controls.Add(this.comboBoxSemestre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ListadoEstadistico";
            this.Text = "Listados Estadísticos TOP 5";
            this.Load += new System.EventHandler(this.ListadoEstadistico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSemestre;
        private System.Windows.Forms.Button buttonDestinosMasPasajesComprados;
        private System.Windows.Forms.Button buttonDestinosMicrosMasVacios;
        private System.Windows.Forms.Button buttonClientesConMasPuntosAcumulados;
        private System.Windows.Forms.Button buttonDestinosConPasajesCancelados;
        private System.Windows.Forms.Button buttonMicrosDiasFueraServicio;
        private System.Windows.Forms.TextBox textBoxAnio;
    }
}