namespace EmployeeCRM
{
    partial class LoginForm
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
            this.textbox_tz = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.label_tz = new ReaLTaiizor.Controls.MaterialLabel();
            this.label_login = new System.Windows.Forms.Label();
            this.label_changePassword = new System.Windows.Forms.Label();
            this.label_password = new ReaLTaiizor.Controls.MaterialLabel();
            this.textbox_password = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.SuspendLayout();
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
            this.textbox_tz.Location = new System.Drawing.Point(56, 111);
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
            this.textbox_tz.TabIndex = 0;
            this.textbox_tz.TabStop = false;
            this.textbox_tz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textbox_tz.TrailingIcon = null;
            this.textbox_tz.UseSystemPasswordChar = false;
            // 
            // label_tz
            // 
            this.label_tz.AutoSize = true;
            this.label_tz.Depth = 0;
            this.label_tz.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_tz.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            this.label_tz.Location = new System.Drawing.Point(54, 84);
            this.label_tz.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_tz.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.label_tz.Name = "label_tz";
            this.label_tz.Size = new System.Drawing.Size(77, 24);
            this.label_tz.TabIndex = 1;
            this.label_tz.Text = "תעודת זהות";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_login.Location = new System.Drawing.Point(56, 272);
            this.label_login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_login.MinimumSize = new System.Drawing.Size(188, 39);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(188, 39);
            this.label_login.TabIndex = 4;
            this.label_login.Text = "כניסה";
            this.label_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_login.Click += new System.EventHandler(this.label_login_Click);
            // 
            // label_changePassword
            // 
            this.label_changePassword.AutoSize = true;
            this.label_changePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label_changePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_changePassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_changePassword.Location = new System.Drawing.Point(56, 336);
            this.label_changePassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_changePassword.MinimumSize = new System.Drawing.Size(188, 39);
            this.label_changePassword.Name = "label_changePassword";
            this.label_changePassword.Size = new System.Drawing.Size(188, 39);
            this.label_changePassword.TabIndex = 5;
            this.label_changePassword.Text = "החלפת ססמא";
            this.label_changePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_changePassword.Click += new System.EventHandler(this.label_changePassword_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Depth = 0;
            this.label_password.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_password.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            this.label_password.Location = new System.Drawing.Point(54, 171);
            this.label_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_password.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(41, 24);
            this.label_password.TabIndex = 7;
            this.label_password.Text = "ססמא";
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
            this.textbox_password.Location = new System.Drawing.Point(56, 198);
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
            this.textbox_password.TabIndex = 6;
            this.textbox_password.TabStop = false;
            this.textbox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textbox_password.TrailingIcon = null;
            this.textbox_password.UseSystemPasswordChar = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 466);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textbox_password);
            this.Controls.Add(this.label_changePassword);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.label_tz);
            this.Controls.Add(this.textbox_tz);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "כניסה למערכת";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit textbox_tz;
        private ReaLTaiizor.Controls.MaterialLabel label_tz;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_changePassword;
        private ReaLTaiizor.Controls.MaterialLabel label_password;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit textbox_password;
    }
}