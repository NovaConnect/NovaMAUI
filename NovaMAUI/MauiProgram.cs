using Microsoft.Extensions.Logging;
using NovaMAUI.Runtimes;
using System.Diagnostics;

namespace NovaMAUI
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
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif



            return builder.Build();
        }
        public static class Functions
        {
            public static bool CheckNetworkAccess()
            {
                NetworkAccess accessType = Connectivity.Current.NetworkAccess;
                if (accessType == NetworkAccess.Internet)
                    return true;
                else
                    return false;
            }
        }
    }
}