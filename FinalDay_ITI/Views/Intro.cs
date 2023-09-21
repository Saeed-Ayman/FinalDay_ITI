using FinalDay_ITI.Controllers;
using FinalDay_ITI.Models;

namespace FinalDay_ITI.Views;

public partial class Intro : Form
{
    public Intro() => InitializeComponent();

    private void Intro_Shown(object sender, EventArgs e)
    {
        Thread thread = new(new ThreadStart(ConnectDB));
        thread.Start();
        thread.Join();

        if (MainController.DB == null) Close();
        else AuthController.Run();
    }

    public static void ConnectDB()
    {
        PharmacyContext pharmacyContext = new();

        if (pharmacyContext.Database.CanConnect())
        {
            MainController.DB = pharmacyContext;
            return;
        }

        DialogResult dialogResult = MessageBox.Show(
            "Error connection to database.\n\rMake sure database is exists and server running.",
            "Error",
            MessageBoxButtons.RetryCancel,
            MessageBoxIcon.Hand
        );

        if (dialogResult == DialogResult.Retry) ConnectDB();
    }
}
