using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaBus.Top_Destinos
{
    public partial class Top5DestinosMasPasajesComprados : Form
    {
        private funciones funciones;
        private string anio;
        private string semestre;

        public Top5DestinosMasPasajesComprados(string anio, string semestre)
        {
            InitializeComponent();
            this.funciones = new funciones();
            this.anio = anio;
            this.semestre = semestre;
        }

        private void Top5DestinosMasPasajesComprados_Load(object sender, EventArgs e)
        {
            this.labelAnio.Text = this.anio;
            this.labelSemestre.Text = this.semestre;
            this.dataGridViewDestinosMasPasajes.DataSource = this.funciones.top5DestinosConMasPasajes(this.anio, this.semestre);
        }
    }
}
