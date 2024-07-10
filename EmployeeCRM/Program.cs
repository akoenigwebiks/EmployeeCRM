using EmployeeCRM.Services;
using System;
using System.Windows.Forms;

namespace EmployeeCRM
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
            NavigationService.ShowForm(FormNames.LoginForm);
            Application.Run();
        }
    }
}
