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
using FrbaBus.Top_Micros;

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
            string query = "select DISTINCT(YEAR(comp_fecha_compra)) as 'año' FROM DATACENTER.Compra";
            connection conexion = new connection();
            DataTable anios = conexion.execute_query(query);

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

            this.comboBoxAnio.DataSource = anios;
            this.comboBoxAnio.DisplayMember = "año";
                                               
        }

        private void buttonDestinosMasPasajesComprados_Click(object sender, EventArgs e)
        {
            if (this.validarAnio()) { return; }            
            Top5DestinosMasPasajesComprados destinosMasPasajes = new Top5DestinosMasPasajesComprados(this.comboBoxAnio.Text, comboBoxSemestre.Text);
            destinosMasPasajes.Show();
        }             

        private void buttonDestinosMicrosMasVacios_Click(object sender, EventArgs e)
        {
            if (this.validarAnio()) { return; }
            MicrosMasButacasVacias microsVacios = new MicrosMasButacasVacias(this.comboBoxAnio.Text,comboBoxSemestre.Text);
            microsVacios.Show();
        }

        private void buttonClientesConMasPuntosAcumulados_Click(object sender, EventArgs e)
        {
            if (this.validarAnio()) { return; }            
            Top5Clientes clientes = new Top5Clientes(comboBoxAnio.Text, comboBoxSemestre.Text);
            clientes.Show();
        }

        private void buttonDestinosConPasajesCancelados_Click(object sender, EventArgs e)
        {
            if (this.validarAnio()) { return; }
            MasPasajesCancelados cancelados = new MasPasajesCancelados(comboBoxAnio.Text, comboBoxSemestre.Text);
            cancelados.Show();
        }

        private void buttonMicrosDiasFueraServicio_Click(object sender, EventArgs e)
        {
            if (this.validarAnio()) { return; }
            MicrosDiasFueraServicio microsFueraServicio = new MicrosDiasFueraServicio(comboBoxAnio.Text, comboBoxSemestre.Text);
            microsFueraServicio.Show();
        }

        private bool validarAnio()
        {
            bool error = false;
            if (comboBoxAnio.Text == "")
            {
                MessageBox.Show("Debe especificar el año (AAAA)");
                return error = true;
            }
            char[] anio = comboBoxAnio.Text.ToCharArray();
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