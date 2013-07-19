namespace FrbaBus.Canc_Dev_de_Pas_Enc
{
    partial class CancelDevol
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
            this.labelFechaCancDev = new System.Windows.Forms.Label();
            this.labelNroCompra = new System.Windows.Forms.Label();
            this.labelCodItem = new System.Windows.Forms.Label();
            this.labelMotivoCancDev = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxNroCompra = new System.Windows.Forms.TextBox();
            this.dateTimePickerCancDev = new System.Windows.Forms.DateTimePicker();
            this.textBoxCodPasEnc = new System.Windows.Forms.TextBox();
            this.textBoxMotivoDeCanc = new System.Windows.Forms.TextBox();
            this.labelItemADevolver = new System.Windows.Forms.Label();
            this.comboBoxTipoItem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAlcance = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelFechaCancDev
            // 
            this.labelFechaCancDev.AutoSize = true;
            this.labelFechaCancDev.Location = new System.Drawing.Point(11, 28);
            this.labelFechaCancDev.Name = "labelFechaCancDev";
            this.labelFechaCancDev.Size = new System.Drawing.Size(176, 13);
            this.labelFechaCancDev.TabIndex = 0;
            this.labelFechaCancDev.Text = "Fecha de Cancelación/Devolución:";
            // 
            // labelNroCompra
            // 
            this.labelNroCompra.AutoSize = true;
            this.labelNroCompra.Location = new System.Drawing.Point(12, 56);
            this.labelNroCompra.Name = "labelNroCompra";
            this.labelNroCompra.Size = new System.Drawing.Size(81, 13);
            this.labelNroCompra.TabIndex = 1;
            this.labelNroCompra.Text = "Nro de Compra:";
            // 
            // labelCodItem
            // 
            this.labelCodItem.AutoSize = true;
            this.labelCodItem.Location = new System.Drawing.Point(11, 145);
            this.labelCodItem.Name = "labelCodItem";
            this.labelCodItem.Size = new System.Drawing.Size(81, 13);
            this.labelCodItem.TabIndex = 2;
            this.labelCodItem.Text = "Código de Item:";
            // 
            // labelMotivoCancDev
            // 
            this.labelMotivoCancDev.AutoSize = true;
            this.labelMotivoCancDev.Location = new System.Drawing.Point(10, 183);
            this.labelMotivoCancDev.Name = "labelMotivoCancDev";
            this.labelMotivoCancDev.Size = new System.Drawing.Size(178, 13);
            this.labelMotivoCancDev.TabIndex = 4;
            this.labelMotivoCancDev.Text = "Motivo de Cancelación/Devolución:";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(83, 279);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 6;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxNroCompra
            // 
            this.textBoxNroCompra.Location = new System.Drawing.Point(193, 53);
            this.textBoxNroCompra.Name = "textBoxNroCompra";
            this.textBoxNroCompra.Size = new System.Drawing.Size(121, 20);
            this.textBoxNroCompra.TabIndex = 15;
            this.textBoxNroCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumericos_KeyPress);
            // 
            // dateTimePickerCancDev
            // 
            this.dateTimePickerCancDev.Location = new System.Drawing.Point(193, 24);
            this.dateTimePickerCancDev.Name = "dateTimePickerCancDev";
            this.dateTimePickerCancDev.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerCancDev.TabIndex = 16;
            // 
            // textBoxCodPasEnc
            // 
            this.textBoxCodPasEnc.Location = new System.Drawing.Point(193, 142);
            this.textBoxCodPasEnc.Name = "textBoxCodPasEnc";
            this.textBoxCodPasEnc.Size = new System.Drawing.Size(121, 20);
            this.textBoxCodPasEnc.TabIndex = 17;
            this.textBoxCodPasEnc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumericos_KeyPress);
            // 
            // textBoxMotivoDeCanc
            // 
            this.textBoxMotivoDeCanc.Location = new System.Drawing.Point(193, 179);
            this.textBoxMotivoDeCanc.MaxLength = 255;
            this.textBoxMotivoDeCanc.Multiline = true;
            this.textBoxMotivoDeCanc.Name = "textBoxMotivoDeCanc";
            this.textBoxMotivoDeCanc.Size = new System.Drawing.Size(200, 78);
            this.textBoxMotivoDeCanc.TabIndex = 19;
            // 
            // labelItemADevolver
            // 
            this.labelItemADevolver.AutoSize = true;
            this.labelItemADevolver.Location = new System.Drawing.Point(11, 115);
            this.labelItemADevolver.Name = "labelItemADevolver";
            this.labelItemADevolver.Size = new System.Drawing.Size(85, 13);
            this.labelItemADevolver.TabIndex = 20;
            this.labelItemADevolver.Text = "Item a Devolver:";
            // 
            // comboBoxTipoItem
            // 
            this.comboBoxTipoItem.FormattingEnabled = true;
            this.comboBoxTipoItem.Location = new System.Drawing.Point(193, 110);
            this.comboBoxTipoItem.Name = "comboBoxTipoItem";
            this.comboBoxTipoItem.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoItem.TabIndex = 21;
            this.comboBoxTipoItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxTipoItem_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Alcance de la Devolución:";
            // 
            // comboBoxAlcance
            // 
            this.comboBoxAlcance.FormattingEnabled = true;
            this.comboBoxAlcance.Location = new System.Drawing.Point(193, 80);
            this.comboBoxAlcance.Name = "comboBoxAlcance";
            this.comboBoxAlcance.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAlcance.TabIndex = 23;
            this.comboBoxAlcance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxAlcance_KeyPress);
            this.comboBoxAlcance.SelectedValueChanged += new System.EventHandler(this.comboBoxAlcance_SelectedValueChanged);
            // 
            // CancelDevol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 326);
            this.Controls.Add(this.comboBoxAlcance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTipoItem);
            this.Controls.Add(this.labelItemADevolver);
            this.Controls.Add(this.textBoxMotivoDeCanc);
            this.Controls.Add(this.textBoxCodPasEnc);
            this.Controls.Add(this.dateTimePickerCancDev);
            this.Controls.Add(this.textBoxNroCompra);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.labelMotivoCancDev);
            this.Controls.Add(this.labelCodItem);
            this.Controls.Add(this.labelNroCompra);
            this.Controls.Add(this.labelFechaCancDev);
            this.Name = "CancelDevol";
            this.Text = "Cancelación/Devolución de Pasajes/Encomiendas";
            this.Load += new System.EventHandler(this.FormCancDev_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFechaCancDev;
        private System.Windows.Forms.Label labelNroCompra;
        private System.Windows.Forms.Label labelCodItem;
        private System.Windows.Forms.Label labelMotivoCancDev;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxNroCompra;
        private System.Windows.Forms.DateTimePicker dateTimePickerCancDev;
        private System.Windows.Forms.TextBox textBoxCodPasEnc;
        private System.Windows.Forms.TextBox textBoxMotivoDeCanc;
        private System.Windows.Forms.Label labelItemADevolver;
        private System.Windows.Forms.ComboBox comboBoxTipoItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAlcance;
    }
}