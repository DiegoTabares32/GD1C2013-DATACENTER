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
        public int cant_butacas_disponibles;


        public select_viaje(FormCompra form_compra)
        {
            InitializeComponent();
            this.compra_form = form_compra;
        }

        private void select_viaje_Load(object sender, EventArgs e)
        {
            stored_procedures stored_prod = new stored_procedures();
            MessageBox.Show(this.compra_form.fechaViajeDateTimeP.Text);
            DataTable listado_viaje = stored_prod.get_listado_viaje(this.compra_form.ciu_orig_list.Text, this.compra_form.ciu_dest_list.Text, this.compra_form.fechaViajeDateTimeP.Text);
            
            /*-----------ACTUALIZAMOS KG A MOSTRAR--------------------------------------------*/
            int cant_kg_enBD = 0;
            foreach (Form_encomienda encomienda in this.compra_form.listas_encomiendas)
            {
                foreach (DataRow fila_encomienda in listado_viaje.Rows)
                {
                    if (fila_encomienda.ItemArray[0].ToString() == encomienda.viaje_cod)
                    {
                        cant_kg_enBD = Convert.ToInt16(fila_encomienda.ItemArray[6].ToString());
                        cant_kg_enBD = cant_kg_enBD - Convert.ToInt16(encomienda.peso_encom_tbox.Text);
                        fila_encomienda[6] = cant_kg_enBD.ToString();
                        continue; 
                    }
                }
            }
            /*-----------------------ACTUALIZAMOS BUTACAS A MOSTRAR---------------------------*/
            int cant_butacas_enBD = 0;
            foreach (cargar_pasajero pasajero in this.compra_form.listas_pasajeros)
            {
                foreach (DataRow fila_pasaje in listado_viaje.Rows)
                {
                    if (fila_pasaje.ItemArray[0].ToString() == pasajero.viaje_cod)
                    {
                        cant_butacas_enBD = Convert.ToInt16(fila_pasaje.ItemArray[5].ToString());
                        cant_butacas_enBD = cant_butacas_enBD - 1;
                        fila_pasaje[5] = cant_butacas_enBD.ToString();

                    }
                }
            }
            /*-------------------------------------------------------------------------------*/

            this.viajes_dataGrid.DataSource = listado_viaje;
            //inicializo codigo de viaje para utilizarse en una compra de pasajes
            this.compra_form.cod_viaje_pasaje = "";
            this.compra_form.cod_viaje_encomienda = "";
        }

        private void viajes_dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                 
                //evaluo si el viaje a seleccionar trata de un viaje o encomienda
                if (this.compra_form.tipo_viaje == 'P')
                {
                    //evaluo que tenga butacas disponibles
                    cant_butacas_disponibles = Convert.ToInt16(this.viajes_dataGrid.Rows[e.RowIndex].Cells[6].Value.ToString());

                    if (cant_butacas_disponibles > 0)
                    {
                        this.compra_form.cod_viaje_pasaje = this.viajes_dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                    }
                    else
                    {
                        MessageBox.Show("El viaje que desea seleccionar esta completo por favor seleccione otro", "Selección de Viaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                else
                {
                    int cant_kg_disponibles = Convert.ToInt16(this.viajes_dataGrid.Rows[e.RowIndex].Cells[7].Value.ToString());

                    if (cant_kg_disponibles > 0)
                        this.compra_form.cod_viaje_encomienda = this.viajes_dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                    else
                    {
                        MessageBox.Show("El viaje que desea seleccionar NO tiene mas espacio disponible para el envio de encomiendas", "Selección de Viaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                }
                this.Close();
            }
        }

    }
}
