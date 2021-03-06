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
    public partial class Top5DestinosMasPasajesComprados : Form
    {
        private funciones funciones;
        private string anio;
        private string semestre;
        private Cargando mensaje;

        public Top5DestinosMasPasajesComprados(string anio, string semestre)
        {
            InitializeComponent();
            this.funciones = new funciones();
            this.anio = anio;
            this.semestre = semestre;
            this.mensaje = new Cargando();
            this.mensaje.Show();                                  
        }

        private void Top5DestinosMasPasajesComprados_Load(object sender, EventArgs e)
        {            
            this.labelAnio.Text = this.anio;
            this.labelSemestre.Text = this.semestre;
            this.dataGridViewDestinosMasPasajes.DataSource = this.funciones.top5DestinosConMasPasajes(this.anio, this.semestre);
            this.mensaje.Close();
        }
    }
}
