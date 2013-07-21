using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaBus.Abm_Recorrido
{
    public partial class Abm_Reco_SelecHab : Form
    {
        //-----ATRIBUTOS--------
        char estado_reco = 'D';
        //----------------------

        public Abm_Reco_SelecHab()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            textBoxCodReco.Clear();
            comboBoxOrigen.ResetText();
            comboBoxDestino.ResetText();
            comboBoxTipoServ.ResetText();
        }

        private void Abm_Reco_SelecHab_Load(object sender, EventArgs e)
        {
            connection conexion = new connection();

            string query1 = "SELECT serv_tipo, serv_id FROM DATACENTER.Servicio";
            DataTable tabla_servicios = conexion.execute_query(query1);
            comboBoxTipoServ.DataSource = tabla_servicios;
            comboBoxTipoServ.DisplayMember = "serv_tipo";
            comboBoxTipoServ.ValueMember = "serv_id";


            string query2 = "SELECT ciu_nombre FROM DATACENTER.Ciudad";
            DataTable tabla_origenes = conexion.execute_query(query2);
            comboBoxOrigen.DataSource = tabla_origenes;
            comboBoxOrigen.DisplayMember = "ciu_nombre";
            comboBoxOrigen.ValueMember = "ciu_nombre";


            string query3 = "SELECT ciu_nombre FROM DATACENTER.Ciudad";
            DataTable tabla_destinos = conexion.execute_query(query3);
            comboBoxDestino.DataSource = tabla_destinos;
            comboBoxDestino.DisplayMember = "ciu_nombre";
            comboBoxDestino.ValueMember = "ciu_nombre";

            limpiar();
        }

        private void dataGridReco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //verificamos que el evento se haya producido en la columna que contiene el boton de seleccionar
            if (e.ColumnIndex == 0)
            {
                string estado_a_mandar;
                estado_a_mandar = "Deshabilitado";

                Abm_Reco_Habilitar abm_reco_hab = new Abm_Reco_Habilitar(estado_a_mandar); // SIEMPRE VA A MANDAR DESHABILITADOS, NUNCA DESHABILITADOS

                abm_reco_hab.textBoxCodReco.Text = this.dataGridReco.CurrentRow.Cells[1].Value.ToString();

                abm_reco_hab.ShowDialog();

                this.limpiar();
                //cuando retorna de la modificacion refrescamos la pantalla
                // podria ir un close
            }
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            if (comboBoxTipoServ.SelectedValue == null) //ESTO CONTROLA QUE NO ME PONGAN UN SERVICIO QUE NO EXISTE EN EL COMBOBOX, PORQ SINO EXPLOTA TODO PQ ESTOY TRABAJANDO CON EL VALUEMEMBER, ENTONCES EL SQL ROMPE AL INTENTAR HACER LA CONVERSION DE TIPO
            {
                MessageBox.Show("ERROR. EL TIPO DE SERVICIO ES INCORRECTO");
                return;
            }

            string query = "SELECT reco_cod, serv_tipo, reco_origen, reco_destino, reco_precio_base_pasaje, reco_precio_base_kg, reco_estado FROM DATACENTER.Recorrido JOIN DATACENTER.Servicio ON reco_serv_id = serv_id WHERE 1 = 1";
            //ESTA QUERY ASI COMO ESTA CORRESPONDE A TODOS LOS CAMPOS VACIOS...
            string condicion = "";

            condicion = condicion + " AND " + "reco_estado = " + "'" + estado_reco + "'"; // ESTA SE CUMPLE SIEMPRE!

            if (textBoxCodReco.Text != "")
            {
                condicion = condicion + " AND " + "reco_cod = " + "'" + textBoxCodReco.Text.ToString() + "'";
            }

            if (comboBoxTipoServ.Text != "")
            {
                condicion = condicion + " AND " + "serv_tipo = " + "'" + comboBoxTipoServ.Text.ToString() + "'";
            }

            if (comboBoxOrigen.Text != "")
            {
                condicion = condicion + " AND " + "reco_origen = " + "'" + comboBoxOrigen.Text.ToString() + "'";
            }

            if (comboBoxDestino.Text != "")
            {
                condicion = condicion + " AND " + "reco_destino = " + "'" + comboBoxDestino.Text.ToString() + "'";
            }

            query = query + condicion; // LE AGREGO A LA QUERY TODOS LOS FILTROS

            connection conexion = new connection();
            DataTable tabla_reco_busq = conexion.execute_query(query);
            this.Cod_Reco.DataPropertyName = tabla_reco_busq.Columns[0].ToString();
            this.Tipo_Serv.DataPropertyName = tabla_reco_busq.Columns[1].ToString();
            this.Ciu_Origen.DataPropertyName = tabla_reco_busq.Columns[2].ToString();
            this.Ciu_Destino.DataPropertyName = tabla_reco_busq.Columns[3].ToString();
            this.Precio_Base_Pasaje.DataPropertyName = tabla_reco_busq.Columns[4].ToString();
            this.Precio_Base_Kg.DataPropertyName = tabla_reco_busq.Columns[5].ToString();
            this.Estado_Reco.DataPropertyName = tabla_reco_busq.Columns[6].ToString();
            //cargamos el data_grid con el resultado de la busqueda
            this.dataGridReco.DataSource = tabla_reco_busq;
        }

        private void textBoxCodReco_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan
                    e.Handled = true;
                }
        }




    }
}
