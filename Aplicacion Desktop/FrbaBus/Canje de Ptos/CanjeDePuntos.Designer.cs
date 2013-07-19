namespace FrbaBus.Canje_de_Ptos
{
    partial class CanjeDePuntos
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
            this.tablaPremios = new System.Windows.Forms.DataGridView();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.labelDniCliente = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.textBoxDniCliente = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.Selección = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Premio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPremios)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaPremios
            // 
            this.tablaPremios.AllowUserToAddRows = false;
            this.tablaPremios.AllowUserToDeleteRows = false;
            this.tablaPremios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPremios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selección,
            this.Cantidad,
            this.Premio,
            this.Puntos});
            this.tablaPremios.Location = new System.Drawing.Point(29, 67);
            this.tablaPremios.Name = "tablaPremios";
            this.tablaPremios.Size = new System.Drawing.Size(520, 215);
            this.tablaPremios.TabIndex = 0;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(453, 298);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 3;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // labelDniCliente
            // 
            this.labelDniCliente.AutoSize = true;
            this.labelDniCliente.Location = new System.Drawing.Point(27, 16);
            this.labelDniCliente.Name = "labelDniCliente";
            this.labelDniCliente.Size = new System.Drawing.Size(64, 13);
            this.labelDniCliente.TabIndex = 4;
            this.labelDniCliente.Text = "DNI Cliente:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(27, 40);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(40, 13);
            this.labelFecha.TabIndex = 5;
            this.labelFecha.Text = "Fecha:";
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(97, 37);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFecha.TabIndex = 6;
            // 
            // textBoxDniCliente
            // 
            this.textBoxDniCliente.Location = new System.Drawing.Point(96, 12);
            this.textBoxDniCliente.Name = "textBoxDniCliente";
            this.textBoxDniCliente.Size = new System.Drawing.Size(201, 20);
            this.textBoxDniCliente.TabIndex = 7;
            this.textBoxDniCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dniCliente_KeyPress);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(317, 9);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 8;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(358, 297);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // Selección
            // 
            this.Selección.Frozen = true;
            this.Selección.HeaderText = "Selección";
            this.Selección.Name = "Selección";
            // 
            // Cantidad
            // 
            this.Cantidad.Frozen = true;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Premio
            // 
            this.Premio.Frozen = true;
            this.Premio.HeaderText = "Premio";
            this.Premio.Name = "Premio";
            this.Premio.Width = 180;
            // 
            // Puntos
            // 
            this.Puntos.Frozen = true;
            this.Puntos.HeaderText = "Puntos";
            this.Puntos.Name = "Puntos";
            // 
            // CanjeDePuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 334);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxDniCliente);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelDniCliente);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.tablaPremios);
            this.Name = "CanjeDePuntos";
            this.Text = "Canje De Puntos";
            ((System.ComponentModel.ISupportInitialize)(this.tablaPremios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaPremios;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label labelDniCliente;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.TextBox textBoxDniCliente;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selección;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Premio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntos;
    }
}