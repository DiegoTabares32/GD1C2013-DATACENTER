namespace FrbaBus.Abm_Rol
{
    partial class Abm_Rol_Alta
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
            this.name_rol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.list_funcionalidades = new System.Windows.Forms.CheckedListBox();
            this.butt_Cleaning = new System.Windows.Forms.Button();
            this.butt_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Rol:";
            // 
            // name_rol
            // 
            this.name_rol.Location = new System.Drawing.Point(109, 32);
            this.name_rol.Name = "name_rol";
            this.name_rol.Size = new System.Drawing.Size(146, 20);
            this.name_rol.TabIndex = 1;
            this.name_rol.TextChanged += new System.EventHandler(this.name_rol_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Funcionalidades: ";
            // 
            // list_funcionalidades
            // 
            this.list_funcionalidades.FormattingEnabled = true;
            this.list_funcionalidades.Location = new System.Drawing.Point(109, 78);
            this.list_funcionalidades.Name = "list_funcionalidades";
            this.list_funcionalidades.Size = new System.Drawing.Size(151, 109);
            this.list_funcionalidades.TabIndex = 3;
            // 
            // butt_Cleaning
            // 
            this.butt_Cleaning.Location = new System.Drawing.Point(16, 209);
            this.butt_Cleaning.Name = "butt_Cleaning";
            this.butt_Cleaning.Size = new System.Drawing.Size(103, 27);
            this.butt_Cleaning.TabIndex = 4;
            this.butt_Cleaning.Text = "Limpiar";
            this.butt_Cleaning.UseVisualStyleBackColor = true;
            this.butt_Cleaning.Click += new System.EventHandler(this.butt_Cleaning_Click);
            // 
            // butt_add
            // 
            this.butt_add.Location = new System.Drawing.Point(157, 209);
            this.butt_add.Name = "butt_add";
            this.butt_add.Size = new System.Drawing.Size(103, 27);
            this.butt_add.TabIndex = 5;
            this.butt_add.Text = "Agregar";
            this.butt_add.UseVisualStyleBackColor = true;
            this.butt_add.Click += new System.EventHandler(this.butt_add_Click);
            // 
            // Abm_Rol_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.butt_add);
            this.Controls.Add(this.butt_Cleaning);
            this.Controls.Add(this.list_funcionalidades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_rol);
            this.Controls.Add(this.label1);
            this.Name = "Abm_Rol_Alta";
            this.Text = "Alta Rol";
            this.Load += new System.EventHandler(this.list_funcionalidades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_rol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox list_funcionalidades;
        private System.Windows.Forms.Button butt_Cleaning;
        private System.Windows.Forms.Button butt_add;
    }
}