namespace FrbaBus.Compra_de_Pasajes
{
    partial class select_fecha_viaje
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
            this.calendario_viajes = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmar_boton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calendario_viajes
            // 
            this.calendario_viajes.Location = new System.Drawing.Point(51, 45);
            this.calendario_viajes.Name = "calendario_viajes";
            this.calendario_viajes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione Fecha de Viaje:";
            // 
            // confirmar_boton
            // 
            this.confirmar_boton.Location = new System.Drawing.Point(73, 230);
            this.confirmar_boton.Name = "confirmar_boton";
            this.confirmar_boton.Size = new System.Drawing.Size(168, 35);
            this.confirmar_boton.TabIndex = 2;
            this.confirmar_boton.Text = "Confirmar Fecha";
            this.confirmar_boton.UseVisualStyleBackColor = true;
            this.confirmar_boton.Click += new System.EventHandler(this.confirmar_boton_Click);
            // 
            // select_fecha_viaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 291);
            this.Controls.Add(this.confirmar_boton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calendario_viajes);
            this.Name = "select_fecha_viaje";
            this.Text = "select_fecha_viaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendario_viajes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmar_boton;
    }
}