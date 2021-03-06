﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus;

namespace FrbaBus.Top_Destinos
{
    public partial class MasPasajesCancelados : Form
    {
        private Cargando mensaje;
        private funciones funciones;
        private string anio;
        private string semestre;

        public MasPasajesCancelados(string anio, string semestre)
        {
            InitializeComponent();
            this.funciones = new funciones();
            this.anio = anio;
            this.semestre = semestre;
            this.mensaje = new Cargando();
            this.mensaje.Show();
        }

        private void MasPasajesCancelados_Load(object sender, EventArgs e)
        {
            this.labelAnio.Text = this.anio;
            this.labelSemestre.Text = this.semestre;
            this.dataGridViewDestinosMasPasajesCancelados.DataSource = this.funciones.top5DestinosPasajesCancelados(this.anio, this.semestre);
            this.mensaje.Close();
        }
    }
}
