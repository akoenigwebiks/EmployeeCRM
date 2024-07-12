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
            string query = $@"SELECT Employees.EmployeeNat, Passwords.EmployeePassword, Passwords.HasAccess, Passwords.ExpiryDate
                                  FROM Employees
                                  JOIN Passwords ON Employees.ID = Passwords.EmployeeID
                                  WHERE Employees.EmployeeNat = '{tz}' 
                                  AND Passwords.EmployeePassword = '{password}';";

            // Validate using Dbcontext
            DataTable findUser = DBContext.MakeQuery(query);


            string reenterPassword = "פרטים שגויים, אנא נסה שוב.";
            if (findUser.Rows.Count == 0)
            {
                MessageBox.Show(reenterPassword);
                return;
            }

            // Check if the password has expired or the user hasaccess is 0
            DataRow user = findUser.Rows[0];
            bool hasAccess = (bool)user["HasAccess"];
            DateTime expiryDate = (DateTime)user["ExpiryDate"];

            if (!hasAccess)
            {
                MessageBox.Show(reenterPassword);
                return;
            }

            if (expiryDate < DateTime.Now)
            {
                isNavigating = true;
                MessageBox.Show("סיסמה פגה, נא לפנות למנהל המערכת.");
                NavigationService.ShowForm(FormNames.PasswordChangeForm);
                return;
            }


            MessageBox.Show("התחברת בהצלחה!");

        }

    }
}
