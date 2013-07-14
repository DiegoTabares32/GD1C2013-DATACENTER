using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FrbaBus.Registrar_LLegada_Micro;

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
            Application.Run(new llegadaMicros());
            
           
        }
    }
}
