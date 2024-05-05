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

    //This method registers a user to the UserRepository databsse which is stored locally
    [RelayCommand]
    public async Task RegisterUser()
    {
        //Checks to see if any required fields are null
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

        EmptyStrings();
    }

    #endregion

    #region Helper Methods
    //Checks to see if any of the required input values are null
    private bool CheckIfNull()
    {
        return string.IsNullOrWhiteSpace(FirstName) ||
            string.IsNullOrWhiteSpace(LastName) ||
            string.IsNullOrWhiteSpace(TelephoneNumber) ||
            string.IsNullOrWhiteSpace(EmailAddress) ||
            string.IsNullOrWhiteSpace(Password) ||
            string.IsNullOrWhiteSpace(Title) ||
            string.IsNullOrWhiteSpace(UserType);

    }

    //Emptys the string values of binded properties
    private void EmptyStrings()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
        OtherName = string.Empty;
        Title = string.Empty;
        EmailAddress = string.Empty;
        Password = string.Empty;
        TelephoneNumber = string.Empty;
        UserType = string.Empty;
    }

    #endregion
}
