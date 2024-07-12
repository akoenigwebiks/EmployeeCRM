using EmployeeCRM.Services;
using System.Windows.Forms;

namespace EmployeeCRM.Forms
{
    public partial class ShiftClockForm : ReaLTaiizor.Forms.MaterialForm
    {
        private bool isNavigating = false;

        public ShiftClockForm()
        {
            InitializeComponent();
        }

        private void label_cancel_Click(object sender, System.EventArgs e)
        {
            NavigationService.ShowForm(FormNames.LoginForm, isNavigating);
        }

        private void label_clockIn_Click(object sender, System.EventArgs e)
        {

        }

        private void label_clockOut_Click(object sender, System.EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            NavigationService.HandleCloseFormEvent(sender, e, isNavigating);
        }
    }
}
