namespace FinalDay_ITI.Views.User.SettingsPartials
{
    partial class DeleteAccount
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
            DeleteAccountGroupBox = new GroupBox();
            DeleteBtn = new Button();
            PasswordTxt = new TextBox();
            PasswordLabel = new Label();
            DeleteAccountGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // DeleteAccountGroupBox
            // 
            DeleteAccountGroupBox.Controls.Add(DeleteBtn);
            DeleteAccountGroupBox.Controls.Add(PasswordTxt);
            DeleteAccountGroupBox.Controls.Add(PasswordLabel);
            DeleteAccountGroupBox.Dock = DockStyle.Fill;
            DeleteAccountGroupBox.Location = new Point(0, 0);
            DeleteAccountGroupBox.Name = "DeleteAccountGroupBox";
            DeleteAccountGroupBox.Size = new Size(450, 224);
            DeleteAccountGroupBox.TabIndex = 0;
            DeleteAccountGroupBox.TabStop = false;
            DeleteAccountGroupBox.Text = "Delete Account";
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Crimson;
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(154, 135);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(143, 41);
            DeleteBtn.TabIndex = 2;
            DeleteBtn.Text = "Delete Account";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // PasswordTxt
            // 
            PasswordTxt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTxt.Location = new Point(50, 70);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.PasswordChar = '•';
            PasswordTxt.Size = new Size(351, 35);
            PasswordTxt.TabIndex = 1;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(50, 37);
            PasswordLabel.Margin = new Padding(4, 0, 4, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(99, 30);
            PasswordLabel.TabIndex = 35;
            PasswordLabel.Text = "Password";
            // 
            // DeleteAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DeleteAccountGroupBox);
            Name = "DeleteAccount";
            Size = new Size(450, 224);
            DeleteAccountGroupBox.ResumeLayout(false);
            DeleteAccountGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox DeleteAccountGroupBox;
        private TextBox PasswordTxt;
        private Label PasswordLabel;
        private Button DeleteBtn;
    }
}
