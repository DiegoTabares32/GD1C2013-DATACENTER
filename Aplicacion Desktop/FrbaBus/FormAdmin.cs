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
using FrbaBus.Abm_Recorrido;
using FrbaBus.GenerarViaje;
using FrbaBus.Consulta_Puntos_Adquiridos;

namespace FrbaBus
{
    public partial class FormAdmin : Form
    {

        string id_rol;

        public FormAdmin()
        {
            InitializeComponent();
        }

        public FormAdmin(string id_rol)
        {
            InitializeComponent();
            this.id_rol = id_rol;
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
            compra.buttonConsultaPuntos.Visible = false;
            compra.compra_admin = true;
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

        private void recorridoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abm_Reco_Alta altaReco = new Abm_Reco_Alta();
            altaReco.Show();
        }

        private void recorridoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Abm_Reco_Seleccion selec_Reco = new Abm_Reco_Seleccion();
            selec_Reco.Show();
        }

        private void generarViajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alta_Viaje altaViaje = new Alta_Viaje();
            altaViaje.Show();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            connection connect = new connection();
            string query = "SELECT fxrol_func_id FROM DATACENTER.FuncionalidadPorRol WHERE fxrol_rol_id = " + id_rol;
            DataTable funcionalidades_Rol= connect.execute_query(query);

            foreach (DataRow funcionalidad in funcionalidades_Rol.Rows)
            {
                switch (funcionalidad.ItemArray[0].ToString())
                {
                    case "1" :
                        alta_rol.Visible= true;
                        modif_rol.Visible= true;
                        break;
                    case "2":
                        alta_micro.Visible = true;
                        baja_micro.Visible = true;
                        modif_micro.Visible = true;
                        break;
                    case "3":
                        alta_recorrido.Visible = true;
                        baja_reco.Visible = true;
                        modif_reco.Visible = true;
                        break;
                    case "4":
                        compra_menu.Visible = true;
                        break;
                    case "5":
                        estadisticaMenu.Visible = true;
                        break;
                    case "6":
                        registrarArriboMenu.Visible = true;
                        break;
                    case "7":
                        registrarDevoluciónCancelacionMenu.Visible = true;
                        break;
                    case "8":
                        canjePremioMenu.Visible = true;
                        break;
                    case "9":
                        generarViajeMenu.Visible = true;
                        break;
                    case "10":
                        consultaPuntosPasajeroFrecuenteToolStripMenuItem.Visible = true;
                        break;
                    default:
                        MessageBox.Show("Funcionalidad Inexistente");
                        break;
                }

            }
        }

        private void baja_reco_Click(object sender, EventArgs e)
        {
            Abm_Reco_SelecDel selec_reco_del = new Abm_Reco_SelecDel();
            selec_reco_del.Show();
        }

        private void consultaPuntosPasajeroFrecuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abm_Consulta_Puntos consultar_puntos = new Abm_Consulta_Puntos();
            consultar_puntos.ShowDialog();
        }


    }
}
