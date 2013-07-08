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
    public partial class Abm_Rol_Modif : Form
    {

        /*-----------ATRIBUTOS--------------------*/
        public string rol_nomb_mod;
        public string id_rol_a_mod;

        /*----------------------------------------*/
        public Abm_Rol_Modif()
        {
            InitializeComponent();

            
        }

        private void list_funcionalidades_Load(object sender, EventArgs e)
        {
            if (this.rol_nomb_mod != null) //evaluamos si esta seteada la var rol_nombre
            {                               //esta seteada si ya se selecciono un rol a modificar
                this.rol_select_tbox.Text = this.rol_nomb_mod;
                this.rol_select_tbox.ReadOnly = true;
                this.select_boton.Enabled = false;

                //cargamos lista segun corresponde

                string query = "SELECT func_id, func_nombre FROM DATACENTER.Funcionalidad";
                connection connect = new connection();
                DataTable tabla_todas_func = connect.execute_query(query);
                list_funcionalidades.DataSource = tabla_todas_func;
                list_funcionalidades.DisplayMember = "func_nombre";
                list_funcionalidades.ValueMember = "func_id";

                //tildamos las funciones que ya tiene el rol

                int i;
                funciones func = new funciones();
                for (i = 0; i < (this.list_funcionalidades.Items.Count); i++)
                {
                     this.list_funcionalidades.SelectedIndex= i;
                     if(func.check_func_activa(this.id_rol_a_mod, this.list_funcionalidades.SelectedValue.ToString()))
                         this.list_funcionalidades.SetItemChecked(i, true);
                }

              
            }
            else
            {
                this.rol_select_tbox.Enabled = false;
            }

            
        }

        private void aplicar_boton_Click(object sender, EventArgs e)
        {

        }

        private void select_boton_Click(object sender, EventArgs e)
        {
           
            Abm_Rol_Busqueda buscar_rol = new Abm_Rol_Busqueda();
            buscar_rol.ShowDialog();
            this.Close();
            
            
            
        }

        private void rol_select_tbox_TextChanged(object sender, EventArgs e)
        {

        }

 
          
   

            

        

       
    }
}
