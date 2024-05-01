namespace ExaminationApp
{
    public partial class App : Application
    {
        public static UserRepository UserRepo { get; private set; }
        public static PostRepository PostRepo { get; private set; }
        public App(UserRepository users, PostRepository posts)
        {
            InitializeComponent();

            MainPage = new AppShell();

            //Connects the tables to the applications
            UserRepo = users;
            PostRepo = posts;
        }
    }
}
