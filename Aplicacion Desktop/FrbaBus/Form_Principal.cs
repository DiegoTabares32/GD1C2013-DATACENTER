using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.Compra_de_Pasajes;
using FrbaBus.Login;
using FrbaBus.Consulta_Puntos_Adquiridos;

namespace FrbaBus
{
    public partial class Form_Principal : Form
    {
        //fecha del sistema
        DateTime fechaDelSistema = Convert.ToDateTime((System.Configuration.ConfigurationSettings.AppSettings["FechaDelSistema"]).ToString());

        public Form_Principal()
        {
            InitializeComponent();
            /*-------------------------ACTUALIZACION DE FECHA DE ALTA DE MICRO--------------*/
            stored_procedures stored = new stored_procedures();
            stored.update_fecha_alta_micro(fechaDelSistema.ToString("yyyy-MM-dd HH:mm"));
        }

        private void comboBoxPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.comboBoxPerfil.SelectedIndex == 1)
            {
                //es un cliente
                

                funciones func = new funciones();

                //chequeo si esta habilitado
                if (!func.check_estado_rol("2", 'H'))
                {
                    MessageBox.Show("Rol cliente Inhabilitado");
                    return;
                }

                //chequeo si compra esta habilitado
                if (func.check_func_activa("2", "4"))
                {
                    FormCompra compra = new FormCompra();
                    //chequeo que este habilitado consultar puntos
                    if (!func.check_func_activa("2", "10"))
                    {
                        compra.buttonConsultaPuntos.Visible = false;
                    }
                    compra.ShowDialog();
                }
                else
                {
                    if (func.check_func_activa("2", "10"))
                    {
                        Abm_Consulta_Puntos consultar_puntos = new Abm_Consulta_Puntos();
                        consultar_puntos.ShowDialog();
                    }
                }
 
            }
            else
            {
                login login = new login();
                login.ShowDialog();
            }

        }


    }
}
