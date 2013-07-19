using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaBus.Abm_Recorrido
{
    public partial class Abm_Reco_Alta : Form
    {
        public Abm_Reco_Alta()
        {
            InitializeComponent();
            comboBoxCiuOrigen.DropDownStyle = ComboBoxStyle.DropDownList;   //ESTA PROPIEDA HACE QUE EL COMBO BOX
            comboBoxCiuDestino.DropDownStyle = ComboBoxStyle.DropDownList;  //NO ME ACEPTE TEXTO, SINO QUE SOLAMENTE
            comboBoxTipoServ.DropDownStyle = ComboBoxStyle.DropDownList;    //SE PUEDAN ELEGIR LAS OPCIONE DEL COMBO.
        }

        private void limpiar()
        {
            textBoxCodReco.Clear();
            numUpDownPrPas.Value = 0;
            numUpDownPrEnco.Value = 0;
            comboBoxCiuOrigen.ResetText();
            comboBoxCiuDestino.ResetText();
            comboBoxTipoServ.ResetText();
        }

        private void botonRefrescar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            int codigo_error = 0; // el 0 es que no tiene errores y el 1 es que SI tiene errores!
            int cant_caract = textBoxCodReco.Text.Length;

            if (cant_caract < 1 || cant_caract > 18)
            {
                MessageBox.Show("ERROR: El codigo de recorrido debe tener entre 1 y 18 caracteres");
                textBoxCodReco.Clear();
                codigo_error = 1;
            }
            else
            {
                funciones funcion = new funciones();
                string cod_reco = textBoxCodReco.Text.ToString();
                if (funcion.son_todos_numeros(cod_reco) == false)
                {
                    MessageBox.Show("ERROR: EL CODIGO DEBE SER NUMERICO");
                    textBoxCodReco.Clear();
                    codigo_error = 1;
                }
            }

            if ((textBoxCodReco.Text == "") || (comboBoxCiuDestino.Text == "") || (comboBoxCiuOrigen.Text == "") || (comboBoxTipoServ.Text == ""))
            {
                MessageBox.Show("ERROR: Debe ingresar todos los campos obligatorios");
                codigo_error = 1;
            }

            if (comboBoxCiuOrigen.Text == comboBoxCiuDestino.Text)
            {
                MessageBox.Show("Error: La ciudad de origen y la ciudad de destino deben ser distintas");
                codigo_error = 1;
            }

            if (codigo_error == 1)
            {
                return;
            }

            //SE INGRESARON LOS CAMPOS CORRECTAMENTE, AHORA CONTROLAMOS CONTRA LA BASE DE DATOS

            connection conexion = new connection();

            DataTable tablaRecorridos = conexion.execute_query("SELECT 1 FROM DATACENTER.Recorrido WHERE reco_cod ="+"'"+textBoxCodReco.Text+"'");

            if (tablaRecorridos.Rows.Count == 1) // Se cumple cuando el codigo ingresado ya esta en la BD
            {
                MessageBox.Show("ERROR: EL CODIGO DE RECORRIDO QUE INGRESASTE YA EXISTE");
                limpiar();
                codigo_error = 1;
            }
            
            tablaRecorridos.Clear();
            tablaRecorridos = conexion.execute_query("SELECT 1 FROM DATACENTER.Recorrido WHERE reco_origen ="+"'"+comboBoxCiuOrigen.Text+"'"+" AND "+"reco_destino ="+"'"+comboBoxCiuDestino.Text+"'"+" AND "+"reco_serv_id ="+comboBoxTipoServ.SelectedValue);
            if (tablaRecorridos.Rows.Count == 1) // Se cumple cuando el recorrido ingresado ya esta en la BD
            {
                MessageBox.Show("ERROR: YA EXISTE ESTE RECORRIDO CON ESTE SERVICIO");
                limpiar();
                codigo_error = 1;
            }


            tablaRecorridos.Clear();
            string precioPas = numUpDownPrPas.Value.ToString();
            string precioPasConPunto = precioPas.Replace(",",".");
            tablaRecorridos = conexion.execute_query("SELECT 1 FROM DATACENTER.Recorrido WHERE reco_origen =" + "'" + comboBoxCiuOrigen.Text + "'" + " AND " + "reco_destino =" + "'" + comboBoxCiuDestino.Text + "'" + " AND " + "reco_serv_id <>" + comboBoxTipoServ.SelectedValue + " AND " + "reco_precio_base_pasaje =" + precioPasConPunto);
     
            if (tablaRecorridos.Rows.Count == 0) // Se cumple cuando hay un mismo recorrido en la BD, pero con otro tipo de servicio, y estos recorridos tienen distinto precio, cosa que no tiene que pasar
            {
                MessageBox.Show("ERROR: EL PRECIO BASE DEL PASAJE QUE INGRESASTE NO COINCIDE CON EL PRECIO QUE ESTA ESTABLECIDO PARA EL PAR ORIGEN-DESTINO ELEGIDOS");
                //limpiar();
                codigo_error = 1;
            }


            tablaRecorridos.Clear();
            string precioEnco = numUpDownPrPas.Value.ToString();
            string precioEncoConPunto = precioEnco.Replace(",", ".");
            tablaRecorridos = conexion.execute_query("SELECT 1 FROM DATACENTER.Recorrido WHERE reco_origen =" + "'" + comboBoxCiuOrigen.Text + "'" + " AND " + "reco_destino =" + "'" + comboBoxCiuDestino.Text + "'" + " AND " + "reco_serv_id <>" + comboBoxTipoServ.SelectedValue + " AND " + "reco_precio_base_Kg =" + precioEncoConPunto);

            if (tablaRecorridos.Rows.Count == 0) // Se cumple cuando hay un mismo recorrido en la BD, pero con otro tipo de servicio, y estos recorridos tienen distinto precio, cosa que no tiene que pasar
            {
                MessageBox.Show("ERROR: EL PRECIO BASE DE KG QUE INGRESASTE NO COINCIDE CON EL PRECIO QUE ESTA ESTABLECIDO PARA EL PAR ORIGEN-DESTINO ELEGIDOS");
                //limpiar();
                codigo_error = 1;
            }

            if (codigo_error == 1)
            {
                return;
            }
            else // Paso todas las restricciones, se puede insertar.
            {
                string cod_ins = textBoxCodReco.Text.ToString();
                string orig_ins = comboBoxCiuOrigen.Text.ToString();
                string dest_ins = comboBoxCiuDestino.Text.ToString();
                int serv_ins = (int)comboBoxTipoServ.SelectedValue;
                decimal pr_pas_ins = numUpDownPrPas.Value;
                decimal pr_enco_ins = numUpDownPrEnco.Value;
                stored_procedures procedure = new stored_procedures();
                procedure.insert_recorrido(cod_ins,orig_ins,dest_ins,serv_ins,pr_pas_ins,pr_enco_ins);
                MessageBox.Show("¡RECORRIDO AGREGADO CORRECTAMENTE!");
                limpiar();
                return;
            }
        }

        private void Abm_Reco_Alta_Load(object sender, EventArgs e)
        {
            connection conexion = new connection();
            

            string query1 = "SELECT ciu_nombre FROM DATACENTER.Ciudad";
            DataTable tabla_origenes = conexion.execute_query(query1);
            comboBoxCiuOrigen.DataSource = tabla_origenes;
            comboBoxCiuOrigen.DisplayMember = "ciu_nombre";
            comboBoxCiuOrigen.ValueMember = "ciu_nombre";


            string query2 = "SELECT ciu_nombre FROM DATACENTER.Ciudad";
            DataTable tabla_destinos = conexion.execute_query(query2);
            comboBoxCiuDestino.DataSource = tabla_destinos;
            comboBoxCiuDestino.DisplayMember = "ciu_nombre";
            comboBoxCiuDestino.ValueMember = "ciu_nombre";


            string query3 = "SELECT serv_tipo, serv_id FROM DATACENTER.Servicio";
            DataTable tabla_servicios = conexion.execute_query(query3);
            comboBoxTipoServ.DataSource = tabla_servicios;
            comboBoxTipoServ.DisplayMember = "serv_tipo";
            comboBoxTipoServ.ValueMember = "serv_id";
        }






    }
}
