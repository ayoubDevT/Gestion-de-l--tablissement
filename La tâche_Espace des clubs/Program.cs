﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace La_tâche_Espace_des_clubs
{
    static class Program
    {
        public static Liste_des_club l;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            l = new Liste_des_club();
            Application.Run(l);
        }
    }
}
