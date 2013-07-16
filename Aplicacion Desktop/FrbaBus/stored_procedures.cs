using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using FrbaBus.Compra_de_Pasajes;

namespace FrbaBus
{
    class stored_procedures
    {
        /*clase que tiene metodos que hacen de interfaz con los stored procedures que estan en la BD sql server*/
        
        //atributo
        connection connect = new connection();
        string query;

        public void update_cant_intentos_fallidos(string username, int cant_intentos)
        {
            
            query = "EXECUTE DATACENTER.update_cant_intentos_fallidos "+
                    "'"+username+"',"+
                    cant_intentos.ToString();

            connect.execute_query_only(query);
            

        }

        public void insert_Rol (string nombre_rol)
        {
            query = "EXECUTE DATACENTER.insert_Rol '" + nombre_rol + "'";

            connect.execute_query_only(query);
        }

        public void insert_funcxrol(string nombre_rol, int func_id)
        {
            //hallamos Id_Rol
            query = "SELECT rol_id FROM DATACENTER.Rol WHERE rol_nombre = '"+nombre_rol+"'";
            DataTable table_rol= connect.execute_query(query);
            string rol_id = table_rol.Rows[0].ItemArray[0].ToString();

            query = "EXECUTE DATACENTER.insert_funcxrol " + rol_id + ", " + func_id.ToString();
            connect.execute_query_only(query);

        }

        public void delete_funcxrol(string rol_id, string func_id)
        {
            query = "EXECUTE DATACENTER.delete_funcxrol " + rol_id + ", " + func_id;
            connect.execute_query_only(query);
        }

        public void update_rol(string rol_id, string rol_nombre, char rol_estado)
        {
            query = "EXECUTE DATACENTER.update_rol " + rol_id + ", '" + rol_nombre + "', '" + rol_estado + "'";
            connect.execute_query_only(query);
        }

        public DataTable get_listado_viaje(string ciu_origen, string ciu_destino, string fecha_salida)
        {
            query = "EXECUTE DATACENTER.get_listado_viaje '" + ciu_origen + "','" + ciu_destino + "','" + fecha_salida+"'";
            return connect.execute_query(query);
        }

        public DataTable cargar_campos_cliente(string dni)
        {
            query = "EXECUTE DATACENTER.cargar_campos_cliente " + dni;
            return connect.execute_query(query);
        }

        public DataTable get_Butacas(string cod_viaje)
        {
            query = "EXECUTE DATACENTER.get_Butacas " + cod_viaje;
            return connect.execute_query(query);
        }

        public void update_Cliente(string cli_dni, string cli_nombre, string cli_apellido, string cli_dir, string cli_telefono, string cli_mail, string cli_fecha_nac, string cli_sexo)
        {
            query = "EXECUTE DATACENTER.update_Cliente "+cli_dni+",'"+cli_nombre+"','"+cli_apellido+"','"+cli_dir+"','"+cli_telefono+"','"+cli_mail+"','"+cli_fecha_nac+"','"+cli_sexo+"'";
            connect.execute_query_only(query);
        }

        public void insert_Cliente(string cli_dni, string cli_nombre, string cli_apellido, string cli_dir, string cli_telefono, string cli_mail, string cli_fecha_nac, string cli_sexo)
        {
            query = "EXECUTE DATACENTER.insert_Cliente " + cli_dni + ",'" + cli_nombre + "','" + cli_apellido + "','" + cli_dir + "','" + cli_telefono + "','" + cli_mail + "','" + cli_fecha_nac + "','" + cli_sexo + "'";
            connect.execute_query_only(query);
        }

        public string get_porcentaje(string viaj_id)
        {
            connection conexion = new connection();
            string query = " EXECUTE DATACENTER.get_porcentaje " + viaj_id;
            DataTable tabl_porc = conexion.execute_query(query);
            return tabl_porc.Rows[0].ItemArray[0].ToString();
        }

        public string get_costo_encomienda(string viaj_id, string paq_kg)
        {
            connection conexion = new connection();
            string query = " EXECUTE DATACENTER.get_costo_encomienda " + viaj_id+","+paq_kg;
            DataTable tabl_porc = conexion.execute_query(query);
            return tabl_porc.Rows[0].ItemArray[0].ToString();
        }

        public Single get_kg_disponibles(string viaj_id)
        {
            connection conexion = new connection();
            string query = "EXECUTE DATACENTER.get_kg_disponibles " + viaj_id;
            DataTable tabl_porc = conexion.execute_query(query);
            return Convert.ToSingle(tabl_porc.Rows[0].ItemArray[0].ToString());
        }

        public char check_tipo_tarjeta(string tipo_id)
        {
            connection conexion = new connection();
            string query = "EXECUTE DATACENTER.check_tipo_tarjeta " + tipo_id;
            DataTable tabl_porc = conexion.execute_query(query);
            return Convert.ToChar(tabl_porc.Rows[0].ItemArray[0].ToString());
        }

        public string insert_compra(string comprador_dni, string tipo_tarj_id, string cant_pasajes, string cant_total_kg, decimal costo_total)
        {
            connection connect = new connection();
            SqlConnection conexion = connect.connector();
            string query= "EXECUTE DATACENTER.insert_compra @comprador_dni, @tipo_tarj_id, @cant_pasajes, @cant_total_kg, @costo_total";
            
            SqlCommand comando = new SqlCommand(query, conexion); 
            comando.Parameters.AddWithValue("@comprador_dni", comprador_dni);
            comando.Parameters.AddWithValue("@tipo_tarj_id", tipo_tarj_id);
            comando.Parameters.AddWithValue("@cant_pasajes", cant_pasajes);
            comando.Parameters.AddWithValue("@cant_total_kg", cant_total_kg);
            comando.Parameters.AddWithValue("@costo_total", costo_total);
            string cod_compra =comando.ExecuteScalar().ToString();
            conexion.Close();
            return cod_compra;
        }
    

    

    }
}
