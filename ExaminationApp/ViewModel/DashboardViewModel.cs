using CommunityToolkit.Mvvm.ComponentModel;
using ExaminationApp.Models;

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


}
