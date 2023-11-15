using ProteinePlus.MVVM.ViewModels;
namespace ProteinePlus.MVVM.Views;

public partial class HomePage : ContentPage
{
    private HomeViewModel _homeViewModel = new HomeViewModel();
    public HomePage()
    {
        InitializeComponent();
        BindingContext = _homeViewModel;
    }
}