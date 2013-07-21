using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaBus.Abm_Recorrido
{
    public partial class Abm_Reco_Habilitar : Form
    {
        String estado;

        public Abm_Reco_Habilitar(string est)
        {
            estado = est;
            InitializeComponent();
            comboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Abm_Reco_Habilitar_Load(object sender, EventArgs e)
        {
            comboBoxEstado.Text = estado;
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (comboBoxEstado.Text == estado)
            {
                MessageBox.Show("ERROR: No Cambió el estado del recorrido");
                return;
            }

            string cod = textBoxCodReco.Text.ToString();
            string est = comboBoxEstado.Text.ToString();
            Char estado_act = est[0];
            stored_procedures procedure = new stored_procedures();
            procedure.habilitar_estado_reco(cod, estado_act); // ESTE PROCEDURE ES EL ENCARGADO DE REAHBILITAR RECOS!!!!!!!!!!!
            MessageBox.Show("¡RECORRIDO HABILITADO CORRECTAMENTE!");
            this.Close();
        }




    }
}
