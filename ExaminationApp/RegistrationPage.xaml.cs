using ExaminationApp.ViewModel;

namespace ExaminationApp;

public partial class RegistrationPage : ContentPage
{
	public RegistrationPage(RegistrationViewModel vm)
	{
        InitializeComponent();
		BindingContext = vm;
	}
}