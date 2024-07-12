using EmployeeCRM.Services;
using System.Windows.Forms;

namespace EmployeeCRM
{
    internal partial class LoginForm : ReaLTaiizor.Forms.MaterialForm
    {
        private bool isNavigating = false;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label_changePassword_Click(object sender, System.EventArgs e) =>
            NavigationService.ShowForm(FormNames.PasswordChangeForm, ref isNavigating);


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) =>
            NavigationService.HandleCloseFormEvent(sender, e, isNavigating);


        private void label_login_Click(object sender, System.EventArgs e)
        {
            string tz = textbox_tz.Text; // תעודת זהות
            string password = textbox_password.Text;

            if (string.IsNullOrEmpty(tz) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("נא להזין פרטים בשדות");
                return;
            }

            AuthResult authResult = AuthService.Login(tz, password);

            switch (authResult)
            {
                case AuthResult.Success:
                    MessageBox.Show("התחברת בהצלחה");
                    NavigationService.ShowForm(FormNames.ShiftClockForm, ref isNavigating);

                    // TODO - Navigate to the main form when it's ready
                    return;
                case AuthResult.PasswordExpired:
                    MessageBox.Show("הסיסמה פגה");
                    NavigationService.ShowForm(FormNames.PasswordChangeForm, ref isNavigating);
                    return;
            }

            string errorMessage = authResult switch
            {
                AuthResult.InvalidCredentials => "פרטי הכניסה שגויים",
                AuthResult.NoAccess => "אין לך גישה למערכת",
                AuthResult.Error => "שגיאה בהתחברות",
                _ => "שגיאה בהתחברות"
            };

            MessageBox.Show(errorMessage);
        }
    }
}
