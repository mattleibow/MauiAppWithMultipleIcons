using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;

namespace MauiAppWithMultipleIcons
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = EnableMainActivityMainLauncher, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    [Register("com.companyname.mauiappwithmultipleicons.MainActivity")]
    public class MainActivity : MauiAppCompatActivity
    {
#if DEBUG
        const bool EnableMainActivityMainLauncher = true;
#else
        const bool EnableMainActivityMainLauncher = false;
#endif
    }
}
