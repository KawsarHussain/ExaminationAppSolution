using ExaminationApp.ViewModel;

namespace ExaminationApp;

public partial class ExamCreationPage : ContentPage
{
	public ExamCreationPage(ExamCreationViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}