using FinalDay_ITI.Controllers;

namespace FinalDay_ITI.Views;

public partial class Intro : Form
{
    public Intro()
    {
        InitializeComponent();
        DbConnection_Thread.RunWorkerAsync();
    }

    private void DbConnection_Thread_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
        if (MainController.DB.Database.CanConnect())
        {
            AuthController.Run(this);
            e.Cancel = true;
            return;
        }

        var result = MessageBox.Show(
                "Error connection to database.\n\rMake sure database is exists and server running.",
                "Error",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Error
        );

        if (result == DialogResult.Retry) DbConnection_Thread_DoWork(sender, e);
        e.Cancel = true;
    }

    private void DbConnection_Thread_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e) => Close();
}
