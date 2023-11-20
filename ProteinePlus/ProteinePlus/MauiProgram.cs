using Microsoft.Extensions.Logging;
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

            
            
            builder.Services.AddTransient<HomePage>();
            builder.Services.AddTransient<HomeViewModel>();  
            
            builder.Services.AddTransient<CalorieTrack>();
            builder.Services.AddTransient<CalorieTrackViewModel>();

            builder.Services.AddTransient<WorkoutCreation>();
            builder.Services.AddTransient<WorkoutCreViewModel>();


            return builder.Build();
        }
    }
}