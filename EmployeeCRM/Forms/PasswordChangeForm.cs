using EmployeeCRM.Services;
using System;
using System.Windows.Forms;

namespace EmployeeCRM.Forms
{
    public partial class PasswordChangeForm : ReaLTaiizor.Forms.MaterialForm
    {
        private string _Tz;
        public PasswordChangeForm()
        {
            InitializeComponent();
            _Tz = AuthService.Tz;
        }

        private void label_cancel_Click(object sender, EventArgs e)
        {
            NavigationService.ShowForm(FormNames.LoginForm);
        }

        private void label_changePassword_Click(object sender, EventArgs e)
        {
            _Tz = textbox_tz.Text;
            string oldPassword = textbox_password.Text;
            string newPassword = textbox_newPassword1.Text;
            string newPassword2 = textbox_newPassword2.Text;


            string message = newPassword switch
            {
                _ when string.IsNullOrEmpty(_Tz) || string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(newPassword2) => "נא למלא את כל השדות",
                _ when newPassword != newPassword2 => "הסיסמאות החדשות אינן תואמות",
                _ when oldPassword == newPassword => "הסיסמה החדשה זהה לסיסמה הישנה",
                _ => string.Empty
            };
             
            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show(message);
                return;
            }

            bool success = AuthService.ChangePassword(_Tz, oldPassword, newPassword);
            if (success)
            {
                MessageBox.Show("הסיסמה שונתה בהצלחה");
                NavigationService.ShowForm(FormNames.LoginForm);
                // TODO - Navigate to the main form when it's ready
            }
            else
            {
                MessageBox.Show("שגיאה בעת שינוי הסיסמה");
            }
        }
    }
}
