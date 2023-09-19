namespace FinalDay_ITI.Views
{
    partial class Login
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
            EmailLabel = new Label();
            EmailTxt = new TextBox();
            PasswordLabel = new Label();
            PasswordTxt = new TextBox();
            LoginBtn = new Button();
            OrLabel = new Label();
            RegisterLabel = new Label();
            SuspendLayout();
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLabel.Location = new Point(30, 30);
            EmailLabel.Margin = new Padding(4, 0, 4, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(63, 30);
            EmailLabel.TabIndex = 0;
            EmailLabel.Text = "Email";
            // 
            // EmailTxt
            // 
            EmailTxt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTxt.Location = new Point(30, 63);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.Size = new Size(351, 35);
            EmailTxt.TabIndex = 1;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(30, 125);
            PasswordLabel.Margin = new Padding(4, 0, 4, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(99, 30);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Password";
            // 
            // PasswordTxt
            // 
            PasswordTxt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTxt.Location = new Point(30, 158);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.PasswordChar = '•';
            PasswordTxt.Size = new Size(351, 35);
            PasswordTxt.TabIndex = 2;
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(134, 218);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(143, 41);
            LoginBtn.TabIndex = 3;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // OrLabel
            // 
            OrLabel.AutoSize = true;
            OrLabel.Location = new Point(189, 273);
            OrLabel.Name = "OrLabel";
            OrLabel.Size = new Size(32, 21);
            OrLabel.TabIndex = 5;
            OrLabel.Text = "OR";
            // 
            // RegisterLabel
            // 
            RegisterLabel.AutoSize = true;
            RegisterLabel.Cursor = Cursors.Hand;
            RegisterLabel.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point);
            RegisterLabel.ForeColor = Color.Blue;
            RegisterLabel.Location = new Point(153, 305);
            RegisterLabel.Name = "RegisterLabel";
            RegisterLabel.Size = new Size(104, 21);
            RegisterLabel.TabIndex = 7;
            RegisterLabel.Text = "Register Now";
            RegisterLabel.Click += RegisterLabel_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 347);
            Controls.Add(RegisterLabel);
            Controls.Add(OrLabel);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordTxt);
            Controls.Add(PasswordLabel);
            Controls.Add(EmailTxt);
            Controls.Add(EmailLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EmailLabel;
        private TextBox EmailTxt;
        private Label PasswordLabel;
        private TextBox PasswordTxt;
        private Button LoginBtn;
        private Label OrLabel;
        private Label RegisterLabel;
    }
}