using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Maui.Views;
using ExaminationApp.Models;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace ExaminationApp.ViewModel;

public partial class DashboardViewModel : ObservableObject, FormHelper
{

    #region Attributes

    [ObservableProperty]
    ObservableCollection<PostRecord> postList = new();

    #endregion
    public DashboardViewModel()
    {

    }


    //Method Allows for the opening of the CreatePost popup page
    [RelayCommand]
    public void ShowCreatePost()
    {
        var popup = new CreatePost(new CreatePostViewModel());
        Shell.Current.CurrentPage.ShowPopup(popup);
    }

    [RelayCommand]
    public void RefreshPage()
    {
        this.postList.Clear();
        if (App.PostRepo.DashboardPosts != null)
        {
            foreach (var record in App.PostRepo.DashboardPosts)
                this.PostList.Add(record);
        }
    }


    #region Helper Methods

    public bool CheckIfNull()
    {
        throw new NotImplementedException();
    }

    public void EmptyStrings()
    {
        throw new NotImplementedException();
    }

    #endregion

}
