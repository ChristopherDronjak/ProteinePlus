using ProteinePlus.MVVM.ViewModels;

namespace ProteinePlus.MVVM.Views;

public partial class NavPage : ContentPage
{


    public NavViewModel _navViewModel = new NavViewModel();

    public NavPage()
    {
        InitializeComponent();

    }

    private void closeButton_Clicked(object sender, EventArgs e)
    {

    }

    private void HomePage_Clicked(object sender, EventArgs e)
    {

        Navigation.PushAsync(new HomePage());

    }
}
