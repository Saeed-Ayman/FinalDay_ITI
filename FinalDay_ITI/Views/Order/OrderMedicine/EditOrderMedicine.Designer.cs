namespace FinalDay_ITI.Views.Order
{
    partial class EditOrderMedicine
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
            QuantityInput = new NumericUpDown();
            label1 = new Label();
            MedicineNames = new ComboBox();
            FirstNameLabel = new Label();
            EditBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)QuantityInput).BeginInit();
            SuspendLayout();
            // 
            // QuantityInput
            // 
            QuantityInput.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            QuantityInput.Location = new Point(30, 156);
            QuantityInput.Name = "QuantityInput";
            QuantityInput.Size = new Size(350, 33);
            QuantityInput.TabIndex = 63;
            QuantityInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 123);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 30);
            label1.TabIndex = 62;
            label1.Text = "Quantity";
            // 
            // MedicineNames
            // 
            MedicineNames.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            MedicineNames.FormattingEnabled = true;
            MedicineNames.Location = new Point(30, 66);
            MedicineNames.Name = "MedicineNames";
            MedicineNames.Size = new Size(350, 33);
            MedicineNames.TabIndex = 61;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameLabel.Location = new Point(30, 30);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(166, 30);
            FirstNameLabel.TabIndex = 60;
            FirstNameLabel.Text = "Medicine Name";
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(133, 214);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(143, 41);
            EditBtn.TabIndex = 64;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // EditOrderMedicine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 276);
            Controls.Add(EditBtn);
            Controls.Add(QuantityInput);
            Controls.Add(label1);
            Controls.Add(MedicineNames);
            Controls.Add(FirstNameLabel);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "EditOrderMedicine";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Order";
            ((System.ComponentModel.ISupportInitialize)QuantityInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown QuantityInput;
        private Label label1;
        private ComboBox MedicineNames;
        private Label FirstNameLabel;
        private Button EditBtn;
    }
}