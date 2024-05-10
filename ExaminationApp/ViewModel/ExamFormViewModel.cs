using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExaminationApp.Models;

namespace ExaminationApp.ViewModel;

public partial class ExamFormViewModel : ObservableObject, IFormHelper
{
    [ObservableProperty]
    ExamQuestions[] examQuestions = App.ExamQuestionList;

    public ExamFormViewModel()
    {

    }

    [RelayCommand]
    public async Task Submit()
    {
        //Validation to check that the user submitting isn't a student
        if (App.LoginUser.UserType == UserType.Student)
            return;

        //Returns if any fields are Empty
        if (CheckIfNull())
            return;

        //Puts the exam into the Exam table
        await App.ExamRepo.AddNewExam(App.ExamTitle, ExamQuestions, App.LoginUser.Id);

        //Empties all fields
        EmptyStrings();

        //After the end of all that, the user is sent back to the dashboard
        await Shell.Current.GoToAsync(nameof(DashboardPage));
    }

    #region Helper Methods
    public bool CheckIfNull()
    {
        //Checks Each question to see if there is any null values
        foreach(var question in examQuestions)
        {
            if (string.IsNullOrWhiteSpace(question.Question) ||
                string.IsNullOrWhiteSpace(question.Answer))
                {
                    return true;
                }
        }
        //If none of the values are null, then it returns false
        return false;
    }

    public void EmptyStrings()
    {
        //Doing a for loop as it is not possible
        //to change values inside of a foreach loop 
        for (int i = 0; i < ExamQuestions.Length; i++)
        {
            ExamQuestions[i].Question = string.Empty;
            ExamQuestions[i].Answer = string.Empty;
        }
    }

    #endregion
}
