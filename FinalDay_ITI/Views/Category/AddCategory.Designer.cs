namespace FinalDay_ITI.Views.Category
{
    partial class AddCategory
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
            AddBtn = new Button();
            CategoryNameTxt = new TextBox();
            EmailLabel = new Label();
            SuspendLayout();
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(135, 121);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(143, 41);
            AddBtn.TabIndex = 33;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // CategoryNameTxt
            // 
            CategoryNameTxt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CategoryNameTxt.Location = new Point(30, 63);
            CategoryNameTxt.Name = "CategoryNameTxt";
            CategoryNameTxt.Size = new Size(351, 35);
            CategoryNameTxt.TabIndex = 32;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLabel.Location = new Point(30, 30);
            EmailLabel.Margin = new Padding(4, 0, 4, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(158, 30);
            EmailLabel.TabIndex = 31;
            EmailLabel.Text = "Category Name";
            // 
            // AddCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 188);
            Controls.Add(AddBtn);
            Controls.Add(CategoryNameTxt);
            Controls.Add(EmailLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddCategory";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Category";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddBtn;
        private TextBox CategoryNameTxt;
        private Label EmailLabel;
    }
}