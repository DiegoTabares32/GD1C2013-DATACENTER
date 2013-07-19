using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaBus.Compra_de_Pasajes
{
    public partial class select_fecha_viaje : Form
    {
        FormCompra form_compra; // formulario que lo llamo

        public select_fecha_viaje(FormCompra form_compra_padre)
        {
            InitializeComponent();
            this.form_compra = form_compra_padre;
        }

        private void confirmar_boton_Click(object sender, EventArgs e)
        {
            this.form_compra.fecha_tbox.Text = this.calendario_viajes.SelectionStart.ToShortDateString();
            this.Close();
        }




    }
}
