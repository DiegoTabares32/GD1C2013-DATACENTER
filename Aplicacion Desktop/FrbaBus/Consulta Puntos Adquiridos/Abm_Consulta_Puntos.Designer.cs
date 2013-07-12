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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.labelPuntosVencidos = new System.Windows.Forms.Label();
            this.labelResultadoPuntosVencidos = new System.Windows.Forms.Label();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewPuntosDetallados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPuntosDetallados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPuntosDetallados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPuntosDetallados.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPuntosDetallados.Location = new System.Drawing.Point(12, 83);
            this.dataGridViewPuntosDetallados.Name = "dataGridViewPuntosDetallados";
            this.dataGridViewPuntosDetallados.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPuntosDetallados.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewPuntosDetallados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewPuntosDetallados.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewPuntosDetallados.Size = new System.Drawing.Size(418, 192);
            this.dataGridViewPuntosDetallados.TabIndex = 7;
            // 
            // dataGridViewCanjesRealizados
            // 
            this.dataGridViewCanjesRealizados.AllowUserToAddRows = false;
            this.dataGridViewCanjesRealizados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewCanjesRealizados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewCanjesRealizados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCanjesRealizados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCanjesRealizados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewCanjesRealizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCanjesRealizados.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewCanjesRealizados.Location = new System.Drawing.Point(447, 83);
            this.dataGridViewCanjesRealizados.Name = "dataGridViewCanjesRealizados";
            this.dataGridViewCanjesRealizados.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCanjesRealizados.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewCanjesRealizados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewCanjesRealizados.RowsDefaultCellStyle = dataGridViewCellStyle10;
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
            // labelPuntosVencidos
            // 
            this.labelPuntosVencidos.AutoSize = true;
            this.labelPuntosVencidos.Location = new System.Drawing.Point(244, 35);
            this.labelPuntosVencidos.Name = "labelPuntosVencidos";
            this.labelPuntosVencidos.Size = new System.Drawing.Size(93, 13);
            this.labelPuntosVencidos.TabIndex = 10;
            this.labelPuntosVencidos.Text = "Puntos Vencidos: ";
            // 
            // labelResultadoPuntosVencidos
            // 
            this.labelResultadoPuntosVencidos.AutoSize = true;
            this.labelResultadoPuntosVencidos.Location = new System.Drawing.Point(372, 35);
            this.labelResultadoPuntosVencidos.Name = "labelResultadoPuntosVencidos";
            this.labelResultadoPuntosVencidos.Size = new System.Drawing.Size(0, 13);
            this.labelResultadoPuntosVencidos.TabIndex = 11;
            // 
            // Abm_Consulta_Puntos
            // 
            this.AcceptButton = this.consultarDni;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonLimpiar;
            this.ClientSize = new System.Drawing.Size(769, 289);
            this.Controls.Add(this.labelResultadoPuntosVencidos);
            this.Controls.Add(this.labelPuntosVencidos);
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
        private System.Windows.Forms.Label labelPuntosVencidos;
        private System.Windows.Forms.Label labelResultadoPuntosVencidos;
    }
}