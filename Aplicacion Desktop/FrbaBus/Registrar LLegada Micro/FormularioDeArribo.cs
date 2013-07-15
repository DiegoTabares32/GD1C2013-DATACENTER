using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaBus.Registrar_LLegada_Micro
{
    public partial class FormularioDeArribo : Form
    {
        
        public FormularioDeArribo()
        {
            InitializeComponent();
            
        }

        private void FormularioDeArribo_Load(object sender, EventArgs e)
        {
            string query = "SELECT ciu_nombre FROM DATACENTER.Ciudad";
            connection conexion = new connection();
            DataTable table_ciu_orig = conexion.execute_query(query);
            DataTable table_ciu_dest = conexion.execute_query(query);

            //Cargo ciudades de Origen
            this.comboBoxOrigen.DataSource = table_ciu_orig;
            this.comboBoxOrigen.DisplayMember = "ciu_nombre";
            this.comboBoxOrigen.ValueMember = "ciu_nombre";

            //Cargo ciudades Destino
            this.comboBoxArribo.DataSource = table_ciu_dest;
            this.comboBoxArribo.DisplayMember = "ciu_nombre";
            this.comboBoxArribo.ValueMember = "ciu_nombre";
            this.comboBoxOrigen.ResetText();
            this.comboBoxArribo.ResetText();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            //LLENO UNA TABLA CON EL RESULTADO DE LOS VALORES INGRESADOS Y 
            //LOS AGREGO EN LA DATAGRID DE REGISTRO LLEGADA MICRO
            string fechayhora = textBoxFechallegada.Text +" "+ textBoxHorallegada.Text;
            string patente = textBoxPatente.Text;
            string origen = comboBoxOrigen.Text;
            string destino = comboBoxArribo.Text;
            //ACA PIDO LA INFORMACION DEL MICRO
            string query1 = "select m.mic_nro as 'N° Micro', m.mic_patente as 'Patente', s.serv_tipo as 'Servicio', m.mic_modelo as 'Modelo', ma.marc_nombre as 'Marca', m.mic_fecha_alta as 'Fecha de alta', m.mic_cant_kg_disponibles as 'Capacidad (Kg)', m.mic_cant_butacas as 'Cantidad de Butacas' from DATACENTER.Micro m join DATACENTER.Servicio s on s.serv_id = m.mic_serv_id join DATACENTER.Marca ma on ma.marc_id = m.mic_marc_id where m.mic_patente = '"+ textBoxPatente.Text +"'";
            //VOY CARGARDO LOS REGISTROS INSERTADOS EN UNA TABLA PARA DESPUES INSETARLOS EN ARRIBO
            connection conexion = new connection();
            string querySeleccionViajeId = "select v.viaj_id from DATACENTER.Recorrido r join DATACENTER.Viaje v on v.viaj_reco_cod = r.reco_cod and r.reco_origen = '" + comboBoxOrigen.Text + "' and v.viaj_mic_patente = '" + textBoxPatente.Text + "' where DATEDIFF(HH, v.viaj_fecha_salida, '" + fechayhora + "' ) BETWEEN 0 AND 24";
            DataTable resultadoSeleccionViajeId = conexion.execute_query(querySeleccionViajeId);
            
            string query = "insert into DATACENTER.arribosCargados values('" + fechayhora + "', '" + patente + "', '" + origen + "', '" + destino + "' ,"+ resultadoSeleccionViajeId.Rows[0].ItemArray.ElementAt(0).ToString()+ ")";
            
            conexion.execute_query(query);
            DataTable infoMicro = conexion.execute_query(query1);
            //VALIDO QUE LA CIUDAD DE DESTINO SEA LA MISMA A LA QUE LLEGO
            string query2 = "select r.reco_destino from DATACENTER.Recorrido r join DATACENTER.Viaje v on v.viaj_reco_cod = r.reco_cod and r.reco_origen = '" + comboBoxOrigen.Text + "'and r.reco_destino = '"+ comboBoxArribo.Text +"' and v.viaj_mic_patente = '" + textBoxPatente.Text + "' where DATEDIFF(HH, v.viaj_fecha_salida, '" + fechayhora + "' ) BETWEEN 0 AND 24";
            DataTable resultadoDestino = conexion.execute_query(query2);
            string mensaje = "La ciudad arribada es distinta a la que el micro tenía programada";            
            if (resultadoDestino.Rows.Count > 0)
            {
                mensaje = "";    
            }
            //MUESTRO LA INFORMACION DEL MICRO INSERTADO
            InfoMicro info = new InfoMicro(infoMicro, mensaje);
            info.Show();            
            this.Close();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.textBoxFechallegada.Clear();
            this.textBoxHorallegada.Clear();
            this.textBoxPatente.Clear();
            this.comboBoxOrigen.ResetText();
            this.comboBoxArribo.ResetText();
        }
               
    }
}
