using ProteinePlus.MVVM.Models;

namespace ProteinePlus.MVVM.Views;

public partial class TicTacToeMain : ContentPage
{
	public TicTacToeMain()
	{
		InitializeComponent();
	}

    private async void OnModeClicked(object sender, EventArgs e)
    {
        // check which button was clicked
        Button button = (Button)sender;
        string mode = button.Text;

        if (mode == PlayerBtn.Text)
        {
            await Navigation.PushAsync(new TicTacToe(Mode.PLAYER));
        }
        else if (mode == BotBtn.Text)
        {
            await Navigation.PushAsync(new TicTacToe(Mode.BOT));
        }
    }
}