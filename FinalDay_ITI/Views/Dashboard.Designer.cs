namespace FinalDay_ITI.Views
{
    partial class Dashboard
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
            dashboardHeader = new Partials.DashboardHeader();
            navSideBar1 = new Partials.NavSideBar();
            LayoutPanel = new Panel();
            SuspendLayout();
            // 
            // dashboardHeader
            // 
            dashboardHeader.BackColor = Color.Indigo;
            dashboardHeader.Dock = DockStyle.Top;
            dashboardHeader.Location = new Point(0, 0);
            dashboardHeader.Name = "dashboardHeader";
            dashboardHeader.Size = new Size(1009, 74);
            dashboardHeader.TabIndex = 0;
            // 
            // navSideBar1
            // 
            navSideBar1.AutoScroll = true;
            navSideBar1.BackColor = Color.Indigo;
            navSideBar1.Dock = DockStyle.Left;
            navSideBar1.ForeColor = Color.White;
            navSideBar1.Location = new Point(0, 74);
            navSideBar1.Name = "navSideBar1";
            navSideBar1.Size = new Size(289, 523);
            navSideBar1.TabIndex = 1;
            // 
            // LayoutPanel
            // 
            LayoutPanel.AutoScroll = true;
            LayoutPanel.Dock = DockStyle.Fill;
            LayoutPanel.Location = new Point(289, 74);
            LayoutPanel.Name = "LayoutPanel";
            LayoutPanel.Size = new Size(720, 523);
            LayoutPanel.TabIndex = 2;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);
            Controls.Add(LayoutPanel);
            Controls.Add(navSideBar1);
            Controls.Add(dashboardHeader);
            MinimumSize = new Size(600, 400);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Partials.DashboardHeader dashboardHeader;
        public Partials.NavSideBar navSideBar1;
        private Panel LayoutPanel;
    }
}