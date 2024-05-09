using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ExaminationApp.ViewModel;

public partial class CreatePostViewModel : ObservableObject, FormHelper
{
    #region Attributes

    [ObservableProperty]
    string title;
    [ObservableProperty]
    string body;
    [ObservableProperty]
    string type;

    #endregion

    public CreatePostViewModel()
    {

    }

    #region Helper Methods

    public bool CheckIfNull()
    {
        return string.IsNullOrWhiteSpace(Title) ||
            string.IsNullOrWhiteSpace(Body) ||
            string.IsNullOrWhiteSpace(Type);
    }

    public void EmptyStrings()
    {
        Title = string.Empty;
        Body = string.Empty;
        Type = string.Empty;
    }

    #endregion
}
