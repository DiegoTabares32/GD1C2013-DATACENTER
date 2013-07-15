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
        private llegadaMicros llegadaMicros;

        public FormularioDeArribo(llegadaMicros llegada)
        {
            InitializeComponent();
            this.llegadaMicros = llegada;
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

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            //LLENO UNA TABLA CON EL RESULTADO DE LOS VALORES INGRESADOS Y 
            //LOS AGREGO EN LA DATAGRID DE REGISTRO LLEGADA MICRO
            string fechayhora = textBoxFechallegada.Text +" "+ textBoxHorallegada.Text;
            string patente = labelpatente.Text;
            string origen = comboBoxOrigen.Text;
            string destino = comboBoxArribo.Text;
            string query1 = "select m.mic_nro as 'N° Micro', m.mic_patente as 'Patente', m.mic_serv_id as 'Servicio', m.mic_modelo as 'Modelo', m.mic_marc_id as 'Marca', m.mic_fecha_alta as 'Fecha de alta', m.mic_cant_kg_disponibles as 'Capacidad (Kg)', m.mic_cant_butacas as 'Cantidad de Butacas' from DATACENTER.Micro m where m.mic_patente = '"+ textBoxPatente.Text +"'";
            string query = "insert into DATACENTER.arribosCargados values('" + fechayhora + "', '" + patente + "', '" + origen + "', '" + destino + "')";
            connection conexion = new connection();
            conexion.execute_query(query);
            DataTable infoMicro = conexion.execute_query(query1);
            string query2 = "select count(distinct v.viaj_mic_patente) from DATACENTER.Recorrido r join DATACENTER.Viaje v on v.viaj_reco_cod = r.reco_cod and r.reco_origen = '"+ comboBoxOrigen.Text +"' and r.reco_destino = '"+ comboBoxArribo.Text +"' and v.viaj_mic_patente = '"+ textBoxPatente.Text +"'";
            DataTable resultadoDestino = conexion.execute_query(query2);
            string mensaje = "La ciudad arribada es distinta a la que el micro tenía programada";            
            if ((int)resultadoDestino.Rows[0].ItemArray.ElementAt(0) > 0)
            {
                mensaje = "";    
            }
            
            InfoMicro info = new InfoMicro(infoMicro, mensaje);
            info.Show();            
            this.Close();
        }
               
    }
}
