﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FrbaBus.Abm_Rol;
using FrbaBus.Compra_de_Pasajes;

namespace FrbaBus
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormCompra());
            //Application.Run(new Abm_Rol_Modif());
            //Application.Run(new Abm_Rol_Baja());
           
        }
    }
}
