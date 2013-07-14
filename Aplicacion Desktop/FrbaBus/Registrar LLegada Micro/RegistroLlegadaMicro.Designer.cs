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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonIngresarArribo = new System.Windows.Forms.Button();
            this.dataGridViewRegistrosCargados = new System.Windows.Forms.DataGridView();
            this.labelRegistrosCargados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistrosCargados)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonIngresarArribo
            // 
            this.buttonIngresarArribo.AutoSize = true;
            this.buttonIngresarArribo.Location = new System.Drawing.Point(112, 28);
            this.buttonIngresarArribo.Name = "buttonIngresarArribo";
            this.buttonIngresarArribo.Size = new System.Drawing.Size(85, 23);
            this.buttonIngresarArribo.TabIndex = 0;
            this.buttonIngresarArribo.Text = "Ingresar Arribo";
            this.buttonIngresarArribo.UseVisualStyleBackColor = true;
            this.buttonIngresarArribo.Click += new System.EventHandler(this.buttonIngresarArribo_Click);
            // 
            // dataGridViewRegistrosCargados
            // 
            this.dataGridViewRegistrosCargados.AllowUserToAddRows = false;
            this.dataGridViewRegistrosCargados.AllowUserToDeleteRows = false;
            this.dataGridViewRegistrosCargados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegistrosCargados.Location = new System.Drawing.Point(12, 100);
            this.dataGridViewRegistrosCargados.Name = "dataGridViewRegistrosCargados";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewRegistrosCargados.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRegistrosCargados.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewRegistrosCargados.ShowEditingIcon = false;
            this.dataGridViewRegistrosCargados.Size = new System.Drawing.Size(331, 150);
            this.dataGridViewRegistrosCargados.TabIndex = 1;
            // 
            // labelRegistrosCargados
            // 
            this.labelRegistrosCargados.AutoSize = true;
            this.labelRegistrosCargados.Location = new System.Drawing.Point(109, 84);
            this.labelRegistrosCargados.Name = "labelRegistrosCargados";
            this.labelRegistrosCargados.Size = new System.Drawing.Size(99, 13);
            this.labelRegistrosCargados.TabIndex = 2;
            this.labelRegistrosCargados.Text = "Registros Cargados";
            this.labelRegistrosCargados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // llegadaMicros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 262);
            this.Controls.Add(this.labelRegistrosCargados);
            this.Controls.Add(this.dataGridViewRegistrosCargados);
            this.Controls.Add(this.buttonIngresarArribo);
            this.Name = "llegadaMicros";
            this.Text = "Registro de Llegadas de Micros";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistrosCargados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIngresarArribo;
        private System.Windows.Forms.DataGridView dataGridViewRegistrosCargados;
        private System.Windows.Forms.Label labelRegistrosCargados;
    }
}