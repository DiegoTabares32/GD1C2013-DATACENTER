using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaBus.Abm_Micro
{
    public partial class Abm_Micro_Baja : Form
    {
        private funciones funciones;

        public Abm_Micro_Baja()
        {
            InitializeComponent();
            this.funciones = new funciones();
        }
  
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (textBoxPatente.Text == "")
            {
                MessageBox.Show("Debe ingresar una Patente");
                return;
            }

            char[] caracter = textBoxPatente.Text.ToCharArray();
            int i;
            if (caracter.Length != 6)
            {
                MessageBox.Show("Patente ingresada incorrecta. Se espera que sea de tipo LLLNNN");
                return;
            }

            for (i = 0; i < 3; i++)
            {
                if (Char.IsDigit(caracter.ElementAt(i)))
                {
                    MessageBox.Show("Patente ingresada incorrecta. Se espera que sea de tipo LLLNNN");
                    return;
                }
            }
            for (i = 3; i < 6; i++)
            {
                if (Char.IsLetter(caracter.ElementAt(i)))
                {
                    MessageBox.Show("Patente ingresada incorrecta. Se espera que sea de tipo LLLNNN");
                    return;
                }
            }

            if (funciones.existePatente(textBoxPatente.Text))
            {
                MessageBox.Show("La patente ingresada ya existe en la Base de Datos");
                return;
            }

            //Chequea si existen viajes ya asignados a ese micro

            //preparar patente para poder registrar nuevo micro
            string primerPartePatente = textBoxPatente.Text.Substring(0, 3);
            string segundaPartePatente = textBoxPatente.Text.Substring(3, 3);
            string nroPatente = primerPartePatente + "-" + segundaPartePatente;

            string query3 = "SELECT DATACENTER.estadoBaja('"+dateTimePickerFechaBajaDefinitiva.Value.ToString("yyyy/MM/dd")+"','"+nroPatente+"')";
            connection connect3 = new connection();
            DataTable estadoBajaMicro = connect3.execute_query(query3);
            
            if (estadoBajaMicro.Rows[0].ItemArray[0].ToString() != "0")
            {
                MessageBox.Show("ERROR: Para esa fecha el micro ya está dado de baja.");
                return;
            }

            //consulta a ejecutar para saber si existen viajes asociados al micro
            string query1 = "SELECT count(*) FROM DATACENTER.Viaje where viaj_mic_patente='" + nroPatente + "'";
            connection connect1 = new connection();
            DataTable cantViajes = connect1.execute_query(query1);

            //consulta a ejecutar para agregar nuevo registro por micro fuera de servicio (en EstadoMicro)
            string query2 = "UPDATE DATACENTER.Micro SET mic_fecha_baja_def='"+dateTimePickerFechaBajaDefinitiva.Value.ToString("yyyy/MM/dd")+"' where mic_patente='"+nroPatente+"'";
            connection connect2 = new connection();
            connect2.execute_query(query2);
            
            if (Convert.ToInt32(cantViajes.Rows[0].ItemArray[0].ToString()) == 0)
            {
                MessageBox.Show("La operación se ha realizado con éxito.");
                textBoxPatente.Clear();
                return;
            }
            else
            {
                // Direcciona a formulario de OPERACIÓN POR CONCRETAR ya que tenía viajes asociados
                Abm_Micro_OpPorConcretar form_OpPorConcretar = new Abm_Micro_OpPorConcretar();
                form_OpPorConcretar.pasaPatente(nroPatente, dateTimePickerFechaBajaDefinitiva, null);
                form_OpPorConcretar.ShowDialog();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
