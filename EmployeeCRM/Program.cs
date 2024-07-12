using EmployeeCRM.DAL;
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
            SeedService.EnsureDatabaseSetup();
            NavigationService.ShowForm(FormNames.ShiftClockForm, false);
            Application.Run();
        }
    }
}
