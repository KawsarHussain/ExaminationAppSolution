using CommunityToolkit.Maui.Views;
using ExaminationApp.ViewModel;

namespace ExaminationApp;

public partial class CreatePost : Popup
{
	public CreatePost(CreatePostViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

    private void CloseWindow(object sender, EventArgs e)
    {
        this.Close();
    }
}