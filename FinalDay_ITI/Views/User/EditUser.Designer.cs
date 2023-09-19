namespace FinalDay_ITI.Views.User
{
    partial class EditUser
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
            EditBtn = new Button();
            comboBox1 = new ComboBox();
            RoleLabel = new Label();
            EmailLabel = new Label();
            NameLabel = new Label();
            SuspendLayout();
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(130, 237);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(148, 41);
            EditBtn.TabIndex = 2;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(30, 177);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(352, 38);
            comboBox1.TabIndex = 1;
            // 
            // RoleLabel
            // 
            RoleLabel.AutoSize = true;
            RoleLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            RoleLabel.Location = new Point(30, 144);
            RoleLabel.Margin = new Padding(4, 0, 4, 0);
            RoleLabel.Name = "RoleLabel";
            RoleLabel.Size = new Size(53, 30);
            RoleLabel.TabIndex = 43;
            RoleLabel.Text = "Role";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLabel.Location = new Point(30, 85);
            EmailLabel.Margin = new Padding(4, 0, 4, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(68, 30);
            EmailLabel.TabIndex = 47;
            EmailLabel.Text = "Email:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.Location = new Point(30, 30);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(76, 30);
            NameLabel.TabIndex = 46;
            NameLabel.Text = "Name:";
            // 
            // EditUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 297);
            Controls.Add(EmailLabel);
            Controls.Add(NameLabel);
            Controls.Add(EditBtn);
            Controls.Add(comboBox1);
            Controls.Add(RoleLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "EditUser";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit User Role";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EditBtn;
        private ComboBox comboBox1;
        private Label RoleLabel;
        private Label EmailLabel;
        private Label NameLabel;
    }
}