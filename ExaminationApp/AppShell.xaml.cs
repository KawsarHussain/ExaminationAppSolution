namespace ExaminationApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            //Adding routes to pages
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(RegistrationPage), typeof(RegistrationPage));
            Routing.RegisterRoute(nameof(DashboardPage), typeof(DashboardPage));
            Routing.RegisterRoute(nameof(ExamCreationPage), typeof(ExamCreationPage));
            Routing.RegisterRoute(nameof(ExamFormPage), typeof(ExamFormPage));
        }
    }
}
