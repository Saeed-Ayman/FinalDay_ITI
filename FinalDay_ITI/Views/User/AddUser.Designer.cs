namespace FinalDay_ITI.Views.Partials
{
    partial class AddUser
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
            RoleLabel = new Label();
            RoleNames = new ComboBox();
            AddBtn = new Button();
            LastNameTxt = new TextBox();
            ConfirmPasswordTxt = new TextBox();
            ConfirmPasswordLabel = new Label();
            PasswordTxt = new TextBox();
            PasswordLabel = new Label();
            EmailTxt = new TextBox();
            EmailLabel = new Label();
            LastNameLabel = new Label();
            FirstNameTxt = new TextBox();
            FirstNameLabel = new Label();
            SuspendLayout();
            // 
            // RoleLabel
            // 
            RoleLabel.AutoSize = true;
            RoleLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            RoleLabel.Location = new Point(32, 406);
            RoleLabel.Margin = new Padding(4, 0, 4, 0);
            RoleLabel.Name = "RoleLabel";
            RoleLabel.Size = new Size(53, 30);
            RoleLabel.TabIndex = 30;
            RoleLabel.Text = "Role";
            // 
            // RoleNames
            // 
            RoleNames.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            RoleNames.FormattingEnabled = true;
            RoleNames.Location = new Point(29, 439);
            RoleNames.Name = "RoleNames";
            RoleNames.Size = new Size(352, 38);
            RoleNames.TabIndex = 6;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(131, 506);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(143, 41);
            AddBtn.TabIndex = 7;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // LastNameTxt
            // 
            LastNameTxt.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameTxt.Location = new Point(212, 63);
            LastNameTxt.Name = "LastNameTxt";
            LastNameTxt.Size = new Size(169, 36);
            LastNameTxt.TabIndex = 2;
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
            ConfirmPasswordLabel.TabIndex = 44;
            ConfirmPasswordLabel.Text = "Confirm Password";
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
            PasswordLabel.TabIndex = 43;
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
            EmailLabel.TabIndex = 42;
            EmailLabel.Text = "Email";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameLabel.Location = new Point(212, 30);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(114, 30);
            LastNameLabel.TabIndex = 38;
            LastNameLabel.Text = "Last Name";
            // 
            // FirstNameTxt
            // 
            FirstNameTxt.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameTxt.Location = new Point(30, 63);
            FirstNameTxt.Name = "FirstNameTxt";
            FirstNameTxt.Size = new Size(170, 36);
            FirstNameTxt.TabIndex = 1;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameLabel.Location = new Point(30, 30);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(117, 30);
            FirstNameLabel.TabIndex = 33;
            FirstNameLabel.Text = "First Name";
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 584);
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
            Controls.Add(AddBtn);
            Controls.Add(RoleNames);
            Controls.Add(RoleLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddUser";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label RoleLabel;
        private ComboBox RoleNames;
        private Button AddBtn;
        private TextBox LastNameTxt;
        private TextBox ConfirmPasswordTxt;
        private Label ConfirmPasswordLabel;
        private TextBox PasswordTxt;
        private Label PasswordLabel;
        private TextBox EmailTxt;
        private Label EmailLabel;
        private Label LastNameLabel;
        private TextBox FirstNameTxt;
        private Label FirstNameLabel;
    }
}