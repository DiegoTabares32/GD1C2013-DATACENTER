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
    public partial class Abm_Rol_Alta : Form
    {

        funciones func = new funciones();
        stored_procedures procedure = new stored_procedures();

        public Abm_Rol_Alta()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            //refresca la pantalla 
            this.name_rol.Clear();

            //destildamos las opciones que estaban marcadas
            int i;
            for (i = 0; i < (this.list_funcionalidades.Items.Count); i++)
            {
                this.list_funcionalidades.SetItemChecked(i, false);
            }
        }
        private void list_funcionalidades_Load(object sender, EventArgs e)
        {
            //consulta a ejecutar para mostrar todas las funcionalidades cargadas en el checkedlistbox
            string query = "SELECT func_id, func_nombre FROM DATACENTER.Funcionalidad";

            //instanciamos obj de la clase connection y le enviamos la query para que la ejecute
            connection connect = new connection();
            DataTable tabla_func = connect.execute_query(query);

            //el resultado de la query lo cargamos en un data table
            //DataSource es el origen de los datos en nuestro caso la tabla que alberga el resultado de la query
            list_funcionalidades.DataSource = tabla_func;

            //Displaymember es la columna de la tabla que se va a mostrar en nuestro caso hay una sola
            list_funcionalidades.DisplayMember = "func_nombre";

            //ValueMembermember es el valor que tiene el campo seleccionado en nuestro caso ponemos la PK
            list_funcionalidades.ValueMember = "func_id";
        }


        private void butt_Cleaning_Click(object sender, EventArgs e)
        {

            this.limpiar();
        }

        private void butt_add_Click(object sender, EventArgs e)
        {
            bool error = false;

            if (this.name_rol.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre de Rol","Alta de Rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }

            if (this.list_funcionalidades.CheckedIndices.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una funcionalidad", "Alta de Rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            
            //controlamos que el nombre de rol ingresado NO este en la base de datos
            if (func.existe_nombre_rol(name_rol.Text) == true)
            {
                MessageBox.Show("Nombre de Rol existente en la Base de Datos", "Alta de Rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }

            if (error)
            {
                this.limpiar();
                return;
            }

            procedure.insert_Rol(name_rol.Text);

            foreach (int indice_func in this.list_funcionalidades.CheckedIndices) //checkedIndices devuelve la coleccion de los indices activados
            {

                this.list_funcionalidades.SelectedIndex= indice_func; //establecemos que el elemento seleccionado posee el indice marcado correspondiente
                //selectValue retorna el value_member del item seleccionado (seleccionado != tildado)
                //insertamos las funcionalidades del nuevo rol
                procedure.insert_funcxrol(name_rol.Text, Convert.ToInt16(this.list_funcionalidades.SelectedValue.ToString()));
                
                
            }
            MessageBox.Show("Rol Insertado Correctamente", "Alta de Rol", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.limpiar();
        }



        private void name_rol_TextChanged(object sender, EventArgs e)
        {

        }

      

      

 
    }
}
