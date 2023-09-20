namespace FinalDay_ITI.Views.Partials
{
    partial class GridViewPage
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
            DeleteBtn = new Components.CRoundButton();
            EditBtn = new Components.CRoundButton();
            AddBtn = new Components.CRoundButton();
            SearchTxt = new TextBox();
            FieldsComboBox = new ComboBox();
            SearchLabel = new Label();
            dataGridView = new DataGridView();
            NoDataLabel = new Label();
            LayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // LayoutPanel
            // 
            LayoutPanel.BackColor = Color.White;
            LayoutPanel.Controls.Add(DeleteBtn);
            LayoutPanel.Controls.Add(EditBtn);
            LayoutPanel.Controls.Add(AddBtn);
            LayoutPanel.Controls.Add(SearchTxt);
            LayoutPanel.Controls.Add(FieldsComboBox);
            LayoutPanel.Controls.Add(SearchLabel);
            LayoutPanel.Dock = DockStyle.Top;
            LayoutPanel.Location = new Point(0, 0);
            LayoutPanel.Name = "LayoutPanel";
            LayoutPanel.Size = new Size(600, 126);
            LayoutPanel.TabIndex = 0;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Anchor = AnchorStyles.Right;
            DeleteBtn.BackColor = Color.Indigo;
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatAppearance.MouseDownBackColor = Color.BlueViolet;
            DeleteBtn.FlatAppearance.MouseOverBackColor = Color.BlueViolet;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            DeleteBtn.IconColor = Color.White;
            DeleteBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            DeleteBtn.IconSize = 30;
            DeleteBtn.Location = new Point(510, 35);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(60, 60);
            DeleteBtn.TabIndex = 4;
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += Btns_Click;
            // 
            // EditBtn
            // 
            EditBtn.Anchor = AnchorStyles.Right;
            EditBtn.BackColor = Color.Indigo;
            EditBtn.FlatAppearance.BorderSize = 0;
            EditBtn.FlatAppearance.MouseDownBackColor = Color.BlueViolet;
            EditBtn.FlatAppearance.MouseOverBackColor = Color.BlueViolet;
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            EditBtn.ForeColor = Color.White;
            EditBtn.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            EditBtn.IconColor = Color.White;
            EditBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            EditBtn.IconSize = 30;
            EditBtn.Location = new Point(448, 35);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(60, 60);
            EditBtn.TabIndex = 3;
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += Btns_Click;
            // 
            // AddBtn
            // 
            AddBtn.Anchor = AnchorStyles.Right;
            AddBtn.BackColor = Color.Indigo;
            AddBtn.FlatAppearance.BorderSize = 0;
            AddBtn.FlatAppearance.MouseDownBackColor = Color.BlueViolet;
            AddBtn.FlatAppearance.MouseOverBackColor = Color.BlueViolet;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.ForeColor = Color.White;
            AddBtn.IconChar = FontAwesome.Sharp.IconChar.Add;
            AddBtn.IconColor = Color.White;
            AddBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AddBtn.IconSize = 30;
            AddBtn.Location = new Point(385, 35);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(60, 60);
            AddBtn.TabIndex = 2;
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += Btns_Click;
            // 
            // SearchTxt
            // 
            SearchTxt.Anchor = AnchorStyles.Left;
            SearchTxt.Location = new Point(132, 60);
            SearchTxt.Name = "SearchTxt";
            SearchTxt.Size = new Size(150, 29);
            SearchTxt.TabIndex = 1;
            SearchTxt.TextChanged += SearchTxt_TextChanged;
            // 
            // FieldsComboBox
            // 
            FieldsComboBox.Anchor = AnchorStyles.Left;
            FieldsComboBox.FormattingEnabled = true;
            FieldsComboBox.Location = new Point(30, 60);
            FieldsComboBox.Name = "FieldsComboBox";
            FieldsComboBox.Size = new Size(100, 29);
            FieldsComboBox.TabIndex = 0;
            FieldsComboBox.SelectedIndexChanged += FieldsComboBox_SelectedIndexChanged;
            // 
            // SearchLabel
            // 
            SearchLabel.Anchor = AnchorStyles.Left;
            SearchLabel.AutoSize = true;
            SearchLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            SearchLabel.Location = new Point(30, 30);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(78, 30);
            SearchLabel.TabIndex = 0;
            SearchLabel.Text = "Search";
            SearchLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            dataGridView.Location = new Point(0, 126);
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
            dataGridView.Size = new Size(600, 174);
            dataGridView.TabIndex = 1;
            dataGridView.TabStop = false;
            dataGridView.DataSourceChanged += DataGridView_DataSourceChanged;
            // 
            // NoDataLabel
            // 
            NoDataLabel.Anchor = AnchorStyles.None;
            NoDataLabel.AutoSize = true;
            NoDataLabel.BackColor = Color.White;
            NoDataLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            NoDataLabel.Location = new Point(240, 190);
            NoDataLabel.Name = "NoDataLabel";
            NoDataLabel.Size = new Size(108, 32);
            NoDataLabel.TabIndex = 2;
            NoDataLabel.Text = "No Data";
            // 
            // GridViewPage
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(NoDataLabel);
            Controls.Add(dataGridView);
            Controls.Add(LayoutPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "GridViewPage";
            Size = new Size(600, 300);
            Load += GridViewPage_Load;
            LayoutPanel.ResumeLayout(false);
            LayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel LayoutPanel;
        private DataGridView dataGridView;
        private Label SearchLabel;
        private ComboBox FieldsComboBox;
        private Components.CRoundButton AddBtn;
        private TextBox SearchTxt;
        private Components.CRoundButton EditBtn;
        private Components.CRoundButton DeleteBtn;
        private Label NoDataLabel;
    }
}
