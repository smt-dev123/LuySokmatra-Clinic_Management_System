﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuySokmatra_ClinicManagementSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmLogin());
            //Application.Run(new FrmMainMenu());
            //Application.Run(new FrmEnterDoctor());
            //Application.Run(new FrmRoom());
            Application.Run(new FrmTest());
        }
    }
}
