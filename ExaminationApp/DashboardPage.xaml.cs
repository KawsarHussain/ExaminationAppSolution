using ExaminationApp.ViewModel;

namespace ExaminationApp;

public partial class DashboardPage : ContentPage
{
	public DashboardPage(DashboardViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;

		//Adds in all the posts to the vm so that it can be used in the page
		vm.CoursePosts.AddRange((IEnumerable<Models.CoursePost>)App.PostRepo.GetDashboardPosts());
	}
}