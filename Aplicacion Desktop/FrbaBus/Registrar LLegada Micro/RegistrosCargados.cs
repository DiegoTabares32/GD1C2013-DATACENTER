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
    public partial class RegistrosCargados : Form
    {
        private DataTable llegada;

        public RegistrosCargados(DataTable llegada)
        {
            InitializeComponent();
            this.llegada = llegada;
        }

        private void RegistrosCargados_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = this.llegada;
        }
    }
}
