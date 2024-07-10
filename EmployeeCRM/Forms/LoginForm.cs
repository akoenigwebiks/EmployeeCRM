using EmployeeCRM.DAL;
using EmployeeCRM.Services;
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
            isNavigating = true;
            NavigationService.ShowForm(FormNames.PasswordChangeForm);
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

            // Ensure the password is treated as a string in the SQL query
            string query = $@"SELECT Employees.EmployeeNat, Passwords.EmployeePassword
                      FROM Employees
                      JOIN Passwords ON Employees.ID = Passwords.EmployeeID
                      WHERE Employees.EmployeeNat = '{tz}' 
                      AND Passwords.EmployeePassword = '{password}';";

            // Validate using Dbcontext
            DataTable findUser = DBContext.MakeQuery(query);

            // Check if a user was found
            if (findUser.Rows.Count > 0)
            {
                MessageBox.Show("התחברת בהצלחה!");
                // Proceed to the next part of your application
                // For example, open a new form or dashboard
            }
            else
            {
                MessageBox.Show("פרטים שגויים, אנא נסה שוב.");
            }
        }

    }
}
