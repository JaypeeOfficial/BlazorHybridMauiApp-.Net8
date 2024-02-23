using BlazorMauiSampleApp.Data;
using Microsoft.Extensions.Logging;

namespace BlazorMauiSampleApp
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

            builder.Services.AddSingleton<TodoService>();
            builder.Services.AddSingleton<IConnectivity>(c =>
              Connectivity.Current);
#endif

            return builder.Build();
        }
    }
}
