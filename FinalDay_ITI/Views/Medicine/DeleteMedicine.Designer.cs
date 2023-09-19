namespace FinalDay_ITI.Views.Medicine
{
    partial class DeleteMedicine
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
            DeleteBtn = new Button();
            PriceLabel = new Label();
            QuantityLabel = new Label();
            MedicineLabel = new Label();
            ProductionDateLabel = new Label();
            ExpirationDateInput = new Label();
            CategoryLabel = new Label();
            SuspendLayout();
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Crimson;
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(132, 345);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(143, 41);
            DeleteBtn.TabIndex = 38;
            DeleteBtn.Text = "Delete Medicine";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PriceLabel.Location = new Point(30, 130);
            PriceLabel.Margin = new Padding(4, 0, 4, 0);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(63, 30);
            PriceLabel.TabIndex = 37;
            PriceLabel.Text = "Price:";
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            QuantityLabel.Location = new Point(30, 80);
            QuantityLabel.Margin = new Padding(4, 0, 4, 0);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(98, 30);
            QuantityLabel.TabIndex = 36;
            QuantityLabel.Text = "Quantity:";
            // 
            // MedicineLabel
            // 
            MedicineLabel.AutoSize = true;
            MedicineLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            MedicineLabel.Location = new Point(30, 30);
            MedicineLabel.Name = "MedicineLabel";
            MedicineLabel.Size = new Size(107, 30);
            MedicineLabel.TabIndex = 35;
            MedicineLabel.Text = "Medicine:";
            // 
            // ProductionDateLabel
            // 
            ProductionDateLabel.AutoSize = true;
            ProductionDateLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ProductionDateLabel.Location = new Point(30, 178);
            ProductionDateLabel.Margin = new Padding(4, 0, 4, 0);
            ProductionDateLabel.Name = "ProductionDateLabel";
            ProductionDateLabel.Size = new Size(169, 30);
            ProductionDateLabel.TabIndex = 39;
            ProductionDateLabel.Text = "Production Date:";
            // 
            // ExpirationDateInput
            // 
            ExpirationDateInput.AutoSize = true;
            ExpirationDateInput.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ExpirationDateInput.Location = new Point(30, 230);
            ExpirationDateInput.Margin = new Padding(4, 0, 4, 0);
            ExpirationDateInput.Name = "ExpirationDateInput";
            ExpirationDateInput.Size = new Size(160, 30);
            ExpirationDateInput.TabIndex = 40;
            ExpirationDateInput.Text = "Expiration Date:";
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CategoryLabel.Location = new Point(30, 284);
            CategoryLabel.Margin = new Padding(4, 0, 4, 0);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(101, 30);
            CategoryLabel.TabIndex = 41;
            CategoryLabel.Text = "Category:";
            // 
            // DeleteMedicine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 406);
            Controls.Add(CategoryLabel);
            Controls.Add(ExpirationDateInput);
            Controls.Add(ProductionDateLabel);
            Controls.Add(DeleteBtn);
            Controls.Add(PriceLabel);
            Controls.Add(QuantityLabel);
            Controls.Add(MedicineLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DeleteMedicine";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Delete Medicine";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeleteBtn;
        private Label PriceLabel;
        private Label QuantityLabel;
        private Label MedicineLabel;
        private Label ProductionDateLabel;
        private Label ExpirationDateInput;
        private Label CategoryLabel;
    }
}