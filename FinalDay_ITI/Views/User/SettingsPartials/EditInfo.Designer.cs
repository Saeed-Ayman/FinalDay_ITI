namespace FinalDay_ITI.Views.User.SettingsPartials
{
    partial class EditInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EditInfoGroupBox = new GroupBox();
            PasswordTxt = new TextBox();
            PasswordLabel = new Label();
            EditBtn = new Button();
            LastNameTxt = new TextBox();
            EmailTxt = new TextBox();
            EmailLabel = new Label();
            LastNameLabel = new Label();
            FirstNameTxt = new TextBox();
            FirstNameLabel = new Label();
            EditInfoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // EditInfoGroupBox
            // 
            EditInfoGroupBox.BackColor = Color.White;
            EditInfoGroupBox.Controls.Add(PasswordTxt);
            EditInfoGroupBox.Controls.Add(PasswordLabel);
            EditInfoGroupBox.Controls.Add(EditBtn);
            EditInfoGroupBox.Controls.Add(LastNameTxt);
            EditInfoGroupBox.Controls.Add(EmailTxt);
            EditInfoGroupBox.Controls.Add(EmailLabel);
            EditInfoGroupBox.Controls.Add(LastNameLabel);
            EditInfoGroupBox.Controls.Add(FirstNameTxt);
            EditInfoGroupBox.Controls.Add(FirstNameLabel);
            EditInfoGroupBox.Dock = DockStyle.Fill;
            EditInfoGroupBox.Location = new Point(0, 0);
            EditInfoGroupBox.Name = "EditInfoGroupBox";
            EditInfoGroupBox.Size = new Size(451, 385);
            EditInfoGroupBox.TabIndex = 3;
            EditInfoGroupBox.TabStop = false;
            EditInfoGroupBox.Text = "Edit Info";
            // 
            // PasswordTxt
            // 
            PasswordTxt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTxt.Location = new Point(50, 255);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.PasswordChar = '•';
            PasswordTxt.Size = new Size(351, 35);
            PasswordTxt.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(50, 222);
            PasswordLabel.Margin = new Padding(4, 0, 4, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(99, 30);
            PasswordLabel.TabIndex = 33;
            PasswordLabel.Text = "Password";
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(154, 321);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(143, 41);
            EditBtn.TabIndex = 5;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // LastNameTxt
            // 
            LastNameTxt.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameTxt.Location = new Point(231, 76);
            LastNameTxt.Name = "LastNameTxt";
            LastNameTxt.Size = new Size(170, 36);
            LastNameTxt.TabIndex = 2;
            // 
            // EmailTxt
            // 
            EmailTxt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTxt.Location = new Point(50, 162);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.Size = new Size(351, 35);
            EmailTxt.TabIndex = 3;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLabel.Location = new Point(51, 129);
            EmailLabel.Margin = new Padding(4, 0, 4, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(63, 30);
            EmailLabel.TabIndex = 23;
            EmailLabel.Text = "Email";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameLabel.Location = new Point(231, 43);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(114, 30);
            LastNameLabel.TabIndex = 22;
            LastNameLabel.Text = "Last Name";
            // 
            // FirstNameTxt
            // 
            FirstNameTxt.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameTxt.Location = new Point(50, 76);
            FirstNameTxt.Name = "FirstNameTxt";
            FirstNameTxt.Size = new Size(170, 36);
            FirstNameTxt.TabIndex = 1;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameLabel.Location = new Point(50, 43);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(117, 30);
            FirstNameLabel.TabIndex = 20;
            FirstNameLabel.Text = "First Name";
            // 
            // EditInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EditInfoGroupBox);
            Name = "EditInfo";
            Size = new Size(451, 385);
            EditInfoGroupBox.ResumeLayout(false);
            EditInfoGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox EditInfoGroupBox;
        private TextBox PasswordTxt;
        private Label PasswordLabel;
        private Button EditBtn;
        private TextBox LastNameTxt;
        private TextBox EmailTxt;
        private Label EmailLabel;
        private Label LastNameLabel;
        private TextBox FirstNameTxt;
        private Label FirstNameLabel;
    }
}
