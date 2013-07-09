namespace FrbaBus.Abm_Rol
{
    partial class Abm_Rol_Baja
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
            this.rol_a_buscarTB = new System.Windows.Forms.TextBox();
            this.buscar_boton = new System.Windows.Forms.Button();
            this.cleanning_boton = new System.Windows.Forms.Button();
            this.roles_elim_dataGrid = new System.Windows.Forms.DataGridView();
            this.Column_eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.roles_elim_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Rol: ";
            // 
            // rol_a_buscarTB
            // 
            this.rol_a_buscarTB.Location = new System.Drawing.Point(148, 32);
            this.rol_a_buscarTB.Name = "rol_a_buscarTB";
            this.rol_a_buscarTB.Size = new System.Drawing.Size(136, 20);
            this.rol_a_buscarTB.TabIndex = 1;
            // 
            // buscar_boton
            // 
            this.buscar_boton.Location = new System.Drawing.Point(341, 21);
            this.buscar_boton.Name = "buscar_boton";
            this.buscar_boton.Size = new System.Drawing.Size(123, 27);
            this.buscar_boton.TabIndex = 2;
            this.buscar_boton.Text = "Buscar";
            this.buscar_boton.UseVisualStyleBackColor = true;
            this.buscar_boton.Click += new System.EventHandler(this.buscar_boton_Click);
            // 
            // cleanning_boton
            // 
            this.cleanning_boton.Location = new System.Drawing.Point(341, 67);
            this.cleanning_boton.Name = "cleanning_boton";
            this.cleanning_boton.Size = new System.Drawing.Size(123, 27);
            this.cleanning_boton.TabIndex = 3;
            this.cleanning_boton.Text = "Limpiar";
            this.cleanning_boton.UseVisualStyleBackColor = true;
            this.cleanning_boton.Click += new System.EventHandler(this.cleanning_boton_Click);
            // 
            // roles_elim_dataGrid
            // 
            this.roles_elim_dataGrid.AllowUserToAddRows = false;
            this.roles_elim_dataGrid.AllowUserToDeleteRows = false;
            this.roles_elim_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roles_elim_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_eliminar});
            this.roles_elim_dataGrid.Location = new System.Drawing.Point(16, 119);
            this.roles_elim_dataGrid.MultiSelect = false;
            this.roles_elim_dataGrid.Name = "roles_elim_dataGrid";
            this.roles_elim_dataGrid.ReadOnly = true;
            this.roles_elim_dataGrid.Size = new System.Drawing.Size(499, 174);
            this.roles_elim_dataGrid.TabIndex = 4;
            this.roles_elim_dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roles_elim_dataGrid_CellContentClick);
            // 
            // Column_eliminar
            // 
            this.Column_eliminar.HeaderText = "Acción";
            this.Column_eliminar.Name = "Column_eliminar";
            this.Column_eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column_eliminar.Text = "Eliminar";
            this.Column_eliminar.UseColumnTextForButtonValue = true;
            // 
            // Abm_Rol_Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 301);
            this.Controls.Add(this.roles_elim_dataGrid);
            this.Controls.Add(this.cleanning_boton);
            this.Controls.Add(this.buscar_boton);
            this.Controls.Add(this.rol_a_buscarTB);
            this.Controls.Add(this.label1);
            this.Name = "Abm_Rol_Baja";
            this.Text = "Baja de Rol";
            ((System.ComponentModel.ISupportInitialize)(this.roles_elim_dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rol_a_buscarTB;
        private System.Windows.Forms.Button buscar_boton;
        private System.Windows.Forms.Button cleanning_boton;
        private System.Windows.Forms.DataGridView roles_elim_dataGrid;
        private System.Windows.Forms.DataGridViewButtonColumn Column_eliminar;
    }
}