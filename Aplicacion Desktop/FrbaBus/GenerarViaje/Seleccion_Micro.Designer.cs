namespace FrbaBus.GenerarViaje
{
    partial class Seleccion_Micro
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
            this.botonConfirmar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.dataGridMicro = new System.Windows.Forms.DataGridView();
            this.comboBoxTipoServ = new System.Windows.Forms.ComboBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPatente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCantBut = new System.Windows.Forms.TextBox();
            this.Patentes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Serv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro_Micro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant_Butacas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMicro)).BeginInit();
            this.SuspendLayout();
            // 
            // botonConfirmar
            // 
            this.botonConfirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.botonConfirmar.Enabled = false;
            this.botonConfirmar.Location = new System.Drawing.Point(671, 5);
            this.botonConfirmar.Name = "botonConfirmar";
            this.botonConfirmar.Size = new System.Drawing.Size(137, 99);
            this.botonConfirmar.TabIndex = 35;
            this.botonConfirmar.Text = "CONFIRMAR SELECCION";
            this.botonConfirmar.UseVisualStyleBackColor = true;
            this.botonConfirmar.Click += new System.EventHandler(this.botonConfirmar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(316, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "*Debe primero seleccionar una fila, y luego confirmar la selección.";
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(546, 58);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(108, 47);
            this.botonBuscar.TabIndex = 33;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(546, 5);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(108, 46);
            this.botonLimpiar.TabIndex = 32;
            this.botonLimpiar.Text = "Limpiar:";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // dataGridMicro
            // 
            this.dataGridMicro.AllowUserToAddRows = false;
            this.dataGridMicro.AllowUserToDeleteRows = false;
            this.dataGridMicro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMicro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Patentes,
            this.Tipo_Serv,
            this.Marca,
            this.Nro_Micro,
            this.Cant_Butacas,
            this.Seleccionar});
            this.dataGridMicro.Location = new System.Drawing.Point(12, 118);
            this.dataGridMicro.Name = "dataGridMicro";
            this.dataGridMicro.ReadOnly = true;
            this.dataGridMicro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMicro.Size = new System.Drawing.Size(679, 291);
            this.dataGridMicro.TabIndex = 31;
            this.dataGridMicro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMicro_CellContentClick);
            // 
            // comboBoxTipoServ
            // 
            this.comboBoxTipoServ.Enabled = false;
            this.comboBoxTipoServ.FormattingEnabled = true;
            this.comboBoxTipoServ.Location = new System.Drawing.Point(105, 52);
            this.comboBoxTipoServ.Name = "comboBoxTipoServ";
            this.comboBoxTipoServ.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoServ.TabIndex = 30;
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(298, 5);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(201, 21);
            this.comboBoxMarca.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Cantidad minima de Butacas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tipo de Servicio:";
            // 
            // textBoxPatente
            // 
            this.textBoxPatente.Location = new System.Drawing.Point(65, 6);
            this.textBoxPatente.Name = "textBoxPatente";
            this.textBoxPatente.Size = new System.Drawing.Size(161, 20);
            this.textBoxPatente.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Patente:";
            // 
            // textBoxCantBut
            // 
            this.textBoxCantBut.Location = new System.Drawing.Point(399, 55);
            this.textBoxCantBut.MaxLength = 3;
            this.textBoxCantBut.Name = "textBoxCantBut";
            this.textBoxCantBut.Size = new System.Drawing.Size(100, 20);
            this.textBoxCantBut.TabIndex = 36;
            this.textBoxCantBut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCantBut_KeyPress);
            // 
            // Patentes
            // 
            this.Patentes.HeaderText = "Patente";
            this.Patentes.Name = "Patentes";
            this.Patentes.ReadOnly = true;
            // 
            // Tipo_Serv
            // 
            this.Tipo_Serv.HeaderText = "Tipo_Serv";
            this.Tipo_Serv.Name = "Tipo_Serv";
            this.Tipo_Serv.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Nro_Micro
            // 
            this.Nro_Micro.HeaderText = "Nro_Micro";
            this.Nro_Micro.Name = "Nro_Micro";
            this.Nro_Micro.ReadOnly = true;
            this.Nro_Micro.Width = 120;
            // 
            // Cant_Butacas
            // 
            this.Cant_Butacas.HeaderText = "Cant_Butacas";
            this.Cant_Butacas.Name = "Cant_Butacas";
            this.Cant_Butacas.ReadOnly = true;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccion";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Text = "Seleccionar";
            this.Seleccionar.UseColumnTextForButtonValue = true;
            // 
            // Seleccion_Micro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 418);
            this.Controls.Add(this.textBoxCantBut);
            this.Controls.Add(this.botonConfirmar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.dataGridMicro);
            this.Controls.Add(this.comboBoxTipoServ);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPatente);
            this.Controls.Add(this.label1);
            this.Name = "Seleccion_Micro";
            this.Text = "Seleccion_Micro";
            this.Load += new System.EventHandler(this.Seleccion_Micro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMicro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonConfirmar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.DataGridView dataGridMicro;
        private System.Windows.Forms.ComboBox comboBoxTipoServ;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPatente;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxCantBut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Serv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_Micro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant_Butacas;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
    }
}