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
    public partial class Form_Comprador : Form
    {
        FormCompra form_compra;
        bool cliente_existente = false;
        bool tarj_verificada = false;
        public bool transaccion_compra_ok = false;

        public Form_Comprador(FormCompra form_compra )
        {
            InitializeComponent();
            this.form_compra = form_compra;
        }

        private void refrescar()
        {
            this.nombre_Tbox.Clear();
            this.apell_Tbox.Clear();
            this.DNI_Tbox.Clear();
            this.dir_Tbox.Clear();
            this.tel_Tbox.Clear();
            this.mail_Tbox.Clear();
            this.nro_tarj_tbox.Clear();
            this.cod_Seg_tbox.Clear();

            this.tipoTarj_comboBox.Enabled = true;
            this.cant_cuot_numericUpDown.Value = this.cant_cuot_numericUpDown.Minimum;
            this.mascul_radioBut.Checked = false;
            this.fem_radButton.Checked = false;
            this.DNI_Tbox.Enabled = true;
            this.discapacitado_checkB.Visible = true;
            this.discapacitado_checkB.Checked = false;
            this.jubilado_checkB.Checked = false;
            this.pensionado_checkB.Checked = false;
            this.tarj_verificada = false;
            this.fecNacDateTimeP.ResetText();
            this.fecNacDateTimeP.ResetText();
            this.tipoTarj_comboBox.SelectedIndex = 0;
        }
        

        private void Limpiar_boton_Click(object sender, EventArgs e)
        {
            this.refrescar();
        }

        private void aceptar_boton_Click(object sender, EventArgs e)
        {
            bool error = false;

            if (this.DNI_Tbox.Text == "")
            {
                MessageBox.Show("Debe ingresar DNI", "Comprador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }

            if (this.nombre_Tbox.Text == "")
            {
                MessageBox.Show("Debe Ingresar Nombre", "Comprador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }

            if (this.apell_Tbox.Text == "")
            {
                MessageBox.Show("Debe Ingresar Apellido", "Comprador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }

            if (this.dir_Tbox.Text == "")
            {
                MessageBox.Show("Debe Ingresar Dirección", "Comprador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }

            if (this.tel_Tbox.Text == "")
            {
                MessageBox.Show("Debe Ingresar Telefono", "Comprador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }


            if (!(this.mascul_radioBut.Checked | this.fem_radButton.Checked))
            {
                MessageBox.Show("Debe Seleccionar Sexo", "Comprador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }

            if (this.nro_tarj_tbox.Text == "")
            {
                MessageBox.Show("Debe ingresar Numero de Tarjeta", "Comprador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;

            }

            if (this.cod_Seg_tbox.Text == "")
            {
                MessageBox.Show("Debe ingresar Codigo Seguridad", "Comprador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }

            

            if (!tarj_verificada)
            {
                MessageBox.Show("Debe verificar Tipo de Tarjeta ", "Comprador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }



            if (error)
                return;

            string sexo;
            if (this.mascul_radioBut.Checked)
                sexo = "M";
            else
                sexo = "F";

            //verificamos si es discapacitado
            string discapacitado;
            if (this.discapacitado_checkB.Checked)
                discapacitado = "D";
            else
                discapacitado = "N";

            //verificamos condicion
            string condicion;
            funciones func = new funciones();
            if (this.pensionado_checkB.Checked | func.es_jubilado(this.fecNacDateTimeP.Text, sexo))
            {
                if (this.pensionado_checkB.Checked)
                    condicion = "P";
                else
                    condicion = "J";
            }
            else
                condicion = "N";

            stored_procedures stored_proc = new stored_procedures();

            //Actualizamos o Insertamos Cliente
            if (this.cliente_existente)
            {

                stored_proc.update_Cliente(this.DNI_Tbox.Text, this.nombre_Tbox.Text, this.apell_Tbox.Text, this.dir_Tbox.Text, this.tel_Tbox.Text, this.mail_Tbox.Text, this.fecNacDateTimeP.Text, sexo,discapacitado, condicion);

            }
            else
            {
                //Insertamos Cliente
                stored_proc.insert_Cliente(this.DNI_Tbox.Text, this.nombre_Tbox.Text, this.apell_Tbox.Text, this.dir_Tbox.Text, this.tel_Tbox.Text, this.mail_Tbox.Text, this.fecNacDateTimeP.Text, sexo, discapacitado, condicion);

            }

            this.form_compra.dni_comprador = this.DNI_Tbox.Text;
            this.form_compra.tipo_tarjeta = this.tipoTarj_comboBox.SelectedValue.ToString();
            this.transaccion_compra_ok = true;
            this.Close();
        }

        private void Form_Comprador_Load(object sender, EventArgs e)
        {
            this.cant_cuot_numericUpDown.Enabled = false;
            string query = "SELECT tipo_id, tipo_descripcion FROM DATACENTER.TipoTarjeta ";
            connection conexion = new connection();
            DataTable table_tipo_tarj = conexion.execute_query(query);
            this.tipoTarj_comboBox.DataSource = table_tipo_tarj;
            this.tipoTarj_comboBox.ValueMember = "tipo_id";
            this.tipoTarj_comboBox.DisplayMember = "tipo_descripcion";
        }

        private void nombre_Tbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //no permite que ingresen numeros/signos de puntuacion/espacios/simbolos
            if (char.IsNumber(e.KeyChar) | char.IsPunctuation(e.KeyChar) | char.IsSeparator(e.KeyChar) | char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void apell_Tbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //no permite que ingresen numeros/signos de puntuacion/espacios/simbolos
            if (char.IsNumber(e.KeyChar) | char.IsPunctuation(e.KeyChar) | char.IsSeparator(e.KeyChar) | char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void dir_Tbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //no permite que ingresen signos de puntuación/simbolos
            if (char.IsPunctuation(e.KeyChar) | char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void tel_Tbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo permite q ingrese numeros
            if (char.IsNumber(e.KeyChar) | char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void fec_nac_Tbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) | char.IsSeparator(e.KeyChar) | char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void nro_tarj_tbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo permite q ingrese numeros
            if (char.IsNumber(e.KeyChar) | char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void cod_Seg_tbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo permite q ingrese numeros
            if (char.IsNumber(e.KeyChar) | char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void fech_venc_tbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo permite q ingrese numeros
            if (char.IsNumber(e.KeyChar) | char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;

        }

        private void confirmar_boton_Click(object sender, EventArgs e)
        {
            this.tipoTarj_comboBox.Enabled = false;

            stored_procedures stored_proc = new stored_procedures();

            char tipo_tarj_estado = stored_proc.check_tipo_tarjeta(this.tipoTarj_comboBox.SelectedValue.ToString());
            if (tipo_tarj_estado == 'H')
                this.cant_cuot_numericUpDown.Enabled = true;
            else
                this.cant_cuot_numericUpDown.Enabled = false;

            this.tarj_verificada = true;

        }

        private void DNI_Tbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            stored_procedures stored_proc = new stored_procedures();

            if (char.IsPunctuation(e.KeyChar) | char.IsSeparator(e.KeyChar) | char.IsLetter(e.KeyChar) | char.IsSymbol(e.KeyChar))
                e.Handled = true;

            //una vez que presione enter controlamos que el DNI ingresado
            //este en la base o no
            if (((int)e.KeyChar == (int)Keys.Enter) & (this.DNI_Tbox.Text != ""))
            {

                DataTable table_campos_cli = stored_proc.cargar_campos_cliente(this.DNI_Tbox.Text);
                if (table_campos_cli.Rows.Count != 0)
                {
                    this.DNI_Tbox.Enabled = false;
                    this.cliente_existente = true;
                    this.nombre_Tbox.Text = table_campos_cli.Rows[0].ItemArray[0].ToString();
                    this.apell_Tbox.Text = table_campos_cli.Rows[0].ItemArray[1].ToString();
                    this.dir_Tbox.Text = table_campos_cli.Rows[0].ItemArray[2].ToString();
                    this.tel_Tbox.Text = table_campos_cli.Rows[0].ItemArray[3].ToString();
                    this.mail_Tbox.Text = table_campos_cli.Rows[0].ItemArray[4].ToString();
                    this.fecNacDateTimeP.Text = table_campos_cli.Rows[0].ItemArray[5].ToString().Substring(0, 10);

                    //controlo si esta ingresado el sexo
                    if (table_campos_cli.Rows[0].ItemArray[6].ToString() == "M")
                        this.mascul_radioBut.Checked = true;
                    if (table_campos_cli.Rows[0].ItemArray[6].ToString() == "F")
                        this.fem_radButton.Checked = true;

                    //controlamos si esta seteado el campo discapacitado
                    if (table_campos_cli.Rows[0].ItemArray[7].ToString() == "D")
                    {
                        this.discapacitado_checkB.Checked = true;
                    }

                    //controlamos si es  jubilado y no es discapacitado
                    if (table_campos_cli.Rows[0].ItemArray[8].ToString() == "J" & !this.discapacitado_checkB.Checked)
                    {
                        this.jubilado_checkB.Checked = true;
                    }
                    if (table_campos_cli.Rows[0].ItemArray[8].ToString() == "P" & !this.discapacitado_checkB.Checked)
                    {
                        this.pensionado_checkB.Checked = true;
                    }

                }

            }
        }

        private void Form_Comprador_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.transaccion_compra_ok)
                MessageBox.Show("Transacción Abortada ", "Comprador", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
