using Microsoft.Extensions.Logging;
using MovieApp.ViewModel;
using CommunityToolkit.Maui;

namespace MovieApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiApp<App>()
                .UseMauiCommunityToolkitMediaElement()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainViewModel>();

            builder.Services.AddTransient<DetailPage>();
            builder.Services.AddTransient<DetailPage2>();
            builder.Services.AddTransient<DetailPage3>();
            builder.Services.AddTransient<DetailPage4>();
            builder.Services.AddTransient<DetailPage5>();
            builder.Services.AddTransient<DetailPage6>();
            builder.Services.AddTransient<DetailPage7>();
            builder.Services.AddTransient<DetailPage8>();

            builder.Services.AddTransient<MoviePage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
