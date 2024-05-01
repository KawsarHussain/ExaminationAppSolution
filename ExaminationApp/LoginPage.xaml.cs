using ExaminationApp.ViewModel;

namespace ExaminationApp;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginViewModel vm)
	{
        InitializeComponent();
		BindingContext = vm;
	}

}