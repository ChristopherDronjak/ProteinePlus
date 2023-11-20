using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProteinePlus.MVVM.Models
{
    public partial class GameBoard : ObservableObject
    {
        // Kotlin init
        public GameBoard(int index)
        {
            Index = index;
        }

        public int Index { get; set; }

        [ObservableProperty]
        private string _selectedType;

        public int? Player { get; set; }
    }
}
