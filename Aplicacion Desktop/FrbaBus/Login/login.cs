using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace FrbaBus.Login
{
    public partial class login : Form
    {
        /*-------ATRIBUTOS------------------*/
        int cant_fallidas;
        stored_procedures procedure = new stored_procedures();
        /*----------------------------------*/
        public login()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            this.username_textbox.Text = "";
            this.passw_textbox.Text = "";
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            /*-----Controlamos que no halla textBoxs en blanco*/
            
            bool error = false;

            if (this.username_textbox.Text == "" )
            {
                MessageBox.Show("Debe Ingresar username", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
                
            }
            
            if (this.passw_textbox.Text == "")
            {
                MessageBox.Show("Debe Ingresar password", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }

            if (error)
            {
                this.limpiar();
                return;
            }
                
            
            /*------------------------------------------------*/
            //el administrador ingreso usuario y contraseña 
            connection conexion = new connection();


            DataTable administrador = conexion.execute_query("SELECT usu_username, usu_password, usu_cant_intentos, rol_estado, rol_id FROM DATACENTER.Usuario  JOIN DATACENTER.Rol  ON (usu_rol_id=rol_id) WHERE usu_username= " + "'" + username_textbox.Text + "'");
            
            
            if (administrador.Rows.Count == 1)
            {
                //verificamos que el Rol administrador NO este inhabilitado
                if (administrador.Rows[0].ItemArray[3].ToString() != "H")
                {
                    MessageBox.Show("Rol  Inhabilitado", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //existe el usuario sino no me devolveria filas el select; entonces evaluamos la cant_intentos
                cant_fallidas = Convert.ToInt16(administrador.Rows[0].ItemArray[2].ToString());
                if ( cant_fallidas == 3)
                {
                    MessageBox.Show("Superada la cantidad Máxima de intentos por loguearse, Usuario Inhabilitado ", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.limpiar();
                    return;
                }
                
                //evaluamos si esta bien la contraseña

                funciones func = new funciones();
                if (func.get_hash(passw_textbox.Text) == administrador.Rows[0].ItemArray[1].ToString())
                {
                    //Row[n] siendo n nro de fila; itemArray[n] siendo n el nro de columna de la fila siendo n>=0

                    //limpiamos cant_intentos
                    cant_fallidas = 0;
                    procedure.update_cant_intentos_fallidos(username_textbox.Text, cant_fallidas);

                    

                    //abrimos el formulario de Funcionalides
                    string id_rol = administrador.Rows[0].ItemArray[4].ToString();
                    FormAdmin form_admin = new FormAdmin(id_rol);
                    form_admin.ShowDialog();

                    
                  
                }
                else
                {
                    cant_fallidas++;
                    //Se debe actualizar el campo adm_cant_intentos de la base de datos
                    procedure.update_cant_intentos_fallidos(username_textbox.Text, cant_fallidas);



                    MessageBox.Show("Password Incorrecto", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
            else
            { //NO EXISTE EL USERNAME entonces NO podemos descontar cant_intentos_fallidos

                MessageBox.Show("Username Incorrecto", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
            this.username_textbox.Text = "";
            this.passw_textbox.Text = "";
            return;
        }

    }
}
