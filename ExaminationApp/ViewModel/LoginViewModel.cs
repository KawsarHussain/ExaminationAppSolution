using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExaminationApp.Models;

namespace ExaminationApp.ViewModel;

public partial class LoginViewModel : ObservableObject
{

    #region Attributes

    [ObservableProperty]
    string email;

    [ObservableProperty]
    string password;

    #endregion
    public LoginViewModel()
    {

    }

    //Allows for the navigation to the Registration page
    [RelayCommand]
    async Task GoToRegister(string s)
    {
        await Shell.Current.GoToAsync(nameof(RegistrationPage));
    }

    [RelayCommand]
    async Task Login()
    {
        //Checkes to see if any required fields are null
        if (CheckIfNull())
        {
            return;
        }

        UserRecord user = await App.UserRepo.GetUser(Email, Password);

        //If there isn't a match, user will be null
        if (user == null) { return; }

        //Sets the LoginUser attribute stored in App so that it can be used in multiple pages
        App.SetLoginUser(user);

        EmptyStrings();

        await Shell.Current.GoToAsync(nameof(DashboardPage));
    }

    #region HelperMethods

    private void EmptyStrings()
    {
        Email = string.Empty;
        Password = string.Empty;
    }

    private bool CheckIfNull()
    {
        return string.IsNullOrWhiteSpace(Email) ||
            string.IsNullOrWhiteSpace(Password);
    }

    #endregion
}
