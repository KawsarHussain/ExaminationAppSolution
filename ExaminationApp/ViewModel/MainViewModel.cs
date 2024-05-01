using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace ExaminationApp.ViewModel;

public partial class MainViewModel : ObservableObject
{

    public MainViewModel()
    {

    }

    //Allows for the navigation to the login page
    [RelayCommand]
    async Task GoToLogin(string s)
    {
        await Shell.Current.GoToAsync(nameof(LoginPage));
    }
}
