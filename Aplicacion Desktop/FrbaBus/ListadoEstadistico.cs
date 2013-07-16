using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.Top_Clientes;
using FrbaBus.Top_Destinos;

namespace FrbaBus
{
    public partial class ListadoEstadistico : Form
    {
        public ListadoEstadistico()
        {
            InitializeComponent();
        }

        private void ListadoEstadistico_Load(object sender, EventArgs e)
        {
            DataTable tablaSemestre = new DataTable();
            tablaSemestre.Columns.Add("semestre", typeof(string));

            DataRow semestre1 = tablaSemestre.NewRow();
            semestre1["semestre"] = "1";
            tablaSemestre.Rows.Add(semestre1);
            DataRow semestre2 = tablaSemestre.NewRow();
            semestre2["semestre"] = "2";
            tablaSemestre.Rows.Add(semestre2);
            this.comboBoxSemestre.DataSource = tablaSemestre;
            this.comboBoxSemestre.DisplayMember = "semestre";
            this.comboBoxSemestre.ValueMember = "semestre";
                                   
        }

        private void buttonDestinosMasPasajesComprados_Click(object sender, EventArgs e)
        {
            if (this.validarAnio()) { return; }
            Top5DestinosMasPasajesComprados destinosMasPasajes = new Top5DestinosMasPasajesComprados(this.textBoxAnio.Text, comboBoxSemestre.Text);
            destinosMasPasajes.Show();
        }             

        private void buttonDestinosMicrosMasVacios_Click(object sender, EventArgs e)
        {
            if (this.validarAnio()) { return; }            
        }

        private void buttonClientesConMasPuntosAcumulados_Click(object sender, EventArgs e)
        {
            if (this.validarAnio()) { return; }            
            Top5Clientes clientes = new Top5Clientes(textBoxAnio.Text, comboBoxSemestre.Text);
            clientes.Show();
        }

        private void buttonDestinosConPasajesCancelados_Click(object sender, EventArgs e)
        {
            if (this.validarAnio()) { return; }            
        }

        private void buttonMicrosDiasFueraServicio_Click(object sender, EventArgs e)
        {
            if (this.validarAnio()) { return; }            
        }

        private bool validarAnio()
        {
            bool error = false;
            if (textBoxAnio.Text == "")
            {
                MessageBox.Show("Debe especificar el año (AAAA)");
                return error = true;
            }
            char[] anio = textBoxAnio.Text.ToCharArray();
            if (anio.Length != 4)
            {
                MessageBox.Show("El año debe ser de 4 digitos AAAA");
                error = true;
            }

            int i;
            for (i = 0; i < anio.Length; i++)
            {
                if (Char.IsLetter(anio.ElementAt(i)))
                {
                    MessageBox.Show("ERROR: El formato de año es numérico AAAA. Por ej: 2013");
                    error = true;
                    return error;
                }
            }
            return error;
        }
    }
}