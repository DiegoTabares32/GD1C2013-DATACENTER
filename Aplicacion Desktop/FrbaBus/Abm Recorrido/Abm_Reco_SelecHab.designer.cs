namespace FrbaBus.Abm_Recorrido
{
    partial class Abm_Reco_SelecHab
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
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.comboBoxTipoServ = new System.Windows.Forms.ComboBox();
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.comboBoxOrigen = new System.Windows.Forms.ComboBox();
            this.dataGridReco = new System.Windows.Forms.DataGridView();
            this.Cod_Reco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Serv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciu_Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciu_Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Base_Pasaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Base_Kg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_Reco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCodReco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReco)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.Location = new System.Drawing.Point(533, 6);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.ReadOnly = true;
            this.textBoxEstado.Size = new System.Drawing.Size(100, 20);
            this.textBoxEstado.TabIndex = 37;
            this.textBoxEstado.Text = "Deshabilitado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Estado:";
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(887, 311);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(139, 45);
            this.botonBuscar.TabIndex = 35;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(887, 226);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(139, 45);
            this.botonLimpiar.TabIndex = 34;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // comboBoxTipoServ
            // 
            this.comboBoxTipoServ.FormattingEnabled = true;
            this.comboBoxTipoServ.Location = new System.Drawing.Point(105, 52);
            this.comboBoxTipoServ.Name = "comboBoxTipoServ";
            this.comboBoxTipoServ.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoServ.TabIndex = 33;
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Location = new System.Drawing.Point(335, 51);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDestino.TabIndex = 32;
            // 
            // comboBoxOrigen
            // 
            this.comboBoxOrigen.FormattingEnabled = true;
            this.comboBoxOrigen.Location = new System.Drawing.Point(335, 6);
            this.comboBoxOrigen.Name = "comboBoxOrigen";
            this.comboBoxOrigen.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOrigen.TabIndex = 31;
            // 
            // dataGridReco
            // 
            this.dataGridReco.AllowUserToAddRows = false;
            this.dataGridReco.AllowUserToDeleteRows = false;
            this.dataGridReco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Reco,
            this.Tipo_Serv,
            this.Ciu_Origen,
            this.Ciu_Destino,
            this.Precio_Base_Pasaje,
            this.Precio_Base_Kg,
            this.Estado_Reco,
            this.Seleccionar});
            this.dataGridReco.Location = new System.Drawing.Point(15, 91);
            this.dataGridReco.Name = "dataGridReco";
            this.dataGridReco.ReadOnly = true;
            this.dataGridReco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridReco.Size = new System.Drawing.Size(866, 291);
            this.dataGridReco.TabIndex = 30;
            this.dataGridReco.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridReco_CellContentClick);
            // 
            // Cod_Reco
            // 
            this.Cod_Reco.HeaderText = "Cod_Reco";
            this.Cod_Reco.Name = "Cod_Reco";
            this.Cod_Reco.ReadOnly = true;
            // 
            // Tipo_Serv
            // 
            this.Tipo_Serv.HeaderText = "Tipo_Serv";
            this.Tipo_Serv.Name = "Tipo_Serv";
            this.Tipo_Serv.ReadOnly = true;
            // 
            // Ciu_Origen
            // 
            this.Ciu_Origen.HeaderText = "Ciu_Origen";
            this.Ciu_Origen.Name = "Ciu_Origen";
            this.Ciu_Origen.ReadOnly = true;
            // 
            // Ciu_Destino
            // 
            this.Ciu_Destino.HeaderText = "Ciu_Destino";
            this.Ciu_Destino.Name = "Ciu_Destino";
            this.Ciu_Destino.ReadOnly = true;
            // 
            // Precio_Base_Pasaje
            // 
            this.Precio_Base_Pasaje.HeaderText = "Precio_Base_Pasaje";
            this.Precio_Base_Pasaje.Name = "Precio_Base_Pasaje";
            this.Precio_Base_Pasaje.ReadOnly = true;
            this.Precio_Base_Pasaje.Width = 120;
            // 
            // Precio_Base_Kg
            // 
            this.Precio_Base_Kg.HeaderText = "Precio_Base_Kg";
            this.Precio_Base_Kg.Name = "Precio_Base_Kg";
            this.Precio_Base_Kg.ReadOnly = true;
            // 
            // Estado_Reco
            // 
            this.Estado_Reco.HeaderText = "Estado_Reco";
            this.Estado_Reco.Name = "Estado_Reco";
            this.Estado_Reco.ReadOnly = true;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccion";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Text = "Seleccionar";
            this.Seleccionar.UseColumnTextForButtonValue = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Ciudad Destino:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Ciudad Origen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tipo de Servicio:";
            // 
            // textBoxCodReco
            // 
            this.textBoxCodReco.Location = new System.Drawing.Point(122, 6);
            this.textBoxCodReco.Name = "textBoxCodReco";
            this.textBoxCodReco.Size = new System.Drawing.Size(104, 20);
            this.textBoxCodReco.TabIndex = 26;
            this.textBoxCodReco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCodReco_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Codigo de Recorrido:";
            // 
            // Abm_Reco_SelecHab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 411);
            this.Controls.Add(this.textBoxEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.comboBoxTipoServ);
            this.Controls.Add(this.comboBoxDestino);
            this.Controls.Add(this.comboBoxOrigen);
            this.Controls.Add(this.dataGridReco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCodReco);
            this.Controls.Add(this.label1);
            this.Name = "Abm_Reco_SelecHab";
            this.Text = "Abm_Reco_SelecHab";
            this.Load += new System.EventHandler(this.Abm_Reco_SelecHab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.ComboBox comboBoxTipoServ;
        private System.Windows.Forms.ComboBox comboBoxDestino;
        private System.Windows.Forms.ComboBox comboBoxOrigen;
        private System.Windows.Forms.DataGridView dataGridReco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Reco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Serv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciu_Origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciu_Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Base_Pasaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Base_Kg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_Reco;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCodReco;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxEstado;
    }
}