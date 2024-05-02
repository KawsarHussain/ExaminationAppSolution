using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace ExaminationApp.ViewModel;

public partial class RegistrationViewModel : ObservableObject
{
    #region Attributes

    [ObservableProperty]
    string firstName;
    [ObservableProperty]
    string lastName;
    [ObservableProperty]
    string otherName;
    [ObservableProperty]
    string telephoneNumber;
    [ObservableProperty]
    string emailAddress;
    [ObservableProperty]
    string password;
    [ObservableProperty]
    string title;
    [ObservableProperty]
    string userType;

    #endregion

    public RegistrationViewModel() 
    { 
    
    }

    #region Page Methods
    [RelayCommand]
    public async void RegisterUser()
    {
        if (CheckIfNull())
        {
            return;
        }   
        await App.UserRepo.AddNewUser(
            FirstName, 
            LastName,
            OtherName,
            Title,
            EmailAddress,
            Password,
            TelephoneNumber,
            UserType);
    }

    #endregion

    #region Helper Methods
    //Checks to see if any of the required input values are null
    private bool CheckIfNull()
    {
        if (string.IsNullOrWhiteSpace(FirstName) ||
            string.IsNullOrWhiteSpace(LastName) ||
            string.IsNullOrWhiteSpace(TelephoneNumber) ||
            string.IsNullOrWhiteSpace(EmailAddress) ||
            string.IsNullOrWhiteSpace(Password) ||
            string.IsNullOrWhiteSpace(Title) ||
            string.IsNullOrWhiteSpace(UserType)) return false;

        return true;
    }

    #endregion
}
