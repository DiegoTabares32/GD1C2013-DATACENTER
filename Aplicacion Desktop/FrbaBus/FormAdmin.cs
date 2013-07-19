using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.Abm_Rol;
using FrbaBus.Compra_de_Pasajes;

namespace FrbaBus
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void rolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abm_Rol_Alta alta_rol = new Abm_Rol_Alta();
            alta_rol.ShowDialog();
        }

        private void rolToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Abm_Rol_Modif modif_rol = new Abm_Rol_Modif();
            modif_rol.ShowDialog();
        }

        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCompra compra = new FormCompra();
            compra.compra_admin = true;
            compra.login_boton.Visible = false;
            compra.ShowDialog();
        }


    }
}
