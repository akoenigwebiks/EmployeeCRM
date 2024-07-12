using EmployeeCRM.DAL;
using EmployeeCRM.Services;
using System;
using System.Data;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace EmployeeCRM
{
    internal partial class LoginForm : ReaLTaiizor.Forms.MaterialForm
    {
        private bool isNavigating = false;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label_changePassword_Click(object sender, System.EventArgs e)
        {
            NavigateTo(FormNames.PasswordChangeForm);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isNavigating && e.CloseReason == CloseReason.UserClosing)
            {
                string confirmExitQuestion = "האם ברצונך לצאת מהמערכת?";
                string confirmExitTitle = "אשר יציאה מהמערכת";
                DialogResult dialogResult = MessageBox.Show(confirmExitQuestion, confirmExitTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                    return;
                }
                e.Cancel = true;
            }
        }

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
                    NavigateTo(FormNames.PasswordChangeForm);
                    // TODO - Navigate to the main form when it's ready
                    return;
                case AuthResult.PasswordExpired:
                    MessageBox.Show("הסיסמה פגה");
                    NavigateTo(FormNames.PasswordChangeForm);
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

        private void NavigateTo(FormNames formName)
        {
            isNavigating = true;
            NavigationService.ShowForm(formName);
        }
    }
}
