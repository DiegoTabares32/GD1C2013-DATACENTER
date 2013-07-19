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
using FrbaBus.Registrar_LLegada_Micro;
using FrbaBus.Abm_Micro;
using FrbaBus.Canc_Dev_de_Pas_Enc;
using FrbaBus.Canje_de_Ptos;

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

        private void estadisticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoEstadistico listado_est = new ListadoEstadistico();
            listado_est.ShowDialog();
        }

        private void registrarArriboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            llegadaMicros llegada_micro = new llegadaMicros();
            llegada_micro.ShowDialog();
        }

        private void microToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abm_Micro_Alta altaMicro = new Abm_Micro_Alta();
            altaMicro.Show();
        }

        private void microToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Abm_Micro_Modif modifMicro = new Abm_Micro_Modif();
            modifMicro.Show();
        }

        private void microToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Abm_Micro_Baja bajaMicro = new Abm_Micro_Baja();
            bajaMicro.Show();
        }

        private void registrarDevoluciónCancelaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelDevol cancelDevol = new CancelDevol();
            cancelDevol.Show();
        }

        private void canjePremioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CanjeDePuntos canje = new CanjeDePuntos();
            canje.Show();
        }


    }
}
