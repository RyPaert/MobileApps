using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using Services;
using ViewModels;
using Pages;

namespace GroceryApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>().ConfigureFonts(fonts =>
            {
                fonts.AddFont("Ubuntu-Regular.ttf", "UbuntuRegular");
                fonts.AddFont("Ubuntu-Bold.ttf", "UbuntuBold");
            }).UseMauiCommunityToolkit();
            builder.Services.AddSingleton<CategoryService>();
            builder.Services.AddSingleton<HomePageViewModel>();
            builder.Services.AddSingleton<HomePage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif
            return builder.Build();
        }
    }
}