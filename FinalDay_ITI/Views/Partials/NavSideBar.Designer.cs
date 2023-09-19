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
            HistoryBtn = new FontAwesome.Sharp.IconButton();
            CreateOrderBtn = new FontAwesome.Sharp.IconButton();
            OrdersBtn = new FontAwesome.Sharp.IconButton();
            MedicinesBtn = new FontAwesome.Sharp.IconButton();
            CategoriesBtn = new FontAwesome.Sharp.IconButton();
            UsersBtn = new FontAwesome.Sharp.IconButton();
            HomeBtn = new FontAwesome.Sharp.IconButton();
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
            SettingsBtn.Location = new Point(0, 440);
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
            // HistoryBtn
            // 
            HistoryBtn.BackColor = Color.Indigo;
            HistoryBtn.Dock = DockStyle.Top;
            HistoryBtn.FlatAppearance.BorderSize = 0;
            HistoryBtn.FlatStyle = FlatStyle.Flat;
            HistoryBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            HistoryBtn.IconChar = FontAwesome.Sharp.IconChar.Inbox;
            HistoryBtn.IconColor = Color.White;
            HistoryBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            HistoryBtn.IconSize = 35;
            HistoryBtn.ImageAlign = ContentAlignment.MiddleLeft;
            HistoryBtn.Location = new Point(0, 360);
            HistoryBtn.Name = "HistoryBtn";
            HistoryBtn.Padding = new Padding(20, 0, 10, 0);
            HistoryBtn.Size = new Size(300, 60);
            HistoryBtn.TabIndex = 7;
            HistoryBtn.Text = "History";
            HistoryBtn.TextAlign = ContentAlignment.MiddleLeft;
            HistoryBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            HistoryBtn.UseVisualStyleBackColor = false;
            HistoryBtn.Click += Btn_Click;
            // 
            // CreateOrderBtn
            // 
            CreateOrderBtn.BackColor = Color.Indigo;
            CreateOrderBtn.Dock = DockStyle.Top;
            CreateOrderBtn.FlatAppearance.BorderSize = 0;
            CreateOrderBtn.FlatStyle = FlatStyle.Flat;
            CreateOrderBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CreateOrderBtn.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            CreateOrderBtn.IconColor = Color.White;
            CreateOrderBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            CreateOrderBtn.IconSize = 35;
            CreateOrderBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CreateOrderBtn.Location = new Point(0, 300);
            CreateOrderBtn.Name = "CreateOrderBtn";
            CreateOrderBtn.Padding = new Padding(20, 0, 10, 0);
            CreateOrderBtn.Size = new Size(300, 60);
            CreateOrderBtn.TabIndex = 6;
            CreateOrderBtn.Text = "Create Order";
            CreateOrderBtn.TextAlign = ContentAlignment.MiddleLeft;
            CreateOrderBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            CreateOrderBtn.UseVisualStyleBackColor = false;
            CreateOrderBtn.Click += Btn_Click;
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
            OrdersBtn.Location = new Point(0, 240);
            OrdersBtn.Name = "OrdersBtn";
            OrdersBtn.Padding = new Padding(20, 0, 10, 0);
            OrdersBtn.Size = new Size(300, 60);
            OrdersBtn.TabIndex = 5;
            OrdersBtn.Text = "Orders";
            OrdersBtn.TextAlign = ContentAlignment.MiddleLeft;
            OrdersBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            OrdersBtn.UseVisualStyleBackColor = false;
            OrdersBtn.Click += Btn_Click;
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
            // NavSideBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Indigo;
            Controls.Add(HistoryBtn);
            Controls.Add(CreateOrderBtn);
            Controls.Add(OrdersBtn);
            Controls.Add(MedicinesBtn);
            Controls.Add(CategoriesBtn);
            Controls.Add(UsersBtn);
            Controls.Add(HomeBtn);
            Controls.Add(SettingsBtn);
            ForeColor = Color.White;
            Name = "NavSideBar";
            Size = new Size(300, 500);
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton SettingsBtn;
        private FontAwesome.Sharp.IconButton HistoryBtn;
        public FontAwesome.Sharp.IconButton CreateOrderBtn;
        private FontAwesome.Sharp.IconButton OrdersBtn;
        private FontAwesome.Sharp.IconButton MedicinesBtn;
        private FontAwesome.Sharp.IconButton CategoriesBtn;
        private FontAwesome.Sharp.IconButton UsersBtn;
        private FontAwesome.Sharp.IconButton HomeBtn;
    }
}
