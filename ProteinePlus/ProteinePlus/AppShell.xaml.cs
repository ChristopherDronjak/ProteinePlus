﻿using ProteinePlus.MVVM.Views;

namespace ProteinePlus
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
        }
    }
}