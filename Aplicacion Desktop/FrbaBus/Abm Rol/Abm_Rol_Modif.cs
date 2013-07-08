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
        char estado_actual_rol;

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
                //this.rol_select_tbox.ReadOnly = true;
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
            int i;
            funciones func = new funciones();
            stored_procedures stored_proc = new stored_procedures(); 
            //this.Visible = false;
            for (i = 0; i < (this.list_funcionalidades.Items.Count); i++)
            {
                
                this.list_funcionalidades.SelectedIndex = i;
                if (this.list_funcionalidades.GetItemChecked(i))
                {
                    //consulto si la func la tnia ya el Rol
                    //si la tnia la dejo sino la agrego
                    if (!func.check_func_activa(this.id_rol_a_mod, this.list_funcionalidades.SelectedValue.ToString()))
                    {
                        stored_proc.insert_funcxrol(this.rol_nomb_mod, Convert.ToInt16(this.list_funcionalidades.SelectedValue.ToString())); 
                    }
                }
                else
                {
                    //consulto si la func la tnia ya el usuario
                    //si la tnia la elimino
                    if (func.check_func_activa(this.id_rol_a_mod, this.list_funcionalidades.SelectedValue.ToString()))
                    {
                        stored_proc.delete_funcxrol(this.id_rol_a_mod, this.list_funcionalidades.SelectedValue.ToString());
                    }
                }

                
            }

            if(this.estado_comboBox.SelectedIndex ==-1) //Devuelve -1 si no se ha seleccionado ninguna opcion del combo
            {
                MessageBox.Show("Actualizacion Exitosa");
                estado_actual_rol = func.get_estado_BD(id_rol_a_mod);
            }


            //this.Visible = true;
            //devuelve true si se realizaron cambios en el nombre o estado 
            if (func.check_cambio_nomb_est_rol(id_rol_a_mod, this.estado_actual_rol, this.rol_select_tbox.Text, this.rol_nomb_mod))
                stored_proc.update_rol(this.id_rol_a_mod, this.rol_select_tbox.Text, estado_actual_rol);

            MessageBox.Show("Actualizacion Exitosa");
            this.Close();
            
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

        private void estado_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (estado_comboBox.Text == "Habilitado")
            {
                this.estado_actual_rol = 'H';
            }
            else
            {
                this.estado_actual_rol = 'D';
            }
        }

 
          
   

            

        

       
    }
}
