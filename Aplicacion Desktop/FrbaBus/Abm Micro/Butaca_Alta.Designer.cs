namespace FrbaBus.Abm_Micro
{
    partial class FormButacaAlta
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
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.dataGridViewButacas = new System.Windows.Forms.DataGridView();
            this.ButacaNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButacaTipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ButacaPiso = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewButacas)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(179, 270);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 0;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // dataGridViewButacas
            // 
            this.dataGridViewButacas.AllowUserToAddRows = false;
            this.dataGridViewButacas.AllowUserToDeleteRows = false;
            this.dataGridViewButacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewButacas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ButacaNro,
            this.ButacaTipo,
            this.ButacaPiso});
            this.dataGridViewButacas.Location = new System.Drawing.Point(23, 30);
            this.dataGridViewButacas.Name = "dataGridViewButacas";
            this.dataGridViewButacas.Size = new System.Drawing.Size(388, 227);
            this.dataGridViewButacas.TabIndex = 1;
            // 
            // ButacaNro
            // 
            this.ButacaNro.Frozen = true;
            this.ButacaNro.HeaderText = "Nro Butaca";
            this.ButacaNro.Name = "ButacaNro";
            this.ButacaNro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ButacaTipo
            // 
            this.ButacaTipo.Frozen = true;
            this.ButacaTipo.HeaderText = "Tipo Butaca";
            this.ButacaTipo.Name = "ButacaTipo";
            // 
            // ButacaPiso
            // 
            this.ButacaPiso.Frozen = true;
            this.ButacaPiso.HeaderText = "Piso Butaca";
            this.ButacaPiso.Name = "ButacaPiso";
            // 
            // FormButacaAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 305);
            this.Controls.Add(this.dataGridViewButacas);
            this.Controls.Add(this.buttonAceptar);
            this.Name = "FormButacaAlta";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormButacaAlta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewButacas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.DataGridView dataGridViewButacas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ButacaNro;
        private System.Windows.Forms.DataGridViewComboBoxColumn ButacaTipo;
        private System.Windows.Forms.DataGridViewComboBoxColumn ButacaPiso;
    }
}