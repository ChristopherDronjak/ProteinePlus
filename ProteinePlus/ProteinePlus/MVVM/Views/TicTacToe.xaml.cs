using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using ProteinePlus.MVVM.Models;
using ProteinePlus.MVVM.ViewModels;

namespace ProteinePlus.MVVM.Views;

public partial class TicTacToe : ContentPage
{
    public TicTacToe(Mode mode)
    {
        InitializeComponent();
        LabelTitle.Text = "Current Mode: " + mode;
        BindingContext = new TicTacToeViewModel(mode);
    }
}