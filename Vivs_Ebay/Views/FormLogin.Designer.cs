namespace Vivs_Ebay.Views
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelGuest = new Label();
            labelUser = new Label();
            buttonGuestLogin = new Button();
            buttonUserLogin = new Button();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            labelUsername = new Label();
            labelPassword = new Label();
            checkBoxReturning = new CheckBox();
            checkBoxNewUser = new CheckBox();
            SuspendLayout();
            // 
            // labelGuest
            // 
            labelGuest.AutoSize = true;
            labelGuest.Location = new Point(172, 30);
            labelGuest.Name = "labelGuest";
            labelGuest.Size = new Size(132, 25);
            labelGuest.TabIndex = 0;
            labelGuest.Text = "Log in as guest";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Location = new Point(172, 196);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(121, 25);
            labelUser.TabIndex = 1;
            labelUser.Text = "Log in as user";
            // 
            // buttonGuestLogin
            // 
            buttonGuestLogin.Location = new Point(150, 72);
            buttonGuestLogin.Name = "buttonGuestLogin";
            buttonGuestLogin.Size = new Size(181, 64);
            buttonGuestLogin.TabIndex = 2;
            buttonGuestLogin.Text = "Guest Login";
            buttonGuestLogin.UseVisualStyleBackColor = true;
            buttonGuestLogin.Click += buttonGuestLogin_Click;
            // 
            // buttonUserLogin
            // 
            buttonUserLogin.Location = new Point(150, 458);
            buttonUserLogin.Name = "buttonUserLogin";
            buttonUserLogin.Size = new Size(181, 63);
            buttonUserLogin.TabIndex = 3;
            buttonUserLogin.Text = "User Login";
            buttonUserLogin.UseVisualStyleBackColor = true;
            buttonUserLogin.Click += buttonUserLogin_Click;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(129, 309);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(240, 31);
            textBoxUsername.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(129, 387);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(240, 31);
            textBoxPassword.TabIndex = 5;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(129, 281);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(91, 25);
            labelUsername.TabIndex = 6;
            labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(129, 359);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(87, 25);
            labelPassword.TabIndex = 7;
            labelPassword.Text = "Password";
            // 
            // checkBoxReturning
            // 
            checkBoxReturning.AutoSize = true;
            checkBoxReturning.Location = new Point(129, 239);
            checkBoxReturning.Name = "checkBoxReturning";
            checkBoxReturning.Size = new Size(114, 29);
            checkBoxReturning.TabIndex = 8;
            checkBoxReturning.Text = "Returning";
            checkBoxReturning.UseVisualStyleBackColor = true;
            // 
            // checkBoxNewUser
            // 
            checkBoxNewUser.AutoSize = true;
            checkBoxNewUser.Location = new Point(256, 239);
            checkBoxNewUser.Name = "checkBoxNewUser";
            checkBoxNewUser.Size = new Size(113, 29);
            checkBoxNewUser.TabIndex = 9;
            checkBoxNewUser.Text = "New User";
            checkBoxNewUser.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(477, 552);
            Controls.Add(checkBoxNewUser);
            Controls.Add(checkBoxReturning);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(buttonUserLogin);
            Controls.Add(buttonGuestLogin);
            Controls.Add(labelUser);
            Controls.Add(labelGuest);
            Name = "FormLogin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelGuest;
        private Label labelUser;
        private Button buttonGuestLogin;
        private Button buttonUserLogin;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label labelUsername;
        private Label labelPassword;
        private CheckBox checkBoxReturning;
        private CheckBox checkBoxNewUser;
    }
}
