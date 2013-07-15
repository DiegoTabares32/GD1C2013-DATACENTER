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
        FormCompra compra_form;

        public select_viaje(FormCompra form_compra)
        {
            InitializeComponent();
            this.compra_form = form_compra;
        }

        private void select_viaje_Load(object sender, EventArgs e)
        {
            stored_procedures stored_prod = new stored_procedures();
            DataTable listado_viaje = stored_prod.get_listado_viaje(this.compra_form.ciu_orig_list.Text, this.compra_form.ciu_dest_list.Text, this.compra_form.fecha_tbox.Text);
            this.viajes_dataGrid.DataSource = listado_viaje;
        }

        private void viajes_dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (this.compra_form.tipo_viaje=='P')
                    this.compra_form.cod_viaje_pasaje= this.viajes_dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                else
                    this.compra_form.cod_viaje_encomienda= this.viajes_dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.Close();
            }
        }
    }
}
