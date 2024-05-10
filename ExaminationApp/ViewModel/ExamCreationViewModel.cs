using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ExaminationApp.ViewModel;

partial class ExamCreationViewModel : ObservableObject, IFormHelper
{
    #region Attributes

    [ObservableProperty]
    string title;

    [ObservableProperty]
    int amountOfQuestions;

    #endregion

    public ExamCreationViewModel()
    {

    }

    [RelayCommand]
    async Task GoToExamForm()
    {
        //Creates the Array with the set number of exam questions
        App.SetExamParameters(title, amountOfQuestions);
        await Shell.Current.GoToAsync(nameof(ExamFormPage));
    }

    #region Helper Methods

    public bool CheckIfNull()
    {
        return string.IsNullOrWhiteSpace(Title) ||
            amountOfQuestions <= 0;
    }

    public void EmptyStrings()
    {
        Title = string.Empty;
        AmountOfQuestions = 0;
    }

    #endregion
}
