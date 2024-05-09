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

    private void btnclose_Clicked(object sender, EventArgs e)
    {
        this.Close();
    }
}