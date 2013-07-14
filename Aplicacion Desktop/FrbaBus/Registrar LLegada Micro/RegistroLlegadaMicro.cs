using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaBus.Registrar_LLegada_Micro
{
    public partial class llegadaMicros : Form
    {
        public llegadaMicros()
        {
            InitializeComponent();
        }

        public void agregarDatos(DataTable tabla)
        {
            this.dataGridViewRegistrosCargados.Rows.Add(tabla);
        }

        private void buttonIngresarArribo_Click(object sender, EventArgs e)
        {
            Form formularioDeArribo = new FormularioDeArribo(this);
            formularioDeArribo.Show();            
        }
    }
}
