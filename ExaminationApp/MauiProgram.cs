using Microsoft.Extensions.Logging;
using ExaminationApp.Models;
using ExaminationApp.ViewModel;
using CommunityToolkit.Maui;

namespace ExaminationApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            string dbPath = FileAccessHelper.GetLocalFilePath("User.db3");
            
            //Makes the user repository a singleton so that multiple versions of it do not exist improving consistency
            builder.Services.AddSingleton<UserRepository>(s => ActivatorUtilities.CreateInstance<UserRepository>(s, dbPath));

            dbPath = FileAccessHelper.GetLocalFilePath("Post.db3");

            //Makes the post repository a singleton so that multiple versions of it do not exist improving consistency
            builder.Services.AddSingleton<PostRepository>(s => ActivatorUtilities.CreateInstance<PostRepository>(s, dbPath));

            //Registering Data
            builder.Services.AddSingleton<UserRecord>();

            //Registering Pages and View Models
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainViewModel>();

            builder.Services.AddSingleton<LoginPage>();
            builder.Services.AddSingleton<LoginViewModel>();

            builder.Services.AddSingleton<RegistrationPage>();
            builder.Services.AddSingleton<RegistrationViewModel>();

            builder.Services.AddSingleton<DashboardPage>();
            builder.Services.AddSingleton<DashboardViewModel>();

            return builder.Build();
        }
    }
}
