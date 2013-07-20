using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;

namespace FrbaBus
{
    class connection
    {
        public SqlConnection connector()
        {
            SqlConnection connect = new SqlConnection();
            try
            {
                connect.ConnectionString = get_string_connection();
                connect.Open(); //abrimos conexion

            }
            catch (SqlException ex) //Capturamos algun error que pudo darse al querer conectarse
            {
                MessageBox.Show("Error al conectar con la base datos--" + ex.Message);

            }
            return connect;

        }

        public string get_string_connection()
        {
            //string string_connect = @"Data Source=localhost\SQLSERVER2008;Initial Catalog=GD1C2013;User ID=gd; PASSWORD=gd2013"; //va el @ porque sino tira un warning escape sequences con @se ignora
            //obtenemos la cadena de conexion del XML
            string connection_string = ConfigurationManager.ConnectionStrings["FrbaBusConnectionString"].ToString();
            return connection_string;;
        }

        public DataTable execute_query(string query)
        {
            //creamos Data_Adapter que es un adaptador/interfaz que nos permite interactuar entre 
            //nuestra base_local dataset/datatable y la la base de datos del sql server
            //el data_adapter se encargara de llevar a cabo las consultas a la DB sql_Server

            SqlDataAdapter data_adapter = new SqlDataAdapter(query, this.get_string_connection());
            
            //volcamos la informacion resultado de ejecutar la consulta en un data table
            DataTable tabla=new DataTable();
            tabla.Locale = System.Globalization.CultureInfo.InvariantCulture;
            try
            {
                data_adapter.Fill(tabla);
            }
            catch (SqlException)
            {
                MessageBox.Show("Error al llenar el DataTable");
            }
            return tabla;
            
        }

        public void execute_query_only(string query)
        {
            SqlConnection conexion = this.connector();
            SqlCommand comando = new SqlCommand(query,conexion); //sqlcommand almacena una instruccion sql que luego ejecutar executenonquery
            int cant_filas_afectadas = comando.ExecuteNonQuery(); //ejecuta la query y devuelve filas afectadas 
            if (cant_filas_afectadas == 0)
            {
                MessageBox.Show("Fallo operacion al tratar de modificar la BD");
            }
            conexion.Close();
        }



        

    }


}
