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
            this.alta_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.alta_rol = new System.Windows.Forms.ToolStripMenuItem();
            this.alta_micro = new System.Windows.Forms.ToolStripMenuItem();
            this.alta_recorrido = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.modif_rol = new System.Windows.Forms.ToolStripMenuItem();
            this.modif_micro = new System.Windows.Forms.ToolStripMenuItem();
            this.modif_reco = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.baja_micro = new System.Windows.Forms.ToolStripMenuItem();
            this.baja_reco = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarArriboMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.compra_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarDevoluciónCancelacionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.canjePremioMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.generarViajeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alta_menu,
            this.modificacionMenu,
            this.bajaMenu,
            this.registrarArriboMenu,
            this.compra_menu,
            this.registrarDevoluciónCancelacionMenu,
            this.estadisticaMenu,
            this.canjePremioMenu,
            this.generarViajeMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alta_menu
            // 
            this.alta_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alta_rol,
            this.alta_micro,
            this.alta_recorrido});
            this.alta_menu.Name = "alta_menu";
            this.alta_menu.Size = new System.Drawing.Size(40, 20);
            this.alta_menu.Text = "Alta";
            // 
            // alta_rol
            // 
            this.alta_rol.Name = "alta_rol";
            this.alta_rol.Size = new System.Drawing.Size(125, 22);
            this.alta_rol.Text = "Rol";
            this.alta_rol.Visible = false;
            this.alta_rol.Click += new System.EventHandler(this.rolToolStripMenuItem_Click);
            // 
            // alta_micro
            // 
            this.alta_micro.Name = "alta_micro";
            this.alta_micro.Size = new System.Drawing.Size(125, 22);
            this.alta_micro.Text = "Micro";
            this.alta_micro.Visible = false;
            this.alta_micro.Click += new System.EventHandler(this.microToolStripMenuItem_Click);
            // 
            // alta_recorrido
            // 
            this.alta_recorrido.Name = "alta_recorrido";
            this.alta_recorrido.Size = new System.Drawing.Size(125, 22);
            this.alta_recorrido.Text = "Recorrido";
            this.alta_recorrido.Visible = false;
            this.alta_recorrido.Click += new System.EventHandler(this.recorridoToolStripMenuItem_Click);
            // 
            // modificacionMenu
            // 
            this.modificacionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modif_rol,
            this.modif_micro,
            this.modif_reco});
            this.modificacionMenu.Name = "modificacionMenu";
            this.modificacionMenu.Size = new System.Drawing.Size(89, 20);
            this.modificacionMenu.Text = "Modificación";
            // 
            // modif_rol
            // 
            this.modif_rol.Name = "modif_rol";
            this.modif_rol.Size = new System.Drawing.Size(125, 22);
            this.modif_rol.Text = "Rol";
            this.modif_rol.Visible = false;
            this.modif_rol.Click += new System.EventHandler(this.rolToolStripMenuItem1_Click);
            // 
            // modif_micro
            // 
            this.modif_micro.Name = "modif_micro";
            this.modif_micro.Size = new System.Drawing.Size(125, 22);
            this.modif_micro.Text = "Micro";
            this.modif_micro.Visible = false;
            this.modif_micro.Click += new System.EventHandler(this.microToolStripMenuItem1_Click);
            // 
            // modif_reco
            // 
            this.modif_reco.Name = "modif_reco";
            this.modif_reco.Size = new System.Drawing.Size(125, 22);
            this.modif_reco.Text = "Recorrido";
            this.modif_reco.Visible = false;
            this.modif_reco.Click += new System.EventHandler(this.recorridoToolStripMenuItem1_Click);
            // 
            // bajaMenu
            // 
            this.bajaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baja_micro,
            this.baja_reco});
            this.bajaMenu.Name = "bajaMenu";
            this.bajaMenu.Size = new System.Drawing.Size(41, 20);
            this.bajaMenu.Text = "Baja";
            // 
            // baja_micro
            // 
            this.baja_micro.Name = "baja_micro";
            this.baja_micro.Size = new System.Drawing.Size(125, 22);
            this.baja_micro.Text = "Micro";
            this.baja_micro.Visible = false;
            this.baja_micro.Click += new System.EventHandler(this.microToolStripMenuItem2_Click);
            // 
            // baja_reco
            // 
            this.baja_reco.Name = "baja_reco";
            this.baja_reco.Size = new System.Drawing.Size(125, 22);
            this.baja_reco.Text = "Recorrido";
            this.baja_reco.Visible = false;
            // 
            // registrarArriboMenu
            // 
            this.registrarArriboMenu.Name = "registrarArriboMenu";
            this.registrarArriboMenu.Size = new System.Drawing.Size(101, 20);
            this.registrarArriboMenu.Text = "Registrar Arribo";
            this.registrarArriboMenu.Visible = false;
            this.registrarArriboMenu.Click += new System.EventHandler(this.registrarArriboToolStripMenuItem_Click);
            // 
            // compra_menu
            // 
            this.compra_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaciónToolStripMenuItem});
            this.compra_menu.Name = "compra_menu";
            this.compra_menu.Size = new System.Drawing.Size(62, 20);
            this.compra_menu.Text = "Compra";
            this.compra_menu.Visible = false;
            // 
            // facturaciónToolStripMenuItem
            // 
            this.facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            this.facturaciónToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.facturaciónToolStripMenuItem.Text = "Facturación";
            this.facturaciónToolStripMenuItem.Click += new System.EventHandler(this.facturaciónToolStripMenuItem_Click);
            // 
            // registrarDevoluciónCancelacionMenu
            // 
            this.registrarDevoluciónCancelacionMenu.Name = "registrarDevoluciónCancelacionMenu";
            this.registrarDevoluciónCancelacionMenu.Size = new System.Drawing.Size(191, 20);
            this.registrarDevoluciónCancelacionMenu.Text = "Registrar Devolucin/Cancelacion";
            this.registrarDevoluciónCancelacionMenu.Visible = false;
            this.registrarDevoluciónCancelacionMenu.Click += new System.EventHandler(this.registrarDevoluciónCancelaciónToolStripMenuItem_Click);
            // 
            // estadisticaMenu
            // 
            this.estadisticaMenu.Name = "estadisticaMenu";
            this.estadisticaMenu.Size = new System.Drawing.Size(74, 20);
            this.estadisticaMenu.Text = "Estadistica";
            this.estadisticaMenu.Visible = false;
            this.estadisticaMenu.Click += new System.EventHandler(this.estadisticaToolStripMenuItem_Click);
            // 
            // canjePremioMenu
            // 
            this.canjePremioMenu.Name = "canjePremioMenu";
            this.canjePremioMenu.Size = new System.Drawing.Size(90, 20);
            this.canjePremioMenu.Text = "Canje Premio";
            this.canjePremioMenu.Visible = false;
            this.canjePremioMenu.Click += new System.EventHandler(this.canjePremioToolStripMenuItem_Click);
            // 
            // generarViajeMenu
            // 
            this.generarViajeMenu.Name = "generarViajeMenu";
            this.generarViajeMenu.Size = new System.Drawing.Size(88, 20);
            this.generarViajeMenu.Text = "Generar Viaje";
            this.generarViajeMenu.Visible = false;
            this.generarViajeMenu.Click += new System.EventHandler(this.generarViajeToolStripMenuItem_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 68);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAdmin";
            this.Text = "Menu Administrador";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alta_menu;
        private System.Windows.Forms.ToolStripMenuItem modificacionMenu;
        private System.Windows.Forms.ToolStripMenuItem bajaMenu;
        private System.Windows.Forms.ToolStripMenuItem alta_rol;
        private System.Windows.Forms.ToolStripMenuItem modif_rol;
        private System.Windows.Forms.ToolStripMenuItem compra_menu;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticaMenu;
        private System.Windows.Forms.ToolStripMenuItem registrarArriboMenu;
        private System.Windows.Forms.ToolStripMenuItem alta_micro;
        private System.Windows.Forms.ToolStripMenuItem modif_micro;
        private System.Windows.Forms.ToolStripMenuItem baja_micro;
        private System.Windows.Forms.ToolStripMenuItem registrarDevoluciónCancelacionMenu;
        private System.Windows.Forms.ToolStripMenuItem canjePremioMenu;
        private System.Windows.Forms.ToolStripMenuItem alta_recorrido;
        private System.Windows.Forms.ToolStripMenuItem modif_reco;
        private System.Windows.Forms.ToolStripMenuItem baja_reco;
        private System.Windows.Forms.ToolStripMenuItem generarViajeMenu;
    }
}