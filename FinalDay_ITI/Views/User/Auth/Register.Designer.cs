namespace FinalDay_ITI.Views
{
    partial class Register
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
            FirstNameLabel = new Label();
            FirstNameTxt = new TextBox();
            LastNameLabel = new Label();
            PasswordTxt = new TextBox();
            PasswordLabel = new Label();
            EmailTxt = new TextBox();
            EmailLabel = new Label();
            ConfirmPasswordTxt = new TextBox();
            ConfirmPasswordLabel = new Label();
            LastNameTxt = new TextBox();
            LoginLabel = new Label();
            OrLabel = new Label();
            RegisterBtn = new Button();
            SuspendLayout();
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameLabel.Location = new Point(30, 30);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(117, 30);
            FirstNameLabel.TabIndex = 0;
            FirstNameLabel.Text = "First Name";
            // 
            // FirstNameTxt
            // 
            FirstNameTxt.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameTxt.Location = new Point(30, 63);
            FirstNameTxt.Name = "FirstNameTxt";
            FirstNameTxt.Size = new Size(170, 36);
            FirstNameTxt.TabIndex = 1;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameLabel.Location = new Point(212, 30);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(114, 30);
            LastNameLabel.TabIndex = 4;
            LastNameLabel.Text = "Last Name";
            // 
            // PasswordTxt
            // 
            PasswordTxt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTxt.Location = new Point(30, 242);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.PasswordChar = '•';
            PasswordTxt.Size = new Size(351, 35);
            PasswordTxt.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(31, 209);
            PasswordLabel.Margin = new Padding(4, 0, 4, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(99, 30);
            PasswordLabel.TabIndex = 12;
            PasswordLabel.Text = "Password";
            // 
            // EmailTxt
            // 
            EmailTxt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTxt.Location = new Point(29, 150);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.Size = new Size(351, 35);
            EmailTxt.TabIndex = 3;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLabel.Location = new Point(30, 117);
            EmailLabel.Margin = new Padding(4, 0, 4, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(63, 30);
            EmailLabel.TabIndex = 10;
            EmailLabel.Text = "Email";
            // 
            // ConfirmPasswordTxt
            // 
            ConfirmPasswordTxt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ConfirmPasswordTxt.Location = new Point(30, 343);
            ConfirmPasswordTxt.Name = "ConfirmPasswordTxt";
            ConfirmPasswordTxt.PasswordChar = '•';
            ConfirmPasswordTxt.Size = new Size(351, 35);
            ConfirmPasswordTxt.TabIndex = 5;
            // 
            // ConfirmPasswordLabel
            // 
            ConfirmPasswordLabel.AutoSize = true;
            ConfirmPasswordLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ConfirmPasswordLabel.Location = new Point(30, 310);
            ConfirmPasswordLabel.Margin = new Padding(4, 0, 4, 0);
            ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            ConfirmPasswordLabel.Size = new Size(179, 30);
            ConfirmPasswordLabel.TabIndex = 14;
            ConfirmPasswordLabel.Text = "Confirm Password";
            // 
            // LastNameTxt
            // 
            LastNameTxt.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameTxt.Location = new Point(212, 63);
            LastNameTxt.Name = "LastNameTxt";
            LastNameTxt.Size = new Size(169, 36);
            LastNameTxt.TabIndex = 2;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Cursor = Cursors.Hand;
            LoginLabel.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point);
            LoginLabel.ForeColor = Color.Blue;
            LoginLabel.Location = new Point(162, 501);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(86, 21);
            LoginLabel.TabIndex = 7;
            LoginLabel.Text = "Login Now";
            LoginLabel.Click += LoginLabel_Click;
            // 
            // OrLabel
            // 
            OrLabel.AutoSize = true;
            OrLabel.Location = new Point(189, 469);
            OrLabel.Name = "OrLabel";
            OrLabel.Size = new Size(32, 21);
            OrLabel.TabIndex = 18;
            OrLabel.Text = "OR";
            // 
            // RegisterBtn
            // 
            RegisterBtn.Location = new Point(134, 412);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(143, 41);
            RegisterBtn.TabIndex = 6;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = true;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 551);
            Controls.Add(LoginLabel);
            Controls.Add(OrLabel);
            Controls.Add(RegisterBtn);
            Controls.Add(LastNameTxt);
            Controls.Add(ConfirmPasswordTxt);
            Controls.Add(ConfirmPasswordLabel);
            Controls.Add(PasswordTxt);
            Controls.Add(PasswordLabel);
            Controls.Add(EmailTxt);
            Controls.Add(EmailLabel);
            Controls.Add(LastNameLabel);
            Controls.Add(FirstNameTxt);
            Controls.Add(FirstNameLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FirstNameLabel;
        private TextBox FirstNameTxt;
        private Label LastNameLabel;
        private TextBox PasswordTxt;
        private Label PasswordLabel;
        private TextBox EmailTxt;
        private Label EmailLabel;
        private TextBox ConfirmPasswordTxt;
        private Label ConfirmPasswordLabel;
        private TextBox LastNameTxt;
        private Label LoginLabel;
        private Label OrLabel;
        private Button RegisterBtn;
    }
}