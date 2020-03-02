using System;
using System.Linq;
using System.Windows.Forms;

namespace Dina_QAS
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
            Application.Run(new SYSTEM.Intro());
        }
    }
}