using ExaminationApp.Models;
using ExaminationApp.ViewModel;

namespace ExaminationApp;

public partial class DashboardPage : ContentPage
{
	public DashboardPage(DashboardViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;

		//Adds in all the posts to the vm so that it can be used in the page
		if (App.PostRepo.Records != null)
		{
            foreach (var record in App.PostRepo.Records)
                vm.PostList.Add(record);
        }

		 
	}

}