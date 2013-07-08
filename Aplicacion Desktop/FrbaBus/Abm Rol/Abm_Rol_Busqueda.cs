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

        private void buscar_boton_Click(object sender, EventArgs e)
        {

            if (rol_a_buscarTBox.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Rol ");
                return;
            }

            //buscamos Patron
            string query = "SELECT rol_id AS ID, rol_nombre AS Nombre, rol_estado AS Estado FROM DATACENTER.Rol WHERE rol_nombre like '"+rol_a_buscarTBox.Text+"%'";
            connection connect = new connection();
            DataTable tabla_func = connect.execute_query(query);
            //cargamos el data_grid con el resultado de la busqueda
            this.roles_dataGrid.DataSource = tabla_func;
        }

        private void roles_dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //currentRow obtiene la fila que contiene a la fila tildada
            Abm_Rol_Modif abm_rol_mod = new Abm_Rol_Modif();
            abm_rol_mod.id_rol_a_mod = this.roles_dataGrid.CurrentRow.Cells[1].Value.ToString();
            abm_rol_mod.rol_nomb_mod= this.roles_dataGrid.CurrentRow.Cells[2].Value.ToString();
            abm_rol_mod.ShowDialog();
            
        }

        private void limpiar_boton_Click(object sender, EventArgs e)
        {
            this.rol_a_buscarTBox.Clear();
            this.roles_dataGrid.DataSource = null;
        }


    }
}
