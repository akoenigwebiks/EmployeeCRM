using EmployeeCRM.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeCRM.Forms
{
    public partial class PasswordChangeForm : ReaLTaiizor.Forms.MaterialForm
    {
        public PasswordChangeForm()
        {
            InitializeComponent();
        }

        private void label_login_Click(object sender, EventArgs e)
        {
            NavigationService.ShowForm(FormNames.LoginForm);
        }
    }
}
