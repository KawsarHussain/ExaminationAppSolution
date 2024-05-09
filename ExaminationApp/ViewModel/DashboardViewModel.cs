using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Maui.Views;
using ExaminationApp.Models;
using CommunityToolkit.Mvvm.Input;

namespace ExaminationApp.ViewModel;

public partial class DashboardViewModel : ObservableObject
{

    #region Attributes

    [ObservableProperty]
    string title;
    [ObservableProperty]
    string body;
    [ObservableProperty]
    string type;

    [ObservableProperty]
    List<PostRecord> postList;


    #endregion
    public DashboardViewModel()
    {

    }

    [RelayCommand]
    public async Task ShowCreatePost()
    {
        var popup = new CreatePost();
        Shell.Current.CurrentPage.ShowPopup(popup);
    }

}
