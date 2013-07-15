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
    public partial class llegadaMicros : Form
    {
        public llegadaMicros()
        {
            InitializeComponent();
            string query = "create table DATACENTER.arribosCargados(id int identity primary key,fechayhora datetime,patente nvarchar(255),origen nvarchar(255),arribo nvarchar(255), viaje int)";
            connection conexion = new connection();
            conexion.execute_query(query);
        }
                          
        private void buttonIngresarArribo_Click(object sender, EventArgs e)
        {
            Form formularioDeArribo = new FormularioDeArribo();
            formularioDeArribo.Show();            
        }

        private void llegadaMicros_FormClosing(object sender, FormClosingEventArgs e)
        {            
            connection conexion = new connection();
            string query1 = "SELECT fechayhora, patente, viaje, arribo FROM DATACENTER.arribosCargados";
            DataTable tabla = conexion.execute_query(query1);
            if (tabla.Rows.Count > 0)
            {
                MessageBox.Show("Todavía hay registros ingresados sin procesar!!!");
                e.Cancel = true;
                return;
            }

            string query = "drop table DATACENTER.arribosCargados";
            
            conexion.execute_query(query);
        }

        private void buttonVerRegistrosIngresados_Click(object sender, EventArgs e)
        {
            string query = "select fechayhora as 'Fecha y Hora de Llegada', patente as 'Patente', origen as 'Origen', arribo as 'Arribo', viaje as 'Viaje Id' from DATACENTER.arribosCargados";
            connection conexion = new connection();
            DataTable resultado = conexion.execute_query(query);
            RegistrosCargados registros = new RegistrosCargados(resultado);
            registros.Show();            
        }

        private void buttonProcesarArribos_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO DATACENTER.Arribo (arri_fecha_llegada, arri_mic_patente, arri_viaj_id, arri_ciu_arribada) SELECT fechayhora, patente, viaje, arribo FROM DATACENTER.arribosCargados";
            connection conexion = new connection();
            conexion.execute_query(query);
            query = "delete DATACENTER.arribosCargados";
            conexion.execute_query(query);
        }
    }
}
