using Android.App;
using Android.Content.PM;
using Android.Content.Res;
using Android.OS;
using Google.Android.Material.BottomNavigation;
//using Android.Support.Design.Widget;
using Android.Widget;
using Microsoft.Maui;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;

namespace MauiKassasystem;

[Activity(Theme = "@style/Maui.SplashTheme", 
    MainLauncher = true, 
    ConfigurationChanges = 
    ConfigChanges.ScreenSize | 
    ConfigChanges.Orientation | 
    ConfigChanges.UiMode | 
    ConfigChanges.ScreenLayout | 
    ConfigChanges.SmallestScreenSize | 
    ConfigChanges.Density, 
    ScreenOrientation = ScreenOrientation.Landscape)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        global::Xamarin.Forms.Forms.SetFlags("CollectionView_Experimental");

        global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
        LoadApplication(new App());

        SetBottomNavigationViewColors();
    }

    private void SetBottomNavigationViewColors()
    {
        // Получаем ресурсные идентификаторы цветов из XML-файла ресурсов
        var resources = Resources;
        var backgroundColorId = resources.GetIdentifier("bottom_nav_background", "color", PackageName);
        var selectedColorId = resources.GetIdentifier("bottom_nav_selected", "color", PackageName);
        var backgroundColor = resources.GetColor(backgroundColorId);
        var selectedColor = resources.GetColor(selectedColorId);

        // Находим BottomNavigationView по идентификатору
        var bottomNavigationView = FindViewById<BottomNavigationView>(Resource.Id.bottom_navigation_view);

        // Устанавливаем цвет фона и выделения
        bottomNavigationView.SetBackgroundColor(backgroundColor);
        bottomNavigationView.ItemRippleColor = new ColorStateList(
            new int[][] { new int[] { } },
            new int[] { selectedColor }
        );
    }
}
