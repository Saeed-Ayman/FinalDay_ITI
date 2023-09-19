namespace FinalDay_ITI.Views.Category
{
    partial class EditCategory
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
            CategoryNameTxt = new TextBox();
            EmailLabel = new Label();
            SuspendLayout();
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(133, 121);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(143, 41);
            EditBtn.TabIndex = 36;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // CategoryNameTxt
            // 
            CategoryNameTxt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CategoryNameTxt.Location = new Point(30, 63);
            CategoryNameTxt.Name = "CategoryNameTxt";
            CategoryNameTxt.Size = new Size(351, 35);
            CategoryNameTxt.TabIndex = 35;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLabel.Location = new Point(30, 30);
            EmailLabel.Margin = new Padding(4, 0, 4, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(158, 30);
            EmailLabel.TabIndex = 34;
            EmailLabel.Text = "Category Name";
            // 
            // EditCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 187);
            Controls.Add(EditBtn);
            Controls.Add(CategoryNameTxt);
            Controls.Add(EmailLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "EditCategory";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Category";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EditBtn;
        private TextBox CategoryNameTxt;
        private Label EmailLabel;
    }
}