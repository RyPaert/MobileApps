using CommunityToolkit.Maui;
using Services;
using ViewModels;
using Pages;
using Interfaces;
using Microsoft.Extensions.Logging;

namespace GroceryApp
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
                    fonts.AddFont("Ubuntu-Regular.ttf", "UbuntuRegular");
                    fonts.AddFont("Ubuntu-Bold.ttf", "UbuntuBold");
                })
                .UseMauiCommunityToolkit();

            builder.Services.AddHttpClient(Constants.AppConstants.HttpClientName, httpClient =>
            {
                var baseAddress = DeviceInfo.Platform == DevicePlatform.Android
                    ? "https://10.0.2.2:12345"
                    : "https://localhost:12345";
                httpClient.BaseAddress = new Uri(baseAddress);
            });

            builder.Services.AddSingleton<CategoryService>();
            builder.Services.AddTransient<ProductsService>();
            builder.Services.AddTransient<OffersService>();
            builder.Services.AddSingleton<HomePageViewModel>();
            builder.Services.AddSingleton<HomePage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}