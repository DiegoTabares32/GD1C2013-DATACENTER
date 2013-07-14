using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.Login;

namespace FrbaBus.Compra_de_Pasajes
{
    public partial class FormCompra : Form
    {
        //Atributos

        public string cod_viaje="";

        //Colección de Pasajes una vez confirmada la compra los cargamos en la base
        List<cargar_pasajero> listas_pasajeros = new List<cargar_pasajero>();

        public FormCompra()
        {
            InitializeComponent();
            this.fecha_tbox.Enabled = false;
        }

        private void login_boton_Click(object sender, EventArgs e)
        {
            //cuando un administrador hace click en login se le abre la
            //pantalla de login
            login login = new login();
            login.ShowDialog();
        }

        private void select_boton_Click(object sender, EventArgs e)
        {
            select_fecha_viaje select_viaje = new select_fecha_viaje(this);
            select_viaje.ShowDialog();
        }

        private void FormCompra_Load(object sender, EventArgs e)
        {
            string query = "SELECT ciu_nombre FROM DATACENTER.Ciudad";
            connection conexion = new connection();
            DataTable table_ciu_orig= conexion.execute_query(query);
            DataTable table_ciu_dest = conexion.execute_query(query);
            
            //Cargo ciudades de Origen
            this.ciu_orig_list.DataSource = table_ciu_orig;
            this.ciu_orig_list.DisplayMember = "ciu_nombre";
            this.ciu_orig_list.ValueMember = "ciu_nombre";

            //Cargo ciudades Destino
            this.ciu_dest_list.DataSource = table_ciu_dest;
            this.ciu_dest_list.DisplayMember = "ciu_nombre";
            this.ciu_dest_list.ValueMember = "ciu_nombre";


        }

        private void busc_viaje_boton_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (this.fecha_tbox.Text == "")
            {
                MessageBox.Show("Debe Seleccionar Fecha", "Comprar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }

            if (error)
                return;

            select_viaje seleccionar_viaje = new select_viaje(this);
            seleccionar_viaje.ShowDialog();
        }

        private void cargar_pas_boton_Click(object sender, EventArgs e)
        {
            bool error = false;

            if (this.cod_viaje == "")
            {
                MessageBox.Show("Debe Seleccionar Viaje", "Comprar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }

            if (error)
                return;

            int cant_pasajes = Convert.ToInt16(this.CantPasaj_numericUpDown.Value);
            int i;

            //cargamos los datos de los pasajeros
            select_viaje form_viaje = new select_viaje(this);
            for (i = 0; i < cant_pasajes; i++)
            {
                cargar_pasajero form_cargar_pas = new cargar_pasajero(this.cod_viaje, listas_pasajeros);
                form_cargar_pas.ShowDialog();
                listas_pasajeros.Add(form_cargar_pas);
                if (cant_pasajes - 1 != i)
                {
                    MessageBox.Show("Datos del Pasajero Ingresados, A continuación debe seleccionar viaje del siguiente Pasajero", "Comprar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    form_viaje.ShowDialog();
                }
                

            }
            stored_procedures stored_proc = new stored_procedures();
            Single sub_total_compra_pasaj = 0;
            foreach (cargar_pasajero pasaje in listas_pasajeros)
            {
                sub_total_compra_pasaj += Convert.ToSingle(stored_proc.get_porcentaje(pasaje.viaje_cod));
            }
            this.sub_total_pasaj_tbox.Text = sub_total_compra_pasaj.ToString();
        }

        private void NroPasaj_numericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo permite q ingrese numeros
            if (char.IsNumber(e.KeyChar) | char.IsControl(e.KeyChar) )
                e.Handled = false;
            else
                e.Handled = true;
        }



 
     
    }
}
