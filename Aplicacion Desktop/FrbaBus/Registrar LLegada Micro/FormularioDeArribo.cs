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
        private llegadaMicros llegadaMicros;

        public FormularioDeArribo(llegadaMicros llegada)
        {
            InitializeComponent();
            this.llegadaMicros = llegada;
        }

        private void FormularioDeArribo_Load(object sender, EventArgs e)
        {
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
            
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            //LLENO UNA TABLA CON EL RESULTADO DE LOS VALORES INGRESADOS Y 
            //LOS AGREGO EN LA DATAGRID DE REGISTRO LLEGADA MICRO
            this.llegadaMicros.agregarDatos();
        }
               
    }
}
