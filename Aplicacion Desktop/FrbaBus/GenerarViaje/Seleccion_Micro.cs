using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaBus.GenerarViaje
{
    public partial class Seleccion_Micro : Form
    {
        public string patente = "";
        string pat_micro = "";
        string tipo_serv_reco = "";
        string fecha_salida = "";
        string dia_despues;
        string dia_antes = "";

        public Seleccion_Micro(string serv, string fecha, string dia_ant, string dia_prox)
        {
            InitializeComponent();
            tipo_serv_reco = serv; // Es el tipo de servicio que tiene que tener el micro
            fecha_salida = fecha;
            dia_despues = dia_prox;
            dia_antes = dia_ant;
        }

        private void limpiar()
        {
            textBoxPatente.Clear();
            comboBoxMarca.ResetText();
            //comboBoxTipoServ.ResetText();
            textBoxCantBut.ResetText();
        }

        private void textBoxCantBut_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Seleccion_Micro_Load(object sender, EventArgs e)
        {
            connection conexion = new connection();

            string query1 = "SELECT serv_tipo, serv_id FROM DATACENTER.Servicio";
            DataTable tabla_servicios = conexion.execute_query(query1);
            comboBoxTipoServ.DataSource = tabla_servicios;
            comboBoxTipoServ.DisplayMember = "serv_tipo";
            comboBoxTipoServ.ValueMember = "serv_id";
            comboBoxTipoServ.Text = tipo_serv_reco;

            string query2 = "SELECT marc_nombre, marc_id FROM DATACENTER.Marca";
            DataTable tabla_marcas = conexion.execute_query(query2);
            comboBoxMarca.DataSource = tabla_marcas;
            comboBoxMarca.DisplayMember = "marc_nombre";
            comboBoxMarca.ValueMember = "marc_id";

            this.limpiar();
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            if (comboBoxMarca.SelectedValue == null) //ESTO CONTROLA QUE NO ME PONGAN UNA MARCA QUE NO EXISTE EN EL COMBOBOX, PORQ SINO EXPLOTA TODO PQ ESTOY TRABAJANDO CON EL VALUEMEMBER, ENTONCES EL SQL ROMPE AL INTENTAR HACER LA CONVERSION DE TIPO
            {
                MessageBox.Show("ERROR. LA MARCA ES INCORRECTA");
                return;
            }

            string query = "SELECT mic_patente, serv_tipo, marc_nombre, mic_nro, mic_cant_butacas FROM DATACENTER.Micro JOIN DATACENTER.Marca ON mic_marc_id = marc_id JOIN DATACENTER.Servicio ON mic_serv_id = serv_id WHERE serv_tipo = " + "'" + comboBoxTipoServ.Text.ToString() + "'";
            //ESTA QUERY ASI COMO ESTA CORRESPONDE A TODOS LOS CAMPOS VACIOS, MENOS EL DE SERVICIO...
            string condicion = "";

            if (textBoxPatente.Text != "")
            {
                condicion = condicion + " AND " + "mic_patente = " + "'" + textBoxPatente.Text.ToString() + "'";
            }

            if (comboBoxMarca.Text != "")
            {
                condicion = condicion + " AND " + "marc_nombre = " + "'" + comboBoxMarca.Text.ToString() + "'";
            }

            if (textBoxCantBut.Text != "")
            {
                condicion = condicion + " AND " + "mic_cant_butacas >= " + textBoxCantBut.Text.ToString();
            }

            if (condicion != "")
            {
                query = query + condicion;
            }

            //FILTRO DE MICROS DISPONIBLES PARA REALIZAR EL VIAJE
            
            query = query + " AND mic_fecha_baja_def IS NULL AND NOT EXISTS (SELECT 1 FROM DATACENTER.EstadoMicro WHERE est_mic_patente = mic_patente AND est_fecha_reingreso >= CONVERT(datetime, " + "'" + fecha_salida + "'" + ", 121)" + " AND est_fecha_fuera_serv IS NOT NULL) AND NOT EXISTS (SELECT 1 FROM DATACENTER.Viaje WHERE viaj_mic_patente = mic_patente AND viaj_fecha_salida BETWEEN CONVERT(datetime, " + "'" + dia_antes + "'" + ", 121) AND  CONVERT(datetime, " + "'" + dia_despues + "'" + ", 121))";

            //ANTES DE ESTO DEBO RESOLVER EL STRING Q LE VOY A MANDAR COMO QUERY A LA CONEXION    
            connection conexion = new connection();
            DataTable tabla_micro_sel = conexion.execute_query(query);

            this.Patentes.DataPropertyName = tabla_micro_sel.Columns[0].ToString();
            this.Tipo_Serv.DataPropertyName = tabla_micro_sel.Columns[1].ToString();
            this.Marca.DataPropertyName = tabla_micro_sel.Columns[2].ToString();
            this.Nro_Micro.DataPropertyName = tabla_micro_sel.Columns[3].ToString();
            this.Cant_Butacas.DataPropertyName = tabla_micro_sel.Columns[4].ToString();
            //cargamos el data_grid con el resultado de la busqueda
            this.dataGridMicro.DataSource = tabla_micro_sel;

            bool flag_entro = false;
            if (tabla_micro_sel.Rows.Count == 0 && textBoxPatente.Text == "" && comboBoxMarca.Text == "" && textBoxCantBut.Text == "")
            {
                flag_entro = true;
                MessageBox.Show("ERROR: No hay ningun micro disponible actualmente para realizar este tipo de recorrido");
            }

            if (tabla_micro_sel.Rows.Count == 0 && flag_entro == false)
            {
                MessageBox.Show("ERROR: No existen micros con las caracteristicas que esta buscando");
            }
        }

        private void dataGridMicro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //verificamos que el evento se haya producido en la columna que contiene el boton de seleccionar
            if (e.ColumnIndex == 0)
            {
                botonConfirmar.Enabled = true;
                pat_micro = this.dataGridMicro.CurrentRow.Cells[1].Value.ToString();
                MessageBox.Show("Usted ha seleccionado el micro: " + pat_micro + "." + " Si es correcto, por favor termine la operacion clickeando el boton de --CONFIRMAR SELECCION--");
            }
        }

        private void botonConfirmar_Click(object sender, EventArgs e)
        {
            if (pat_micro == "")
            {
                MessageBox.Show("ERROR: Usted no ha seleccionado ninguna fila");
                return;
            }

            patente = pat_micro;
        }





    }


}

