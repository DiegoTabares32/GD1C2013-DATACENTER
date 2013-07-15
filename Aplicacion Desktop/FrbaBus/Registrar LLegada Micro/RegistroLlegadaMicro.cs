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
            Form formularioDeArribo = new FormularioDeArribo(this);
            formularioDeArribo.Show();            
        }

        private void llegadaMicros_FormClosing(object sender, FormClosingEventArgs e)
        {
            string query = "drop table DATACENTER.arribosCargados";
            connection conexion = new connection();
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
            string query = "";
            connection conexion = new connection();
            conexion.execute_query(query);
        }
    }
}
