using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using Services;
using ViewModels;
using Pages;
using Interfaces;
using System.Runtime.InteropServices;

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
            })
            .UseMauiCommunityToolkit();

            builder.Services.AddSingleton<IPlatformHttpMessageHandler>(sp =>
            {
#if ANDROID 
                return new Platforms.Android.AndroidHttpMessageHandler();
#elif IOS
                return new Platforms.iOS.IosHttpMessageHandler();
#else
                throw new PlatformNotSupportedException("fuc koff");
#endif
            });

            builder.Services.AddHttpClient(Constants.AppConstants.HttpClientName, httpClient =>
            {
                var baseAddress = DeviceInfo.Current.Platform == DevicePlatform.Android
                                    ? "https://10.0.2.2:12345"
                                    : "https://localhost:12345";
                httpClient.BaseAddress = new Uri(baseAddress);
            })
                .ConfigureHttpMessageHandlerBuilder(confifBuilder =>
                {
                    var platformHttpMessageHandler = confifBuilder.Services.GetRequiredService<IPlatformHttpMessageHandler>();
                    confifBuilder.PrimaryHandler = platformHttpMessageHandler.GetHttpMessageHandler();
                });

            builder.Services.AddSingleton<CategoryService>();
            builder.Services.AddSingleton<HomePageViewModel>();
            builder.Services.AddSingleton<HomePage>();
            builder.Services.AddTransient<OffersService>();

#if DEBUG
            builder.Logging.AddDebug();
#endif
            return builder.Build();
        }
    }
}