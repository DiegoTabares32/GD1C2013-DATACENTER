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
    public partial class Abm_Micro_Modif : Form
    {
        private funciones funciones;

        public Abm_Micro_Modif()
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
            //preparar patente para poder registrar nuevo micro
            string primerPartePatente = textBoxPatente.Text.Substring(0, 3);
            string segundaPartePatente = textBoxPatente.Text.Substring(3, 3);
            string nroPatente = primerPartePatente + "-" + segundaPartePatente;

            if (!funciones.existePatente(nroPatente))
            {
                MessageBox.Show("La patente ingresada no existe en la Base de Datos");
                return;
            }

            if (dateTimePickerFechaReingreso.Value < dateTimePickerFechaBajaTemporaria.Value)
            {
                MessageBox.Show("ERROR: La fecha de baja no puede ser anterior a la de reingreso.");
                return;
            }

            //Chequea si existen viajes ya asignados a ese micro
                        

            //consulta a ejecutar para saber si existen viajes asociados al micro
            string query3 = "SELECT * FROM DATACENTER.EstadoMicro where est_mic_patente='" + nroPatente + "'";
            connection connect3 = new connection();
            DataTable estadosDelMicro = connect3.execute_query(query3);

            for(i=0;i<estadosDelMicro.Rows.Count;i++)
            {
                if (Convert.ToDateTime(dateTimePickerFechaBajaTemporaria.Value.ToString()) >= Convert.ToDateTime(estadosDelMicro.Rows[i].ItemArray[2].ToString()))
                {
                    if (Convert.ToDateTime(dateTimePickerFechaBajaTemporaria.Value.ToString()) <= Convert.ToDateTime(estadosDelMicro.Rows[i].ItemArray[3].ToString()))
                    {
                        MessageBox.Show("ERROR: Para ese rango de fechas ya se registra una baja del micro");
                        return;
                    }
                }

                if (Convert.ToDateTime(dateTimePickerFechaReingreso.Value.ToString()) >= Convert.ToDateTime(estadosDelMicro.Rows[i].ItemArray[2].ToString()))
                {
                    if (Convert.ToDateTime(dateTimePickerFechaReingreso.Value.ToString()) <= Convert.ToDateTime(estadosDelMicro.Rows[i].ItemArray[3].ToString()))
                    {
                        MessageBox.Show("ERROR: Para ese rango de fechas ya se registra una baja del micro");
                        return;
                    }
                }
            }

            //consulta a ejecutar para saber si existen viajes asociados al micro
            string query1 = "SELECT count(*) FROM DATACENTER.Viaje where viaj_mic_patente='" + nroPatente + "'";
            connection connect1 = new connection();
            DataTable cantViajes = connect1.execute_query(query1);

            //consulta a ejecutar para agregar nuevo registro por micro fuera de servicio (en EstadoMicro)
            string query2 = "INSERT INTO DATACENTER.EstadoMicro(est_mic_patente,est_fecha_fuera_serv,est_fecha_reingreso) VALUES ('"
                            + nroPatente + "','" + dateTimePickerFechaBajaTemporaria.Value.ToString("yyyy/MM/dd HH:mm") + "','" + dateTimePickerFechaReingreso.Value.ToString("yyyy/MM/dd HH:mm") + "')";
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
                form_OpPorConcretar.pasaPatente(nroPatente, dateTimePickerFechaBajaTemporaria, dateTimePickerFechaReingreso);
                form_OpPorConcretar.ShowDialog();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxPatente_KeyPress(object sender, KeyPressEventArgs e)
        {            
            //Para obligar a que sólo se introduzcan letras 
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsDigit(e.KeyChar)) //permitir teclas de control como retroceso 
                {
                    e.Handled = false;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        //el resto de teclas pulsadas se desactivan 
                        e.Handled = true;
                    }
                }
        
        }
    }
}
