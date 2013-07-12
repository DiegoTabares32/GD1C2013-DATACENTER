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
    public partial class Abm_Micro_Alta : Form
    {
        private funciones funciones;

        public Abm_Micro_Alta()
        {
            InitializeComponent();
            this.funciones = new funciones();    
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (textBoxPatente.Text == "")
            {
                MessageBox.Show("Debe ingresar una Patente");
                return;
            }

            char[] caracter = textBoxPatente.Text.ToCharArray();
            int i;
            for (i = 0;i<3; i++)
            {
                if (Char.IsDigit(caracter.ElementAt(i)))
                {
                    MessageBox.Show("Patente ingresada incorrecta. Se espera que sea de tipo LLLNNN");
                    return;
                }
            }
            for (i=3; i < 6; i++)
            {
                if (Char.IsLetter(caracter.ElementAt(i)))
                {
                    MessageBox.Show("Patente ingresada incorrecta. Se espera que sea de tipo LLLNNN");
                    return;
                }
            }

            if (funciones.existePatente(textBoxPatente.Text))
            {
                MessageBox.Show("La patente ingresada ya existe en la Base de Datos");
                return;
            }
            if (textBoxModelo.Text == "")
            {
                MessageBox.Show("Debe ingresar un Modelo");
                return;
            }
            if (textBoxCButacas.Text == "")
            {
                MessageBox.Show("Debe ingresar Cantidad de butacas");
                return;
            }
            if (textBoxCKGDisp.Text == "")
            {
                MessageBox.Show("Debe ingresar Cantidad de KG Disponibles");
                return;
            }

            //consulta a ejecutar para conseguir id de servicio para poder registrar nuevo micro
            string query1 = "SELECT serv_id FROM DATACENTER.Servicio where serv_tipo='"+comboBoxServicio.Text.ToString()+"'";

            //instanciamos obj de la clase connection y le enviamos la query para que la ejecute
            connection connect1 = new connection();
            DataTable idServ = connect1.execute_query(query1);

            //consulta a ejecutar para conseguir id de marca para poder registrar nuevo micro
            string query2 = "SELECT marc_id FROM DATACENTER.Marca where marc_nombre='"+comboBoxMarca.Text.ToString()+"'";

            //instanciamos obj de la clase connection y le enviamos la query para que la ejecute
            connection connect2 = new connection();
            DataTable idMarca = connect2.execute_query(query2);

            //preparar patente para poder registrar nuevo micro
            string primerPartePatente = textBoxPatente.Text.Substring(0, 3);
            string segundaPartePatente = textBoxPatente.Text.Substring(3, 3);
            string nroPatente = primerPartePatente + "-" + segundaPartePatente;

            //consulta a ejecutar para registrar nuevo micro
            string query3 = "INSERT INTO DATACENTER.Micro(mic_patente, mic_marc_id, mic_serv_id, mic_cant_butacas, mic_cant_kg_disponibles, mic_modelo, mic_fecha_alta, mic_fecha_baja_def) VALUES ('"+
                            nroPatente + "','" + idMarca.Rows[0].ItemArray[0].ToString() + "','" + idServ.Rows[0].ItemArray[0].ToString() + "','" + textBoxCButacas.Text.ToString() + "','" + textBoxCKGDisp.Text.ToString() + "','" + textBoxModelo.Text.ToString() + "','" + dateTimePickerFechaAlta.Value.ToString("dd/MM/yyyy") + "',NULL)";

            //instanciamos obj de la clase connection y le enviamos la query para que la ejecute
            connection connect3 = new connection();
            connect3.execute_query(query3);

            MessageBox.Show("El ingreso de Micro se ha realizado con éxito.");

            // Se redirecciona al formulario de alta de butacas
            FormButacaAlta butaca_Alta = new FormButacaAlta();
            butaca_Alta.patente = nroPatente;
            butaca_Alta.cantButacas = Convert.ToInt32(textBoxCButacas.Text);
            butaca_Alta.Show();
            
            // Limpiar campos
            this.textBoxPatente.Clear();
            this.textBoxModelo.Clear();
            this.textBoxCKGDisp.Clear();
            this.textBoxCButacas.Clear();
            return;
            
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan 
                    e.Handled = true;
                } 

        }

        private void textBoxMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan 
                    e.Handled = true;
                } 
        }

        private void Abm_Micro_Alta_Load(object sender, EventArgs e)
        {
            //consulta a ejecutar para mostrar todas los tipos de servicios existentes
            string query1 = "SELECT serv_tipo FROM DATACENTER.Servicio";
            
            //instanciamos obj de la clase connection y le enviamos la query para que la ejecute
            connection connect1 = new connection();
            DataTable tiposServicio = connect1.execute_query(query1);

            //cargamos el comboBox de los servicios
            comboBoxServicio.DataSource = tiposServicio;
            comboBoxServicio.DisplayMember = "serv_tipo";
            comboBoxServicio.ValueMember = "serv_tipo";

            //consulta a ejecutar para mostrar todas los tipos de marca existentes
            string query2 = "SELECT marc_nombre FROM DATACENTER.Marca";

            //instanciamos obj de la clase connection y le enviamos la query para que la ejecute
            connection connect2 = new connection();
            DataTable tiposMarca = connect2.execute_query(query2);

            //cargamos el comboBox de los servicios
            comboBoxMarca.DataSource = tiposMarca;
            comboBoxMarca.DisplayMember = "marc_nombre";
            comboBoxMarca.ValueMember = "marc_nombre";

        }
    }
}
