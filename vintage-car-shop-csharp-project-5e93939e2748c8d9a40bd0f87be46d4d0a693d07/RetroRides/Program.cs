using RetroRides.Utilities;
using System;
using System.Windows.Forms;

namespace RetroRides
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(FormManager.GetLoginForm());


        }

        static void GlobalExceptionHandler(object sender, EventArgs e)
        {
            MessageBox.Show("An unhandled exception occurred!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}