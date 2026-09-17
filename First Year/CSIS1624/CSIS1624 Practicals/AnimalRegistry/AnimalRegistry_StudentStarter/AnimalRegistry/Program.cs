/*Neo Kgatla
 *2029139488
 *Practical 8
 *17/09/2026
 */
using System;
using System.Windows.Forms;

namespace AnimalRegistry
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CfrmMain());
        }
    }
}
