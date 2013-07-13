namespace FrbaBus.Compra_de_Pasajes
{
    partial class select_butaca
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
            this.butaca_dataGrid = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.butaca_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione Butaca:";
            // 
            // butaca_dataGrid
            // 
            this.butaca_dataGrid.AllowUserToAddRows = false;
            this.butaca_dataGrid.AllowUserToDeleteRows = false;
            this.butaca_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.butaca_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.butaca_dataGrid.Location = new System.Drawing.Point(15, 56);
            this.butaca_dataGrid.MultiSelect = false;
            this.butaca_dataGrid.Name = "butaca_dataGrid";
            this.butaca_dataGrid.ReadOnly = true;
            this.butaca_dataGrid.Size = new System.Drawing.Size(522, 353);
            this.butaca_dataGrid.TabIndex = 2;
            this.butaca_dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.butaca_dataGrid_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Accion";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Text = "Seleccionar";
            this.Seleccionar.UseColumnTextForButtonValue = true;
            // 
            // select_butaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 425);
            this.Controls.Add(this.butaca_dataGrid);
            this.Controls.Add(this.label1);
            this.Name = "select_butaca";
            this.Text = "Butacas Disponbles";
            ((System.ComponentModel.ISupportInitialize)(this.butaca_dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView butaca_dataGrid;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
    }
}