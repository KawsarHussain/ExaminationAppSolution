using ExaminationApp.Models;

namespace ExaminationApp
{
    public partial class App : Application
    {
        public static UserRepository UserRepo { get; private set; }
        public static PostRepository PostRepo { get; private set; }
        public static UserRecord LoginUser { get; private set; }

        public static string ExamTitle { get; private set; }
        public static ExamQuestions[] ExamQuestionList { get; private set; }
        
        public App(UserRepository users, PostRepository posts, UserRecord loginUser)
        {
            InitializeComponent();

            MainPage = new AppShell();

            //Connects the tables to the applications
            UserRepo = users;
            PostRepo = posts;
            LoginUser = loginUser;
        }

        //Create a setter for the LoginUser whenever the user logs in
        public static void SetLoginUser(UserRecord loginUser)
        {
            LoginUser = loginUser;
        }

        //Creates a list with the number of Exam Questions the Exam has
        public static void SetExamParameters(string title,int amount)
        {
            ExamTitle = title;
            ExamQuestionList = new ExamQuestions[amount];
        }
    }
}
