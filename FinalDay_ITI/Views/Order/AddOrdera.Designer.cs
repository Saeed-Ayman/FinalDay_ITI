namespace FinalDay_ITI.Views.Order
{
    partial class AddOrdera
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            LayoutPanel = new Panel();
            RemoveBtn = new FontAwesome.Sharp.IconButton();
            AddBtn = new FontAwesome.Sharp.IconButton();
            SubmitBtn = new Button();
            QuantityInput = new NumericUpDown();
            label1 = new Label();
            MedicineNames = new ComboBox();
            FirstNameLabel = new Label();
            dataGridView = new DataGridView();
            LayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QuantityInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // LayoutPanel
            // 
            LayoutPanel.BackColor = Color.White;
            LayoutPanel.Controls.Add(RemoveBtn);
            LayoutPanel.Controls.Add(AddBtn);
            LayoutPanel.Controls.Add(SubmitBtn);
            LayoutPanel.Controls.Add(QuantityInput);
            LayoutPanel.Controls.Add(label1);
            LayoutPanel.Controls.Add(MedicineNames);
            LayoutPanel.Controls.Add(FirstNameLabel);
            LayoutPanel.Dock = DockStyle.Top;
            LayoutPanel.Location = new Point(0, 0);
            LayoutPanel.Name = "LayoutPanel";
            LayoutPanel.Size = new Size(735, 124);
            LayoutPanel.TabIndex = 56;
            // 
            // RemoveBtn
            // 
            RemoveBtn.IconChar = FontAwesome.Sharp.IconChar.Minus;
            RemoveBtn.IconColor = Color.Black;
            RemoveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            RemoveBtn.IconSize = 30;
            RemoveBtn.Location = new Point(480, 63);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(33, 33);
            RemoveBtn.TabIndex = 62;
            RemoveBtn.TextImageRelation = TextImageRelation.TextAboveImage;
            RemoveBtn.UseVisualStyleBackColor = true;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.IconChar = FontAwesome.Sharp.IconChar.Add;
            AddBtn.IconColor = Color.Black;
            AddBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AddBtn.IconSize = 32;
            AddBtn.Location = new Point(441, 63);
            AddBtn.Name = "AddBtn";
            AddBtn.Padding = new Padding(5);
            AddBtn.Size = new Size(33, 33);
            AddBtn.TabIndex = 61;
            AddBtn.TextImageRelation = TextImageRelation.TextAboveImage;
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // SubmitBtn
            // 
            SubmitBtn.Location = new Point(519, 64);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(100, 33);
            SubmitBtn.TabIndex = 60;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // QuantityInput
            // 
            QuantityInput.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            QuantityInput.Location = new Point(270, 64);
            QuantityInput.Name = "QuantityInput";
            QuantityInput.Size = new Size(165, 33);
            QuantityInput.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(270, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 30);
            label1.TabIndex = 58;
            label1.Text = "Quantity";
            // 
            // MedicineNames
            // 
            MedicineNames.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            MedicineNames.FormattingEnabled = true;
            MedicineNames.Location = new Point(28, 63);
            MedicineNames.Name = "MedicineNames";
            MedicineNames.Size = new Size(236, 33);
            MedicineNames.TabIndex = 57;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameLabel.Location = new Point(28, 27);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(166, 30);
            FirstNameLabel.TabIndex = 55;
            FirstNameLabel.Text = "Medicine Name";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Indigo;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeight = 40;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.BlueViolet;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.NullValue = "####";
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.White;
            dataGridView.Location = new Point(0, 124);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Indigo;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.Padding = new Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = Color.SlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.DarkBlue;
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.RowTemplate.DefaultCellStyle.BackColor = Color.BlueViolet;
            dataGridView.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridView.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.MediumPurple;
            dataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dataGridView.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView.RowTemplate.Height = 30;
            dataGridView.RowTemplate.ReadOnly = true;
            dataGridView.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(735, 219);
            dataGridView.TabIndex = 57;
            dataGridView.DataSourceChanged += DataGridView_DataSourceChanged;
            // 
            // AddOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView);
            Controls.Add(LayoutPanel);
            Name = "AddOrder";
            Size = new Size(735, 343);
            LayoutPanel.ResumeLayout(false);
            LayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)QuantityInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel LayoutPanel;
        private NumericUpDown QuantityInput;
        private Label label1;
        private ComboBox MedicineNames;
        private Label FirstNameLabel;
        private DataGridView dataGridView;
        private Button SubmitBtn;
        private FontAwesome.Sharp.IconButton AddBtn;
        private FontAwesome.Sharp.IconButton RemoveBtn;
    }
}
