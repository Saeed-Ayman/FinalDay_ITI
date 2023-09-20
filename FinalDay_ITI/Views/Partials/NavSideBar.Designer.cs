namespace FinalDay_ITI.Views.Partials
{
    partial class NavSideBar
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
            SettingsBtn = new FontAwesome.Sharp.IconButton();
            MedicinesBtn = new FontAwesome.Sharp.IconButton();
            CategoriesBtn = new FontAwesome.Sharp.IconButton();
            UsersBtn = new FontAwesome.Sharp.IconButton();
            HomeBtn = new FontAwesome.Sharp.IconButton();
            ExpiredMedicinesBtn = new FontAwesome.Sharp.IconButton();
            OutOfStocksBtn = new FontAwesome.Sharp.IconButton();
            MyOrdersBtn = new FontAwesome.Sharp.IconButton();
            OrdersBtn = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // SettingsBtn
            // 
            SettingsBtn.BackColor = Color.Indigo;
            SettingsBtn.Dock = DockStyle.Bottom;
            SettingsBtn.FlatAppearance.BorderSize = 0;
            SettingsBtn.FlatStyle = FlatStyle.Flat;
            SettingsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SettingsBtn.IconChar = FontAwesome.Sharp.IconChar.Gears;
            SettingsBtn.IconColor = Color.White;
            SettingsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SettingsBtn.IconSize = 35;
            SettingsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            SettingsBtn.Location = new Point(0, 531);
            SettingsBtn.Name = "SettingsBtn";
            SettingsBtn.Padding = new Padding(20, 0, 10, 0);
            SettingsBtn.Size = new Size(300, 60);
            SettingsBtn.TabIndex = 1;
            SettingsBtn.Text = "Settings";
            SettingsBtn.TextAlign = ContentAlignment.MiddleLeft;
            SettingsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            SettingsBtn.UseVisualStyleBackColor = false;
            SettingsBtn.Click += Btn_Click;
            // 
            // MedicinesBtn
            // 
            MedicinesBtn.BackColor = Color.Indigo;
            MedicinesBtn.Dock = DockStyle.Top;
            MedicinesBtn.FlatAppearance.BorderSize = 0;
            MedicinesBtn.FlatStyle = FlatStyle.Flat;
            MedicinesBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MedicinesBtn.IconChar = FontAwesome.Sharp.IconChar.Medkit;
            MedicinesBtn.IconColor = Color.White;
            MedicinesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MedicinesBtn.IconSize = 35;
            MedicinesBtn.ImageAlign = ContentAlignment.MiddleLeft;
            MedicinesBtn.Location = new Point(0, 180);
            MedicinesBtn.Name = "MedicinesBtn";
            MedicinesBtn.Padding = new Padding(20, 0, 10, 0);
            MedicinesBtn.Size = new Size(300, 60);
            MedicinesBtn.TabIndex = 4;
            MedicinesBtn.Text = "Medicines";
            MedicinesBtn.TextAlign = ContentAlignment.MiddleLeft;
            MedicinesBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            MedicinesBtn.UseVisualStyleBackColor = false;
            MedicinesBtn.Click += Btn_Click;
            // 
            // CategoriesBtn
            // 
            CategoriesBtn.BackColor = Color.Indigo;
            CategoriesBtn.Dock = DockStyle.Top;
            CategoriesBtn.FlatAppearance.BorderSize = 0;
            CategoriesBtn.FlatStyle = FlatStyle.Flat;
            CategoriesBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CategoriesBtn.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            CategoriesBtn.IconColor = Color.White;
            CategoriesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            CategoriesBtn.IconSize = 35;
            CategoriesBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CategoriesBtn.Location = new Point(0, 120);
            CategoriesBtn.Name = "CategoriesBtn";
            CategoriesBtn.Padding = new Padding(20, 0, 10, 0);
            CategoriesBtn.Size = new Size(300, 60);
            CategoriesBtn.TabIndex = 3;
            CategoriesBtn.Text = "Categories";
            CategoriesBtn.TextAlign = ContentAlignment.MiddleLeft;
            CategoriesBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            CategoriesBtn.UseVisualStyleBackColor = false;
            CategoriesBtn.Click += Btn_Click;
            // 
            // UsersBtn
            // 
            UsersBtn.BackColor = Color.Indigo;
            UsersBtn.Dock = DockStyle.Top;
            UsersBtn.FlatAppearance.BorderSize = 0;
            UsersBtn.FlatStyle = FlatStyle.Flat;
            UsersBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UsersBtn.IconChar = FontAwesome.Sharp.IconChar.Users;
            UsersBtn.IconColor = Color.White;
            UsersBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            UsersBtn.IconSize = 35;
            UsersBtn.ImageAlign = ContentAlignment.MiddleLeft;
            UsersBtn.Location = new Point(0, 60);
            UsersBtn.Name = "UsersBtn";
            UsersBtn.Padding = new Padding(20, 0, 10, 0);
            UsersBtn.Size = new Size(300, 60);
            UsersBtn.TabIndex = 2;
            UsersBtn.Text = "Users";
            UsersBtn.TextAlign = ContentAlignment.MiddleLeft;
            UsersBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            UsersBtn.UseVisualStyleBackColor = false;
            UsersBtn.Click += Btn_Click;
            // 
            // HomeBtn
            // 
            HomeBtn.BackColor = Color.BlueViolet;
            HomeBtn.Dock = DockStyle.Top;
            HomeBtn.FlatAppearance.BorderSize = 0;
            HomeBtn.FlatStyle = FlatStyle.Flat;
            HomeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            HomeBtn.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            HomeBtn.IconColor = Color.White;
            HomeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            HomeBtn.IconSize = 35;
            HomeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            HomeBtn.Location = new Point(0, 0);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Padding = new Padding(20, 0, 10, 0);
            HomeBtn.Size = new Size(300, 60);
            HomeBtn.TabIndex = 0;
            HomeBtn.Text = "Home";
            HomeBtn.TextAlign = ContentAlignment.MiddleLeft;
            HomeBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            HomeBtn.UseVisualStyleBackColor = false;
            HomeBtn.Click += Btn_Click;
            // 
            // ExpiredMedicinesBtn
            // 
            ExpiredMedicinesBtn.BackColor = Color.Indigo;
            ExpiredMedicinesBtn.Dock = DockStyle.Top;
            ExpiredMedicinesBtn.FlatAppearance.BorderSize = 0;
            ExpiredMedicinesBtn.FlatStyle = FlatStyle.Flat;
            ExpiredMedicinesBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ExpiredMedicinesBtn.IconChar = FontAwesome.Sharp.IconChar.Capsules;
            ExpiredMedicinesBtn.IconColor = Color.White;
            ExpiredMedicinesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ExpiredMedicinesBtn.IconSize = 35;
            ExpiredMedicinesBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ExpiredMedicinesBtn.Location = new Point(0, 240);
            ExpiredMedicinesBtn.Name = "ExpiredMedicinesBtn";
            ExpiredMedicinesBtn.Padding = new Padding(20, 0, 10, 0);
            ExpiredMedicinesBtn.Size = new Size(300, 60);
            ExpiredMedicinesBtn.TabIndex = 8;
            ExpiredMedicinesBtn.Text = "Expired Medicines";
            ExpiredMedicinesBtn.TextAlign = ContentAlignment.MiddleLeft;
            ExpiredMedicinesBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            ExpiredMedicinesBtn.UseVisualStyleBackColor = false;
            ExpiredMedicinesBtn.Click += Btn_Click;
            // 
            // OutOfStocksBtn
            // 
            OutOfStocksBtn.BackColor = Color.Indigo;
            OutOfStocksBtn.Dock = DockStyle.Top;
            OutOfStocksBtn.FlatAppearance.BorderSize = 0;
            OutOfStocksBtn.FlatStyle = FlatStyle.Flat;
            OutOfStocksBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            OutOfStocksBtn.IconChar = FontAwesome.Sharp.IconChar.StoreSlash;
            OutOfStocksBtn.IconColor = Color.White;
            OutOfStocksBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            OutOfStocksBtn.IconSize = 35;
            OutOfStocksBtn.ImageAlign = ContentAlignment.MiddleLeft;
            OutOfStocksBtn.Location = new Point(0, 300);
            OutOfStocksBtn.Name = "OutOfStocksBtn";
            OutOfStocksBtn.Padding = new Padding(20, 0, 10, 0);
            OutOfStocksBtn.Size = new Size(300, 60);
            OutOfStocksBtn.TabIndex = 9;
            OutOfStocksBtn.Text = "Out of Stocks";
            OutOfStocksBtn.TextAlign = ContentAlignment.MiddleLeft;
            OutOfStocksBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            OutOfStocksBtn.UseVisualStyleBackColor = false;
            OutOfStocksBtn.Click += Btn_Click;
            // 
            // MyOrdersBtn
            // 
            MyOrdersBtn.BackColor = Color.Indigo;
            MyOrdersBtn.Dock = DockStyle.Top;
            MyOrdersBtn.FlatAppearance.BorderSize = 0;
            MyOrdersBtn.FlatStyle = FlatStyle.Flat;
            MyOrdersBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MyOrdersBtn.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            MyOrdersBtn.IconColor = Color.White;
            MyOrdersBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            MyOrdersBtn.IconSize = 35;
            MyOrdersBtn.ImageAlign = ContentAlignment.MiddleLeft;
            MyOrdersBtn.Location = new Point(0, 420);
            MyOrdersBtn.Name = "MyOrdersBtn";
            MyOrdersBtn.Padding = new Padding(20, 0, 10, 0);
            MyOrdersBtn.Size = new Size(300, 60);
            MyOrdersBtn.TabIndex = 11;
            MyOrdersBtn.Text = "MyOrders";
            MyOrdersBtn.TextAlign = ContentAlignment.MiddleLeft;
            MyOrdersBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            MyOrdersBtn.UseVisualStyleBackColor = false;
            MyOrdersBtn.Click += Btn_Click;
            // 
            // OrdersBtn
            // 
            OrdersBtn.BackColor = Color.Indigo;
            OrdersBtn.Dock = DockStyle.Top;
            OrdersBtn.FlatAppearance.BorderSize = 0;
            OrdersBtn.FlatStyle = FlatStyle.Flat;
            OrdersBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            OrdersBtn.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            OrdersBtn.IconColor = Color.White;
            OrdersBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            OrdersBtn.IconSize = 35;
            OrdersBtn.ImageAlign = ContentAlignment.MiddleLeft;
            OrdersBtn.Location = new Point(0, 360);
            OrdersBtn.Name = "OrdersBtn";
            OrdersBtn.Padding = new Padding(20, 0, 10, 0);
            OrdersBtn.Size = new Size(300, 60);
            OrdersBtn.TabIndex = 10;
            OrdersBtn.Text = "Orders";
            OrdersBtn.TextAlign = ContentAlignment.MiddleLeft;
            OrdersBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            OrdersBtn.UseVisualStyleBackColor = false;
            OrdersBtn.Click += Btn_Click;
            // 
            // NavSideBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Indigo;
            Controls.Add(MyOrdersBtn);
            Controls.Add(OrdersBtn);
            Controls.Add(OutOfStocksBtn);
            Controls.Add(ExpiredMedicinesBtn);
            Controls.Add(MedicinesBtn);
            Controls.Add(CategoriesBtn);
            Controls.Add(UsersBtn);
            Controls.Add(HomeBtn);
            Controls.Add(SettingsBtn);
            ForeColor = Color.White;
            Name = "NavSideBar";
            Size = new Size(300, 591);
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton SettingsBtn;
        private FontAwesome.Sharp.IconButton MedicinesBtn;
        private FontAwesome.Sharp.IconButton CategoriesBtn;
        private FontAwesome.Sharp.IconButton UsersBtn;
        private FontAwesome.Sharp.IconButton HomeBtn;
        private FontAwesome.Sharp.IconButton ExpiredMedicinesBtn;
        private FontAwesome.Sharp.IconButton OutOfStocksBtn;
        private FontAwesome.Sharp.IconButton MyOrdersBtn;
        private FontAwesome.Sharp.IconButton OrdersBtn;
    }
}
