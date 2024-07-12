namespace EmployeeCRM.Forms
{
    partial class ShiftClockForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_cancel = new System.Windows.Forms.Label();
            this.label_clockIn = new System.Windows.Forms.Label();
            this.groupbox_container = new ReaLTaiizor.Controls.ParrotGroupBox();
            this.groupBox_lastEntry = new ReaLTaiizor.Controls.ParrotGroupBox();
            this.dateTimePicker_lastEntry = new System.Windows.Forms.DateTimePicker();
            this.groupBox_lastExit = new ReaLTaiizor.Controls.ParrotGroupBox();
            this.dateTimePicker_lastExit = new System.Windows.Forms.DateTimePicker();
            this.label_clockOut = new System.Windows.Forms.Label();
            this.groupbox_container.SuspendLayout();
            this.groupBox_lastEntry.SuspendLayout();
            this.groupBox_lastExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_cancel
            // 
            this.label_cancel.AutoSize = true;
            this.label_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(54)))));
            this.label_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_cancel.Location = new System.Drawing.Point(70, 436);
            this.label_cancel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_cancel.MinimumSize = new System.Drawing.Size(188, 40);
            this.label_cancel.Name = "label_cancel";
            this.label_cancel.Size = new System.Drawing.Size(188, 40);
            this.label_cancel.TabIndex = 12;
            this.label_cancel.Text = "ביטול";
            this.label_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_cancel.Click += new System.EventHandler(this.label_cancel_Click);
            // 
            // label_clockIn
            // 
            this.label_clockIn.AutoSize = true;
            this.label_clockIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.label_clockIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_clockIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_clockIn.Location = new System.Drawing.Point(197, 199);
            this.label_clockIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_clockIn.MinimumSize = new System.Drawing.Size(90, 90);
            this.label_clockIn.Name = "label_clockIn";
            this.label_clockIn.Size = new System.Drawing.Size(90, 90);
            this.label_clockIn.TabIndex = 14;
            this.label_clockIn.Text = "כניסה";
            this.label_clockIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_clockIn.Click += new System.EventHandler(this.label_clockIn_Click);
            // 
            // groupbox_container
            // 
            this.groupbox_container.BorderColor = System.Drawing.Color.Gray;
            this.groupbox_container.BorderWidth = 1;
            this.groupbox_container.Controls.Add(this.groupBox_lastEntry);
            this.groupbox_container.Controls.Add(this.groupBox_lastExit);
            this.groupbox_container.Controls.Add(this.label_clockOut);
            this.groupbox_container.Controls.Add(this.label_clockIn);
            this.groupbox_container.Location = new System.Drawing.Point(16, 82);
            this.groupbox_container.Name = "groupbox_container";
            this.groupbox_container.ShowText = true;
            this.groupbox_container.Size = new System.Drawing.Size(304, 315);
            this.groupbox_container.TabIndex = 15;
            this.groupbox_container.TabStop = false;
            this.groupbox_container.Text = "החתמת שעון";
            this.groupbox_container.TextColor = System.Drawing.Color.Gray;
            // 
            // groupBox_lastEntry
            // 
            this.groupBox_lastEntry.BorderColor = System.Drawing.Color.Gray;
            this.groupBox_lastEntry.BorderWidth = 1;
            this.groupBox_lastEntry.Controls.Add(this.dateTimePicker_lastEntry);
            this.groupBox_lastEntry.Location = new System.Drawing.Point(46, 39);
            this.groupBox_lastEntry.Name = "groupBox_lastEntry";
            this.groupBox_lastEntry.ShowText = true;
            this.groupBox_lastEntry.Size = new System.Drawing.Size(219, 49);
            this.groupBox_lastEntry.TabIndex = 18;
            this.groupBox_lastEntry.TabStop = false;
            this.groupBox_lastEntry.Text = "יציאה אחרונה";
            this.groupBox_lastEntry.TextColor = System.Drawing.Color.Gray;
            // 
            // dateTimePicker_lastEntry
            // 
            this.dateTimePicker_lastEntry.Enabled = false;
            this.dateTimePicker_lastEntry.Location = new System.Drawing.Point(6, 19);
            this.dateTimePicker_lastEntry.Name = "dateTimePicker_lastEntry";
            this.dateTimePicker_lastEntry.Size = new System.Drawing.Size(207, 20);
            this.dateTimePicker_lastEntry.TabIndex = 16;
            // 
            // groupBox_lastExit
            // 
            this.groupBox_lastExit.BorderColor = System.Drawing.Color.Gray;
            this.groupBox_lastExit.BorderWidth = 1;
            this.groupBox_lastExit.Controls.Add(this.dateTimePicker_lastExit);
            this.groupBox_lastExit.Location = new System.Drawing.Point(46, 127);
            this.groupBox_lastExit.Name = "groupBox_lastExit";
            this.groupBox_lastExit.ShowText = true;
            this.groupBox_lastExit.Size = new System.Drawing.Size(219, 49);
            this.groupBox_lastExit.TabIndex = 17;
            this.groupBox_lastExit.TabStop = false;
            this.groupBox_lastExit.Text = "יציאה אחרונה";
            this.groupBox_lastExit.TextColor = System.Drawing.Color.Gray;
            // 
            // dateTimePicker_lastExit
            // 
            this.dateTimePicker_lastExit.Enabled = false;
            this.dateTimePicker_lastExit.Location = new System.Drawing.Point(6, 19);
            this.dateTimePicker_lastExit.Name = "dateTimePicker_lastExit";
            this.dateTimePicker_lastExit.Size = new System.Drawing.Size(207, 20);
            this.dateTimePicker_lastExit.TabIndex = 16;
            // 
            // label_clockOut
            // 
            this.label_clockOut.AutoSize = true;
            this.label_clockOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(59)))));
            this.label_clockOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_clockOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_clockOut.Location = new System.Drawing.Point(20, 199);
            this.label_clockOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_clockOut.MinimumSize = new System.Drawing.Size(90, 90);
            this.label_clockOut.Name = "label_clockOut";
            this.label_clockOut.Size = new System.Drawing.Size(90, 90);
            this.label_clockOut.TabIndex = 15;
            this.label_clockOut.Text = "יציאה";
            this.label_clockOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_clockOut.Click += new System.EventHandler(this.label_clockOut_Click);
            // 
            // ShiftClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 519);
            this.Controls.Add(this.groupbox_container);
            this.Controls.Add(this.label_cancel);
            this.Name = "ShiftClockForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "החתמת שעון";
            this.groupbox_container.ResumeLayout(false);
            this.groupbox_container.PerformLayout();
            this.groupBox_lastEntry.ResumeLayout(false);
            this.groupBox_lastEntry.PerformLayout();
            this.groupBox_lastExit.ResumeLayout(false);
            this.groupBox_lastExit.PerformLayout();
            this.FormClosing += MainForm_FormClosing;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_cancel;
        private System.Windows.Forms.Label label_clockIn;
        private ReaLTaiizor.Controls.ParrotGroupBox groupbox_container;
        private System.Windows.Forms.Label label_clockOut;
        private ReaLTaiizor.Controls.ParrotGroupBox groupBox_lastExit;
        private ReaLTaiizor.Controls.ParrotGroupBox groupBox_lastEntry;
        private System.Windows.Forms.DateTimePicker dateTimePicker_lastEntry;
        private System.Windows.Forms.DateTimePicker dateTimePicker_lastExit;
    }
}