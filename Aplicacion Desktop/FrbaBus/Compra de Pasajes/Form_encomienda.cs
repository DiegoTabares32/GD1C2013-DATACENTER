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
    public partial class Form_encomienda : Form
    {
        public string viaje_cod;
        public List<Form_encomienda> listas_encomienda;
        bool cliente_existente = false;
        public string cod_encomienda = "";
        public bool transacc_encomienda_ok=false;
        bool peso_validado = false;

        public Form_encomienda(string viaje_cod, List<Form_encomienda> listas_encomienda)
        {
            InitializeComponent();
            this.viaje_cod = viaje_cod;
            this.listas_encomienda = listas_encomienda; //la necesito para chequear KG
        }

        private void refrescar()
        {
            this.nombre_Tbox.Clear();
            this.apell_Tbox.Clear();
            this.DNI_Tbox.Clear();
            this.dir_Tbox.Clear();
            this.tel_Tbox.Clear();
            this.mail_Tbox.Clear();
            this.mascul_radioBut.Checked = false;
            this.fem_radButton.Checked = false;
            this.DNI_Tbox.Enabled = true;
            this.peso_encom_tbox.Clear();
            this.peso_encom_tbox.Enabled = true; ;
            this.jubilado_checkB.Checked = false;
            this.discapacitado_checkB.Checked = false;
            this.pensionado_checkB.Checked = false;
            this.peso_validado = false;
            this.fecNacDateTimeP.ResetText();
            this.precio_encomiendaTbox.Clear();
        }

        private void limpiar_boton_Click(object sender, EventArgs e)
        {
            this.refrescar();
        }

        private void check_peso_encom_boton_Click(object sender, EventArgs e)
        {
            if (this.peso_encom_tbox.Text == "")
            {
                MessageBox.Show("Debe ingresar un Peso", "Encomienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Convert.ToInt16(this.peso_encom_tbox.Text) == 0)
            {
                MessageBox.Show("Debe ingresar un Peso", "Encomienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            int kg_a_ocupar = Convert.ToInt16(this.peso_encom_tbox.Text); //inicializo con peso actual
            
            //calculo peso de las encomiendas implicadas en la compra más el peso de la encomienda actual
            foreach (Form_encomienda encomienda in this.listas_encomienda)
            {
                if (this.viaje_cod == encomienda.viaje_cod)
                    kg_a_ocupar += Convert.ToInt16(encomienda.peso_encom_tbox.Text);
 
            }

            //hacemos la diferencia con el peso disponible para ver si es posible enviar encomienda
            stored_procedures stored_proc = new stored_procedures();
            int kg_ocupados = stored_proc.get_kg_disponibles(this.viaje_cod);
            if (( kg_ocupados - kg_a_ocupar) >= 0)
            {
                MessageBox.Show("Se puede enviar Encomienda con este Peso", "Encomienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.precio_encomiendaTbox.Text = stored_proc.get_costo_encomienda(this.viaje_cod, this.peso_encom_tbox.Text);
                this.peso_encom_tbox.Enabled = false;
                this.peso_validado = true;
            }
            else
            {
                MessageBox.Show("El peso de la Encomienda supera los KG disponibles del micro, Imposible enviar Encomienda", "Encomienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.refrescar();
            }



        }

        private void guardar_boton_Click(object sender, EventArgs e)
        {
            bool error = false;

            if (this.DNI_Tbox.Text == "")
            {
                MessageBox.Show("Debe ingresar DNI", "Encomienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }

            if (this.nombre_Tbox.Text == "")
            {
                MessageBox.Show("Debe Ingresar Nombre", "Encomienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }

            if (this.apell_Tbox.Text == "")
            {
                MessageBox.Show("Debe Ingresar Apellido", "Encomienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }

            if (this.dir_Tbox.Text == "")
            {
                MessageBox.Show("Debe Ingresar Dirección", "Encomienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }

            if (this.tel_Tbox.Text == "")
            {
                MessageBox.Show("Debe Ingresar Telefono", "Encomienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }


            if (!(this.mascul_radioBut.Checked | this.fem_radButton.Checked))
            {
                MessageBox.Show("Debe Seleccionar Sexo", "Encomienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }


            if (!this.peso_validado)
            {
                MessageBox.Show("Debe Validar peso", "Encomienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }

            if (error)
                return;


            stored_procedures stored_proc = new stored_procedures();
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

            //Actualizamos o Insertamos Cliente
            if (this.cliente_existente)
            {

                stored_proc.update_Cliente(this.DNI_Tbox.Text, this.nombre_Tbox.Text, this.apell_Tbox.Text, this.dir_Tbox.Text, this.tel_Tbox.Text, this.mail_Tbox.Text, this.fecNacDateTimeP.Text, sexo, discapacitado,condicion);

            }
            else
            {
                //Insertamos Cliente
                stored_proc.insert_Cliente(this.DNI_Tbox.Text, this.nombre_Tbox.Text, this.apell_Tbox.Text, this.dir_Tbox.Text, this.tel_Tbox.Text, this.mail_Tbox.Text, this.fecNacDateTimeP.Text, sexo, discapacitado, condicion);

            }

            this.transacc_encomienda_ok = true;
            this.Close();

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
                    this.fecNacDateTimeP.Text = table_campos_cli.Rows[0].ItemArray[5].ToString();

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

        private void apell_Tbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //no permite que ingresen numeros/signos de puntuacion/espacios/simbolos
            if (char.IsNumber(e.KeyChar) | char.IsPunctuation(e.KeyChar) | char.IsSeparator(e.KeyChar) | char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void nombre_Tbox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void peso_encom_tbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo permite q ingrese numeros
            if (char.IsNumber(e.KeyChar) | char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void Form_encomienda_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!transacc_encomienda_ok)
            {
                MessageBox.Show("Transacción Cancelada", "Encomienda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.transacc_encomienda_ok = false;
            }
        }

  

      

    }
}
