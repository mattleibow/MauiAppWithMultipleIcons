namespace MauiAppWithMultipleIcons
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            CounterBtn.Text = "Icon is PURPLE now";
            CounterBtn2.Text = "Click for RED";

            SwapIcons("purple");
        }

        private void OnCounter2Clicked(object sender, EventArgs e)
        {
            CounterBtn.Text = "Click for PURPLE";
            CounterBtn2.Text = "Icon is RED now";
            
            SwapIcons("red");
        }

        void SwapIcons(string iconName)
        {
#if ANDROID
            var ctx = Android.App.Application.Context;
            var pm = ctx.PackageManager!;

            if (iconName == "purple")
            {
                pm.SetComponentEnabledSetting(
                    new Android.Content.ComponentName(ctx, ctx.PackageName + ".MainActivityAlias"),
                    Android.Content.PM.ComponentEnabledState.Enabled,
                    Android.Content.PM.ComponentEnableOption.DontKillApp);
                pm.SetComponentEnabledSetting(
                    new Android.Content.ComponentName(ctx, ctx.PackageName + ".MainActivityAlias2"),
                    Android.Content.PM.ComponentEnabledState.Disabled,
                    Android.Content.PM.ComponentEnableOption.DontKillApp);
            }
            else
            {
                pm.SetComponentEnabledSetting(
                    new Android.Content.ComponentName(ctx, ctx.PackageName + ".MainActivityAlias"),
                    Android.Content.PM.ComponentEnabledState.Disabled,
                    Android.Content.PM.ComponentEnableOption.DontKillApp);
                pm.SetComponentEnabledSetting(
                    new Android.Content.ComponentName(ctx, ctx.PackageName + ".MainActivityAlias2"),
                    Android.Content.PM.ComponentEnabledState.Enabled,
                    Android.Content.PM.ComponentEnableOption.DontKillApp);
            }
#endif
        }
    }
}
