﻿using Microsoft.Extensions.Logging;
using ProteinePlus.MVVM.Views;
using ProteinePlus.MVVM.ViewModels;

namespace ProteinePlus
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<NavPage>();
            builder.Services.AddSingleton<NavViewModel>();
            
            
            builder.Services.AddTransient<HomePage>();
            builder.Services.AddTransient<HomeViewModel>();


            return builder.Build();
        }
    }
}