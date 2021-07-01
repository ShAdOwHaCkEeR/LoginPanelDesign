
namespace LOGIN_PANEL
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Login_Button = new Guna.UI2.WinForms.Guna2Button();
            this.RegisterLabel = new System.Windows.Forms.LinkLabel();
            this.Register_Button = new Guna.UI2.WinForms.Guna2Button();
            this.RePassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.User_Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.UserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.RegisterBanner = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.guna2Panel1.Controls.Add(this.Login_Button);
            this.guna2Panel1.Controls.Add(this.RegisterLabel);
            this.guna2Panel1.Controls.Add(this.Register_Button);
            this.guna2Panel1.Controls.Add(this.RePassword);
            this.guna2Panel1.Controls.Add(this.Password);
            this.guna2Panel1.Controls.Add(this.User_Email);
            this.guna2Panel1.Controls.Add(this.UserName);
            this.guna2Panel1.Controls.Add(this.RegisterBanner);
            this.guna2Panel1.Location = new System.Drawing.Point(389, -3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(370, 455);
            this.guna2Panel1.TabIndex = 0;
            // 
            // Login_Button
            // 
            this.Login_Button.AutoRoundedCorners = true;
            this.Login_Button.BackColor = System.Drawing.Color.Transparent;
            this.Login_Button.BorderRadius = 16;
            this.Login_Button.CheckedState.Parent = this.Login_Button;
            this.Login_Button.CustomImages.Parent = this.Login_Button;
            this.Login_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Login_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Login_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Login_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Login_Button.DisabledState.Parent = this.Login_Button;
            this.Login_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.Login_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Login_Button.ForeColor = System.Drawing.Color.White;
            this.Login_Button.HoverState.Parent = this.Login_Button;
            this.Login_Button.Location = new System.Drawing.Point(225, 408);
            this.Login_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.ShadowDecoration.BorderRadius = 36;
            this.Login_Button.ShadowDecoration.Enabled = true;
            this.Login_Button.ShadowDecoration.Parent = this.Login_Button;
            this.Login_Button.Size = new System.Drawing.Size(117, 34);
            this.Login_Button.TabIndex = 8;
            this.Login_Button.Text = "Exit";
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RegisterLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.RegisterLabel.Location = new System.Drawing.Point(3, 421);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(100, 23);
            this.RegisterLabel.TabIndex = 7;
            this.RegisterLabel.TabStop = true;
            this.RegisterLabel.Text = "Back to login";
            this.RegisterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegisterLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLabel_LinkClicked);
            // 
            // Register_Button
            // 
            this.Register_Button.AutoRoundedCorners = true;
            this.Register_Button.BackColor = System.Drawing.Color.Transparent;
            this.Register_Button.BorderRadius = 16;
            this.Register_Button.CheckedState.Parent = this.Register_Button;
            this.Register_Button.CustomImages.Parent = this.Register_Button;
            this.Register_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Register_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Register_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Register_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Register_Button.DisabledState.Parent = this.Register_Button;
            this.Register_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.Register_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Register_Button.ForeColor = System.Drawing.Color.White;
            this.Register_Button.HoverState.Parent = this.Register_Button;
            this.Register_Button.Location = new System.Drawing.Point(225, 352);
            this.Register_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Register_Button.Name = "Register_Button";
            this.Register_Button.ShadowDecoration.BorderRadius = 36;
            this.Register_Button.ShadowDecoration.Enabled = true;
            this.Register_Button.ShadowDecoration.Parent = this.Register_Button;
            this.Register_Button.Size = new System.Drawing.Size(117, 34);
            this.Register_Button.TabIndex = 6;
            this.Register_Button.Text = "Register";
            this.Register_Button.Click += new System.EventHandler(this.Register_Button_Click);
            // 
            // RePassword
            // 
            this.RePassword.BorderRadius = 14;
            this.RePassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RePassword.DefaultText = "";
            this.RePassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RePassword.DisabledState.Parent = this.RePassword;
            this.RePassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RePassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RePassword.FocusedState.Parent = this.RePassword;
            this.RePassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RePassword.ForeColor = System.Drawing.Color.Black;
            this.RePassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RePassword.HoverState.Parent = this.RePassword;
            this.RePassword.Location = new System.Drawing.Point(68, 298);
            this.RePassword.Name = "RePassword";
            this.RePassword.PasswordChar = '\0';
            this.RePassword.PlaceholderText = "Repeat Password";
            this.RePassword.SelectedText = "";
            this.RePassword.ShadowDecoration.Parent = this.RePassword;
            this.RePassword.Size = new System.Drawing.Size(229, 31);
            this.RePassword.TabIndex = 5;
            this.RePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RePassword.Enter += new System.EventHandler(this.RePassword_Enter);
            this.RePassword.Leave += new System.EventHandler(this.RePassword_Leave);
            // 
            // Password
            // 
            this.Password.BorderRadius = 14;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.DefaultText = "";
            this.Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.DisabledState.Parent = this.Password;
            this.Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password.FocusedState.Parent = this.Password;
            this.Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Password.ForeColor = System.Drawing.Color.Black;
            this.Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password.HoverState.Parent = this.Password;
            this.Password.Location = new System.Drawing.Point(70, 239);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '\0';
            this.Password.PlaceholderText = "Password";
            this.Password.SelectedText = "";
            this.Password.ShadowDecoration.Parent = this.Password;
            this.Password.Size = new System.Drawing.Size(229, 31);
            this.Password.TabIndex = 4;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password.Enter += new System.EventHandler(this.Password_Enter);
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // User_Email
            // 
            this.User_Email.BorderRadius = 14;
            this.User_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.User_Email.DefaultText = "";
            this.User_Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.User_Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.User_Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.User_Email.DisabledState.Parent = this.User_Email;
            this.User_Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.User_Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.User_Email.FocusedState.Parent = this.User_Email;
            this.User_Email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.User_Email.ForeColor = System.Drawing.Color.Black;
            this.User_Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.User_Email.HoverState.Parent = this.User_Email;
            this.User_Email.Location = new System.Drawing.Point(70, 179);
            this.User_Email.Name = "User_Email";
            this.User_Email.PasswordChar = '\0';
            this.User_Email.PlaceholderText = "Email";
            this.User_Email.SelectedText = "";
            this.User_Email.ShadowDecoration.Parent = this.User_Email;
            this.User_Email.Size = new System.Drawing.Size(229, 31);
            this.User_Email.TabIndex = 3;
            this.User_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.User_Email.Enter += new System.EventHandler(this.User_Email_Enter);
            this.User_Email.Leave += new System.EventHandler(this.User_Email_Leave);
            // 
            // UserName
            // 
            this.UserName.BorderRadius = 14;
            this.UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserName.DefaultText = "";
            this.UserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserName.DisabledState.Parent = this.UserName;
            this.UserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserName.FocusedState.Parent = this.UserName;
            this.UserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UserName.ForeColor = System.Drawing.Color.Black;
            this.UserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserName.HoverState.Parent = this.UserName;
            this.UserName.Location = new System.Drawing.Point(70, 119);
            this.UserName.Name = "UserName";
            this.UserName.PasswordChar = '\0';
            this.UserName.PlaceholderText = "Username";
            this.UserName.SelectedText = "";
            this.UserName.ShadowDecoration.Parent = this.UserName;
            this.UserName.Size = new System.Drawing.Size(229, 31);
            this.UserName.TabIndex = 2;
            this.UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserName.Enter += new System.EventHandler(this.UserName_Enter);
            this.UserName.Leave += new System.EventHandler(this.UserName_Leave);
            // 
            // RegisterBanner
            // 
            this.RegisterBanner.BackColor = System.Drawing.Color.Transparent;
            this.RegisterBanner.Cursor = System.Windows.Forms.Cursors.Default;
            this.RegisterBanner.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.RegisterBanner.ForeColor = System.Drawing.Color.White;
            this.RegisterBanner.Location = new System.Drawing.Point(63, 37);
            this.RegisterBanner.Name = "RegisterBanner";
            this.RegisterBanner.Size = new System.Drawing.Size(236, 45);
            this.RegisterBanner.TabIndex = 1;
            this.RegisterBanner.Text = "Register";
            this.RegisterBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LOGIN_PANEL.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label RegisterBanner;
        private Guna.UI2.WinForms.Guna2TextBox UserName;
        private Guna.UI2.WinForms.Guna2TextBox RePassword;
        private Guna.UI2.WinForms.Guna2TextBox Password;
        private Guna.UI2.WinForms.Guna2TextBox User_Email;
        private Guna.UI2.WinForms.Guna2Button Register_Button;
        private System.Windows.Forms.LinkLabel RegisterLabel;
        private Guna.UI2.WinForms.Guna2Button Login_Button;
    }
}