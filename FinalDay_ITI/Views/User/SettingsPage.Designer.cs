namespace FinalDay_ITI.Views.User
{
    partial class SettingsPage
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
            editPassword1 = new SettingsPartials.EditPassword();
            deleteAccount1 = new SettingsPartials.DeleteAccount();
            editInfo1 = new SettingsPartials.EditInfo();
            SuspendLayout();
            // 
            // editPassword1
            // 
            editPassword1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            editPassword1.BackColor = Color.White;
            editPassword1.Location = new Point(32, 393);
            editPassword1.Name = "editPassword1";
            editPassword1.Size = new Size(450, 383);
            editPassword1.TabIndex = 4;
            // 
            // deleteAccount1
            // 
            deleteAccount1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            deleteAccount1.Location = new Point(33, 782);
            deleteAccount1.Name = "deleteAccount1";
            deleteAccount1.Size = new Size(450, 196);
            deleteAccount1.TabIndex = 5;
            // 
            // editInfo1
            // 
            editInfo1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            editInfo1.Location = new Point(33, 3);
            editInfo1.Name = "editInfo1";
            editInfo1.Size = new Size(451, 385);
            editInfo1.TabIndex = 3;
            // 
            // SettingsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            Controls.Add(editInfo1);
            Controls.Add(deleteAccount1);
            Controls.Add(editPassword1);
            Name = "SettingsPage";
            Size = new Size(500, 990);
            ResumeLayout(false);
        }

        #endregion

        private SettingsPartials.EditPassword editPassword1;
        private SettingsPartials.DeleteAccount deleteAccount1;
        private SettingsPartials.EditInfo editInfo1;
    }
}
