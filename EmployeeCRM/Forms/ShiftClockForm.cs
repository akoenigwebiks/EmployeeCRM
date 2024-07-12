using EmployeeCRM.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace EmployeeCRM.Forms
{
    public partial class ShiftClockForm : ReaLTaiizor.Forms.MaterialForm
    {
        private bool isNavigating = false;

        public ShiftClockForm()
        {
            InitializeComponent();
            LoadShiftRecords();
        }

        private void LoadShiftRecords()
        {
            // TODO - Implement the logic to load the shift records
            DataTable shiftRecords = AuthService.GetShiftRecords();
            DateTime entry = (DateTime)shiftRecords.Rows[0]["EntryTime"];
            DateTime? exit = shiftRecords.Rows[0]["ExitTime"] as DateTime?;

            dateTimePicker_lastEntry.Value = entry;

            ToggleDateTimePicker(dateTimePicker_lastExit, !exit.HasValue);
            if (exit.HasValue)
            {
                dateTimePicker_lastExit.Value = exit.Value;
            }
        }

        private void label_cancel_Click(object sender, System.EventArgs e)
        {
            NavigationService.ShowForm(FormNames.LoginForm, ref isNavigating);
        }

        private void label_clockIn_Click(object sender, System.EventArgs e)
        {
            bool result = AuthService.ClockIn();
            string message = result ? "נכנסת בהצלחה" : "שגיאה בעת כניסה";
            MessageBox.Show(message);
            if (result) dateTimePicker_lastEntry.Value = DateTime.Now;
        }

        private void label_clockOut_Click(object sender, System.EventArgs e)
        {
            bool result = AuthService.ClockOut();
            string message = result ? "יצאת בהצלחה" : "שגיאה בעת יציאה";
            MessageBox.Show(message);
            ToggleDateTimePicker(picker: dateTimePicker_lastExit, setNull: !result);
            if (result) dateTimePicker_lastExit.Value = DateTime.Now;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            NavigationService.HandleCloseFormEvent(sender, e, isNavigating);
        }

        private void ToggleDateTimePicker(DateTimePicker picker,bool setNull)
        {
            picker.Format = setNull ? DateTimePickerFormat.Custom : DateTimePickerFormat.Long;
            picker.CustomFormat = setNull ? " " : null;
        }
    }
}
