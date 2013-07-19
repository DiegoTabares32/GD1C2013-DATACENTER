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
    public partial class Abm_Reco_Baja : Form
    {
        String Estado;

        public Abm_Reco_Baja(string est)
        {
            Estado = est;
            InitializeComponent();
            comboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Abm_Reco_Baja_Load(object sender, EventArgs e)
        {
            comboBoxEstado.Text = Estado;
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (comboBoxEstado.Text == Estado)
            {
                MessageBox.Show("ERROR: No Cambió el estado del recorrido");
                return;
            }

            string cod = textBoxCodReco.Text.ToString();
            string est = comboBoxEstado.Text.ToString();
            Char estado_act = est[0];
            stored_procedures procedure = new stored_procedures();
            procedure.update_estado_reco(cod, estado_act);
            MessageBox.Show("¡RECORRIDO ACTUALIZADO CORRECTAMENTE!");
            return;
        }


    }
}
