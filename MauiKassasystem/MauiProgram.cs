using MauiKassasystem.Datenbank;
using Microsoft.AspNetCore.Components.WebView.Maui;

namespace MauiKassasystem;

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
#endif

        var dbPath = Path.Combine(FileSystem.AppDataDirectory, "mptest.db3");
        //var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"C:\Users\PC98FA9BFD51B5\Kassa007DBv9.3.db");
        builder.Services.AddSingleton<DatabaseContext>(s => ActivatorUtilities.CreateInstance<DatabaseContext>(s, dbPath));
		

        return builder.Build();
	}
}
