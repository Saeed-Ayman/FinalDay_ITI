namespace FinalDay_ITI.Views.User
{
    public partial class SettingsPage : UserControl
    {
        public SettingsPage()
        {
            InitializeComponent();

            Dock = DockStyle.Top;
            AutoScroll = true;
            Visible = false;
        }

        public override void Refresh()
        {
            base.Refresh();

            editInfo1.Refresh();
            editPassword1.Refresh();
            deleteAccount1.Refresh();
        }
    }
}
