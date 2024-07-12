namespace EmployeeCRM.Forms
{
    partial class PasswordChangeForm
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
            this.label_password = new ReaLTaiizor.Controls.MaterialLabel();
            this.textbox_password = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.label_changePassword = new System.Windows.Forms.Label();
            this.label_cancel = new System.Windows.Forms.Label();
            this.label_tz = new ReaLTaiizor.Controls.MaterialLabel();
            this.textbox_tz = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.label_newPassword1 = new ReaLTaiizor.Controls.MaterialLabel();
            this.textbox_newPassword1 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.label_newPassword2 = new ReaLTaiizor.Controls.MaterialLabel();
            this.textbox_newPassword2 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.SuspendLayout();
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Depth = 0;
            this.label_password.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_password.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            this.label_password.Location = new System.Drawing.Point(50, 174);
            this.label_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_password.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(88, 24);
            this.label_password.TabIndex = 13;
            this.label_password.Text = "ססמה נוכחית";
            // 
            // textbox_password
            // 
            this.textbox_password.AnimateReadOnly = false;
            this.textbox_password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textbox_password.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textbox_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textbox_password.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textbox_password.Depth = 0;
            this.textbox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textbox_password.HideSelection = true;
            this.textbox_password.LeadingIcon = null;
            this.textbox_password.Location = new System.Drawing.Point(52, 202);
            this.textbox_password.Margin = new System.Windows.Forms.Padding(2);
            this.textbox_password.MaxLength = 32767;
            this.textbox_password.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.PasswordChar = '\0';
            this.textbox_password.PrefixSuffixText = null;
            this.textbox_password.ReadOnly = false;
            this.textbox_password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textbox_password.SelectedText = "";
            this.textbox_password.SelectionLength = 0;
            this.textbox_password.SelectionStart = 0;
            this.textbox_password.ShortcutsEnabled = true;
            this.textbox_password.Size = new System.Drawing.Size(188, 48);
            this.textbox_password.TabIndex = 12;
            this.textbox_password.TabStop = false;
            this.textbox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textbox_password.TrailingIcon = null;
            this.textbox_password.UseSystemPasswordChar = false;
            // 
            // label_changePassword
            // 
            this.label_changePassword.AutoSize = true;
            this.label_changePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label_changePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_changePassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_changePassword.Location = new System.Drawing.Point(52, 574);
            this.label_changePassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_changePassword.MinimumSize = new System.Drawing.Size(188, 39);
            this.label_changePassword.Name = "label_changePassword";
            this.label_changePassword.Size = new System.Drawing.Size(188, 39);
            this.label_changePassword.TabIndex = 11;
            this.label_changePassword.Text = "החלפת ססמא";
            this.label_changePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_changePassword.Click += new System.EventHandler(this.label_changePassword_Click);
            // 
            // label_cancel
            // 
            this.label_cancel.AutoSize = true;
            this.label_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(54)))));
            this.label_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_cancel.Location = new System.Drawing.Point(52, 510);
            this.label_cancel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_cancel.MinimumSize = new System.Drawing.Size(188, 39);
            this.label_cancel.Name = "label_cancel";
            this.label_cancel.Size = new System.Drawing.Size(188, 39);
            this.label_cancel.TabIndex = 10;
            this.label_cancel.Text = "ביטול";
            this.label_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_cancel.Click += new System.EventHandler(this.label_cancel_Click);
            // 
            // label_tz
            // 
            this.label_tz.AutoSize = true;
            this.label_tz.Depth = 0;
            this.label_tz.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_tz.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            this.label_tz.Location = new System.Drawing.Point(50, 87);
            this.label_tz.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_tz.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.label_tz.Name = "label_tz";
            this.label_tz.Size = new System.Drawing.Size(77, 24);
            this.label_tz.TabIndex = 9;
            this.label_tz.Text = "תעודת זהות";
            // 
            // textbox_tz
            // 
            this.textbox_tz.AnimateReadOnly = false;
            this.textbox_tz.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textbox_tz.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textbox_tz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textbox_tz.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textbox_tz.Depth = 0;
            this.textbox_tz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textbox_tz.HideSelection = true;
            this.textbox_tz.LeadingIcon = null;
            this.textbox_tz.Location = new System.Drawing.Point(52, 115);
            this.textbox_tz.Margin = new System.Windows.Forms.Padding(2);
            this.textbox_tz.MaxLength = 32767;
            this.textbox_tz.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.textbox_tz.Name = "textbox_tz";
            this.textbox_tz.PasswordChar = '\0';
            this.textbox_tz.PrefixSuffixText = null;
            this.textbox_tz.ReadOnly = false;
            this.textbox_tz.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textbox_tz.SelectedText = "";
            this.textbox_tz.SelectionLength = 0;
            this.textbox_tz.SelectionStart = 0;
            this.textbox_tz.ShortcutsEnabled = true;
            this.textbox_tz.Size = new System.Drawing.Size(188, 48);
            this.textbox_tz.TabIndex = 8;
            this.textbox_tz.TabStop = false;
            this.textbox_tz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textbox_tz.TrailingIcon = null;
            this.textbox_tz.UseSystemPasswordChar = false;
            // 
            // label_newPassword1
            // 
            this.label_newPassword1.AutoSize = true;
            this.label_newPassword1.Depth = 0;
            this.label_newPassword1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_newPassword1.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            this.label_newPassword1.Location = new System.Drawing.Point(50, 292);
            this.label_newPassword1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_newPassword1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.label_newPassword1.Name = "label_newPassword1";
            this.label_newPassword1.Size = new System.Drawing.Size(84, 24);
            this.label_newPassword1.TabIndex = 15;
            this.label_newPassword1.Text = "ססמה חדשה";
            // 
            // textbox_newPassword1
            // 
            this.textbox_newPassword1.AnimateReadOnly = false;
            this.textbox_newPassword1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textbox_newPassword1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textbox_newPassword1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textbox_newPassword1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textbox_newPassword1.Depth = 0;
            this.textbox_newPassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textbox_newPassword1.HideSelection = true;
            this.textbox_newPassword1.LeadingIcon = null;
            this.textbox_newPassword1.Location = new System.Drawing.Point(52, 320);
            this.textbox_newPassword1.Margin = new System.Windows.Forms.Padding(2);
            this.textbox_newPassword1.MaxLength = 32767;
            this.textbox_newPassword1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.textbox_newPassword1.Name = "textbox_newPassword1";
            this.textbox_newPassword1.PasswordChar = '\0';
            this.textbox_newPassword1.PrefixSuffixText = null;
            this.textbox_newPassword1.ReadOnly = false;
            this.textbox_newPassword1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textbox_newPassword1.SelectedText = "";
            this.textbox_newPassword1.SelectionLength = 0;
            this.textbox_newPassword1.SelectionStart = 0;
            this.textbox_newPassword1.ShortcutsEnabled = true;
            this.textbox_newPassword1.Size = new System.Drawing.Size(188, 48);
            this.textbox_newPassword1.TabIndex = 14;
            this.textbox_newPassword1.TabStop = false;
            this.textbox_newPassword1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textbox_newPassword1.TrailingIcon = null;
            this.textbox_newPassword1.UseSystemPasswordChar = false;
            // 
            // label_newPassword2
            // 
            this.label_newPassword2.AutoSize = true;
            this.label_newPassword2.Depth = 0;
            this.label_newPassword2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_newPassword2.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            this.label_newPassword2.Location = new System.Drawing.Point(50, 377);
            this.label_newPassword2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_newPassword2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.label_newPassword2.Name = "label_newPassword2";
            this.label_newPassword2.Size = new System.Drawing.Size(180, 24);
            this.label_newPassword2.TabIndex = 17;
            this.label_newPassword2.Text = "ססמה חדשה בשנית לאישור";
            // 
            // textbox_newPassword2
            // 
            this.textbox_newPassword2.AnimateReadOnly = false;
            this.textbox_newPassword2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textbox_newPassword2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textbox_newPassword2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textbox_newPassword2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textbox_newPassword2.Depth = 0;
            this.textbox_newPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textbox_newPassword2.HideSelection = true;
            this.textbox_newPassword2.LeadingIcon = null;
            this.textbox_newPassword2.Location = new System.Drawing.Point(52, 405);
            this.textbox_newPassword2.Margin = new System.Windows.Forms.Padding(2);
            this.textbox_newPassword2.MaxLength = 32767;
            this.textbox_newPassword2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.textbox_newPassword2.Name = "textbox_newPassword2";
            this.textbox_newPassword2.PasswordChar = '\0';
            this.textbox_newPassword2.PrefixSuffixText = null;
            this.textbox_newPassword2.ReadOnly = false;
            this.textbox_newPassword2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textbox_newPassword2.SelectedText = "";
            this.textbox_newPassword2.SelectionLength = 0;
            this.textbox_newPassword2.SelectionStart = 0;
            this.textbox_newPassword2.ShortcutsEnabled = true;
            this.textbox_newPassword2.Size = new System.Drawing.Size(188, 48);
            this.textbox_newPassword2.TabIndex = 16;
            this.textbox_newPassword2.TabStop = false;
            this.textbox_newPassword2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textbox_newPassword2.TrailingIcon = null;
            this.textbox_newPassword2.UseSystemPasswordChar = false;
            // 
            // PasswordChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 708);
            this.Controls.Add(this.label_newPassword2);
            this.Controls.Add(this.textbox_newPassword2);
            this.Controls.Add(this.label_newPassword1);
            this.Controls.Add(this.textbox_newPassword1);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textbox_password);
            this.Controls.Add(this.label_changePassword);
            this.Controls.Add(this.label_cancel);
            this.Controls.Add(this.label_tz);
            this.Controls.Add(this.textbox_tz);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PasswordChangeForm";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "החלפת סיסמה";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialLabel label_password;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit textbox_password;
        private System.Windows.Forms.Label label_changePassword;
        private System.Windows.Forms.Label label_cancel;
        private ReaLTaiizor.Controls.MaterialLabel label_tz;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit textbox_tz;
        private ReaLTaiizor.Controls.MaterialLabel label_newPassword1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit textbox_newPassword1;
        private ReaLTaiizor.Controls.MaterialLabel label_newPassword2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit textbox_newPassword2;
    }
}