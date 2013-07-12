namespace FrbaBus.Compra_de_Pasajes
{
    partial class select_viaje
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
            this.viajes_dataGrid = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.viajes_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione un viaje: ";
            // 
            // viajes_dataGrid
            // 
            this.viajes_dataGrid.AllowUserToAddRows = false;
            this.viajes_dataGrid.AllowUserToDeleteRows = false;
            this.viajes_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viajes_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.viajes_dataGrid.Location = new System.Drawing.Point(12, 54);
            this.viajes_dataGrid.Name = "viajes_dataGrid";
            this.viajes_dataGrid.ReadOnly = true;
            this.viajes_dataGrid.Size = new System.Drawing.Size(917, 349);
            this.viajes_dataGrid.TabIndex = 1;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Acción";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Text = "Seleccionar";
            this.Seleccionar.UseColumnTextForButtonValue = true;
            // 
            // select_viaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 415);
            this.Controls.Add(this.viajes_dataGrid);
            this.Controls.Add(this.label1);
            this.Name = "select_viaje";
            this.Text = "Viajes Actuales";
            this.Load += new System.EventHandler(this.select_viaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viajes_dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView viajes_dataGrid;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
    }
}