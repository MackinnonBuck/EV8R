﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EV8R
{
    static class Program
    {
        /// <summary>
        /// The global LoginDialog instance.
        /// </summary>
        public static LoginDialog LoginDialog { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginDialog = new LoginDialog();

            Application.Run(new MainWindow());
        }
    }
}
