using CommunityToolkit.Mvvm.Input;
using ExaminationApp.ViewModel;

namespace ExaminationApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }



    }

}
