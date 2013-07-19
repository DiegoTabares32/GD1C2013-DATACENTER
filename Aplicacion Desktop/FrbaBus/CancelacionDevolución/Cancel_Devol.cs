using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaBus.Canc_Dev_de_Pas_Enc
{
    public partial class CancelDevol : Form
    {
        public CancelDevol()
        {
            InitializeComponent();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (textBoxNroCompra.Text == "")
            {
                MessageBox.Show("Debe ingresar un Nro de Compra");
                return;
            }
            
            //consulta a ejecutar para verificar que existe id de la compra
            string query1 = "select * from DATACENTER.Compra where comp_id=" + textBoxNroCompra.Text;
            connection connect1 = new connection();
            DataTable existeCompra = connect1.execute_query(query1);

            if (existeCompra.Rows.Count == 0)
            {
                MessageBox.Show("El Nro de Compra ingresado es incorrecto.");
                return;
            }

            if (comboBoxAlcance.SelectedValue.ToString() == "Parcial")
            {
                if (textBoxCodPasEnc.Text == "")
                {
                    MessageBox.Show("Debe ingresar el Código de un Pasaje o Encomienda.");
                    return;
                }

                string tipoItem = comboBoxTipoItem.Text.ToString();
                if (tipoItem == "Encomienda")
                    tipoItem = "Paquete";   //Asigno asi porque se relaciona más directo con TABLA PAQUETE

                if (tipoItem == "Paquete")
                {
                    //consulta a ejecutar para verificar que existe el código de paquete
                    string query2 = "select * from DATACENTER.Paquete where paq_comp_id=" + textBoxNroCompra.Text;
                    connection connect2 = new connection();
                    DataTable existePaquete = connect2.execute_query(query2);

                    if (existePaquete.Rows.Count == 0)
                    {
                        MessageBox.Show("El Código de Paquete ingresado es incorrecto.");
                        return;
                    }

                    //consulta a ejecutar para verificar que exista relación entre la compra y paquete
                    string query3 = "select * from DATACENTER.Compra join DATACENTER.Paquete on paq_comp_id=comp_id where comp_id=" + textBoxNroCompra.Text + " and paq_cod=" + textBoxCodPasEnc.Text;
                    connection connect3 = new connection();
                    DataTable existeRelCompraPaquete = connect3.execute_query(query3);

                    if (existeRelCompraPaquete.Rows.Count == 0)
                    {
                        MessageBox.Show("El Nro de Compra no se vincula con el Código de la Encomienda.");
                        return;
                    }

                    if (existeRelCompraPaquete.Rows[0].ItemArray[4].ToString() == "0")
                    {
                        MessageBox.Show("No existen encomiendas para devolver.");
                        return;
                    }

                }
                else
                {
                    //consulta a ejecutar para verificar que existe el código de pasaje
                    string query2 = "select * from DATACENTER.Pasaje where pas_compra_id=" + textBoxNroCompra.Text;
                    connection connect2 = new connection();
                    DataTable existePasaje = connect2.execute_query(query2);

                    if (existePasaje.Rows.Count == 0)
                    {
                        MessageBox.Show("El Código de Pasaje ingresado es incorrecto.");
                        return;
                    }

                    //consulta a ejecutar para verificar que exista relación entre la compra y pasaje
                    string query3 = "select * from DATACENTER.Compra join DATACENTER.Pasaje on pas_compra_id=comp_id where comp_id=" + textBoxNroCompra.Text + " and pas_cod=" + textBoxCodPasEnc.Text;
                    connection connect3 = new connection();
                    DataTable existeRelCompraPasaje = connect3.execute_query(query3);

                    if (existeRelCompraPasaje.Rows.Count == 0)
                    {
                        MessageBox.Show("El Nro de Compra no se vincula con el Código de Pasaje.");
                        return;
                    }

                    if (existeRelCompraPasaje.Rows[0].ItemArray[3].ToString() == "0")
                    {
                        MessageBox.Show("No existen pasajes para devolver.");
                        return;
                    }

                }

                //consulta a ejecutar para registrar nueva devolución
                string query5 = "exec DATACENTER.registraDevolucionParcial '" + dateTimePickerCancDev.Value.ToString("yyyy/MM/dd") + "'," + textBoxNroCompra.Text + ",'" + tipoItem + "'," + textBoxCodPasEnc.Text + ",'" + textBoxMotivoDeCanc.Text + "'";
                connection connect5 = new connection();
                connect5.execute_query(query5);

                MessageBox.Show("La devolución se ha realizado con éxito.");

                //Limpiar campos
                this.textBoxNroCompra.Clear();
                this.textBoxCodPasEnc.Clear();
                this.textBoxMotivoDeCanc.Clear();
            }
            else
            {
                //consulta a ejecutar para registrar nueva devolución
                string query5 = "exec DATACENTER.registraDevolucionTotal '" + dateTimePickerCancDev.Value.ToString("yyyy/MM/dd") + "'," + textBoxNroCompra.Text + ",'"+textBoxMotivoDeCanc.Text + "'";
                connection connect5 = new connection();
                connect5.execute_query(query5);

                MessageBox.Show("La devolución se ha realizado con éxito.");

                //Limpiar campos
                this.textBoxNroCompra.Clear();
                this.textBoxMotivoDeCanc.Clear();
            }

            return;

        }

        private void FormCancDev_Load(object sender, EventArgs e)
        {
            DataTable tablaItems = new DataTable();
            tablaItems.Columns.Add("tipo_item", typeof(string));

            DataRow filaItem1 = tablaItems.NewRow();
            filaItem1["tipo_item"] = "Pasaje";
            tablaItems.Rows.Add(filaItem1);
            DataRow filaItem2 = tablaItems.NewRow();
            filaItem2["tipo_item"] = "Encomienda";
            tablaItems.Rows.Add(filaItem2);
            comboBoxTipoItem.DataSource = tablaItems;
            comboBoxTipoItem.DisplayMember = "tipo_item";
            comboBoxTipoItem.ValueMember = "tipo_item";

            DataTable tablaAlcance = new DataTable();
            tablaAlcance.Columns.Add("tipo_alcance", typeof(string));

            DataRow filaAlcance1 = tablaAlcance.NewRow();
            filaAlcance1["tipo_alcance"] = "Total";
            tablaAlcance.Rows.Add(filaAlcance1);
            DataRow filaAlcance2 = tablaAlcance.NewRow();
            filaAlcance2["tipo_alcance"] = "Parcial";
            tablaAlcance.Rows.Add(filaAlcance2);
            comboBoxAlcance.DataSource = tablaAlcance;
            comboBoxAlcance.DisplayMember = "tipo_alcance";
            comboBoxAlcance.ValueMember = "tipo_alcance";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxNumericos_KeyPress(object sender, KeyPressEventArgs e)
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

        private void comboBoxAlcance_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxTipoItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxAlcance_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxAlcance.SelectedValue.ToString() == "Parcial")
            {
                comboBoxTipoItem.Enabled = true;
                textBoxCodPasEnc.Enabled = true;
            }
            else
            {
                comboBoxTipoItem.Enabled = false;
                textBoxCodPasEnc.Enabled = false;
            }
        }
        
    }
}
