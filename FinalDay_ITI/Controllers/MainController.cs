using FinalDay_ITI.Models;
using FinalDay_ITI.Views;

namespace FinalDay_ITI.Controllers;

class MainController
{
    public static PharmacyContext? DB;
    public static Form? RunnerForm;
    public static Form? NextRunnerForm;

    public static void Run()
    {
        ApplicationConfiguration.Initialize();
        NextRunnerForm = new Intro();

        while (NextRunnerForm != null)
        {
            RunnerForm = NextRunnerForm;
            NextRunnerForm = null;
            Application.Run(RunnerForm);
        }
    }

    public static void SwitchToForm(Form? opening)
    {
        NextRunnerForm = opening;
        RunnerForm?.Close();
    }
}

