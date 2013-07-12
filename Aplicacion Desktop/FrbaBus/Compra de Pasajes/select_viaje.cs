using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaBus.Compra_de_Pasajes
{
    public partial class select_viaje : Form
    {
        string ciudad_origen;
        string ciudad_destino;
        string fecha_salida;

        public select_viaje(string ciu_orig, string ciu_dest, string fecha_salida)
        {
            InitializeComponent();
            this.ciudad_origen = ciu_orig;
            this.ciudad_destino = ciu_dest;
            this.fecha_salida = fecha_salida;
        }

        private void select_viaje_Load(object sender, EventArgs e)
        {
            stored_procedures stored_prod = new stored_procedures();
            DataTable listado_viaje = stored_prod.get_listado_viaje(this.ciudad_origen, this.ciudad_destino, this.fecha_salida);
            this.viajes_dataGrid.DataSource = listado_viaje;
        }
    }
}
