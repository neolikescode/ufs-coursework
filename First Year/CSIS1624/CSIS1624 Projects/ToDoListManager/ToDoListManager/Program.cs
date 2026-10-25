// Name: Neo Kgatla
// Student Number: 2029139488
// Practical: 6
// Date: 27/08/2026

using System;
using System.Windows.Forms;

namespace ToDoListManager
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
            Application.Run(new CfrmMain());
        }
    }
}
