namespace FinalDay_ITI.Views.Partials
{
    partial class DashboardHeader
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
            MenuBtn = new FontAwesome.Sharp.IconButton();
            LogoutBtn = new FontAwesome.Sharp.IconButton();
            UserIcon = new FontAwesome.Sharp.IconPictureBox();
            UsernameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)UserIcon).BeginInit();
            SuspendLayout();
            // 
            // MenuBtn
            // 
            MenuBtn.Anchor = AnchorStyles.Left;
            MenuBtn.BackColor = Color.Indigo;
            MenuBtn.Cursor = Cursors.Hand;
            MenuBtn.FlatAppearance.BorderSize = 0;
            MenuBtn.FlatStyle = FlatStyle.Flat;
            MenuBtn.ForeColor = Color.Transparent;
            MenuBtn.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            MenuBtn.IconColor = Color.White;
            MenuBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuBtn.IconSize = 45;
            MenuBtn.Location = new Point(13, 13);
            MenuBtn.Name = "MenuBtn";
            MenuBtn.Padding = new Padding(3, 5, 3, 3);
            MenuBtn.Size = new Size(50, 50);
            MenuBtn.TabIndex = 0;
            MenuBtn.UseVisualStyleBackColor = false;
            MenuBtn.Click += MenuBtn_Click;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Anchor = AnchorStyles.Right;
            LogoutBtn.BackColor = Color.Indigo;
            LogoutBtn.Cursor = Cursors.Hand;
            LogoutBtn.FlatStyle = FlatStyle.Flat;
            LogoutBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LogoutBtn.ForeColor = Color.White;
            LogoutBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            LogoutBtn.IconColor = Color.Black;
            LogoutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            LogoutBtn.IconSize = 40;
            LogoutBtn.Location = new Point(737, 13);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(150, 50);
            LogoutBtn.TabIndex = 1;
            LogoutBtn.Text = "Logout";
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // UserIcon
            // 
            UserIcon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            UserIcon.BackColor = Color.Indigo;
            UserIcon.BackgroundImageLayout = ImageLayout.Center;
            UserIcon.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            UserIcon.IconColor = Color.White;
            UserIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            UserIcon.IconSize = 45;
            UserIcon.Location = new Point(78, 18);
            UserIcon.Margin = new Padding(0);
            UserIcon.Name = "UserIcon";
            UserIcon.Size = new Size(45, 45);
            UserIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            UserIcon.TabIndex = 4;
            UserIcon.TabStop = false;
            // 
            // UsernameLabel
            // 
            UsernameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            UsernameLabel.ForeColor = Color.White;
            UsernameLabel.Location = new Point(118, 25);
            UsernameLabel.Margin = new Padding(0, 0, 3, 0);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(106, 25);
            UsernameLabel.TabIndex = 5;
            UsernameLabel.Text = "User name";
            // 
            // DashboardHeader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            Controls.Add(UsernameLabel);
            Controls.Add(UserIcon);
            Controls.Add(LogoutBtn);
            Controls.Add(MenuBtn);
            Name = "DashboardHeader";
            Size = new Size(900, 76);
            ((System.ComponentModel.ISupportInitialize)UserIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton MenuBtn;
        private FontAwesome.Sharp.IconButton LogoutBtn;
        private FontAwesome.Sharp.IconPictureBox UserIcon;
        private Label UsernameLabel;
    }
}
