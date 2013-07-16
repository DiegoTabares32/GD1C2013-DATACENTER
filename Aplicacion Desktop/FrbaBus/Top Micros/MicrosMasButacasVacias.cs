using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaBus.Top_Micros
{
    public partial class MicrosMasButacasVacias : Form
    {
        private funciones funciones;
        private string anio;
        private string semestre;

        public MicrosMasButacasVacias(string anio, string semestre)
        {
            InitializeComponent();
            this.funciones = new funciones();
            this.anio = anio;
            this.semestre = semestre;
        }

        private void MicrosMasButacasVacias_Load(object sender, EventArgs e)
        {
            this.labelAnio.Text = this.anio;
            this.labelSemestre.Text = this.semestre;
            this.dataGridViewMicrosButacasVacias.DataSource = this.funciones.top5MicrosMasVacios(this.anio, this.semestre);
        }
    }
}
