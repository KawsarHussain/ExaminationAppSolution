using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace ExaminationApp.ViewModel;

public partial class LoginViewModel : ObservableObject
{

    public LoginViewModel()
    {

    }

    //Allows for the navigation to the Registration page
    [RelayCommand]
    async Task GoToRegister(string s)
    {
        await Shell.Current.GoToAsync(nameof(RegistrationPage));
    }
}
