using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaBus.Abm_Micro
{
    public partial class FormButacaAlta : Form
    {
        private int cantButacas;
        private string patenteMic;

        public FormButacaAlta()
        {
            InitializeComponent();
        }

        internal void pasaDatosMicro(int cantidadButacas, String patMicro)
        {
            cantButacas = cantidadButacas;
            patenteMic = patMicro;
        }

        private void FormButacaAlta_Load(object sender, EventArgs e)
        {
            int i;

            DataTable tablaButacas1 = new DataTable();
            tablaButacas1.Columns.Add("tipo_butaca", typeof(string));
            
            DataRow filaButacas1 = tablaButacas1.NewRow();
            filaButacas1["tipo_butaca"]= "Ventanilla";
            tablaButacas1.Rows.Add(filaButacas1);
            DataRow filaButacas2 = tablaButacas1.NewRow();
            filaButacas2["tipo_butaca"] = "Pasillo";
            tablaButacas1.Rows.Add(filaButacas2);
            ButacaTipo.DataSource = tablaButacas1;
            ButacaTipo.DisplayMember = "tipo_butaca";
            ButacaTipo.ValueMember = "tipo_butaca";

            DataTable tablaButacas2 = new DataTable();
            tablaButacas2.Columns.Add("piso_butaca", typeof(string));

            DataRow filaButacas3 = tablaButacas2.NewRow();
            filaButacas3["piso_butaca"] = "1";
            tablaButacas2.Rows.Add(filaButacas3);
            DataRow filaButacas4 = tablaButacas2.NewRow();
            filaButacas4["piso_butaca"] = "2";
            tablaButacas2.Rows.Add(filaButacas4);
            ButacaPiso.DataSource = tablaButacas2;
            ButacaPiso.DisplayMember = "piso_butaca";
            ButacaPiso.ValueMember = "piso_butaca";

            for (i = 0; i<cantButacas;i++ )
            {
                this.dataGridViewButacas.Rows.Add(Convert.ToString(i));
            }

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            int i;
            try
            {
                for (i = 0; i < dataGridViewButacas.RowCount; i++)
                {

                    //consulta a ejecutar para registrar nueva butaca
                    string query1 = "INSERT INTO DATACENTER.Butaca(but_nro,but_mic_patente,but_tipo,but_piso) VALUES ('" +
                                    dataGridViewButacas.Rows[i].Cells[0].Value.ToString() + "','" + patenteMic + "','" + dataGridViewButacas.Rows[i].Cells[1].Value.ToString() + "','" + dataGridViewButacas.Rows[i].Cells[2].Value.ToString() + "')";
                    connection connect1 = new connection();
                    connect1.execute_query(query1);
                
                }
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Debe cargar todas las butacas");
                return;
            }
            MessageBox.Show("El ingreso de Butacas se ha realizado con éxito.");
            this.Close();

        }


    }
}
