﻿using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DXApplication1;
using DXApplication1.RJControls;
using DXApplication1.Statup.Information_user;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;



namespace DXApplication1
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
            Application.Run(new XtraForm1());



        }

    }
}
