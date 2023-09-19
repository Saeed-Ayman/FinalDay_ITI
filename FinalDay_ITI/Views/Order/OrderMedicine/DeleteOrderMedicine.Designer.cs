namespace FinalDay_ITI.Views.Order.OrderMedicine
{
    partial class DeleteOrderMedicine
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
            QuantityLabel = new Label();
            MedicineLabel = new Label();
            SuspendLayout();
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Crimson;
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(131, 145);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(143, 41);
            DeleteBtn.TabIndex = 38;
            DeleteBtn.Text = "Delete Medicine";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            QuantityLabel.Location = new Point(30, 85);
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
            // DeleteOrderMedicine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 207);
            Controls.Add(DeleteBtn);
            Controls.Add(QuantityLabel);
            Controls.Add(MedicineLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DeleteOrderMedicine";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Delete Order Medicine";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeleteBtn;
        private Label QuantityLabel;
        private Label MedicineLabel;
    }
}