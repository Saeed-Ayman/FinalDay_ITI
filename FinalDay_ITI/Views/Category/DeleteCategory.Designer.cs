namespace FinalDay_ITI.Views.Category
{
    partial class DeleteCategory
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
            CategoryLabel = new Label();
            DeleteBtn = new Button();
            SuspendLayout();
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CategoryLabel.Location = new Point(30, 30);
            CategoryLabel.Margin = new Padding(4, 0, 4, 0);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(107, 30);
            CategoryLabel.TabIndex = 32;
            CategoryLabel.Text = "Category: ";
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Crimson;
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(134, 94);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(143, 41);
            DeleteBtn.TabIndex = 35;
            DeleteBtn.Text = "Delete Category";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // DeleteCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 157);
            Controls.Add(DeleteBtn);
            Controls.Add(CategoryLabel);
            Name = "DeleteCategory";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Delete Category";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CategoryLabel;
        private Button DeleteBtn;
    }
}