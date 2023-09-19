namespace FinalDay_ITI.Views.Order
{
    partial class AddOrderMedicine
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
            QuantityInput = new NumericUpDown();
            label1 = new Label();
            MedicineNames = new ComboBox();
            FirstNameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)QuantityInput).BeginInit();
            SuspendLayout();
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(132, 210);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(143, 41);
            AddBtn.TabIndex = 69;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // QuantityInput
            // 
            QuantityInput.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            QuantityInput.Location = new Point(29, 152);
            QuantityInput.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            QuantityInput.Name = "QuantityInput";
            QuantityInput.Size = new Size(350, 33);
            QuantityInput.TabIndex = 2;
            QuantityInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 119);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 30);
            label1.TabIndex = 67;
            label1.Text = "Quantity";
            // 
            // MedicineNames
            // 
            MedicineNames.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            MedicineNames.FormattingEnabled = true;
            MedicineNames.Location = new Point(29, 62);
            MedicineNames.Name = "MedicineNames";
            MedicineNames.Size = new Size(350, 33);
            MedicineNames.TabIndex = 1;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameLabel.Location = new Point(29, 26);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(166, 30);
            FirstNameLabel.TabIndex = 65;
            FirstNameLabel.Text = "Medicine Name";
            // 
            // AddOrderMedicine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 276);
            Controls.Add(AddBtn);
            Controls.Add(QuantityInput);
            Controls.Add(label1);
            Controls.Add(MedicineNames);
            Controls.Add(FirstNameLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddOrderMedicine";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Order Medicine";
            ((System.ComponentModel.ISupportInitialize)QuantityInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddBtn;
        private NumericUpDown QuantityInput;
        private Label label1;
        private ComboBox MedicineNames;
        private Label FirstNameLabel;
    }
}