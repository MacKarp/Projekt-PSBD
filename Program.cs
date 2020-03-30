using System;
using System.Windows.Forms;
using Projekt_PSBD.Formularze;

namespace Projekt_PSBD
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Panel_logowania());
        }
    }
}
