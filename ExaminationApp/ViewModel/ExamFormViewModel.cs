using CommunityToolkit.Mvvm.ComponentModel;
using ExaminationApp.Models;

namespace ExaminationApp.ViewModel;

public partial class ExamFormViewModel : ObservableObject
{
    [ObservableProperty]
    ExamQuestions[] questions = App.ExamQuestionList;

}
