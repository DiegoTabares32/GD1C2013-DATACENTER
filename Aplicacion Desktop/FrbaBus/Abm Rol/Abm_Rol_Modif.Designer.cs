namespace FrbaBus.Abm_Rol
{
    partial class Abm_Rol_Modif
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
            this.label2 = new System.Windows.Forms.Label();
            this.list_funcionalidades = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.estado_comboBox = new System.Windows.Forms.ComboBox();
            this.aplicar_boton = new System.Windows.Forms.Button();
            this.rol_select_tbox = new System.Windows.Forms.TextBox();
            this.select_boton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Rol: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Funcionalidades: ";
            // 
            // list_funcionalidades
            // 
            this.list_funcionalidades.FormattingEnabled = true;
            this.list_funcionalidades.Location = new System.Drawing.Point(131, 96);
            this.list_funcionalidades.Name = "list_funcionalidades";
            this.list_funcionalidades.Size = new System.Drawing.Size(141, 94);
            this.list_funcionalidades.TabIndex = 3;

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estado:";
            // 
            // estado_comboBox
            // 
            this.estado_comboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.estado_comboBox.FormattingEnabled = true;
            this.estado_comboBox.Items.AddRange(new object[] {
            "Habilitado",
            "Deshabilitado"});
            this.estado_comboBox.Location = new System.Drawing.Point(131, 214);
            this.estado_comboBox.Name = "estado_comboBox";
            this.estado_comboBox.Size = new System.Drawing.Size(137, 21);
            this.estado_comboBox.TabIndex = 5;
            this.estado_comboBox.SelectedIndexChanged += new System.EventHandler(this.estado_comboBox_SelectedIndexChanged);
            // 
            // aplicar_boton
            // 
            this.aplicar_boton.Location = new System.Drawing.Point(156, 270);
            this.aplicar_boton.Name = "aplicar_boton";
            this.aplicar_boton.Size = new System.Drawing.Size(112, 26);
            this.aplicar_boton.TabIndex = 6;
            this.aplicar_boton.Text = "Aplicar";
            this.aplicar_boton.UseVisualStyleBackColor = true;
            this.aplicar_boton.Click += new System.EventHandler(this.aplicar_boton_Click);
            // 
            // rol_select_tbox
            // 
            this.rol_select_tbox.Location = new System.Drawing.Point(134, 24);
            this.rol_select_tbox.Name = "rol_select_tbox";
            this.rol_select_tbox.Size = new System.Drawing.Size(133, 20);
            this.rol_select_tbox.TabIndex = 7;
            this.rol_select_tbox.TextChanged += new System.EventHandler(this.rol_select_tbox_TextChanged);
            // 
            // select_boton
            // 
            this.select_boton.Location = new System.Drawing.Point(166, 50);
            this.select_boton.Name = "select_boton";
            this.select_boton.Size = new System.Drawing.Size(101, 27);
            this.select_boton.TabIndex = 8;
            this.select_boton.Text = "Seleccionar";
            this.select_boton.UseVisualStyleBackColor = true;
            this.select_boton.Click += new System.EventHandler(this.select_boton_Click);
            // 
            // Abm_Rol_Modif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 308);
            this.Controls.Add(this.select_boton);
            this.Controls.Add(this.rol_select_tbox);
            this.Controls.Add(this.aplicar_boton);
            this.Controls.Add(this.estado_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.list_funcionalidades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Abm_Rol_Modif";
            this.Text = "Modificación Rol";
            this.Load += new System.EventHandler(this.list_funcionalidades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox list_funcionalidades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox estado_comboBox;
        private System.Windows.Forms.Button aplicar_boton;
        private System.Windows.Forms.TextBox rol_select_tbox;
        private System.Windows.Forms.Button select_boton;
    }
}