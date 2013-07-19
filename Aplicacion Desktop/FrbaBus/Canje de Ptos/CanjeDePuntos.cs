using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaBus.Canje_de_Ptos
{
    public partial class CanjeDePuntos : Form
    {
        funciones func = new funciones();
        private string ptosAcumulados;

        public CanjeDePuntos()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (textBoxDniCliente.Text == "")
            {
                MessageBox.Show("ERROR: Debe ingresar un DNI de Cliente");
                return;
            }

            //consulta a ejecutar para actualizar y obtener los puntos del cliente
            string query1 = "exec DATACENTER.actualizarPuntos " + textBoxDniCliente.Text + "Select c.cli_puntos_acum from DATACENTER.Cliente c where c.cli_dni = " + textBoxDniCliente.Text;
            connection connect1 = new connection();
            DataTable ptos_acum = connect1.execute_query(query1);
            ptosAcumulados = ptos_acum.Rows[0].ItemArray[0].ToString();
 
            //consulta a ejecutar para mostrar todas los premios cargados en la tabla
            string query2 = "SELECT prem_nombre as Premio, prem_costo_puntos as Puntos FROM DATACENTER.Premio where " + ptosAcumulados + ">=prem_costo_puntos";
            connection connect2 = new connection();
            DataTable tabla_premio = connect2.execute_query(query2);
            this.Premio.DataPropertyName = tabla_premio.Columns[0].ToString();
            this.Puntos.DataPropertyName = tabla_premio.Columns[1].ToString();
            this.tablaPremios.DataSource = tabla_premio;
        }

        private void dniCliente_KeyPress(object sender, KeyPressEventArgs e)
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

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            int i;
            int puntosAConsumir = 0;

            // Verifica que los premios seleccionados tengan cantidad ingresada en el campo correspondiente
            for (i = 0; i < tablaPremios.RowCount; i++)
            {
                if (Convert.ToBoolean(tablaPremios.Rows[i].Cells[0].Value))
                {
                    if (tablaPremios.Rows[i].Cells[1].ToString() != null)
                    {
                        puntosAConsumir = puntosAConsumir + (Convert.ToInt32(tablaPremios.Rows[i].Cells[1].Value) * Convert.ToInt32(tablaPremios.Rows[i].Cells[3].Value));
                    }
                    else
                    {
                        MessageBox.Show("ERROR: Ingrese cantidad de premio/s a canjear");
                        return;
                    }
                }
            }

            string idCanjeNuevo = "0";
            // Verifica si dispone de puntos para efectuar el canje total
            if (puntosAConsumir <= Convert.ToInt32(ptosAcumulados))
            {
                //consulta a ejecutar para obtener el id del último canje realizado
                string query1 = "SELECT max(canj_id) FROM DATACENTER.Canje";
                connection connect1 = new connection();
                DataTable idCanje = connect1.execute_query(query1);
                
                if (idCanje.Rows[0].ItemArray[0].ToString() != "")
                {
                    int nroCanjeNuevo = Convert.ToInt32(idCanje.Rows[0].ItemArray[0].ToString()) + 1;
                    idCanjeNuevo = Convert.ToString(nroCanjeNuevo);
                }

                // se actualiza el stock de los premios
                for (i = 0; i < tablaPremios.RowCount; i++)
                {
                    if (Convert.ToBoolean(tablaPremios.Rows[i].Cells[0].Value))
                    {
                        //consulta a ejecutar para saber si hay stock disponible del premio en cuestión
                        string query4 = "SELECT DATACENTER.verificaStock('" + tablaPremios.Rows[i].Cells[2].Value.ToString() + "','" + tablaPremios.Rows[i].Cells[1].Value.ToString()+"')";
                        connection connect4 = new connection();
                        DataTable disponeStock = connect4.execute_query(query4);

                        if (Convert.ToInt32(disponeStock.Rows[0].ItemArray[0].ToString()) < 0)
                        {
                            MessageBox.Show("ERROR: No se puede entregar " + disponeStock.Rows[0].ItemArray[0].ToString() + " unidades de " + tablaPremios.Rows[i].Cells[2].Value.ToString() + " por falta de stock.");
                            return;
                        }

                        //consulta para actualizar por canje por premio (Actualiza stock del premio-Agrega canje nuevo)
                        string query3 = "exec DATACENTER.canjeaPremio '" + tablaPremios.Rows[i].Cells[2].Value.ToString()+"','"+textBoxDniCliente.Text+"','"+disponeStock.Rows[0].ItemArray[0].ToString()+"','"+tablaPremios.Rows[i].Cells[1].Value.ToString()+"','"+idCanjeNuevo+"'";
                        connection connect3 = new connection();
                        connect3.execute_query(query3);
                        
                    }
                }
                
                int puntosTotAcum = (Convert.ToInt32(ptosAcumulados) - puntosAConsumir);
                //consulta a ejecutar para actualizar los nuevos puntos del cliente
                string query2 = "UPDATE DATACENTER.Cliente set cli_puntos_acum=" + puntosTotAcum.ToString() + " where " + textBoxDniCliente.Text.ToString() + "=cli_dni";
                connection connect2 = new connection();
                connect2.execute_query(query2);

                MessageBox.Show("Puntos Consumidos " + puntosAConsumir.ToString());
                MessageBox.Show("El canje se ha realizado con éxito.");

                // Limpiar campo DNIcliente y tabla
                this.textBoxDniCliente.Clear();
                int cantFilas = tablaPremios.RowCount;
                for (i = 0; i < cantFilas; i++)
                {
                    this.tablaPremios.Rows.Remove(tablaPremios.Rows[0]);
                }

                return;
            }
            else
            {
                MessageBox.Show("ERROR: No tiene los suficientes puntos para realizar el canje");
                return;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            // Vuelve a la pantallita de formulario para el Administrador
            FormAdmin form_admin = new FormAdmin();
            form_admin.ShowDialog();
        }
    }  
}
