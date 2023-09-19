namespace FinalDay_ITI.Views.Medicine
{
    partial class EditMedicine
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
            ExpirationDate = new DateTimePicker();
            ExpirationDateLabel = new Label();
            ProductionDate = new DateTimePicker();
            QuantityInput = new NumericUpDown();
            PriceInput = new NumericUpDown();
            EditBtn = new Button();
            comboBox1 = new ComboBox();
            CategoryLabel = new Label();
            ProductionDateLabel = new Label();
            PasswordLabel = new Label();
            PriceLabel = new Label();
            MedicineNameTxt = new TextBox();
            FirstNameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)QuantityInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceInput).BeginInit();
            SuspendLayout();
            // 
            // ExpirationDate
            // 
            ExpirationDate.CalendarFont = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ExpirationDate.DropDownAlign = LeftRightAlignment.Right;
            ExpirationDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ExpirationDate.Format = DateTimePickerFormat.Short;
            ExpirationDate.Location = new Point(66, 371);
            ExpirationDate.Name = "ExpirationDate";
            ExpirationDate.Size = new Size(352, 33);
            ExpirationDate.TabIndex = 63;
            // 
            // ExpirationDateLabel
            // 
            ExpirationDateLabel.AutoSize = true;
            ExpirationDateLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ExpirationDateLabel.Location = new Point(66, 338);
            ExpirationDateLabel.Margin = new Padding(4, 0, 4, 0);
            ExpirationDateLabel.Name = "ExpirationDateLabel";
            ExpirationDateLabel.Size = new Size(155, 30);
            ExpirationDateLabel.TabIndex = 62;
            ExpirationDateLabel.Text = "Expiration Date";
            // 
            // ProductionDate
            // 
            ProductionDate.CalendarFont = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ProductionDate.DropDownAlign = LeftRightAlignment.Right;
            ProductionDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ProductionDate.Format = DateTimePickerFormat.Short;
            ProductionDate.Location = new Point(66, 266);
            ProductionDate.Name = "ProductionDate";
            ProductionDate.Size = new Size(352, 33);
            ProductionDate.TabIndex = 61;
            // 
            // QuantityInput
            // 
            QuantityInput.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            QuantityInput.Location = new Point(66, 168);
            QuantityInput.Name = "QuantityInput";
            QuantityInput.Size = new Size(170, 33);
            QuantityInput.TabIndex = 60;
            // 
            // PriceInput
            // 
            PriceInput.DecimalPlaces = 2;
            PriceInput.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            PriceInput.Location = new Point(248, 168);
            PriceInput.Name = "PriceInput";
            PriceInput.Size = new Size(170, 33);
            PriceInput.TabIndex = 59;
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(164, 545);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(143, 41);
            EditBtn.TabIndex = 58;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(66, 475);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(352, 38);
            comboBox1.TabIndex = 57;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CategoryLabel.Location = new Point(67, 442);
            CategoryLabel.Margin = new Padding(4, 0, 4, 0);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(96, 30);
            CategoryLabel.TabIndex = 56;
            CategoryLabel.Text = "Category";
            // 
            // ProductionDateLabel
            // 
            ProductionDateLabel.AutoSize = true;
            ProductionDateLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ProductionDateLabel.Location = new Point(67, 235);
            ProductionDateLabel.Margin = new Padding(4, 0, 4, 0);
            ProductionDateLabel.Name = "ProductionDateLabel";
            ProductionDateLabel.Size = new Size(164, 30);
            ProductionDateLabel.TabIndex = 55;
            ProductionDateLabel.Text = "Production Date";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(66, 135);
            PasswordLabel.Margin = new Padding(4, 0, 4, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(93, 30);
            PasswordLabel.TabIndex = 54;
            PasswordLabel.Text = "Quantity";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PriceLabel.Location = new Point(249, 135);
            PriceLabel.Margin = new Padding(4, 0, 4, 0);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(58, 30);
            PriceLabel.TabIndex = 53;
            PriceLabel.Text = "Price";
            // 
            // MedicineNameTxt
            // 
            MedicineNameTxt.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            MedicineNameTxt.Location = new Point(66, 73);
            MedicineNameTxt.Name = "MedicineNameTxt";
            MedicineNameTxt.Size = new Size(352, 36);
            MedicineNameTxt.TabIndex = 52;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameLabel.Location = new Point(66, 40);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(166, 30);
            FirstNameLabel.TabIndex = 51;
            FirstNameLabel.Text = "Medicine Name";
            // 
            // EditMedicine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 626);
            Controls.Add(ExpirationDate);
            Controls.Add(ExpirationDateLabel);
            Controls.Add(ProductionDate);
            Controls.Add(QuantityInput);
            Controls.Add(PriceInput);
            Controls.Add(EditBtn);
            Controls.Add(comboBox1);
            Controls.Add(CategoryLabel);
            Controls.Add(ProductionDateLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(PriceLabel);
            Controls.Add(MedicineNameTxt);
            Controls.Add(FirstNameLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "EditMedicine";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Medicine";
            ((System.ComponentModel.ISupportInitialize)QuantityInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriceInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker ExpirationDate;
        private Label ExpirationDateLabel;
        private DateTimePicker ProductionDate;
        private NumericUpDown QuantityInput;
        private NumericUpDown PriceInput;
        private Button EditBtn;
        private ComboBox comboBox1;
        private Label CategoryLabel;
        private Label ProductionDateLabel;
        private Label PasswordLabel;
        private Label PriceLabel;
        private TextBox MedicineNameTxt;
        private Label FirstNameLabel;
    }
}