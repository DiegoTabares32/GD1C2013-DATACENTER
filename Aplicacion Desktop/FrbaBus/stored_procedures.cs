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
            query = "EXECUTE DATACENTER.get_listado_viaje '" + ciu_origen + "','" + ciu_destino + "','" + fecha_salida + "'";
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

        public void update_Cliente(string cli_dni, string cli_nombre, string cli_apellido, string cli_dir, string cli_telefono, string cli_mail, string cli_fecha_nac, string cli_sexo, string cli_discapacitado, string condicion)
        {
            query = "EXECUTE DATACENTER.update_Cliente " + cli_dni + ",'" + cli_nombre + "','" + cli_apellido + "','" + cli_dir + "','" + cli_telefono + "','" + cli_mail + "','" + cli_fecha_nac + "','" + cli_sexo + "','" + cli_discapacitado + "','" + condicion + "'";
            connect.execute_query_only(query);
        }

        public void insert_Cliente(string cli_dni, string cli_nombre, string cli_apellido, string cli_dir, string cli_telefono, string cli_mail, string cli_fecha_nac, string cli_sexo, string cli_discapacitado, string condicion)
        {
            query = "EXECUTE DATACENTER.insert_Cliente " + cli_dni + ",'" + cli_nombre + "','" + cli_apellido + "','" + cli_dir + "','" + cli_telefono + "','" + cli_mail + "','" + cli_fecha_nac + "','" + cli_sexo + "','" + cli_discapacitado + "','"+condicion+"'";
            connect.execute_query_only(query);
        }

        public decimal get_porcentaje(string viaj_id)
        {
            connection conexion = new connection();
            string query = " EXECUTE DATACENTER.get_porcentaje " + viaj_id;
            DataTable tabl_porc = conexion.execute_query(query);
            return Convert.ToDecimal(tabl_porc.Rows[0].ItemArray[0].ToString());
        }

        public string get_costo_encomienda(string viaj_id, string paq_kg)
        {
            connection conexion = new connection();
            string query = " EXECUTE DATACENTER.get_costo_encomienda " + viaj_id+","+paq_kg;
            DataTable tabl_porc = conexion.execute_query(query);
            return tabl_porc.Rows[0].ItemArray[0].ToString();
        }

        public int get_kg_disponibles(string viaj_id)
        {
            connection conexion = new connection();
            string query = "EXECUTE DATACENTER.get_kg_disponibles " + viaj_id;
            DataTable tabl_kg_disp = conexion.execute_query(query);
            return Convert.ToInt16(tabl_kg_disp.Rows[0].ItemArray[0].ToString());
        }

        public char check_tipo_tarjeta(string tipo_id)
        {
            connection conexion = new connection();
            string query = "EXECUTE DATACENTER.check_tipo_tarjeta " + tipo_id;
            DataTable tabl_tip_tarj = conexion.execute_query(query);
            return Convert.ToChar(tabl_tip_tarj.Rows[0].ItemArray[0].ToString());
        }

        public string insert_compra(string comprador_dni, string tipo_tarj_id, string cant_pasajes, string cant_total_kg, decimal costo_total, DateTime fecha_actual)
        {
            connection connect = new connection();
            SqlConnection conexion = connect.connector();
            string query = "EXECUTE DATACENTER.insert_compra @comprador_dni, @tipo_tarj_id, @cant_pasajes, @cant_total_kg, @costo_total, @fecha_actual";
            
            SqlCommand comando = new SqlCommand(query, conexion); 
            comando.Parameters.AddWithValue("@comprador_dni", comprador_dni);
            comando.Parameters.AddWithValue("@tipo_tarj_id", tipo_tarj_id);
            comando.Parameters.AddWithValue("@cant_pasajes", cant_pasajes);
            comando.Parameters.AddWithValue("@cant_total_kg", cant_total_kg);
            comando.Parameters.AddWithValue("@costo_total", costo_total);
            comando.Parameters.AddWithValue("@fecha_actual", fecha_actual);
            string cod_compra =comando.ExecuteScalar().ToString();
            conexion.Close();
            return cod_compra;
        }

        public string insert_pasaje(string nro_butaca, string micro_patente, string cli_dni, string pas_compra, decimal pas_precio, string viaj_id)
        {
            connection connect = new connection();
            SqlConnection conexion = connect.connector();
            string query = "EXECUTE DATACENTER.insert_pasaje @nro_butaca, @micro_patente, @cli_dni, @pas_compra, @pas_precio, @viaj_id";

            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@nro_butaca", nro_butaca);
            comando.Parameters.AddWithValue("@micro_patente", micro_patente);
            comando.Parameters.AddWithValue("@cli_dni", cli_dni);
            comando.Parameters.AddWithValue("@pas_compra", pas_compra);
            comando.Parameters.AddWithValue("@pas_precio", pas_precio);
            comando.Parameters.AddWithValue("@viaj_id", viaj_id);
            string cod_pasaje = comando.ExecuteScalar().ToString();
            conexion.Close();
            return cod_pasaje;
        }

        public string get_micro_patente(string viaje_id)
        {
            connection conexion = new connection();
            string query = "EXECUTE DATACENTER.get_micro_patente " + viaje_id;
            DataTable tabl_mic_pat = conexion.execute_query(query);
            return tabl_mic_pat.Rows[0].ItemArray[0].ToString();
        }

        public string insert_paquete(string comp_id, decimal precio, string paq_kg, string viaj_id)
        {
            connection connect = new connection();
            SqlConnection conexion = connect.connector();
            string query = "EXECUTE DATACENTER.insert_paquete @comp_id, @precio, @paq_kg, @viaj_id";

            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@comp_id", comp_id);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@paq_kg", paq_kg);
            comando.Parameters.AddWithValue("@viaj_id", viaj_id);
            string cod_paquete = comando.ExecuteScalar().ToString();
            conexion.Close();
            return cod_paquete;
        }

        /*-----------------------------CAMBIADO----------------------------*/
        public void insert_recorrido(string cod_ins, string orig_ins, string dest_ins, int serv_ins, decimal pr_pas_ins, decimal pr_enco_ins)
        {
            connection conexion = new connection();

            string precioPas = pr_pas_ins.ToString();
            string precioPasConPunto = precioPas.Replace(",", ".");
            string precioEnco = pr_enco_ins.ToString();
            string precioEncoConPunto = precioPas.Replace(",", ".");

            query = "EXECUTE DATACENTER.insert_recorrido " + "'" + cod_ins + "'" + ", " + "'" + orig_ins + "'" + ", " + "'" + dest_ins + "'" + ", " + serv_ins + ", " + precioPasConPunto + ", " + precioEncoConPunto;
            conexion.execute_query_only(query);
        }

        /*-----------------------------CAMBIADO-----------------------------*/
        public void insert_viaje(string fecha_sal, string fecha_lleg, string cod_reco_ins, string pat_mic_ins)
        {
            connection conexion = new connection();

            query = "EXECUTE DATACENTER.insert_viaje " + "'" + fecha_sal + "'" + ", " + "'" + fecha_lleg + "'" + ", " + "'" + cod_reco_ins + "'" + ", " + "'" + pat_mic_ins + "'";
            conexion.execute_query_only(query);
        }

        /*---------------------------CAMBIADO--------------------------*/
        public void update_recorrido(string cod_act, string orig_act, string dest_act, int serv_act, decimal pr_pas_act, decimal pr_enco_act)
        {
            connection conexion = new connection();

            string precioPas = pr_pas_act.ToString();
            string precioPasConPunto = precioPas.Replace(",", ".");
            string precioEnco = pr_enco_act.ToString();
            string precioEncoConPunto = precioEnco.Replace(",", ".");
            query = "EXECUTE DATACENTER.update_recorrido " + "'" + cod_act + "'" + ", " + "'" + orig_act + "'" + ", " + "'" + dest_act + "'" + ", " + serv_act + ", " + "'" + precioPasConPunto + "'" + ", " + "'" + precioEncoConPunto + "'";
            conexion.execute_query_only(query);
        }

        public void update_estado_reco(string cod, char estado_act)
        {
            connection conexion = new connection();

            string fecha_hoy = System.Configuration.ConfigurationSettings.AppSettings["FechaDelSistema"].ToString();
            DateTime fecha_hoy2 = Convert.ToDateTime(fecha_hoy);
            string fecha = fecha_hoy2.ToString("yyyy-MM-dd HH:mm");

            query = "EXECUTE DATACENTER.update_estado_reco " + "'" + cod + "'" + ", " + "'" + estado_act + "'" + ", " + "'" + fecha + "'";
            conexion.execute_query_only(query);
        }

        public void habilitar_estado_reco(string cod, char estado_act)
        {
            connection conexion = new connection();
            query = "EXECUTE DATACENTER.habilitar_estado_reco " + "'" + cod + "'" + ", " + "'" + estado_act + "'";
            conexion.execute_query_only(query);
        }

        public void update_fecha_alta_micro(string fecha_alta)
        {
            connection conexion = new connection();
            string query = "EXECUTE DATACENTER.update_fecha_alta_micro '"+fecha_alta+"'";
            conexion.execute_query(query);
            
        }

    }
}
