namespace FinalDay_ITI.Views.User.SettingsPartials
{
    partial class EditPassword
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
            EditPasswordGroupBox = new GroupBox();
            OldPasswordTxt = new TextBox();
            OldPasswordLabel = new Label();
            ConfirmPasswordTxt = new TextBox();
            ConfirmPasswordLabel = new Label();
            PasswordTxt = new TextBox();
            PasswordLabel = new Label();
            EditBtn = new Button();
            EditPasswordGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // EditPasswordGroupBox
            // 
            EditPasswordGroupBox.BackColor = Color.White;
            EditPasswordGroupBox.Controls.Add(OldPasswordTxt);
            EditPasswordGroupBox.Controls.Add(OldPasswordLabel);
            EditPasswordGroupBox.Controls.Add(ConfirmPasswordTxt);
            EditPasswordGroupBox.Controls.Add(ConfirmPasswordLabel);
            EditPasswordGroupBox.Controls.Add(PasswordTxt);
            EditPasswordGroupBox.Controls.Add(PasswordLabel);
            EditPasswordGroupBox.Controls.Add(EditBtn);
            EditPasswordGroupBox.Dock = DockStyle.Fill;
            EditPasswordGroupBox.Location = new Point(0, 0);
            EditPasswordGroupBox.Name = "EditPasswordGroupBox";
            EditPasswordGroupBox.Size = new Size(450, 400);
            EditPasswordGroupBox.TabIndex = 1;
            EditPasswordGroupBox.TabStop = false;
            EditPasswordGroupBox.Text = "Edit Password";
            // 
            // OldPasswordTxt
            // 
            OldPasswordTxt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            OldPasswordTxt.Location = new Point(50, 69);
            OldPasswordTxt.Name = "OldPasswordTxt";
            OldPasswordTxt.PasswordChar = '•';
            OldPasswordTxt.Size = new Size(351, 35);
            OldPasswordTxt.TabIndex = 1;
            // 
            // OldPasswordLabel
            // 
            OldPasswordLabel.AutoSize = true;
            OldPasswordLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            OldPasswordLabel.Location = new Point(50, 36);
            OldPasswordLabel.Margin = new Padding(4, 0, 4, 0);
            OldPasswordLabel.Name = "OldPasswordLabel";
            OldPasswordLabel.Size = new Size(138, 30);
            OldPasswordLabel.TabIndex = 35;
            OldPasswordLabel.Text = "Old Password";
            // 
            // ConfirmPasswordTxt
            // 
            ConfirmPasswordTxt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ConfirmPasswordTxt.Location = new Point(50, 251);
            ConfirmPasswordTxt.Name = "ConfirmPasswordTxt";
            ConfirmPasswordTxt.PasswordChar = '•';
            ConfirmPasswordTxt.Size = new Size(351, 35);
            ConfirmPasswordTxt.TabIndex = 3;
            // 
            // ConfirmPasswordLabel
            // 
            ConfirmPasswordLabel.AutoSize = true;
            ConfirmPasswordLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ConfirmPasswordLabel.Location = new Point(50, 218);
            ConfirmPasswordLabel.Margin = new Padding(4, 0, 4, 0);
            ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            ConfirmPasswordLabel.Size = new Size(179, 30);
            ConfirmPasswordLabel.TabIndex = 33;
            ConfirmPasswordLabel.Text = "Confirm Password";
            // 
            // PasswordTxt
            // 
            PasswordTxt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTxt.Location = new Point(50, 161);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.PasswordChar = '•';
            PasswordTxt.Size = new Size(351, 35);
            PasswordTxt.TabIndex = 2;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(50, 128);
            PasswordLabel.Margin = new Padding(4, 0, 4, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(99, 30);
            PasswordLabel.TabIndex = 31;
            PasswordLabel.Text = "Password";
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(155, 325);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(143, 41);
            EditBtn.TabIndex = 4;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // EditPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(EditPasswordGroupBox);
            Name = "EditPassword";
            Size = new Size(450, 400);
            EditPasswordGroupBox.ResumeLayout(false);
            EditPasswordGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox EditPasswordGroupBox;
        private Button EditBtn;
        private TextBox ConfirmPasswordTxt;
        private Label ConfirmPasswordLabel;
        private TextBox PasswordTxt;
        private Label PasswordLabel;
        private TextBox OldPasswordTxt;
        private Label OldPasswordLabel;
    }
}
