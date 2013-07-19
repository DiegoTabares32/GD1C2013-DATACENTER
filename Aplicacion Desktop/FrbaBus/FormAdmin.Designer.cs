namespace FrbaBus
{
    partial class FormAdmin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarArriboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.microToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.modificaciónToolStripMenuItem,
            this.bajaToolStripMenuItem,
            this.compraToolStripMenuItem,
            this.estadisticaToolStripMenuItem,
            this.registrarArriboToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(549, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolToolStripMenuItem,
            this.microToolStripMenuItem});
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.altaToolStripMenuItem.Text = "Alta";
            // 
            // rolToolStripMenuItem
            // 
            this.rolToolStripMenuItem.Name = "rolToolStripMenuItem";
            this.rolToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rolToolStripMenuItem.Text = "Rol";
            this.rolToolStripMenuItem.Click += new System.EventHandler(this.rolToolStripMenuItem_Click);
            // 
            // modificaciónToolStripMenuItem
            // 
            this.modificaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolToolStripMenuItem1});
            this.modificaciónToolStripMenuItem.Name = "modificaciónToolStripMenuItem";
            this.modificaciónToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.modificaciónToolStripMenuItem.Text = "Modificación";
            // 
            // rolToolStripMenuItem1
            // 
            this.rolToolStripMenuItem1.Name = "rolToolStripMenuItem1";
            this.rolToolStripMenuItem1.Size = new System.Drawing.Size(91, 22);
            this.rolToolStripMenuItem1.Text = "Rol";
            this.rolToolStripMenuItem1.Click += new System.EventHandler(this.rolToolStripMenuItem1_Click);
            // 
            // bajaToolStripMenuItem
            // 
            this.bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            this.bajaToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.bajaToolStripMenuItem.Text = "Baja";
            // 
            // compraToolStripMenuItem
            // 
            this.compraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaciónToolStripMenuItem});
            this.compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            this.compraToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.compraToolStripMenuItem.Text = "Compra";
            // 
            // facturaciónToolStripMenuItem
            // 
            this.facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            this.facturaciónToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.facturaciónToolStripMenuItem.Text = "Facturación";
            this.facturaciónToolStripMenuItem.Click += new System.EventHandler(this.facturaciónToolStripMenuItem_Click);
            // 
            // estadisticaToolStripMenuItem
            // 
            this.estadisticaToolStripMenuItem.Name = "estadisticaToolStripMenuItem";
            this.estadisticaToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.estadisticaToolStripMenuItem.Text = "Estadistica";
            this.estadisticaToolStripMenuItem.Click += new System.EventHandler(this.estadisticaToolStripMenuItem_Click);
            // 
            // registrarArriboToolStripMenuItem
            // 
            this.registrarArriboToolStripMenuItem.Name = "registrarArriboToolStripMenuItem";
            this.registrarArriboToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.registrarArriboToolStripMenuItem.Text = "Registrar Arribo";
            this.registrarArriboToolStripMenuItem.Click += new System.EventHandler(this.registrarArriboToolStripMenuItem_Click);
            // 
            // microToolStripMenuItem
            // 
            this.microToolStripMenuItem.Name = "microToolStripMenuItem";
            this.microToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.microToolStripMenuItem.Text = "Micro";
            this.microToolStripMenuItem.Click += new System.EventHandler(this.microToolStripMenuItem_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 68);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAdmin";
            this.Text = "Menu Administrador";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarArriboToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem microToolStripMenuItem;
    }
}