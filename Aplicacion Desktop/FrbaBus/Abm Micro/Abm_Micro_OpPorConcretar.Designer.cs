namespace FrbaBus.Abm_Micro
{
    partial class Abm_Micro_OpPorConcretar
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
            this.buttonSustituir = new System.Windows.Forms.Button();
            this.labelExplicaSustituir = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelCancelar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "El micro tiene viajes programados. Desea ...";
            // 
            // buttonSustituir
            // 
            this.buttonSustituir.Location = new System.Drawing.Point(21, 85);
            this.buttonSustituir.Name = "buttonSustituir";
            this.buttonSustituir.Size = new System.Drawing.Size(75, 23);
            this.buttonSustituir.TabIndex = 2;
            this.buttonSustituir.Text = "Sustituir";
            this.buttonSustituir.UseVisualStyleBackColor = true;
            this.buttonSustituir.Click += new System.EventHandler(this.buttonSustituir_Click);
            // 
            // labelExplicaSustituir
            // 
            this.labelExplicaSustituir.Location = new System.Drawing.Point(120, 79);
            this.labelExplicaSustituir.Name = "labelExplicaSustituir";
            this.labelExplicaSustituir.Size = new System.Drawing.Size(211, 45);
            this.labelExplicaSustituir.TabIndex = 3;
            this.labelExplicaSustituir.Text = "Sustituye micro que será dado de baja por otro de similares características. En c" +
                "aso de no existir, se agregará nuevo micro.";
            this.labelExplicaSustituir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(21, 158);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 4;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelCancelar
            // 
            this.labelCancelar.Location = new System.Drawing.Point(120, 157);
            this.labelCancelar.Name = "labelCancelar";
            this.labelCancelar.Size = new System.Drawing.Size(211, 31);
            this.labelCancelar.TabIndex = 5;
            this.labelCancelar.Text = "Efectúa la baja del micro y procede a cancelar los viajes que tenía asignados.";
            this.labelCancelar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Abm_Micro_OpPorConcretar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 238);
            this.Controls.Add(this.labelCancelar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.labelExplicaSustituir);
            this.Controls.Add(this.buttonSustituir);
            this.Controls.Add(this.label1);
            this.Name = "Abm_Micro_OpPorConcretar";
            this.Text = "Operación Por Concretar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSustituir;
        private System.Windows.Forms.Label labelExplicaSustituir;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelCancelar;
    }
}