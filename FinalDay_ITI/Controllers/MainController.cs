using FinalDay_ITI.Models;
using FinalDay_ITI.Views;

namespace FinalDay_ITI.Controllers;

class MainController
{
    public static PharmacyContext DB = new();
    public static Form? RunnerForm;

    public static void Run()
    {
        ApplicationConfiguration.Initialize();
        Form intro = new Intro();
        Application.Run(intro);

        while (RunnerForm != null)
        {
            Form form = RunnerForm;
            RunnerForm = null;
            Application.Run(form);
        }
    }

    public static void SwitchToForm(Form runnerForm, Form opening)
    {
        RunnerForm = opening;
        runnerForm?.Close();
    }
}

