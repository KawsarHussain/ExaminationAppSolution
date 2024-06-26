﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ExaminationApp.ViewModel;

public partial class CreatePostViewModel : ObservableObject, IFormHelper
{
    #region Attributes

    [ObservableProperty]
    string title;
    [ObservableProperty]
    string body;
    [ObservableProperty]
    string type;

    [ObservableProperty]
    List<string> typeOfPostList = new();

    #endregion

    public CreatePostViewModel()
    {
        //Based on the type of user the logged in user is,
        //different options are available
        if (App.LoginUser.UserType == Models.UserType.Student)
        {
            TypeOfPostList.Add("Comment");
            TypeOfPostList.Add("Update");
        }
        else
        {
            TypeOfPostList.Add("Assessment");
            TypeOfPostList.Add("Comment");
            TypeOfPostList.Add("Update");
        }
    }

    [RelayCommand]
    public async Task CreatePost()
    {
        //Return if any of the required fields are empty
        if (CheckIfNull())
        {
            return;
        }

        await App.PostRepo.AddNewPost(title, body, type, App.LoginUser.Id);

        EmptyStrings();

        //Retrieves the updated data of the dashboard posts
        await App.PostRepo.GetDashboardPosts();
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
