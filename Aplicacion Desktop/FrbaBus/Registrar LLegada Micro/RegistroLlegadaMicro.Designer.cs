namespace FrbaBus.Registrar_LLegada_Micro
{
    partial class llegadaMicros
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
            this.buttonIngresarArribo = new System.Windows.Forms.Button();
            this.buttonVerRegistrosIngresados = new System.Windows.Forms.Button();
            this.buttonProcesarArribos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonIngresarArribo
            // 
            this.buttonIngresarArribo.AutoSize = true;
            this.buttonIngresarArribo.Location = new System.Drawing.Point(23, 12);
            this.buttonIngresarArribo.Name = "buttonIngresarArribo";
            this.buttonIngresarArribo.Size = new System.Drawing.Size(85, 23);
            this.buttonIngresarArribo.TabIndex = 0;
            this.buttonIngresarArribo.Text = "Ingresar Arribo";
            this.buttonIngresarArribo.UseVisualStyleBackColor = true;
            this.buttonIngresarArribo.Click += new System.EventHandler(this.buttonIngresarArribo_Click);
            // 
            // buttonVerRegistrosIngresados
            // 
            this.buttonVerRegistrosIngresados.AutoSize = true;
            this.buttonVerRegistrosIngresados.Location = new System.Drawing.Point(137, 12);
            this.buttonVerRegistrosIngresados.Name = "buttonVerRegistrosIngresados";
            this.buttonVerRegistrosIngresados.Size = new System.Drawing.Size(135, 23);
            this.buttonVerRegistrosIngresados.TabIndex = 1;
            this.buttonVerRegistrosIngresados.Text = "Ver Registros Ingresados";
            this.buttonVerRegistrosIngresados.UseVisualStyleBackColor = true;
            this.buttonVerRegistrosIngresados.Click += new System.EventHandler(this.buttonVerRegistrosIngresados_Click);
            // 
            // buttonProcesarArribos
            // 
            this.buttonProcesarArribos.AutoSize = true;
            this.buttonProcesarArribos.Location = new System.Drawing.Point(302, 12);
            this.buttonProcesarArribos.Name = "buttonProcesarArribos";
            this.buttonProcesarArribos.Size = new System.Drawing.Size(94, 23);
            this.buttonProcesarArribos.TabIndex = 2;
            this.buttonProcesarArribos.Text = "Procesar Arribos";
            this.buttonProcesarArribos.UseVisualStyleBackColor = true;
            this.buttonProcesarArribos.Click += new System.EventHandler(this.buttonProcesarArribos_Click);
            // 
            // llegadaMicros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 52);
            this.Controls.Add(this.buttonProcesarArribos);
            this.Controls.Add(this.buttonVerRegistrosIngresados);
            this.Controls.Add(this.buttonIngresarArribo);
            this.Name = "llegadaMicros";
            this.Text = "Registro de Llegadas de Micros";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.llegadaMicros_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIngresarArribo;
        private System.Windows.Forms.Button buttonVerRegistrosIngresados;
        private System.Windows.Forms.Button buttonProcesarArribos;
    }
}