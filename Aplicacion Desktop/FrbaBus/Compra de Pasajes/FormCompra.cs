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

        public string cod_viaje;

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
            select_viaje seleccionar_viaje = new select_viaje(this);
            seleccionar_viaje.ShowDialog();
        }

        private void cargar_pas_boton_Click(object sender, EventArgs e)
        {
            cargar_pasajero form_cargar_pas = new cargar_pasajero(this.cod_viaje);
            form_cargar_pas.ShowDialog();
        }



 
     
    }
}
