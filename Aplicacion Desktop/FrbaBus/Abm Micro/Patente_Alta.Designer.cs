namespace FrbaBus.Abm_Micro
{
    partial class Patente_Alta
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
            this.labelPatenteNueva = new System.Windows.Forms.Label();
            this.labelExplicaSustituir = new System.Windows.Forms.Label();
            this.textBoxPatente = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPatenteNueva
            // 
            this.labelPatenteNueva.AutoSize = true;
            this.labelPatenteNueva.Location = new System.Drawing.Point(13, 58);
            this.labelPatenteNueva.Name = "labelPatenteNueva";
            this.labelPatenteNueva.Size = new System.Drawing.Size(82, 13);
            this.labelPatenteNueva.TabIndex = 0;
            this.labelPatenteNueva.Text = "Patente Nueva:";
            // 
            // labelExplicaSustituir
            // 
            this.labelExplicaSustituir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelExplicaSustituir.Location = new System.Drawing.Point(18, 15);
            this.labelExplicaSustituir.Name = "labelExplicaSustituir";
            this.labelExplicaSustituir.Size = new System.Drawing.Size(237, 39);
            this.labelExplicaSustituir.TabIndex = 4;
            this.labelExplicaSustituir.Text = "El siguiente micro a ingresar presenta las mismas características que el que se d" +
                "ará de baja.";
            this.labelExplicaSustituir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxPatente
            // 
            this.textBoxPatente.Location = new System.Drawing.Point(119, 56);
            this.textBoxPatente.MaxLength = 6;
            this.textBoxPatente.Name = "textBoxPatente";
            this.textBoxPatente.Size = new System.Drawing.Size(136, 20);
            this.textBoxPatente.TabIndex = 5;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(96, 105);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 6;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // Patente_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 148);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxPatente);
            this.Controls.Add(this.labelExplicaSustituir);
            this.Controls.Add(this.labelPatenteNueva);
            this.Name = "Patente_Alta";
            this.Text = "Alta de Micro Nuevo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPatenteNueva;
        private System.Windows.Forms.Label labelExplicaSustituir;
        private System.Windows.Forms.TextBox textBoxPatente;
        private System.Windows.Forms.Button buttonAceptar;
    }
}