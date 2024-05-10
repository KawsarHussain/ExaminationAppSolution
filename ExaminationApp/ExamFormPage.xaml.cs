using ExaminationApp.ViewModel;

namespace ExaminationApp;

public partial class ExamFormPage : ContentPage
{
	public ExamFormPage(ExamFormViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}