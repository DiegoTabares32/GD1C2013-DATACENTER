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

            string query = "SELECT isnull(Cli_puntos_Acum,0) FROM DATACENTER.Cliente WHERE cli_Dni = " + textBoxDni.Text;
            connection connect = new connection();
            DataTable tabla_puntos = connect.execute_query(query);
            
            if (!funciones.existeDni(tabla_puntos))
            {
                MessageBox.Show("DNI inexistente en la Base de Datos");
                return;
            }            
            this.labelResultadoPuntos.Text = tabla_puntos.Rows[0].ItemArray.ElementAt(0).ToString();
            //Cargo el resultado de los puntos vencidos
            string puntosVencidos = "SELECT ISNULL(SUM(cast(round((p.pas_precio/5),0) as numeric(18,0))),0) FROM DATACENTER.Arribo a JOIN DATACENTER.Pasaje p ON p.pas_viaj_id = a.arri_viaj_id and p.pas_cli_dni = " + textBoxDni.Text + " WHERE DATACENTER.estado_puntos(A.arri_fecha_llegada, SYSDATETIME()) = 'VENCIDOS'";
            this.labelResultadoPuntosVencidos.Text = connect.execute_query(puntosVencidos).Rows[0].ItemArray.ElementAt(0).ToString();
            //Lleno la tabla de canjes 
            string query2 = "SELECT	prem_nombre AS 'Premio', prem_costo_Puntos AS 'Puntos', canj_fecha AS 'Fecha', canj_cant_retirada AS 'Cantidad' FROM DATACENTER.Canje join DATACENTER.Premio on canj_prem_Id = prem_Id WHERE canj_cli_Dni = " + textBoxDni.Text;
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
