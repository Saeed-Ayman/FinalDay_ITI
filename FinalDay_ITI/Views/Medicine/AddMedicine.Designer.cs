namespace FinalDay_ITI.Views.Medicine
{
    partial class AddMedicine
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
            CategoryNames = new ComboBox();
            CategoryLabel = new Label();
            ProductionDateLabel = new Label();
            PasswordLabel = new Label();
            PriceLabel = new Label();
            MedicineNameTxt = new TextBox();
            FirstNameLabel = new Label();
            PriceInput = new NumericUpDown();
            QuantityInput = new NumericUpDown();
            ProductionDate = new DateTimePicker();
            ExpirationDateLabel = new Label();
            ExpirationDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)PriceInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)QuantityInput).BeginInit();
            SuspendLayout();
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(164, 547);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(143, 41);
            AddBtn.TabIndex = 45;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // CategoryNames
            // 
            CategoryNames.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CategoryNames.FormattingEnabled = true;
            CategoryNames.Location = new Point(66, 477);
            CategoryNames.Name = "CategoryNames";
            CategoryNames.Size = new Size(352, 38);
            CategoryNames.TabIndex = 44;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CategoryLabel.Location = new Point(67, 444);
            CategoryLabel.Margin = new Padding(4, 0, 4, 0);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(96, 30);
            CategoryLabel.TabIndex = 43;
            CategoryLabel.Text = "Category";
            // 
            // ProductionDateLabel
            // 
            ProductionDateLabel.AutoSize = true;
            ProductionDateLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ProductionDateLabel.Location = new Point(67, 237);
            ProductionDateLabel.Margin = new Padding(4, 0, 4, 0);
            ProductionDateLabel.Name = "ProductionDateLabel";
            ProductionDateLabel.Size = new Size(164, 30);
            ProductionDateLabel.TabIndex = 40;
            ProductionDateLabel.Text = "Production Date";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(66, 137);
            PasswordLabel.Margin = new Padding(4, 0, 4, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(93, 30);
            PasswordLabel.TabIndex = 38;
            PasswordLabel.Text = "Quantity";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PriceLabel.Location = new Point(249, 137);
            PriceLabel.Margin = new Padding(4, 0, 4, 0);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(58, 30);
            PriceLabel.TabIndex = 36;
            PriceLabel.Text = "Price";
            // 
            // MedicineNameTxt
            // 
            MedicineNameTxt.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            MedicineNameTxt.Location = new Point(66, 75);
            MedicineNameTxt.Name = "MedicineNameTxt";
            MedicineNameTxt.Size = new Size(352, 36);
            MedicineNameTxt.TabIndex = 34;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameLabel.Location = new Point(66, 42);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(166, 30);
            FirstNameLabel.TabIndex = 33;
            FirstNameLabel.Text = "Medicine Name";
            // 
            // PriceInput
            // 
            PriceInput.DecimalPlaces = 2;
            PriceInput.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            PriceInput.Location = new Point(248, 170);
            PriceInput.Name = "PriceInput";
            PriceInput.Size = new Size(170, 33);
            PriceInput.TabIndex = 46;
            // 
            // QuantityInput
            // 
            QuantityInput.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            QuantityInput.Location = new Point(66, 170);
            QuantityInput.Name = "QuantityInput";
            QuantityInput.Size = new Size(170, 33);
            QuantityInput.TabIndex = 47;
            // 
            // ProductionDate
            // 
            ProductionDate.CalendarFont = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ProductionDate.DropDownAlign = LeftRightAlignment.Right;
            ProductionDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ProductionDate.Format = DateTimePickerFormat.Short;
            ProductionDate.Location = new Point(66, 268);
            ProductionDate.Name = "ProductionDate";
            ProductionDate.Size = new Size(352, 33);
            ProductionDate.TabIndex = 48;
            ProductionDate.ValueChanged += ProductionDate_ValueChanged;
            // 
            // ExpirationDateLabel
            // 
            ExpirationDateLabel.AutoSize = true;
            ExpirationDateLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ExpirationDateLabel.Location = new Point(66, 340);
            ExpirationDateLabel.Margin = new Padding(4, 0, 4, 0);
            ExpirationDateLabel.Name = "ExpirationDateLabel";
            ExpirationDateLabel.Size = new Size(155, 30);
            ExpirationDateLabel.TabIndex = 49;
            ExpirationDateLabel.Text = "Expiration Date";
            // 
            // ExpirationDate
            // 
            ExpirationDate.CalendarFont = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ExpirationDate.DropDownAlign = LeftRightAlignment.Right;
            ExpirationDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ExpirationDate.Format = DateTimePickerFormat.Short;
            ExpirationDate.Location = new Point(66, 373);
            ExpirationDate.Name = "ExpirationDate";
            ExpirationDate.Size = new Size(352, 33);
            ExpirationDate.TabIndex = 50;
            ExpirationDate.ValueChanged += ExpirationDate_ValueChanged;
            // 
            // AddMedicine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 626);
            Controls.Add(ExpirationDate);
            Controls.Add(ExpirationDateLabel);
            Controls.Add(ProductionDate);
            Controls.Add(QuantityInput);
            Controls.Add(PriceInput);
            Controls.Add(AddBtn);
            Controls.Add(CategoryNames);
            Controls.Add(CategoryLabel);
            Controls.Add(ProductionDateLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(PriceLabel);
            Controls.Add(MedicineNameTxt);
            Controls.Add(FirstNameLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddMedicine";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Medicine";
            ((System.ComponentModel.ISupportInitialize)PriceInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)QuantityInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddBtn;
        private ComboBox CategoryNames;
        private Label CategoryLabel;
        private Label ProductionDateLabel;
        private Label PasswordLabel;
        private Label PriceLabel;
        private TextBox MedicineNameTxt;
        private Label FirstNameLabel;
        private NumericUpDown PriceInput;
        private NumericUpDown QuantityInput;
        private DateTimePicker ProductionDate;
        private Label ExpirationDateLabel;
        private DateTimePicker ExpirationDate;
    }
}