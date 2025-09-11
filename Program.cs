using System;
using System.Windows.Forms;

namespace PolyTrade_WebApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Start with Login form
            Application.Run(new Viren());
        }
    }
}
        