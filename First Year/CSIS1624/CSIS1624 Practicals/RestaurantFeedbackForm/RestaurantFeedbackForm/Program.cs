/* Neo Kgatla
 * 2029139488
 * Practical 4
 * 13/08/2026
 */
using System;
using System.Windows.Forms;

namespace RestaurantFeedbackForm
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
