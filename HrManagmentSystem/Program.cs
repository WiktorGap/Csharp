using System;
using System.Windows.Forms;

namespace HrManagmentSystem
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Uruchamiamy bezpośrednio główny formularz
            Application.Run(new Form1());
        }
    }
}
