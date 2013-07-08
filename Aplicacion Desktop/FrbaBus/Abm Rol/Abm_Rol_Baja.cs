using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaBus.Abm_Rol
{
    public partial class Abm_Rol_Baja : Form
    {
        public Abm_Rol_Baja()
        {
            InitializeComponent();
        }

        private void select_boton_Click(object sender, EventArgs e)
        {
            Abm_Rol_Busqueda buscar_rol = new Abm_Rol_Busqueda();
            buscar_rol.ShowDialog();
        }
    }
}
