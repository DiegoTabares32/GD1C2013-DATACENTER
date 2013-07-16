using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace FrbaBus
{
    class funciones
    {
        public string get_hash(string pass_ingresada)
        {
            
                byte[] pass_hash;
                //convierto pass en un array de bytes para poder usarla en las funciones de encriptacion
                byte[] pass_en_bytes = Encoding.UTF8.GetBytes(pass_ingresada);
                SHA256 shaManag = new SHA256Managed();
                //calculamos valor hash de la contraseña
                pass_hash = shaManag.ComputeHash(pass_en_bytes);

                //convertimos hash en string
                StringBuilder pass_string = new StringBuilder();

                //concatenamos bytes
                for (int i = 0; i < pass_hash.Length; i++)
                    pass_string.Append(pass_hash[i].ToString("x2").ToLower()); //toLower me convierte todo a minuscula

                return pass_string.ToString();

        }

        public bool existe_nombre_rol (string nombre_rol_ingresado)
        {
            bool existe_rol;
            connection conexion = new connection();
            string query = "SELECT rol_id FROM DATACENTER.Rol WHERE rol_nombre='" + nombre_rol_ingresado + "'";
            DataTable table_rol =  conexion.execute_query(query);
            if (table_rol.Rows.Count > 0)
            {
                existe_rol = true;
            }
            else 
            {
                existe_rol = false;
            }
            return existe_rol;
        }

        public bool existeDni(DataTable tabla_puntos)
        {
            return tabla_puntos.Rows.Count > 0;
        }

        public bool existePatente(string patente)
        {
            connection conexion = new connection();
            string query = "SELECT m.mic_patente FROM DATACENTER.Micro m WHERE m.mic_patente = '"+patente+"'";
            DataTable tabla_patente = conexion.execute_query(query);
            return tabla_patente.Rows.Count > 0;
        }

        public DataTable consultarPuntos(string dni)
        {
            connection conexion = new connection();
            string query = "SELECT v.viaj_id AS 'Viaje ID', v.viaj_fecha_llegada AS 'Fecha Llegada', cast(round(isnull(p.pas_precio,0)/5,0) as numeric(18,0)) AS 'Puntos', DATACENTER.estado_puntos(A.arri_fecha_llegada, SYSDATETIME()) AS 'ESTADO' FROM DATACENTER.Arribo a join DATACENTER.Viaje v ON a.arri_viaj_id = v.viaj_id join DATACENTER.Pasaje p on p.pas_viaj_id = a.arri_viaj_id and p.pas_cli_dni = " + dni + " union all SELECT a.arri_viaj_id AS 'Viaje ID',  v.viaj_fecha_llegada AS 'Fecha Llegada', cast(round(isnull(p.paq_precio,0)/5,0) as numeric(18,0)) AS 'Puntos', DATACENTER.estado_puntos(A.arri_fecha_llegada, SYSDATETIME()) AS 'ESTADO' FROM DATACENTER.Paquete p join DATACENTER.Arribo a on a.arri_viaj_id = p.paq_viaj_id join DATACENTER.Compra c on c.comp_id = p.paq_comp_id and c.comp_comprador_dni = " + dni + " join DATACENTER.Viaje v on v.viaj_id = a.arri_viaj_id";
            return conexion.execute_query(query);
        }

        public string totalPuntosVencidos(string dni)
        {
            connection conexion = new connection();
            string query = "SELECT DATACENTER.totalPuntosVencidos("+dni+")";
            return conexion.execute_query(query).Rows[0].ItemArray.ElementAt(0).ToString();
        }

        public DataTable top5Clientes(string anio, string semestre)
        {
            string query = "select top 5 cli_dni as 'Cliente (DNI)', DATACENTER.puntosParaSemestre('" + anio + "'," + semestre + ",cli_dni) as 'Puntos acumulados en el semestre' from DATACENTER.Cliente where cli_dni in (select distinct p.pas_cli_dni from DATACENTER.Pasaje p join DATACENTER.Arribo a on a.arri_viaj_id = p.pas_viaj_id and a.arri_fecha_llegada between DATACENTER.fechaInicioSemestre('" + anio + "'," + semestre + ") and DATACENTER.fechaFinSemestre('" + anio + "'," + semestre + ")	union all select distinct c.cli_dni	from DATACENTER.Cliente c join DATACENTER.Compra co on co.comp_comprador_dni = c.cli_dni join DATACENTER.Paquete pa	on pa.paq_comp_id = co.comp_id join DATACENTER.Arribo a	on a.arri_viaj_id = pa.paq_viaj_id and a.arri_fecha_llegada between DATACENTER.fechaInicioSemestre('" + anio + "'," + semestre + ") and DATACENTER.fechaFinSemestre('" + anio + "'," + semestre + ")) order by 2 desc";
            connection conexion = new connection();
            return conexion.execute_query(query);
        }

        public DataTable top5DestinosConMasPasajes(string anio, string semestre)
        {
            string query = "select top 5 r.reco_destino as 'Destino', COUNT(distinct p.pas_cod) as 'Cantidad de Pasajes' from DATACENTER.Pasaje p join DATACENTER.Viaje v on p.pas_viaj_id = v.viaj_id join DATACENTER.Recorrido r on r.reco_cod = v.viaj_reco_cod join DATACENTER.Compra co on co.comp_id = p.pas_compra_id and co.comp_fecha_compra between DATACENTER.fechaInicioSemestre('" + anio + "'," + semestre + ") and DATACENTER.fechaFinSemestre('" + anio + "'," + semestre + ") group by r.reco_destino order by COUNT(distinct p.pas_cod) desc";
            connection conexion = new connection();
            return conexion.execute_query(query);
        }

        public DataTable top5DestinosPasajesCancelados(string anio, string semestre)
        {
            string query = "SELECT TOP 5 R.reco_destino AS 'Destino', COUNT(DISTINCT P.pas_cod) as 'Cantidad de Pasajes' FROM DATACENTER.Pasaje P JOIN DATACENTER.Viaje V ON P.pas_viaj_id = V.viaj_id JOIN DATACENTER.Recorrido R ON R.reco_cod = V.viaj_reco_cod JOIN DATACENTER.Devolucion D ON D.dev_pas_cod = P.pas_cod AND D.dev_fecha BETWEEN DATACENTER.fechaInicioSemestre('"+anio+"',"+semestre+") and DATACENTER.fechaFinSemestre('"+anio+"',"+semestre+") GROUP BY R.reco_destino ORDER BY 2 DESC";
            connection conexion = new connection();
            return conexion.execute_query(query);
        }

        public DataTable top5MicrosMasVacios(string anio, string semestre)
        {
            string query = "select top 5 m.mic_patente as 'Patente', (m.mic_cant_butacas-COUNT(distinct p.pas_cod)) as 'Cantidad de Butacas Vacías' from DATACENTER.Micro m join DATACENTER.Pasaje p on p.pas_micro_patente = m.mic_patente join DATACENTER.Arribo a on a.arri_mic_patente = m.mic_patente and a.arri_viaj_id = p.pas_viaj_id and a.arri_fecha_llegada between DATACENTER.fechaInicioSemestre('" + anio + "'," + semestre + ") and DATACENTER.fechaFinSemestre('" + anio + "'," + semestre + ") group by m.mic_patente, m.mic_cant_butacas order by 2 desc";
            connection conexion = new connection();
            return conexion.execute_query(query);
        }
    }
}
