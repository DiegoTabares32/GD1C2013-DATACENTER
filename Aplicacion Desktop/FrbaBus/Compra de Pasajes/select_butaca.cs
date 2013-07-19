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
    public partial class select_butaca : Form
    {
        cargar_pasajero carg_pasajero;

        public select_butaca(cargar_pasajero form_pasajero)
        {
            InitializeComponent();
            this.carg_pasajero = form_pasajero;
            stored_procedures stored_proc = new stored_procedures();
            DataTable tabla_butacas = stored_proc.get_Butacas(form_pasajero.viaje_cod);
            
            /* Filtramos Butacas que fueron seleccionadas en la compra para que no las puedan seleccionar*/
            
            DataColumn[] columns = new DataColumn[1]; 
            columns[0] = tabla_butacas.Columns["Nro_Butaca"];
            tabla_butacas.PrimaryKey = columns; //seteamos PK del DTable pues Find encuentra filtrando por la PK

            foreach (cargar_pasajero pasajero in form_pasajero.listas_pasajeros)
            {
                if (pasajero.viaje_cod == this.carg_pasajero.viaje_cod)
                {
                    tabla_butacas.Rows.Remove(tabla_butacas.Rows.Find(pasajero.butNro_tbox.Text));
                }
            }
            this.butaca_dataGrid.DataSource = tabla_butacas;

            
        }

        private void butaca_dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                this.carg_pasajero.butNro_tbox.Text = this.butaca_dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.carg_pasajero.pos_but_tbox.Text = this.butaca_dataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.carg_pasajero.piso_tbox.Text = this.butaca_dataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.Close();

            }
        }
    }
}
