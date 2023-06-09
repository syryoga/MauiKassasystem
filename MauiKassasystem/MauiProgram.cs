﻿using MauiKassasystem.Datenbank;
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

        var platform = DeviceInfo.Current.Platform;

        var dbPath = "";

        // Möchte man eine neue Datenbank haben dann hier den dbFileName z.B.:"kassadbWien.sqlite" einfach umbenennen!. 
        var dbFileName = "kassadb15.sqlite";

        if (platform == DevicePlatform.Android)
        {
            dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), dbFileName);
        }
        else if (platform == DevicePlatform.WinUI)
        {
            //dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"C:\Users\PC98FA9BFD51B5\Kassa007DBv9.3.db");
            dbPath = Path.Combine(FileSystem.AppDataDirectory, dbFileName);
        }
        else
        {
            throw new Exception("Platform not supported");
        }

        builder.Services.AddSingleton<DatabaseContext>(s => ActivatorUtilities.CreateInstance<DatabaseContext>(s, dbPath));
        return builder.Build();
    }
}
