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
    public partial class Abm_Reco_Modificacion : Form
    {
        bool modificacion = false; // me indica si modificaron servicio, origen o destino
        bool modif_precio = false; // me indica si modificaron algun precio
        string Tipo_Servicio;
        string Ciu_Origen;
        string Ciu_Destino;

        private void limpiar()
        {
            numUpDownPrPas.Value = 0;
            numUpDownPrEnco.Value = 0;
            comboBoxOrigen.ResetText();
            comboBoxDestino.ResetText();
            comboBoxTipoServ.ResetText();
        }

        public Abm_Reco_Modificacion(string tipoServ, string origen, string destino)
        {
            Tipo_Servicio = tipoServ;     //Estos string los paso como parametro para poder
            Ciu_Origen = origen;          //setear en esta pantalla los mismos parametros que
            Ciu_Destino = destino;        //habian seleccionado en el dataGrid.
            InitializeComponent();
            comboBoxOrigen.DropDownStyle = ComboBoxStyle.DropDownList;   //ESTA PROPIEDA HACE QUE EL COMBO BOX
            comboBoxDestino.DropDownStyle = ComboBoxStyle.DropDownList;  //NO ME ACEPTE TEXTO, SINO QUE SOLAMENTE
            comboBoxTipoServ.DropDownStyle = ComboBoxStyle.DropDownList;    //SE PUEDAN ELEGIR LAS OPCIONE DEL COMBO.
        }

        private void Abm_Reco_Modificacion_Load(object sender, EventArgs e)
        {
            connection conexion = new connection();

            string query1 = "SELECT serv_tipo, serv_id FROM DATACENTER.Servicio";
            DataTable tabla_servicios = conexion.execute_query(query1);
            comboBoxTipoServ.DataSource = tabla_servicios;
            comboBoxTipoServ.DisplayMember = "serv_tipo";
            comboBoxTipoServ.ValueMember = "serv_id";
            comboBoxTipoServ.Text = Tipo_Servicio;


            string query2 = "SELECT ciu_nombre FROM DATACENTER.Ciudad";
            DataTable tabla_origenes = conexion.execute_query(query2);
            comboBoxOrigen.DataSource = tabla_origenes;
            comboBoxOrigen.DisplayMember = "ciu_nombre";
            comboBoxOrigen.ValueMember = "ciu_nombre";
            comboBoxOrigen.Text = Ciu_Origen;

            string query3 = "SELECT ciu_nombre FROM DATACENTER.Ciudad";
            DataTable tabla_destinos = conexion.execute_query(query3);
            comboBoxDestino.DataSource = tabla_destinos;
            comboBoxDestino.DisplayMember = "ciu_nombre";
            comboBoxDestino.ValueMember = "ciu_nombre";
            comboBoxDestino.Text = Ciu_Destino;
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            int codigo_error = 0; // el 0 es que no tiene errores y el 1 es que SI tiene errores!

            if ((comboBoxDestino.Text == "") || (comboBoxOrigen.Text == "") || (comboBoxTipoServ.Text == ""))
            {
                MessageBox.Show("ERROR: Debe ingresar todos los campos obligatorios");
                codigo_error = 1;
            }

            if (comboBoxOrigen.Text == comboBoxDestino.Text)
            {
                MessageBox.Show("ERROR: La ciudad de origen y la ciudad de destino deben ser distintas");
                codigo_error = 1;
            }

            if (numUpDownPrPas.Value == 0 || numUpDownPrEnco.Value == 0)
            {
                MessageBox.Show("ERROR: El precio de debe ser distinto de 0");
                codigo_error = 1;
            }

            if (modificacion == false || modif_precio == false || Tipo_Servicio == comboBoxTipoServ.Text.ToString() || Ciu_Origen == comboBoxOrigen.Text.ToString() || Ciu_Destino == comboBoxDestino.Text.ToString())
            {
                MessageBox.Show("ERROR: Usted no ha modificado nada");
                codigo_error = 1;
            }

            if (codigo_error == 1)
            {
                return;
            }

            connection conexion = new connection();

            DataTable tablaRecorridos = conexion.execute_query("SELECT 1 FROM DATACENTER.Recorrido WHERE reco_origen =" + "'" + comboBoxOrigen.Text + "'" + " AND " + "reco_destino =" + "'" + comboBoxDestino.Text + "'" + " AND " + "reco_serv_id =" + comboBoxTipoServ.SelectedValue);
            if (tablaRecorridos.Rows.Count == 1) // Se cumple cuando el recorrido ingresado ya esta en la BD
            {
                MessageBox.Show("ERROR: YA EXISTE ESTE RECORRIDO CON ESTE SERVICIO");
                codigo_error = 1;
            }

            if (modificacion == true)
            tablaRecorridos.Clear();
            string reco_cod = textBoxCodReco.Text.ToString();
            string fecha_ayer = DateTime.Now.ToString("yyyy:MM:dd HH:mm"); // ESTO SE CAMBIA POR LA FECHA DEL CONFIG!!!
            tablaRecorridos = conexion.execute_query("SELECT 1 FROM DATACENTER.Viaje WHERE viaj_reco_cod = " + "'" + reco_cod + "'" + " AND viaj_fecha_salida >= " + );
            if (tablaRecorridos.Rows.Count == 1) // Se cumple cuando el recorrido tiene viajes asociados que se estan realizando en este momento o que estan programados de hoy en adelante
            {
                MessageBox.Show("ERROR: YA EXISTE ESTE RECORRIDO CON ESTE SERVICIO");
                codigo_error = 1;
            }

            if (codigo_error == 1)
            {
                return;
            }

            //SI LLEGA ESTA ACA QUIERE DECIR QUE PASO TODAS LA VALIDACIONES, POR LO TANTO ACTUALIZAMOS LA BASE

            string cod_act = textBoxCodReco.Text.ToString();
            string orig_act = comboBoxOrigen.Text.ToString();
            string dest_act = comboBoxDestino.Text.ToString();
            int serv_act = (int)comboBoxTipoServ.SelectedValue;
            decimal pr_paq_act = numUpDownPrPas.Value;
            decimal pr_enco_act = numUpDownPrEnco.Value;
            stored_procedures procedure = new stored_procedures();
            procedure.update_recorrido(cod_act, orig_act, dest_act, serv_act, pr_paq_act, pr_enco_act);
            MessageBox.Show("¡RECORRIDO ACTUALIZADO CORRECTAMENTE!");
            limpiar();
            return;
        }

        private void comboBoxTipoServ_SelectedValueChanged(object sender, EventArgs e)
        {
            modificacion = true;
        }

        private void comboBoxOrigen_SelectedValueChanged(object sender, EventArgs e)
        {
            modificacion = true;
        }

        private void comboBoxDestino_SelectedValueChanged(object sender, EventArgs e)
        {
            modificacion = true;
        }

        private void numUpDownPrPas_ValueChanged(object sender, EventArgs e)
        {
            modif_precio = true;
        }

        private void numUpDownPrEnco_ValueChanged(object sender, EventArgs e)
        {
            modif_precio = true;
        }




    }
}
