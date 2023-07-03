using PartsClient.Data;
using PartsClient.ViewModels;

namespace PartsClient;

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


        builder.Services.AddSingleton<HttpClient>();
        builder.Services.AddSingleton<PartsManager>();
        builder.Services.AddTransient<PartsViewModel>();
        builder.Services.AddTransient<AddPartViewModel>();

        return builder.Build();
    }
}
