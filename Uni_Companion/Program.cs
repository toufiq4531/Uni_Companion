using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uni_Companion
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
            //Application.Run(new rent("22-40450-3"));
            //Application.Run(new profile("22-49451-3","student_home"));
            //Application.Run(new Buy("22-49451-3"));
            //Application.Run(new student_home("22-49450-3"));
            //Application.Run(new schedule_settings("22-49451-3"));
            //Application.Run(new forgetPass("22-49451-3"));
            //Application.Run(new recruitment("22-49451-3"));
            //Application.Run(new Flat_upload("2003"));
            //Application.Run(new Sign_In());
            Application.Run(new startPage());
            //Application.Run(new Admin());

        }
    }
}
