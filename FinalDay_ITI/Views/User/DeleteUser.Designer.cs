namespace FinalDay_ITI.Views.User
{
    partial class DeleteUser
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
            EmailLabel = new Label();
            NameLabel = new Label();
            DeleteBtn = new Button();
            SuspendLayout();
            // 
            // RoleLabel
            // 
            RoleLabel.AutoSize = true;
            RoleLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            RoleLabel.Location = new Point(30, 138);
            RoleLabel.Margin = new Padding(4, 0, 4, 0);
            RoleLabel.Name = "RoleLabel";
            RoleLabel.Size = new Size(58, 30);
            RoleLabel.TabIndex = 33;
            RoleLabel.Text = "Role:";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLabel.Location = new Point(30, 85);
            EmailLabel.Margin = new Padding(4, 0, 4, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(68, 30);
            EmailLabel.TabIndex = 32;
            EmailLabel.Text = "Email:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.Location = new Point(30, 30);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(76, 30);
            NameLabel.TabIndex = 31;
            NameLabel.Text = "Name:";
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Crimson;
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(132, 189);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(143, 41);
            DeleteBtn.TabIndex = 34;
            DeleteBtn.Text = "Delete Account";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // DeleteUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 249);
            Controls.Add(DeleteBtn);
            Controls.Add(RoleLabel);
            Controls.Add(EmailLabel);
            Controls.Add(NameLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DeleteUser";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Delete User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RoleLabel;
        private Label EmailLabel;
        private Label NameLabel;
        private Button DeleteBtn;
    }
}