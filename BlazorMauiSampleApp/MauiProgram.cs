using BlazorMauiSampleApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SharedClassLibrary.Infrastructure.Store_Context;

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
            var connectionString = builder.Configuration.GetConnectionString("DevConnection");
            builder.Services.AddDbContext<StoreContext>(x => x.UseSqlServer(connectionString));


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
