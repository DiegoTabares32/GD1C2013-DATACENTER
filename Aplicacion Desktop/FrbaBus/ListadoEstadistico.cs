using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

            //UNA QUERY QUE DEVUELVE TODOS LOS ANIOS QUE HAY REGISTRADOS EN LOS VIAJES
            connection conexion = new connection();
            string query = "";
            this.comboBoxAnio.DataSource = conexion.execute_query(query);
            
        }
    }
}
