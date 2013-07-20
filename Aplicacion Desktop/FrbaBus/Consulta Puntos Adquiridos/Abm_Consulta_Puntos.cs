using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaBus.Consulta_Puntos_Adquiridos
{
    public partial class Abm_Consulta_Puntos : Form
    {
        private funciones funciones;

        public Abm_Consulta_Puntos()
        {
            InitializeComponent();
            this.funciones = new funciones();
        }

        private void consultarDni_Click(object sender, EventArgs e)
        {
            if (textBoxDni.Text == "")
            {
                MessageBox.Show("Debe Ingresar un DNI ");
                return;
            }
            
            char[] caracter = textBoxDni.Text.ToCharArray();
            if (!caracter.All(Char.IsDigit))
            {
                MessageBox.Show("Ingresar sólo números. Ej: 99999999");
                return;
            }
            DateTimePicker datetimepicker = new DateTimePicker();
            datetimepicker.Value = Convert.ToDateTime((System.Configuration.ConfigurationSettings.AppSettings["FechaDelSistema"]).ToString());

            string query = "exec DATACENTER.actualizarPuntos " + textBoxDni.Text + ", '" + datetimepicker.Value.ToString("dd/MM/yyyy HH:mm") + "' Select c.cli_puntos_acum from DATACENTER.Cliente c where c.cli_dni = " + textBoxDni.Text;
            connection connect = new connection();
            DataTable tabla_puntos = connect.execute_query(query);
            
            if (!funciones.existeDni(tabla_puntos))
            {
                MessageBox.Show("DNI inexistente en la Base de Datos");
                return;
            }            
            this.labelResultadoPuntos.Text = tabla_puntos.Rows[0].ItemArray.ElementAt(0).ToString();
            //Cargo el resultado de los puntos vencidos
            string puntosVencidos = this.funciones.totalPuntosVencidos(textBoxDni.Text);
            this.labelResultadoPuntosVencidos.Text = puntosVencidos;
            //Lleno la tabla de canjes 
            string query2 = "SELECT    prem_nombre AS 'Premio', prem_costo_Puntos AS 'Puntos', canj_fecha AS 'Fecha', canj_cant_retirada AS 'Cantidad' FROM DATACENTER.Canje join DATACENTER.Premio on canj_prem_Id = prem_Id WHERE canj_cli_Dni = " + textBoxDni.Text;
            DataTable tabla_canje = connect.execute_query(query2);

            this.dataGridViewCanjesRealizados.DataSource = tabla_canje;
            
            //Lleno la tabla de detalle de puntos            
            this.dataGridViewPuntosDetallados.DataSource = this.funciones.consultarPuntos(this.textBoxDni.Text);
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.textBoxDni.Clear();
            this.labelResultadoPuntosVencidos.Text = "";
            this.labelResultadoPuntos.Text = "";

            this.dataGridViewPuntosDetallados.Columns.Clear();
            this.dataGridViewCanjesRealizados.Columns.Clear();
            
        }


    }
}
