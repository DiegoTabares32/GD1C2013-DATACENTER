namespace FrbaBus.Abm_Rol
{
    partial class Abm_Rol_Busqueda
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
            this.roles_dataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.rol_a_buscarTBox = new System.Windows.Forms.TextBox();
            this.buscar_boton = new System.Windows.Forms.Button();
            this.limpiar_boton = new System.Windows.Forms.Button();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.roles_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // roles_dataGrid
            // 
            this.roles_dataGrid.AllowUserToAddRows = false;
            this.roles_dataGrid.AllowUserToDeleteRows = false;
            this.roles_dataGrid.AllowUserToResizeColumns = false;
            this.roles_dataGrid.AllowUserToResizeRows = false;
            this.roles_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roles_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.roles_dataGrid.Location = new System.Drawing.Point(12, 113);
            this.roles_dataGrid.MultiSelect = false;
            this.roles_dataGrid.Name = "roles_dataGrid";
            this.roles_dataGrid.ReadOnly = true;
            this.roles_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.roles_dataGrid.Size = new System.Drawing.Size(418, 177);
            this.roles_dataGrid.TabIndex = 0;
            this.roles_dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roles_dataGrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar Rol: ";
            // 
            // rol_a_buscarTBox
            // 
            this.rol_a_buscarTBox.Location = new System.Drawing.Point(106, 32);
            this.rol_a_buscarTBox.Name = "rol_a_buscarTBox";
            this.rol_a_buscarTBox.Size = new System.Drawing.Size(141, 20);
            this.rol_a_buscarTBox.TabIndex = 2;
            // 
            // buscar_boton
            // 
            this.buscar_boton.Location = new System.Drawing.Point(309, 25);
            this.buscar_boton.Name = "buscar_boton";
            this.buscar_boton.Size = new System.Drawing.Size(106, 33);
            this.buscar_boton.TabIndex = 3;
            this.buscar_boton.Text = "Buscar";
            this.buscar_boton.UseVisualStyleBackColor = true;
            this.buscar_boton.Click += new System.EventHandler(this.buscar_boton_Click);
            // 
            // limpiar_boton
            // 
            this.limpiar_boton.Location = new System.Drawing.Point(309, 75);
            this.limpiar_boton.Name = "limpiar_boton";
            this.limpiar_boton.Size = new System.Drawing.Size(106, 32);
            this.limpiar_boton.TabIndex = 4;
            this.limpiar_boton.Text = "Limpiar";
            this.limpiar_boton.UseVisualStyleBackColor = true;
            this.limpiar_boton.Click += new System.EventHandler(this.limpiar_boton_Click);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Acción";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Seleccionar.Text = "Seleccionar";
            this.Seleccionar.UseColumnTextForButtonValue = true;
            // 
            // Abm_Rol_Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 302);
            this.Controls.Add(this.limpiar_boton);
            this.Controls.Add(this.buscar_boton);
            this.Controls.Add(this.rol_a_buscarTBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roles_dataGrid);
            this.Name = "Abm_Rol_Busqueda";
            this.Text = "Buscar Rol";
            ((System.ComponentModel.ISupportInitialize)(this.roles_dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView roles_dataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rol_a_buscarTBox;
        private System.Windows.Forms.Button buscar_boton;
        private System.Windows.Forms.Button limpiar_boton;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;

    }
}