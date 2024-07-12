using EmployeeCRM.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeCRM.Services
{
    public enum FormNames
    {
        PasswordChangeForm,
        LoginForm,
        ShiftClockForm
    }

    internal static class NavigationService
    {

        public static void HandleCloseFormEvent(object sender, FormClosingEventArgs e, bool isNavigating)
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

        public static void CloseAllForms()
        {
            List<Form> openForms = new List<Form>(Application.OpenForms.Cast<Form>());
            openForms.ForEach(f => f.Close());
        }
        
        public static void ShowForm(FormNames formName,bool isNavigating)
        {
            isNavigating = true;
            CloseAllForms();
            Form form = formName switch
            {
                FormNames.PasswordChangeForm => new PasswordChangeForm(),
                FormNames.LoginForm => new LoginForm(),
                FormNames.ShiftClockForm => new ShiftClockForm(),
                _ => throw new ArgumentException("Invalid form name.", nameof(formName))
            };
            form.Show();
        }

    }
}
