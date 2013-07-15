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
    public partial class InfoMicro : Form
    {
        
        public InfoMicro(DataTable tabla, string mensaje)
        {
            InitializeComponent();
            this.dataGridView1.DataSource = tabla;
            this.labelValidacionLlegada.Text = mensaje;
        }

        private void InfoMicro_Load(object sender, EventArgs e)
        {
            
        }
    }
}
