﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaBus.Abm_Micro
{
    public partial class Patente_Alta : Form
    {
        private funciones funciones;
        private string patenteAReemplazar;
        private DateTimePicker fechaFServ;
        private DateTimePicker fechaRein;

        public Patente_Alta()
        {
            InitializeComponent();
            this.funciones = new funciones();    
        }

        internal void pasaCaracteristicas(String patAReemplazar, DateTimePicker fechaFS, DateTimePicker fechaR)
        {
            patenteAReemplazar = patAReemplazar;
            fechaFServ = fechaFS;
            fechaRein = fechaR;
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

            for (i = 0;i<3; i++)
            {
                if (Char.IsDigit(caracter.ElementAt(i)))
                {
                    MessageBox.Show("Patente ingresada incorrecta. Se espera que sea de tipo LLLNNN");
                    return;
                }
            }
            for (i=3; i < 6; i++)
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

            //preparar patente para poder registrar nuevo micro
            string primerPartePatente = textBoxPatente.Text.Substring(0, 3);
            string segundaPartePatente = textBoxPatente.Text.Substring(3, 3);
            string nroPatente = primerPartePatente + "-" + segundaPartePatente;

            DateTimePicker datetimepicker = new DateTimePicker();
            datetimepicker.Value = Convert.ToDateTime((System.Configuration.ConfigurationSettings.AppSettings["FechaDelSistema"]).ToString());

            string query1 = "exec DATACENTER.registrarNuevoMicro '" + nroPatente + "','" + patenteAReemplazar + "','" + datetimepicker.Value.ToString("yyyy/MM/dd HH:mm") + "'";
            connection connect1 = new connection();
            connect1.execute_query(query1);

            MessageBox.Show("El ingreso de Micro se ha realizado con éxito.");
            
            
            // Proceder al cambio de micro efectivo en los registros de los viajes que corresponda

            //consulta a ejecutar para localizar los viajes que tenía asignados el micro anterior y actualizarles el nuevo valor
            string query2;
            if (fechaRein == null)
            {
                query2 = "UPDATE DATACENTER.Viaje SET viaj_mic_patente='" + nroPatente + "' WHERE viaj_mic_patente='" + patenteAReemplazar + "' and (viaj_fecha_salida>='" + fechaFServ.Value.ToString("yyyy/MM/dd HH:mm") + "' or viaj_fecha_lleg_estimada>='" + fechaFServ.Value.ToString("yyyy/MM/dd HH:mm") + "')";
            }
            else
            {
                query2 = "UPDATE DATACENTER.Viaje SET viaj_mic_patente='" + nroPatente + "' WHERE viaj_mic_patente='" + patenteAReemplazar + "' and ((viaj_fecha_salida>='" + fechaFServ.Value.ToString("yyyy/MM/dd HH:mm") + "' and viaj_fecha_salida<='" + fechaRein.Value.ToString("yyyy/MM/dd HH:mm") + "') or (viaj_fecha_lleg_estimada>='" + fechaFServ.Value.ToString("yyyy/MM/dd") + "' and viaj_fecha_lleg_estimada<='" + fechaRein.Value.ToString("yyyy/MM/dd HH:mm") + "'))";
            }
            connection connect2 = new connection();
            connect2.execute_query(query2);

            MessageBox.Show("La asignación de micro nuevo a los viajes se ha realizado con éxito.");
    
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
