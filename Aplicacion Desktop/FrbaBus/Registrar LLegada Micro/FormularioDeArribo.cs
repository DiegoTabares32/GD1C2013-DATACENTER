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
        private funciones funciones;

        public FormularioDeArribo()
        {
            InitializeComponent();
            this.funciones = new funciones();    
        }

        private void FormularioDeArribo_Load(object sender, EventArgs e)
        {
            //Limpiamos todo
            this.dateTimePicker1.ResetText();
            
            this.textBoxPatente.Clear();
            //para que no puedan ingresar texto
            this.comboBoxArribo.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            this.hora.DropDownStyle = ComboBoxStyle.DropDownList;
            this.minutos.DropDownStyle = ComboBoxStyle.DropDownList;
            //cargo el combobox de hora con el rango 0 a 23
            List<int> cadenaHora = new List<int>();
            for (int i = 0; i<24; i++)
            {
                cadenaHora.Add(i);
            }
            this.hora.DataSource = cadenaHora; 
            //cargo el combobox de minutos con el rango de 0 a 59
            List<int> cadenaMinutos = new List<int>();
            for (int i = 0; i < 60; i++)
            {
                cadenaMinutos.Add(i);
            }
            this.minutos.DataSource = cadenaMinutos;

            this.hora.ResetText();
            this.minutos.ResetText();

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
            //Validaciones                               
            
            if (textBoxPatente.Text == "")
            {
                MessageBox.Show("Debe ingresar una Patente");
                return;
            }

            char[] caracter = textBoxPatente.Text.ToCharArray();
            int i;
            if (caracter.Length != 6)
            {
                MessageBox.Show("Patente ingresada incorrecta. Se espera que sea de tipo LLLNNN");
                return;
            }
            for (i = 0; i < 3; i++)
            {
                if (Char.IsDigit(caracter.ElementAt(i)))
                {
                    MessageBox.Show("Patente ingresada incorrecta. Se espera que sea de tipo LLLNNN");
                    return;
                }
            }
            for (i = 3; i < 6; i++)
            {
                if (Char.IsLetter(caracter.ElementAt(i)))
                {
                    MessageBox.Show("Patente ingresada incorrecta. Se espera que sea de tipo LLLNNN");
                    return;
                }
            }

            //preparar patente para poder registrar nuevo micro
            string primerPartePatente = textBoxPatente.Text.Substring(0, 3);
            string segundaPartePatente = textBoxPatente.Text.Substring(3, 3);
            string nroPatente = primerPartePatente + "-" + segundaPartePatente;

            if (!funciones.existePatente(nroPatente))
            {
                MessageBox.Show("La patente ingresada no existe en la Base de Datos");
                return;
            }
            if (comboBoxOrigen.Text.Equals(comboBoxArribo.Text))
            {
                MessageBox.Show("La Ciudad de Origen no puede coincidir con la Ciudad de Arribo!");
                return;
            }
            //LLENO UNA TABLA CON EL RESULTADO DE LOS VALORES INGRESADOS Y 
            //LOS AGREGO EN LA DATAGRID DE REGISTRO LLEGADA MICRO
            string fechayhora = dateTimePicker1.Text + " " + hora.Text +':'+ minutos.Text;
            string patente = textBoxPatente.Text;
            string origen = comboBoxOrigen.Text;
            string destino = comboBoxArribo.Text;
            //ACA PIDO LA INFORMACION DEL MICRO
            string query1 = "select m.mic_nro as 'N° Micro', m.mic_patente as 'Patente', s.serv_tipo as 'Servicio', m.mic_modelo as 'Modelo', ma.marc_nombre as 'Marca', m.mic_fecha_alta as 'Fecha de alta', m.mic_cant_kg_disponibles as 'Capacidad (Kg)', m.mic_cant_butacas as 'Cantidad de Butacas' from DATACENTER.Micro m join DATACENTER.Servicio s on s.serv_id = m.mic_serv_id join DATACENTER.Marca ma on ma.marc_id = m.mic_marc_id where m.mic_patente = '" + nroPatente + "'";
            //VOY CARGARDO LOS REGISTROS INSERTADOS EN UNA TABLA PARA DESPUES INSETARLOS EN ARRIBO
            connection conexion = new connection();
            string querySeleccionViajeId = "select v.viaj_id from DATACENTER.Recorrido r join DATACENTER.Viaje v on v.viaj_reco_cod = r.reco_cod and r.reco_origen = '" + comboBoxOrigen.Text + "' and v.viaj_mic_patente = '" + nroPatente + "' where DATEDIFF(HH, v.viaj_fecha_salida, '" + fechayhora + "' ) BETWEEN 0 AND 24";
            DataTable resultadoSeleccionViajeId = conexion.execute_query(querySeleccionViajeId);
            if(resultadoSeleccionViajeId.Rows.Count != 1)
            {
                MessageBox.Show("La Ciudad de Origen es incorrecta!");
                return;
            }
            string registroYaCargado = "select a.arri_viaj_id from DATACENTER.Arribo a where a.arri_viaj_id = " + resultadoSeleccionViajeId.Rows[0].ItemArray.ElementAt(0).ToString();
            if (conexion.execute_query(registroYaCargado).Rows.Count > 0)
            {
                MessageBox.Show("Este registro ya fue cargado en la base de datos");
                return;
            }
            string query = "insert into DATACENTER.arribosCargados values('" + fechayhora + "', '" + nroPatente + "', '" + origen + "', '" + destino + "' ," + resultadoSeleccionViajeId.Rows[0].ItemArray.ElementAt(0).ToString() + ")";

            conexion.execute_query(query);
            DataTable infoMicro = conexion.execute_query(query1);
            //VALIDO QUE LA CIUDAD DE DESTINO SEA LA MISMA A LA QUE LLEGO
            string query2 = "select r.reco_destino from DATACENTER.Recorrido r join DATACENTER.Viaje v on v.viaj_reco_cod = r.reco_cod and r.reco_origen = '" + comboBoxOrigen.Text + "'and r.reco_destino = '" + comboBoxArribo.Text + "' and v.viaj_mic_patente = '" + nroPatente + "' where DATEDIFF(HH, v.viaj_fecha_salida, '" + fechayhora + "' ) BETWEEN 0 AND 24";
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
            this.FormularioDeArribo_Load(sender, e);
        }

        private void textBoxPatente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan letras 
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsDigit(e.KeyChar)) //permitir teclas de control como retroceso 
                {
                    e.Handled = false;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar))
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
}
