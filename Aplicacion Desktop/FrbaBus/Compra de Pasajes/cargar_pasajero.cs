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
    public partial class cargar_pasajero : Form
    {

        bool cliente_existente = false;
        public string viaje_cod;
        public List<cargar_pasajero> listas_pasajeros;

        public cargar_pasajero(string cod_viaje, List<cargar_pasajero> listas_pasajeros)
        {
            InitializeComponent();
            this.viaje_cod = cod_viaje;
            this.listas_pasajeros = listas_pasajeros;
        }




        private void refrescar()
        {
            this.nombre_Tbox.Clear();
            this.apell_Tbox.Clear();
            this.DNI_Tbox.Clear();
            this.dir_Tbox.Clear();
            this.tel_Tbox.Clear();
            this.mail_Tbox.Clear();
            this.fec_nac_Tbox.Clear();
            this.mascul_radioBut.Checked = false;
            this.fem_radButton.Checked = false;
            this.DNI_Tbox.Enabled = true;
        }

        private void limpiar_boton_Click(object sender, EventArgs e)
        {
            this.refrescar();
        }

        private void guardar_boton_Click(object sender, EventArgs e)
        {
            bool error = false;

            if (this.DNI_Tbox.Text == "")
            {
                MessageBox.Show("Debe ingresar DNI", "Cargar Pasajero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }

            if (this.nombre_Tbox.Text == "")
            {
                MessageBox.Show("Debe Ingresar Nombre", "Cargar Pasajero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }

            if (this.apell_Tbox.Text == "")
            {
                MessageBox.Show("Debe Ingresar Apellido", "Cargar Pasajero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }

            if (this.dir_Tbox.Text == "")
            {
                MessageBox.Show("Debe Ingresar Dirección", "Cargar Pasajero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }

            if (this.tel_Tbox.Text == "")
            {
                MessageBox.Show("Debe Ingresar Telefono", "Cargar Pasajero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }

            if (this.fec_nac_Tbox.Text == "" )
            {
                MessageBox.Show("Debe Ingresar Fecha de Nacimiento", "Cargar Pasajero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }


            if (this.fec_nac_Tbox.Text.Length >= 6)
            {
                if (this.fec_nac_Tbox.Text[2] != '/' | this.fec_nac_Tbox.Text[5] != '/')
                {
                    MessageBox.Show("Error en el formato de fecha. Formato obligatorio: dd/mm/aaaaa", "Cargar Pasajero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error = true;

                }
            }
            else
            {
                MessageBox.Show("Error en el formato de fecha. Formato obligatorio: dd/mm/aaaaa", "Cargar Pasajero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }

            if (!(this.mascul_radioBut.Checked | this.fem_radButton.Checked))
            {
                MessageBox.Show("Debe Seleccionar Sexo", "Cargar Pasajero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }

            if (this.butNro_tbox.Text == "" | this.piso_tbox.Text == "" | this.pos_but_tbox.Text == "")
            {
                MessageBox.Show("Debe Seleccionar Butaca", "Cargar Pasajero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }


            if (this.butNro_tbox.Text == "" | this.piso_tbox.Text == "" | this.pos_but_tbox.Text == "")
            {
                MessageBox.Show("Debe Seleccionar Butaca", "Cargar Pasajero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }

            if (error)
            {
                this.refrescar();
                return;
            }

            stored_procedures stored_proc = new stored_procedures();
            string sexo;
            if (this.mascul_radioBut.Checked)
                    sexo = "M";
                else
                    sexo = "F";

            //Actualizamos o Insertamos Cliente
            if (this.cliente_existente)
            {

                stored_proc.update_Cliente(this.DNI_Tbox.Text, this.nombre_Tbox.Text, this.apell_Tbox.Text, this.dir_Tbox.Text, this.tel_Tbox.Text, this.mail_Tbox.Text, this.fec_nac_Tbox.Text, sexo);

            }
            else
            {
                //Insertamos Cliente
                stored_proc.insert_Cliente(this.DNI_Tbox.Text, this.nombre_Tbox.Text, this.apell_Tbox.Text, this.dir_Tbox.Text, this.tel_Tbox.Text, this.mail_Tbox.Text, this.fec_nac_Tbox.Text, sexo);

            }

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
                    this.fec_nac_Tbox.Text = table_campos_cli.Rows[0].ItemArray[5].ToString().Substring(0, 10);

                    //controlo si esta ingresado el sexo
                    if (table_campos_cli.Rows[0].ItemArray[6].ToString() == "M")
                        this.mascul_radioBut.Checked = true;
                    if (table_campos_cli.Rows[0].ItemArray[6].ToString() == "F")
                        this.fem_radButton.Checked = true;
                }

            }
            
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

        private void select_butaca_boton_Click(object sender, EventArgs e)
        {
            

            select_butaca select_butaca = new select_butaca(this);
            select_butaca.ShowDialog();
        }

 

   



    }
}
