using ProteinePlus.MVVM.Views;
using ProteinePlus.MVVM.ViewModels;

namespace ProteinePlus;
public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new NavigationPage(new HomePage());
        BindingContext = new HomeViewModel();
    }
}
