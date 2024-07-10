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
        LoginForm
    }

    internal static class NavigationService
    {
    
        public static void CloseAllForms()
        {
            List<Form> openForms = new List<Form>(Application.OpenForms.Cast<Form>());
            openForms.ForEach(f => f.Close());
        }
        public static void ShowForm(FormNames formName)
        {
            CloseAllForms();
            Form form = formName switch
            {
                FormNames.PasswordChangeForm => new PasswordChangeForm(),
                FormNames.LoginForm => new LoginForm(),
                _ => throw new ArgumentException("Invalid form name.", nameof(formName))
            };
            form.Show();
        }

    }
}
