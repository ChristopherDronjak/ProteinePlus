using ProteinePlus.MVVM.ViewModels;
namespace ProteinePlus.MVVM.Views;

public partial class NavPage : ContentPage
{
    private NavViewModel _navViewModel = new NavViewModel();
    public NavPage()
    {
        InitializeComponent();
        BindingContext = _navViewModel;
    }
}
