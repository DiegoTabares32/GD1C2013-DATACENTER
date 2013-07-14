using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaBus.Abm_Rol
{
    public partial class Abm_Rol_Busqueda : Form
    {
        public Abm_Rol_Busqueda()
        {
            InitializeComponent();
            
        }
        private void limpiar()
        {
            this.rol_a_buscarTBox.Clear();
            this.roles_dataGrid.DataSource = null;
        }
        private void buscar_boton_Click(object sender, EventArgs e)
        {

            string seleccion = "SELECT rol_id AS ID, rol_nombre AS Nombre, rol_estado AS Estado";
            string desde = " FROM DATACENTER.Rol";
            string condicion = "";
            if (this.rol_a_buscarTBox.Text != "") condicion = " WHERE rol_nombre like '" + rol_a_buscarTBox.Text + "%'"; 
            //buscamos Patron
            string query = seleccion + desde + condicion;
            connection connect = new connection();
            DataTable tabla_func = connect.execute_query(query);
            //cargamos el data_grid con el resultado de la busqueda
            this.roles_dataGrid.DataSource = tabla_func;
        }

        private void roles_dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   //verificamos que el evento se haya producido en la columna que contiene el boton
            if (e.ColumnIndex == 0)
            {
                //currentRow obtiene la fila que contiene a la fila tildada
                Abm_Rol_Modif abm_rol_mod = new Abm_Rol_Modif();
                abm_rol_mod.id_rol_a_mod = this.roles_dataGrid.CurrentRow.Cells[1].Value.ToString();
                abm_rol_mod.rol_nomb_mod = this.roles_dataGrid.CurrentRow.Cells[2].Value.ToString();
                abm_rol_mod.ShowDialog();
                //cuando retorna de la modificacion refrescamos la pantalla
                this.Close();
            }
            
        }

        private void limpiar_boton_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }


    }
}
