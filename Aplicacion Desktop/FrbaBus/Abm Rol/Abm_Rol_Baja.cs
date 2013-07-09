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
    public partial class Abm_Rol_Baja : Form
    {
        public Abm_Rol_Baja()
        {
            InitializeComponent();
        }

        
        private void cleanning_boton_Click(object sender, EventArgs e)
        {
            this.rol_a_buscarTB.Text = "";
            this.roles_elim_dataGrid.DataSource= null;
        }

        private void buscar_boton_Click(object sender, EventArgs e)
        {
            if (this.rol_a_buscarTB.Text == "")
            {
                MessageBox.Show("Debe ingresar un Rol", "Baja de Rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //buscamos Patron
            string query = "SELECT rol_id AS ID, rol_nombre AS Nombre, rol_estado AS Estado FROM DATACENTER.Rol WHERE rol_nombre like '" + this.rol_a_buscarTB.Text + "%'";
            connection connect = new connection();
            DataTable tabla_func = connect.execute_query(query);
            //cargamos el data_grid con el resultado de la busqueda
            this.roles_elim_dataGrid.DataSource = tabla_func;
        }

        private void roles_elim_dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //verificamos que el evento lo haya disparado el boton
            if (e.ColumnIndex == 0)//
            {   //currentRow obtiene la fila que contiene a la celda en la cual se clickeo 
                string id_a_eliminar = this.roles_elim_dataGrid.CurrentRow.Cells[1].Value.ToString();
                stored_procedures stored_proc = new stored_procedures();
                stored_proc.delete_Rol(id_a_eliminar);
                MessageBox.Show("Rol Eliminado Correctamente", "Baja de Rol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.rol_a_buscarTB.Text = "";
                this.roles_elim_dataGrid.DataSource = null;
            }
           
        }
    }
}
