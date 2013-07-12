namespace FrbaBus.Consulta_Puntos_Adquiridos
{
    partial class Abm_Consulta_Puntos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.consultarDni = new System.Windows.Forms.Button();
            this.labelDni = new System.Windows.Forms.Label();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.labelTotalPuntos = new System.Windows.Forms.Label();
            this.labelResultadoPuntos = new System.Windows.Forms.Label();
            this.labelPuntosDetallados = new System.Windows.Forms.Label();
            this.labelCanjesRealizados = new System.Windows.Forms.Label();
            this.dataGridViewPuntosDetallados = new System.Windows.Forms.DataGridView();
            this.dataGridViewCanjesRealizados = new System.Windows.Forms.DataGridView();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPuntosDetallados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCanjesRealizados)).BeginInit();
            this.SuspendLayout();
            // 
            // consultarDni
            // 
            this.consultarDni.Location = new System.Drawing.Point(244, 7);
            this.consultarDni.Name = "consultarDni";
            this.consultarDni.Size = new System.Drawing.Size(127, 23);
            this.consultarDni.TabIndex = 0;
            this.consultarDni.Text = "Consultar";
            this.consultarDni.UseVisualStyleBackColor = true;
            this.consultarDni.Click += new System.EventHandler(this.consultarDni_Click);
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Location = new System.Drawing.Point(13, 9);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(98, 13);
            this.labelDni.TabIndex = 1;
            this.labelDni.Text = "Ingrese n° de DNI: ";
            // 
            // textBoxDni
            // 
            this.textBoxDni.Location = new System.Drawing.Point(112, 8);
            this.textBoxDni.MaxLength = 8;
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(120, 20);
            this.textBoxDni.TabIndex = 2;
            // 
            // labelTotalPuntos
            // 
            this.labelTotalPuntos.AutoSize = true;
            this.labelTotalPuntos.Location = new System.Drawing.Point(10, 35);
            this.labelTotalPuntos.Name = "labelTotalPuntos";
            this.labelTotalPuntos.Size = new System.Drawing.Size(107, 13);
            this.labelTotalPuntos.TabIndex = 3;
            this.labelTotalPuntos.Text = "Puntos Acumulados: ";
            // 
            // labelResultadoPuntos
            // 
            this.labelResultadoPuntos.AutoSize = true;
            this.labelResultadoPuntos.Location = new System.Drawing.Point(140, 35);
            this.labelResultadoPuntos.Name = "labelResultadoPuntos";
            this.labelResultadoPuntos.Size = new System.Drawing.Size(0, 13);
            this.labelResultadoPuntos.TabIndex = 4;
            // 
            // labelPuntosDetallados
            // 
            this.labelPuntosDetallados.AutoSize = true;
            this.labelPuntosDetallados.Location = new System.Drawing.Point(10, 67);
            this.labelPuntosDetallados.Name = "labelPuntosDetallados";
            this.labelPuntosDetallados.Size = new System.Drawing.Size(93, 13);
            this.labelPuntosDetallados.TabIndex = 5;
            this.labelPuntosDetallados.Text = "Puntos Detallados";
            // 
            // labelCanjesRealizados
            // 
            this.labelCanjesRealizados.AutoSize = true;
            this.labelCanjesRealizados.Location = new System.Drawing.Point(444, 67);
            this.labelCanjesRealizados.Name = "labelCanjesRealizados";
            this.labelCanjesRealizados.Size = new System.Drawing.Size(94, 13);
            this.labelCanjesRealizados.TabIndex = 6;
            this.labelCanjesRealizados.Text = "Canjes Realizados";
            // 
            // dataGridViewPuntosDetallados
            // 
            this.dataGridViewPuntosDetallados.AllowUserToAddRows = false;
            this.dataGridViewPuntosDetallados.AllowUserToDeleteRows = false;
            this.dataGridViewPuntosDetallados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewPuntosDetallados.Location = new System.Drawing.Point(12, 83);
            this.dataGridViewPuntosDetallados.Name = "dataGridViewPuntosDetallados";
            this.dataGridViewPuntosDetallados.ReadOnly = true;
            this.dataGridViewPuntosDetallados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewPuntosDetallados.Size = new System.Drawing.Size(418, 192);
            this.dataGridViewPuntosDetallados.TabIndex = 7;
            // 
            // dataGridViewCanjesRealizados
            // 
            this.dataGridViewCanjesRealizados.AllowUserToAddRows = false;
            this.dataGridViewCanjesRealizados.AllowUserToDeleteRows = false;
            this.dataGridViewCanjesRealizados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCanjesRealizados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewCanjesRealizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCanjesRealizados.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCanjesRealizados.Location = new System.Drawing.Point(447, 83);
            this.dataGridViewCanjesRealizados.Name = "dataGridViewCanjesRealizados";
            this.dataGridViewCanjesRealizados.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCanjesRealizados.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCanjesRealizados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewCanjesRealizados.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCanjesRealizados.Size = new System.Drawing.Size(310, 192);
            this.dataGridViewCanjesRealizados.TabIndex = 8;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonLimpiar.Location = new System.Drawing.Point(602, 8);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 9;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // Abm_Consulta_Puntos
            // 
            this.AcceptButton = this.consultarDni;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonLimpiar;
            this.ClientSize = new System.Drawing.Size(769, 289);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.dataGridViewCanjesRealizados);
            this.Controls.Add(this.dataGridViewPuntosDetallados);
            this.Controls.Add(this.labelCanjesRealizados);
            this.Controls.Add(this.labelPuntosDetallados);
            this.Controls.Add(this.labelResultadoPuntos);
            this.Controls.Add(this.labelTotalPuntos);
            this.Controls.Add(this.consultarDni);
            this.Controls.Add(this.textBoxDni);
            this.Controls.Add(this.labelDni);
            this.Name = "Abm_Consulta_Puntos";
            this.Text = "Consulta de Puntos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPuntosDetallados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCanjesRealizados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button consultarDni;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.Label labelTotalPuntos;
        private System.Windows.Forms.Label labelResultadoPuntos;
        private System.Windows.Forms.Label labelPuntosDetallados;
        private System.Windows.Forms.Label labelCanjesRealizados;
        private System.Windows.Forms.DataGridView dataGridViewPuntosDetallados;
        private System.Windows.Forms.DataGridView dataGridViewCanjesRealizados;
        private System.Windows.Forms.Button buttonLimpiar;
    }
}