using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaBus.Abm_Micro
{
    public partial class Abm_Micro_OpPorConcretar : Form
    {
        private string patenteConGuion;
        private DateTimePicker fechaFueraServ;
        private DateTimePicker fechaReing;

        public Abm_Micro_OpPorConcretar()
        {
            InitializeComponent();
        }

        internal void pasaPatente(String patenteMicro, DateTimePicker fechaFueraServicio, DateTimePicker fechaReingreso)
        {
            patenteConGuion = patenteMicro;
            fechaFueraServ = fechaFueraServicio;
            fechaReing = fechaReingreso;
        }

        private void buttonSustituir_Click(object sender, EventArgs e)
        {
            // consulta a ejecutar para saber si hay micro disponible
            string query1;
            if (fechaReing != null)
            {
                query1 = "SELECT DATACENTER.microDisponible('" + patenteConGuion + "','" + fechaFueraServ.Value.ToString("yyy/MM/dd") + "','" + fechaReing.Value.ToString("yyy/MM/dd") + "')";
            }
            else
            {
                query1 = "SELECT DATACENTER.microDisponible('" + patenteConGuion + "','" + fechaFueraServ.Value.ToString("yyy/MM/dd") + "','" + null + "')";
            }
            connection connect1 = new connection();
            DataTable microReemplazante = connect1.execute_query(query1);

            if (microReemplazante.Rows[0].ItemArray[0].ToString() == "")
            {
                //Ingreso nuevo micro que cumpla las mismas características debido que no existe uno que lo reemplace en la BD

                // Direcciona a formulario de ingreso de nuevo micro con similares características
                Patente_Alta form_PatenteAlta = new Patente_Alta();
                form_PatenteAlta.pasaCaracteristicas(patenteConGuion, fechaFueraServ, fechaReing);
                form_PatenteAlta.ShowDialog();
            
            }
            else
            {
                //Reemplazo el micro en aquellos viajes que debían darse dentro del rango de tiempo que está fuera de servicio

                //consulta a ejecutar para localizar los viajes que tenía asignados el micro anterior y actualizarles el nuevo valor
                string query3;
                if (fechaReing == null)
                {
                    query3 = "UPDATE DATACENTER.Viaje SET viaj_mic_patente='" + microReemplazante.Rows[0].ItemArray[0].ToString() + "' WHERE viaj_mic_patente='" + patenteConGuion + "' and (viaj_fecha_salida>='" + fechaFueraServ.Value.ToString("yyyy/MM/dd") + "' or viaj_fecha_lleg_estimada>='" + fechaFueraServ.Value.ToString("yyyy/MM/dd") + "')";
                }
                else
                {
                    query3 = "UPDATE DATACENTER.Viaje SET viaj_mic_patente='" + microReemplazante.Rows[0].ItemArray[0].ToString() + "' WHERE viaj_mic_patente='" + patenteConGuion + "' and ((viaj_fecha_salida>='" + fechaFueraServ.Value.ToString("yyyy/MM/dd") + "' and viaj_fecha_salida<='" + fechaReing.Value.ToString("yyyy/MM/dd") + "') or (viaj_fecha_lleg_estimada>='" + fechaFueraServ.Value.ToString("yyyy/MM/dd") + "' and viaj_fecha_lleg_estimada<='" + fechaReing.Value.ToString("yyyy/MM/dd") + "'))";
                }
                connection connect3 = new connection();
                connect3.execute_query(query3);

                MessageBox.Show("La asignación de micro nuevo a los viajes se ha realizado con éxito.");

                this.Close();

            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

            //Hacer devoluciones por los viajes y encomiendas que tenían asignado el micro para la fecha en que se da de baja

            //consulta a ejecutar para cancelar todos los viajes de ese micro en la fecha requerida
            string query2 = "exec cancelaViajesXMicro '"+patenteConGuion+"','"+fechaFueraServ.Value.ToString("yyyy/MM/dd")+"','"+fechaReing.Value.ToString("yyyy/MM/dd")+"'";
            connection connect2 = new connection();
            connect2.execute_query(query2);

            MessageBox.Show("Los viajes se han cancelado con éxito.");

            this.Close();

        }
    }
}
